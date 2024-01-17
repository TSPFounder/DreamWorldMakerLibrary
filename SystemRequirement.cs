using System;
using System.Collections.Generic;
using CAD;
using SystemsEngineering;

namespace MissionsNamespace
{
    public class SystemRequirement : DWM_Requirement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //  Owned & Owning Objects
        //
        //  WBS Workbook
        private Microsoft.Office.Interop.Excel.Workbook _MyWorkbook;
        //
        //  System Requirements Document
        private Microsoft.Office.Interop.Word.Document _RequirementsDocument;

        //  UModel Objects
        //
        //  UModel Requirement
        private UModelLib.IUMLGuiNodeLink _UModelRequirement;
        //private UModelLib.IUMLGuiNodeLink.OwnedGuiElements _UModelRequirementGUIElements;
        //
        //  UModel Requirement Diagram
        private UModelLib.IUMLGuiSysMLRequirementDiagram _UModelSysMLRequirementsDiagram;

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
        //  SYSTEMREQUIREMENT CONSTRUCTOR
        //
        //  ************************************************************
        public SystemRequirement()
        {
            _MyWorkbook = new Microsoft.Office.Interop.Excel.Workbook();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        
        //
        //  Owned & Owning Objects
        //
        //  WBS Workbook
        public Microsoft.Office.Interop.Excel.Workbook MyWorkbook
        {
            set { }
            get
            {
                return _MyWorkbook;
            }
        }
        //
        //  System Requirements Document
        public Microsoft.Office.Interop.Word.Document RequirementsDocument
        {
            set { }
            get
            {
                return _RequirementsDocument;
            }
        }
        //
        //  UModel Objects
        //
        //  SysML Requirement
        public UModelLib.IUMLGuiNodeLink UModelRequirement
        {
            set { }
            get
            {
                return _UModelRequirement;
            }
        }
        //
        //  SysML Requirement
        public UModelLib.IUMLGuiSysMLRequirementDiagram UModelSysMLRequirementsDiagram
        {
            set { }
            get
            {
                return _UModelSysMLRequirementsDiagram;
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
