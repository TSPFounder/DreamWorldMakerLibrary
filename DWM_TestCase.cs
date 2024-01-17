using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using Documents;
using MissionsNamespace;
using SystemsEngineering;

namespace Test
{
    public class DWM_TestCase : DWM_WorkItem
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _ADO_ID;
        //
        //  Data
        //
        //  Status
        private Status _MyStatus;
        //
        //  Owned & Owning Objects
        private DWM_TestStep _CurrentStep;
        private List<DWM_TestStep> _MySteps;
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
            Designed = 0,
            Ready,            
            Closed
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  DWM_TESTCASE CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public DWM_TestCase()
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
        //  ADO ID
        public String ADO_ID
        {
            set => _ADO_ID = value;
            get
            {
                return _ADO_ID;
            }
        }
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
        //  Owned & Owning Objects
        public DWM_TestStep CurrentStep
         {
            set => _CurrentStep = value;
            get
            {
                return _CurrentStep;
            }
         }
         public List<DWM_TestStep> MySteps
        {
            set => _MySteps = value;
            get
            {
                return _MySteps;
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
