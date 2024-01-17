using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using Documents;
using MissionsNamespace;

namespace SystemsEngineering
{
    public class DWM_Risk : DWM_WorkItem
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
        //  Severity
        private int _Severity;
        //
        // Probability
        private int _Probability;
        //
        //  Status
        private Status _MyStatus;
        //
        //  Owned & Owning Objects
        private DWM_Document _MyPlan;
        private DWM_Document _MyContingencyPlan;
        
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
        //  DWM_RISK CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public DWM_Risk()
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
        //  Data
        //
        //  Severity
        public int Severity
        {
            set => _Severity = value;
            get
            {
                return _Severity;
            }
        }
        //
        // Probability
        private int Probability
        {
            set => _Probability = value;
            get
            {
                return _Probability;
            }
        }
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
        //  Owned & Owning Objects
        //
        //  My Plan
        public DWM_Document MyPlan
        {
            set => _MyPlan = value;
            get
            {
                return _MyPlan;
            }
        }
        //
        //  My Contingency Plan
        public DWM_Document MyContingencyPlan
        {
            set => _MyContingencyPlan = value;
            get
            {
                return _MyContingencyPlan;
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
