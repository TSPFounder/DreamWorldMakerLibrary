using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;

namespace Mathematics
{
    public class TwoDGeometry
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //  
        //  Identification
        private String _GeometryID;
        //
        //  Owned & Owning Objects
        //  
        //  Cad Sketch
        private CAD_Sketch _MyCAD_Sketch;

        //
        //  Geometry Parameters
        //
        //  Booleans
        private Boolean _IsClosed;
        private Boolean _IsConstructionGeometry;

        //  Geometry
        //
        //  Points
        private Point _CurrentPoint;
        private Point _NextPoint;
        private Point _PreviousPoint;
        private Point _CenterPoint;
        private List<Point> _MyPoints;
        //
        //  Segments
        private Segment _CurrentSegment;
        private Segment _NextSegment;
        private Segment _PreviousSegment;
        private List<Segment> _MySegments;
        //
        //  Sketch
        private CAD_Sketch _MySketch;
        //
        //  Coordinate System
        private CoordinateSystem _MyCoordinateSystem;
        //  *****************************************************************************************


        //  ****************************************************************************************
        //  INITIALIZATIONS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        // ENUMERATIONS
        //
        //  ************************************************************
        public enum GeometryTypeEnum
        {
            Line = 0,
            Arc,
            Circle,
            Triangle,
            Rectangle,
            Quadratic,
            Spline
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  TWODGEOMETRY CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public TwoDGeometry()
        {
            this.MyPoints = new List<Point>();
            this._MySegments = new List<Segment>();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        //
        //  Geometry ID
        public String GeometryID
        {
            set {
                _GeometryID = value;
                }
            get
            {
                return _GeometryID;
            }
        }
        //
        // Owned & Owning Objects
        //
        // CAD Sketch
        public CAD_Sketch MyCAD_Sketch
        {
            set {
                  _MyCAD_Sketch = value;
                }
            get { return _MyCAD_Sketch; }
        }
        //
        //  Geometry Parameters
        //
        //  Booleans
        //
        //  Is a Closed Loop
        public Boolean IsClosed
        {
            set {
                   _IsClosed = value;
                }
            get
            {
                return _IsClosed;
            }
        }
        //
        //  Is Construction Geometry
        public Boolean IsConstructionGeometry
        {
            set {
                  _IsConstructionGeometry = value;
                }
            get
            {
                return _IsConstructionGeometry;
            }
        }
        //  Geometry
        //
        //  Points
        public Point CurrentPoint
        {
            set => _CurrentPoint = value;
            get { return _CurrentPoint; }
        }
        public Point NextPoint
        {
            set => _NextPoint = value;
            get { return _NextPoint; }
        }
        public Point PreviousPoint
        {
            set => _PreviousPoint = value;
            get { return _PreviousPoint; }
        }
        public Point CenterPoint
        {
            set => _CenterPoint = value;
            get { return _CenterPoint; }
        }
        public List<Point> MyPoints
        {
            set => _MyPoints = value;
            get { return _MyPoints; }
        }
        //
        //  Segments
        public Segment CurrentSegment
        {
            set => _CurrentSegment = value;
            get { return _CurrentSegment; }
        }
        public Segment NextSegment
        {
            set => _NextSegment = value;
            get { return _NextSegment; }
        }
        public Segment PreviousSegment
        {
            set => _PreviousSegment = value;
            get { return _PreviousSegment; }
        }
        public List<Segment> MySegments
        {
            set => _MySegments = value;
            get { return _MySegments; }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
