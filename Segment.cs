using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;

namespace Mathematics
{
    public class Segment
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _SegmentID;
        //
        //   Is an Edge
        private Boolean _IsEdge;

        //  Geometry
        //  
        //  Points
        private Point _StartPoint;
        private Point _EndPoint;
        private Point _MidPoint;
        private Point _FocalPoint1;
        private Point _FocalPoint2;
        private Point _Vertex;
        private List<Point> _MyPoints;
        private List<Point> _WeightPoints;
        //
        //  Dimensions
        private CAD_Dimension _CurrentDimension;
        //
        //  Vector
        private Vector _CurrentVector;
        private List<Vector> _MyVectors;
        //
        //  Coordinate System
        private CoordinateSystem _MyCoordinateSystem;
        //
        //  Sketch
        private CAD_Sketch _MySketch;
        //
        //  Segments
        private Segment _PreviousSegment;
        private Segment _NextSegment;
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
        public enum SegmentTypeEnum
        {
            Line = 0,
            Arc,
            Circle,
            Quadratic,
            Spline
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SEGMENT CONSTRUCTOR
        //
        //  ************************************************************
        public Segment()
        {
            this.StartPoint = new Point();
            this.EndPoint = new Point();
            this.MyPoints = new List<Point>();
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
        public String SegmentID
        {
            set => _SegmentID = value;
            get { return _SegmentID; }
        }
        //
        //  Is an Edge
        public Boolean IsEdge
        {
            set => _IsEdge = value;
            get { return _IsEdge; }
        }
        //  Geometry
        //  
        //  Points
        public Point StartPoint
        {
            set => _StartPoint = value;
            get { return _StartPoint; }
        }
        public Point EndPoint
        {
            set => _EndPoint = value;
            get { return _EndPoint; }
        }
        public Point MidPoint
        {
            set => _MidPoint = value;
            get { return _MidPoint; }
        }
        public Point FocalPoint1
        {
            set => _FocalPoint1 = value;
            get { return _FocalPoint1; }
        }
        public Point FocalPoint2
        {
            set => _FocalPoint2 = value;
            get { return _FocalPoint2; }
        }
        public Point Vertex
        {
            set => _Vertex = value;
            get { return _Vertex; }
        }
        public List<Point> MyPoints
        {
            set => _MyPoints = value;
            get { return _MyPoints; }
        }
        //
        //  Weight Points
        public List<Point> WeightPoints
        {
            set => _WeightPoints = value;
            get { return _WeightPoints; }
        }
        //
        //  Vectors
        //
        //  Current Vector
        public Vector CurrentVector
        {
            set => _CurrentVector = value;
            get { return _CurrentVector; }
        }
        //
        //  My Vectors
        public List<Vector> MyVectors
        {
            set => _MyVectors = value;
            get { return _MyVectors; }
        }
        //
        //  Coordinate System
        public CoordinateSystem MyCoordinateSystem
        {
            set => _MyCoordinateSystem = value;
            get { return _MyCoordinateSystem; }
        }
        //
        //  Sketch
        public CAD_Sketch MySketch
        {
            set => _MySketch = value;
            get { return _MySketch; }
        }
        //
        //  Segments
        public Segment PreviousSegment
        {
            set => _PreviousSegment = value;
            get { return _PreviousSegment; }
        }
        public Segment NextSegment
        {
            set => _NextSegment = value;
            get { return _NextSegment; }
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
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
