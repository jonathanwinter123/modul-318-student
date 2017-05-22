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
    public partial class mainFormSwissTransport : Form
    {
        //instantiate Transport class for getting the data
        private Transport getTransportData = new Transport();

        //NewLine variable for easier code
        private string nl = Environment.NewLine;

        private string noConnectionsForEnteredKeywordError = "Für diese Eingaben gibt es leider keine Verbindungen.";
        private string fillAllFieldsError = "Bitte füllen Sie alle Felder aus.";

        public mainFormSwissTransport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setControlInMainFormToFormSize();
            dtpTripTimePicker.Format = DateTimePickerFormat.Time;
            dtpTripTimePicker.ShowUpDown = true;

            dgvTripShowFoundTrips.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDepShowFoundDepartures.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var currentClientLocation = GetCurrentClientLocation();

            gmapDepLocationMap.MapProvider = GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmapDepLocationMap.Position = new GMap.NET.PointLatLng(currentClientLocation.Latitude,currentClientLocation.Longitude);
        }

        private void setControlInMainFormToFormSize(object sender = null, EventArgs e = null)
        {
            tabControlMainForm.Size = this.Size;
            dgvTripShowFoundTrips.Width = this.Width;
            dgvDepShowFoundDepartures.Width = this.Width;
        }

        private GeoCoordinate GetCurrentClientLocation()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            watcher.TryStart(true, TimeSpan.FromMilliseconds(0));
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

        private void getStationsForComboBoxDropdownIfQueryIsLongerThanFourChars(object sender, EventArgs e)
        {
            ComboBox currentCombobox = (ComboBox)sender;
            currentCombobox.Items.Clear();
            if (currentCombobox.Text.Length >= 4)
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
                cmbTripDepartureStation.Items.Add("Bitte mindestens vier Zeichen eingeben.");
            }
        }

        private void btnTripSwitchArrivalAndDepartureStations_Click(object sender, EventArgs e)
        {
            string oldDepartureStation = cmbTripDepartureStation.Text;
            string oldArrivalStation = cmbTripArrivalStation.Text;

            cmbTripDepartureStation.Text = oldArrivalStation;
            cmbTripArrivalStation.Text = oldDepartureStation;
        }

        private void btnTripSearch_Click(object sender, EventArgs e)
        {
            removePreviousEntries(dgvTripShowFoundTrips);
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

        private void removePreviousEntries(DataGridView dgvToDeletePreviousEntries)
        {
            while (dgvToDeletePreviousEntries.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row in dgvToDeletePreviousEntries.Rows)
                    dgvToDeletePreviousEntries.Rows.Remove(row);
            }
        }

        private string FormatUserDateTime(DateTimePicker dtpDate, DateTimePicker dtpTime)
        {
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string time = dtpTime.Value.ToString("HH:mm");
            string dateTime = date + "+" + time;
            return dateTime;
        }

        private string FormatApiDate(DateTime dateAndTime)
        {
            return dateAndTime.ToString("dd.MM.yyy" + nl + "HH:mm");

        }

        private void btnDepSearch_Click(object sender, EventArgs e)
        {
            removePreviousEntries(dgvDepShowFoundDepartures);

            ComboBox currentCombobox = cmbDepDepartureStation;
            var foundStationsWithKeyWord = getTransportData.GetStations(currentCombobox.Text);

            var objectOfSearchedStation = foundStationsWithKeyWord.StationList.First(x => x.Name == currentCombobox.Text);

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

        private void btnTripSendMail_Click(object sender, EventArgs e)
        {
            sendConnectionsViaMailForm sendMailForm = new sendConnectionsViaMailForm(dgvTripShowFoundTrips);
            sendMailForm.ShowDialog();
        }
    }
}
