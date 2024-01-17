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


namespace Mathematics
{
    public class Tetrahedron : Primitive
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _TetrahedronID;
        //
        //  Data
        //
        //  Geometry
        private Point _CenterPoint;
        private List<Point> _Points;
        private List<Surface> _Faces;
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
        //  TETRAHEDRON CONSTRUCTOR
        //
        //  ************************************************************
        #region

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        public String TetrahedronID
        {
            set => _TetrahedronID = value;
            get
            {
                return _TetrahedronID;
            }
        }
        //
        //  Data
        //
        //  Geometry
        public Point CenterPoint
        {
            set => _CenterPoint = value;
            get
            {
                return _CenterPoint;
            }
        }
        public List<Point> Points
        {
            set => _Points = value;
            get
            {
                return _Points;
            }
        }
        public List<Surface> Faces
        {
            set => _Faces = value;
            get
            {
                return _Faces;
            }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region
        //
        //  Get Geometry Data
        public Double CalculateSurfaceArea()
        {
            try
            {
                
                return 1;
            }

            catch
            {
                
                return 0;
            }
        }
        public void CreateFaces()
        {
            try
            {

               
            }

            catch
            {

                
            }
        }
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
