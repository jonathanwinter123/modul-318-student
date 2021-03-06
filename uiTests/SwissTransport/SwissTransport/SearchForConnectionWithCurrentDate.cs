﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SwissTransport
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SearchForConnectionWithCurrentDate recording.
    /// </summary>
    [TestModule("7bf8d7ae-94a8-460c-8945-07490569fc68", ModuleType.Recording, 1)]
    public partial class SearchForConnectionWithCurrentDate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SwissTransportRepository repository.
        /// </summary>
        public static SwissTransportRepository repo = SwissTransportRepository.Instance;

        static SearchForConnectionWithCurrentDate instance = new SearchForConnectionWithCurrentDate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchForConnectionWithCurrentDate()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SearchForConnectionWithCurrentDate Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationText' at 63;7.", repo.MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationTextInfo, new RecordItemIndex(0));
            repo.MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationText.MoveTo("63;7");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationText' at 71;-1.", repo.MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationTextInfo, new RecordItemIndex(1));
            repo.MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationText.MoveTo("71;-1");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'Luzer' on item 'MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationText'.", repo.MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationTextInfo, new RecordItemIndex(2));
            repo.MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationText.Element.SetAttributeValue("Text", "Luzer");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationDropDown' at 6;1.", repo.MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationDropDownInfo, new RecordItemIndex(3));
            repo.MainFormSwissTransport.cmbTripDepartureStation.cmbTripDepartureStationDropDown.Click("6;1");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.lstComboboxItemDepartureStation' at 68;10.", repo.List1000.lstComboboxItemDepartureStationInfo, new RecordItemIndex(4));
            repo.List1000.lstComboboxItemDepartureStation.Click("68;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'Luzer' on item 'MainFormSwissTransport.cmbTripArrivalStation.cmbTripArrivalStationText'.", repo.MainFormSwissTransport.cmbTripArrivalStation.cmbTripArrivalStationTextInfo, new RecordItemIndex(5));
            repo.MainFormSwissTransport.cmbTripArrivalStation.cmbTripArrivalStationText.Element.SetAttributeValue("Text", "Luzer");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainFormSwissTransport.cmbTripArrivalStation.cmbTripArrivalStationDropDown' at 4;5.", repo.MainFormSwissTransport.cmbTripArrivalStation.cmbTripArrivalStationDropDownInfo, new RecordItemIndex(6));
            repo.MainFormSwissTransport.cmbTripArrivalStation.cmbTripArrivalStationDropDown.Click("4;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.lstComboboxItemArrivalStation' at 69;4.", repo.List1000.lstComboboxItemArrivalStationInfo, new RecordItemIndex(7));
            repo.List1000.lstComboboxItemArrivalStation.Click("69;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainFormSwissTransport.TabTripPage.btnTripSearch' at 40;7.", repo.MainFormSwissTransport.TabTripPage.btnTripSearchInfo, new RecordItemIndex(8));
            repo.MainFormSwissTransport.TabTripPage.btnTripSearch.Click("40;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Luzern, Wey\r\n\r\n') on item 'MainFormSwissTransport.TabTripPage.gdvLastCell'.", repo.MainFormSwissTransport.TabTripPage.gdvLastCellInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.MainFormSwissTransport.TabTripPage.gdvLastCellInfo, "Text", new Regex(Regex.Escape("Luzern, Wey\r\n\r\n")));
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleName='Abfahrt Row 5') on item 'MainFormSwissTransport.TabTripPage.gdvLastCell'.", repo.MainFormSwissTransport.TabTripPage.gdvLastCellInfo, new RecordItemIndex(10));
            Validate.Attribute(repo.MainFormSwissTransport.TabTripPage.gdvLastCellInfo, "AccessibleName", "Abfahrt Row 5");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
