using System;
using System.Collections.Generic;
using Mathematics;
using SystemsEngineering;

namespace CAD
{
    public class CAD_App : ApplicationClass
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //
        //  Identification
        private CAD_AppEnum _Name;
        private String _Version;
        //
        //  Sketches
        private CAD_Sketch _CurrentSketch;
        private List<CAD_Sketch> _MySketches;
        #endregion
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
        public enum CAD_AppEnum
        {
            Fusion360 = 0,
            SolidWorks,
            SolidEdge,
            Inventor,
            AutoCAD,
            MechanicalDesktop,
            Sketchup,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_APP CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_App()
        {

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        public CAD_AppEnum Name
        {
            set => _Name = value;
            get { return _Name; }
        }
        public String Version
        {
            set => _Version = value;
            get { return _Version; }
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
        //  My Sketches
        public List<CAD_Sketch> MySketches
        {
            set => _MySketches = value;
            get { return _MySketches; }
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        public CAD_Sketch createSketch(CAD_SketchPlane mySketchPlane)

        {
            this._CurrentSketch = new CAD_Sketch();
            return this._CurrentSketch;
        }


        //  *****************************************************************************************
    }
}
