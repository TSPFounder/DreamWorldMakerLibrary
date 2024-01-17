using System;
using System.Collections.Generic;
using Mathematics;
using SystemsEngineering;

namespace CAD
{
    public class CAD_SketchPlane
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Owned & Owning Objects
        //
        //  My Model
        private CAD_Model _MyModel;
        //
        //  Sketches
        //
        //  Current Sketch
        private CAD_Sketch _CurrentSketch;
        //
        //  Sketches
        private List<CAD_Sketch> _Sketches;
        //
        //  Coordinate System
        private CoordinateSystem _MyCoordinateSystem;
        // 
        //  Vectors
        //
        //  Normal Vector
        private Vector _NormalVector;
        //
        //  
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
        //  CAD_SKETCH CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_SketchPlane()
        {
            this.Sketches = new List<CAD_Sketch>();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        // Owned & Owning Objects
        //
        // CAD Model
        public CAD_Model MyModel
        {
            set => _MyModel = value;
            get { return _MyModel; }
        }
        //
        //  Sketches
        //
        //  Current Sketch
        public CAD_Sketch CurrentSketch
        {
            set => _CurrentSketch = value;
            get { return _CurrentSketch; }
        }
        //
        //  Sketches
        public List<CAD_Sketch> Sketches
        {
            set => _Sketches = value;
            get { return _Sketches; }
        }
        //
        //  Coordinate System
        public CoordinateSystem MyCoordinateSystem
        {
            set => _MyCoordinateSystem = value;
            get { return _MyCoordinateSystem; }
        }
        // 
        //  Vectors
        //
        //  Normal Vector
        public Vector NormalVector
        {
            set => _NormalVector = value;
            get { return _NormalVector; }
        }
        //
        //  
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
