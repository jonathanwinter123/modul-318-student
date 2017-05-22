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

namespace SwissTransport.WinFormsUI
{
    public partial class mainFormSwissTransport : Form
    {
        //instantiate Transport class for getting the data
        private Transport getTransportData = new Transport();

        //NewLine variable for easier code
        private string nl = Environment.NewLine;

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
        }

        private void mainFormSwissTransport_SizeChanged(object sender, EventArgs e)
        {
            setControlInMainFormToFormSize();
        }

        private void setControlInMainFormToFormSize()
        {
            tabControlMainForm.Size = this.Size;
            dgvTripShowFoundTrips.Width = this.Width;
        }

        private void getStationsForComboBoxDropdownIfQueryIsLongerThanFourChars(object sender, EventArgs e)
        {
            ComboBox currentCombobox = (ComboBox)sender;
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

            if (cmbTripArrivalStation.Text != String.Empty && cmbTripDepartureStation.Text != String.Empty && dtpTripDatePicker.Value != null && dtpTripTimePicker.Value != null)
            {
                string date = dtpTripDatePicker.Value.ToString("yyyy-MM-dd");
                string time = dtpTripTimePicker.Value.ToString("HH:mm");

                var resultDataFromQuery = getTransportData.GetConnections(cmbTripDepartureStation.Text, cmbTripArrivalStation.Text, date, time);

                if (resultDataFromQuery != null)
                {
                    foreach (var item in resultDataFromQuery.ConnectionList)
                    {
                        DateTime unformattedDepartureDateTime = DateTime.Parse(item.From.Departure);
                        DateTime unformattedArrivalDateTime = DateTime.Parse(item.To.Arrival);
                        string departureDateTime = unformattedDepartureDateTime.ToString("dd.MM.yyy" + nl + "HH:mm");
                        string departureStation = item.From.Station.Name;
                        string arrivalDateTime = unformattedArrivalDateTime.ToString("dd.MM.yyy" + nl + "HH:mm");
                        string arrivalStation = item.To.Station.Name;

                        this.dgvTripShowFoundTrips.Rows.Add(departureStation + nl + nl + departureDateTime, arrivalStation + nl + nl + arrivalDateTime, "seven", "eight");
                    }
                }
                else
                    MessageBox.Show("Für diese Eingaben gibt es leider keine Verbindungen.");
            }
            else
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");

            btnTripSendMail.Enabled = true;
        }

        private void btnDepSearch_Click(object sender, EventArgs e)
        {
            while (dgvDepShowFoundDepartures.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row in dgvDepShowFoundDepartures.Rows)
                {
                    dgvDepShowFoundDepartures.Rows.Remove(row);
                }
            } 

            ComboBox currentCombobox = cmbDepDepartureStation;
            var foundStationsWithKeyWord = getTransportData.GetStations(currentCombobox.Text);

            var objectOfSearchedStation = foundStationsWithKeyWord.StationList.First(x => x.Name == currentCombobox.Text);

            string idOfSearchedStation = objectOfSearchedStation.Id;

            if (cmbDepDepartureStation.Text != "" && dtpDepDatePicker.Value != null && dtpDepTimePicker.Value != null)
            {
                string date = dtpDepDatePicker.Value.ToString("yyyy-MM-dd");
                string time = dtpDepTimePicker.Value.ToString("HH:mm");

                var resultDataFromQuery = getTransportData.GetStationBoard(cmbTripDepartureStation.Text, idOfSearchedStation, date, time);

                if (resultDataFromQuery != null)
                {
                    foreach (var item in resultDataFromQuery.Entries)
                    {
                        DateTime unformattedDepartureDateTime = DateTime.Parse(item.Stop.Departure.ToShortDateString());
                        string departureDateTime = unformattedDepartureDateTime.ToString("dd.MM.yyy" + nl + "HH:mm");
                        string departureStation = item.Stop.Station.Name;
                        string typeTransport = item.Name;

                        this.dgvDepShowFoundDepartures.Rows.Add(typeTransport, departureStation + nl + nl + departureDateTime, item.To);
                    }
                }
                else
                    MessageBox.Show("Für diese Eingaben gibt es leider keine Verbindungen.");
            }
            else
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
        }

        private void cmbTripDepartureStation_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void btnTripSendMail_Click(object sender, EventArgs e)
        {

        }
    }
}
