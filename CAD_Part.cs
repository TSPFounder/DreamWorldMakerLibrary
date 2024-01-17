using System;
using System.Collections.Generic;
using Mathematics;
using SystemsEngineering;


namespace CAD
{
    public class CAD_Part
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Version;
        private String _PartNumber;
        private String _Description;
        //
        //  Data
        //
        //  Mass Properties Objects
        private MassProperties _CurrentMassProperties;
        private List<MassProperties> _MyMassPropertiesList;
        //
        //  Owned & Owning Objects
        //
        //  Models
        private CAD_Model _CurrentModel;
        private List<CAD_Model> _MyModels;
        // 
        //  Sketches
        private CAD_Sketch _CurrentSketch;
        private List<CAD_Sketch> _MySketches;
        //
        //  Features
        private CAD_Feature _CurrentFeature;
        private List<CAD_Feature> _MyFeatures;
        //
        //  Bodies
        private CAD_Body _CurrentBody;
        private List<CAD_Body> _MyBodies;
        //
        //  Drawings
        private CAD_Drawing _CurrentDrawing;
        private List<CAD_Drawing> _MyDrawings;
        //
        //  Dimensions
        private CAD_Dimension _CurrentDimension;
        private List<CAD_Dimension> _MyDimensions;
        //
        //  Assembly
        private CAD_Assembly _MyAssembly;
        //
        //  CAD Application
        private CAD_AppEnum _CAD_Application;
        //
        //  Materials
        private List<Material> _MyMaterials;
        //
        //  Mass Properties
        private MassProperties _MyMassProperties;
        //
        //  Libraries
        private CAD_Library _CurrentLibrary;
        private List<CAD_Library> _MyLibraries;
        //
        //  GUI
        //
        //  TreeNode
        private TreeNode _MyTreeNode;

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
        public enum CAD_AppEnum
        {
            Fusion360 = 0,
            Solidworks,
            Blender,
            Simulink,
            FEMAP,
            UnrealEngine,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_PART CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_Part()
        {
            // 
            //  CAD Objects
            this._MySketches = new List<CAD_Sketch>();
            this._MyFeatures = new List<CAD_Feature>();
            this._MyBodies =new List<CAD_Body>();
            this.MyDrawings = new List<CAD_Drawing>();
            this.MyDimensions = new List<CAD_Dimension>();
            this.MyLibraries = new List<CAD_Library>();
            //
            //  Materials
            this.MyMaterials = new List<Material>();
            //
            //  Mass Properties
            this.MyMassProperties = new MassProperties();
            this.MyMassProperties.MyCAD_Part = this;

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
            get { return _Name; }
        }
        //
        //  Version
        public String Version
        {
            set => _Version = value;
            get { return _Version; }
        }
        //
        //  Part Number
        public String PartNumber
        {
            set => _PartNumber = value;
            get { return _PartNumber; }
        }
        //
        //  Description
        public String Description
        {
            set => _Description = value;
            get { return _Description; }
        }
        //
        //  Data
        //
        //  Mass Properties Objects
        //
        // Current Mass Properties
        public MassProperties CurrentMassProperties
        {
            set => _CurrentMassProperties = value;
            get { return _CurrentMassProperties; }
        }
        //
        //  Mass Properties List
        public List<MassProperties> MyMassPropertiesList
        {
            set => _MyMassPropertiesList = value;
            get { return _MyMassPropertiesList; }
        }
        //  Owned & Owning Objects
        // 
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
        //
        //  Features
        public CAD_Feature CurrentFeature
        {
            set => _CurrentFeature = value;
            get { return _CurrentFeature; }
        }
        public List<CAD_Feature> MyFeatures
        {
            set => _MyFeatures = value;
            get { return _MyFeatures; }
        }
        //
        //  Bodies
        public CAD_Body CurrentBody
        {
            set => _CurrentBody = value;
            get { return _CurrentBody; }
        }
        public List<CAD_Body> MyBodies
        {
            set => _MyBodies = value;
            get { return _MyBodies; }
        }
        //
        //  Drawings
        public CAD_Drawing CurrentDrawing
        {
            set => _CurrentDrawing = value;
            get { return _CurrentDrawing; }
        }
        public List<CAD_Drawing> MyDrawings
        {
            set => _MyDrawings = value;
            get { return _MyDrawings; }
        }
        //
        //  Mass Properties
        public MassProperties MyMassProperties
        {
            set => _MyMassProperties = value;
            get { return _MyMassProperties; }
        }
        //
        //  Dimensions
        //
        //  Current Dimension
        public CAD_Dimension CurrentDimension
        {
            set => _CurrentDimension = value;
            get { return _CurrentDimension; }
        }
        //
        //  Current Dimension
        public List<CAD_Dimension> MyDimensions
        {
            set => _MyDimensions = value;
            get { return _MyDimensions; }
        }
        //
        //  Assembly
        public CAD_Assembly MyAssembly
        {
            set => _MyAssembly = value;
            get { return _MyAssembly; }
        }
        //
        //  Materials
        public List<Material> MyMaterials
        {
            set => _MyMaterials = value;
            get { return _MyMaterials; }
        }
        //
        //  CAD Application
        public CAD_AppEnum CAD_Application
        {
            set => _CAD_Application = value;
            get { return _CAD_Application; }
        }
        //
        //  GUI
        //
        //  TreeNode
        public TreeNode MyTreeNode
        {
            set => _MyTreeNode = value;
            get { return _MyTreeNode; }
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
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        //
        //  Extrude Sketch
        public bool ExtrudeSketch()
        {
            try
            {
                
                //_CurrentVisioApp.Visible = true;
                return true;
            }

            catch
            {
                System.Windows.MessageBox.Show("Could Not Extrude the Sketch!");
                return false;
            }
        }
        //  *****************************************************************************************
    }
}
