using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;

namespace Mathematics
{
    public class Equation
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private Boolean _IsInEquality;
        
        //  Owned & Owning Objects
        //
        private String _MathML;
        private Expression _LHS;
        private Expression _RHS;
        private Operator _EqualityOperator;
        private List<Operator> _Operators;
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
        //  EQUATION CONSTRUCTOR
        //
        //  ************************************************************
        public Equation()
        {
            this.Operators = new List<Operator>();
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        public String Name
        {
            set => _Name = value;
            get { return _Name; }
        }
        public Boolean IsInEquality
        {
            set => _IsInEquality = value;
            get { return _IsInEquality; }
        }
        //
        //  Owned & Owning Objects
        //
        public String MathML
        {
            set => _MathML = value;
            get { return _MathML; }
        }
        public Expression LHS
        {
            set => _LHS = value;
            get { return _LHS; }
        }
        public Expression RHS
        {
            set => _RHS = value;
            get { return _RHS; }
        }
        public Operator EqualityOperator
        {
            set => _EqualityOperator = value;
            get { return _EqualityOperator; }
        }
        public List<Operator> Operators
        {
            set => _Operators = value;
            get { return _Operators; }
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  METHODS
        //
        //  ************************************************************
        //
        //  Write the Equation to MathML
        public void writeMathML()
        {


        }
        //
        //  Build the Equation
        public void BuildEquation()
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
