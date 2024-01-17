using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using SystemsEngineering;

namespace CAD
{
    public class CAD_Feature
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //
        //  Identification
        private String _Name;
        private String _Version;
        //
        //  Owned & Owning Objects
        //
        //  Dimensions
        //
        //  Dimensions
        private CAD_Dimension _CurrentDimension;
        private List<CAD_Dimension> _MyDimensions;
        //
        //  Sketches
        private CAD_Sketch _CurrentSketch;
        private List<CAD_Sketch> _Sketches;
        //
        //  Stations
        private CAD_Station _CurrentStation;
        private List<CAD_Station> _Stations;
        //
        //  My Model
        private CAD_Model _MyModel;
        //
        //  My Coordinate System
        private CoordinateSystem _Origin;
        //
        //  3-D Operations
        private List<Feature3DOperationEnum> _ThreeDimOperations;
        //
        //  Libraries
        private CAD_Library _CurrentLibrary;
        private List<CAD_Library> _MyLibraries;
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
        #region
        public enum GeometricFeatureTypeEnum
        {
            Hole = 0,
            Joint,
            Thread,
            Chamfer,
            Fillet,
            CounterBore,
            CounterSink,
            Bead,
            Boss,
            Mirror,
            Embossment,
            Rib,
            RoundedSlot,
            Gusset,
            Taper,
            SquareSlot,
            Shell,
            Web,
            Tab,
            Helicoil,
            RectangularPattern,
            CircularPattern,
            OtherPattern
        }
        public enum Feature3DOperationEnum
        {
            Extrude = 0,
            Revolve,
            Sweep,
            Loft
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_FEATURE CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_Feature()
        {
            this.ThreeDimOperations = new List<Feature3DOperationEnum>();
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
        //  Data
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
        // Owned & Owning Objects
        //
        // Current CAD Sketch
        public CAD_Sketch CurrentCAD_Sketch
        {
            set => _CurrentSketch = value;
            get { return _CurrentSketch; }
        }
        //
        //  CAD Sketches
        public List<CAD_Sketch> Sketches
        {
            set => _Sketches = value;
            get { return _Sketches; }
        }
        //
        // Current CAD Station
        public CAD_Station CurrentCAD_Station
        {
            set => _CurrentStation = value;
            get { return _CurrentStation; }
        }
        //
        //  CAD Stations
        public List<CAD_Station> Stations
        {
            set => _Stations = value;
            get { return _Stations; }
        }
        //
        // CAD Model
        public CAD_Model MyModel
        {
            set => _MyModel = value;
            get { return _MyModel; }
        }
        //
        // Origin
        public CoordinateSystem Origin
        {
            set => _Origin = value;
            get { return _Origin; }
        }
        //
        //  3-D Operations
        public List<Feature3DOperationEnum> ThreeDimOperations
        {
            set => _ThreeDimOperations = value;
            get { return _ThreeDimOperations; }
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
        #region
        public Boolean CreateHole()
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        //  *****************************************************************************************
    }
}
