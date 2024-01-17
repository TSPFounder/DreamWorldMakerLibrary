using System;
using System.Collections.Generic;
using Propulsion;
using Power;
using Structure;
using SensorNamespace;
using ThermalManagement;
using GNC;
using Communications;
using Fluidics;
using Data;
using CAD;
using Controls;
using SystemsEngineering;


namespace MissionsNamespace
{
    public class FamilyOfSystems
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Name;
        private String _Version;
        //private SystemTypeEnum _SystemType;
        //
        //  Data

        //
        //  Collections
        //
        //  Owned Systems
        private DWM_System _CurrentSystem;
        private List<DWM_System> _MySystems;

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
        //
        //  Element Type
        public enum SystemTypeEnum
        {
            SoS = 0,
            SoI,
            Subsystem,
            ConfigurationItem,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  FAMILYOFSYSTEMS CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public FamilyOfSystems()
        {
            
            
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        public String Name
        {
            set => _Name = value;
            get { return _Name; }
        }
        public String Version
        {
            set => _Version = value;
            get { return _Version; }
        }
        //
        //  Type
        //public SystemTypeEnum SystemType
        //{
        //    set => _SystemType = value;
        //    get { return _SystemType; }
        //}
        //
        //  Owned & Owning Objects
        //
        //  Owned Systems
        public DWM_System CurrentSystem
        {
            set => _CurrentSystem = value;
            get { return _CurrentSystem; }
        }
        public List<DWM_System> MySystems
        {
            set => _MySystems = value;
            get { return _MySystems; }
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
