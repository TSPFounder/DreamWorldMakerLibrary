using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;

namespace Mathematics
{
    public class Primitive
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************

        //
        //  Identification
        private String _Name;
        private String _Version;

        //
        //  Primitive Properties
        private Boolean _Is2D;
        private TwoDPrimitiveTypeEnum _TwoDType;
        private ThreeDPrimitiveTypeEnum _ThreeDType;

        //
        // Geometry
        //
        //  Points
        private Point _CurrentPoint;
        private Point _NextPoint;
        private Point _PreviousPoint;
        private Point _CenterPoint;
        private List<Point> _MyPoints;
        private List<Point> _Vertices;
        //
        //  Segments
        private Segment _CurrentSegment;
        private Segment _NextSegment;
        private Segment _PreviousSegment;
        private List<Segment> _MySegments;
        //
        //  Surfaces

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
        public enum TwoDPrimitiveTypeEnum
        {
            Square = 0,
            Circle,
            Triangle,
            Rectangle,
            Pentagon,
            Hexagon,
            Septagon,
            Octagon,
            Other
        }
        public enum ThreeDPrimitiveTypeEnum
        {
            Sphere = 0,
            Cube,
            Cone,
            Cylinder,
            Prism,
            Tetrahedron,
            Torus,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PRIMITIVE CONSTRUCTOR
        //
        //  ************************************************************
        public Primitive()
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
            set { }
            get
            {
                return _Name;
            }
        }
        //  Version
        public String Version
        {
            set { }
            get
            {
                return _Version;
            }
        }
        //  Primitive Properties
        //
        //  Is Two-Dimensional
        public Boolean Is2D
        {
            set { }
            get
            {
                return _Is2D;
            }
        }
        //  Is Two-Dimensional
        public TwoDPrimitiveTypeEnum TwoDType
        {
            set { }
            get
            {
                return _TwoDType;
            }
        }
        //  Is Two-Dimensional
        public ThreeDPrimitiveTypeEnum ThreeDType
        {
            set { }
            get
            {
                return _ThreeDType;
            }
        }
        //  Geometry
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
        public List<Point> Vertices
        {
            set { }
            get
            {
                return _Vertices;
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
