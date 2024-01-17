using System;
using System.Collections.Generic;
//using Propulsion;
using Power;
using Structure;
using SensorNamespace;
/*
using ThermalManagement;
using GNC;
using Communications;
using Fluidics;
using Data;
*/
using CAD;
using Controls;
using SystemsEngineering;
using Simulation;

namespace MissionsNamespace
{
    public class DWM_SystemModel
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
        //
        //  Data
        private WorkBreakdownStructure _WBS;
        //
        //  Owned & Owning Objects
        //
        //  Application Manager
        private ApplicationManager _TheApplicationManager;
        //
        //  App Models
        //
        //  Simulation Models
        private List<SimulationModel> _SimulationModels;
        //
        //  Simscape Models
        private List<SimscapeModel> _SimscapeModels;
        //
        //  Simulink Models
        private List<SimulinkModel> _SimulinkModels;
        
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
        //  System Model Type
        public enum ModelTypeEnum
        {
            Simulink = 0,
            Simscape,
            CAD,
            ACE,
            CEA,
            CMA,
            DATCOM,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SYSTEMODEL CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public DWM_SystemModel()
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
        public String Name
        {
            set => _Name = value;
            get { return _Name; }
        }
        public String Version
        {
            set => _Version = value;
            get { return _Version; }
        }
        //
        //  Data
        public WorkBreakdownStructure WBS
        {
            set => _WBS = value;
            get { return _WBS; }
        }
        //
        //  Owned & Owning Objects
        //
        /*
        //  Application Manager
        public ApplicationManager TheApplicationManager
        {
            set => _TheApplicationManager = value;
            get { return _TheApplicationManager; }
        }
        */
        //
        //  App Models
        //
        //  Simulation Models
        public List<SimulationModel> SimulationModels
        {
            set => _SimulationModels = value;
            get { return _SimulationModels; }
        }
        //
        //  Simulink Models
        public List<SimulinkModel> SimulinkModels
        {
            set => _SimulinkModels = value;
            get { return _SimulinkModels; }
        }
        //
        //  Simscape Models
        public List<SimscapeModel> SimscapeModels
        {
            set => _SimscapeModels = value;
            get { return _SimscapeModels; }
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
