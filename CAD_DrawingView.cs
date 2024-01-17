using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using Mathematics;

namespace CAD
{
    public class CAD_DrawingView :CAD_DrawingElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Title;
        private String _Description;
        private String _ID;
        //
        //  Data
        //
        //  Center Point
        private Point _CenterPoint;
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
        public enum ViewType
        {
            OrthoTop,
            OrthoFront,
            OrthoRightSide,
            OrthoBottom,
            OrthoBack,
            OrthoLeftSide,
            Isometric,
            CrossSection,
            Detail,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_DRAWINGVIEW CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_DrawingView()
        {
            this.MyType = DrawingElementType.DrawingView;
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
        //  Title
        public String Title
        {
            set => _Title = value;
            get { return _Title; }
        }
        //
        //  Description
        public String Description
        {
            set => _Description = value;
            get { return _Description; }
        }
        //
        //  ID
        public String ID
        {
            set => _ID = value;
            get { return _ID; }
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
