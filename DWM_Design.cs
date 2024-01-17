using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using Documents;
using CAD;

namespace SystemsEngineering
{
    public class DWM_Design
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Version;
        //  
        //  Owned & Owning Objects
        //
        //  Notebooks
        private EngineeringNotebook _CurrentLiveScript;
        private List<EngineeringNotebook> _MyLiveScripts;
        //
        //  CAD Models
        private CAD_Model _CurrentCAD_Model;
        private List<CAD_Model> _CAD_Models;
        //
        //  Change Orders
        private CAD_ChangeOrder _CurrentChangeOrder;
        private List<CAD_ChangeOrder> _MyChangeOrders;
        //
        //  System Design Document
        private DWM_DesignDescription _SDD;
        private DWM_DesignDescription _SwDD;
        //  *****************************************************************************************


        //  ****************************************************************************************
        //  INITIALIZATIONS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ENUMERATIONS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  DESIGN CONSTRUCTOR
        //
        //  ************************************************************
        public DWM_Design()
        {

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        //
        //  Name
        public String Name
        {
            set => _Name = value;
            get
            {
                return _Name;
            }
        }
        //
        //  Version
        public String Version
        {
            set => _Version = value;
            get
            {
                return _Version;
            }
        }
        //  
        //  Owned & Owning Objects       
        //
        //  CAD_Models
        public CAD_Model CurrentCAD_Model
        {
            set => _CurrentCAD_Model = value;
            get
            {
                return _CurrentCAD_Model;
            }
        }
        public List<CAD_Model> CAD_Models
        {
            set => _CAD_Models = value;
            get
            {
                return _CAD_Models;
            }
        }
       
        
             
        //
        //  LiveScripts
        public EngineeringNotebook CurrentLiveScript
        {
            set => _CurrentLiveScript = value;
            get
            {
                return _CurrentLiveScript;
            }
        }
        public List<EngineeringNotebook> MyLiveScripts
        {
            set => _MyLiveScripts = value;
            get
            {
                return _MyLiveScripts;
            }
        }
        //
        //  Change Orders
        public CAD_ChangeOrder CurrentChangeOrder
        {
            set => _CurrentChangeOrder = value;
            get
            {
                return _CurrentChangeOrder;
            }
        }
        public List<CAD_ChangeOrder> MyChangeOrders
        {
            set => _MyChangeOrders = value;
            get
            {
                return _MyChangeOrders;
            }
        }
        //
        //  System Design Document
        public DWM_DesignDescription SDD
        {
            set => _SDD = value;
            get
            {
                return _SDD;
            }
        }
        private DWM_DesignDescription SwDD
        {
            set => _SwDD = value;
            get
            {
                return _SwDD;
            }
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
