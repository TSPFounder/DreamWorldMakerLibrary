using System;

using System.Collections.Generic;
using Mathematics;
using SystemsEngineering;

namespace CAD
{
    public class CAD_Component :CAD_Part
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private String _Version;
        private String _Path;
        //
        //  Data
        private Double _Weight;
        private Double[] _MomentsOfInertia;
        private Vector[] _PrincipleDirections;
        private Double[] _CenterOfMass;
        //
        //  Booleans
        private Boolean _IsAssembly;
        private Boolean _IsConfigurationItem;

        //  Owned & Owning Objects
        private CAD_Part _MyPart;
        private List<CAD_Sketch> _MySketches;
        private List<CAD_Joint> _MyJoints;
        //
        //  GUI
        //
        //  TreeNode
        private TreeNode _MyTreeNode;

        //
        //  Component Data
        private int _WBS_Level;

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
        //  CAD_COMPONENT CONSTRUCTOR
        //
        //  ************************************************************
        #region
        public CAD_Component()
        {
            //
            //  Sketches
            this.MySketches = new List<CAD_Sketch>();
            //
            //  Joints
            this.MyJoints = new List<CAD_Joint>();
        }
        #endregion
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
            set => _Name = value;
            get { return _Name; }
        }
        //
        //  Version
        public String Version
        {
            set => _Version = value;
            get { return _Version; }
        }
        //
        //  Path
        public String Path
        {
            set => _Path = value;
            get { return _Path; }
        }
        //
        //  Data
        //
        //  Weight
        public Double Weight
        {
            set => _Weight = value;
            get { return _Weight; }
        }
        //
        //  Moments Of Inertia
        public Double[] MomentsOfInertia
        {
            set => _MomentsOfInertia = value;
            get { return _MomentsOfInertia; }
        }
        //
        //  Principle Directions
        public Vector[] PrincipleDirections
        {
            set => _PrincipleDirections = value;
            get { return _PrincipleDirections; }
        }
        //
        //  Center of Mass
        public Double[] CenterOfMass
        {
            set => _CenterOfMass = value;
            get { return _CenterOfMass; }
        }
        //
        //  Booleans
        //
        // Is an Assembly
        public Boolean IsAssembly
        {
            set => _IsAssembly = value;
            get { return _IsAssembly; }
        }
        //
        // Is a Configuration Item
        public Boolean IsConfigurationItem
        {
            set => _IsConfigurationItem = value;
            get { return _IsConfigurationItem; }
        }

        //
        // Owned & Owning Objects
        //
        //  Part
        public CAD_Part MyPart
        {
            set => _MyPart = value;
            get { return _MyPart; }
        }
        //
        //  Sketches
        public List<CAD_Sketch> MySketches
        {
            set => _MySketches = value;
            get { return _MySketches; }
        }
        //
        //  Joints
        public List<CAD_Joint> MyJoints
        {
            set => _MyJoints = value;
            get { return _MyJoints; }
        }
        //
        //  GUI
        //
        //  TreeNode
        public TreeNode MyTreeNode
        {
            set => _MyTreeNode = value;
            get { return _MyTreeNode; }
        }
        //
        //  Component Data
        //
        //  WBS Level
        public int WBS_Level
        {
            set => _WBS_Level = value;
            get { return _WBS_Level; }
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        //
        //  Extrude Profiles
        //
        //  Fusion 360
        public void ExtrudeCAD_Profile()
        {

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  EVENTS
        //
        //  ************************************************************

        //  *****************************************************************************************
    }
}
