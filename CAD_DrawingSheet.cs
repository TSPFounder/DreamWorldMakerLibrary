using System;
using System.Collections.Generic;
using Mathematics;
using SystemsEngineering;
using Documents;

namespace CAD
{
    public class CAD_DrawingSheet
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //  
        //  Identification
        private String _SheetID;
        //
        //  Data

        //
        //  Owned & Owning Objects
        //
        //  My Drawing
        private CAD_Drawing _MyDrawing;
        //
        //  CAD Drawing Elements
        //
        //  BoM
        private CAD_BoM _MyBoM;
        //
        //  CAD Views
        private CAD_DrawingView _CurrentDrawingView;
        private List<CAD_DrawingView> _MyDrawingViews;
        //
        //  CAD Dimensions
        private CAD_Dimension _CurrentDimensions;
        private List<CAD_Dimension> _MyDimensions;
        //
        //  CAD Notes
        private CAD_DrawingNote _CurrentDrawingNote;
        private List<CAD_DrawingNote> _MyDrawingNotes;
        //
        //  CAD Construction Geometry
        private CAD_ConstructionGeometery _CurrentConstructionGeometry;
        private List<CAD_ConstructionGeometery> _MyConstructionGeometry;
        //
        //  CAD PMI
        private CAD_DrawingPMI _CurrentPMI;
        private List<CAD_DrawingPMI> _MyPMI;
        //
        //  CAD Tables
        private CAD_DrawingTable _CurrentDrawingTables;
        private List<CAD_DrawingTable> _MyDrawingTables;
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
        //  CAD_DRAWINGSHEET CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_DrawingSheet()
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
        //  Data
        public String  SheetID
        {
            set => _SheetID = value;
            get { return _SheetID; }
        }
        //
        //  Owned & Owning Objects
        //
        //  My Drawing
        public CAD_Drawing  MyDrawing
        {
            set => _MyDrawing = value;
            get { return _MyDrawing; }
        }
        //
        //  CAD Drawing Elements
        //
        //  BoM
        public CAD_BoM  MyBoM
        {
            set => _MyBoM = value;
            get { return _MyBoM; }
        }
        //
        //  CAD Views
        public CAD_DrawingView  CurrentDrawingView
        {
            set => _CurrentDrawingView = value;
            get { return _CurrentDrawingView; }
        }
        public List<CAD_DrawingView>  MyDrawingViews
        {
            set => _MyDrawingViews = value;
            get { return _MyDrawingViews; }
        }
        //
        //  CAD Dimensions
        public CAD_Dimension  CurrentDimensions
        {
            set => _CurrentDimensions = value;
            get { return _CurrentDimensions; }
        }
        public List<CAD_Dimension>  MyDimensions
        {
            set => _MyDimensions = value;
            get { return _MyDimensions; }
        }
        //
        //  CAD Notes
        public CAD_DrawingNote CurrentDrawingNote
        {
            set => _CurrentDrawingNote = value;
            get { return _CurrentDrawingNote; }
        }
        public List<CAD_DrawingNote> MyDrawingNotes
        {
            set => _MyDrawingNotes = value;
            get { return _MyDrawingNotes; }
        }
        //
        //  CAD Construction Geometry
        public CAD_ConstructionGeometery  CurrentConstructionGeometry
        {
            set => _CurrentConstructionGeometry = value;
            get { return _CurrentConstructionGeometry; }
        }
        public List<CAD_ConstructionGeometery>  MyConstructionGeometry
        {
            set => _MyConstructionGeometry = value;
            get { return _MyConstructionGeometry; }
        }
        //
        //  CAD PMI
        public CAD_DrawingPMI  CurrentPMI
        {
            set => _CurrentPMI = value;
            get { return _CurrentPMI; }
        }
        public List<CAD_DrawingPMI>  MyPMI
        {
            set => _MyPMI = value;
            get { return _MyPMI; }
        }
        //
        //  CAD Tables
        public CAD_DrawingTable  CurrentDrawingTables
        {
            set => _CurrentDrawingTables = value;
            get { return _CurrentDrawingTables; }
        }
        public List<CAD_DrawingTable>  MyDrawingTables
        {
            set => _MyDrawingTables = value;
            get { return _MyDrawingTables; }
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
