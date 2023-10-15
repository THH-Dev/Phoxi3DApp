using HslCommunication.Profinet.Melsec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanHungHa.Common.PLC
{
    public enum ePLCCOMMAND
    {
        CMD_PLC_READY,
        CMD_PLC_NOT_READY,
        CMD_VISION_FREE,
        CMD_VISION_BUSY,
        CMD_VISION_OK,
        CMD_VISION_NG,
        CMD_VISION_READY,
        CMD_VISION_NOT_READY,
        CMD_SLOT_OK,
        CMD_SLOT_NG,
        CMD_TRIGGER_ON,
        CMD_TRIGGER_OFF
    }
    
    public enum ePLCREG
    {
        STT,
        PLCREG,
        PURPOSE,
        DESCRIPT,
        MODE_RW
    }

    public enum eModeRW
    {
        BOOL,
        DOUBLE,
        FLOAT,
        INT16=16,
        INT32=32, 
        INT64=64,
        UINT16,
        UINT32,
        UINT64,
        STRING
    }

    public enum eIndex
    {
        //tape
        IsPLCTapeReady,
        IsPLCTapeTrigger,
        IsVisionTapeReady,
        IsVisionTapeProcessing,
        IsVisionTapeException,
        TapeQuantity,
        Tape1X,
        Tape1Y,
        Tape2X,
        Tape2Y,
        Tape3X,
        Tape3Y,
        Tape4X,
        Tape4Y,
        Tape5X,
        Tape5Y,
        Tape6X,
        Tape6Y,
        Tape1State,
        Tape2State,
        Tape3State,
        Tape4State,
        Tape5State,
        Tape6State,
        //jig
        IsPLCJigReady,
        IsPLCJigTrigger,
        IsVisionJigReady,
        IsVisionJigProcessing,
        IsVisionJigException,
        IsSlot1Exist,
        IsSlot2Exist,
        IsSlot3Exist,
        IsSlot4Exist,
        IsSlot5Exist,
        IsSlot6Exist,
        IsSlot7Exist,
        IsSlot8Exist,
        IsSlot9Exist,
        IsSlot10Exist,
        JigX,
        JigY,
        //Row attach target
        RowTarget
    }
    
    public enum eIndexIO
    {
        /*
            STT,PLC Register,Assigment,Descript,Mode RW
            1,M2,Centering Up/Down,Centering Up?1:0,0
            2,M3,Centering FW/BW,Centering FW?1:0,0
            3,M4,Transfer,Transfer FW?1:0,0
            4,M5,Vacum,On?1:0,0
            5,X0,Btn Start,Start?1:0,0
            6,X1,Btn EMG,EMG?1:0,0
            7,X2,Is Transfer In,In?1:0,0
            8,X3,IS TransferOut,Out?1:0,0
            9,X5,Vacum,On?1:0,0
            10,X4,??,On?1:0,0
            11,X6,Is Detect Can,In?1:0,0
         */

        Cylinder_UpDown,
        Cylinder_Gripper,
        Cylinder_Transfer,
        Vacumn,
        Btn_Start,
        Btn_EMG,
        Is_Tranfer_In,
        Is_Tranfer_Out,
        Is_Vacumn_On,
        Is_X4_On,
        Is_Detect_Can
    }

    public class PLCValue
    {
        public int iVal;
        public float fVal;
        public string sVal;

        public PLCValue(int iVal, float fVal, string sVal)
        {
            this.iVal = iVal;
            this.fVal = fVal;
            this.sVal = sVal;
        }

        public PLCValue()
        {
            this.iVal = MyDefine.ERROR_PLC_CODE;
            this.fVal = MyDefine.ERROR_PLC_CODE;
            this.sVal = MyDefine.PLC_CODE_STR;
        }
    }
    public class PLCRegister : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        public PLCRegister()
        {
            this.Register = "M0";
            this.Purpose = "Test";
            this.Description = "Test";
            this.Value = MyDefine.ERROR_PLC_CODE;
            this.strValue = MyDefine.PLC_CODE_STR;
            this.ModeRW = this.ModeRW = eModeRW.INT32;
        }
        public PLCRegister(string _Register, string _Purpose, string _Descript)
        {
            this.Register = _Register;
            this.Purpose = _Purpose;
            this.Description = _Descript;
            this.Value = MyDefine.ERROR_PLC_CODE;
            this.strValue = MyDefine.PLC_CODE_STR;
            this.ModeRW = eModeRW.INT32;
        }
        public PLCRegister(string _Register, string _Purpose, string _Descript, eModeRW mode)
        {
            this.Register = _Register;
            this.Purpose = _Purpose;
            this.Description = _Descript;
            this.Value = MyDefine.ERROR_PLC_CODE;
            this.strValue = MyDefine.PLC_CODE_STR;
            this.ModeRW = mode;
        }
        //-------------Variable----------------
        private string register;
        private string purpose;
        private string description;
        private eModeRW modeRW;
        private MyPLC myPLC = MyPLC.GetInstance();
        public int Value = MyDefine.ERROR_PLC_CODE;
        public string strValue = MyDefine.PLC_CODE_STR;
        //------------------------------

        public eModeRW ModeRW
        {
            get
            {
                return modeRW;
            }
            set
            {
                if (modeRW != value)
                {
                    modeRW = value;
                    OnPropertyChanged("modeRW");
                }
            }
        }
        public string Register
        {
            get
            {
                return register;
            }
            set
            {
                if (register != value)
                {
                    register = value;
                    OnPropertyChanged("register");
                }
            }
        }

        public string Purpose
        {
            get { return purpose; }
            set
            {
                if (purpose != value)
                {
                    purpose = value;
                    OnPropertyChanged("purpose");
                }

            }
        }
        
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged("description");
                }

            }
        }

        public string PrintInfo()
        {
            return string.Format($"{Register} - {Purpose} - {Description} - {modeRW} {GetValue()}");
        }



        public int GetValue()
        {

            if (!myPLC.IsConnected())
            {
                return MyDefine.ERROR_PLC_CODE;
            }
            int curVal = myPLC.GetValue(this);
            if(Value != curVal)
            {
                Value = curVal;
                OnPropertyChanged("value");
            }    
            return Value;
            
        }
        
        

        public bool SetValue(int value)
        {
            if (!myPLC.IsConnected())
            {
                MyLib.log("PLC not yet connect, can't set value");
                return false;
            }

            return myPLC.SetValue(value, this)?true: false;
        }

        
    }
}
