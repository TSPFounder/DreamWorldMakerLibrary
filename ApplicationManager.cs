using System.Windows;
using Microsoft.Win32;

using System;
using System.Collections.Generic;
using Microsoft.Office.Interop;
using CAD;
using Mathematics;
using UModelLib;
//using SldWorks;
using Simulation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Bson;
using MissionsNamespace;
using Project;
using DATCOM;

namespace SystemsEngineering
{
    public class ApplicationManager
    {


        //  **********************************************************************************
        // DECLARATIONS
        #region
        //
        //  ApplicationClass Objects
        private ApplicationClass _CurrentApp;
        private List<ApplicationClass> _ApplicationsAvailable = new List<ApplicationClass>();
        private List<ApplicationClass> _ApplicationsOpen = new List<ApplicationClass>();

        //
        //  MS Word Declarations
        private bool _WordInstalled = false;
        private WordApp _TheWordAppWrapper;
        private Microsoft.Office.Interop.Word._Application _ExistingWordApp;
        private Microsoft.Office.Interop.Word._Application _NewWordApp;
        private Microsoft.Office.Interop.Word._Application _CurrentWordApp;

        //
        //  MS Excel Declarations
        private bool _ExcelInstalled = false;
        private ExcelApp _TheExcelAppWrapper;
        private Microsoft.Office.Interop.Excel.AppEvents_Event excelEvents;
        private Microsoft.Office.Interop.Excel._Application _ExistingExcelApp;
        private Microsoft.Office.Interop.Excel.Application _NewExcelApp;
        private Microsoft.Office.Interop.Excel.Application _CurrentExcelApp;

        //
        //  MS Outlook Declarations
        private bool _OutlookInstalled = false;
        private OutlookApp _TheOutlookAppWrapper;
        private Microsoft.Office.Interop.Outlook._Application _ExistingOutlookApp;
        private Microsoft.Office.Interop.Outlook._Application _NewOutlookApp;
        private Microsoft.Office.Interop.Outlook._Application _CurrentOutlookApp;

        //
        //  MS Project Declarations
        private bool _MSProjectInstalled = false;
        private MSProjectApp _TheMSProjectAppWrapper;
        private Microsoft.Office.Interop.MSProject.Application _ExistingMSProjectApp;
        private Microsoft.Office.Interop.MSProject.Application _NewMSProjectApp;
        private Microsoft.Office.Interop.MSProject.Application _CurrentMSProjectApp;

        //
        //  MS Visio Declarations
        private bool _VisioInstalled = false;
        private VisioApp _TheVisioAppWrapper;
        private Microsoft.Office.Interop.Visio.Application _ExistingVisioApp;
        private Microsoft.Office.Interop.Visio.Application _NewVisioApp;
        private Microsoft.Office.Interop.Visio.Application _CurrentVisioApp;

        //
        //  MS PowerPoint Declarations
        private bool _PowerPointInstalled = false;
        private PowerPointApp _ThePowerPointAppWrapper;
        private Microsoft.Office.Interop.PowerPoint._Application _ExistingPowerPointApp;
        private Microsoft.Office.Interop.PowerPoint._Application _NewPowerPointApp;
        private Microsoft.Office.Interop.PowerPoint._Application _CurrentPowerPointApp;

        //
        //  Matlab Declarations
        private bool _MatlabInstalled = false;
        private MatlabApp _TheMatlabAppWrapper;
        private MLApp.MLApp _ExistingMatlabApp;
        private MLApp.MLApp _NewMatlabApp;
        private MLApp.MLApp _CurrentMatlabApp;

        //
        //  SolidWorks Declarations
        private bool _SolidWorksInstalled = false;
        //private SolidWorksApp _TheSolidWorksAppWrapper;
        //private SldWorks.SldWorks _ExistingSolidWorksApp;
        //private SldWorks.SldWorks _NewSolidWorksApp;
        //private SldWorks.SldWorks _CurrentSolidWorksApp;


        //
        //  UModel Declarations
        private bool _UModelInstalled = false;
        private UModelApp _TheUModelAppWrapper;
        private UModelLib.Application _ExistingUModelApp;
        private UModelLib.Application _NewUModelApp;
        private UModelLib.Application _CurrentUModelApp;
        private UModelLib.Document _CurrentUModelDoc;

