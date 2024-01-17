using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using SystemsEngineering;

namespace CAD
{
    public class CAD_Body
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Version;
        private String _PartNumber;
        //
        //  Data

        //  Owned & Owning Objects
        // 
        //  Sketches
        private CAD_Sketch _CurrentSketch;
        private List<CAD_Sketch> _MySketches;
        //
        //  3-D Operations
        private List<Feature3DOperationEnum> _ThreeDimOperations;
        //
        //  Features
        private CAD_Feature _CurrentFeature;
        private List<CAD_Feature> _MyFeatures;
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
        public enum Feature3DOperationEnum
        {
            Extrude = 0,
            Revolve,
            Sweep,
            Loft
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_BODY CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_Body()
        {
            this.MySketches = new List<CAD_Sketch>();
            this.ThreeDimOperations = new List<Feature3DOperationEnum>();
            this.MyFeatures = new List<CAD_Feature>();
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
            get { return _Name; }
        }
        //
        //  Version
        public String Version
        {
            set => _Version = value;
            get { return _Version; }
        }
        //
        //  Part Number
        public String PartNumber
        {
            set => _PartNumber = value;
            get { return _PartNumber; }
        }
        //
        // Owned & Owning Objects
        //
        // CAD Sketch
        public CAD_Sketch CurrentSketch
        {
            set => _CurrentSketch = value;
            get { return CurrentSketch; }
        }
        //
        // My Sketches
        public List<CAD_Sketch> MySketches
        {
            set => _MySketches = value;
            get { return MySketches; }
        }
        //
        //  3-D Operations
        public List<Feature3DOperationEnum> ThreeDimOperations
        {
            set => _ThreeDimOperations = value;
            get { return _ThreeDimOperations; }
        }
        //
        // CAD Feature
        public CAD_Feature CurrentFeature
        {
            set => _CurrentFeature = value;
            get { return CurrentFeature; }
        }
        //
        // My Features
        public List<CAD_Feature> MyFeatures
        {
            set => _MyFeatures = value;
            get { return MyFeatures; }
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
