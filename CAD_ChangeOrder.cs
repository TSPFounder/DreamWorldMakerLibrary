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
    public class CAD_ChangeOrder : DWM_WorkItem
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
        private String _ADO_ID;
        //
        //  Data

        //
        //  Owned & Owning Objects
        //
        //  Change Request
        private CAD_ChangeRequest _MyChangeRequest;
        //
        // Design
        private DWM_Design _MyDesign;
        //
        //  Changed Parts
        private CAD_Part _CurrentChangedPart;
        private List<CAD_Part> _MyChangedParts;
        //
        //  Approvers
        private DWM_Stakeholder _CurrentApprover;
        private List<DWM_Stakeholder> _MyApprovers;
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
        public enum Status
        {
            UnderReview=0,
            Approved,
            Rejected,
            Implemented,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_CHANGEORDER CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_ChangeOrder()
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
        public String ID
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
        //  Azure Devops ID
        public String ADO_ID
        {
            set => _ADO_ID = value;
            get { return _ADO_ID; }
        }
        //
        //  Data

        //
        //  Owned & Owning Objects
        //
        //  Change Request
        public CAD_ChangeRequest MyChangeRequest
        {
            set => _MyChangeRequest = value;
            get { return _MyChangeRequest; }
        }
        //
        //  My Design
        public DWM_Design MyDesign
        {
            set => _MyDesign = value;
            get { return _MyDesign; }
        }
        //
        //  Changed Parts
        public CAD_Part CurrentChangedPart
        {
            set => _CurrentChangedPart = value;
            get { return _CurrentChangedPart; }
        }
        public List<CAD_Part> MyChangedParts
        {
            set => _MyChangedParts = value;
            get { return _MyChangedParts; }
        }
        //
        //  Approvers
        public DWM_Stakeholder CurrentApprover
        {
            set => _CurrentApprover = value;
            get { return _CurrentApprover; }
        }
        public List<DWM_Stakeholder> MyApprovers
        {
            set => _MyApprovers = value;
            get { return _MyApprovers; }
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