        //
        //  UnrealEngine Declarations
        private bool _UnrealEngineInstalled = false;
        private UnrealEngineApp _TheUnrealEngineAppWrapper;

        //
        //  GOTS Apps
        private DATCOM_Manager _DATCOM_Mgr;

        //
        //  Non-API Apps
        private UnrealEngine_Manager _UE_Mgr;
        private Solidworks_Manager _Solidworks_Mgr;
        private Fusion360_Manager _Fusion360_Mgr;

        //
        //  CAD Apps
        private CAD_App _ActiveCAD_App;
        //
        //  Managers
        //
        //  System Manager
        private DWM_SystemManager _TheSystemManager;
        //
        //  Project Manager
        private DWM_ProjectManager _TheProjectManager;
        //
        //  CAD Manager
        private CAD_Manager _TheCAD_Manager;
        //
        //  Requirement Manager
        private DWM_RequirementsManager _TheRequirementManager;
        //
        //  File Manager
        private DWM_FileManager _TheFileManager;
        //
        //  Controls
        //

        #endregion
        //  **********************************************************************************


        //  **********************************************************************************
        // ENUMERATIONS
        #region
        //
        //  *****************************
        //  APPLICATION NAME ENUMERATION
        enum AppName
        {
            MicrosoftWord = 0,
            MicrosoftExcel,
            MicrosoftOutlook,
            MicrosoftPowerPoint,
            MicrosoftOneNote,
            MicrosoftProject,
            MicrosoftVisio,
            Fusion360,
            SolidWorks,
            Matlab,
            FEMAP,
            Eagle,
            UModel,
            Other
        }
        #endregion
        //  **********************************************************************************


