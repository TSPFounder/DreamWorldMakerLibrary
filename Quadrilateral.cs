using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;

namespace Mathematics
{
    public class Quadrilateral : Primitive
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //  
        //  Identification
        private String _QuadrilateralID;
        //
        //  Is Dart
        private Boolean _IsDart;
        //
        //  Is Trapezoid
        private Boolean _IsTrapezoid;
        //
        //  Is Isosceles Trapezoid
        private Boolean _IsIsoscelesTrapezoid;
        //
        //  Is Parallelogram
        private Boolean _IsParallelogram;
        //
        //  Is Kite
        private Boolean _IsKite;
        //
        //  Is Rhombus
        private Boolean _IsRhombus;
        //
        //  Is Rectangle
        private Boolean _IsRectangle;
        //
        //  Is Square
        private Boolean _IsSquare;
        //
        //  Name
        private String _Name;
        //
        //  Description
        private String _Description;
        //
        //  Data
        //
        //  Points
        //
        //  Vertices
        private Point _Vertex1;
        private Point _Vertex2;
        private Point _Vertex3;
        private Point _Vertex4;
        //
        //  Midpoint
        private Point _MidPoint;
        //
        //  Segments
        private Segment _Segment1;
        private Segment _Segment2;
        private Segment _Segment3;
        private Segment _Segment4;
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
        //  QUADRILATERAL CONSTRUCTOR
        //
        //  ************************************************************
        public Quadrilateral()
        {
            //  Points
            this.MyPoints = new List<Point>();
            this.Vertices = new List<Point>();
            this.Vertex1 = new Point();
            this.Vertex2 = new Point();
            this.Vertex3 = new Point();
            this.Vertex4 = new Point();
            this._MidPoint = new Point();
            this.Vertices.Add(this.Vertex1);
            this.Vertices.Add(this.Vertex2);
            this.Vertices.Add(this.Vertex3);
            this.Vertices.Add(this.Vertex4);
            this.Vertices.Add(this._MidPoint);

            //  Segments
            this.MySegments = new List<Segment>();
            this.Segment1 = new Segment();
            this.Segment2 = new Segment();
            this.Segment3 = new Segment();
            this.Segment4 = new Segment();
            this.MySegments.Add(this.Segment1);
            this.MySegments.Add(this.Segment2);
            this.MySegments.Add(this.Segment3);
            this.MySegments.Add(this.Segment4);

            //  Assign Points to Segments
            //
            //  Segment 1
            this.Segment1.StartPoint = this.Vertex1;
            this.Segment1.EndPoint = this.Vertex2;
            //
            //  Segment 2
            this.Segment2.StartPoint = this.Vertex2;
            this.Segment2.EndPoint = this.Vertex3;
            //
            //  Segment 3
            this.Segment3.StartPoint = this.Vertex3;
            this.Segment3.EndPoint = this.Vertex4;
            //
            //  Segment 4
            this.Segment4.StartPoint = this.Vertex4;
            this.Segment4.EndPoint = this.Vertex1;
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //  
        //  Identification
        public String QuadrilateralID
        {
            set => _QuadrilateralID = value;
            get
            {
                return _QuadrilateralID;
            }
        }
        //
        //  Is Dart
        public Boolean IsDart
        {
            set => _IsDart = value;
            get
            {
                return _IsDart;
            }
        }
        //
        //  Is Trapezoid
        public Boolean IsTrapezoid
        {
            set => _IsTrapezoid = value;
            get
            {
                return _IsTrapezoid;
            }
        }
        //
        //  Is Isosceles  Trapezoid
        public Boolean IsIsoscelesTrapezoid
        {
            set => _IsIsoscelesTrapezoid = value;
            get
            {
                return _IsIsoscelesTrapezoid;
            }
        }
        //
        //  Is Parallelogram
        public Boolean IsParallelogram
        {
            set => _IsParallelogram = value;
            get
            {
                return _IsParallelogram;
            }
        }
        //
        //  Is Kite
        public Boolean IsKite
        {
            set => _IsKite = value;
            get
            {
                return _IsKite;
            }
        }
        //
        //  Is Rhombus
        public Boolean IsRhombus
        {
            set => _IsRhombus = value;
            get
            {
                return _IsRhombus;
            }
        }
        //
        //  Is Rectangle
        public Boolean IsRectangle
        {
            set => _IsRectangle = value;
            get
            {
                return _IsRectangle;
            }
        }
        //
        //  Is Square
        public Boolean IsSquare
        {
            set => _IsSquare = value;
            get
            {
                return _IsSquare;
            }
        }
        //
        //  Name
        public String Name
        {
            set => _Name = value;
            get
            {
                return _Name;
            }
        }
        //
        //  Description
        public String Description
        {
            set => _Description = value;
            get
            {
                return _Description;
            }
        }
        //
        //  Data
        //
        //  Points
        //
        //  Vertices
        //
        //  Vertex1
        public Point Vertex1
        {
            set => _Vertex1 = value;
            get
            {
                return _Vertex1;
            }
        }
        //
        //  Vertex2
        public Point Vertex2
        {
            set => _Vertex2 = value;
            get
            {
                return _Vertex2;
            }
        }
        //
        //  Vertex3
        public Point Vertex3
        {
            set => _Vertex3 = value;
            get
            {
                return _Vertex3;
            }
        }
        //
        //  Vertex4
        public Point Vertex4
        {
            set => _Vertex4 = value;
            get
            {
                return _Vertex4;
            }
        }
        //
        //  Segments
        //
        //  Segment1
        public Segment Segment1
        {
            set => _Segment1 = value;
            get
            {
                return _Segment1;
            }
        }
        //
        //  Segment2
        public Segment Segment2
        {
            set => _Segment2 = value;
            get
            {
                return _Segment2;
            }
        }
        //
        //  Segment3
        public Segment Segment3
        {
            set => _Segment3 = value;
            get
            {
                return _Segment3;
            }
        }
        //
        //  Segment4
        public Segment Segment4
        {
            set => _Segment4 = value;
            get
            {
                return _Segment4;
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
