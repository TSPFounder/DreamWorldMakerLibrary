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

using SystemsEngineering;

namespace Simulation
{
    public class SimscapeModel : SimulinkModel
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
        private String _Path;
        //
        //  Enumerations
        //
        //  Library Type
        private LibraryTypeEnum _MyLibraryType;
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
        public enum LibraryTypeEnum
        {
            General = 0,
            Battery,
            Driveline,
            Electrical,
            Fluids,
            Multibody
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  SIMSCAPEMODEL CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public SimscapeModel()
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
        //  Path
        public String Path
        {
            set => _Path = value;
            get { return _Path; }
        }
        //
        //  Enumerations
        //
        //  Library Type
        public LibraryTypeEnum LibraryType
        {
            set => _MyLibraryType = value;
            get { return _MyLibraryType; }
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
