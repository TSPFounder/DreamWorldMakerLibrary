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
    public class DWM_Verification : DWM_Document
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _VerificationTitle;
        private String _VerificationID;
        private String _Description;
        //
        //  Data
        private VerificationType _MyVerificationType;
        //
        //  Owned & Owning Objects
        //
        //  Requirements
        //
        //  Mission Requirements
        private MissionRequirement _CurrentMissionRequirement;
        private List<MissionRequirement> _MyMissionRequirements;
        //
        //  System Requirements
        private SystemRequirement _CurrentSystemRequirement;
        private List<SystemRequirement> _MySystemRequirements;

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
        public enum VerificationType
        {
            Analysis=0,
            Test,
            Inspection,
            Demo
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        // DWM_VERIFICATION CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public DWM_Verification()
        {
            this.MyMissionRequirements = new List<MissionRequirement>();
            this.MySystemRequirements = new List<SystemRequirement>();            
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
        //  Title
        public String VerificationTitle
        {
            set => _VerificationTitle = value;
            get { return _VerificationTitle; }
        }
        //
        //  Verification ID
        public String VerificationID        
        {
            set => _VerificationID = value;
            get { return _VerificationID; }
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
        //  Verification Type
        public VerificationType MyVerificationType
        {
            set => _MyVerificationType = value;
            get { return _MyVerificationType; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Requirements
        //
        //  Mission Requirements
        public MissionRequirement CurrentMissionRequirement
         {
            set => _CurrentMissionRequirement = value;
            get { return _CurrentMissionRequirement; }
        }
        public List<MissionRequirement> MyMissionRequirements
        {
            set => _MyMissionRequirements = value;
            get { return _MyMissionRequirements; }
        }
        //
        //  System Requirements
        public SystemRequirement CurrentSystemRequirement
        {
            set => _CurrentSystemRequirement = value;
            get { return _CurrentSystemRequirement; }
        }
        public List<SystemRequirement> MySystemRequirements
        {
            set => _MySystemRequirements = value;
            get { return _MySystemRequirements; }
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
