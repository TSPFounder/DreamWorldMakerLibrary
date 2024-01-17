using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;

namespace Documents
{
    public class DWM_TableCell
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        //  
        //  Identification
        private String _Name;
        private String _ID;
        private String _Description;
        private String _RowID;
        private String _ColumnID;
        //
        //  Enumerations
        private CellDataType _MyDataType;
        //
        //  Data
        private String _ObjectTypeName;
        //
        //  Owned & Owning Objects
        private DWM_Table _MyTable;

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
        public enum CellDataType
        {
            _Double = 0,
            _Single,
            _int,
            _Int16,
            _Int32,
            _Int64,
            String,
            Object,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  DWM_TABLECELL CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public DWM_TableCell(CellDataType myType)
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
        //  Identification
        //
        //  Name
        public String Name
        {
            set => _Name = value;
            get { return _Name; }
        }
        //
        //  ID
        public String PartNumber
        {
            set => _ID = value;
            get { return _ID; }
        }
        //
        //  Description
        public String Description
        {
            set => _Description = value;
            get { return _Description; }
        }
        //
        //  Row Number
        public String RowID
        {
            set => _RowID = value;
            get { return _RowID; }
        }
        //
        //
        public String ColumnID
        {
            set => _ColumnID = value;
            get { return _ColumnID; }
        }
        //
        //  Enumerations
        public CellDataType MyDataType
        {
            set => _MyDataType = value;
            get { return _MyDataType; }
        }
        //
        //  Data
        //
        //  Name of Object that is the Cell's Type
        public String ObjectTypeName
        {
            set => _ObjectTypeName = value;
            get { return _ObjectTypeName; }
        }
        //
        //  Owned & Owning Objects
        //
        //  My Table
        public DWM_Table MyTable
        {
            set => _MyTable = value;
            get { return _MyTable; }
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
