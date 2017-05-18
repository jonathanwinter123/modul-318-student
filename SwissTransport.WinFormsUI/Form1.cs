using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport.WinFormsUI
{
    public partial class mainFormSwissTransport : Form
    {
        //instantiate Transport class for getting the data
        private Transport getTransportData = new Transport();

        public mainFormSwissTransport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setTabControlMainFormToFormSize();

        }

        private void mainFormSwissTransport_SizeChanged(object sender, EventArgs e)
        {
            setTabControlMainFormToFormSize();
        }

        private void setTabControlMainFormToFormSize()
        {
            tabControlMainForm.Size = this.Size;
        }

        private void getStationsForComboBoxDropdownIfQueryIsLongerThanFourChars(object sender, EventArgs e)
        {
            if (cmbTripDepartureStation.Text.Length >= 4)
            {
                cmbTripDepartureStation.Items.Add("Loading...");

                var foundStationsWithPartialKeyWord = getTransportData.GetStations(cmbTripDepartureStation.Text);

                foreach (var stationName in foundStationsWithPartialKeyWord.StationList)
                {
                    cmbTripDepartureStation.Items.Add(stationName.Name);
                }
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

            if (cmbTripArrivalStation.Text != "" && cmbTripDepartureStation.Text != "" && dtpDepDatePicker.Value != null && dtpDepTimePicker.Value != null)
            {
                string date = String.Format("yyyy-mm-dd", dtpDepDatePicker.Value);

                var resultDataFromQuery = getTransportData.GetConnections(cmbTripDepartureStation.Text, cmbTripArrivalStation.Text, date, dtpDepTimePicker.Value.ToString());

                if (resultDataFromQuery != null)
                {
                    foreach (var item in resultDataFromQuery.ConnectionList)
                    {
                        string depConnectionsDateTime = DateTime.Parse(item.From.Departure).ToString();
                        string[] departureTripsConnections = {depConnectionsDateTime};
                        ListViewItem lvi = new ListViewItem();
                    }
                }
                else
                    MessageBox.Show("Für diese Eingaben gibt es leider keine Verbindungen.");
            }
            else
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
        }
    }
}
