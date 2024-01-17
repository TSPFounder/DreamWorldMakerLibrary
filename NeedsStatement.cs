using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;


namespace MissionsNamespace
{
    public class NeedsStatement
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
        private List<String> _As_A_Statements;
        private List<String> _I_Need_Statements;
        private List<String> _So_That_Statements;
        //
        //  Has Been Satisfied
        private Boolean _IsSatisfied;
        //
        //  Owned & Owning Objects
        //
        //  My Roles
        private List<Role> _MyRoles;
        //  
        //  Me
        private DWM_Stakeholder _Me;
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
        //  NEEDSSTATEMENT CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public NeedsStatement()
        {
            //  Statements
            this.As_A_Statements = new List<String>();
            this.I_Need_Statements = new List<String>();
            this.So_That_Statements = new List<String>();
            //  Roles
            this.MyRoles = Me.Roles;
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
        //  Data
        public List<String> As_A_Statements        
        {
            set => _As_A_Statements = value;
            get { return _As_A_Statements; }
        }
        public List<String> I_Need_Statements        
        {
            set => _I_Need_Statements  = value;
            get { return _I_Need_Statements; }
        }
        public List<String> So_That_Statements        
        {
            set => _So_That_Statements = value;
            get { return _So_That_Statements; }
        }
        //
        //  Has Been Satisfied
        public Boolean IsSatisfied
        {
            set => _IsSatisfied = value;
            get { return _IsSatisfied; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Role (As a...)
        public List<Role> MyRoles
        {
            set => _MyRoles = value;
            get { return _MyRoles; }
        }
        //  
        //  Me
        public DWM_Stakeholder Me
        {
            set => _Me = value;
            get { return _Me; }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region
        public String CreateNeedsSummary()
        {
            //  As A ...
            String tempAs_A = "";
            foreach (String tempString in As_A_Statements)
            {
                tempAs_A = tempAs_A + " and " + tempString;
            }

            //  I Need ...
            String tempI_Need = "";
            foreach (String tempString in I_Need_Statements)
            {
                tempI_Need = tempI_Need + " and " + tempString;
            }

            //  So That ...
            String tempSo_That = "";
            foreach (String tempString in So_That_Statements)
            {
                tempSo_That = tempSo_That + " and " + tempString;
            }
            String SummaryString = tempAs_A + " " + tempI_Need + " " + tempSo_That;
            return SummaryString;
        }
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
