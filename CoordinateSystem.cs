using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;

namespace Mathematics
{
    public class CoordinateSystem
    {
        //  *****************************************************************************************
        // DECLARATIONS
        //
        //  ************************************************************
        //  
        //  Identification
        //
        //  ID
        private String _CoordinateSystemID;
        //
        //  Name
        private String _Name;
        //
        //  Definitions
        private CoordinateSystemTypeEnum _MyType;
        //
        //  Owned & Owning Objects
        //
        //  Vectors
        private Vector _BaseVector;
        private List<Vector> _Vectors;
        //  
        //  Cad Sketches
        private List<CAD_Sketch> _MyCAD_Sketches;
        //
        //  Two Dimensional Geometry
        //
        //  Is Two Dimensional
        private Boolean _Is2D;
        private List<TwoDGeometry> _My2DGeometry;
        //
        //  Three Dimensional Geometry
        private List<ThreeDGeometry> _My3DGeometry;
        //
        //  Data
        //
        //  Is World Coordinate System
        private Boolean _IsWCS;
        //
        //  Origin Location
        private Point _OriginLocation;

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
        public enum CoordinateSystemTypeEnum
        {
            Cartesian = 0,
            Cylindrical,
            Spherical,
            Polar
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  COORDINATESYSTEM CONSTRUCTOR
        //
        //  ************************************************************
        public CoordinateSystem()
        {
        #region
            this.MyCAD_Sketches = new List<CAD_Sketch>();
            this.Vectors = new List<Vector>();
            this.My2DGeometry = new List<TwoDGeometry>();
            this.My3DGeometry = new List<ThreeDGeometry>();
        #endregion
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        public String CoordinateSystemID
        {
            set => _CoordinateSystemID = value;
            get { return _CoordinateSystemID; }
        }
        //
        //  Name
        public String Name
        {
            set => _Name = value;
            get { return _Name; }
        }
        //
        //  Definitions
        public CoordinateSystemTypeEnum MyType
        {
            set => _MyType = value;
            get { return _MyType; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Vectors
        //
        //  Base Vector
        public Vector BaseVector
        {
            set => _BaseVector = value;
            get { return _BaseVector; }
        }
        //
        //  My Vectors
        public List<Vector> Vectors
        {
            set => _Vectors = value;
            get { return _Vectors; }
        }
        //  
        //  Cad Sketches
        public List<CAD_Sketch> MyCAD_Sketches
        {
            set => _MyCAD_Sketches = value;
            get { return _MyCAD_Sketches; }
        }
        //
        //  Two Dimensional Geometry
        //
        //  Is Two Dimensional
        public Boolean Is2D
        {
            set => _Is2D = value;
            get { return _Is2D; }
        }
        public List<TwoDGeometry> My2DGeometry
        {
            set => _My2DGeometry = value;
            get { return _My2DGeometry; }
        }
        //
        //  Three Dimensional Geometry
        public List<ThreeDGeometry> My3DGeometry
        {
            set => _My3DGeometry = value;
            get { return _My3DGeometry; }
        }
        //
        //  Data
        //
        //  Is World Coordinate System
        public Boolean IsWCS
        {
            set => _IsWCS = value;
            get { return _IsWCS; }
        }
        //
        //  Origin Location
        public Point OriginLocation
        {
            set => _OriginLocation = value;
            get { return _OriginLocation; }
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
