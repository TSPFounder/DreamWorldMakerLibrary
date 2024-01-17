using System;
using System.Collections.Generic;
using Mathematics;
using SystemsEngineering;
using MissionsNamespace;

namespace CAD
{
    public class CAD_Assembly : CAD_Component
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Version;
        private String _Description;
        //
        //  Booleans
        private Boolean _IsSubAssembly;
        private Boolean _IsConfigurationItem;
        //
        //  Owned & Owning Objects
        //
        //  Components
        private CAD_Component _CurrentComponent;
        private CAD_Component _PreviousComponent;
        private CAD_Component _NextComponent;
        private List<CAD_Component> _MyComponents;
        //
        //  Model
        private CAD_Model _MyModel;
        //
        //  Configurations
        private CAD_Configuration _CurrentConfiguration;
        private List<CAD_Configuration> _MyConfigurations;
        //
        //  Requirements
        //
        //  Mission Requirements
        private List<MissionRequirement> _MissionRequirements;
        //
        //  System Requirements
        private List<SystemRequirement> _SystemRequirements;
        //
        // CAD Parts
        private CAD_Part _MyPart;
        //
        //  CAD Stations
        private List<CAD_Station> _AxialStations;
        private List<CAD_Station> _RadialStations;
        private List<CAD_Station> _AngularStations;
        private List<CAD_Station> _WingStations;
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
        //  CAD_ASSEMBLY CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_Assembly()
        {
            this.MyComponents = new List<CAD_Component>();
            this.MissionRequirements = new List<MissionRequirement>();
            this.SystemRequirements = new List<SystemRequirement>();
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
        //  Booleans
        public Boolean IsSubAssembly
        {
            set => _IsSubAssembly = value;
            get { return _IsSubAssembly; }
        }
        public Boolean IsConfigurationItem
        {
            set => _IsConfigurationItem = value;
            get { return _IsConfigurationItem; }
        }

        //
        //  Owned & Owning Objects
        //
        //  Components
        public CAD_Component CurrentComponent
        {
            set => _CurrentComponent = value;
            get { return _CurrentComponent; }
        }
        public CAD_Component PreviousComponent
        {
            set => _PreviousComponent = value;
            get { return _PreviousComponent; }
        }
        public CAD_Component NextComponent
        {
            set => _NextComponent = value;
            get { return _NextComponent; }
        }
        //
        //  My Components
        public List<CAD_Component> MyComponents
        {
            set => _MyComponents = value;
            get { return _MyComponents; }
        }
        //
        //  My Model
        public CAD_Model MyModel
        {
            set => _MyModel = value;
            get { return _MyModel; }
        }
        //
        //  Configurations
        //
        //  Current Configuration
        public CAD_Configuration CurrentConfiguration
        {
            set => _CurrentConfiguration = value;
            get { return _CurrentConfiguration; }
        }
        //
        //  My Configurations
        public List<CAD_Configuration> MyConfigurations
        {
            set => _MyConfigurations = value;
            get { return _MyConfigurations; }
        }
        //
        //  Requirements
        //
        //  Mission Requirements
        public List<MissionRequirement> MissionRequirements
        {
            set => _MissionRequirements = value;
            get { return _MissionRequirements; }
        }
        //
        //  System Requirements
        public List<SystemRequirement> SystemRequirements
        {
            set => _SystemRequirements = value;
            get { return _SystemRequirements; }
        }
        //
        //  My CAD Part
        public CAD_Part MyPart
        {
            set => _MyPart = value;
            get { return _MyPart; }
        }
        //
        //  CAD Stations
        //
        //  Axial Stations
        public List<CAD_Station> AxialStations
        {
            set => _AxialStations = value;
            get { return _AxialStations; }
        }
        //
        //  Radial Stations
        public List<CAD_Station> RadialStations
        {
            set => _RadialStations = value;
            get { return _RadialStations; }
        }
        //
        //  Angular Stations
        public List<CAD_Station> AngularStations
        {
            set => _AngularStations = value;
            get { return _AngularStations; }
        }
        //
        //  Wing Stations
        public List<CAD_Station> WingStations
        {
            set => _WingStations = value;
            get { return _WingStations; }
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
