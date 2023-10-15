using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanHungHa.Common
{
    public class MyComport
    {
        public enum modeReadCOM
        {
            READ_BY_LINE,
            READ_ALL_DATA
        }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public string portName { get; set; }
        public int baudRate { get; set; }
        public int readTimeout { get; set; }
        public int writeTimeout { get; set; }
        public Parity parity { get; set; }
        public int dataBits { get; set; }
        public StopBits stopBits { get; set; }
        public Handshake handshake { get; set; }
        public bool isDTR { get; set; }
        public bool isRTS { get; set; }
        
        public modeReadCOM modeRead { get; set; }
        
        public string keyParseData { get; set; }

        [Browsable(false)]
        public string dataComport { get; set; }


        [JsonIgnore]
        [Browsable(false)]
        SerialPort serialPort;


        private static MyComport _instance;
        private static readonly object _lock = new object();
        public static MyComport GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MyComport();
                    }
                }
            }
            return _instance;
        }


        MyComport()
        {
            dataComport = "";
            prefix = "";
            suffix = "";
            keyParseData = "M1=";

            portName = "COM1";
            baudRate = 9600;
            parity = Parity.None;
            dataBits = 8;
            stopBits = StopBits.One;
            handshake = Handshake.None;

            isDTR = false;
            isRTS = false;
            serialPort = null;
            readTimeout = writeTimeout = 500;
            modeRead = modeReadCOM.READ_BY_LINE;
        }

        public MyComport Clone()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            //MyLib.log(json);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MyComport>(json);
        }

        public bool GetStatus()
        {
            if(serialPort == null)
            {
                return false;
            }
            else
            {
                return serialPort.IsOpen;
            }
        }
        public bool Connect()
        {
            if(serialPort == null)
            {
                serialPort = new SerialPort();
            }

            try
            {

                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = portName;
                    serialPort.BaudRate = baudRate;
                    serialPort.DataBits = dataBits;
                    serialPort.StopBits = stopBits;
                    serialPort.Parity = parity;
                    serialPort.Handshake = handshake;

                    serialPort.RtsEnable = isRTS;
                    serialPort.DtrEnable = isDTR;
                    
                    serialPort.ReadTimeout = readTimeout;
                    serialPort.WriteTimeout = writeTimeout;

                    serialPort.Open();
                    serialPort.ErrorReceived += SerialPort_ErrorReceived;
                    serialPort.DataReceived += SerialPort_DataReceived;
                }
            }
            catch(Exception ex)
            {
                MyLib.showDlgError(ex.Message);
                MyLib.log(ex.Message, SvLogger.LogType.ERROR);
            }
            
            return serialPort.IsOpen;
        }

        private void SerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MyLib.showDlgWarning(e.EventType.ToString());
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (modeRead == modeReadCOM.READ_BY_LINE)
                {
                    dataComport = serialPort.ReadLine();
                }
                else if (modeRead == modeReadCOM.READ_ALL_DATA)
                {
                    dataComport = serialPort.ReadExisting();
                }

                //process data
                if (string.IsNullOrEmpty(dataComport))
                    return;

                if (dataComport.Contains(keyParseData))
                {
                    lock(MyParam.commonParam.queueLock)
                    {
                        if(MyParam.commonParam.queueData.Count >= MyDefine.MAX_QUEUE_DATA)
                        {
                            MyLib.log("Over queue size: " + dataComport);
                            MyLib.showDlgInfo("Please stop comport and wait a second!");
                        }
                        else
                        {

                            MyParam.commonParam.queueData.Enqueue(dataComport);
                        }
                    }
                    MyLib.log(dataComport);
                }
            }
            catch (Exception ex)
            {
                MyLib.showDlgError(ex.Message);
                MyLib.log(ex.Message, SvLogger.LogType.ERROR);
            }
            
        }

        public bool DisConnect()
        {
            if (serialPort == null)
                return false;

            try
            {
                serialPort.Close();
                serialPort.DataReceived -= SerialPort_DataReceived;
                serialPort.ErrorReceived -= SerialPort_ErrorReceived;
            }
            catch(Exception ex)
            {
                MyLib.log(ex.Message, SvLogger.LogType.ERROR);
            }

            return serialPort.IsOpen;
        }

        public bool SendData(string data)
        {
            if (serialPort == null || !serialPort.IsOpen)
                return false;
            try
            {
                serialPort.Write(string.Format($"{prefix}{data}{suffix}"));
            }
            catch (Exception e)
            {
                MyLib.showDlgError(e.Message);
                MyLib.log(e.Message, SvLogger.LogType.ERROR);
            }
            return true;
        }

    }
}
