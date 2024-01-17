using System;
using System.Collections.Generic;
using Propulsion;
using Power;
using Structure;
using SensorNamespace;
using ThermalManagement;
//using GNC;
using Communications;
using Fluidics;
using Data;
using CAD;
using Controls;
using SystemsEngineering;
using Documents;

namespace MissionsNamespace
{
    public class SystemOfSystems : DWM_System
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Version;
        //
        //  Type
        private SystemTypeEnum _SystemType;
        //
        //  Owned & Owning Objects
        //
        //  System of Interest
        private SystemOfInterest _CurrentSoI;
        private List<SystemOfInterest> _MySOIs;
        private List<DWM_System> _MySystems;       
        //
        //  Managers
        private ApplicationManager _MyAppMgr;
        //
        //  My Systems Engineering Master Plan
        private DWM_Document _MySEMP;
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
        #region
       
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SYSTEMOFSYSTEMS CONSTRUCTOR
        //
        //  ************************************************************
        public SystemOfSystems()
        {
           //  Managers
            this.MyAppMgr = this.TheMainWindow.MyAppManager;
            //
            //  Set the Type of System
            this.SystemType = SystemTypeEnum.SoS;
            //
            //  Lists
            this.MyCAD_Models = new List<CAD_Model>();
            this.MySOIs = new List<SystemOfInterest>();
            this.MySystems = new List<DWM_System>();
            
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
            set => _Name = value;
            get { return _Name; }
        }
        //
        //  Version
        public String Version
        {
            set => _Version = value;
            get { return _Version; }
        }
        //
        //  Type
        public SystemTypeEnum SystemType
        {
           set => _SystemType = value;
           get { return _SystemType; }
        }
        //  Owned & Owning Objects
        //
        //  System of Interest
        public SystemOfInterest CurrentSoI
        {
            set => _CurrentSoI = value;
            get { return _CurrentSoI; }
        }
        //
        //  My Systems of Interest
        public List<SystemOfInterest> MySOIs
        {
            set => _MySOIs = value;
            get { return _MySOIs; }
        }
        //
        //  My Systems
        public List<DWM_System> MySystems
        {
            set => _MySystems = value;
            get { return _MySystems; }
        }
        //
        //  Controls
         //
        //  Managers
        public ApplicationManager MyAppMgr
        {
            set => _MyAppMgr = value;
            get { return _MyAppMgr; }
        }
        //
        //  My Systems Engineering Master Plan
        public DWM_Document MySEMP
        {
            set => _MySEMP = value;
            get { return _MySEMP; }
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
