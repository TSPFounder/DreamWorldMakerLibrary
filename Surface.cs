using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;

namespace Mathematics
{
    public class Surface
    {
        //
        //  Identification
        private String _Name;
        private String _ID;
        private String _Version;
        //
        //  Data
        private Double _Area;
        private Double _PerimeterLength;
        //
        //  Enumerations
        //
        //  Surface Primitives
        private SurfacePrimitive _MyPrimitive;
        //
        //  Surface Properties
        private Boolean _Is2D;
        //
        //  Owned & Owning Objects
        private List<Point> _MyPoints;
        private List<Segment> _MySegments;
        private List<Segment> _Perimeter;
        private List<Mesh> _MyMeshes;
        
        //  ****************************************************************************************
        //  INITIALIZATIONS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ENUMERATIONS
        //
        //  ************************************************************
        public enum SurfacePrimitive
        {
            Circle=0,
            Square,
            Rectangle,
            Triangle,
            Parallelogram,
            Rhombus,
            CylinderWall,
            Sphere,
            PartialSphere,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SURFACE CONSTRUCTOR
        //
        //  ************************************************************
        public Surface()
        {
            this.MyPoints = new List<Point>();
            this.MySegments = new List<Segment>();
            this.Perimeter = new List<Segment>();
            this.MyMeshes = new List<Mesh>();
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
            get
            {
                return _Name;
            }
        }
        //
        //  ID
        public String ID
        {
            set => _ID = value;
            get
            {
                return _ID;
            }
        }
        //
        //  Version
        public String Version
        {
            set => _Version = value;
            get
            {
                return _Version;
            }
        }
        //
        //  Data
        //  
        //  Area
        public Double Area
        {
            set => _Area = value;
            get
            {
                return _Area;
            }
        }
        //
        //  Perimeter Length
        public Double PerimeterLength
        {
            set => _PerimeterLength = value;
            get
            {
                return _PerimeterLength;
            }
        }
        //
        //  Surface Properties
        public Boolean Is2D
        {
            set => _Is2D = value;
            get
            {
                return _Is2D;
            }
        }
        //
        //  Enumerations
        //
        //  Surface Primitives
        public SurfacePrimitive MyPrimitive
        {
            set => _MyPrimitive = value;
            get
            {
                return _MyPrimitive;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Points
        public List<Point> MyPoints
        {
            set => _MyPoints = value;
            get
            {
                return _MyPoints;
            }
        }
        //
        //  Segments
        public List<Segment> MySegments
        {
            set => _MySegments = value;
            get
            {
                return _MySegments;
            }
        }
        //
        //  Perimeter
        public List<Segment> Perimeter
        {
            set => _Perimeter = value;
            get
            {
                return _Perimeter;
            }
        }
        //
        //  Meshes
        public List<Mesh> MyMeshes
        {
            set => _MyMeshes = value;
            get
            {
                return _MyMeshes;
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
