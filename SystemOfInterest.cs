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


namespace MissionsNamespace
{
    public class SystemOfInterest : DWM_System
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
        //  Owned & Owning Objects
        //
        //  WBS
        private WBS _MyWBS;
        //
        //  Models
        private CAD_Model _CurrentModel;
        private List<CAD_Model> _MyModels;
        //
        //  Subsystems
        private SubSystem _CurrentSubSystem;
        private List<SubSystem> _MySubsystems;
        private PowerPlant _MyPowerPlant;
        private Power.PowerSubsystem _MyPowerSubsystem;
        private Structure.StructureSubsystem _MyStructure;
        private SensorNamespace.SensorSubsystem _MySensorSubsystem;
        //
        //  Assemblies & Components
        private Plant _MyPlant;
        private Controller _MyController;
        //
        //  Main Window
        private MainWindow _TheMainWindow;
        //
        //  Managers
        private ApplicationManager _MyAppMgr;
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
        //  SYSTEMOFINTEREST CONSTRUCTOR
        //
        //  ************************************************************
        public SystemOfInterest()
        {
            //
            //  System Type 
            this.SystemType = SystemTypeEnum.SoI;
            //  Windows
            this.TheMainWindow = MyMainWindow;
            //  Managers
            this.MyAppMgr = this.TheMainWindow.MyAppManager;
            //
            //  Models
            this.MySubsystems = new List<SubSystem>();
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
        //  WBS
        public WBS MyWBS
        {
            set => _MyWBS = value;
            get { return _MyWBS; }
        }
        //
        //  Models
        //
        //  Current Model
        public CAD_Model CurrentModel
        {
            set => _CurrentModel = value;
            get {
                return _CurrentModel;
                }
        }
        //
        //  My Models
        public List<CAD_Model> MyModels
        {
            set => _MyModels = value;
            get
            {
                return _MyModels;
            }
        }
        //
        //  Subsystems
        //
        // Current Subsystem
        public SubSystem CurrentSubSystem
        {
            set => _CurrentSubSystem = value;
            get
            {
                return _CurrentSubSystem;
            }
        }
        //
        //  Subsystems
        public List<SubSystem> MySubsystems
        {
            set => _MySubsystems = value;
            get
            {
                return _MySubsystems;
            }
        }
        //
        //  Powerplant
        public PowerPlant MyPowerPlant
        {
            set => _MyPowerPlant = value;
            get
            {
                return _MyPowerPlant;
            }
        }
        //
        //  Power Subsystem
        public Power.PowerSubsystem MyPowerSubsystem
        {
            set => _MyPowerSubsystem = value;
            get
            {
                return _MyPowerSubsystem;
            }
        }
        //
        //  Structure
        public Structure.StructureSubsystem MyStructure
        {
            set => _MyStructure = value;
            get
            {
                return _MyStructure;
            }
        }
        //
        //  Sensors
        //
        //  Sensor Subsystem
        public SensorNamespace.SensorSubsystem MySensorSubsystem
        {
            set => _MySensorSubsystem = value;
            get
            {
                return _MySensorSubsystem;
            }
        }
        //  Assemblies & Components
        public Plant MyPlant
        {
            set => _MyPlant = value;
            get
            {
                return _MyPlant;
            }
        }
        public Controller MyController
        {
            set => _MyController = value;
            get
            {
                return _MyController;
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
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
