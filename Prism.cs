using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;

namespace Mathematics
{
    public class Prism : Primitive
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //  
        //  Identification
        private String _PrismID;
        //
        //  Data
        //
        //  Dimensions
        private Segment _LengthSegment;
        private Segment _WidthSegment;
        private Segment _HeightSegment;
        //
        //  Surfaces
        private Triangle _Triangle1;
        private Triangle _Triangle2;
        private Quadrilateral _Quadrilateral1;
        private Quadrilateral _Quadrilateral2;
        private Quadrilateral _Quadrilateral3;
        //
        //  Location
        private Point _CenterPoint;

        
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
        //  PRISM CONSTRUCTOR
        //
        //  ************************************************************
        public Prism()
        {
            this.Is2D = false;
            this.ThreeDType = ThreeDPrimitiveTypeEnum.Prism;

            //  Segments
            this.LengthSegment = new Segment();
            this.WidthSegment = new Segment();
            this.HeightSegment = new Segment();
            
            //
            //  Faces
            this.Triangle1 = new Triangle();
            this.Triangle2 = new Triangle();
            this._Quadrilateral1 = new Quadrilateral();
            this._Quadrilateral2 = new Quadrilateral();
            this._Quadrilateral3 = new Quadrilateral();
            //
            //  Location
            this.CenterPoint = new Point();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //  
        //  Identification
        public String PrismID
        {
            set => _PrismID = value;
            get
            {
                return _PrismID;
            }
        }
        //
        //  Data
        //
        //  Dimensions
        public Segment LengthSegment
        {
            set => _LengthSegment = value;
            get
            {
                return _LengthSegment;
            }
        }
        public Segment WidthSegment
        {
            set => _WidthSegment = value;
            get
            {
                return _WidthSegment;
            }
        }
        public Segment HeightSegment
        {
            set => _HeightSegment = value;
            get
            {
                return _HeightSegment;
            }
        }
        //
        //  Surfaces
        public Triangle Triangle1
        {
            set => _Triangle1 = value;
            get
            {
                return _Triangle1;
            }
        }
        public Triangle Triangle2
        {
            set => _Triangle2 = value;
            get
            {
                return _Triangle2;
            }
        }
        public Quadrilateral Quadrilateral1
        {
            set => _Quadrilateral1 = value;
            get
            {
                return _Quadrilateral1;
            }
        }
        public Quadrilateral Quadrilateral2
        {
            set => _Quadrilateral2 = value;
            get
            {
                return _Quadrilateral2;
            }
        }
        public Quadrilateral Quadrilateral3
        {
            set => _Quadrilateral3 = value;
            get
            {
                return _Quadrilateral3;
            }
        }
        //
        //  Location
        public Point CenterPoint
        {
            set => _CenterPoint = value;
            get
            {
                return _CenterPoint;
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
