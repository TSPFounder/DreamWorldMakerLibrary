using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OfficeApps;
using SystemsEngineering;

namespace Documents
{
    public class EngineeringNotebook : DWM_Document
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
        //  Enumerations
        private NotebookTypeEnum _MyNotebookType;
        //
        //  Owned & Owning Objects
        //
        //  Matlab LiveScript
        private MatlabFile _MyLiveScript;
        //
        //  Word Document
        private Microsoft.Office.Interop.Word.Document _MyWordDoc;
        //
        //  HTML Document
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
        public enum NotebookTypeEnum
        {
            LiveScript = 0,
            Word,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ENGINEERINGNOTEBOOK CONSTRUCTOR
        //
        //  ************************************************************
        public EngineeringNotebook()
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
        //  Enumerations
         public NotebookTypeEnum MyNotebookType
        {
            set => _MyNotebookType = value;
            get
            {
                return _MyNotebookType;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Matlab LiveScript
        public MatlabFile MyLiveScript
        {
            set => _MyLiveScript = value;
            get
            {
                return _MyLiveScript;
            }
        }
        //
        //  Word Document
        public Microsoft.Office.Interop.Word.Document MyWordDoc
        {
            set => _MyWordDoc = value;
            get
            {
                return _MyWordDoc;
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
