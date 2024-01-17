using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using SystemsEngineering;

namespace CAD
{
    public class CAD_Surface : Surface
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _ID;
        private String _Version;
        //
        //  Data
        //
        //  Dimensions
        private Double _Length;
        private Double _Area;
        private Double _Perimeter;
        //
        //  Owned & Owning Objects
        //
        //  Surfaces
        private Surface _MySurface;
        // 
        //  Meshes
        private Mesh _CurrentMesh;
        private List<Mesh> _MyMeshes;
        // 
        //  CAD Body
        private CAD_Body _MyBody;
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
        //  CAD_SURFACE CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_Surface()
        {
            
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        public String Name
        {
            set => _Name = value;
            get
            {
                return _Name;
            }
        }
        public String ID
        {
            set => _ID = value;
            get
            {
                return _ID;
            }
        }
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
        //  Dimensions
        public Double Length
        {
            set => _Length = value;
            get
            {
                return _Length;
            }
        }
        public Double Area
        {
            set => _Area = value;
            get
            {
                return _Area;
            }
        }
        public Double Perimeter
        {
            set => _Perimeter = value;
            get
            {
                return _Perimeter;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Surfaces
        public Surface MySurface
        {
            set => _MySurface = value;
            get
            {
                return _MySurface;
            }
        }
        // 
        //  Meshes
        public Mesh CurrentMesh
        {
            set => _CurrentMesh = value;
            get
            {
                return _CurrentMesh;
            }
        }
        public List<Mesh> MyMeshes
        {
            set => _MyMeshes = value;
            get
            {
                return _MyMeshes;
            }
        }
        // 
        //  CAD Body
        public CAD_Body MyBody
        {
            set => _MyBody = value;
            get
            {
                return _MyBody;
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
