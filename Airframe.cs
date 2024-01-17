using DATCOM;
using SystemsEngineering;
using System;
using System.Collections.Generic;
using Propulsion;
using CAD;
using MissionsNamespace;
using Power;
using AircraftObjects;

namespace Structure
{
    public class Airframe :StructureSubsystem
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        //
        //  Data
        //
        //  Dimensions
        private CAD_Dimension _Length;
        private CAD_Dimension _Height;
        //
        //  Parameters
        private CAD_Parameter _Weight;
        //
        //  Owned & Owning Objects
        //
        //  Structural Objects
        // 
        //  Structural Subsystems
        private StructureSubsystem _CurrentFrame;
        private List<StructureSubsystem> _MyFrames;
        //
        //  CAD Objects
        private CAD_Component _CurrentComponent;

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
        //  AIRFRAME CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Airframe()
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
        //  Data
        //
        //  Length
        public CAD_Dimension Length
        {
            set => _Length = value;
            get
            {
                return _Length;
            }
        }
        //
        //  Height
        public CAD_Dimension Height
        {
            set => _Height = value;
            get
            {
                return _Height;
            }
        }
        //
        //  Parameters
        //
        //  Weights
        public CAD_Parameter Weight
        {
            set => _Weight = value;
            get
            {
                return _Weight;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Structural Objects
        // 
        //  Structural Subsystems
        //
        //   Current Frame
        public StructureSubsystem CurrentFrame
        {
            set => _CurrentFrame = value;
            get
            {
                return _CurrentFrame;
            }
        }
        //
        //  My Frames
        public List<StructureSubsystem> MyFrames
        {
            set => _MyFrames = value;
            get
            {
                return _MyFrames;
            }
        }
        //
        //  CAD Objects
        public CAD_Component CurrentComponent
        {
            set => _CurrentComponent = value;
            get
            {
                return _CurrentComponent;
            }
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
