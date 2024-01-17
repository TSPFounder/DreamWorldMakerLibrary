using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;

namespace Mathematics
{
    public class Cone : Primitive
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //  
        //  Identification
        private String _ConeID;
        //
        //  Data
        //
        //  Dimensions
        private Double _Height;
        //
        //  Truncation
        private Boolean _IsTruncated;
        //
        //  Owned & Owning Objects
        //
        //  Base Circle
        private Circle _BaseCircle;
        //
        //  Truncation Circle
        private Circle _TruncationCircle;
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
        //  CONE CONSTRUCTOR
        //
        //  ************************************************************
        public Cone()
        {
            this.Is2D = false;
            this.ThreeDType = ThreeDPrimitiveTypeEnum.Cone;

            //
            //  Location
            this.CenterPoint = new Point();
            this.BaseCircle = new Circle();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //  
        //  Identification
        public String ConeID
        {
            set { }
            get
            {
                return _ConeID;
            }
        }
        
        ///
        //  Data
        //
        //  Dimensions
        public Double Height
        {
            set { }
            get
            {
                return _Height;
            }
        }
        //
        //  Truncation
        public Boolean IsTruncated
        {
            set { }
            get
            {
                return _IsTruncated;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Base Circle
        public Circle BaseCircle
        {
            set { }
            get
            {
                return _BaseCircle;
            }
        }
        //
        //  Truncation Circle
        public Circle TruncationCircle
        {
            set { }
            get
            {
                return _TruncationCircle;
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
