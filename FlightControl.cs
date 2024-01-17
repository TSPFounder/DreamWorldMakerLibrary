using DATCOM;
using SystemsEngineering;
using System;
using System.Collections.Generic;
using Propulsion;
using CAD;
using MissionsNamespace;
using Missile;
using Power;
using Structure;

namespace AircraftObjects
{
    public class FlightControl :ConfigurationItem
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification

        //
        //  Data

        //
        //  Owned & Owning Objects
        private Airframe _CurrentAirframe;
        private List<Airframe> _Airframes;
        //
        //  Main Window
        private MainWindow _TheMainWindow;
        //
        //  Managers
        private ApplicationManager _MyAppMgr;
        #endregion
        //  *****************************************************************************************


        //  ****************************************************************************************
        //  INITIALIZATIONS
        //
        //  ************************************************************
        #region

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ENUMERATIONS
        //
        //  ************************************************************
        #region
        public enum ControlTypeEnum
        {
            Aileron = 0,
            Rudder,
            Elevator,
            Elevon,
            Canard,
            Flap,
            Fin,
            TrimTab,
            ACS,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  FLIGHTCONTROL CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public FlightControl()
        {
            //  Windows
            this.TheMainWindow = MyMainWindow;
            //  Managers
            this.MyAppMgr = this.TheMainWindow.MyAppManager;
            //
            //  Owned & Owning Objects
            this.MyCAD_Models = new List<CAD_Model>();
            this.MyComponents = new List<SRS_Component>();
            this.MyControllers = new List<Controls.Controller>(); 

        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region
        //
        //  Current Airframe
        public Airframe CurrentAirframe
        {
            set => _CurrentAirframe = value;
            get
            {
                return _CurrentAirframe;
            }
        }
        //
        //  Airframes
        public List<Airframe> Airframes
        {
            set => _Airframes = value;
            get
            {
                return _Airframes;
            }
        }
        //
        //  Controls
        //
        //  Main Window
        public MainWindow TheMainWindow
        {
            set => _TheMainWindow = value;
            get { return _TheMainWindow; }
        }
        //
        //  Managers
        public ApplicationManager MyAppMgr
        {
            set => _MyAppMgr = value;
            get { return _MyAppMgr; }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************
        #region

        #endregion
        //  *****************************************************************************************
    }
}
