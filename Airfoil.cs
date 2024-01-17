using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD;
using SystemsEngineering;

namespace AircraftObjects
{
    public class Airfoil : CAD_Feature
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //
        //  Identification
        private String _Name;
        private String _Description;
        private String _ID;
        private AirfoilTypeEnum _AirfoilType;
        private NACA_SeriesEnum _NACA_Series;

        //  Airfoil Data
        //
        //
        // Dimensions
        private CAD_Dimension _ChordLength;
        private CAD_Dimension _Thickness;
        //
        //  Area
        private CAD_Parameter _Area;
        //
        //  Owned & Owning Objects
        private CAD_SketchPlane _SketchPlane;
        private CAD_Model _MyCAD_Model;
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
        #region
        //
        //  Airfoil Type
        public enum AirfoilTypeEnum
        {
            Hex = 0,
            NACA,
            Arc,
            UserDefined
        }
        //
        //  NACA Series
        public enum NACA_SeriesEnum
        {
            FourDigit = 0,
            ModifiedFourDigit,
            FiveDigit,
            ModifiedFiveDigit,
            One,
            Six,
            Seven,
            Eight
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  AIRFOIL CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Airfoil()
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
            get
            {
                return _Name;
            }
        }
        //       
        //  Description
        public String Description
        {
            set => _Description = value;
            get
            {
                return _Description;
            }
        }
        //       
        //  ID
        public String ID
        {
            set => _ID = value;
            get
            {
                return _ID;
            }
        }
        //       
        // Airfoil Type
        public AirfoilTypeEnum AirfoilType
        {
            set => _AirfoilType = value;
            get
            {
                return _AirfoilType;
            }
        }
        //
        //  NACA Series
        public NACA_SeriesEnum NACA_Series
        {
            set => _NACA_Series = value;
            get
            {
                return _NACA_Series;
            }
        }
        //
        //  Airfoil Data
        //
        //  Data
        //
        //  Dimensions
        //
        // 
        //  Chord Length
        public CAD_Dimension ChordLength
        {
            set => _ChordLength = value;
            get
            {
                return _ChordLength;
            }
        }
        //
        //  Thickness
        public CAD_Dimension Thickness
        {
            set => _Thickness = value;
            get
            {
                return _Thickness;
            }
        }
        //
        //  Area
        public CAD_Parameter Area
        {
            set => _Area = value;
            get
            {
                return _Area;
            }
        }
        //
        // Owned & Owning Objects
        //
        //  Sketch Plane
        public CAD_SketchPlane SketchPlane
        {
            set => _SketchPlane = value;
            get
            {
                return _SketchPlane;
            }
        }
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
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region
        //
        //  Draw the Airfoil Sketch
        #endregion
        //  *****************************************************************************************
    }
}
