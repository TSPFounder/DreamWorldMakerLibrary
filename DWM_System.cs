using System;
using System.Collections.Generic;
/*
using Propulsion;
using Power;
using Structure;

using ThermalManagement;
//using GNC;
using Communications;
using Fluidics;
using Data;
*/
using CAD;
using Controls;
using SystemsEngineering;
using SensorNamespace;
//using Simulation;


namespace MissionsNamespace
{
    public class DWM_System : MissionElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Version;
        private String _Description;
        private String _ID;
        //
        //  Type
        private SystemTypeEnum _SystemType;
        //
        //  Data
        //
        //  Parameters
        private CAD_Parameter _Weight;
        //
        //  WBS Level
        private Int16 _WBS_Level;
        //
        //  Is a Purchased Part
        private Boolean _IsPurchasedPart;
        //
        //  Owned & Owning Objects
        //
        //  People
        private Person _CurrentUser;
        private List<Person> _Users;
        //
        //  Sub-systems
        //
        //  Sensor Groups
        private SensorGroup _CurrentSensorGroup;
        private List<SensorGroup> _MySensorGroups;
        //
        //  Controllers
        private Controller _CurrentController;
        private List<Controller> _MyControllers;
        //
        //  Plants
        private Plant _CurrentPlant;
        private List<Plant> _MyPlants;
        //
        //  Components
        private DWM_Component _CurrentComponent;
        private List<DWM_Component> _MyComponents;
        //
        //  Models
        //
        // CAD Models
        private CAD_Model _CurrentModel;
        private List<CAD_Model> _MyCAD_Models;
        //
        //  Simulink Blocks
        private SimulinkBlockset _MySimulinkBlock;
        //
        //  System Models
        private DWM_SystemModel _CurrentSystemModel;
        private List<DWM_SystemModel> _MySystemModels;
        // 
        //  My Assembly
        private CAD_Assembly _MyAssembly;
        //
        //  Sub-Assemblies
        private List<CAD_Assembly> _Subassemblies;
        
        //
        //  Managers
        //private ApplicationManager _MyAppMgr;
        //
        //  Interfacing Components
        private List<DWM_Component> _MyInterfacingComponents;
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
        //
        //  System Type
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
        //  DWM_SYSTEM CONSTRUCTOR
        //
        //  ************************************************************
        public DWM_System()
        {
            
            //
            //  People
            this.Users = new List<Person>();
            //  Components
            this.MyComponents = new List<DWM_Component>();
            //
            //  Models
            this.MyCAD_Models = new List<CAD_Model>();
            this.Subassemblies = new List<CAD_Assembly>();
            this.MySystemModels = new List<DWM_SystemModel>();
            
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region
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
        //  Description
        public String Description
        {
            set => _Description = value;
            get { return _Description; }
        }
        //
        //  ID
        public String ID
        {
            set => _ID = value;
            get { return _ID; }
        }
        //
        //  Type
        public SystemTypeEnum SystemType
        {
           set => _SystemType = value;
           get { return _SystemType; }
        }
        //
        //  Data
        //
        //  Parameters
        //
        //  Weights
        public CAD_Parameter Weight
        {
            set => _Weight = value;
            get
            {
                return _Weight;
            }
        }
        //
        //  WBS Level
        public Int16 WBS_Level
        {
            set => _WBS_Level = value;
            get { return _WBS_Level; }
        }
        //
        //  Is a Purchased Part
        public Boolean IsPurchasedPart
        {
            set => _IsPurchasedPart = value;
            get { return _IsPurchasedPart; }
        }
        //
        //  Owned & Owning Objects
        //
        //  People
        //
        //  Users
        //
        //  Current User
        public Person CurrentUser
        {
            set => _CurrentUser = value;
            get { return _CurrentUser; }
        }
        //
        //  Users
        public List<Person> Users
        {
            set => _Users = value;
            get { return _Users; }
        }
        //
        //  Sub-systems
        //
        //  Sensor Groups
        public SensorGroup CurrentSensorGroup
        {
            set => _CurrentSensorGroup = value;
            get { return _CurrentSensorGroup; }
        }
        public List<SensorGroup> MySensorGroups
        {
            set => _MySensorGroups = value;
            get { return _MySensorGroups; }
        }
        //
        //  Controllers
        public Controller CurrentController
        {
            set => _CurrentController = value;
            get { return _CurrentController; }
        }
        public List<Controller> MyControllers
        {
            set => _MyControllers = value;
            get { return _MyControllers; }
        }
        //
        //  Plants
        public Plant CurrentPlant
        {
            set => _CurrentPlant = value;
            get { return _CurrentPlant; }
        }
        public List<Plant> MyPlants
        {
            set => _MyPlants = value;
            get { return _MyPlants; }
        }
        //
        //  Components
        //
        //  Current Component
        public DWM_Component CurrentComponent
        {
            set => _CurrentComponent = value;
            get { return _CurrentComponent; }
        }
        public List<DWM_Component> MyComponents
        {
            set => _MyComponents = value;
            get { return _MyComponents; }
        }
        //
        //  Models
        //
        //  Current CAD Model
        public CAD_Model CurrentModel
        {
            set => _CurrentModel = value;
            get { return _CurrentModel; }
        }
        //
        //  My CAD Models
        public List<CAD_Model> MyCAD_Models
        {
            set => _MyCAD_Models = value;
            get { return _MyCAD_Models; }
        }
        //
        //  Current System Model
        public DWM_SystemModel CurrentSystemModel
        {
            set => _CurrentSystemModel = value;
            get { return _CurrentSystemModel; }
        }
        //
        //  My System Models
        public List<DWM_SystemModel> MySystemModels
        {
            set => _MySystemModels = value;
            get { return _MySystemModels; }
        }
        //
        //  My Assembly
        public CAD_Assembly MyAssembly
        {
            set => _MyAssembly = value;
            get { return _MyAssembly; }
        }
        //
        //  Sub-Assemblies
        public List<CAD_Assembly> Subassemblies
        {
            set => _Subassemblies = value;
            get { return _Subassemblies; }
        }
        //
        //  Interfacing Components
        public List<DWM_Component> MyInterfacingComponents
        {
            set => _MyInterfacingComponents = value;
            get
            {
                return _MyInterfacingComponents;
            }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        public void WalkAssembly()
        {

        }
        public void CreateSystemModel()
        {
            this.CurrentSystemModel = new DWM_SystemModel();
            this.MySystemModels.Add(this.CurrentSystemModel);
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