        //  **********************************************************************************
        // APPLICATION MANAGER CONSTRUCTOR
        #region
        //
        public ApplicationManager()
        {


            //  *******************************************************
            //  GET THE SYSTEM MANAGER
            this.TheSystemManager = new DWM_SystemManager();
            //  **************************************************************

            //  *******************************************************
            //  GET THE FILE MANAGER
            this.TheFileManager = new DWM_FileManager();
            //  **************************************************************

            //  *******************************************************
            //  GET THE PROJECT MANAGER
            this.TheProjectManager = new DWM_ProjectManager();
            //  **************************************************************

            //  *******************************************************
            //  GET REGISTRY KEYS AND WRAPPERS
            #region
            //
            //  Create ClassesRoot Object
            RegistryKey regClasses;
            regClasses = Registry.ClassesRoot;

            //  Create CurrentConfig Object
            RegistryKey regConfig;
            regConfig = Registry.CurrentConfig;
            //  *******************************************************


            //  **************************************************************
            //  WORD APPLICATION SETUP - APPLICATION MANAGER CONSTRUCTOR
            //
            //  *******************************************************
            #region
            //  Create Microsoft WORD Registry Key & Check If Installed
            RegistryKey regWordKey;
            regWordKey = regClasses.OpenSubKey("Word.Application");

            if (regWordKey == null)
            {
                //throw new ArgumentNullException();

            }
            else
            {
                //bool _WordInstalled = true;
                this.WordInstalled = true;
                this.TheWordAppWrapper = new WordApp();
                this._ApplicationsAvailable.Add(this.TheWordAppWrapper);
            }
            #endregion
            //  *******************************************************


            //  **************************************************************
            //  EXCEL APPLICATION SETUP - APPLICATION MANAGER CONSTRUCTOR
            //
            //  *******************************************************
            #region
            //  Create Microsoft Excel Registry Key & Check If Installed
            RegistryKey regExcelKey;
            regExcelKey = regClasses.OpenSubKey("Excel.Application");

            if (regExcelKey == null)
            {
                //throw new ArgumentNullException();

            }
            else
            {
                this.ExcelInstalled = true;
                this.TheExcelAppWrapper = new ExcelApp();
                this._ApplicationsAvailable.Add(this.TheExcelAppWrapper);
            }
            #endregion
            //  *******************************************************



            //  **************************************************************
            //  OUTLOOK APPLICATION SETUP - APPLICATION MANAGER CONSTRUCTOR
            //
            //  *******************************************************
            #region
            //  Create Microsoft Outlook Registry Key & Check If Installed
            RegistryKey regOutlookKey;
            regOutlookKey = regClasses.OpenSubKey("Outlook.Application");

            if (regOutlookKey == null)
            {
                //throw new ArgumentNullException();

            }
            else
            {
                this.OutlookInstalled = true;
                this.TheOutlookAppWrapper = new OutlookApp();
                this._ApplicationsAvailable.Add(this.TheOutlookAppWrapper);
            }
            #endregion
            //  *******************************************************



            //  **************************************************************
            //  MSPROJECT APPLICATION SETUP - APPLICATION MANAGER CONSTRUCTOR
            //
            //  *******************************************************
            #region
            //  Create Microsoft Project Registry Key & Check If Installed
            RegistryKey regMSProjectKey;
            regMSProjectKey = regClasses.OpenSubKey("MSProject.Application");

            if (regMSProjectKey == null)
            {
                //throw new ArgumentNullException();

            }
            else
            {
                this.MSProjectInstalled = true;
                this.TheMSProjectAppWrapper = new MSProjectApp();
                this._ApplicationsAvailable.Add(this.TheMSProjectAppWrapper);
            }
            #endregion
            //  *******************************************************


            //  **************************************************************
            //  VISIO APPLICATION SETUP - APPLICATION MANAGER CONSTRUCTOR
            //
            //  *******************************************************
            #region
            //  Create Microsoft Visio Registry Key & Check If Installed
            RegistryKey regVisioKey;
            regVisioKey = regClasses.OpenSubKey("Visio.Application");

            if (regVisioKey == null)
            {
                //throw new ArgumentNullException();

            }
            else
            {
                this.VisioInstalled = true;
                this.TheVisioAppWrapper = new VisioApp();
                this._ApplicationsAvailable.Add(this.TheVisioAppWrapper);
            }
            #endregion
            //  *******************************************************


            //  **************************************************************
            //  POWERPOINT APPLICATION SETUP - APPLICATION MANAGER CONSTRUCTOR
            //
            //  *******************************************************
            #region
            //  Create PowerPoint Registry Key & Check If Installed
            RegistryKey regPowerPointKey;
            regPowerPointKey = regClasses.OpenSubKey("PowerPoint.Application");

            if (regPowerPointKey == null)
            {
                //throw new ArgumentNullException();

            }
            else
            {
                this.PowerPointInstalled = true;
                this.ThePowerPointAppWrapper = new PowerPointApp();
                this._ApplicationsAvailable.Add(this.ThePowerPointAppWrapper);
            }
            #endregion
            //  *******************************************************


            //  **************************************************************
            //  MATLAB APPLICATION SETUP - APPLICATION MANAGER CONSTRUCTOR
            //
            //  **********************************************************
            #region
            //  Create Microsoft MATLAB Registry Key & Check If Installed
            RegistryKey regMatlabKey;
            regMatlabKey = regClasses.OpenSubKey("Matlab.Application");

            if (regMatlabKey == null)
            {
                //throw new ArgumentNullException();
            }
            else
            {
                this.MatlabInstalled = true;
                this.TheMatlabAppWrapper = new MatlabApp(this);
                this._ApplicationsAvailable.Add(this.TheMatlabAppWrapper);

            }
            #endregion
            //  *********************************************************


            //  **************************************************************
            //  SOLIDWORKS APPLICATION SETUP - APPLICATION MANAGER CONSTRUCTOR
            //
            //  **********************************************************
            #region
            //  Create Microsoft MATLAB Registry Key & Check If Installed
            RegistryKey regSolidWorksKey;
            //regSolidWorksKey = regClasses.OpenSubKey("SldWorks.Application");

            //if (regSolidWorksKey == null)
            //{
            //throw new ArgumentNullException();
            //}
            //else
            //{
            //this.SolidWorksInstalled = true;
            //this.TheSolidWorksAppWrapper = new SolidWorksApp();
            //this._ApplicationsAvailable.Add(this.TheSolidWorksAppWrapper);

            //}
            //  *********************************************************
            //  Get and map the SOLIDWORKS App object
            #endregion
            //  **************************************************************




            //  **************************************************************
            //  UMODEL APPLICATION SETUP - APPLICATION MANAGER CONSTRUCTOR
            //
            //  **********************************************************
            #region
            //  Create Microsoft UMODEL Registry Key & Check If Installed
            RegistryKey regUModelKey;
            regUModelKey = regClasses.OpenSubKey("UModel_x64.Application");

            if (regUModelKey == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                this._UModelInstalled = true;
                this._TheUModelAppWrapper = new UModelApp();
                this._ApplicationsAvailable.Add(this._TheUModelAppWrapper);
            }
            #endregion
            //  *********************************************************            
            #endregion
            //  **************************************************************



            this._DATCOM_Mgr = new DATCOM_Manager();

            //
            //  Assign the Application Manager to the GOTS Managers

            this._DATCOM_Mgr.TheApplicationManager = this;

            #endregion
            //  **************************************************************

            //  **************************************************************
            //  NON-API APPLICATION MANAGER CREATION & ASSIGNMENT
            //
            //  **********************************************************
            #region
            //
            //  Create the Application Managers
            this.TheCAD_Manager = new CAD_Manager();
            this._UE_Mgr = new UnrealEngine_Manager();
            this._Solidworks_Mgr = new Solidworks_Manager();
            this._Fusion360_Mgr = new Fusion360_Manager();
            //
            //  Assign the Application Manager to the Non-API Application Managers
            this._UE_Mgr.TheApplicationManager = this;
            this._Solidworks_Mgr.TheApplicationManager = this;
            this._Fusion360_Mgr.TheApplicationManager = this;
        
        #endregion
    }
            //  **************************************************************
           
