using System.Collections.Generic;
using Mathematics;
using SystemsEngineering;
using Project;
using MissionsNamespace;
using Documents;

namespace CAD
{
    public class CAD_Manager
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //
        //  Owned & Owning Objects
        //
        //  Managers
        //
        //  Applicaton Manager
        private ApplicationManager _TheApplicationManager;
        //
        //  System Manager
        private DWM_SystemManager _TheSystemManager;
        //
        //  Project Manager
        private DWM_ProjectManager _TheProjectManager;
        //
        //  Mission Manager
        private MissionManager _TheMissionManager;
        //
        //  Requirement Manager
        private DWM_RequirementsManager _TheRequirementsManager;
        //
        //  Document Manager
        private DocumentManager _MyDocumentManager;
        //
        //  File Manager
        private DWM_FileManager _TheFileManager;
        //
        //  Applications
        private CAD_App _CurrentApp;
        private List<CAD_App> _MyApps;
        //
        //  Models
        private CAD_Model _CurrentModel;
        private List<CAD_Model> _MyModels;

        //  Assemblies
        private CAD_Assembly _CurrentAssembly;
        private List<CAD_Assembly> _CAD_Assemblies;

        // Parts
        private CAD_Part _CurrentPart;
        private List<CAD_Part> _CAD_Parts;

        // Components
        private CAD_Component _CurrentComponent;
        private List<CAD_Component> _CAD_Components;

        // Bodies
        private CAD_Body _CurrentBody;
        private List<CAD_Body> _CAD_Bodies;

        // Features
        private CAD_Feature _CurrentFeature;
        private List<CAD_Feature> _CAD_Features;

        // Drawings
        private CAD_Drawing _CurrentDrawing;
        private List<CAD_Drawing> _CAD_Drawings;

