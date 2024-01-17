using System;
using System.Collections.Generic;
using System.Windows.Controls.Ribbon;
using Propulsion;
using Power;
using Structure;
using SensorNamespace;
using ThermalManagement;

using Communications;
using Fluidics;
using Data;
using CAD;
using Controls;
using SystemsEngineering;

using SysML;

namespace MissionsNamespace
{
    public class MeasureOfEffectiveness
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Title;
        private String _Description;
        private String _ID;
        //
        //  Data

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
        //  MEASUREOFEFFECTIVENESS CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public MeasureOfEffectiveness()
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
        // Title
        public String Title
        {
            set => _Title = value;
            get { return _Title; }
        }
        //
        // Description
        public String Description
        {
            set => _Description = value;
            get { return _Description; }
        }
        //
        // ID
        public String ID
        {
            set => _ID = value;
            get { return _ID; }
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
