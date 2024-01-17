using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using Documents;
using CAD;
using SystemsEngineering;

namespace Documents
{
    public class DWM_Image : AppFile
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
        private String _Path;
        private String _URL;
        //
        //  Data
        private Int16 _NumX_Values;
        private Int16 _NumY_Values;
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
        public enum FileType
            {
                PNG=0,
                JPG,
                ICO,
                Other
            }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  DWM_IMAGE CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public DWM_Image()
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
        //
        //  Path
        public String Path
        {
            set => _Path = value;
            get { return _Path; }
        }
        //
        // URL
        public String URL
        {
            set => _URL = value;
            get { return _URL; }
        }
        //
        //  Data
        //
        //  Number of X Values
        public Int16 NumX_Values
        {
            set => _NumX_Values = value;
            get { return _NumX_Values; }
        }
        //
        //  Number of Y Values
        public Int16 NumY_Values
        {
            set => _NumY_Values = value;
            get { return _NumY_Values; }
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
