using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using Documents;
using MissionsNamespace;

namespace CAD
{
    public class CAD_ChangeRequest :DWM_Document
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
        //
        //  Justification
        private String _Justification;
        //
        //  Impacts
        private String _ArchitectureImpact;
        private String _UserExperience;
        private String _TestImpact;
        private String _Requirements;
        private List<String> _Impacts;
        //
        //  Status
        private Status _MyStatus;
        //
        //  Owned & Owning Objects
        //
        //  Document
        private DWM_Document _MyDoc;
        //
        //  Requirements
        private SystemRequirement _CurrentAffectedRequirement;
        private List<SystemRequirement> _MyAffectedRequirements;
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
        //
        //  Status
        public enum Status
        {
            Proposed = 0,
            Active,
            Resolved,
            Closed
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_CHANGEREQUEST CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_ChangeRequest()
        {
            this.Impacts = new List<String>();
            this.MyFigures = new List<DWM_Figure>();

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
        //  Status
        public Status MyStatus
        {
            set => _MyStatus = value;
            get
            {
                return _MyStatus;
            }
        }
        //
        //  Justification
        public String Justification
        {
            set => _Justification = value;
            get { return _Justification; }
        }
        //
        //  Impacts
        //
        //  Impact on Architecture
        public String ArchitectureImpact
        {
            set => _ArchitectureImpact = value;
            get { return _ArchitectureImpact; }
        }
        //
        //  Impact on User Experience
        public String UserExperience
        {
            set => _UserExperience = value;
            get { return _UserExperience; }
        }
        //
        //  Impact on Testing
        public String TestImpact
        {
            set => _TestImpact = value;
            get { return _TestImpact; }
        }
        //
        //  Impact on Requirements
        public String Requirements
        {
            set => _Requirements = value;
            get { return _Requirements; }
        }
        //
        //  List of Impacts
        public List<String> Impacts
        {
            set => _Impacts = value;
            get { return _Impacts; }
        }
        //
        //  Owned & Owning Objects
        //
        //  My Document
        public DWM_Document MyDoc
        {
            set => _MyDoc = value;
            get { return _MyDoc; }
        }
        //
        //  Current Affected Requirement
        public SystemRequirement CurrentAffectedRequirement
        {
            set => _CurrentAffectedRequirement = value;
            get { return _CurrentAffectedRequirement; }
        }
        //
        //  My Affected Requirements
        public List<SystemRequirement> MyAffectedRequirements
        {
            set => _MyAffectedRequirements = value;
            get { return _MyAffectedRequirements; }
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
