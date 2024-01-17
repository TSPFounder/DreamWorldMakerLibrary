using System;
using System.Collections.Generic;
using CAD;
using SystemsEngineering;

namespace MissionsNamespace
{
    public class Role
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _RoleID;
        //
        //  Definition
        //
        //  Description
        private String _RoleDescription;
        //
        //  Group
        private RoleGroupEnum _MyGroup;
        //
        //  Developer Role
        private DeveloperRoleEnum _DeveloperRole;
        //
        //  Adversarial Role
        private AdversaryRoleEnum _AdversarialRole;
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
        //  Role Group
        public enum RoleGroupEnum
        {
            Founder = 0,
            Supporter,
            Developer,
            User,
            Regulator,
            Adversary,
            Other
        }
        //
        //  Developer Role
        public enum DeveloperRoleEnum
        {
            ProjectManager = 0,
            SystemsEngineer,
            DesignEngineer,
            AnalysisEngineer,
            ManufacturingEngineer,
            QualityEngineer,
            TestEngineer,
            FacilitiesEngineer,
            SoftwareEngineer,
            SafetyEngineer,
            ConfigurationManager,
            ResourceManager,
            IT_Manager,
            CommunicationsManager,
            CostEstimator,
            RiskManager,
            Other
        }
        //
        //  Adversary Role
        public enum AdversaryRoleEnum
        {
            Thief = 0,
            Attacker,
            Hacker,
            Arsonist,
            Poacher,
            Trespasser,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ROLE CONSTRUCTOR
        //
        //  ************************************************************
        public Role()
        {

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        //
        //  First Name
        public String Name
        {
            set => _Name = value;
            get
            {
                return _Name;
            }
        }
        //
        //  Role ID
        public String RoleID
        {
            set => _RoleID = value;
            get
            {
                return _RoleID;
            }
        }
        //
        //  Definition
        //
        //  Description
        public String RoleDescription
        {
            set => _RoleDescription = value;
            get
            {
                return _RoleDescription;
            }
        }
        //
        //  Group
        public RoleGroupEnum MyGroup
        {
            set => _MyGroup = value;
            get
            {
                return _MyGroup;
            }
        }
        //
        //  Developer Role
        public DeveloperRoleEnum DeveloperRole
        {
            set => _DeveloperRole = value;
            get
            {
                return _DeveloperRole;
            }
        }
        //
        //  Adversarial Role
        public AdversaryRoleEnum AdversarialRole
        {
            set => _AdversarialRole = value;
            get
            {
                return _AdversarialRole;
            }
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
