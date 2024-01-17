using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class Vector 
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _VectorID;
        private Boolean _IsKnotVector;
        private VectorTypeEnum _VectorType;
        //  Data
        //
        //  Vector Values
        //
        //  Length
        private Double _Length;
        //
        //  Cartesian
        private Double _X_Value;
        private Double _Y_Value;
        private Double _Z_Value;
        //
        //  Cylindrical & Polar
        private Double _Cyl_R;
        private Double _Cyl_Theta;
        private Double _L;
        //
        //  Spherical
        private Double _Sph_R;
        private Double _Sph_Theta;
        private Double _Phi;
        //
        //  Owned & Owning Objects
        //
        //  Points
        //  
        //  Points
        private Point _StartPoint;
        private Point _EndPoint;
        //
        //  Coordinate System
        private CoordinateSystem _WorldCoordinateSystem = new CoordinateSystem();
        private CoordinateSystem _CurrentCoordinateSystem;
        private List<CoordinateSystem> _CoordinateSystems;
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
        public enum VectorTypeEnum
        {
            Cartesian = 0,
            Cylindrical,
            Spherical,
            Polar
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  VECTOR CONSTRUCTOR
        //
        //  ************************************************************
        public Vector(Point startCartesianPoint, Point endCartesianPoint)
        {
            //
            //  My Lengths
            this.X_Value = endCartesianPoint.X_Value - startCartesianPoint.X_Value;
            this.Y_Value = endCartesianPoint.Y_Value - startCartesianPoint.Y_Value;
            this.Z_Value = endCartesianPoint.X_Value - startCartesianPoint.X_Value;
            //
            //  WCS Base Vector
            //
            //  0,0,0 Start Point
            this.WorldCoordinateSystem.BaseVector.StartPoint.X_Value = 0;
            this.WorldCoordinateSystem.BaseVector.StartPoint.Y_Value = 0;
            this.WorldCoordinateSystem.BaseVector.StartPoint.Z_Value_Cartesian = 0;
            //
            //  0,0,0 End Point
            this.WorldCoordinateSystem.BaseVector.EndPoint.X_Value = 0;
            this.WorldCoordinateSystem.BaseVector.EndPoint.Y_Value = 0;
            this.WorldCoordinateSystem.BaseVector.EndPoint.Z_Value_Cartesian = 0;
            //
            //  Coordinate System List
            this.CoordinateSystems = new List<CoordinateSystem>();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        public String Name
        {
            set => _Name = value;
            get { return _Name; }
        }
        public String VectorID
        {
            set => _VectorID = value;
            get { return _VectorID; }
        }
        public Boolean IsKnotVector
        {
            set => _IsKnotVector = value;
            get { return _IsKnotVector; }
        }
        //
        //  Vector Type
        public VectorTypeEnum VectorType
        {
            set => _VectorType = value;
            get { return _VectorType; }
        }
        //  Data
        //
        //
        //  Length
        public Double Length
        {
            set => _Length = value;
            get { return _Length; }
        }
        //
        //  Vector Values
        //
        //  Cartesian
        public Double X_Value
        {
            set => _X_Value = value;
            get { return _X_Value; }
        }
        
        public Double Y_Value
        {
            set => _Y_Value = value;
            get { return _Y_Value; }
        }
        public Double Z_Value
        {
            set => _Z_Value = value;
            get { return _Z_Value; }
        }
        //
        //  Cylindrical & Polar
        public Double Cyl_R
        {
            set => _Cyl_R = value;
            get { return _Cyl_R; }
        }
        public Double Cyl_Theta
        {
            set => _Cyl_Theta = value;
            get { return _Cyl_Theta; }
        }
        public Double L
        {
            set => _L = value;
            get { return _L; }
        }
        
        //
        //  Spherical
        public Double Sph_R
        {
            set => _Sph_R = value;
            get { return _Sph_R; }
        }
        public Double Sph_Theta
        {
            set => _Sph_Theta = value;
            get { return _Sph_Theta; }
        }
        public Double Phi
        {
            set => _Phi = value;
            get { return _Phi; }
        }
        //
        //  Owned &Owning Objects
        //  
        //  Points
        public Point StartPoint
        {
            set => _StartPoint = value;
            get
            {
                return _StartPoint;
            }
        }
        public Point EndPoint
        {
            set => _EndPoint = value;
            get
            {
                return _EndPoint;
            }
        }
        //
        //  Coordinate Systems
        //
        //  World Coordinate System
        public CoordinateSystem WorldCoordinateSystem
        {
            set => _WorldCoordinateSystem = value;
            get { return _WorldCoordinateSystem; }
        }
        //
        //  Current Coordinate System
        public CoordinateSystem CurrentCoordinateSystem
        {
            set => _CurrentCoordinateSystem = value;
            get { return _CurrentCoordinateSystem; }
        }
        //
        //  list of Coordinate Systems
        public List<CoordinateSystem> CoordinateSystems
        {
            set => _CoordinateSystems = value;
            get { return _CoordinateSystems; }
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        public Double GetVectorLength()
        {
            Double Length = 0;
            if (this.VectorType == VectorTypeEnum.Cartesian)
            {
                //  Cartesian
                Length = Math.Sqrt(this.X_Value * this.X_Value * +this.Y_Value * this.Y_Value + this.Z_Value * this.Z_Value);
            }
            else if (this.VectorType == VectorTypeEnum.Cylindrical)
            {
                Length = Math.Sqrt(this.Cyl_R * this.Cyl_R + this.L * this.L);
            }
            else if (this.VectorType == VectorTypeEnum.Spherical)
            {
                Length = Math.Abs(this.Sph_R);
            }
            else if (this.VectorType == VectorTypeEnum.Polar)
            {
                Length = Math.Abs(this.L);
            }
            return Length;
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
