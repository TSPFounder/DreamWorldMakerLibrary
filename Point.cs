using System;
using System.Collections.Generic;
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


namespace Mathematics
{
    public class Point
    {
        //  *****************************************************************************************
        // DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _PointID;
        private Boolean _IsWeightPoint;
        //
        //  Data
        //
        //  Is 2-D
        private Boolean _Is2D;
        //
        //  Type
        private PointTypeEnum _MyType;
        //
        //  Geometry
        //
        //  Cartesian Values
        private Double _X_Value;
        private Double _Y_Value;
        private Double _Z_Value_Cartesian;
        //
        //  Cylindrical Values
        private Double _R_Value_Cylindrical;
        private Double _Theta_Value_Cylindrical;
        private Double _Z_Value_Cylindrical;
        //
        //  Spherical Values
        private Double _R_Value_Spherical;
        private Double _Theta_Value_Spherical;
        private Double _Phi_Value;
        //
        //  Complex Values
        private Double _Real_Value;
        private Double _Complex_Value;
        //
        //  Coordinate Systems
        private CoordinateSystem _CurrentCoordinateSystem;
        private List<CoordinateSystem> _MyCoordinateSystems;
        //  *****************************************************************************************


        //  ****************************************************************************************
        //  INITIALIZATIONS
        //
        //  ************************************************************

        //  *****************************************************************************************


        //  *****************************************************************************************
        // ENUMERATIONS
        //
        //  ************************************************************
        public enum PointTypeEnum
        {
            Cartesian = 0,
            Cylindrical,
            Spherical,
            Complex
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  POINTCLASS CONSTRUCTOR
        //
        //  ************************************************************
        public Point()
        {
            this.MyCoordinateSystems = new List<CoordinateSystem>();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region
        //
        //  Identification
        public String PointID
        {
            set => _PointID = value;
            get { return _PointID; }
        }
        public Boolean IsWeightPoint
        {
            set => _IsWeightPoint = value;
            get { return _IsWeightPoint; }
        }
        //
        //  Type
        public PointTypeEnum MyType
        {
            set => _MyType = value;
            get { return _MyType; }
        }
        //
        //  Data
        //
        //  Is 2-D
        public Boolean Is2D
        {
            set => _Is2D = value;
            get { return _Is2D; }
        }
        //
        //  Geometry
        //
        //  Cartesian Values
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
        public Double Z_Value_Cartesian
        {
            set => _Z_Value_Cartesian = value;
            get { return _Z_Value_Cartesian; }
        }
        //
        //  Cylindrical Values
        public Double R_Value_Cylindrical
        {
            set => _R_Value_Cylindrical = value;
            get { return _R_Value_Cylindrical; }
        }
        public Double Theta_Value_Cylindrical
        {
            set => _Theta_Value_Cylindrical = value;
            get { return _Theta_Value_Cylindrical; }
        }
        public Double Z_Value_Cylindrical
        {
            set => _Z_Value_Cylindrical = value;
            get { return _Z_Value_Cylindrical; }
        }
        //
        //  Spherical Values
        public Double R_Value_Spherical
        {
            set => _R_Value_Spherical = value;
            get { return _R_Value_Spherical; }
        }
       public Double Theta_Value_Spherical
        {
            set => _Theta_Value_Spherical = value;
            get { return _Theta_Value_Spherical; }
        }
        public Double Phi_Value
        {
            set => _Phi_Value = value;
            get { return _Phi_Value; }
        }
        //
        //  Complex Values
        public Double Real_Value
        {
            set => _Real_Value = value;
            get { return _Real_Value; }
        }
        public Double Complex_Value
        {
            set => _Complex_Value = value;
            get { return _Complex_Value; }
        }
        //
        //  Coordinate Systems
        //
        //  Current Coordinate System
        public CoordinateSystem CurrentCoordinateSystem
        {
            set => _CurrentCoordinateSystem = value;
            get { return _CurrentCoordinateSystem; }
        }
        //
        //  My Coordinate Systems
        public List<CoordinateSystem> MyCoordinateSystems
        {
            set => _MyCoordinateSystems = value;
            get { return _MyCoordinateSystems; }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************

        //
        //  **********************
        //  Convert to Cartesian Coordinates
        public Boolean CylindricalToCartesian(Double R, Double Theta_Radians)
        {
            try
            {
                if (this.MyType == PointTypeEnum.Cylindrical)
                {
                    this.X_Value = R * Math.Cos(Theta_Radians);
                    this.Y_Value = R * Math.Sin(Theta_Radians);
                    this._Z_Value_Cartesian = this._Z_Value_Cylindrical;
                }
                else
                {
                    return false;
                }
                    return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean SphericalToCartesian(Double R, Double Theta_Radians, Double Phi_Radians)
        {
            try
            {
                if (this.MyType == PointTypeEnum.Spherical)
                {
                    this.X_Value = R * Math.Cos(Theta_Radians) * Math.Sin(Phi_Radians);
                    this.Y_Value = R * Math.Sin(Theta_Radians) * Math.Sin(Phi_Radians);
                    this.Z_Value_Cartesian = R * Math.Sin(Phi_Radians);
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //
        //  **********************
        //  Convert to Cylindrical Coordinates
        public Boolean CartesianToCylindrical(Double X, Double Y)
        {
            try
            {
                if (this.MyType == PointTypeEnum.Cartesian)
                {
                    this.R_Value_Cylindrical = Math.Sqrt(X*X + Y*Y);
                    this.Theta_Value_Cylindrical =  Math.Atan(Y/X);
                    this._Z_Value_Cylindrical = this._Z_Value_Cartesian;
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean SphericalToCylindrical(Double R, Double Phi_Radians)
        {
            try
            {
                if (this.MyType == PointTypeEnum.Spherical)
                {
                    this.R_Value_Cylindrical = R * Math.Sin(Phi_Radians);
                    this.Z_Value_Cylindrical = R * Math.Cos(Phi_Radians);
                    this._Theta_Value_Cylindrical = this._Theta_Value_Spherical;
                    }
                else
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //
        //  **********************
        //  Convert to Spherical Coordinates
        public Boolean CartesianToSpherical(Double X, Double Y, Double Z)
        {
            try
            {
                if (this.MyType == PointTypeEnum.Cartesian)
                {
                    this.R_Value_Spherical = Math.Sqrt(X * X + Y * Y + Z*Z);
                    this.Phi_Value = Math.Atan(Math.Sqrt(X * X + Y * Y)/Z);
                    this._Theta_Value_Spherical = Math.Atan(Y / X);
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean CylindricalToSpherical(Double R, Double Z)
        {
            try
            {
                if (this.MyType == PointTypeEnum.Cylindrical)
                {
                    this.R_Value_Spherical = Math.Sqrt(R * R + Z * Z);
                    this.Phi_Value = Math.Atan(R / Z);
                    this._Theta_Value_Spherical = this.Theta_Value_Cylindrical;
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //
        //  **********************
        //  Convert Degrees to Radians
        public Double DegreesToRadians(Double AngleInDegrees)
        {
           return  AngleInDegrees * Math.PI / 180;
        }
        //
        //  **********************
        //  Convert Radians to Degrees 
        public Double RadiansToDegrees(Double AngleInRadians)
        {
            return AngleInRadians * 180/Math.PI;
        }
    }
    //  *************************************************************************************
}

