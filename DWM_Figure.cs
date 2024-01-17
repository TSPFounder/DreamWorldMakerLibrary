using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using Microsoft.Office.Interop;

namespace Documents
{
    public class DWM_Figure
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _ID;
        //
        //  Definitions
        //
        //  Figure Type
        private FigureTypeEnum _FigureType;
        //
        //  Owned & Owning Objects
        private DWM_Image _MyImage;
        //
        //  Word Objects
        private Microsoft.Office.Interop.Word.Document _MyWordDoc;
        //
        //  Diagrams
        private DWM_Diagram _CurrentDiagram;
        private List<DWM_Diagram> _MyDigrams;
        //
        //  Tables
        private DWM_Table _CurrentTable;
        private List<DWM_Table> _MyTables;
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
        public enum FigureTypeEnum
        {
            Image = 0,
            Table,
            Diagram,
            Video,
            Two_D_Plot,
            Three_D_Plot,
            Three_D_Model,
            SmartArt,
            Spreadsheet,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  DWM_FIGURE CONSTRUCTOR
        //
        //  ************************************************************
        public DWM_Figure()
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
        //  Definitions
        //
        //  Figure Type
        public FigureTypeEnum FigureType
        {
            set => _FigureType = value;
            get
            {
                return _FigureType;
            }
        }
        //
        //  Owned & Owning Objects
        public DWM_Image MyImage
        { 
            set => _MyImage = value;
            get
            {
                return _MyImage;
            }
         }
        //
        //  Word Objects
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
        //
        //  Diagrams
        //
        //  Current Diagram
        public DWM_Diagram CurrentDiagram
        {
            set => _CurrentDiagram = value;
            get { return _CurrentDiagram; }
        }
        //
        //  My Diagrams
        public List<DWM_Diagram> MyDigrams
        {
            set => _MyDigrams = value;
            get { return _MyDigrams; }
        }
        //
        //  Tables
        //
        //  Current Table
        public DWM_Table CurrentTable
        {
            set => _CurrentTable = value;
            get { return _CurrentTable; }
        }
        //
        //  My Tables
        public List<DWM_Table> MyTables
        {
            set => _MyTables = value;
            get { return _MyTables; }
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
