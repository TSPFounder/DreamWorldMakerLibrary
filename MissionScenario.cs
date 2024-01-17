using System;
using System.Collections.Generic;
using Documents;
using CAD;
using SystemsEngineering;

namespace MissionsNamespace 
{
    public class MissionScenario : MissionElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _MissionScenarioID;
        private String _MissionScenarioName;
        //
        //  Definitions
        private String _Noun;
        private String _Action;
        private String _ObjectID;
        //
        //  Owned & Owning Objects
        //
        //  My Stakeholders
        private List<Person> _Stakeholders;
        private List<Person> _Users;
        private List<Person> _Adversaries;
        //
        //  Views
        private List<View> _MyViews;
        //
        //  Mission Elements
        private MissionElement _CurrentElement;
        private List<MissionElement> _MissionElements;
        //
        //  Scenes
        private MissionScene _CurrentScene;
        private List<MissionScene> _MyScenes;
        //
        //  Scenario Designer
        private ScenarioDesigner _MyScenarioDesigner;
       
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
        //  MISSIONSCENARIO CONSTRUCTOR
        //
        //  ************************************************************
        public MissionScenario()
        {
            
            //
            //  People Lists
            this.Stakeholders = new List<Person>();
            this.Users = new List<Person>();
            this.Adversaries = new List<Person>();
            //
            //  Mission Element List
            this.MissonElements = new List<MissionElement>();
            //
            //  Mission Element Type
            this.MyType = ElementTypeEnum.MissionScenario;
            

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        //
        //  Mission Scenario ID
        public String MissionScenarioID
        {
            set => _MissionScenarioID = value;
            get { return _MissionScenarioID; }
        }
        //
        //  Mission Scenario Name
        public String MissionScenarioName
        {
            set => _MissionScenarioName = value;
            get { return _MissionScenarioName; }
        }
        //
        //  Definitions
        //
        //  Noun
        public String Noun
        {
            set => _Noun = value;
            get { return _Noun; }
        }
        //
        //  Action
        public String Action
        {
            set => _Action = value;
            get { return _Action; }
        }
        //
        //  Object ID
        public String ObjectID
        {
            set => _ObjectID = value;
            get { return _ObjectID; }
        }
        //  Owned & Owning Objects
        //
        //  My Stakeholders
        public List<Person> Stakeholders
        {
            set => _Stakeholders = value;
            get { return _Stakeholders; }
        }
        //
        //  My Users
        public List<Person> Users
        {
            set => _Users = value;
            get { return _Users; }
        }
        //
        //  My Adversaries
        public List<Person> Adversaries
        {
            set => _Adversaries = value;
            get { return _Adversaries; }
        }
        //
        //  Views
        public List<View> MyViews
        {
            set => _MyViews = value;
            get { return _MyViews; }
        }
        //
        //  Mission Elements
        public MissionElement CurrentElement
        {
            set => _CurrentElement = value;
            get { return _CurrentElement; }
        }
        public List<MissionElement> MissonElements
        {
            set => _MissionElements = value;
            get { return _MissionElements; }
        }
        //
        //  Scenes
        //
        //  Current Scene
        public MissionScene CurrentScene
        {
            set => _CurrentScene = value;
            get { return _CurrentScene; }
        }
        //
        //  My Scenes
        public List<MissionScene> MyScenes
        {
            set => _MyScenes = value;
            get { return _MyScenes; }
        }
        //
        //  Scenario Designer
        public ScenarioDesigner MyScenarioDesigner
        {
            set => _MyScenarioDesigner = value;
            get { return _MyScenarioDesigner; }
        }
        
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
