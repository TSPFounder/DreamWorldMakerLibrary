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
using MissionsNamespace;
using SystemsEngineering;

namespace Automotive
{
    public class Automobile : SystemOfSystems
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _Make;
        private String _Model;
        private Int32 _ModelYear;
        private String _Description;
        private ColorEnum _Color;
        //
        //  Data
        private String _LicenseNumber;
        //
        //  Owned & Owning Objects
       
        //
        //  Managers
        private ApplicationManager _MyAppMgr;
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
        public enum ColorEnum
        {
            Red = 0,
            Black,
            White,
            Tan,
            Green,
            Yellow, 
            Silver,
            Gold,
            Purple,
            Pink
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  AUTOMOBILE CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public Automobile()
        {
            
            //
            //  CAD Objects

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
    //  Make
    public String Make
        {
            set => _Make = value;
            get
            {
                return _Make;
            }
        }
        //
        //  Model
        public String Model
        {
            set => _Model = value;
            get
            {
                return _Model;
            }
        }
        //
        //  Description
        public String Description
        {
            set => _Description = value;
            get
            {
                return _Description;
            }
        }
        //
        //  Model Year
        public Int32 ModelYear
        {
            set => _ModelYear = value;
            get
            {
                return _ModelYear;
            }
        }
        //
        //  Color
        public ColorEnum Color
        {
            set => _Color = value;
            get
            {
                return _Color;
            }
        }
        //
        //  Data
        //
        //  Description
        public String LicenseNumber
        {
            set => _LicenseNumber = value;
            get
            {
                return _LicenseNumber;
            }
        }
    //
    //  Owned & Owning Objects
    //
    //  Controls
    //
    //  Managers
    public ApplicationManager MyAppMgr
    {
        set => _MyAppMgr = value;
        get { return _MyAppMgr; }
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
