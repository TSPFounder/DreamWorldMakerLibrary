using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using SystemsEngineering;

namespace CAD
{
   public class CAD_Joint :CAD_Interface
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
        //  Joint Type
        private JointTypeEnum _JointType;
        // 
        //  CAD Model Type
        private CAD_ModelTypeEnum _ModelType;
        //
        //  Owned & Owning Objects
        //
        //  Included Components
        private List<CAD_Component> _IncludedComponents;
        //
        //  Locating Coordinate System
        private CoordinateSystem _MyCoordinateSystem;
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
        // 
        //  Joint Type
        public enum JointTypeEnum
        {
            Rigid = 0,
            Revolute,
            Slider,
            Cylindrical,
            PinSlot,
            Planar,
            InPlane,
            Ball,
            LeadScrew,
            Other
        }
        //
        //  Joint CAD Model Type
        public enum CAD_ModelTypeEnum
        {
            SolidWorks = 0,
            Fusion360,
            MechanicalDesktop,
            Simscape,
            STEP,
            STL,
            FBX
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_JOINT CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_Joint()
        {
            this.IncludedComponents = new List<CAD_Component>();
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
        //  Joint Type
        public JointTypeEnum JointType
        {
            set => _JointType = value;
            get
            {
                return _JointType;
            }
        }
        // 
        //  CAD Model Type
        public CAD_ModelTypeEnum ModelType
        {
            set => _ModelType = value;
            get
            {
                return _ModelType;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Included Component
        public List<CAD_Component> IncludedComponents
        {
            set => _IncludedComponents = value;
            get
            {
                return _IncludedComponents;
            }
        }
        //
        //  Locating Coordinate System
        public CoordinateSystem MyCoordinateSystem
        {
            set => _MyCoordinateSystem = value;
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


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
