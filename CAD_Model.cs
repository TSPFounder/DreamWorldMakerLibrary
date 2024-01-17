using System;
using System.Collections.Generic;
using Mathematics;
using SystemsEngineering;
using Documents;

namespace CAD 
{
    public class CAD_Model : AppFile
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Version;
        private String _Path;
        //
        //  Enumerations
        private CAD_AppEnum _CAD_AppName;
        private CAD_ModelTypeEnum _ModelType;
        private CAD_FileTypeEnum _FileType;
        //
        //  Owned & Owning Objects
        //
        //  Sketches
        private CAD_Sketch _CurrentSketch;
        private List<CAD_Sketch> _MySketches;
        //
        //  Features
        private CAD_Feature _CurrentFeature;
        private List<CAD_Feature> _MyFeatures;
        //
        //  Parts
        private CAD_Part _CurrentPart;
        private List<CAD_Part> _MyParts;
        //
        //  Drawings
        private CAD_Drawing _CurrentDrawing;
        private List<CAD_Drawing> _MyDrawings;
        //
        //  Assemblies
        private CAD_Assembly _CurrentAssembly;
        private List<CAD_Assembly> _MyAssemblies;
        //
        //  CAD Application Models
        private AppFile _Fusion360Model;
        private AppFile _SolidWorksModel;
        private AppFile _MechanicalDesktopModel;
        private AppFile _BlenderModel;
        private AppFile _UnityModel;
        private AppFile _UnrealEngine4Model;
        private AppFile _UnrealEngine5Model;
        private AppFile _OtherCAD_Model;
        //
        //  Design Tables
        private CAD_DesignTable _SolidWorksDesignTable;
        private CAD_DesignTable _MechanicalDesktopDesignTable;
        private CAD_DesignTable _Fusion360DesignTable;
        //
        //  Bill of Materials
        private CAD_BoM _MyBoM;
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
        //  Model Type
        public enum CAD_ModelTypeEnum
        {
            Component = 0,
            Assembly,
            Drawing,
            Mesh,
            Other
        }
        //
        //  CAD App
        public enum CAD_AppEnum
        {
            Fusion360 = 0,
            Solidworks,
            Blender,
            UnReal4,
            UnReal5,
            Unity,
            Other
        }
        //
        //  File Type
        public enum CAD_FileTypeEnum
        {
            f3d = 0,
            f3z,
            sldprt,
            sldasm,
            slddrw,
            step,
            stl,
            sat,
            dxf,
            iges,
            fbx,
            obj,
            dae,
            x3d,
            wrl,
            other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_MODEL CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_Model()
        {
            this.MySketches = new List<CAD_Sketch>();
            this.MyFeatures = new List<CAD_Feature>();
            this.MyParts = new List<CAD_Part>();
            this.MyDrawings = new List<CAD_Drawing>();
            this.MyAssemblies = new List<CAD_Assembly>();

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
        //  Path
        public String Path
        {
            set => _Path = value;
            get { return _Path; }
        }
        //
        //  Enumerations
        //
        //  CAD Application Name
        public CAD_AppEnum CAD_AppName
        {
            set => _CAD_AppName = value;
            get { return _CAD_AppName; }
        }
        //
        //  CAD Model Type
        public CAD_ModelTypeEnum ModelType
        {
            set => _ModelType = value;
            get { return _ModelType; }
        }
        //
        //  CAD Model Type
        public CAD_FileTypeEnum FileType
        {
            set => _FileType = value;
            get { return _FileType; }
        }

        //
        // Owned & Owning Objects
        //
        // CAD Sketches
        //
        //  Current Sketch
        public CAD_Sketch CurrentSketch
        {
            set => _CurrentSketch = value;
            get { return _CurrentSketch; }
        }
        //
        //  My Sketches
        public List<CAD_Sketch> MySketches
        {
            set => _MySketches = value;
            get { return _MySketches; }
        }
        // CAD Features
        //
        //  Current Feature
        public CAD_Feature CurrentFeature
        {
            set => _CurrentFeature = value;
            get { return _CurrentFeature; }
        }
        //
        //  My Features
        public List<CAD_Feature> MyFeatures
        {
            set => _MyFeatures = value;
            get { return _MyFeatures; }
        }
        //
        // CAD Parts
        //
        //  Current Part
        public CAD_Part CurrentPart
        {
            set => _CurrentPart = value;
            get { return _CurrentPart; }
        }
        //
        //  My Parts
        public List<CAD_Part> MyParts
        {
            set => _MyParts = value;
            get { return _MyParts; }
        }
        //
        // CAD Drawings
        //
        //  Current Part
        public CAD_Drawing CurrentDrawing
        {
            set => _CurrentDrawing = value;
            get { return _CurrentDrawing; }
        }
        //
        //  My Drawings
        public List<CAD_Drawing> MyDrawings
        {
            set => _MyDrawings = value;
            get { return _MyDrawings; }
        }
        //
        // CAD Assemblies
        //
        //  Current Assembly
        public CAD_Assembly CurrentAssembly
        {
            set => _CurrentAssembly = value;
            get { return _CurrentAssembly; }
        }
        public List<CAD_Assembly> MyAssemblies
        {
            set => _MyAssemblies = value;
            get { return _MyAssemblies; }
        }
        //
        //  CAD Application Models
        public AppFile Fusion360Model
        {
            set => _Fusion360Model = value;
            get { return _Fusion360Model; }
        }
        public AppFile SolidWorksModel
        {
            set => _SolidWorksModel = value;
            get { return _SolidWorksModel; }
        }
        public AppFile MechanicalDesktopModel
        {
            set => _MechanicalDesktopModel = value;
            get { return _MechanicalDesktopModel; }
        }
        public AppFile BlenderModel
        {
            set => _BlenderModel = value;
            get { return _BlenderModel; }
        }
        public AppFile UnityModel
        {
            set => _UnityModel = value;
            get { return _UnityModel; }
        }
        public AppFile UnrealEngine4Model
        {
            set => _UnrealEngine4Model = value;
            get { return _UnrealEngine4Model; }
        }
        public AppFile UnrealEngine5Model
        {
            set => _UnrealEngine5Model = value;
            get { return _UnrealEngine5Model; }
        }
        public AppFile OtherCAD_Model
        {
            set => _OtherCAD_Model = value;
            get { return _OtherCAD_Model; }
        }
        //
        //  Design Tables
        //
        //  SolidWorks Design Table
        public CAD_DesignTable SolidWorksDesignTable
        {
            set => _SolidWorksDesignTable = value;
            get
            {
                return _SolidWorksDesignTable;
            }
        }
        //
        //  Mechanical Desktop Design Table
        public CAD_DesignTable MechanicalDesktopDesignTable
        {
            set => _MechanicalDesktopDesignTable = value;
            get
            {
                return _MechanicalDesktopDesignTable;
            }
        }
        //
        //  Fusion360 Design Table
        public CAD_DesignTable Fusion360DesignTable
        {
            set => _Fusion360DesignTable = value;
            get
            {
                return _Fusion360DesignTable;
            }
        }
        //
        //  Bill of Material
        public CAD_BoM MyBoM
        {
            set => _MyBoM = value;
            get
            {
                return _MyBoM;
            }
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        //
        //  Create a Fusion360 Model
        public Boolean CreateFusion360Model()
        {
            try
            {
                this.Fusion360Model = new AppFile();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //  *****************************************************************************************
    }
}
