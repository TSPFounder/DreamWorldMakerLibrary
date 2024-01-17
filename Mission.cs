using System;
using System.Collections.Generic;
/*using CAD;
using AircraftObjects;
using Automotive;
using Rocket;
using Missile;
using Controls;
using Propulsion;
using Power;
using Structure;
using SensorNamespace;
using ThermalManagement;

using Communications;
using Fluidics;
using Data;
using SystemsEngineering;
*/
using Project;


namespace MissionsNamespace
{
    public class Mission
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _MissionID;
        private String _MissionName;
        //
        //  Definitions
        private String _Narrative;
        //
        //  Owned & Owning Objects
        //
        //  People
        private List<DWM_Stakeholder> _Stakeholders;
        private List<Person> _Adversaries;
        //
        //  Project
        private DWM_Project _MyProject;
        //
        //  Requirements
        private MissionRequirement _CurrentMissionRequirement;
        private List<MissionRequirement> _MissionRequirements;
        //private DWM_RequirementsManager _RequirementsManager;
        //
        //  Mission Objects
        //
        //  Mission Elements
        private MissionElement _CurrentElement;
        private List<MissionElement> _Elements;
        //
        //  Scenarios
        private MissionScenario _CurrentScenario;
        private List<MissionScenario> _Scenarios;
        //
        //  Goals
        private MissionGoal _CurrentGoal;
        private List<MissionGoal> _Goals;
        //
        //  System Objects
        //
        //  System of Systems
        private SystemOfSystems _CurrentSystemOfSystems;
        private List<SystemOfSystems> _MySystemsOfSystems;
        //
        //  Family of Systems
        private FamilyOfSystems _CurrentFamilyOfSystems;
        private List<FamilyOfSystems> _MyFamiliesOfSystems;
        //
        //  Systems of Interest
        private SystemOfInterest _CurrentSystemOfInterest;
        private List<SystemOfInterest> _MySystemsOfInterest;
         //
        //  Managers

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
        //  MISSION CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Mission()
        {
            //
            //  People Lists
            _Stakeholders = new List<DWM_Stakeholder >();
            this.Adversaries = new List<Person>();
            //
            //  Mission Lists
            this.Elements = new List<MissionElement>();
            this.Scenarios = new List<MissionScenario>();
            this.Goals = new List<MissionGoal>();
            //
            //  System Lists
            this.MySystemsOfSystems = new List<SystemOfSystems>();
            this.MyFamiliesOfSystems = new List<FamilyOfSystems>();
            this.MySystemsOfInterest = new List<SystemOfInterest>();
            //
            //  Requirements
            //
            //this.RequirementsManager.MyMission = this;
            //
            //  Mission Requiements
            this.MissionRequirements = new List<MissionRequirement>();
            //
            //
            //  Windows
            
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
        //  Mission ID
        public String MissionID
        {
            set => _MissionID = value;
            get { return _MissionID; }
        }
        //
        //  Mission Name
        public String MissionName
        {
            set => _MissionName = value;
            get { return _MissionName; }
        }
        //
        //  Definitions
        //
        //  Narrative
        public String Narrative
        {
            set => _Narrative = value;
            get { return _Narrative; }
        }
        //
        //  Owned & Owning Objects
        //
        //  People
        //
        //  Stakeholders
        public List<DWM_Stakeholder> Stakeholders
        {
            set => _Stakeholders = value;
            get { return _Stakeholders; }
        }
        //
        //  Adversaries
        public List<Person> Adversaries
        {
            set => _Adversaries = value;
            get { return _Adversaries; }
        }
        //
        //  Project
        public DWM_Project MyProject
        {
            set => _MyProject = value;
            get { return _MyProject; }
        }
        //
        //  Mission Objects
        //
        //  Mission Requirement Objects
        //
        //  Current Requirement
        public MissionRequirement CurrentMissionRequirement
        {
            set => _CurrentMissionRequirement = value;
            get { return _CurrentMissionRequirement; }
        }
        //
        //  Mission Requirements
        public List<MissionRequirement> MissionRequirements
        {
            set => _MissionRequirements = value;
            get { return _MissionRequirements; }
        }
        //
        //  Requirements Manager
        /*
        public DWM_RequirementsManager RequirementsManager
        {
            set => _RequirementsManager = value;
            get { return _RequirementsManager; }
        }
        */
        //
        //  Current Mission Element
        public MissionElement CurrentElement
        {
            set => _CurrentElement = value;
            get { return _CurrentElement; }
        }
        //
        //  Elements
        public List<MissionElement> Elements
        {
            set => _Elements = value;
            get { return _Elements; }
        }
        //
        //  Current Mission Scenario
        public MissionScenario CurrentScenario
        {
            set => _CurrentScenario = value;
            get { return _CurrentScenario; }
        }
        //
        //  Scenarios
        public List<MissionScenario> Scenarios
        {
            set => _Scenarios = value;
            get { return _Scenarios; }
        }
        //
        //  Current Goal
        public MissionGoal CurrentGoal
        {
            set => _CurrentGoal = value;
            get { return _CurrentGoal; }
        }
        //
        //  Goals
        public List<MissionGoal> Goals
        {
            set => _Goals = value;
            get { return _Goals; }
        }
        //
        //  System Objects
        //
        //  System of Systems
        public SystemOfSystems CurrentSystemOfSystems
        {
            set => _CurrentSystemOfSystems = value;
            get { return _CurrentSystemOfSystems; }
        }
        public List<SystemOfSystems> MySystemsOfSystems
        {
            set => _MySystemsOfSystems = value;
            get { return _MySystemsOfSystems; }
        }
        //
        //  Family of Systems
        public FamilyOfSystems CurrentFamilyOfSystems
        {
            set => _CurrentFamilyOfSystems = value;
            get { return _CurrentFamilyOfSystems; }
        }
        public List<FamilyOfSystems> MyFamiliesOfSystems
        {
            set => _MyFamiliesOfSystems = value;
            get { return _MyFamiliesOfSystems; }
        }
        //
        //  Systems of Interest
        public SystemOfInterest CurrentSystemOfInterest
        {
            set => _CurrentSystemOfInterest = value;
            get { return _CurrentSystemOfInterest; }
        }
        public List<SystemOfInterest> MySystemsOfInterest
        {
            set => _MySystemsOfInterest = value;
            get { return _MySystemsOfInterest; }
        }
       
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region
        //
        //  Add New Systems
        //
        //  Add a New System of Systems
        public void AddNew_SoS()
        {
            this.CurrentSystemOfSystems = new SystemOfSystems();
            this.MySystemsOfSystems.Add(this.CurrentSystemOfSystems);
        }
        //
        //  Add a Family of Systems
        public void AddNew_FoS()
        {
            this.CurrentFamilyOfSystems = new FamilyOfSystems();
            this._MyFamiliesOfSystems.Add(this.CurrentFamilyOfSystems);
        }
        //
        //  Add a System of Interest
        public void AddNew_SoI()
        {
            this.CurrentSystemOfInterest = new SystemOfInterest();
            this._MySystemsOfInterest.Add(this.CurrentSystemOfInterest);
        }
        //
        //  Add Scenarios & Mission Elements
        //
        //  Add a Scenario
        public void Add_Scenario()
        {
            this._CurrentScenario = new MissionScenario();
            this.Scenarios.Add(this._CurrentScenario);
        }
        //
        //  Add a Mission Element
        public void Add_Element()
        {
            this.CurrentElement = new MissionElement();
            this.Elements.Add(this.CurrentElement);
        }
        //
        //  Add a Mission Goal
        public void Add_Goal()
        {
            this.CurrentGoal = new MissionGoal();
            this.Elements.Add(this.CurrentElement);
        }
        #endregion
        //  *****************************************************************************************

        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************
        #region
        public event EventHandler MissionAddedOrRemoved
        {
            add
            { 
                
            }

            remove
            {

            }
        }
        #endregion
        //  *****************************************************************************************
    }
}
