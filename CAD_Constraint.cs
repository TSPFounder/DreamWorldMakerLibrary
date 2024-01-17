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
    public class CAD_Constraint
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        //  
        //  Identification
        private String _Name;
        private String _ID;
        private String _Description;
        //
        //  Enums
        private ConstraintType _MyConstraintType;
        //
        //  Data

        //
        //  Owned & Owning Objects
        //
        //  Features
        private CAD_Feature _CurrentFeature;
        private CAD_Feature _PreviousFeature;
        private List<CAD_Feature> _MyFeatures;
        //
        //  Models
        private CAD_Model _CurrentModel;
        private List<CAD_Model> _MyModels;
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
        public enum ConstraintType
        {
            Horizontal=0,
            Vertical,
            Distance,
            Coincident,
            Tangent,
            Angle,
            Equal,
            Parallel,
            Perpendicular,
            Fixed,
            Midpoint,
            Midplane,
            Concentric,
            Collinear,
            Symmetry,
            Curvature
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_CONSTRAINT CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_Constraint()
        {
            this.MyFeatures = new List<CAD_Feature>();
            this.MyModels = new List<CAD_Model>();
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
        //
        //  My Type
        public ConstraintType MyConstraintType
        {
            set => _MyConstraintType = value;
            get { return _MyConstraintType; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Features
        public CAD_Feature CurrentFeature
        {
            set => _CurrentFeature = value;
            get { return _CurrentFeature; }
        }
        public CAD_Feature PreviousFeature
        {
            set => _PreviousFeature = value;
            get { return _PreviousFeature; }
        }
        public List<CAD_Feature> MyFeatures
        {
            set => _MyFeatures = value;
            get { return _MyFeatures; }
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
