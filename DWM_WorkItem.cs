using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD;
using MissionsNamespace;

namespace SystemsEngineering
{
    public class DWM_WorkItem
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        #region
        //
        //  Identification
        private String _Name;
        private String _Description;
        private String _RequirementID;
        private String _Version;
        private String _ADO_ID;
        //
        //  Enumerations
        private WorkItemType _MyWorkItemType;
        //
        //  Data
        //
        //  Iteration
        private String _Iteration;
        //
        //  Priority
        private int _Priority;
        //
        //  Efforts
        private float _EffortInHours;
        private int _EffortEstimate;
        //
        //  Is Blocked
        private Boolean _Blocked;
        //
        //  Discussions
        private String _CurrentDiscussion;
        private List<String> _MyDiscussions;
        //
        //  Owned & Owning Objects
        //
        //  Work Items
        private DWM_WorkItem _CurrentWorkItem;
        private List<DWM_WorkItem> _MyWorkItems;
        //
        //  Attachments
        private AppFile _CurrentAttachment;
        private List<AppFile> _MyAttachments;
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
        public enum WorkItemType
        {
            Epic=0,
            Feature,
            Requirement,
            Task,
            Bug,
            ChangeRequest,
            Issue,
            Review,
            Risk,
            TestCase,
            Other
        }
        #endregion
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  DWM_WORKITEM CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public DWM_WorkItem()
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
            get
            {
                return _Name;
            }
        }
        //
        //  Description
        public String Description
        {
            set => _Description = value;
            get
            {
                return _Description;
            }
        }
        //
        //  Requirement ID
        public String RequirementID
        {
            set => _RequirementID = value;
            get
            {
                return _RequirementID;
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
        //  ADO ID
        public String ADO_ID
        {
            set => _ADO_ID = value;
            get
            {
                return _ADO_ID;
            }
        }
        //
        //  Enumerations
        //
        //  WorkItem Types
        public WorkItemType MyWorkItemType
        {
            set => _MyWorkItemType = value;
            get
            {
                return _MyWorkItemType;
            }
        }
        //
        //  Data
        //
        //  Iteration
        public String Iteration
        {
            set => _Iteration = value;
            get { return _Iteration; }
        }
        //
        //  Priority
        public int Priority
        {
            set => _Priority = value;
            get { return _Priority; }
        }
        //
        //  Efforts
        public float EffortInHours
        {
            set => _EffortInHours = value;
            get { return _EffortInHours; }
        }
        public int EffortEstimate
        {
            set => _EffortEstimate = value;
            get { return _EffortEstimate; }
        }
        //
        //  Is Blocked
        public Boolean Blocked
        {
            set => _Blocked = value;
            get { return _Blocked; }
        }
        //
        //  Discussions
        public String CurrentDiscussion
        {
            set => _CurrentDiscussion = value;
            get { return _CurrentDiscussion; }
        }
        public List<String> MyDiscussions
        {
            set => _MyDiscussions = value;
            get { return _MyDiscussions; }
        }
        //
        //  Owned & Owning Objects
        //
        //  Work Items
        public DWM_WorkItem CurrentWorkItem
        {
            set => _CurrentWorkItem = value;
            get { return _CurrentWorkItem; }
        }
        public List<DWM_WorkItem> MyWorkItems
        {
            set => _MyWorkItems = value;
            get { return _MyWorkItems; }
        }
        //
        //  Attachments
        public AppFile CurrentAttachment
        {
            set => _CurrentAttachment = value;
            get { return _CurrentAttachment; }
        }
        public List<AppFile> MyAttachments
        {
            set => _MyAttachments = value;
            get { return _MyAttachments; }
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
