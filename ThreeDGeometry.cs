using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;

namespace Mathematics
{
    public class ThreeDGeometry
    {
        //  *****************************************************************************************
        // DECLARATIONS
        //
        //  ************************************************************
        //  
        //  Identification
        private String _SegmentID;

        //  3-D Geometry Parameters
        //
        //  Booleans
        private Boolean _IsClosed;
        private Boolean _IsConstructionGeometry;
        private Boolean _IsSolid;

        // Geometry
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
        //  Primitives
       

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
            Curve = 0,
            Helix,
            Prism,
            Sphere,
            Cylinder,
            Cone,
            Tetrahedron,
            Octahedron,
            Conic,
            Spline
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  THREEDGEOMETRY CONSTRUCTOR
        //
        //  ************************************************************
        public ThreeDGeometry()
        {

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //  *****************************************************************************************
        // DECLARATIONS
        //
        //  ************************************************************
        //  
        //  Identification
        public String SegmentID
        {
            set { }
            get
            {
                return _SegmentID;
            }
        }

        //  3-D Geometry Parameters
        //
        //  Booleans
        public Boolean IsClosed
        {
            set { }
            get
            {
                return _IsClosed;
            }
        }
        public Boolean IsConstructionGeometry
        {
            set { }
            get
            {
                return _IsConstructionGeometry;
            }
        }
        public Boolean IsSolid
        {
            set { }
            get
            {
                return _IsSolid;
            }
        }

        // Geometry
        //
        //  Points
        public Point CurrentPoint
        {
            set { }
            get
            {
                return _CurrentPoint;
            }
        }
        public Point NextPoint
        {
            set { }
            get
            {
                return _NextPoint;
            }
        }
        public Point PreviousPoint
        {
            set { }
            get
            {
                return _PreviousPoint;
            }
        }
        public Point CenterPoint
        {
            set { }
            get
            {
                return _CenterPoint;
            }
        }
        public List<Point> MyPoints
        {
            set { }
            get
            {
                return _MyPoints;
            }
        }
        //
        //  Segments
        public Segment CurrentSegment
        {
            set { }
            get
            {
                return _CurrentSegment;
            }
        }
        public Segment NextSegment
        {
            set { }
            get
            {
                return _NextSegment;
            }
        }
        public Segment PreviousSegment
        {
            set { }
            get
            {
                return _PreviousSegment;
            }
        }
        public List<Segment> MySegments
        {
            set { }
            get
            {
                return _MySegments;
            }
        }

        //
        //  Primitives


        //
        //  Sketch
        public CAD_Sketch MySketch
        {
            set { }
            get
            {
                return _MySketch;
            }
        }
        //
        //  Coordinate System
        public CoordinateSystem MyCoordinateSystem
        {
            set { }
            get
            {
                return _MyCoordinateSystem;
            }
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