            //  **********************************************************************************
        //  PROPERTIES
        //
        #region
         //  ************************************************************

        //  ************************************************************
        //
        //  Managers
        //
        //  System Manager
       public DWM_SystemManager TheSystemManager
        {
            set => _TheSystemManager = value;
            get { return _TheSystemManager; }

        }
        //
        //  File Manager
        public DWM_FileManager TheFileManager
        {
            set => _TheFileManager = value;
            get { return _TheFileManager; }
        }
        //
        //  Requirements Manager
        public DWM_RequirementsManager TheRequirementManager
        {
            set => _TheRequirementManager = value;
            get { return _TheRequirementManager; }
        }
        //
        //  Project Manager
        public DWM_ProjectManager TheProjectManager
        {
            set => _TheProjectManager = value;
            get { return _TheProjectManager; }
        }
        //
        // CAD Manager
        public CAD_Manager TheCAD_Manager
        {
            set => _TheCAD_Manager = value;
            get { return _TheCAD_Manager; }

        }
        //  ************************************************************

        //  ************************************************************
        //  APPLICATONCLASS PROPERTIES
        //  
        //  Current App
        public ApplicationClass CurrentApp
        {
            set => _CurrentApp = value;
            get { return _CurrentApp; }
        }
        //
        //  Applications Available        
        public List<ApplicationClass> ApplicationsAvailable
        {
            set => _ApplicationsAvailable = value;
            get { return _ApplicationsAvailable; }
        }
        //  
        //  Open Applications
        public List<ApplicationClass> ApplicationsOpen
        {
            set => _ApplicationsOpen = value;
            get { return _ApplicationsOpen; }
        }

        //  ************************************************************
        //  WORD INSTALLED PROPERTY
        public bool WordInstalled
        {
            private set
            {
                _WordInstalled = value;
            }
            get
            {
                return _WordInstalled;
            }
        }
        //  ************************************************************


        //  ************************************************************
        //  WORD APP WRAPPER PROPERTY
        public WordApp TheWordAppWrapper
        {
            set
            {
                _TheWordAppWrapper = value;
            }
            get
            {
                return _TheWordAppWrapper;
            }
        }
        //  ***********************************************************


        //  ************************************************************
        //  CURRENT WORD APP
        //public Microsoft.Office.Interop.Word._Application CurrentWordApp
        //{
            //set => _CurrentWordApp = value;
            //get { return _CurrentWordApp; }
        //}
        //  ***********************************************************


        //  ************************************************************
        //  EXCEL INSTALLED PROPERTY
        public bool ExcelInstalled
        {
            private set
            {
                _ExcelInstalled = value;
            }
            get
            {
                return _ExcelInstalled;
            }
        }
        //  ************************************************************


        //  ************************************************************
        //  EXCEL APP WRAPPER PROPERTY
        public ExcelApp TheExcelAppWrapper
        {
            set
            {
                _TheExcelAppWrapper = value;
            }
            get
            {
                return _TheExcelAppWrapper;
            }
        }
        //  ***********************************************************


