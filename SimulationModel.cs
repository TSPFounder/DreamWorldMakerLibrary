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

using MissionsNamespace;

namespace Simulation
{
    public class SimulationModel
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
        private String _Path;
        //
        //  Data
        private Boolean _IsHDRP;
        private SimModelType _MyModelType;
        private ModelCategory _MyModelCategory;
        //
        //  Owned & Owning Objects
        //
        //  Models
        private SimulationModel _CurrentChildModel;
        private List<SimulationModel> _MyChildModels;
        //
        //  Prefabs
        private SimulationModel _CurrentPrefab;
        private List<SimulationModel> _MyPrefabs;
        //
        //  Game Assets
        private GameAsset _CurrentGameAsset;
        private List<GameAsset> _MyGameAssets;
        //
        //  Scenarios
        private MissionScenario _CurrentScenario;
        private List<MissionScenario> _Scenarios;
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
        //  Model Type
        public enum SimModelType
        {
            Simulink = 0,
            Simscape,
            UnrealEngine,
            Unity,
            Blender,
            Other
        }
        //
        //  Model Category
        public enum ModelCategory
        {
            Terrain=0,
            Vegetation,
            Animal,
            Person,
            Road,
            BodyOfWater,
            Building,
            Vehicle,
            Machine,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SIMULATIONMODEL CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimulationModel()
        {
            this.MyChildModels = new List<SimulationModel>();
            this.MyGameAssets = new List<GameAsset>();
            this.Scenarios = new List<MissionScenario>();
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
        //
        //  Name
        public String Name
        {
            set => _Name = value;
            get
            {
                return _Name;
            }
        }
        //
        //  Version
        public String Version
        {
            set => _Version = value;
            get
            {
                return _Version;
            }
        }
        //
        //  Path
        public String Path
        {
            set => _Path = value;
            get
            {
                return _Path;
            }
        }
        //
        //  Data
        //
        //  Is an HDRP Model
        public Boolean IsHDRP
        {
            set => _IsHDRP = value;
            get { return _IsHDRP; }
        }
        //
        //  ModelType
        public SimModelType MyModelType
        {
            set => _MyModelType = value;
            get { return _MyModelType; }
        }
        //
        //  Model Category
        public ModelCategory MyModelCategory
        {
            set => _MyModelCategory = value;
            get { return _MyModelCategory; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Models
        public SimulationModel CurrentChildModel
        {
            set => _CurrentChildModel = value;
            get { return _CurrentChildModel; }
        }
        public List<SimulationModel> MyChildModels
        {
            set => _MyChildModels = value;
            get { return _MyChildModels; }
        }
        //
        //  Prefabs
        public SimulationModel CurrentPrefab
        {
            set => _CurrentPrefab = value;
            get { return _CurrentPrefab; }
        }
        public List<SimulationModel> MyPrefabs
        {
            set => _MyPrefabs = value;
            get { return _MyPrefabs; }
        }
        //
        //  Game Assets
        public GameAsset CurrentGameAsset
        {
            set => _CurrentGameAsset = value;
            get { return _CurrentGameAsset; }
        }
        public List<GameAsset> MyGameAssets
        {
            set => _MyGameAssets = value;
            get { return _MyGameAssets; }
        }
        //
        //  Scenarios
        public MissionScenario CurrentScenario
        {
            set => _CurrentScenario = value;
            get { return _CurrentScenario; }
        }
        public List<MissionScenario> Scenarios
        {
            set => _Scenarios = value;
            get { return _Scenarios; }
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
