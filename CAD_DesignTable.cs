using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;

namespace Documents
{
    public class CAD_DesignTable :DWM_Table
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification

        //
        //  Data

        //
        //  Owned & Owning Objects
        //
        //  Cells
        private DWM_TableCell _CurrentName;
        private DWM_TableCell _CurrentExpression;
        private DWM_TableCell _CurrentComments;
        private DWM_TableCell _CurrentValue;
        //
        //  Fields
        private DWM_TableColumn _NameField;
        private DWM_TableColumn _ExpressionField;
        private DWM_TableColumn _Comments;       
        private DWM_TableColumn _Value;
        //
        //  Rows
        private DWM_TableRow _CurrentRow;
        private List<DWM_TableRow> _MyRows;
        //
        //  Configurations
        private CAD_Configuration _CurrentConfiguration;
        private List<CAD_Configuration> _MyConfigurations;
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

        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  CAD_DESIGNTABLE CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_DesignTable()
        {
            this.MyColumns.Add(this.NameField);
            this.MyColumns.Add(this.ExpressionField);
            this.MyColumns.Add(this.Comments);
            this.MyColumns.Add(this.Value);
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        #region
        //
        //  Owned & Owning Objects
        //
        //  Fields
        //
        //  Name Field
        public DWM_TableColumn NameField
        {
            set => _NameField = value;
            get
            {
                return _NameField;
            }
        }
        //
        //  Expression Field
        public DWM_TableColumn ExpressionField
        {
            set => _ExpressionField = value;
            get
            {
                return _ExpressionField;
            }
        }
        //
        //  Comments Field
        public DWM_TableColumn Comments
        {
            set => _Comments = value;
            get
            {
                return _Comments;
            }
        }
        //
        //  Value Field
        public DWM_TableColumn Value
        {
            set => _Value = value;
            get
            {
                return _Value;
            }
        }
        //
        //  Rows
        //
        //  Current Row
        public DWM_TableRow CurrentRow
        {
            set => _CurrentRow = value;
            get
            {
                return _CurrentRow;
            }
        }
        //
        //  My Rows
        public List<DWM_TableRow> MyRows
        {
            set => _MyRows = value;
            get
            {
                return _MyRows;
            }
        }
        //
        //  Configurations
        //
        //  Current Configuration
        public CAD_Configuration CurrentConfiguration
        {
            set => _CurrentConfiguration = value;
            get
            {
                return _CurrentConfiguration;
            }
        }
        public List<CAD_Configuration> MyConfigurations
        {
            set => _MyConfigurations = value;
            get
            {
                return _MyConfigurations;
            }
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        #region
        public DWM_TableRow CreateRow(DWM_TableCell nameField, DWM_TableCell expressionField, DWM_TableCell comments, DWM_TableCell value)
        {
           
            this.NameField.ColumnValues.Add(nameField);
            this.ExpressionField.ColumnValues.Add(expressionField);
            this.Comments.ColumnValues.Add(comments);
            this.Value.ColumnValues.Add(value);
            DWM_TableRow newRow = new DWM_TableRow();
            newRow.RowValues.Add(nameField);
            newRow.RowValues.Add(expressionField);
            newRow.RowValues.Add(comments);
            newRow.RowValues.Add(value);
            this.MyRows.Add(newRow);
            return newRow;
        }
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
