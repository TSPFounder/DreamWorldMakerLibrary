using System;
using System.Collections.Generic;
using Mathematics;
using SystemsEngineering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Bson;

namespace CAD
{
    public class CAD_Sketch
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _SketchID;
        private String _Version;
        //
        //  Data
        private Double _Area;
        private Double _PerimeterLength;
        //
        //  Owned & Owning Objects
        //
        //  My Model
        private CAD_Model _MyModel;
        //
        //  Geometry
        //
        //  Segments
        //
        //  Current Segment
        private Segment _CurrentSegment;
        private Segment _PreviousSegment;
        private List<Segment> _MySegments;
        //
        //  Dimensions
        private CAD_Dimension _CurrentDimension;
        private List<CAD_Dimension> _MyDimensions;
        //
        //  Parameters
        private CAD_Parameter _CurrentParameter;
        private List<CAD_Parameter> _MyParameters;
        //
        //  Constraints
        private CAD_Constraint _CurrentConstraint;
        private List<CAD_Constraint> _MyConstraints;
        //
        //  Profile
        private List<Segment> _MyProfile;
        //
        //  Segment Booleans
        private Boolean _IsTwoD;
        //
        //  2-Dimensional Geometry
        private List<TwoDGeometry> _My2DGeometry;
        //
        //  Coordinate Systems
        private CoordinateSystem _CurrentCoordinateSystem;
        private CoordinateSystem _BaseCoordinateSystem;
        private List<CoordinateSystem> _MyCoordinateSystems;
        //
        //  My Sketch Plane
        private CAD_SketchPlane _MySketchPlane;
       
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

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_SKETCH CONSTRUCTOR
        //
        //  ************************************************************
        public CAD_Sketch()
        {
            this.MySegments = new List<Segment>();
            this.MyCoordinateSystems = new List<CoordinateSystem>();
            this.MyDimensions = new List<CAD_Dimension>();
            this.MyParameters = new List<CAD_Parameter>();
            this.MyConstraints = new List<CAD_Constraint>();
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
        //  Sketch ID
        public String SketchID
        {
            set => _SketchID = value;
            get { return _SketchID; }
        }
        //
        //  Version
        public String Version
        {
            set => _Version = value;
            get { return _Version; }
        }
        //
        //  Data
        //  
        //  Area
        public Double Area
        {
            set => _Area = value;
            get
            {
                return _Area;
            }
        }
        //
        //  Perimeter Length
        public Double PerimeterLength
        {
            set => _PerimeterLength = value;
            get
            {
                return _PerimeterLength;
            }
        }
        //
        // Owned & Owning Objects
        //
        // CAD Model
        public CAD_Model MyModel
        {
            set => _MyModel = value;
            get { return _MyModel; }
        }
        //  Segment Parameters
        public Boolean IsTwoD
        {
            set => _IsTwoD = value;
            get { return _IsTwoD; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Segments
        //
        //  Current Segment
        public Segment CurrentSegment
        {
            set => _CurrentSegment = value;
            get { return _CurrentSegment; }
        }
        //
        //  Previous Segment
        public Segment PreviousSegment
        {
            set => _PreviousSegment = value;
            get { return _PreviousSegment; }
        }
        //
        //  My Segments
        public List<Segment> MySegments
        {
            set => _MySegments = value;
            get { return _MySegments; }
        }
        //
        //  Profile
        public List<Segment> MyProfile
        {
            set => _MyProfile = value;
            get { return _MyProfile; }
        }
        //  Geometry
        //
        //  2-Dimensional Geometry
        public List<TwoDGeometry> My2DGeometry
        {
            set => _My2DGeometry = value;
            get { return _My2DGeometry; }
        }
        //
        //  Coordinate Systems
        public CoordinateSystem CurrentCoordinateSystem
        {
            set => _CurrentCoordinateSystem = value;
            get { return _CurrentCoordinateSystem; }
        }
        public CoordinateSystem BaseCoordinateSystem
        {
            set => _BaseCoordinateSystem = value;
            get { return _BaseCoordinateSystem; }
        }
        public List<CoordinateSystem> MyCoordinateSystems
        {
            set => _MyCoordinateSystems = value;
            get { return _MyCoordinateSystems; }
        }
        //
        //  My Sketch Plane
        public CAD_SketchPlane MySketchPlane
        {
            set => _MySketchPlane = value;
            get { return _MySketchPlane; }
        }
        //
        //  Parameters
        //
        //  Current Parameter
        public CAD_Parameter CurrentParameter
        {
            set => _CurrentParameter = value;
            get
            {
                return _CurrentParameter;
            }
        }
        //
        //  My Parameters
        public List<CAD_Parameter> MyParameters
        {
            set => _MyParameters = value;
            get
            {
                return _MyParameters;
            }
        }
        //
        //  Dimensions
        //
        //  Current Dimension
        public CAD_Dimension CurrentDimension
        {
            set => _CurrentDimension = value;
            get { return _CurrentDimension; }
        }
        //
        //  My Dimensions
        public List<CAD_Dimension> MyDimensions
        {
            set => _MyDimensions = value;
            get { return _MyDimensions; }
        }
        //
        //  Constraints
        //
        //  Current Constraint
        public CAD_Constraint CurrentConstraint
        {
            set => _CurrentConstraint = value;
            get { return _CurrentConstraint; }
        }
        //
        //  My Constraints
        public List<CAD_Constraint> MyConstraints
        {
            set => _MyConstraints = value;
            get { return _MyConstraints; }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region
        //
        //  Write the Sketch to JSON
        public Boolean WriteSketchToJSON(List<Segment> MySegments)
        {
            try
            {
                //  Loop through the segments to verify they make a contiguous closed loop
                foreach (Segment CurrentSegment in MySegments)
                {
                    //  Set the values for the starting point of the first segment
                    if (MySegments.IndexOf(CurrentSegment) == 0)
                    {
                        Double X_StartValue = CurrentSegment.StartPoint.X_Value;
                        Double Y_StartValue = CurrentSegment.StartPoint.Y_Value;
                        Double Z_StartValue = CurrentSegment.StartPoint.Z_Value_Cartesian;
                    }
                    else
                    {
                        if (CurrentSegment.StartPoint.X_Value == PreviousSegment.EndPoint.X_Value)
                        {
                            if (CurrentSegment.StartPoint.Y_Value == PreviousSegment.EndPoint.Y_Value)
                            {
                                if (CurrentSegment.StartPoint.Z_Value_Cartesian == PreviousSegment.EndPoint.Z_Value_Cartesian)
                                {
                                    
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    PreviousSegment = CurrentSegment;
                    if (MySegments.Count == MySegments.LastIndexOf(CurrentSegment) - 1  )
                    {

                    }
                }
                return true;
            }

            catch
            {

                return false;
            }

        }
        //
        //  Create the Profile
        public void CreateProfile()
        {


        }
        #endregion
        //  *****************************************************************************************
    }
}
