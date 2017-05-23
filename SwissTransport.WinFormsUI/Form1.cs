using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using System.Device.Location;

namespace SwissTransport.WinFormsUI
{
    public partial class MainFormSwissTransport : Form
    {
        //instantiate Transport class for getting the data
        private Transport getTransportData = new Transport();

        //NewLine variable for easier code
        private string nl = Environment.NewLine;

        //Error messages
        private string noConnectionsForEnteredKeywordError = "Für diese Eingaben gibt es leider keine Verbindungen.";
        private string fillAllFieldsError = "Bitte füllen Sie alle Felder aus.";
        private string minThreeLettersError = "Min. drei Zeichen eingeben.";
        private string stationNotFoundError = "Station nicht gefunden";

        public MainFormSwissTransport()
        {
            InitializeComponent();
        }

        //Load event of main form
        /*
         * <summary>
         *      Setting tabControl and datagridviews to the same size/width as the form.
         *      Setting the timePicker to time format
         *      Setting the defaultCellStyle to wrapMode, this is needed to allow multiline values in a cell
         *      Getting the current location initializing the map with the current coordinates or with the coordinates from Lucerne.
         * </summary>
         */
        private void MainFormSwissTransport_Load(object sender, EventArgs e)
        {
            SetControlInMainFormToFormSize();
            dtpTripTimePicker.Format = DateTimePickerFormat.Time;
            dtpTripTimePicker.ShowUpDown = true;

            dgvTripShowFoundTrips.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDepShowFoundDepartures.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var currentClientLocation = GetCurrentClientLocation();

            gmapDepLocationMap.MapProvider = GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;          //Gets map always from the server to ensure that correct map is used
            gmapDepLocationMap.Position = new GMap.NET.PointLatLng(currentClientLocation.Latitude,currentClientLocation.Longitude);
        }

        /*
         * <summary>
         *      Set tabControl to form size and dgv widths to form width
         * </summary>
         */
        private void SetControlInMainFormToFormSize(object sender = null, EventArgs e = null)
        {
            tabControlMainForm.Size = this.Size;
            dgvTripShowFoundTrips.Width = this.Width;
            dgvDepShowFoundDepartures.Width = this.Width;
        }

        /*
         * <summary>
         *      Get current location if device has gps otherwise give back coordinates of Lucerne
         * </summary>
         */
        private GeoCoordinate GetCurrentClientLocation()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            watcher.TryStart(true, TimeSpan.FromMilliseconds(5000));
            GeoCoordinate coord = watcher.Position.Location;

            if (coord.IsUnknown != true)
            {
                return coord;
            }
            else
            {
                coord.Latitude = 47.0502;
                coord.Longitude = 8.3093;
                return coord;
            }
        }

        /*
         * <summary>
         *      Clears all Combobox items, then gets Stations which match the entered value and adds them as combobox items
         *      Needs at least 3 characters
         * </summary>
         */
        private void GetStationsForComboBoxDropdownIfQueryIsLongerThanThreeChars(object sender, EventArgs e)
        {
            ComboBox currentCombobox = (ComboBox)sender;
            currentCombobox.Items.Clear();
            if (currentCombobox.Text.Length >= 3)
            {
                currentCombobox.Items.Add("Loading...");

                var foundStationsWithPartialKeyWord = getTransportData.GetStations(currentCombobox.Text);

                foreach (var stationName in foundStationsWithPartialKeyWord.StationList)
                {
                    currentCombobox.Items.Add(stationName.Name);
                }
                currentCombobox.Items.Remove("Loading...");
            }
            else
            {
                cmbTripDepartureStation.Items.Add(minThreeLettersError);
            }
        }

        /*
         * <summary>
         *      Switches entered stations in the Trips tab
         * </summary>
         */
        private void BtnTripSwitchArrivalAndDepartureStations_Click(object sender, EventArgs e)
        {
            string oldDepartureStation = cmbTripDepartureStation.Text;
            string oldArrivalStation = cmbTripArrivalStation.Text;

            cmbTripDepartureStation.Text = oldArrivalStation;
            cmbTripArrivalStation.Text = oldDepartureStation;
        }

