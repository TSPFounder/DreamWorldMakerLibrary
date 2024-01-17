using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using CAD;
//using DATCOM;

using Documents;

namespace SystemsEngineering
{
    public class DWM_Analysis : DWM_Verification
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _ID;
        private String _Version;
        //
        //  Data
        //
        //  Analysis Tool
        private AnalysisToolEnum _MyTool;
        //
        //  Is Discrete
        private Boolean _IsDiscrete;
        //  
        //  Owned & Owning Objects
        //
        //  Documents
        //
        //  My Analysis Plan
        private DWM_Document _MyAnalysisPlan;
        //
        //  My Analysis Report
        private DWM_Document _MyAnalysisReport;
        //
        //  Models
        private CAD_Model _CurrentCAD_Model;
        //
        //  LiveScripts
        private EngineeringNotebook _CurrentLiveScript;
        private List<EngineeringNotebook> _MyLiveScripts;
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
        //
        //  Analysis Tool Enumeration
        public enum AnalysisToolEnum
        {
            DATCOM = 0,         
           LiveScript,
           Other
        }
        //
        //  Analysis Type
        public enum AnalysisType
        {
            Structural = 0,
            Thermal,
            Fluids,
            Magnetic,
            RF,
            MotionStudy,
            Optical,
            Chemical,
            Performance,
            GDT,
            Electronic,
            SixDoF,
            Spectral,
            Other
        }
        //
        //  Methodology
        public enum AnalysisMethodology
        {
            FEA3D=0,
            FEA2D,
            BulkProperties,
            Statistical,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ANALYSIS CONSTRUCTOR
        //
        //  ************************************************************
        public DWM_Analysis()
        {
            //  Verification Type
            this.MyVerificationType = VerificationType.Analysis;
            //  Create Model Lists
            
            this.CAD_Models = new List<CAD_Model>();
            
            //this.DATCOM_Models = new List<DATCOM_Model>();
            
            this.MyLiveScripts = new List<EngineeringNotebook>();
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
        public String Name
        {
            set => _Name = value;
            get
            {
                return _Name;
            }
        }
        //
        //  ID
        public String ID
        {
            set => _ID = value;
            get
            {
                return _ID;
            }
        }
        //
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
        //  Analysis Tool
        public AnalysisToolEnum MyTool
        {
            set => _MyTool = value;
            get
            {
                return _MyTool;
            }
        }
        //
        //  Is Discrete
        public Boolean IsDiscrete
        {
            set => _IsDiscrete = value;
            get
            {
                return _IsDiscrete;
            }
        }
        //  
        //  Owned & Owning Objects
        //
        //  Documents
        //
        //  My Analysis Plan
        public DWM_Document MyAnalysisPlan
        {
            set => _MyAnalysisPlan = value;
            get
            {
                return _MyAnalysisPlan;
            }
        }
        //
        //  My Analysis Report
        public DWM_Document MyAnalysisReport
        {
            set => _MyAnalysisReport = value;
            get
            {
                return _MyAnalysisReport;
            }
        }
        
        //
        //  CAD_Models
        public CAD_Model CurrentCAD_Model
        {
            set => _CurrentCAD_Model = value;
            get
            {
                return _CurrentCAD_Model;
            }
        }
        public List<CAD_Model> CAD_Models
        {
            set => _CAD_Models = value;
            get
            {
                return _CAD_Models;
            }
        }
        
        //
        //  LiveScripts
        public EngineeringNotebook CurrentLiveScript
        {
            set => _CurrentLiveScript = value;
            get
            {
                return _CurrentLiveScript;
            }
        }
        public List<EngineeringNotebook> MyLiveScripts
        {
            set => _MyLiveScripts = value;
            get
            {
                return _MyLiveScripts;
            }
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

