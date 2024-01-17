using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
//using OfficeApps;
using SystemsEngineering;
using MissionsNamespace;

namespace Documents
{
    public class DWM_Document : AppFile
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //  
        //  Identification
        //
        //  Title
        private String _Title;
        private String _SubTitle;
        private String _Path;
        private String _Revision;
        //
        //  Definitions
        //
        //  Document Type
        private DocumentTypeEnum _DocumentType;
        //
        //  Document File Type
        private DocumentFileTypeEnum _FileType;
        //
        //  Data
        //
        //  Revision Date
        private DateTime _RevisionDate;
        //
        //  Owned & Owning Objects
        //
        //  Word Objects
        //
        //  Word Document
        private Microsoft.Office.Interop.Word.Document _MyWordDoc;
        //
        //  Word Subdocuments
        private Microsoft.Office.Interop.Word.Subdocument _CurrentSubDocument;
        private List<Microsoft.Office.Interop.Word.Subdocument> _MySubdocuments;
        //
        //  Word Bookmarks
        private Microsoft.Office.Interop.Word.Bookmark _CurrentBookmark;
        private List<Microsoft.Office.Interop.Word.Bookmark> _MyWordBookmarks;
        //
        //  Word Sections
        private Microsoft.Office.Interop.Word.Section _CurrentSection;
        private List<Microsoft.Office.Interop.Word.Section> _MyWordSections;
        //
        //  Word Paragraphs
        private Microsoft.Office.Interop.Word.Paragraph _CurrentParagraph;
        private List<Microsoft.Office.Interop.Word.Paragraph> _MyWordParagraphs;
        // 
        //  Word Lists
        private Microsoft.Office.Interop.Word.List _CurrentList;
        private List<Microsoft.Office.Interop.Word.List> _MyWordLists;
        //
        //  DWM Objects
        //
        //  DWM Figures
        private List<DWM_Figure> _MyFigures;
        //
        //  DWM Tables
        private DWM_Table _MyRevisionTable;
        private List<DWM_Table> _MyTables;
        //
        //  People
        //
        //  Author
        private Person _Author;
        //
        //  Approver
        private Person _Approver;
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
        public enum DocumentFileTypeEnum
        {
            Word = 0,
            PDF,
            HTML,
            Other
        }
        public enum DocumentTypeEnum
        {
            Plan = 0,
            Report,
            Notebook,
            DesignDescription,
            Requirement,
            Specification,
            Concepts,
            Manuals,
            Process,
            Drawing,
            Other
        }
        public enum Status
        {
            Working=0,
            Complete,
            Reworking,
            Approved,
            Obsolete
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  DWM_DOCUMENT CONSTRUCTOR
        //
        //  ************************************************************
        public  DWM_Document()
        {
            this.MyFigures = new List<DWM_Figure>();
            this.MyRevisionTable = new DWM_Table();
            //this.MyWordDoc = new Microsoft.Office.Interop.Word.Document();
            this.MySubdocuments = new List<Microsoft.Office.Interop.Word.Subdocument>();
            this.MyTables = new List<DWM_Table>();
            this.MyWordBookmarks = new List<Microsoft.Office.Interop.Word.Bookmark>();
            this.MyWordLists = new List<Microsoft.Office.Interop.Word.List>(0);
            this.MyWordParagraphs = new List<Microsoft.Office.Interop.Word.Paragraph>();
            this.MyWordSections = new List<Microsoft.Office.Interop.Word.Section>();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //  
        //  Identification
        //
        //  Title
        public String Title
        {
            set => _Title = value;
            get { return _Title; }
        }
        //
        // SubTitle
        public String SubTitle
        {
            set => _SubTitle = value;
            get { return _SubTitle; }
        }
        //
        //  Path
        public String Path
        {
            set => _Path = value;
            get { return _Path; }
        }
        //
        //  Revision
        public String Revision
        {
            set => _Revision = value;
            get { return _Revision; }
        }
        //
        // Definitions
        //
        //
        //  Document Type
        public DocumentTypeEnum DocumentType
        {
            set => _DocumentType = value;
            get { return _DocumentType; }
        }
        //
        //  Document File Type
        public DocumentFileTypeEnum FileType
        {
            set => _FileType = value;
            get { return _FileType; }
        }
        //
        //  Data
        //
        //  Revision Date
        public DateTime RevisionDate
        {
            set => _RevisionDate = value;
            get { return _RevisionDate; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Word Document
        public Microsoft.Office.Interop.Word.Document MyWordDoc
        {
            set => _MyWordDoc = value;
            get { return _MyWordDoc; }
        }
        //
        //  Word Subdocuments
        public Microsoft.Office.Interop.Word.Subdocument CurrentSubDocument
        {
            set => _CurrentSubDocument = value;
            get { return _CurrentSubDocument; }
        }
        public List<Microsoft.Office.Interop.Word.Subdocument> MySubdocuments
        {
            set => _MySubdocuments = value;
            get { return _MySubdocuments; }
        }
        //
        //  Word Bookmarks
        public Microsoft.Office.Interop.Word.Bookmark CurrentBookmark
        {
            set => _CurrentBookmark = value;
            get { return _CurrentBookmark; }
        }
        public List<Microsoft.Office.Interop.Word.Bookmark> MyWordBookmarks
        {
            set => _MyWordBookmarks = value;
            get { return _MyWordBookmarks; }
        }
        //
        //  Word Sections
        public Microsoft.Office.Interop.Word.Section CurrentSection
        {
            set => _CurrentSection = value;
            get { return _CurrentSection; }
        }
        public List<Microsoft.Office.Interop.Word.Section> MyWordSections
        {
            set => _MyWordSections = value;
            get { return _MyWordSections; }
        }
        //
        //  Word Paragraphs
        public Microsoft.Office.Interop.Word.Paragraph CurrentParagraph
        {
            set => _CurrentParagraph = value;
            get { return _CurrentParagraph; }
        }
        public List<Microsoft.Office.Interop.Word.Paragraph> MyWordParagraphs
        {
            set => _MyWordParagraphs = value;
            get { return _MyWordParagraphs; }
        }
        // 
        //  Word Lists
        public Microsoft.Office.Interop.Word.List CurrentList
        {
            set => _CurrentList = value;
            get { return _CurrentList; }
        }
        public List<Microsoft.Office.Interop.Word.List> MyWordLists
        {
            set => _MyWordLists = value;
            get { return _MyWordLists; }
        }
        //
        //  DWM Objects
        //
        //  DWM Figures
        public List<DWM_Figure> MyFigures
        {
            set => _MyFigures = value;
            get { return _MyFigures; }
        }
        //
        //  DWM Tables
        public DWM_Table MyRevisionTable
        {
            set => _MyRevisionTable = value;
            get { return _MyRevisionTable; }
        }
        public List<DWM_Table> MyTables
        {
            set => _MyTables = value;
            get { return _MyTables; }
        }
        //
        //  People
        //
        //  Author
        public Person Author
        {
            set => _Author = value;
            get { return _Author; }
        }
        //
        //  Approver
        public Person Approver
        {
            set => _Approver = value;
            get { return _Approver; }
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
