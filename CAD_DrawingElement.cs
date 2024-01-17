using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;

namespace CAD
{
    public  class CAD_DrawingElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Name;
        //
        //  Data
        private DrawingElementType _MyType;
        //
        //  Owned & Owning Objects
        //
        //  Construction Geometry
        private CAD_ConstructionGeometery _CurrentConstructionGeometry;
        private List<CAD_ConstructionGeometery> _MyConstructionGeometry;
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
        public enum DrawingElementType
        {
            DrawingView=0,
            Dimension,
            Table,
            BoM,
             PMI,
             ConstructionGeometry,
             Note,
             Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        // CAD_DRAWINGELEMENT CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_DrawingElement()
        {

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
            get { return _Name; }
        }
        //
        //  Data
        public DrawingElementType MyType
        {
            set => _MyType = value;
            get { return _MyType; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Construction Geometry
        //
        //  Current Construction Geometry
        public CAD_ConstructionGeometery CurrentConstructionGeometry
        {
            set => _CurrentConstructionGeometry = value;
            get { return _CurrentConstructionGeometry; }
        }
        //
        public List<CAD_ConstructionGeometery> MyConstructionGeometry
        {
            set => _MyConstructionGeometry = value;
            get { return _MyConstructionGeometry; }
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
