using SystemsEngineering;
using System;
using System.Collections.Generic;
using Propulsion;


using CEA;
using Missile_Datcom;

using CAD;
using AircraftObjects;
using MissionsNamespace;
using Power;
using Structure;
using SensorNamespace;
using ThermalManagement;
using GNC;
using Communications;
using Fluidics;
using Data;
using Controls;

using Rocket;
using Structure;
using MissionsNamespace;
using MLApp;
using SystemsEngineering;

namespace Simulation
{
    public class SimulinkModel : AppFile
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private SimulinkFileTypeEnum _SimulinkFileType;
        //
        //  Data
        private String _SolverName;
        //
        //  Owned & Owning Objects
        //
        //  Matlab App
        private MatlabApp _MyMatlabApp;
        //
        //  DWM System
        private DWM_System _MySystem;
        //
        //  Toolboxes & Blocksets

        #endregion
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
        public enum SimulinkFileTypeEnum
        {
            MAT = 0,
            MX,
            M,
            MEX,
            MLIB,
            MLAPP,
            MLPROJ,
            MLTBX,
            MLX
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SIMULINKMODEL CONSTRUCTOR
        //
        //  ************************************************************
        public SimulinkModel()
        {

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region
        //
        //  Identification
        //
        //  Simulink File Type
        public SimulinkFileTypeEnum SimulinkFileType
        {
            set => _SimulinkFileType = value;
            get
            {
                return _SimulinkFileType;
            }
        }
        //
        //  Data
        public String SolverName
        {
            set => _SolverName = value;
            get { return _SolverName; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Matlab File Type
        public MatlabApp MyMatlabApp
        {
            set => _MyMatlabApp = value;
            get
            {
                return _MyMatlabApp;
            }
        }
        public DWM_System MySystem
        {
            set => _MySystem = value;
            get { return _MySystem; }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        public Boolean OpenModel(String tempPath)
        {
            return true;
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
