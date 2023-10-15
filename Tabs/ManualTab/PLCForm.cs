using MaterialSkin.Controls;
using System;
using System.IO.Ports;
using System.Windows.Forms;
using TanHungHa.Common;
using TanHungHa.Common.PLC;
using TanHungHa.Tabs.UC;

namespace TanHungHa.Tabs.ManualTab
{
    public partial class PLCForm : MaterialForm
    {

        private static PLCForm _instance;
        private static readonly object _lock = new object();
        public static PLCForm GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PLCForm();
                    }
                }
            }
            return _instance;
        }
        PLCForm()
        {
            InitializeComponent();
            cbbModeRW.DataSource = Enum.GetValues(typeof(eModeRW));
            cbbModeRW.SelectedItem = eModeRW.BOOL;
        }



        public void InitPLCRegister()
        {
            UpdateBtnStatus();

            this.flowLayoutPanel_X.Controls.Clear();
            this.flowLayoutPanel_Y.Controls.Clear();
            this.flowLayoutPanel_M.Controls.Clear();
            //this.flowLayoutPanel_D.Controls.Clear();

            for (int index = 0; index < MyParam.list_plc_reg.Count; ++index)
            {
                UCPLCReg ucio = new UCPLCReg(MyParam.list_plc_reg[index]);
                ucio.PropertyChanged += Ucio_PropertyChanged;

                var REG = MyParam.list_plc_reg[index].Register.Substring(0, 1);
                /*switch (REG)
                {
                    case "X":
                        ucio.State.Enabled = false;
                        this.flowLayoutPanel_X.Controls.Add((Control)ucio);
                        break;

                    case "Y":
                        ucio.State.Enabled = true;
                        this.flowLayoutPanel_Y.Controls.Add((Control)ucio);
                        break;

                    case "M":
                        ucio.State.Enabled = true;
                        this.flowLayoutPanel_M.Controls.Add((Control)ucio);
                        break;

                    case "D":
                        ucio.State.Enabled = false;
                        this.flowLayoutPanel_D.Controls.Add((Control)ucio);
                        break;

                }*/
                
                if (index < MyDefine.PAGE_SHOW_PLC)
                {
                    ucio.State.Enabled = false;
                    this.flowLayoutPanel_M.Controls.Add((Control)ucio);
                }
                else
                {
                    ucio.State.Enabled = false;
                    this.flowLayoutPanel_D.Controls.Add((Control)ucio);
                }

            }
        }

        private void Ucio_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var obj = sender as UCPLCReg;
            if (obj == null)
            {
                return;
            }

            if (e.PropertyName == "LabelHintClick")
            {
                txtPLCAdress.Text = obj.obj.Register;
                //Console.WriteLine(obj.obj.Register);
            }
        }

        MyPLC myPLC = MyPLC.GetInstance();

        private void btnPLCActionClick(object sender, EventArgs e)
        {
            var btnSerialName = ((MaterialButton)sender).Name;
            switch (btnSerialName)
            {
                case "btnConnectPLC":
                    try
                    {
                        if (!myPLC.IsConnected())
                        {
                            this.Cursor = Cursors.WaitCursor;
                            if (myPLC.ConnectToPlc())
                            {
                                btnRead.Enabled = btnWrite.Enabled = true;
                                btnConnectPLC.Text = "Connected";
                                btnScanREG.Enabled = true;
                                if (btnAutoScanPLC.Checked)
                                {
                                    MainProcess.RunLoopPLC();
                                }
                            }
                            else
                            {
                                MyLib.showDlgWarning($"Can't connect to PLC {myPLC.GetInfo()}");
                            }
                            this.Cursor = Cursors.Default;
                        }
                        else
                        {
                            myPLC.DisconnectPLC();
                            btnConnectPLC.Text = "Connect";
                            btnRead.Enabled = btnWrite.Enabled = false;
                            MainProcess.StopLoopPLC();
                            btnScanREG.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MyLib.showDlgError(ex.Message);
                        MyLib.log(ex.Message, SvLogger.LogType.ERROR);
                    }

                    break;

                case "btnWrite":
                    try
                    {
                        var plcAddress = txtPLCAdress.Text;
                        var plcVal = int.Parse(txtPLCVal.Text);
                        var mode = (eModeRW)cbbModeRW.SelectedItem;
                        PLCRegister plcReg = new PLCRegister(
                            plcAddress, "Test", "Test", mode);


                        bool b = myPLC.SetValue(plcVal, plcReg);
                        //MyLib.showDlgInfo($"Write {b}: {plcAddress} = {plcVal}");
                    }
                    catch (Exception ex)
                    {
                        MyLib.showDlgError(ex.Message);
                        MyLib.log(ex.Message, SvLogger.LogType.ERROR);
                    }
                    break;


                case "btnRead":
                    try
                    {
                        var plcAddress = txtPLCAdress.Text;
                        var plcVal = int.Parse(txtPLCVal.Text);
                        var mode = (eModeRW)cbbModeRW.SelectedItem;
                        PLCRegister plcReg = new PLCRegister(
                            plcAddress, "Test", "Test", mode);

                        int a = myPLC.GetValue(plcReg);
                        //MyLib.showDlgInfo(a.ToString());
                        txtPLCVal.Text = a.ToString();
                    }
                    catch (Exception ex)
                    {
                        MyLib.showDlgError(ex.Message);
                        MyLib.log(ex.Message, SvLogger.LogType.ERROR);
                    }
                    break;

                case "btnLoadREG":
                    //MyParam.list_plc_reg = MyLib.GetListPLCREG();
                    break;


            }
        }

        public void UpdateBtnStatus()
        {
            if (myPLC.IsConnected())
            {
                btnRead.Enabled = btnWrite.Enabled = true;
                btnConnectPLC.Text = "Connected";
                btnScanREG.Enabled = true;
            }
            else
            {
                btnConnectPLC.Text = "Connect";
                btnRead.Enabled = btnWrite.Enabled = false;
                btnScanREG.Enabled = false;
            }
        }
        private void txtPLCAdress_TrailingIconClick(object sender, EventArgs e)
        {
            txtPLCAdress.Text = "";
        }

        private void txtPLCVal_TrailingIconClick(object sender, EventArgs e)
        {
            txtPLCVal.Text = "";
        }

        private void txtPLCVal_LeadingIconClick(object sender, EventArgs e)
        {
            if(txtPLCVal.Text == "1")
            {
                txtPLCVal.Text = "0";
            }
            else
            {
                txtPLCVal.Text = "1";
            }
        }

       
    }
}