        //  ************************************************************
        //  CURRENT EXCEL APP
        //public Microsoft.Office.Interop.Excel._Application CurrentExcelApp
        //{
            //set => _CurrentExcelApp = value;
            //get { return _CurrentExcelApp; }
        //}
        //  ***********************************************************


        //  ************************************************************
        //  OUTLOOK INSTALLED PROPERTY
        public bool OutlookInstalled
        {
            private set
            {
                _OutlookInstalled = value;
            }
            get
            {
                return _OutlookInstalled;
            }
        }
        //  ************************************************************


        //  ************************************************************
        //  OUTLOOK APP WRAPPER PROPERTY
        public OutlookApp TheOutlookAppWrapper
        {
            set
            {
                _TheOutlookAppWrapper = value;
            }
            get
            {
                return _TheOutlookAppWrapper;
            }
        }
        //  ***********************************************************


        //  ************************************************************
        //  CURRENT OUTLOOK APP
        //public Microsoft.Office.Interop.Outlook._Application CurrentOutlookApp
        //{
            //set => _CurrentOutlookApp = value;
            //get { return _CurrentOutlookApp; }
        //}
        //  ***********************************************************

        //  ************************************************************
        //  POWERPOINT INSTALLED PROPERTY
        public bool PowerPointInstalled
        {
            private set
            {
                _PowerPointInstalled = value;
            }
            get
            {
                return _PowerPointInstalled;
            }
        }
        //  ************************************************************


        //  ************************************************************
        //  POWERPOINT APP WRAPPER PROPERTY
        public PowerPointApp ThePowerPointAppWrapper
        {
            set
            {
                _ThePowerPointAppWrapper = value;
            }
            get
            {
                return _ThePowerPointAppWrapper;
            }
        }
        //  ************************************************************


        //  ************************************************************
        //  CURRENT POWERPOINT APP
        //public Microsoft.Office.Interop.PowerPoint._Application CurrentPowerPointApp
        //{
            //set => _CurrentPowerPointApp = value;
            //get { return _CurrentPowerPointApp; }
        //}
        //  ***********************************************************

        //  ************************************************************
        //  MICROSOFT PROJECT INSTALLED PROPERTY
        public bool MSProjectInstalled
        {
            private set
            {
                _MSProjectInstalled = value;
            }
            get
            {
                return _MSProjectInstalled;
            }
        }
        //  ************************************************************


        //  ************************************************************
        //  MICROSOFT PROJECT APP WRAPPER PROPERTY
        public MSProjectApp TheMSProjectAppWrapper
        {
            set
            {
                _TheMSProjectAppWrapper = value;
            }
            get
            {
                return _TheMSProjectAppWrapper;
            }
        }
        //  ************************************************************


        //  ************************************************************
        //  VISIO INSTALLED PROPERTY
        public bool VisioInstalled
        {
            private set
            {
                _VisioInstalled = value;
            }
            get
            {
                return _VisioInstalled;
            }
        }
        //  ************************************************************


        //  ************************************************************
        //  VISIO APP WRAPPER PROPERTY
        public VisioApp TheVisioAppWrapper
        {
            set
            {
                _TheVisioAppWrapper = value;
            }
            get
            {
                return _TheVisioAppWrapper;
            }
        }
        //  ***********************************************************


        //  ************************************************************
        //  MATLAB INSTALLED PROPERTY
        public bool MatlabInstalled
        {
            private set
            {
                _MatlabInstalled = value;
            }
            get
            {
                return _MatlabInstalled;
            }
        }
        //  ************************************************************


        //  ************************************************************
        //  MATLAB APP WRAPPER PROPERTY
        public MatlabApp TheMatlabAppWrapper
        {
            set
            {
                _TheMatlabAppWrapper = value;
            }
            get
            {
                return _TheMatlabAppWrapper;
            }
        }
        //  ***********************************************************

        //  ************************************************************
        //  SOLIDWORKS INSTALLED PROPERTY
        public bool SolidWorksInstalled
        {
            private set
            {
                _SolidWorksInstalled = value;
            }
            get
            {
                return _SolidWorksInstalled;
            }
        }
        //  ************************************************************

