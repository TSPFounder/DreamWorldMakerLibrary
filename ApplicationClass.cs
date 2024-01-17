﻿using System;
using System.Collections.Generic;
using Fluidics;
using Data;
using CAD;
using Controls;
using System.IO;
using Mathematics;
using SoftwareNamespace;

namespace SystemsEngineering
{
    public class ApplicationClass
    {
        //
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _AppName;
        protected String _Version;
        //
        //  Data
        //
        //  ExtensionTypes
        private String _CurrentExtensionType;
        private List<String> _MyExtensions;
        //
        //  Owned & Owning Objects
        //
        //  The API Object
        private List<ApplicationProgrammingInterface> _APIs;
        //
        //  The Software Object
        private SoftwareProgram _MySoftware;
        //
        //  App File Objects
        protected List<AppFile> _AppFiles;
        //
        //  Home Page
        protected String _HomePage;
        //  Booleans
        //
        //  Application Is Installed
        protected bool _IsInstalled;

        //protected List<Software.ApplicationNamespace> Namespaces;
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
        //  APPLICATIONCLASS CONSTRUCTOR
        //
        //  ************************************************************
        public ApplicationClass()
        {
            this.APIs = new List<ApplicationProgrammingInterface>();
            this.AppFiles = new List<AppFile>();
           
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
        public String AppName
        {
            set => _AppName = value;
            get
            {
                return _AppName;
            }
        }
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
        //  Data
        //
        //  ExtensionTypes
        public String CurrentExtensionType
        {
            set => _CurrentExtensionType = value;
            get { return _CurrentExtensionType; }
        }
        public List<String> MyExtensions
        {
            set => _MyExtensions = value;
            get { return _MyExtensions; }
        }
        //
        //  Owned & Owning Objects
        //
        //  The API Object
        public List<ApplicationProgrammingInterface> APIs
        {
            set => _APIs = value;
            get
            {
                return _APIs;
            }
        }
        //
        //  The Software Object
        public SoftwareProgram MySoftware
        {
            set => _MySoftware = value;
            get
            {
                return _MySoftware;
            }
        }
        //
        //  App File Objects
        public List<AppFile> AppFiles
        {
            set => _AppFiles = value;
            get
            {
                return _AppFiles;
            }
        }
        //
        //  Home Page
        public String HomePage
        {
            set => _HomePage = value;
            get
            {
                return _HomePage;
            }
        }
        //  Booleans
        //
        //  Application Is Installed
        public Boolean IsInstalled
        {
            set => _IsInstalled = value;
            get
            {
                return _IsInstalled;
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
