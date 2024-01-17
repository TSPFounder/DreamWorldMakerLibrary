using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissionsNamespace;
using SystemsEngineering;
//using UModelLib;

namespace Project
{
    public class DWM_Project
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _ID;
        //
        //  Definitions
        private String _Description;
        
        //
        //  Owned & Owning Objects
        //
        //  Missions
        private List<Mission> _MyMissions;
        //
        //  System of System
        private SystemOfSystems _MySoS;
        //
        //  Systems of Interest
        private SystemOfInterest _CurrentSoI;
        private List<SystemOfInterest> _MySystemsOfInterest;
        //
        //  App Projects
        //
        //  Matlab Projects
        private String _CurrentMatlabProject;
        private List<String> _MyMatlabProjects;
        //
        //  UnrealEngine Projects
        private String _CurrentUnrealEngineProject;
        private String _MyUnrealEngineProjects;
        //
        //  Unity Projects
        private String _CurrentUnityProject;
        private String _MyUnityProjects;
        //
        //  MS Project Objects
        //  
        //  My MS Project
        private Microsoft.Office.Interop.MSProject.Project _MyMS_Project;
        //
        //  My MS Project Subprojects
        private List<Microsoft.Office.Interop.MSProject.Subproject> _MyMS_Subprojects;
        //
        //  My MS Project Task Groups
        private List<Microsoft.Office.Interop.MSProject.TaskGroups> _MyMS_TaskGroups;
        //
        //  My MS Project Tasks
        private Microsoft.Office.Interop.MSProject.Task _CurrentMS_Task;
        private List<Microsoft.Office.Interop.MSProject.Task> _MyMS_Tasks;
        //
        //  Designs
        //
        //  Current Design
        private DWM_Design _CurrentDesign;
        //
        //  List of Designs
        private List<DWM_Design> _MyDesigns;
        //
        //  Analysis
        //
        //  Current Design
        private DWM_Analysis _CurrentAnalysis;
        //
        //  List of Designs
        private List<DWM_Analysis> _MyAnalyses;

        //private WBS_Manager _MyWBS_Manager;
        //
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
        //  DWM_PROJECT CONSTRUCTOR
        //
        //  ************************************************************
        public DWM_Project() 
        {
            
            this.MyMissions = new List<Mission>();
            this.MySoS = new SystemOfSystems();
            //
            //  MS Project Object Lists
            //
            //  MS Projects Subprojects List
            this.MyMS_Subprojects = new List<Microsoft.Office.Interop.MSProject.Subproject>();
            //
            //  MS Projects Task Groups 
            this.MyMS_TaskGroups = new List<Microsoft.Office.Interop.MSProject.TaskGroups>();
            //
            //  MS Projects Tasks List
            this.MyMS_Tasks = new List<Microsoft.Office.Interop.MSProject.Task>();

            
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
           set  => _Name = value;
            get { return _Name; }
        }
        //
        //  ID
        public String ID
        {
            set => _Name = ID;
            get { return _ID; }
        }
        //
        //  Definitions
        //
        //  Description
        public String Description
        {
            set => _Description = value;
            get { return _Description; }
        }
        //  Owned & Owning Objects
        //
        //  Missions
        public List<Mission> MyMissions
        {
            set => _MyMissions = value;
            get { return _MyMissions; }
        }
        //
        //  System of System
        public SystemOfSystems MySoS
        {
            set => _MySoS = value;
            get { return _MySoS; }
        }
        //
        //  Systems of Interest
        //
        //  Current SoI
        public SystemOfInterest CurrentSoI
        {
            set => _CurrentSoI = value;
            get { return _CurrentSoI; }
        }
        public List<SystemOfInterest> MySystemsOfInterest
        {
            set => _MySystemsOfInterest = value;
            get { return _MySystemsOfInterest; }
        }
        //
        //  Designs
        //
        //  Current Design
        public DWM_Design CurrentDesign
        {
            set => _CurrentDesign = value;
            get { return _CurrentDesign; }
        }
        //
        //  List of Designs
        public List<DWM_Design> MyDesigns
        {
            set => _MyDesigns = value;
            get { return _MyDesigns; }
        }
        //
        //  Analysis
        //
        //  Current Design
        public DWM_Analysis CurrentAnalysis
        {
            set => _CurrentAnalysis = value;
            get { return _CurrentAnalysis; }
        }
        //
        //  List of Designs
        public List<DWM_Analysis> MyAnalyses
        {
            set => _MyAnalyses = value;
            get { return _MyAnalyses; }
        }
        //
        //  App Projects
        //
        //  Matlab Projects
        public String CurrentMatlabProject
        {
            set => _CurrentMatlabProject = value;
            get { return _CurrentMatlabProject; }
        }
        public List<String> MyMatlabProjects
        {
            set => _MyMatlabProjects = value;
            get { return _MyMatlabProjects; }
        }
        //
        //  UnrealEngine Projects
        public String CurrentUnrealEngineProject
        {
            set => _CurrentUnrealEngineProject = value;
            get { return _CurrentUnrealEngineProject; }
        }
        public String MyUnrealEngineProjects
        {
            set => _MyUnrealEngineProjects = value;
            get { return _MyUnrealEngineProjects; }
        }
        //
        //  Unity Projects
        public String CurrentUnityProject
        {
            set => _CurrentUnityProject = value;
            get { return _CurrentUnityProject; }
        }
        public String MyUnityProjects
        {
            set => _MyUnityProjects = value;
            get { return _MyUnityProjects; }
        }
        //
        //  MS Project Objects
        //  
        //  My MS Project
        public Microsoft.Office.Interop.MSProject.Project MyMS_Project
        {
            set => _MyMS_Project = value;
            get { return _MyMS_Project; }
        }
        //
        //  My MS Project Subprojects
        public List<Microsoft.Office.Interop.MSProject.Subproject> MyMS_Subprojects
        {
            set => _MyMS_Subprojects = value;
            get { return _MyMS_Subprojects; }
        }
        //
        //  My MS Project Task Groups
        public List<Microsoft.Office.Interop.MSProject.TaskGroups> MyMS_TaskGroups
        {
            set => _MyMS_TaskGroups = value;
            get { return _MyMS_TaskGroups; }
        }
        //
        //  MS Project Tasks
        //
        //  Current MS Project Task
        public Microsoft.Office.Interop.MSProject.Task CurrentMS_Task
        {
            set => _CurrentMS_Task = value;
            get { return _CurrentMS_Task; }
        }
        //
        //  My MS Project Tasks
        public List<Microsoft.Office.Interop.MSProject.Task> MyMS_Tasks
        {
             set => _MyMS_Tasks = value;
            get { return _MyMS_Tasks; }
        }
        /*
        public WBS_Manager MyWBS_Manager
        {
            set => _MyWBS_Manager = value;
            get { return _MyWBS_Manager; }
        }
        */
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