        //  ************************************************************
        //  SOLIDWORKS APP WRAPPER PROPERTY
       // public SolidWorksApp TheSolidWorksAppWrapper
       // {
         //   set
         //   {
          //      _TheSolidWorksAppWrapper = value;
            //}
          //  get
           // {
          //      return _TheSolidWorksAppWrapper;
         //   }
        //}
        //  ***********************************************************

    
        //  ************************************************************
        //  UMODEL INSTALLED PROPERTY
        public bool UModelInstalled
        {
            private set
            {
                _UModelInstalled = value;
            }
            get
            {
                return _UModelInstalled;
            }
        }
        //  ************************************************************


        //  ************************************************************
        //  UModel APP WRAPPER PROPERTY
        public UModelApp TheUModel_AppWrapper
        {
            set
            {
                _TheUModelAppWrapper = value;
            }
            get
            {
                return _TheUModelAppWrapper;
            }
        }
        //  ************************************************************

        //  ************************************************************
        //
        public UModelLib.Document CurrentUModelDoc
        {
            set => _CurrentUModelDoc = value;
            get { return _CurrentUModelDoc; }
        }

        //  ************************************************************
        //  GOTS APPS
        //
        //  DATCOM
        public DATCOM_Manager DATCOM_Mgr
        {
            set
            {
                _DATCOM_Mgr = value;
            }
            get
            {
                return _DATCOM_Mgr;
            }
        }
       //  ************************************************************
        //
        //  ************************************************************
        //  NON-API APPS
        
        //
        //  UNREAL ENGINE
        public UnrealEngine_Manager UE_Mgr
        {
            set => _UE_Mgr = value;
            get { return _UE_Mgr; }

        }
        //
        //  SOLIDWORKS
        public Solidworks_Manager Solidworks_Mgr
        {
            set => _Solidworks_Mgr = value;
            get { return _Solidworks_Mgr; }

        }
        //
        //  FUSION 360
        public Fusion360_Manager Fusion360_Mgr
        {
            set => _Fusion360_Mgr = value;
            get { return _Fusion360_Mgr; }

        }
      
        //  ************************************************************
        //
        #endregion
        //
        //  **********************************************************************************


        //  **********************************************************************************
        //  METHODS
        #region

        private void InitializeMyControl()
        {
            // Set to no text.
            //textBox1.Text = "";
            // The password character is an asterisk.
            //textBox1.PasswordChar = '*';
            // The control will allow no more than 14 characters.
           // textBox1.MaxLength = 14;
        }

        //
        //  ************************************************************
        //
        //  APPLICATION CREATION FUNCTIONS
        #region        


        //  ************************************************************
        //  CREATE A WORD APPLICATION AND MAKE IT CURRENT
        #region
        public bool CreateWordApp()
        {
            try
            {
                this._CurrentWordApp = new Microsoft.Office.Interop.Word.Application();
                this.TheWordAppWrapper.TheWordApp = _CurrentWordApp;
                _CurrentWordApp.Visible = true;
                

                //  Map the Word Quit Events to the object events
                Microsoft.Office.Interop.Word.ApplicationEvents4_Event ExistingWordClosingEvent = (Microsoft.Office.Interop.Word.ApplicationEvents4_Event)this._CurrentWordApp;

                return true;
            }

            catch
            {
               
                return false;
            }
        }
        #endregion
        //  ************************************************************


        //  ************************************************************
        //  CREATE AN EXCEL APPLICATION AND MAKE IT CURRENT
        #region
        public bool CreateExcelApp()
        {
            try
            {
                this._CurrentExcelApp = new Microsoft.Office.Interop.Excel.Application();


                //  Map the Excel Quit Events to the object events
                Microsoft.Office.Interop.Excel.AppEvents_Event excelEvents;
                excelEvents = (Microsoft.Office.Interop.Excel.AppEvents_Event)this._CurrentExcelApp;
                Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeCloseEventHandler EventDel_BeforeBookClose;
                EventDel_BeforeBookClose = new Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeCloseEventHandler(BeforeBookClose);
                excelEvents.WorkbookBeforeClose += EventDel_BeforeBookClose;


                //  Map the existing Excel App to the Wrapper
                this.TheExcelAppWrapper.TheExcelApp = _CurrentExcelApp;

                return true;
            }

            catch
            {

               return false;
            }
        }
        #endregion
        //  ************************************************************


