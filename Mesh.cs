using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD;
using SystemsEngineering;
using CAD;

namespace Mathematics
{
    public class Mesh
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //
        //  Identification
        private String _Name;
        private String _ID;
        private String _Version;
        //
        //  Data
        private Double _Volume;
        private Double _SurfaceArea;
        private Double _Area;
        private Double _PerimeterLength;
        //
        //  Owned & Owning Objects
        // 
        //  Geometry
        private List<Triangle> _MyTriangles;
        private List<Quadrilateral> _MyQuadrilaterals;
        //
        // Nodes & Elements
        private List<Node> _MyNodes;
        private List<MeshElement> _MyElements;
        //
        //  My Surface
        private Surface _MySurface;
        #endregion
        //  *****************************************************************************************


        //  ****************************************************************************************
        //  INITIALIZATIONS
        //
        //  ************************************************************
        #region

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ENUMERATIONS
        //
        //  ************************************************************
        #region

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  MESH CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Mesh()
        {
            //  Create lists
            this._MyTriangles = new List<Triangle>();
            this._MyQuadrilaterals = new List<Quadrilateral>();
            this.MyNodes = new List<Node>();
            this.MyElements = new List<MeshElement>();
        }
        #endregion
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
        //  Volume
        public Double Volume
        {
            set => _Volume = value;
            get
            {
                return _Volume;
            }
        }
        //  
        //  Surface Area
        public Double SurfaceArea
        {
            set => _SurfaceArea = value;
            get
            {
                return _SurfaceArea;
            }
        }
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
        //  Owned & Owning Objects
        // 
        //  Geometry
        //
        //  Triangles
        public List<Triangle> MyTriangles
        {
            set => _MyTriangles = value;
            get
            {
                return _MyTriangles;
            }
        }
        //
        //  Quadrilaterals
        public List<Quadrilateral> MyQuadrilaterals
        {
            set => _MyQuadrilaterals = value;
            get
            {
                return _MyQuadrilaterals;
            }
        }
        //
        //  Nodes & Elements
        //
        // Nodes
        public List<Node> MyNodes
        {
            set => _MyNodes = value;
            get
            {
                return _MyNodes;
            }
        }
        //  
        // Elements
        public List<MeshElement> MyElements
        {
            set => _MyElements = value;
            get
            {
                return _MyElements;
            }
        }
        //
        //  My Surface
        public Surface MySurface
        {
            set => _MySurface = value;
            get
            {
                return _MySurface;
            }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************
        #region

        #endregion
        //  *****************************************************************************************
    }
}
