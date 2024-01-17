using System;
using System.Collections.Generic;
using Propulsion;
using Power;
using Structure;
using SensorNamespace;
using ThermalManagement;
using GNC;
using Communications;
using Fluidics;
using Data;
using CAD;
using Controls;
using SystemsEngineering;



namespace MissionsNamespace
{
    public class ScenarioDesigner
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //
        //  Identification
        private Boolean _IsUAV_ToolboxScenarioDesigner;
        //
        //  Data

        //
        //  Owned & Owning Objects
        private MissionScenario _CurrentScenario;
        private List<MissionScenario> _Scenarios;
        //
        //  Controls
        //
        //  My Window
        private MainWindow _TheMainWindow;
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
        //  SCENARIODESIGNER CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public ScenarioDesigner(MainWindow MyMainWindow)
        {
            //  Windows
            this.TheMainWindow = MyMainWindow;
            this.Scenarios = new List<MissionScenario>();
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
        //  Is UAV Toolbox Scenario
        public Boolean IsUAV_ToolboxScenarioDesigner
        {
            set => _IsUAV_ToolboxScenarioDesigner = value;
            get { return _IsUAV_ToolboxScenarioDesigner; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Current Scenario
        public MissionScenario CurrentScenario
        {
            set => _CurrentScenario = value;
            get { return _CurrentScenario; }
        }
        //
        //  Scenarios
        public List<MissionScenario> Scenarios
        {
            set => _Scenarios = value;
            get { return _Scenarios; }
        }
        //  ************************************************************
        //  MAIN RIBBON WINDOW OBJECT
        public MainWindow TheMainWindow
        {
            set => _TheMainWindow = value;
            get { return _TheMainWindow; }

        }
        //  ************************************************************
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region
        public MissionScenario CreateScenario(String myName)
        {
            this.CurrentScenario = new MissionScenario(this.TheMainWindow);
            this.CurrentScenario.Name = myName;
            this.Scenarios.Add(this.CurrentScenario);
            return this.CurrentScenario;
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
