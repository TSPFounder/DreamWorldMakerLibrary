using System;
using System.Collections.Generic;
using Propulsion;
using Power;
using Structure;
using SensorNamespace;
using ThermalManagement;

using Communications;
using Fluidics;
using Data;
using CAD;
using Controls;
using SystemsEngineering;

namespace MissionsNamespace
{
    public class WorkBreakdownStructure
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        protected String _Path;
        private String _Version;

        //  Owned & Owning Objects
        //
        //  WBS Workbook
        private Microsoft.Office.Interop.Excel.Workbook _MyWorkbook;
        //
        //  Current WBS Worksheet
        private Microsoft.Office.Interop.Excel.Worksheet _CurrentWBS_Worksheet;
        //
        //  Managers
        //
        //  Application Manager
        private ApplicationManager _TheApplicationManager;
        //
        //  WBS Data
        //
        //  WBS Levels
        private int _WBS_ControlAccountLevel;
        //
        //  WBS Elements
        private MissionElement _CurrentElement;
        private List<MissionElement> _MyElements;
        //  *****************************************************************************************


        //  ****************************************************************************************
        //  INITIALIZATIONS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ENUMERATIONS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  WORKBREAKDOWNSTRUCTURE CONSTRUCTOR
        //
        //  ************************************************************
        public WorkBreakdownStructure()
        {
            
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        //
        //  Name
        public String Name
        {
            set { }
            get
            {
                return _Name;
            }
        }
        //
        //  Version
        public String Version
        {
            set { }
            get
            {
                return _Version;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  WBS Workbook
        public Microsoft.Office.Interop.Excel.Workbook MyWorkbook
        {
            set { }
            get
            {
                return _MyWorkbook;
            }
        }
        //
        //  Current WBS Worksheet
        public Microsoft.Office.Interop.Excel.Worksheet CurrentWBS_Worksheet
        {
            set { }
            get
            {
                return _CurrentWBS_Worksheet;
            }
        }
        //
        //  WBS Data
        //
        //  Control Account Level
        public int ControlAccountLevel
        {
            set { }
            get
            {
                return _WBS_ControlAccountLevel;
            }
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        public void New_WBS()
        {
            _MyWorkbook = new Microsoft.Office.Interop.Excel.Workbook();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