        //
        //  ************************************************************
        //  CREATE AN OUTLOOK APPLICATION AND MAKE IT CURRENT
        #region
        public bool CreateOutlookApp()
        {
            try
            {
                //  *******************************************************
                //  Create the OUTLOOK App object & Map to DWM Objects
                this._CurrentOutlookApp = new Microsoft.Office.Interop.Outlook.Application();

                //
                //  The Quit Outlook Event
                void Event_ApplicationQuit()
                {
                    _CurrentOutlookApp.Quit();
                }
                //
                //  Map the existing Outlook App to the Wrapper
                this.TheOutlookAppWrapper.TheOutlookApp = _CurrentOutlookApp;
               
                return true;
            }

            catch
            {

               return false;
            }
        }
        #endregion
        //  ************************************************************


        //  ************************************************************
        //  CREATE A MSPROJECT APPLICATION AND MAKE IT CURRENT
        #region
        public bool CreateMSProjectApp()
        {
            try
            {
                this._CurrentMSProjectApp = new Microsoft.Office.Interop.MSProject.Application();
                
                this.TheMSProjectAppWrapper.TheMSProjectApp = _CurrentMSProjectApp;
                _CurrentMSProjectApp.Visible = true;
                return true;
            }

            catch
            {
                 return false;
            }
        }
        #endregion
        //  ************************************************************


        //  ************************************************************
        //  CREATE A VISIO APPLICATION AND MAKE IT CURRENT
        #region
        public bool CreateVisioApp() {            

            try
            {
                this._CurrentVisioApp = new Microsoft.Office.Interop.Visio.Application();
                this._CurrentVisioApp.Visible = true;

                //  Map the Visio Quit Events to the object events
                Microsoft.Office.Interop.Visio.Event ExistingWordClosingEvent = (Microsoft.Office.Interop.Visio.Event)this._ExistingVisioApp;
                
                return true;
            }

            catch (System.Exception ex)
            {
                return false;
            }



            //  Map the existing Word App to the Wrapper
            this.TheVisioAppWrapper.TheVisioApp = _CurrentVisioApp;
            #endregion
        }
        //  **************************************************************


        //  ************************************************************
        //  CREATE A POWERPOINT APPLICATION AND MAKE IT CURRENT
        #region
        public bool CreatePowerPointApp()
        {
            try
            {
                Microsoft.Office.Interop.PowerPoint.Application _CurrentPowerPointApp = new Microsoft.Office.Interop.PowerPoint.Application();
                
                this.ThePowerPointAppWrapper.ThePowerPointApp = this._CurrentPowerPointApp;
                return true;
            }

            catch
            {
               return false;
            }
        }
        #endregion
        //  **************************************************************


        //  ************************************************************
        //  CREATE A MATLAB APPLICATION AND MAKE IT CURRENT
        #region
        public bool CreateMatlabApp()
        {
            try
            {
                this._CurrentMatlabApp = new MLApp.MLApp();

                //  Map the existing Matlab App to the Wrapper
                this.TheMatlabAppWrapper.TheMatlabApp = this._CurrentMatlabApp;
                this._CurrentMatlabApp.Visible = 1;
                return true;
               
            }

            catch
            {
               return false;
            }
        }
        #endregion
        //  **************************************************************

        //  ************************************************************
        //  CREATE A UMODEL DOCUMENT AND MAKE IT CURRENT
        #region
        public bool CreateUModelApp()
        {
            try
            {
                this._CurrentUModelApp = new UModelLib.Application();
                this._CurrentUModelApp.Visible = true;
                return true;
            }

            catch
            {
                return false;
            }
        }
        #endregion
        //  **************************************************************
        #endregion
        //
        //  **************************************************************
        #endregion
        //  **********************************************************************************


        //  **********************************************************************************
        //  EVENTS
        #region
        //  **********************************************************************************
        //  EXISTING WORD APPLICATION CLOSING 
        //
        void ExistingWordApp_Quit()
        {
           
            
        }
        //  ************************************************************

        //  ************************************************************
        // CURRENT WORD APPLICATION CLOSING 
        private void CurrentWordApp_Quit(object sender, EventArgs e)
        {
           
        }
        //  ************************************************************

        //  ************************************************************
        //  Current EXCEL Workbook Closing
        static void BeforeBookClose(Microsoft.Office.Interop.Excel._Workbook Wb, ref bool Cancel)
        {
           
        }
        #endregion
        //  **********************************************************************************
    }
}

