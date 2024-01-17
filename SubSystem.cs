using System;
using System.Collections.Generic;
//using Propulsion;
using Power;
using Structure;
using SensorNamespace;
//using ThermalManagement;
//using Communications;
//using Fluidics;
//using Data;
using CAD;
using Controls;
using SystemsEngineering;


namespace MissionsNamespace
{
    public class SubSystem : DWM_System
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
        //  Owned & Owning Objects
        //
        //  Configuration Items
        private ConfigurationItem _CurrentCI;
        private List<ConfigurationItem> _MyConfigurationItems;
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
        //  SUBSYSTEM CONSTRUCTOR
        //
        //  ************************************************************
        public SubSystem()
        { 
           
            //
            //  Models
            this.MyConfigurationItems = new List<ConfigurationItem>();
            //
            //  System Type
            this.SystemType = SystemTypeEnum.Subsystem;

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
            get { return _Name; }
        }
        //
        //  Version
        public String Version
        {
            set { }
            get { return _Version; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Configuration Items
        public ConfigurationItem CurrentCI
        {
            set { }
            get { return _CurrentCI; }
        }
        public List<ConfigurationItem> MyConfigurationItems
        {
            set { }
            get { return _MyConfigurationItems; }
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