        /*
         * <summary>
         *      Click event of the Search button in the trip tab calls this function
         *      Removes previous items of the DataGridView, checks if the fields are empty and gets the api data
         *      Formats the datetime and fills the data in the datagridview
         * </summary>
         */
        private void BtnTripSearch_Click(object sender, EventArgs e)
        {
            RemovePreviousEntries(dgvTripShowFoundTrips);

            if (cmbTripArrivalStation.Text != String.Empty && cmbTripDepartureStation.Text != String.Empty && dtpTripDatePicker.Value != null && dtpTripTimePicker.Value != null)
            {
                string dateTime = FormatUserDateTime(dtpTripDatePicker, dtpTripTimePicker);

                var resultDataFromQuery = getTransportData.GetConnections(cmbTripDepartureStation.Text, cmbTripArrivalStation.Text, dateTime);

                if (resultDataFromQuery != null)
                {
                    foreach (var item in resultDataFromQuery.ConnectionList)
                    {
                        DateTime unformattedDepartureDateTime = DateTime.Parse(item.From.Departure);
                        DateTime unformattedArrivalDateTime = DateTime.Parse(item.To.Arrival);
                        string departureDateTime = FormatApiDate(unformattedDepartureDateTime);
                        string departureStation = item.From.Station.Name;
                        string arrivalDateTime = FormatApiDate(unformattedArrivalDateTime);
                        string arrivalStation = item.To.Station.Name;

                        this.dgvTripShowFoundTrips.Rows.Add(departureStation + nl + nl + departureDateTime, arrivalStation + nl + nl + arrivalDateTime);
                    }
                }
                else
                    MessageBox.Show(noConnectionsForEnteredKeywordError);
            }
            else
                MessageBox.Show(fillAllFieldsError);

            btnTripSendMail.Enabled = true;
        }
        /// <summary>
        ///     Removes all items of a DataGridView
        /// </summary>
        /// <param name="dgvToDeletePreviousEntries"></param>
        private void RemovePreviousEntries(DataGridView dgvToDeletePreviousEntries)
        {
            while (dgvToDeletePreviousEntries.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row in dgvToDeletePreviousEntries.Rows)
                    dgvToDeletePreviousEntries.Rows.Remove(row);
            }
        }

        /// <summary>
        ///     Formats the date and time for the api request
        /// </summary>
        /// <param name="dtpDate"></param>
        /// <param name="dtpTime"></param>
        /// <returns></returns>
        private string FormatUserDateTime(DateTimePicker dtpDate, DateTimePicker dtpTime)
        {
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string time = dtpTime.Value.ToString("HH:mm");
            string dateTime = date + "+" + time;
            return dateTime;
        }

        /// <summary>
        ///     Formats the api date and time to swiss standard date and time
        /// </summary>
        /// <param name="dateAndTime"></param>
        /// <returns></returns>
        private string FormatApiDate(DateTime dateAndTime)
        {
            return dateAndTime.ToString("dd.MM.yyy" + nl + "HH:mm");

        }

        /*
         * <summary>
         *      Click event of the Search button in the departure tab calls this function
         *      Gets the id of a station by checking for a match between name and stationlist - this is needed for the api request of the stationboard
         *      Removes previous items of the DataGridView, checks if the fields are empty and gets the api data
         *      Formats the datetime and fills the data in the datagridview
         * </summary>
         */
        private void BtnDepSearch_Click(object sender, EventArgs e)
        {
            RemovePreviousEntries(dgvDepShowFoundDepartures);

            ComboBox currentCombobox = cmbDepDepartureStation;
            var foundStationsWithKeyWord = getTransportData.GetStations(currentCombobox.Text);

            Station objectOfSearchedStation = null;

            try
            {
                objectOfSearchedStation = foundStationsWithKeyWord.StationList.First(x => x.Name == currentCombobox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(stationNotFoundError);
                currentCombobox.Items.Clear();
                currentCombobox.Text = "";
            }

            string idOfSearchedStation = objectOfSearchedStation.Id;

            if (cmbDepDepartureStation.Text != "" && dtpDepDatePicker.Value != null && dtpDepTimePicker.Value != null)
            {
                string dateTime = FormatUserDateTime(dtpDepDatePicker, dtpDepTimePicker);

                var resultDataFromQuery = getTransportData.GetStationBoard(cmbTripDepartureStation.Text, idOfSearchedStation, dateTime);

                if (resultDataFromQuery != null)
                {
                    foreach (var item in resultDataFromQuery.Entries)
                    {
                        string departureDateTime = FormatApiDate(item.Stop.Departure);
                        string departureStation = item.Stop.Station.Name;
                        string typeTransport = item.Name;

                        this.dgvDepShowFoundDepartures.Rows.Add(typeTransport, departureStation + nl + nl + departureDateTime, item.To);
                    }
                }
                else
                    MessageBox.Show(noConnectionsForEnteredKeywordError);
            }
            else
                MessageBox.Show(fillAllFieldsError);
        }

        /// <summary>
        ///     Opens a new form to send the connections data as a mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTripSendMail_Click(object sender, EventArgs e)
        {
            SendConnectionsViaMailForm sendMailForm = new SendConnectionsViaMailForm(dgvTripShowFoundTrips);
            sendMailForm.ShowDialog();
        }
    }
}
