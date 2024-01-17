using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using SystemsEngineering;

namespace Documents
{
    public class DWM_Table
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
        //  Read Directions
        private Boolean _VerticalReadDirectionDown;
        private Boolean _HorizontalReadDirectonRtL;
        // 
        //  Table Type
        private TableType _MyTableType;
        //
        //  Figure Numbers
        private int _CurrentFigureNumber;
        private List<int> _FigureNumbers;
        //
        //  Data
        private Int64 _NumRows;
        private Int64 _NumColumns;
        private Boolean _HasHeader;
        //
        //  Owned & Owning Objects
        private List<DWM_TableRow> _MyRows;
        private List<DWM_TableColumn> _MyColumns;
        //
        //  Table Type
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
        public enum TableType
        {
            Database=0,
            Excel,
            SharePoint,
            Design,
            BoM,
            TraceabilityMatyrix,
            TableOfFigures,
            TableOfTables,
            RevisionTable,
            HoQ,
            AllocationTable,
            Glossary,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  DWM_TABLE CONSTRUCTOR
        //
        //  ************************************************************
        public DWM_Table()
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
        #region
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
        //  Table Type
        public TableType MyTableType
        {
            set => _MyTableType = value;
            get
            {
                return _MyTableType;
            }
        }
        //
        //  Figure Numbers
        public int CurrentFigureNumber
        {
            set => _CurrentFigureNumber = value;
            get
            {
                return _CurrentFigureNumber;
            }
        }
        public List<int> FigureNumbers
        {
            set => _FigureNumbers = value;
            get
            {
                return _FigureNumbers;
            }
        }
        //
        //  Data
        //
        //  Read Directions
        public Boolean VerticalReadDirectionDown
        {
            set => _VerticalReadDirectionDown = value;
            get
            {
                return _VerticalReadDirectionDown;
            }
        }
        public Boolean HorizontalReadDirectonRtL
        {
            set => _HorizontalReadDirectonRtL = value;
            get
            {
                return _HorizontalReadDirectonRtL;
            }
        }
        //
        //  Number of Rows
        public Int64 NumRows
         {
            set => _NumRows = value;
            get
            {
                return _NumRows;
            }
        }
       //
      //  Number of Columns
      public Int64 NumColumns
        {
            set => _NumColumns = value;
            get
            {
                return _NumColumns;
            }
        }
        //
        //  Has Header
        public Boolean HasHeader
        {
            set => _HasHeader = value;
            get
            {
                return _HasHeader;
            }
        }
        //
        //  Owned & Owning Objects
        //
        // My Rows
        public List<DWM_TableRow> MyRows
        {
            set => _MyRows = value;
            get
            {
                return _MyRows;
            }
        }
        //
        //  Current Field Values
        public List<DWM_TableColumn> MyColumns
        {
            set => _MyColumns = value;
            get
            {
                return _MyColumns;
            }
        }
        #endregion
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
