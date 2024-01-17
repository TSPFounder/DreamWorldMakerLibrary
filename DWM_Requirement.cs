using System;
using System.Collections.Generic;
using CAD;
using SystemsEngineering;
using Test;

namespace MissionsNamespace
{
    public class DWM_Requirement : DWM_WorkItem
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _RequirementID;
        private String _Version;
        private String _ADO_ID;
        //
        //  Definitions
        //
        //  Requirement Type
        private RequirementTypeEnum _MyType;
        //
        //  System Type
        private SystemTypeEnum _SystemType;
        //
        //  Status
        private Status _MyStatus;
        //
        //  Given, When, Then
        private String _Given;
        private String _When;
        private String _Then;


        //  Owned & Owning Objects
        //
        //  My Mission
        private Mission _MyMission;
        //
        //  Use Case
        private UseCase _MyUseCase;
        //
        //  Verifications & Validations
        //
        //  Analysis
        private DWM_Analysis _CurrentAnalysis;
        private List<DWM_Analysis> _MyAnalyses;
        //
        //  Test
        private DWM_Test _CurrentTest;
        private List<DWM_Test> _MyTests;
        //
        //  Inspection
        private DWM_Inspection _CurrentInspection;
        private List<DWM_Inspection> _MyInspections;
        //
        //  Demo
        private DWM_Demo _CurrentDemo;
        private List<DWM_Demo> _MyDemos;
        // 
        //  Satisfied By
        private DWM_System _SatisfyingSystem;
        private DWM_Component _SatisfyingComponent;
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
        public enum RequirementTypeEnum
        {
            Mission = 0,
            Functional,
            Constraint,
            Environment,
            Interface,
            Performance,
            Physical,
            Cost,
            Other
        }
        //
        //  System Type Enum
        public enum SystemTypeEnum
        {
            Hardware,
            Software,
            Data,
            Other
        }
        //
        //  Status
        public enum Status
        {
            Proposed=0,
            Active,
            Resolved,
            Closed
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  DWM_REQUIREMENT CONSTRUCTOR
        //
        //  ************************************************************
        public DWM_Requirement()
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
        //  Requirement ID
        public String RequirementID
        {
            set => _RequirementID = value;
            get
            {
                return _RequirementID;
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
        //  ADO ID
        public String ADO_ID
        {
            set => _ADO_ID = value;
            get
            {
                return _ADO_ID;
            }
        }
        //
        //  Definitions
        //
        //  Requirement Type
        public RequirementTypeEnum MyType
        {
            set => _MyType = value;
            get
            {
                return _MyType;
            }
        }
        //
        //  System Type
        public SystemTypeEnum SystemType
        {
            set => _SystemType = value;
            get
            {
                return _SystemType;
            }
        }
        //
        //  Status
        public Status MyStatus
        {
            set => _MyStatus = value;
            get
            {
                return _MyStatus;
            }
        }
        //
        //  Given
        public String Given
        {
            set => _Given = value;
            get
            {
                return _Given;
            }
        }
        //
        //  When
        public String When
        {
            set => _When = value;
            get
            {
                return _When;
            }
        }
        //
        //  Then
        public String Then
        {
            set => _Then = value;
            get
            {
                return _Then;
            }
        }

        //  Owned & Owning Objects
        //
        //  My Mission
        public Mission MyMission
        {
            set => _MyMission = value;
            get
            {
                return _MyMission;
            }
        }
        //
        //  Use Case
        public UseCase MyUseCase
        {
            set => _MyUseCase = value;
            get
            {
                return _MyUseCase;
            }
        }
        //
        //  Analysis
        public DWM_Analysis CurrentAnalysis
        {
            set => _CurrentAnalysis = value;
            get { return _CurrentAnalysis; }
        }
        public List<DWM_Analysis> MyAnalyses
        {
            set => _MyAnalyses = value;
            get { return _MyAnalyses; }
        }
        //
        //  Test
        public DWM_Test CurrentTest
        {
            set => _CurrentTest = value;
            get { return _CurrentTest; }
        }
        public List<DWM_Test> MyTests
        {
            set => _MyTests = value;
            get { return _MyTests; }
        }
        //
        //  Inspection
        public DWM_Inspection CurrentInspection
        {
            set => _CurrentInspection = value;
            get { return _CurrentInspection; }
        }
        public List<DWM_Inspection> MyInspections
        {
            set => _MyInspections = value;
            get { return _MyInspections; }
        }
        //
        //  Demo
        public DWM_Demo CurrentDemo
        {
            set => _CurrentDemo = value;
            get { return _CurrentDemo; }
        }
        public List<DWM_Demo> MyDemos
        {
            set => _MyDemos = value;
            get { return _MyDemos; }
        }
        // 
        //  Satisfied By
        //
        //  Satisfying System
        public DWM_System SatisfyingSystem
        {
            set => _SatisfyingSystem = value;
            get { return _SatisfyingSystem; }
        }
        public DWM_Component SatisfyingComponent
        {
            set => _SatisfyingComponent = value;
            get { return _SatisfyingComponent; }
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
