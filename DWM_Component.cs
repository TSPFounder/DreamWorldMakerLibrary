using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using Propulsion;
using Power;
using Structure;
using SensorNamespace;
using ThermalManagement;
using Communications;
using Fluidics;
using Data;
*/
using CAD;
//using Controls;

namespace MissionsNamespace
{
    public class DWM_Component : MissionElement
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
        //  Is a Purchased Part
        private Boolean _IsPurchasedPart;
        //
        //  Owned & Owning Objects
        //
        // Systems
        private DWM_System _CurrentSystem;
        private List<DWM_System> _MySystems;
        //
        //  Models
        //
        // CAD Models
        private CAD_Model _CurrentModel;
        private List<CAD_Model> _MyCAD_Models;
        //
        //  System Models
        private DWM_SystemModel _CurrentSystemModel;
        private List<DWM_SystemModel> _MySystemModels;
        // 
        //  My Assembly
        private CAD_Assembly _MyAssembly;
        //
        //  Sub-Assemblies
        private List<CAD_Assembly> _Subassemblies;

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
        //  DWM_COMPONENT CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public DWM_Component()
        {
            //  DWM Systems
            this.MySystems = new List<DWM_System>();
            //
            //  Models
            this.MyCAD_Models = new List<CAD_Model>();
            this.Subassemblies = new List<CAD_Assembly>();
            this.MySystemModels = new List<DWM_SystemModel>();
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
        //  Data
        //
        //  Is a Purchased Part
        public Boolean IsPurchasedPart
        {
            set => _IsPurchasedPart = value;
            get { return _IsPurchasedPart; }
        }
        //
        //  Owned & Owning Objects       
        //
        // Systems
        //
        //  Current System
        public DWM_System CurrentSystem
        {
            set => _CurrentSystem = value;
            get { return _CurrentSystem; }
        }
        //
        //  My Systems
        public List<DWM_System> MySystems
        {
            set => _MySystems = value;
            get { return _MySystems; }
        }
        //
        //  Models
        //
        //  Current CAD Model
        public CAD_Model CurrentModel
        {
            set => _CurrentModel = value;
            get { return _CurrentModel; }
        }
        //
        //  My CAD Models
        public List<CAD_Model> MyCAD_Models
        {
            set => _MyCAD_Models = value;
            get { return _MyCAD_Models; }
        }
        //
        //  Current System Model
        public DWM_SystemModel CurrentSystemModel
        {
            set => _CurrentSystemModel = value;
            get { return _CurrentSystemModel; }
        }
        //
        //  My System Models
        public List<DWM_SystemModel> MySystemModels
        {
            set => _MySystemModels = value;
            get { return _MySystemModels; }
        }
        //
        //  My Assembly
        public CAD_Assembly MyAssembly
        {
            set => _MyAssembly = value;
            get { return _MyAssembly; }
        }
        //
        //  Sub-Assemblies
        public List<CAD_Assembly> Subassemblies
        {
            set => _Subassemblies = value;
            get { return _Subassemblies; }
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
