using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsEngineering;
using CAD;
using MissionsNamespace;

namespace Power
{
    public class Battery : DWM_System
    {
        //  *****************************************************************************************
        //  DECLARATIONS
        //
        //  ************************************************************
        //
        //  Identification
        private String _Make;
        private String _Model;
        private String _Version;
        //
        //  Data
        //
        //  Dimensions
        private CAD_Dimension _Length;
        private CAD_Dimension _Width;
        private CAD_Dimension _Height;
        

        //
        //  Physical Properties
        private CAD_Parameter _Weight;
        private CAD_Parameter _PanelLeadGauge;
        private Battery_TypeEnum _BatteryType;
        private int _NumCells;
        //
        //  Performance
        private CAD_Parameter _MaxCurrent;  // ohms
        private CAD_Parameter _Capacity;  //  mAh
        private CAD_Parameter _MaxDischargeRate;  // C
        private CAD_Parameter _NominalVoltage;  //  Volts
        private CAD_Parameter _FullChargeVoltage;  //  Volts
        private CAD_Parameter _StorageVoltage;  //  Volts
        private CAD_Parameter _MinOperatingTemp;  // deg Celsius
        private CAD_Parameter _MaxOperatingTemp;  // deg Celsius
        //
        //  Owned & Owning Objects
        //
        //  Discharge Connector
        private CAD_Part _DischargeConnector;
        //
        //  Balance Connector
        private CAD_Part _BalanceConnector;
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
        public enum Battery_TypeEnum
        {
            Lipo = 0,
            LeadAcid,
            NiCad,
            NMH,
            Other
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  BATTERY CONSTRUCTOR
        //
        //  ************************************************************
        public Battery()
        {
           //  Managers
            this.MyAppMgr = this.TheMainWindow.MyAppManager;
            //
            //  Parameters
            this.Weight.MyParameterType = CAD_Parameter.ParameterType.Double;
            this.PanelLeadGauge.MyParameterType = CAD_Parameter.ParameterType.String;
            this.MaxCurrent.MyParameterType = CAD_Parameter.ParameterType.Double;
            this.Capacity.MyParameterType = CAD_Parameter.ParameterType.Double;
            this.MaxDischargeRate.MyParameterType = CAD_Parameter.ParameterType.Double;
            this.NominalVoltage.MyParameterType = CAD_Parameter.ParameterType.Double;
            this.FullChargeVoltage.MyParameterType = CAD_Parameter.ParameterType.Double;
            this.StorageVoltage.MyParameterType = CAD_Parameter.ParameterType.Double;
            this.MinOperatingTemp.MyParameterType = CAD_Parameter.ParameterType.Double;
            this.MaxOperatingTemp.MyParameterType = CAD_Parameter.ParameterType.Double;
            
        }
        //  *****************************************************************************************


        //  *****************************************************************************************
        //  PROPERTIES
        //
        //  ************************************************************
        //
        //  Identification
        public String Make
        {
            set => _Make = value;
            get
            {
                return _Make;
            }
        }
        public String Model
        {
            set => _Model = value;
            get
            {
                return _Model;
            }
        }
        public String Version
        {
            set => _Version = value;
            get
            {
                return _Version;
            }
        }
        //
        //  Data
        //
        //  Dimensions
        public CAD_Dimension Length
        {
            set => _Length = value;
            get
            {
                return _Length;
            }
        }
        public CAD_Dimension Width
        {
            set => _Width = value;
            get
            {
                return _Width;
            }
        }
        public CAD_Dimension Height
        {
            set => _Height = value;
            get
            {
                return _Height;
            }
        }


        //
        //  Physical Properties
        public CAD_Parameter Weight
        {
            set => _Weight = value;
            get
            {
                return _Weight;
            }
        }
        public CAD_Parameter PanelLeadGauge
        {
            set => _PanelLeadGauge = value;
            get
            {
                return _PanelLeadGauge;
            }
        }
        public Battery_TypeEnum BatteryType
        {
            set => _BatteryType = value;
            get
            {
                return _BatteryType;
            }
        }
        public int NumCells
        {
            set => _NumCells = value;
            get
            {
                return _NumCells;
            }
        }
        //
        //  Performance
        public CAD_Parameter MaxCurrent
        {
            set => _MaxCurrent = value;
            get
            {
                return _MaxCurrent;
            }
        }
        public CAD_Parameter Capacity
        {
            set => _Capacity = value;
            get
            {
                return _Capacity;
            }
        }
        public CAD_Parameter MaxDischargeRate
        {
            set => _MaxDischargeRate = value;
            get
            {
                return _MaxDischargeRate;
            }
        }
        public CAD_Parameter NominalVoltage
        {
            set => _NominalVoltage = value;
            get
            {
                return _NominalVoltage;
            }
        }
        public CAD_Parameter FullChargeVoltage
        {
            set => _FullChargeVoltage = value;
            get
            {
                return _FullChargeVoltage;
            }
        }
        public CAD_Parameter StorageVoltage
        {
            set => _StorageVoltage = value;
            get
            {
                return _StorageVoltage;
            }
        }
        public CAD_Parameter MinOperatingTemp
        {
            set => _MinOperatingTemp = value;
            get
            {
                return _MinOperatingTemp;
            }
        }
        public CAD_Parameter MaxOperatingTemp
        {
            set => _MaxOperatingTemp = value;
            get
            {
                return _MaxOperatingTemp;
            }
        }
        //
        //  Owned & Owning Objects
        //
        //  Discharge Connector
        public CAD_Part DischargeConnector
        {
            set => _DischargeConnector = value;
            get
            {
                return _DischargeConnector;
            }
        }
        //
        //  Balance Connector
        public CAD_Part BalanceConnector
        {
            set => _BalanceConnector = value;
            get
            {
                return _BalanceConnector;
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
