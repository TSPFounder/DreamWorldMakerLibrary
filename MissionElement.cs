using CAD;
using System;
using System.Collections.Generic;
using SystemsEngineering;

namespace MissionsNamespace
{
    public class MissionElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _MissionElementID;
        private String _Name;
        private String _Description;
        //
        //  Definitions
        private ElementTypeEnum _MyType;
        //
        //  Owned & Owning Objects
        //
        //  Mission & Scenarios
        private Mission _MyMission;
        private MissionScenario _CurrentScenario;
        private List<MissionScenario> _MyScenarios;
        //
        //  Controls
        
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
        //
        //  Element Type
        public enum ElementTypeEnum
        {
            Stakeholder = 0,
            User,
            Adversary,
            SoS,
            SoI,
            Subsystem,
            ConfigurationItem,
            UseCase,
            MissionScenario,
            MissionScene,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  MISSIONELEMENT CONSTRUCTOR
        //
        //  ************************************************************
        public MissionElement()
        {
            
            //
            //  Scenarios
            this.MyScenarios = new List<MissionScenario>();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        //
        //  Mission ID
        public String MissionElementID
        {
            set => _MissionElementID = value;
            get { return _MissionElementID; }
        }
        //
        //  Mission Name
        public String Name
        {
            set => _Name = value;
            get { return _Name; }
        }
        //
        //  Mission Description
        public String Description
        {
            set => _Description = value;
            get { return _Description; }
        }
        //
        //  Definitions
        public ElementTypeEnum MyType
        {
            set => _MyType = value;
            get { return _MyType; }
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
        //
        //  Current Scenario
        public MissionScenario CurrentScenario
        {
            set => _CurrentScenario = value;
            get { return _CurrentScenario; }
        }
        public List<MissionScenario> MyScenarios
        {
            set => _MyScenarios= value;
            get { return _MyScenarios; }
        }
        //
        //  Controls
        
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

        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