        //  Sketches
        private CAD_Sketch _CurrentSketch;
        private List<CAD_Sketch> _MySketches;
        //
        //  Libraries
        private CAD_Library _CurrentLibrary;
        private List<CAD_Library> _MyLibraries;
        //
        //  Geometry
        private TwoDGeometry _CurrentGeometry;
        private List<TwoDGeometry> _MyGeometries;
        
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
        //  CAD_MANAGER CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_Manager()
        {
            //
            //  Applications
            this.MyApps = new List<CAD_App>();
            //
            //  Models
            this._MyModels = new List<CAD_Model>();
            //
            //  Assemblies
            this.CAD_Assemblies = new List<CAD_Assembly>();
            //
            //  CAD Parts
            this.CAD_Parts = new List<CAD_Part>();
            //
            //  CAD Components
            this._CAD_Components = new List<CAD_Component>();
            //
            //  CAD Bodies
            this.CAD_Bodies = new List<CAD_Body>();
            //
            //  CAD Features
            this.CAD_Features = new List<CAD_Feature>();
            //
            //  CAD Drawings
            this.CAD_Drawings = new List<CAD_Drawing>();
            //
            //  CAD Sketches
            this.MySketches = new List<CAD_Sketch>();
            //
            //  CAD Geometry
            this.MyGeometries = new List<TwoDGeometry>();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region
        // Owned & Owning Objects
        //
        //  Applications
        public CAD_App CurrentApp
        {
            set => _CurrentApp = value;
            get { return _CurrentApp; }
        }
        public List<CAD_App> MyApps
        {
            set => _MyApps = value;
            get { return _MyApps; }
        }
        //
        //  CAD Models
        //
        // Current CAD Models
        public CAD_Model CurrentModel
        {
            set => _CurrentModel = value;
            get { return _CurrentModel; }
        }
        //
        // My CAD Models
        public List<CAD_Model> MyModels
        {
            set => _MyModels = value;
            get { return _MyModels; }
        }
        //
        //  Assemblies
        public CAD_Assembly CurrentAssembly
        {
            set => _CurrentAssembly = value;
            get { return _CurrentAssembly; }
        }
        public List<CAD_Assembly> CAD_Assemblies
        {
            set => _CAD_Assemblies = value;
            get { return _CAD_Assemblies; }
        }
        //
        // Parts
        public CAD_Part CurrentPart
        {
            set => _CurrentPart = value;
            get { return _CurrentPart; }
        }
        public List<CAD_Part> CAD_Parts
        {
            set => _CAD_Parts = value;
            get { return _CAD_Parts; }
        }
        //
        // Components
        public CAD_Component CurrentComponent
        {
            set => _CurrentComponent = value;
            get { return _CurrentComponent; }
        }
        public List<CAD_Component> CAD_Component
        {
            set => _CAD_Components = value;
            get { return _CAD_Components; }
        }
        //
        // Bodies
        public CAD_Body CurrentBody
        {
            set => _CurrentBody = value;
            get { return _CurrentBody; }
        }
        public List<CAD_Body> CAD_Bodies
        {
            set => _CAD_Bodies = value;
            get { return _CAD_Bodies; }
        }
        //
        // Features
        public CAD_Feature CurrentFeature
        {
            set => _CurrentFeature = value;
            get { return _CurrentFeature; }
        }
        public List<CAD_Feature> CAD_Features
        {
            set => _CAD_Features = value;
            get { return _CAD_Features; }
        }

        // Drawings
        public CAD_Drawing CurrentDrawing
        {
            set => _CurrentDrawing = value;
            get { return _CurrentDrawing; }
        }
        public List<CAD_Drawing> CAD_Drawings
        {
            set => _CAD_Drawings = value;
            get { return _CAD_Drawings; }
        }

        //  Sketches
        public CAD_Sketch CurrentSketch
        {
            set => _CurrentSketch = value;
            get { return _CurrentSketch; }
        }
        public List<CAD_Sketch> MySketches
        {
            set => _MySketches = value;
            get { return _MySketches; }
        }

        //  Two Dimensional Geometry
        public TwoDGeometry CurrentGeometry
        {
            set => _CurrentGeometry = value;
            get { return _CurrentGeometry; }
        }
        public List<TwoDGeometry> MyGeometries
        {
            set => _MyGeometries = value;
            get { return _MyGeometries; }
        }
        //
        //  Controls
        //
        //  Managers
        //
        //  Application Manager
        public ApplicationManager TheApplicationManager
        {
            set => _TheApplicationManager = value;
            get { return _TheApplicationManager; }
        }
        //
        //  Mission Mananger
        public MissionManager TheMissionManager
        {
            set => _TheMissionManager = value;
            get { return _TheMissionManager; }
        }
        //
        //  Requirements Manager
        public DWM_RequirementsManager TheRequirementsManager
        {
            set => _TheRequirementsManager = value;
            get { return _TheRequirementsManager; }
        }
        //
        //  Systems Manager
        public DWM_SystemManager TheSystemManager
        {
            set => _TheSystemManager = value;
            get { return _TheSystemManager; }
        }
        //
        //  Project Manager
        public DWM_ProjectManager TheProjectManager
        {
            set => _TheProjectManager = value;
            get { return _TheProjectManager; }
        }
        //
        //  Documents Manager
        public DocumentManager TheDocumentManager
        {
            set => _MyDocumentManager = value;
            get { return _MyDocumentManager; }
        }
        //
        //  File Manager
        public DWM_FileManager TheFileManager
        {
            set => _TheFileManager = value;
            get { return _TheFileManager; }
        }
        
        //
        //  Libraries
        //
        //  Current Library
        public CAD_Library CurrentLibrary
        {
            set => _CurrentLibrary = value;
            get { return _CurrentLibrary; }
        }
        //
        //  My Libraries
        public List<CAD_Library> MyLibraries
        {
            set => _MyLibraries = value;
            get { return _MyLibraries; }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        //
        //  Create a Sketch
        public void CreateF360Sketch(CAD_SketchPlane SketchPlane)
        {
            if (this._CurrentApp.Name.Equals(0))
            {
                //  Initilizations
                this._CurrentApp.createSketch(SketchPlane);                
            }
        }
        //
        //  Populate the Main Window Tree
        public void PopulateTree(CAD_Part currentPart)
        {
            // private TreeNode _Test Treenode;
            //this.TheMainWindow.MainWindowTreeView.Items.Add(currentPart);
        }
        //  *****************************************************************************************
    }
}
