using System;
using System.Collections.Generic;
using CAD;
using SoftwareNamespace;

namespace SystemsEngineering
{
    public class ApplicationProgrammingInterface
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private ApplicationClass _MyApp;

        //
        //  Owned & Owning Objects
        private SoftwareClass _APIClass;
        private List<SoftwareClass> _APIClasses;

        //  API_Parameters
        //
        //  Programming Language
        protected SoftwareLanguage _Language;

        //  *****************************************************************************************


        //  *****************************************************************************************
        //  APPLICATIONPROGRAMMINGINTERFACE CONSTRUCTOR
        //
        //  ************************************************************
        public ApplicationProgrammingInterface()
        {

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        //
        //  Application
        public ApplicationClass MyApp
        {
            set { }
            get
            {
                return _MyApp;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  API Command
        public SoftwareClass APIClass
        {
            set { }
            get
            {
                return _APIClass;
            }
        }
        //
        //  Recent Commands
        public List<SoftwareClass> APIClasses
        {
            set { }
            get
            {
                return _APIClasses;
            }
        }
        //  API_Parameters
        //
        //  Programming Language
        public SoftwareLanguage Language
        {
            set { }
            get
            {
                return _Language;
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
