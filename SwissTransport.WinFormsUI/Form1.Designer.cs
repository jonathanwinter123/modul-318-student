namespace SwissTransport.WinFormsUI
{
    partial class mainFormSwissTransport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTripDepartureStation = new System.Windows.Forms.Label();
            this.lblTripArrivalStation = new System.Windows.Forms.Label();
            this.btnTripSwitchArrivalAndDepartureStations = new System.Windows.Forms.Button();
            this.tabControlMainForm = new System.Windows.Forms.TabControl();
            this.tabTripPage = new System.Windows.Forms.TabPage();
            this.btnTripSearch = new System.Windows.Forms.Button();
            this.lblShownTrips = new System.Windows.Forms.Label();
            this.lblTripTimePicker = new System.Windows.Forms.Label();
            this.lblTripDatePicker = new System.Windows.Forms.Label();
            this.dtpTripTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dtpTripDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbTripArrivalStation = new System.Windows.Forms.ComboBox();
            this.cmbTripDepartureStation = new System.Windows.Forms.ComboBox();
            this.tabDeparturePage = new System.Windows.Forms.TabPage();
            this.btnDepSearch = new System.Windows.Forms.Button();
            this.lblDepTimePicker = new System.Windows.Forms.Label();
            this.lblDepDatePicker = new System.Windows.Forms.Label();
            this.dtpDepTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dtpDepDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbDepDepartureStation = new System.Windows.Forms.ComboBox();
            this.lblDepDepartureStation = new System.Windows.Forms.Label();
            this.lblDepFoundResults = new System.Windows.Forms.Label();
            this.lstDepFoundResults = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmTripDepartureLocationAndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTripArrivalLocationAndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTripTransportationType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlMainForm.SuspendLayout();
            this.tabTripPage.SuspendLayout();
            this.tabDeparturePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTripDepartureStation
            // 
            this.lblTripDepartureStation.AutoSize = true;
            this.lblTripDepartureStation.Location = new System.Drawing.Point(8, 15);
            this.lblTripDepartureStation.Name = "lblTripDepartureStation";
            this.lblTripDepartureStation.Size = new System.Drawing.Size(80, 13);
            this.lblTripDepartureStation.TabIndex = 1;
            this.lblTripDepartureStation.Text = "Abfahrtsstation:";
            // 
            // lblTripArrivalStation
            // 
            this.lblTripArrivalStation.AutoSize = true;
            this.lblTripArrivalStation.Location = new System.Drawing.Point(192, 15);
            this.lblTripArrivalStation.Name = "lblTripArrivalStation";
            this.lblTripArrivalStation.Size = new System.Drawing.Size(83, 13);
            this.lblTripArrivalStation.TabIndex = 3;
            this.lblTripArrivalStation.Text = "Ankunftsstation:";
            // 
            // btnTripSwitchArrivalAndDepartureStations
            // 
            this.btnTripSwitchArrivalAndDepartureStations.Location = new System.Drawing.Point(144, 31);
            this.btnTripSwitchArrivalAndDepartureStations.Name = "btnTripSwitchArrivalAndDepartureStations";
            this.btnTripSwitchArrivalAndDepartureStations.Size = new System.Drawing.Size(36, 20);
            this.btnTripSwitchArrivalAndDepartureStations.TabIndex = 4;
            this.btnTripSwitchArrivalAndDepartureStations.Text = "<-->";
            this.btnTripSwitchArrivalAndDepartureStations.UseVisualStyleBackColor = true;
            this.btnTripSwitchArrivalAndDepartureStations.Click += new System.EventHandler(this.btnTripSwitchArrivalAndDepartureStations_Click);
            // 
            // tabControlMainForm
            // 
            this.tabControlMainForm.Controls.Add(this.tabTripPage);
            this.tabControlMainForm.Controls.Add(this.tabDeparturePage);
            this.tabControlMainForm.Location = new System.Drawing.Point(0, 1);
            this.tabControlMainForm.Name = "tabControlMainForm";
            this.tabControlMainForm.SelectedIndex = 0;
            this.tabControlMainForm.Size = new System.Drawing.Size(412, 433);
            this.tabControlMainForm.TabIndex = 5;
            // 
            // tabTripPage
            // 
            this.tabTripPage.Controls.Add(this.listView1);
            this.tabTripPage.Controls.Add(this.btnTripSearch);
            this.tabTripPage.Controls.Add(this.lblShownTrips);
            this.tabTripPage.Controls.Add(this.lblTripTimePicker);
            this.tabTripPage.Controls.Add(this.lblTripDatePicker);
            this.tabTripPage.Controls.Add(this.dtpTripTimePicker);
            this.tabTripPage.Controls.Add(this.dtpTripDatePicker);
            this.tabTripPage.Controls.Add(this.cmbTripArrivalStation);
            this.tabTripPage.Controls.Add(this.cmbTripDepartureStation);
            this.tabTripPage.Controls.Add(this.btnTripSwitchArrivalAndDepartureStations);
            this.tabTripPage.Controls.Add(this.lblTripDepartureStation);
            this.tabTripPage.Controls.Add(this.lblTripArrivalStation);
            this.tabTripPage.Location = new System.Drawing.Point(4, 22);
            this.tabTripPage.Name = "tabTripPage";
            this.tabTripPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTripPage.Size = new System.Drawing.Size(404, 407);
            this.tabTripPage.TabIndex = 0;
            this.tabTripPage.Text = "Trips";
            this.tabTripPage.UseVisualStyleBackColor = true;
            // 
            // btnTripSearch
            // 
            this.btnTripSearch.Location = new System.Drawing.Point(195, 93);
            this.btnTripSearch.Name = "btnTripSearch";
            this.btnTripSearch.Size = new System.Drawing.Size(75, 23);
            this.btnTripSearch.TabIndex = 13;
            this.btnTripSearch.Text = "Suchen";
            this.btnTripSearch.UseVisualStyleBackColor = true;
            this.btnTripSearch.Click += new System.EventHandler(this.btnTripSearch_Click);
            // 
            // lblShownTrips
            // 
            this.lblShownTrips.AutoSize = true;
            this.lblShownTrips.Location = new System.Drawing.Point(3, 183);
            this.lblShownTrips.Name = "lblShownTrips";
            this.lblShownTrips.Size = new System.Drawing.Size(132, 13);
            this.lblShownTrips.TabIndex = 12;
            this.lblShownTrips.Text = "Gefundene Verbindungen:";
            // 
            // lblTripTimePicker
            // 
            this.lblTripTimePicker.AutoSize = true;
            this.lblTripTimePicker.Location = new System.Drawing.Point(111, 81);
            this.lblTripTimePicker.Name = "lblTripTimePicker";
            this.lblTripTimePicker.Size = new System.Drawing.Size(43, 13);
            this.lblTripTimePicker.TabIndex = 10;
            this.lblTripTimePicker.Text = "Uhrzeit:";
            // 
            // lblTripDatePicker
            // 
            this.lblTripDatePicker.AutoSize = true;
            this.lblTripDatePicker.Location = new System.Drawing.Point(8, 81);
            this.lblTripDatePicker.Name = "lblTripDatePicker";
            this.lblTripDatePicker.Size = new System.Drawing.Size(41, 13);
            this.lblTripDatePicker.TabIndex = 9;
            this.lblTripDatePicker.Text = "Datum:";
            // 
            // dtpTripTimePicker
            // 
            this.dtpTripTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTripTimePicker.Location = new System.Drawing.Point(114, 97);
            this.dtpTripTimePicker.Name = "dtpTripTimePicker";
            this.dtpTripTimePicker.Size = new System.Drawing.Size(66, 20);
            this.dtpTripTimePicker.TabIndex = 8;
            // 
            // dtpTripDatePicker
            // 
            this.dtpTripDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTripDatePicker.Location = new System.Drawing.Point(7, 97);
            this.dtpTripDatePicker.Name = "dtpTripDatePicker";
            this.dtpTripDatePicker.Size = new System.Drawing.Size(80, 20);
            this.dtpTripDatePicker.TabIndex = 7;
            // 
            // cmbTripArrivalStation
            // 
            this.cmbTripArrivalStation.FormattingEnabled = true;
            this.cmbTripArrivalStation.Location = new System.Drawing.Point(195, 33);
            this.cmbTripArrivalStation.Name = "cmbTripArrivalStation";
            this.cmbTripArrivalStation.Size = new System.Drawing.Size(121, 21);
            this.cmbTripArrivalStation.TabIndex = 6;
            this.cmbTripArrivalStation.DropDown += new System.EventHandler(this.getStationsForComboBoxDropdownIfQueryIsLongerThanFourChars);
            // 
            // cmbTripDepartureStation
            // 
            this.cmbTripDepartureStation.FormattingEnabled = true;
            this.cmbTripDepartureStation.Location = new System.Drawing.Point(7, 32);
            this.cmbTripDepartureStation.Name = "cmbTripDepartureStation";
            this.cmbTripDepartureStation.Size = new System.Drawing.Size(121, 21);
            this.cmbTripDepartureStation.TabIndex = 5;
            this.cmbTripDepartureStation.DropDown += new System.EventHandler(this.getStationsForComboBoxDropdownIfQueryIsLongerThanFourChars);
            // 
            // tabDeparturePage
            // 
            this.tabDeparturePage.Controls.Add(this.lblDepFoundResults);
            this.tabDeparturePage.Controls.Add(this.lstDepFoundResults);
            this.tabDeparturePage.Controls.Add(this.btnDepSearch);
            this.tabDeparturePage.Controls.Add(this.lblDepTimePicker);
            this.tabDeparturePage.Controls.Add(this.lblDepDatePicker);
            this.tabDeparturePage.Controls.Add(this.dtpDepTimePicker);
            this.tabDeparturePage.Controls.Add(this.dtpDepDatePicker);
            this.tabDeparturePage.Controls.Add(this.cmbDepDepartureStation);
            this.tabDeparturePage.Controls.Add(this.lblDepDepartureStation);
            this.tabDeparturePage.Location = new System.Drawing.Point(4, 22);
            this.tabDeparturePage.Name = "tabDeparturePage";
            this.tabDeparturePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeparturePage.Size = new System.Drawing.Size(404, 407);
            this.tabDeparturePage.TabIndex = 1;
            this.tabDeparturePage.Text = "Abfahrtsmonitor";
            this.tabDeparturePage.UseVisualStyleBackColor = true;
            // 
            // btnDepSearch
            // 
            this.btnDepSearch.Location = new System.Drawing.Point(295, 30);
            this.btnDepSearch.Name = "btnDepSearch";
            this.btnDepSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDepSearch.TabIndex = 23;
            this.btnDepSearch.Text = "Suchen";
            this.btnDepSearch.UseVisualStyleBackColor = true;
            // 
            // lblDepTimePicker
            // 
            this.lblDepTimePicker.AutoSize = true;
            this.lblDepTimePicker.Location = new System.Drawing.Point(220, 17);
            this.lblDepTimePicker.Name = "lblDepTimePicker";
            this.lblDepTimePicker.Size = new System.Drawing.Size(43, 13);
            this.lblDepTimePicker.TabIndex = 22;
            this.lblDepTimePicker.Text = "Uhrzeit:";
            // 
            // lblDepDatePicker
            // 
            this.lblDepDatePicker.AutoSize = true;
            this.lblDepDatePicker.Location = new System.Drawing.Point(138, 17);
            this.lblDepDatePicker.Name = "lblDepDatePicker";
            this.lblDepDatePicker.Size = new System.Drawing.Size(41, 13);
            this.lblDepDatePicker.TabIndex = 21;
            this.lblDepDatePicker.Text = "Datum:";
            // 
            // dtpDepTimePicker
            // 
            this.dtpDepTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDepTimePicker.Location = new System.Drawing.Point(223, 33);
            this.dtpDepTimePicker.Name = "dtpDepTimePicker";
            this.dtpDepTimePicker.Size = new System.Drawing.Size(66, 20);
            this.dtpDepTimePicker.TabIndex = 20;
            // 
            // dtpDepDatePicker
            // 
            this.dtpDepDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepDatePicker.Location = new System.Drawing.Point(137, 33);
            this.dtpDepDatePicker.Name = "dtpDepDatePicker";
            this.dtpDepDatePicker.Size = new System.Drawing.Size(80, 20);
            this.dtpDepDatePicker.TabIndex = 19;
            // 
            // cmbDepDepartureStation
            // 
            this.cmbDepDepartureStation.FormattingEnabled = true;
            this.cmbDepDepartureStation.Location = new System.Drawing.Point(8, 32);
            this.cmbDepDepartureStation.Name = "cmbDepDepartureStation";
            this.cmbDepDepartureStation.Size = new System.Drawing.Size(121, 21);
            this.cmbDepDepartureStation.TabIndex = 17;
            this.cmbDepDepartureStation.DropDown += new System.EventHandler(this.getStationsForComboBoxDropdownIfQueryIsLongerThanFourChars);
            // 
            // lblDepDepartureStation
            // 
            this.lblDepDepartureStation.AutoSize = true;
            this.lblDepDepartureStation.Location = new System.Drawing.Point(9, 15);
            this.lblDepDepartureStation.Name = "lblDepDepartureStation";
            this.lblDepDepartureStation.Size = new System.Drawing.Size(80, 13);
            this.lblDepDepartureStation.TabIndex = 14;
            this.lblDepDepartureStation.Text = "Abfahrtsstation:";
            // 
            // lblDepFoundResults
            // 
            this.lblDepFoundResults.AutoSize = true;
            this.lblDepFoundResults.Location = new System.Drawing.Point(3, 76);
            this.lblDepFoundResults.Name = "lblDepFoundResults";
            this.lblDepFoundResults.Size = new System.Drawing.Size(102, 13);
            this.lblDepFoundResults.TabIndex = 25;
            this.lblDepFoundResults.Text = "Gefundene Fahrten:";
            // 
            // lstDepFoundResults
            // 
            this.lstDepFoundResults.FormattingEnabled = true;
            this.lstDepFoundResults.Location = new System.Drawing.Point(0, 92);
            this.lstDepFoundResults.Name = "lstDepFoundResults";
            this.lstDepFoundResults.Size = new System.Drawing.Size(404, 316);
            this.lstDepFoundResults.TabIndex = 24;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTripTransportationType,
            this.clmTripDepartureLocationAndTime,
            this.clmTripArrivalLocationAndTime});
            this.listView1.Location = new System.Drawing.Point(0, 210);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 194);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmTripDepartureLocationAndTime
            // 
            this.clmTripDepartureLocationAndTime.Text = "Abfahrt";
            this.clmTripDepartureLocationAndTime.Width = 121;
            // 
            // clmTripArrivalLocationAndTime
            // 
            this.clmTripArrivalLocationAndTime.Text = "Ankunft";
            this.clmTripArrivalLocationAndTime.Width = 112;
            // 
            // clmTripTransportationType
            // 
            this.clmTripTransportationType.Text = "Typ";
            // 
            // mainFormSwissTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 459);
            this.Controls.Add(this.tabControlMainForm);
            this.Name = "mainFormSwissTransport";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.mainFormSwissTransport_SizeChanged);
            this.tabControlMainForm.ResumeLayout(false);
            this.tabTripPage.ResumeLayout(false);
            this.tabTripPage.PerformLayout();
            this.tabDeparturePage.ResumeLayout(false);
            this.tabDeparturePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTripDepartureStation;
        private System.Windows.Forms.Label lblTripArrivalStation;
        private System.Windows.Forms.Button btnTripSwitchArrivalAndDepartureStations;
        private System.Windows.Forms.TabControl tabControlMainForm;
        private System.Windows.Forms.TabPage tabTripPage;
        private System.Windows.Forms.TabPage tabDeparturePage;
        private System.Windows.Forms.DateTimePicker dtpTripDatePicker;
        private System.Windows.Forms.ComboBox cmbTripArrivalStation;
        private System.Windows.Forms.ComboBox cmbTripDepartureStation;
        private System.Windows.Forms.DateTimePicker dtpTripTimePicker;
        private System.Windows.Forms.Label lblTripTimePicker;
        private System.Windows.Forms.Label lblTripDatePicker;
        private System.Windows.Forms.Label lblShownTrips;
        private System.Windows.Forms.Button btnTripSearch;
        private System.Windows.Forms.Label lblDepFoundResults;
        private System.Windows.Forms.ListBox lstDepFoundResults;
        private System.Windows.Forms.Button btnDepSearch;
        private System.Windows.Forms.Label lblDepTimePicker;
        private System.Windows.Forms.Label lblDepDatePicker;
        private System.Windows.Forms.DateTimePicker dtpDepTimePicker;
        private System.Windows.Forms.DateTimePicker dtpDepDatePicker;
        private System.Windows.Forms.ComboBox cmbDepDepartureStation;
        private System.Windows.Forms.Label lblDepDepartureStation;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmTripTransportationType;
        private System.Windows.Forms.ColumnHeader clmTripDepartureLocationAndTime;
        private System.Windows.Forms.ColumnHeader clmTripArrivalLocationAndTime;
    }
}

