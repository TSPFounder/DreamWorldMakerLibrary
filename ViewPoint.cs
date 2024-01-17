using System;
using System.Collections.Generic;
using CAD;
using SystemsEngineering;

namespace MissionsNamespace
{
    public class ViewPoint
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Description;

        //  Owned & Owning Objects
        //
        //  My Person
        private List<Person> _Stakeholders;
        //
        //  Views
        private List<View> _MyViews;
        //
        //  Concerns
        private List<String> _MyConcerns;
        //
        //  Languages
        private List<String> _Languages;
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
        //  VIEWPOINT CONSTRUCTOR
        //
        //  ************************************************************
        public ViewPoint()
        {
            this.Stakeholders = new List<Person>();
            this.MyViews = new List<View>();
            this.MyConcerns = new List<string>();
            this.Languages = new List<string>();
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
            set { }
            get
            {
                return _Name;
            }
        }
        public String Description
        {
            set { }
            get
            {
                return _Description;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  My Person
        public List<Person> Stakeholders
        {
            set { }
            get
            {
                return _Stakeholders;
            }
        }
        //
        //  Views
        public List<View> MyViews
        {
            set { }
            get
            {
                return _MyViews;
            }
        }
        //
        //  Concerns
        public List<String> MyConcerns
        {
            set { }
            get
            {
                return _MyConcerns;
            }
        }
        //
        //  Languages
        public List<String> Languages
        {
            set { }
            get
            {
                return _Languages;
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
