using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;
using Structure;
using MissionsNamespace;
using PowerTransmission;

namespace Structure
{
    public class Bearing : DWM_System
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
        //  Data
        //
        //  Type
        private List<BearingTypeEnum> _BearingTypes;
        //
        //  Dimensions
        private Double _Width;
        private Double _ShaftDiameter;
        private Double _HousingDiameter;
        //
        //  Physical Properties
        private Double _Weight;
        private Boolean _PermanentlyLubricated;
        private Boolean _ElectricallyInsulated;
        private Boolean _OneWay;
        private Boolean _ThrustBearing;
        private Boolean _MultipleBearingTypes;
        //
        //  Geometric Properties
        private Boolean _Tapered;
        private Boolean _HexBored;
        private Boolean _SelfAligning;
        //
        //  Performance
        private BearingLoadTypeEnum _LoadType;
        private Double _MaxSpeed;  //  RPM
        private Double _MaxLoad;  //  lbf
        //
        //  Owned & Owning Objects
        //
        //  Material
        private Material _MyMaterial;
        //
        //  CAD Objects
        private CAD_Model _MyCAD_Model;
        private CAD_Assembly _MyAssembly;
        private List<CAD_Component> _MyComponents;
        private List<CAD_Sketch> _MyCrossSections;
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
        public enum BearingTypeEnum
        {
            Plain = 0,
            Ball,
            Roller,
            Needle,
            Mounted
        }
        public enum BearingLoadTypeEnum
        {
            Standard = 0,
            High,
            LightDuty,
            Needle,
            Mounted
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  BEARING CONSTRUCTOR
        //
        //  ************************************************************
        public Bearing()
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
        //  Type
        public List<BearingTypeEnum> BearingTypes
        {
            set => _BearingTypes = value;
            get
            {
                return _BearingTypes;
            }
        }
        //
        //  Dimensions
        //
        //
        public Double Width
        {
            set => _Width = value;
            get
            {
                return _Width;
            }
        }
        public Double ShaftDiameter
        {
            set => _ShaftDiameter = value;
            get
            {
                return _ShaftDiameter;
            }
        }
        public Double HousingDiameter
        {
            set => _HousingDiameter = value;
            get
            {
                return _HousingDiameter;
            }
        }


        //
        //  Physical Properties
        public Double Weight
        {
            set => _Weight = value;
            get
            {
                return _Weight;
            }
        }
        public Boolean PermanentlyLubricated
        {
            set => _PermanentlyLubricated = value;
            get
            {
                return _PermanentlyLubricated;
            }
        }
        public Boolean ElectricallyInsulated
        {
            set => _ElectricallyInsulated = value;
            get
            {
                return _ElectricallyInsulated;
            }
        }
        public Boolean OneWay
        {
            set => _OneWay = value;
            get
            {
                return _OneWay;
            }
        }
        public Boolean ThrustBearing
        {
            set => _ThrustBearing = value;
            get
            {
                return _ThrustBearing;
            }
        }
        public Boolean MultipleBearingTypes
        {
            set => _MultipleBearingTypes = value;
            get
            {
                return _MultipleBearingTypes;
            }
        }
        //
        //  Geometric Properties
        public Boolean Tapered
        {
            set => _Tapered = value;
            get
            {
                return _Tapered;
            }
        }
        public Boolean HexBored
        {
            set => _HexBored = value;
            get
            {
                return _HexBored;
            }
        }
        public Boolean SelfAligning
        {
            set => _SelfAligning = value;
            get
            {
                return _SelfAligning;
            }
        }
        //
        //  Performance
        public BearingLoadTypeEnum LoadType
        {
            set => _LoadType = value;
            get
            {
                return _LoadType;
            }
        }
        public Double MaxSpeed
        {
            set => _MaxSpeed = value;
            get
            {
                return _MaxSpeed;
            }
        }
        public Double MaxLoad
        {
            set => _MaxLoad = value;
            get
            {
                return _MaxLoad;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Material
        public Material MyMaterial
        {
            set => _MyMaterial = value;
            get
            {
                return _MyMaterial;
            }
        }
        //
        //  CAD Objects
        //
        //  CAD Model
        public CAD_Model MyCAD_Model
        {
            set => _MyCAD_Model = value;
            get
            {
                return _MyCAD_Model;
            }
        }
        //
        //  My CAD Assembly
        public CAD_Assembly MyAssembly
        {
            set => _MyAssembly = value;
            get
            {
                return _MyAssembly;
            }
        }
        //
        //  My CAD Assemblies
        public List<CAD_Component> MyComponents
        {
            set => _MyComponents = value;
            get
            {
                return _MyComponents;
            }
        }
        //
        //  My CAD Cross Sections
        public List<CAD_Sketch> MyCrossSections
        {
            set => _MyCrossSections = value;
            get
            {
                return _MyCrossSections;
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
