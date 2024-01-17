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
using SystemsEngineering;
using Controls;
using SystemsEngineering;

using CAD;

namespace Mathematics
{
    public class Matrix
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Name;
        private String _MatrixID;
        //
        //  Data
        private Int32 _X_Dimension = 0;
        private Int32 _Y_Dimension = 0;
        private Int32 _Z_Dimension = 0;
        private Double[,,] _Values;
        //
        //  Owned & Owning Objects
        private CoordinateSystem _MyCoordinateSystem;
        #endregion
        //  *****************************************************************************************


        //  ****************************************************************************************
        //  INITIALIZATIONS
        //
        //  ************************************************************
        #region
        //Double[,,] Values = new Double[ 0, 0, 0 ];
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
        //  MATRIX CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Matrix(Int32 X_Dim, Int32 Y_Dim, Int32 Z_Dim)
        {
            _X_Dimension = X_Dim;
            _Y_Dimension = Y_Dim;
            _Z_Dimension = Z_Dim;
            Double[,,] _Values = new Double[X_Dim, Y_Dim, Z_Dim];
            //Values[1, 1, 1] = 20;
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region
        public Boolean  CreateMatrix(Int32 X_Dimension, Int32 Y_Dimension, Int32 Z_Dimension, Double[,,] Vals)
        {
            try
            {

                _X_Dimension = X_Dimension;
                _Y_Dimension = Y_Dimension;
                _Z_Dimension = Z_Dimension;
                Double[,,] Values = Vals;
                return true;
            }

            catch
            {
                System.Windows.MessageBox.Show("Could Not Create the Matrix!");
                return false;
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
