using System;
using System.Collections.Generic;
using Mathematics;
using SystemsEngineering;

namespace CAD
{
    public class CAD_Station
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _ID;
        private String _Version;

        //  Station Data
        //
        //  Station Type
        private StationTypeEnum _MyType;
        //
        //  Axial Location
        private Double _AxialLocation;
        //
        //  Radial Location
        private Double _RadialLocation;
        //
        //  Angular Location
        private Double _AngularLocation;
        //
        //  Wing Location
        private Double _WingLocation;

        //  Owned & Owning Objects
        //
        //  My Model
        private CAD_Model _MyModel;
        //
        //  Sketch Planes
        private CAD_SketchPlane _CurrentSketchPlane;
        private List<CAD_SketchPlane> _MySketchPlanes;
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
        public enum StationTypeEnum
        {
            Axial = 0,
            Radial,
            Angular,
            Wing,
            Other
        }
        //  *****************************************************************************************


            //  *****************************************************************************************
            //  CAD_STATION CONSTRUCTOR
            //
            //  ************************************************************
        public CAD_Station()
        {
            this._MySketchPlanes = new List<CAD_SketchPlane>();

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
        //  ID
        public String ID
        {
            set => _ID = value;
            get
            {
                return _ID;
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
        //
        //  Owned & Owning Objects
        //
        //  Station Type
        public StationTypeEnum MyType
        {
            set => _MyType = value;
            get
            {
                return _MyType;
            }
        }
        //
        //  Axial Location
        public Double AxialLocation
        {
            set => _AxialLocation= value;
            get
            {
                return _AxialLocation;
            }
        }
        //
        //  Radial Location
        public Double RadialLocation
        {
            set => _RadialLocation = value;
            get
            {
                return _RadialLocation;
            }
        }
        //
        //  Angular Location
        public Double AngularLocation
        {
            set => _AngularLocation = value;
            get
            {
                return _AngularLocation;
            }
        }
        //
        //  Wing Location
        public Double WingLocation
        {
            set => _WingLocation = value;
            get
            {
                return _WingLocation;
            }
        }

        //  Owned & Owning Objects
        //
        //  My Model
        public CAD_Model MyModel
        {
            set => _MyModel = value;
            get
            {
                return _MyModel;
            }
        }
        //
        //  Sketch Planes
        public CAD_SketchPlane CurrentSketchPlane
        {
            set => _CurrentSketchPlane = value;
            get
            {
                return _CurrentSketchPlane;
            }
        }
        public List<CAD_SketchPlane> MySketchPlanes
        {
            set => _MySketchPlanes = value;
            get
            {
                return _MySketchPlanes;
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
