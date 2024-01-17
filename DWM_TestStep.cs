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
    public class DWM_TestStep
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        //
        //  Step Number
        private Int16 _StepNumber;

        //
        //  Data
        private String _Action;
        private String _ExpectedResult;
        private _PassFail _MyPassFail;
        private Boolean _IsShared;
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
        public enum _PassFail
        {
            Pass=0,
            Fail,
            NoTest,
            NotTested
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  DWM_TESTSTEP CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public DWM_TestStep()
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
        //  Step Number
        public Int16 StepNumber
        {
            set => _StepNumber = value;
            get { return _StepNumber; }
        }
        //
        //  Data
        public String Action
        {
            set => _Action = value;
            get { return _Action; }
        }
        public String ExpectedResult
        {
            set => _ExpectedResult = value;
            get { return _ExpectedResult; }
        }
        public _PassFail MyPassFail
        {
            set => _MyPassFail = value;
            get { return _MyPassFail; }
        }
        public Boolean IsShared
        {
            set => _IsShared = value;
            get { return _IsShared; }
        }
        //
        //  Owned & Owning Objects

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
