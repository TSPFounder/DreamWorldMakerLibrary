﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using SystemsEngineering;
using CAD;
using MissionsNamespace;

namespace SensorNamespace
{
    public class Sensor : DWM_System
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //
        //  Identification
       
        //
        //  Owned & Owning Objects
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
        #region
        //
        //  System Type
        public enum SystemTypeEnum
        {
            SoS = 0,
            SoI,
            Subsystem,
            ConfigurationItem,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SENSOR CONSTRUCTOR
        //
        //  ************************************************************
        public Sensor()
        {
            //  Managers
            this.MyAppMgr = this.TheMainWindow.MyAppManager;

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************

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
