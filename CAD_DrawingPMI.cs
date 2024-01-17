﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;

namespace CAD
{
    public class CAD_DrawingPMI : CAD_DrawingElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification

        //
        //  Data
        private Boolean _Is3D;
        private PMI_Type _MyPMI_Type;
        //
        //  Owned & Owning Objects

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
        public enum PMI_Type
        {
            GDT = 0,
            Welding,
            Hole,
            SurfaceFinish,
            Other
          }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_DRAWINGPMI CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_DrawingPMI()
        {
            this.MyType = DrawingElementType.PMI;
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
        //  Data
        //
        //  Is 3-D
        public Boolean Is3D
        {
            set => _Is3D = value;
            get { return _Is3D; }
        }
        //
        //  PMI Type
        public PMI_Type MyPMI_Type
        {
            set => _MyPMI_Type = value;
            get { return _MyPMI_Type; }
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
