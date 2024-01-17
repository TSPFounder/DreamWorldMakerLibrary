using System;
using System.Collections.Generic;
//using Propulsion;
using Power;
using Structure;
using SensorNamespace;
//using ThermalManagement;

//using Communications;
//using Fluidics;
//using Data;
using CAD;
using Controls;
using SystemsEngineering;

using SystemsEngineering;

namespace MissionsNamespace
{
    public class MissionGoal
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Name;
        //
        //  Data
        private Role _MyRole;
        private List<NeedsStatement> _Needs;
        private String _Outcome;
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

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  MISSIONGOAL CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public MissionGoal()
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
        //  Goal Name
        public String Name
        {
            set => _Name = value;
            get { return _Name; }
        }
        //
        //  Data
        //
        //  Role (As a...)
        public Role MyRole
        {
            set => _MyRole = value;
            get { return _MyRole; }
        }
        //
        //  Need (I need...)
        public List<NeedsStatement> Needs
        {
            set => _Needs = value;
            get { return _Needs; }
        }
        //
        //  Outcome (So that...)
        public String Outcome
        {
            set => _Outcome = value;
            get { return _Outcome; }
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
