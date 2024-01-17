using DATCOM;
using SystemsEngineering;
using System;
using System.Collections.Generic;
using Propulsion;
using CAD;
using MissionsNamespace;
using Power;
using Simulation;
using MLApp;
using Mathematics;


namespace AircraftObjects
{
    public class Aircraft : SystemOfSystems
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //
        //  Identification
        private String _Name;
        private String _Description;
        private String _Version;
        //
        //Enumerations
        private AircraftTypeEnum _MyType;
        private PropulsionTypeEnum _PropulsionType;
        //
        //  Data
        //
        //  Dimensions
        private CAD_Dimension _Length;
        private CAD_Dimension _Height;
        private CAD_Dimension _Wingspan;
        //
        //  Parameters
        //
        //  Weights
        private CAD_Parameter _TotalWeight;
        private CAD_Parameter _PayloadWeight;
        //  
        //  Areas
        private List<CAD_Parameter> _CrossSectionAreas;
        //
        //  Owned & Owning Objects
        //
        //  CAD Objects
        private CAD_Model _CurrentCAD_Model;
        private CAD_Assembly _CurrentAssembly;
        private List<CAD_Component> _MyComponents;
        //
        //  Aircraft Elements
        private Wing _LeftWing;
        private Wing _RightWing;
        private List<VerticalStabilizer> _VerticleStabilizers;
        private List<HorizontalStabilizer> _HorizontalStabilizers;
        private List<VerticalFin> _VerticleFins;
        private Fuselage _MyFuselage;
        private List<PowerPlant> _MyPowerPlants;
        private Canard _MyCanard;
        private LandingGear _CurrentLandingGear;
        private List<LandingGear> _MyLandingGears;
        //
        //  App Objects
        //
        //  DATCOM Models
        private DATCOM_Model _CurrentDATCOM_Model;
        private List<DATCOM_Model> _MyDATCOM_Models;
        //
        //  Simulink Models
        private SimulinkModel _CurrentSimulinkModel;
        private List<SimulinkModel> _MySimulinkModels;
        //
        //  System Objects
        private SystemOfInterest _MySoI;
        private SystemOfSystems _MySoS;
        private PowerSubsystem _MyPowerSubsystem;
        #endregion
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
        //  Aircraft Type

