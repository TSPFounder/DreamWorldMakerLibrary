﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;
using PowerTransmission;

namespace Structure
{
    public class Brake : PowerTransmissionElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Version;
        //
        //  Data
        //
        //  Number of Teeth
        private Double NumberTeeth;
        //  Type
        //
        //  Dimensions
        private Double _Length;
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
        //  BRAKE CONSTRUCTOR
        //
        //  ************************************************************
        public Brake()
        {
            

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
            set { }
            get
            {
                return _Name;
            }
        }
        public String Version
        {
            set { }
            get
            {
                return _Version;
            }
        }
        //
        //  Data
        //
        //  Type

        //
        //  Dimensions
        public Double Length
        {
            set { }
            get
            {
                return _Length;
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
