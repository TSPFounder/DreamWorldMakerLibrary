using DATCOM;
using SystemsEngineering;
using System;
using System.Collections.Generic;
using CAD;
using MissionsNamespace;

namespace AircraftObjects
{
    public class Aileron :FlightControl
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Version;

        //  Owned & Owning Objects
        //
        //  Aircraft Objects
        //
        //  My Aircraft
        private Aircraft _MyAircraft;
        //
        //  Airfoils
        private Airfoil _CurrentAirfoil;
        private List<Airfoil> _Airfoils;
        //
        //  CAD Objects
        private CAD_Model _MyCAD_Model;
        private CAD_Assembly _MyAssembly;
        private List<CAD_Component> _MyComponents;

        //
        //  App Objects
        private List<DATCOM_Model> _MyDATCOM_Models;

        //  System Objects
        private SystemOfInterest _MySoI;
        private SystemOfSystems _MySoS;

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
        //  AILERON CONSTRUCTOR
        //
        //  ************************************************************
        public Aileron()
        {
            //
            //  System Type
            this.MyType = ElementTypeEnum.ConfigurationItem;
            //
            //  Owned & Owning Objects
            this.Airfoils = new List<Airfoil>();
            this.MyCAD_Models = new List<CAD_Model>();
            this.MyDATCOM_Models = new List<DATCOM_Model>();
            this.MyInterfacingComponents = new List<DWM_Component>();
            this.MyPlants = new List<Plant>(); 
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
        //  Owned & Owning Objects
        //
        //  Aircraft Objects
        //
        //  My Aircraft
        public Aircraft MyAircraft
        {
            set => _MyAircraft = value;
            get
            {
                return _MyAircraft;
            }
        }
        //
        //  Current Airfoil
        public Airfoil CurrentAirfoil
        {
            set => _CurrentAirfoil = value;
            get
            {
                return _CurrentAirfoil;
            }
        }
        //
        //  Airfoils
        public List<Airfoil> Airfoils
        {
            set => _Airfoils = value;
            get
            {
                return _Airfoils;
            }
        }
        //
        //  CAD Objects
        //
        //  CAD Model
        public CAD_Model MyCAD_Model
        {
            set => _MyCAD_Model = value;
            get
            {
                return _MyCAD_Model;
            }
        }
        //
        //  My CAD Assembly
        public CAD_Assembly MyAssembly
        {
            set => _MyAssembly = value;
            get
            {
                return _MyAssembly;
            }
        }
        //
        //  My CAD Assemblies
        public List<CAD_Component> MyComponents
        {
            set => _MyComponents = value;
            get
            {
                return _MyComponents;
            }
        }

        //
        //  App Objects
        //
        //  DATCOM Models
        public List<DATCOM_Model> MyDATCOM_Models
        {
            set => _MyDATCOM_Models = value;
            get
            {
                return _MyDATCOM_Models;
            }
        }

        //  System Objects
        //
        //  System of Interest
        public SystemOfInterest MySoI
        {
            set => _MySoI = value;
            get
            {
                return _MySoI;
            }
        }
        //
        //  System of Systems
        public SystemOfSystems MySoS
        {
            set => _MySoS = value;
            get
            {
                return _MySoS;
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
