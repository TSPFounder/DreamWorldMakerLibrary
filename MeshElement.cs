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
    public class MeshElement
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
        //
        //  Data
        private ElementTypeEnum _ElementType;
        private OrderEnum _Order;
        private Double _Volume;
        private Double _SurfaceArea;
        private Double _Area;
        private Double _PerimeterLength;
        //
        //  Owned & Owning Objects
        private Mesh _MyMesh;
        private List<Node> _MyNodes;
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
        public enum ElementTypeEnum
        {
            Triangle = 0,
            Quadralateral,
            Tetrahedron,
            Quadrahedron,
            Other
        }
        public enum OrderEnum
        {
            First = 0,
            Second,
            Third,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  MESHELEMENT CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public MeshElement()
        {
            this.MyNodes = new List<Node>();

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
        //  Data
        //
        //  Element Type
        public ElementTypeEnum ElementType
        {
            set => _ElementType = value;
            get
            {
                return _ElementType;
            }
        }
        //
        //  Order
        public OrderEnum Order
        {
            set => _Order = value;
            get
            {
                return _Order;
            }
        }
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
        //  My Mesh
        public Mesh MyMesh
        {
            set => _MyMesh = value;
            get
            {
                return _MyMesh;
            }
        }
        //
        //  My Nodes
        public List<Node> MyNodes
        {
            set => _MyNodes = value;
            get
            {
                return _MyNodes;
            }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region
        public void AssignNodes()
        {


        }
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
