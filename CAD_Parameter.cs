using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using Mathematics;
using Documents;

namespace CAD
{
    public class CAD_Parameter
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Name;
        private String _ID;
        private String _Description;
        //
        //  Data
        private ParameterType _MyParameterType;
        //
        //  Owned & Owning Objects
        //
        //  Dimensions
        private CAD_Dimension _CurrentDimension;
        private List<CAD_Dimension> _MyDimensions;
        //
        //  Parameter ID's for CAD Apps
        private String _SolidWorksParameterName;
        private String _Fusion360ParameterName;
        //
        //  Dependent Parameters
        private List<CAD_Parameter> _DependencyParameters;
        private List<CAD_Parameter> _DependentParameters;
        //
        //  Math Parameters
        private Parameter _CurrentMathParameter;
        private List<Parameter> _MyMathParameters;
        //
        //  Models
        private CAD_Model _CurrentModel;
        private List<CAD_Model> _MyModels;
        //
        //  Expression
        private Expression _MyExpression;
        //
        //  Design Table
        private DWM_Table _DesignTable;
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
        public enum ParameterType
        {
            Double = 0,
            Integer,
            String,
            Vector,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_PARAMETER CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_Parameter()
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
        //  ID
        public String PartNumber
        {
            set => _ID = value;
            get { return _ID; }
        }
        //
        //  Description
        public String Description
        {
            set => _Description = value;
            get { return _Description; }
        }
        //
        //  Data
        public ParameterType MyParameterType
        {
            set => _MyParameterType = value;
            get { return _MyParameterType; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Dimensions
        //
        //  Current Dimension
        public CAD_Dimension CurrentDimension
        {
            set => _CurrentDimension = value;
            get { return _CurrentDimension; }
        }
        //
        //  My Dimensions
        public List<CAD_Dimension> MyDimensions
        {
            set => _MyDimensions = value;
            get { return _MyDimensions; }
        }
        //
        //  Parameter ID's for CAD Apps
        //
        //  SolidWorks
        public String SolidWorksParameterName
        {
            set => _SolidWorksParameterName = value;
            get { return _SolidWorksParameterName; }
        }
        //
        //  Fusion360
        public String Fusion360ParameterName
        {
            set => _Fusion360ParameterName = value;
            get { return _Fusion360ParameterName; }
        }
        //
        //  Dependent Parameters
        public List<CAD_Parameter> DependencyParameters
        {
            set => _DependencyParameters = value;
            get { return _DependencyParameters; }
        }
        public List<CAD_Parameter> DependentParameters
        {
            set => _DependentParameters = value;
            get { return _DependentParameters; }
        }
        //
        //  Math Parameters
        public Parameter CurrentMathParameter
        {
            set => _CurrentMathParameter = value;
            get { return _CurrentMathParameter; }
        }
        public List<Parameter> MyMathParameters        
        {
            set => _MyMathParameters = value;
            get { return _MyMathParameters;  }
        }
        //
        //  Models
        //
        //  Current Model
        public CAD_Model CurrentModel

       {
            set => _CurrentModel = value;
            get { return _CurrentModel; }
        }
        //
        //  My Models
        public List<CAD_Model> MyModels
        {
            set => _MyModels = value;
            get { return _MyModels; }
        }
        //
        //  Expression
        public Expression MyExpression
        {
            set => _MyExpression = value;
            get { return _MyExpression; }
        }
        //
        //  Design Table
        public DWM_Table DesignTable
        {
            set => _DesignTable = value;
            get { return _DesignTable; }
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
