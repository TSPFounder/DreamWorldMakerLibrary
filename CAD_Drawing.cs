using System;
using System.Collections.Generic;
using Mathematics;
using SystemsEngineering;
using Documents;

namespace CAD
{
    public class CAD_Drawing : DWM_Document
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //  Identification
        private String _Title;
        private String _DrawingNumber;
        private String _Revision;
        //
        //  Data
        private DocFormat _MyFormat;
        private DrawingSize _MyDrawingSize;
        //  Owned & Owning Objects
        //
        //  Dimensions
        private CAD_Dimension _CurrentDimension;
        private List<CAD_Dimension> _MyDimensions;
        //
        //  Construction Geometry
        private CAD_ConstructionGeometery _CurrentConstructionGeometry;
        private List<CAD_ConstructionGeometery> _MyConstructionGeometry;
        //
        //  Parameters
        private CAD_Parameter _CurrentParameter;
        private List<CAD_Parameter> _MyParameters;
        //
        //  CAD Drawing Sheets
        private CAD_DrawingSheet _CurrentCAD_DrawingSheet;
        private List<CAD_DrawingSheet> _MyDrawingSheets;
        //
        //  CAD Drawing Elements
        private CAD_DrawingElement _RevisionTable;
        private CAD_DrawingElement _CurrentElement;
        private List<CAD_DrawingElement> _DrawingElements;
        //
        //  Sketches
        private CAD_Sketch _CurrentSketch;
        private List<CAD_Sketch> _MySketches;
        //
        //  Parts
        private CAD_Part _CurrentPart;
        private List<CAD_Part> _MyParts;
        //
        //  Assembly
        private CAD_Assembly _MyAssembly;
        //
        //  CAD Model
        private CAD_Model _MyModel;
        //
        //  The CAD Manager
        private CAD_Manager _TheCAD_Manager;
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
        //  Drawing Document Format
        public enum DocFormat
        {
            CAD_File=0,
            DWG,
            PDF,
            PNG,
            JPG,
            Other
        }
        //
        //
        public enum CAD_AppName
        {
            SolidWorks=0,
            Fusion360,
            MechanicalDesktop,
            AutoCAD,
            Other
        }
        public enum DrawingSize
        {
            E=0,
            D,
            C,
            B,
            A
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_DRAWING CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_Drawing()
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
        public String Title
        {
            set => _Title = value;
            get { return _Title; }
        }
        //
        //  Drawing Number
        public String DrawingNumber
        {
            set => _DrawingNumber = value;
            get { return _DrawingNumber; }
        }
        //
        //  Revision
        public String Revision
        {
            set => _Revision = value;
            get { return _Revision; }
        }
        //
        //  Data
        //
        //  Document Format
        public DocFormat MyFormat
        {
            set => _MyFormat = value;
            get { return _MyFormat; }
        }
        //
        //  Drawing Size
        public DrawingSize MyDrawingSize
        {
            set => _MyDrawingSize = value;
            get { return _MyDrawingSize; }
        }
        //
        // Owned & Owning Objects
        //
        //  CAD Drawing Sheets
        public CAD_DrawingSheet CurrentCAD_DrawingSheet
        {
            set => _CurrentCAD_DrawingSheet = value;
            get { return _CurrentCAD_DrawingSheet; }
        }
        public List<CAD_DrawingSheet> MyDrawingSheets
        {
            set => _MyDrawingSheets = value;
            get { return _MyDrawingSheets; }
        }
        //
        // Revision Table
        public CAD_DrawingElement RevisionTable
        {
            set => _RevisionTable = value;
            get { return _RevisionTable; }
        }
        //
        //  CAD Drawing Elements
        public CAD_DrawingElement CurrentElement
        {
            set => _CurrentElement = value;
            get { return _CurrentElement; }
        }
        public List<CAD_DrawingElement> DrawingElements
        {
            set => _DrawingElements = value;
            get { return _DrawingElements; }
        }
        //
        //  Current Sketch
        public CAD_Sketch CurrentSketch
        {
            set => _CurrentSketch = value;
            get { return _CurrentSketch; }
        }
        //
        // CAD Sketches
        public List<CAD_Sketch> MyCAD_Sketches
        {
            set => _MySketches = value;
            get { return _MySketches; }
        }
        //
        // CAD Parts
        public CAD_Part CurrentPart
        {
            set => _CurrentPart = value;
            get { return _CurrentPart; }
        }
        public List<CAD_Part> MyParts
        {
            set => _MyParts = value;
            get { return _MyParts; }
        }
        //
        // CAD Assembly
        public CAD_Assembly MyAssembly
        {
            set => _MyAssembly = value;
            get { return _MyAssembly; }
        }
        //
        //  CAD Model
        public CAD_Model MyModel       
        {
            set => _MyModel = value;
            get { return _MyModel; }
        }
        //
        //  The CAD Manager
        public CAD_Manager TheCAD_Manager
        {
            set => _TheCAD_Manager = value;
            get { return _TheCAD_Manager; }
        }
        //
        //  Parameters
        //
        //  Current Parameter
        public CAD_Parameter CurrentParameter
        {
            set => _CurrentParameter = value;
            get
            {
                return _CurrentParameter;
            }
        }
        //
        //  My Parameters
        public List<CAD_Parameter> MyParameters
        {
            set => _MyParameters = value;
            get
            {
                return _MyParameters;
            }
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
        //  Construction Geometry
        public CAD_ConstructionGeometery CurrentConstructionGeometry
        {
            set => _CurrentConstructionGeometry = value;
            get { return _CurrentConstructionGeometry; }
        }
        public List<CAD_ConstructionGeometery> MyConstructionGeometry
        {
            set => _MyConstructionGeometry = value;
            get { return _MyConstructionGeometry; }
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        //
        //  Create a Revision Table
        public void CreateRevisionTable (String title, List<DWM_TableColumn> myColumns, List<DWM_TableRow> myRows)
        {

        }
        //  *****************************************************************************************
    }
}
