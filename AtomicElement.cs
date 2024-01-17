using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;

namespace Science
{
    public class AtomicElement
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Name;
        private ElementEnum _AtomicNumber;
        private String _ElementSymbol;

        //  Element Data
        //
        //  Atomic Weights
        private List<Double> _AtomicWeights;

        //  Owned & Owning Objects
        //
        //  
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
        public enum ElementEnum
        {
            Hydrogen = 1,
            Helium,
            Lithium,
            Beryllium,
            Boron,
            Carbon,
            Nitrogen,
            Oxygen,
            Flourine,
            Neon,
            Sodium,
            Magnesium,
            Aluminum,
            Silicon,
            Phosphorus,
            Chlorine,
            Argon,
            Potassium,
            Calcium,
            Scandium,
            Titanium,
            Vanadium,
            Chromium,
            Manganese,
            Iron,
            Cobalt,
            Nickle,
            Copper,
            Zinc,
            Gallium,
            Germanium,
            Arsenic,
            Selenium,
            Bromine,
            Krypton,
            Rubidium,
            Strontium,
            Yttrium,
            Zirconium,
            Niobium,
            Molybdenum,
            Technetium,
            Ruthenium,
            Rhodium,
            Palladium,
            Silver,
            Cadmium,
            Indium,
            Tin,
            Antimony,
            Tellurium,
            Iodine,
            Xenon,
            Caesium,
            Barium,
            Lanthanum,
            Cerium,
            Tantalum = 73,
            Tungsten = 74,
            Rhenium = 75,
            Iridium = 77,
            Platinum = 78,
            Gold = 79,
            Mercury = 80,
            Lead = 82
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  ATOMICELEMENT CONSTRUCTOR
        //
        //  ************************************************************
        public AtomicElement()
        {
            this.AtomicWeights = new List<double>();

        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        //
        //  Fullname
        //
        public String Name
        {
            set => _Name = value;
            get
            {
                return _Name;
            }
        }
        //  Atomic Number
        //
        public ElementEnum AtomicNumber
        {
            set => _AtomicNumber = value;
            get
            {
                return _AtomicNumber;
            }
        }
        //  Element Symbol
        //
        public String ElementSymbol
        {
            set => _ElementSymbol = value;
            get
            {
                return _ElementSymbol;
            }
        }
        //  Element Data
        //
        //  Atomic Weights
        public List<Double> AtomicWeights
        {
            set => _AtomicWeights = value;
            get
            {
                return _AtomicWeights;
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
