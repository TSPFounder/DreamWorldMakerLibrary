using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;

namespace Mathematics
{
    public class Expression
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;

        //  Owned & Owning Objects
        //
        private List<Double> _Constants;
        private List<Double> _Coefficients;
        private List<Operator> _Operators;
        private List<Parameter> _Parameters;
        private List<Variable> _Variables;
        private List<Expression> _Expressions;
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
        //  EXPRESSION CONSTRUCTOR
        //
        //  ************************************************************
        public Expression()
        {

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        private String Name;

        //  Owned & Owning Objects
        //
        public List<Double> Constants
        {
            set => _Constants = value;
            get { return _Constants; }
        }
        public List<Double> Coefficients
        {
            set => _Coefficients = value;
            get { return _Coefficients; }
        }
        public List<Operator> Operators
        {
            set => _Operators = value;
            get { return _Operators; }
        }
        public List<Parameter> Parameters
        {
            set => _Parameters = value;
            get { return _Parameters; }
        }
        public List<Variable> Variables
        {
            set => _Variables = value;
            get { return _Variables; }
        }
        public List<Expression> Expressions
        {
            set => _Expressions = value;
            get { return _Expressions; }
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
