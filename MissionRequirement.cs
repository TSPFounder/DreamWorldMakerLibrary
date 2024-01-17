using System;
using CAD;
using SystemsEngineering;

namespace MissionsNamespace
{
    public class MissionRequirement : DWM_Requirement
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
        //  Mission Requirements Document
        private Microsoft.Office.Interop.Word.Document _RequirementsDocument;

        //  UModel Objects
        //
        //  UModel Requirement
        //private UModelLib.IUMLGuiNodeLink _UModelRequirement;
        //
        //  UModel Requirement Diagram
        //private UModelLib.IUMLGuiSysMLRequirementDiagram _UModelSysMLRequirementsDiagram;
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
        public enum RequirementTypeEnum
        {
            Functional,
            Constraint,
            Environment,
            Interface,
            Performance,
            Physical,
            Cost

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  MISSIONREQUIREMENT CONSTRUCTOR
        //
        //  ************************************************************
        public MissionRequirement()
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
        //  Requirements Document
        public Microsoft.Office.Interop.Word.Document RequirementsDocument
        {
            set { }
            get
            {
                return _RequirementsDocument;
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
