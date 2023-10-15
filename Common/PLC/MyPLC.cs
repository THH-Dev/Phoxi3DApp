using HslCommunication;
using HslCommunication.Profinet.Melsec;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanHungHa.Common.PLC
{
    public enum ePLCType
    {
        PLC_MELSEC,
        PLC_SERIAL
    }
    public class PLCParameter
    {
        private static PLCParameter _instance;
        private static readonly object _lock = new object();
        public static PLCParameter GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PLCParameter();
                    }
                }
            }
            return _instance;
        }

        [Category("Melsec"), DescriptionAttribute("IP of PLC")]
        public string IP { get; set; }

        [Category("Melsec"), DescriptionAttribute("Port of PLC")]
        public int Port { get; set; }

        [Category("Serial"), DescriptionAttribute("PortName of PLC")]
        public string Comport { get; set; }

        [Category("Serial"), DescriptionAttribute("Baurate of PLC")]
        public int Baudrate { get; set; }

        [Category("Type"), DescriptionAttribute("Type of PLC")]
        public ePLCType PLCType { get; set; }

        public PLCParameter()
        {
            IP = "192.168.100.212";
            Port = 3000;
            Comport = "COM1";
            Baudrate = 115200;
            PLCType = ePLCType.PLC_SERIAL;
        }
    }

    public class MyPLC
    {
        private static MyPLC _instance;
        private static readonly object _lock = new object();
        public static MyPLC GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MyPLC();
                    }
                }
            }
            return _instance;
        }

        

        [JsonIgnore]
        IMyPLC iMyPLC = null;

        MyPLC()
        {
            UpdatePLCType();
        }

        
        void SetPLCType(IMyPLC myPLC)
        {

            this.iMyPLC = myPLC;
        }

        public void UpdatePLCType()
        {
            if (MyParam.commonParam.PLCParam.PLCType == ePLCType.PLC_MELSEC)
            {
                SetPLCType(MyFxMelsec.GetInstance());
            }
            else if (MyParam.commonParam.PLCParam.PLCType == ePLCType.PLC_SERIAL)
            {
                SetPLCType(MyFxSerial.GetInstance());
            }
        }


        public string GetInfo()
        {
            return iMyPLC.GetInfo();
        }
        public bool ConnectToPlc(bool bShow = false)
        {
            UpdatePLCType();
            return iMyPLC.ConnectToPlc(bShow);
        }

        public bool DisconnectPLC()
        {
            return iMyPLC.DisconnectPLC();
        }


        public bool SetValue(int value, PLCRegister assignment)
        {
            return iMyPLC.SetValue(value, assignment);
        }



        public int GetValue(PLCRegister assignment)
        {
            return iMyPLC.GetValue(assignment);
        }


        public string Ping()
        {
            return iMyPLC.Ping();
        }

        public bool IsConnected()
        {
            return iMyPLC.IsConnected();
        }
    }
}
