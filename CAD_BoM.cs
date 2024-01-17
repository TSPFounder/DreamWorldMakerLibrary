using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using Documents;
using Mathematics;
using MissionsNamespace;

namespace CAD
{
    public class CAD_BoM  :CAD_DrawingTable
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
        //  Configurations
        private CAD_Configuration _CurrentConfiguration;
        private List<CAD_Configuration> _MyConfigurations;
        //
        //  Columns
        //
        //  Configuration Columns
        private DWM_TableColumn _CurrentConfigurationColumn;
        private List<DWM_TableColumn> _MyConfigurationColumns;
        //
        //  ItemNumber
        private DWM_TableColumn _ItemNumberColumn;
        //
        //  Part Number Column
        private DWM_TableColumn _PartNumberColumn;
        //
        //  Description Column
        private DWM_TableColumn _DescriptionColumn;
        //
        //  Material Column
        private DWM_TableColumn _MaterialColumn;
        //
        //  Specification Column
        private DWM_TableColumn _SpecificationColumn;
        //
        //  Rows
        private DWM_TableRow _HeaderRow;
        private DWM_TableRow _PartRow;
        //
        //  Location
        private Point _MyLocation;
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
        //  CAD_BOM CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_BoM()
        {
            this.MyType = DrawingElementType.BoM;
            this.MyLocation.Is2D = true;
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
        //  Configurations
        public CAD_Configuration CurrentConfiguration
        {
            set => _CurrentConfiguration = value;
            get { return _CurrentConfiguration; }
        }
        public List<CAD_Configuration> MyConfigurations
        {
            set => _MyConfigurations = value;
            get { return _MyConfigurations; }
        }
        //
        //  Columns
        //
        //  Configuration Columns
        public DWM_TableColumn CurrentConfigurationColumn
        {
            set => _CurrentConfigurationColumn = value;
            get { return _CurrentConfigurationColumn; }
        }
        public List<DWM_TableColumn> MyConfigurationColumns
        {
            set => _MyConfigurationColumns = value;
            get { return _MyConfigurationColumns; }
        }
        //  ItemNumber
        public DWM_TableColumn ItemNumberColumn
        {
            set => _ItemNumberColumn = value;
            get { return _ItemNumberColumn; }
        }
        //
        //  Part Number Column
        public DWM_TableColumn PartNumberColumn
        {
            set => _PartNumberColumn = value;
            get { return _PartNumberColumn; }
        }
        //
        //  Description Column
        public DWM_TableColumn DescriptionColumn
        {
            set => _DescriptionColumn = value;
            get { return _DescriptionColumn; }
        }
        //
        //  Material Column
        public DWM_TableColumn MaterialColumn
        {
            set => _MaterialColumn = value;
            get { return _MaterialColumn; }
        }
        //
        //  Specification Column
        public DWM_TableColumn SpecificationColumn
        {
            set => _SpecificationColumn = value;
            get { return _SpecificationColumn; }
        }
        //
        //  Rows
        public DWM_TableRow HeaderRow
        {
            set => _HeaderRow = value;
            get { return _HeaderRow; }
        }
        public DWM_TableRow PartRow
        {
            set => _PartRow = value;
            get { return _PartRow; }
        }
        //
        //  Location
        public Point MyLocation
        {
            set => _MyLocation = value;
            get { return _MyLocation; }
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
