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
    public class ConfigurationItem : DWM_System
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
        //  Definitions & Data
        private CI_TypeEnum _CI_Type;
        
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
        public enum CI_TypeEnum
        {
            Hardware = 0,
            Software,
            Database
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CONFIGURATIONITEM CONSTRUCTOR
        //
        //  ************************************************************
        public ConfigurationItem()
        {
            //  Windows
            this.TheMainWindow = MyMainWindow;
            //  Managers
            this.MyAppMgr = this.TheMainWindow.MyAppManager;
            
            //
            //  Models
            this.MyCAD_Models = new List<CAD_Model>();
            this.Subassemblies = new List<CAD_Assembly>();
            this.MySystemModels = new List<DWM_SystemModel>();
            //
            //  System Type
            this.SystemType = SystemTypeEnum.ConfigurationItem;
            
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
        //  Definitions & Data
        public CI_TypeEnum CI_Type
        {
            set => _CI_Type = value;
            get { return _CI_Type; }
        }
        //
        // Owned & Owning Objects
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
