using MaterialSkin.Controls;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanHungHa.Common;

namespace TanHungHa.Tabs.ManualTab
{
    public partial class RS232Form : MaterialForm
    {
        //SerialPort serialPort = new SerialPort();

        MyComport myComport = MyParam.commonParam.myComport;

        private static RS232Form _instance;
        private static readonly object _lock = new object();
        public static RS232Form GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new RS232Form();
                    }
                }
            }
            return _instance;
        }
        public RS232Form()
        {
            InitializeComponent();
            initSerialPort();
        }
        #region RS232 Form

        void initSerialPort()
        {
            try
            {
                cbbParity.DataSource = Enum.GetValues(typeof(Parity));
                cbbParity.SelectedItem = myComport.parity;

                cbbHandshake.DataSource = Enum.GetValues(typeof(Handshake));
                cbbHandshake.SelectedItem = myComport.handshake;

                cbbBaud.DataSource = MyDefine.baudrates;
                cbbBaud.SelectedItem = myComport.baudRate;

                cbbDataSize.DataSource = MyDefine.dataSize;
                cbbDataSize.SelectedItem = myComport.dataBits;

                cbbStopbit.DataSource = Enum.GetValues(typeof(StopBits));
                cbbStopbit.SelectedItem = myComport.stopBits;

                cbbComPort.DataSource = SerialPort.GetPortNames();
                cbbComPort.SelectedItem = myComport.portName;
            }
            catch (Exception ex)
            {
                MyLib.showDlgError(ex.Message);
                MyLib.log(ex.Message, SvLogger.LogType.ERROR);
            }
            
        }

        


        private void txtDataSend_TrailingIconClick(object sender, EventArgs e)
        {
            txtDataSend.Text = "";
        }

        public void setText(string data)
        {
            txtDataReceiver.BeginInvoke(new Action(() =>
            {
                txtDataReceiver.Text += data;
            }));
        }

        private void btnSerialClick(object sender, EventArgs e)
        {
            var btnSerialName = ((MaterialButton)sender).Name;
            switch (btnSerialName)
            {
                case "btnClearData":
                    txtDataReceiver.Text = "";
                    break;

                case "btnSendDataCom":
                    if (myComport.GetStatus())
                    {
                        myComport.SendData(txtDataSend.Text);
                        MyLib.log($"Write data = {txtDataSend.Text}");
                    }
                    else
                    {
                        MyLib.ShowInfo($"Please connect {myComport.portName} first!");
                    }
                    break;


                case "btnConnectComport":
                    //connect
                    if (myComport.GetStatus())
                    {
                        //disconnect
                        myComport.DisConnect();
                        MyLib.log($"Disconnect {myComport.portName}");
                        btnConnectComport.Text = "Connect";
                        MainProcess.StopLoopRS232();
                    }
                    else
                    {
                        //connect
                        try
                        {
                            myComport.portName = cbbComPort.Text;
                            myComport.baudRate = (int)cbbBaud.SelectedItem; //int.Parse(cbbBaud.Text);
                            myComport.parity = (Parity)cbbParity.SelectedIndex;
                            myComport.dataBits = (int)cbbDataSize.SelectedItem;
                            myComport.handshake = (Handshake)cbbHandshake.SelectedItem;
                            myComport.stopBits = (StopBits)cbbStopbit.SelectedItem;


                            if (myComport.Connect())
                            {
                                btnConnectComport.Text = "Connected";
                                MainProcess.RunLoopRS232();
                                MyLib.log($"Connected {myComport.portName}");
                            }
                        }
                        catch (Exception ex)
                        {
                            MyLib.showDlgError(ex.Message);
                            //MyLib.ShowInfo(ex.Message, "Exception");
                            MyLib.log(ex.Message, SvLogger.LogType.ERROR);
                        }

                    }
                    break;
            }
        }

        #endregion


        private void btnConnectServer_Click(object sender, EventArgs e)
        {
        }

        
    }
}
