using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using SystemsEngineering;
using Documents;

namespace CAD
{
    public class CAD_ModelConfiguration
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Name;
        private String _Revision;
        private String _Path;
        //
        //  Data

        //
        //  Owned & Owning Objects
        //
        //  My CAD Model
        private CAD_Model _MyModel;
        //
        //  Parameters
        private CAD_Parameter _CurrentParameter;
        private List<CAD_Parameter> _MyParameters;
        //
        //  Features
        private CAD_Feature _CurrentFeature;
        private List<CAD_Feature> _MyFeatures;
        //
        //  Design Tables
        private CAD_DesignTable _CurrentDesignTable;
        private List<CAD_DesignTable> _MyDesignTables;
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

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_MODELCONFIGURATION CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_ModelConfiguration()
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
        //  Revision
        public String Revision
        {
            set => _Revision = value;
            get { return _Revision; }
        }
        //
        //  Path
        public String Path
        {
            set => _Path = value;
            get { return _Path; }
        }
        //
        //  Owned & Owning Objects
        //
        //  My CAD Model
        public CAD_Model MyModel
        {
            set => _MyModel = value;
            get { return _MyModel; }
        }
        //
        //  Parameters
        public CAD_Parameter CurrentParameter
        {
            set => _CurrentParameter = value;
            get { return _CurrentParameter; }
        }
        public List<CAD_Parameter> MyParameters
        {
            set => _MyParameters = value;
            get { return _MyParameters; }
        }
        // CAD Features
        //
        //  Current Feature
        public CAD_Feature CurrentFeature
        {
            set => _CurrentFeature = value;
            get { return _CurrentFeature; }
        }
        //
        //  My Features
        public List<CAD_Feature> MyFeatures
        {
            set => _MyFeatures = value;
            get { return _MyFeatures; }
        }
        //
        //  Current Design Table
        public CAD_DesignTable CurrentDesignTable
        {
            set => _CurrentDesignTable = value;
            get
            {
                return _CurrentDesignTable;
            }
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