        public enum AircraftTypeEnum
        {
            FixedWing = 0,
            SwingWing,
            Helicopter,
            Quadcopter,
            Multicopter
        }
        //
        //  Propulsion Type
        public enum PropulsionTypeEnum
        {
            Propeller = 0,
            Jet,
            DuctedFan,
            Rocket,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  AIRCRAFT CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Aircraft()
        {
           //
            //  Mission Elements
            //
            //  Scenarios
            this.MyScenarios = new List<MissionScenario>();
            //
            //  CAD Objects
            this.Subassemblies = new List<CAD_Assembly>();
            this.MyCAD_Models = new List<CAD_Model>();
            this.MyComponents = new List<CAD_Component>();
            //
            //  Aircraft Objects
            this.LeftWing = new Wing();
            this.RightWing = new Wing();
            this.MyFuselage = new Fuselage();
            this.HorizontalStabilizers = new List<HorizontalStabilizer>();
            this.VerticleStabilizers = new List<VerticalStabilizer>();
            this._VerticleFins = new List<VerticalFin>();
            this.MyPowerPlants = new List<PowerPlant>();
            this.MyLandingGears = new List<LandingGear>();
            //
            //  Models
            //
            //  DATCOM
            this.MyDATCOM_Models = new List<DATCOM_Model>();
            //  Simulink
            this.MySimulinkModels = new List<SimulinkModel>();
            //
            //  Systems
            //
            //  DWM Systems
            this.MySystems = new List<DWM_System>();
            //
            //  System Models
            this.MySystemModels = new List<DWM_SystemModel>();
            //
            //  PowerPlants
            this.MyPowerPlants = new List<PowerPlant>();
            //
            //  Plants
            this.MyPlants = new List<Plant>();
            //
            //  Sensor Groups
            this.MySensorGroups = new List<SensorNamespace.SensorGroup>();
            //
            //  Systems of Interest
            this.MySOIs = new List<SystemOfInterest>();
            //
            //  System Type
            this.SystemType = SystemTypeEnum.SoS;
            //
            //  Parameters
            this.TotalWeight.MyParameterType = CAD_Parameter.ParameterType.Double;
            this.PayloadWeight.MyParameterType = CAD_Parameter.ParameterType.Double;
            //
            //  Interfaces
            this.MyInterfacingComponents = new List<DWM_Component>();
            //
            //  Other
           
            
            
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
        //  Description
        public String Description
        {
            set => _Description = value;
            get
            {
                return _Description;
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
        //Enumerations
        //
        //  Aircraft Type
        public AircraftTypeEnum MyType
        {
            set => _MyType = value;
            get
            {
                return _MyType;
            }
        }
        //
        //  Propulsion Type
        public PropulsionTypeEnum PropulsionType
        {
            set => _PropulsionType = value;
            get
            {
                return _PropulsionType;
            }
        }
        //
        //  Data
        //
        //  Length
        public CAD_Dimension Length
        {
            set => _Length = value;
            get
            {
                return _Length;
            }
        }
        //
        //  Height
        public CAD_Dimension Height
        {
            set => _Height = value;
            get
            {
                return _Height;
            }
        }
        //
        //  Wingspan
        public CAD_Dimension Wingspan
        {
            set => _Wingspan = value;
            get
            {
                return _Wingspan;
            }
        }
        //
        //  Parameters
        //
        //  Weights
        public CAD_Parameter TotalWeight
        {
            set => _TotalWeight = value;
            get
            {
                return _TotalWeight;
            }
        }
        public CAD_Parameter PayloadWeight
        {
            set => _PayloadWeight = value;
            get
            {
                return _PayloadWeight;
            }
        }
        //  
        //  Areas
        public List<CAD_Parameter> CrossSectionAreas
        {
            set => _CrossSectionAreas = value;
            get
            {
                return _CrossSectionAreas;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  CAD Objects
        //
        //  Current CAD Model
        public CAD_Model CurrentCAD_Model
        {
            set => _CurrentCAD_Model = value;
            get
            {
                return _CurrentCAD_Model;
            }
        }
        //
        //  Current CAD Assembly
        public CAD_Assembly CurrentAssembly
        {
            set => _CurrentAssembly = value;
            get
            {
                return _CurrentAssembly;
            }
        }
        //
        //  My CAD Assemblies
        public List<CAD_Component> MyComponents
        {
            set => _MyComponents = value;
            get
            {
                return _MyComponents;
            }
        }
        //
        //  Aircraft Elements
        //
        //  Left Wing
        public Wing LeftWing
        {
            set => _LeftWing = value;
            get
            {
                return _LeftWing;
            }
        }
        //
        //  Right Wing
        public Wing RightWing
        {
            set => _RightWing = value;
            get
            {
                return _RightWing;
            }
        }
        //
        //  Verticle Stabilizer
        public List<VerticalStabilizer> VerticleStabilizers
        {
            set => _VerticleStabilizers = value;
            get
            {
                return _VerticleStabilizers;
            }
        }
        //
        //  Horizontal Stabilizer
        public List<HorizontalStabilizer> HorizontalStabilizers
        {
            set => _HorizontalStabilizers = value;
            get
            {
                return _HorizontalStabilizers;
            }
        }
        //
        //  Verticle Fins
        public List<VerticalFin> VerticleFins
        {
            set => _VerticleFins = value;
            get
            {
                return _VerticleFins;
            }
        }
        //
        //  Fuselage
        public Fuselage MyFuselage
        {
            set => _MyFuselage = value;
            get
            {
                return _MyFuselage;
            }
        }
        //
        //  Power Plants
        public List<PowerPlant> MyPowerPlants
        {
            set => _MyPowerPlants = value;
            get
            {
                return _MyPowerPlants;
            }
        }
        //
        //  Canard
        public Canard MyCanard
        {
            set => _MyCanard = value;
            get
            {
                return _MyCanard;
            }
        }
        //
        // Current Landing Gear
        public LandingGear CurrentLandingGear
        {
            set => _CurrentLandingGear = value;
            get
            {
                return _CurrentLandingGear;
            }
        }
        //
        //  Landing Gears
        public List<LandingGear> MyLandingGears
        {
            set => _MyLandingGears = value;
            get
            {
                return _MyLandingGears;
            }
        }
        //
        //  App Objects
        //
        //  Current DATCOM Model
        public DATCOM_Model CurrentDATCOM_Model
        {
            set => _CurrentDATCOM_Model = value;
            get
            {
                return _CurrentDATCOM_Model;
            }
        }
        //
        //  DATCOM Models
        public List<DATCOM_Model> MyDATCOM_Models
        {
            set => _MyDATCOM_Models = value;
            get
            {
                return _MyDATCOM_Models;
            }
        }
        //
        //  Simulink Models
        public SimulinkModel CurrentSimulinkModel
        {
            set => _CurrentSimulinkModel = value;
            get
            {
                return _CurrentSimulinkModel;
            }
        }
        //
        //  Simulink Models
        public List<SimulinkModel> MySimulinkModels
        {
            set => _MySimulinkModels = value;
            get
            {
                return _MySimulinkModels;
            }
        }
        //  System Objects
        //
        //  System of Interest
        public SystemOfInterest MySoI
        {
            set => _MySoI = value;
            get
            {
                return _MySoI;
            }
        }
        //
        //  System of Systems
        public SystemOfSystems MySoS
        {
            set => _MySoS = value;
            get
            {
                return _MySoS;
            }
        }
        //
        //  My Power Subsystem
        public PowerSubsystem MyPowerSubsystem
        {
            set => _MyPowerSubsystem = value;
            get
            {
                return _MyPowerSubsystem;
            }
        }
        //
        //  Controls
         #endregion
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
