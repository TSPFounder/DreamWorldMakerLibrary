using System;
using System.Collections.Generic;
using CAD;
using SystemsEngineering;

namespace MissionsNamespace
{
    public class UseCase : MissionElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //
        //  Identification
        private String _Name;
        private String _Definition;
        private String _ID;
        //
        //  Predicate
        private String _Predicate;
        //
        //  Owned & Owning Objects
        //
        //  My Actors
        private List<Person> _HumanActors;
        private List<SystemOfInterest> _SystemActors;
        //
        //  My Requirement
        private DWM_Requirement _MyRequirement;
        //
        //  Mission & Scenarios
        private Mission _MyMission;
        private MissionScenario _CurrentScenario;
        private List<MissionScenario> _MyScenarios;
        //
        //  Controls
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

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ENUMERATIONS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  USECASE CONSTRUCTOR
        //
        //  ************************************************************
        public UseCase()
        {
            this.TheMainWindow = MyMainWindow;
            this.MyAppMgr = this.TheMainWindow.MyAppManager;

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
            get
            {
                return _Name;
            }
        }
        //
        //  Definition
        public String Definition
        {
            set => _Definition = value;
            get
            {
                return _Definition;
            }
        }
        //
        //  ID
        public String ID
        {
            set => _ID = value;
            get
            {
                return _ID;
            }
        }
        //
        //  Definitions
        //
        //  Predicate
        public String Predicate
        {
            set => _Predicate = value;
            get
            {
                return _Predicate;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Mission & Scenarios
        //
        //  My Mission
        public Mission MyMission
        {
            set => _MyMission = value;
            get { return _MyMission; }
        }
        //  My Actors
        //
        //  Human Actors
        public List<Person> HumanActors
        {
            set => _HumanActors = value;
            get
            {
                return _HumanActors;
            }
        }
        //
        //  System Actors
        public List<SystemOfInterest> SystemActors
        {
            set => _SystemActors = value;
            get
            {
                return _SystemActors;
            }
        }
        //
        //  My Requirement
        public DWM_Requirement MyRequirement
        {
            set => _MyRequirement = value;
            get
            {
                return _MyRequirement;
            }
        }
        //
        //  Scenarios
        public MissionScenario CurrentScenario
        {
            set => _CurrentScenario = value;
            get
            {
                return _CurrentScenario;
            }
        }
        public List<MissionScenario> MyScenarios
        {
            set => _MyScenarios = value;
            get
            {
                return _MyScenarios;
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

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
