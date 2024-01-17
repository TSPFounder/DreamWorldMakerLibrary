using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using Documents;
using CAD;

namespace MissionsNamespace
{
    public class MissionScene :MissionElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Name;
        private String _Version;
        private String _Description;
        private String _ID;
        //
        //  Data

        //
        //  Owned & Owning Objects
        //
        //  People
        private List<DWM_Stakeholder> _Stakeholders;
        private List<Person> _Adversaries;
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
        //  MISSIONSCENE CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public MissionScene()
        {
            
            //
            //  Mission Element Type
            this.MyType = ElementTypeEnum.MissionScene;
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
        //  Version
        public String Version
        {
            set => _Version = value;
            get { return _Version; }
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
        //  Owned & Owning Objects
        //
        //  People
        //
        //  Stakeholders
        public List<DWM_Stakeholder> Stakeholders
        {
            set => _Stakeholders = value;
            get { return _Stakeholders; }
        }
        //
        //  Adversaries
        public List<Person> Adversaries
        {
            set => _Adversaries = value;
            get { return _Adversaries; }
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
