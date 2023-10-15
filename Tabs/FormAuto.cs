using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanHungHa.Common;
using TanHungHa.Common.PLC;
using TanHungHa.Common.TaskCustomize;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TanHungHa.Tabs
{
    public partial class FormAuto : MaterialForm
    {
        private static FormAuto _instance;
        private static readonly object _lock = new object();
        public static FormAuto GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {

                    if (_instance == null)
                    {
                        _instance = new FormAuto();
                    }
                }
            }
            return _instance;
        }

        public FormAuto()
        {
            InitializeComponent();
            
        }

        public void StopProgram()
        {
            if(btnStart.InvokeRequired)
            {
                btnStart.BeginInvoke(new Action(() =>
                {
                    btnStart.Enabled = true;
                }));
            }
            else
            {
                btnStart.Enabled = true;
            }
            
            if(btnStop.InvokeRequired)
            {
                btnStop.BeginInvoke(new Action(() =>
                {
                    btnStop.Enabled = true;
                }));
            }
            else
            {
                btnStop.Enabled = true;
            }
            
            MainProcess.MainTape_StepCtrl.SetStep(eProcessing.None);
            MainProcess.MainJig_StepCtrl.SetStep(eProcessing.None);

            //send to plc
            //Set Vision free
            WriteDataToPLC.WriteVisionFree(eCamSide.CAM_TAPE, eMainView.AUTO_VIEW);
            WriteDataToPLC.WriteVisionFree(eCamSide.CAM_JIG, eMainView.AUTO_VIEW);
            
            //Set Vision not ready
            WriteDataToPLC.WriteVisionNotReady(eCamSide.CAM_TAPE, eMainView.AUTO_VIEW);
            WriteDataToPLC.WriteVisionNotReady(eCamSide.CAM_JIG, eMainView.AUTO_VIEW);

            MainProcess.StopLoopPLC();
            MainProcess.StopLoopVision();

            MainProcess.AddLogAuto($"-----------Stop Vision-----------", eCamSide.CAM_TAPE);
            MainProcess.AddLogAuto($"-----------Stop Vision-----------", eCamSide.CAM_JIG);

            MyParam.runParam.ProgramStatus = ePRGSTATUS.Stoped;
        }

        void StartProgram()
        {
            //init VM
            /*if (!MyParam.runParam.camTape.IsInitVM)
            {
                MyParam.runParam.camTape.InitVM();
            }

            if (!MyParam.runParam.camJig.IsInitVM)
            {
                MyParam.runParam.camJig.InitVM();
            }*/

            ////Start loop
            MainProcess.RunLoopPLC();

            MainProcess.MainIO_StepCtrl.SetStep(eProcessing.CheckConditionToRun);


            //btnStart.Enabled = false;
            if (btnStart.InvokeRequired)
            {
                btnStart.BeginInvoke(new Action(() =>
                {
                    btnStart.Enabled = false;
                }));
            }
            else
            {
                btnStart.Enabled = false;
            }
            //btnStop.Enabled = true;
            if (btnStop.InvokeRequired)
            {
                btnStop.BeginInvoke(new Action(() =>
                {
                    btnStop.Enabled = true;
                }));
            }
            else
            {
                btnStop.Enabled = true;
            }

            MyParam.runParam.ProgramStatus = ePRGSTATUS.Started;
        }

        public async void InititalProgram()
        {
            bool bEnableInit = false;
            if(MyParam.runParam.ProgramStatus == ePRGSTATUS.Start_Up ||
                MyParam.runParam.ProgramStatus == ePRGSTATUS.Reset)
            {
                bEnableInit = true;
            }

            if(!bEnableInit)
            {
                MyLib.showDlgWarning("Please RESET program and try again!");
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            var x = THHInitial.InitDevice();
            await x;
            Console.WriteLine("-------------btnInitial = " + x.Result);
            MainProcess.AddLogAuto($"Initial Device = {x.Result}, press Start to Run", eCamSide.CAM_TAPE);
            MainProcess.AddLogAuto($"Initial Device = {x.Result}, press Start to Run", eCamSide.CAM_JIG);

            btnStart.Enabled = true;
            if (x.Result)
            {
                btnInitial.Enabled = false;
                //btnStart.Enabled = true;
                btnRestart.Enabled = true;
                btnStop.Enabled = false;
            }
            else
            {
                //btnStart.Enabled = false;
                btnRestart.Enabled = true;
                btnStop.Enabled = false;
            }
            MyParam.runParam.ProgramStatus = ePRGSTATUS.Initial;
            this.Cursor = Cursors.Default;
        }

        void ResetProgram()
        {
            //Stop program
            StopProgram();

            //Reset Connection

            this.Cursor = Cursors.WaitCursor;
            /*
            //Write not ready to PLC
            WriteDataToPLC.WriteVisionNotReady(eCamSide.CAM_TAPE, eMainView.AUTO_VIEW);
            WriteDataToPLC.WriteVisionNotReady(eCamSide.CAM_JIG, eMainView.AUTO_VIEW);
            //Set Vision free
            WriteDataToPLC.WriteVisionFree(eCamSide.CAM_TAPE, eMainView.AUTO_VIEW);
            WriteDataToPLC.WriteVisionFree(eCamSide.CAM_JIG, eMainView.AUTO_VIEW);*/

            Thread.Sleep(50);
            //Close all connection
            MyLib.CloseAllDevices((int)eTaskLoop.Task_HEATBEAT);
            MainProcess.isRunLoopVision = false;
            MainProcess.isRunLoopPLC = false;

            btnInitial.Enabled = true;
            btnStart.Enabled = false;
            btnRestart.Enabled = false;
            btnStop.Enabled = false;

            MainProcess.AddLogAuto($"-----------Release all connection, Please initital and start-----------", eCamSide.CAM_TAPE);
            MainProcess.AddLogAuto($"-----------Release all connection, Please initital and start-----------", eCamSide.CAM_JIG);
            
            MyParam.runParam.ProgramStatus = ePRGSTATUS.Reset;
            this.Cursor = Cursors.Default;
        }

        private  void btnProgramAction(object sender, EventArgs e)
        {
            var btnName = ((MaterialButton)sender).Name;
            switch (btnName)
            {
                case "btnModel":
                    break;

                case "btnTrigger":
                    break;

                case "btnStop":
                    StopProgram();
                    break;

                case "btnInitial":
                    InititalProgram();
                    break;

                case "btnStart":
                    StartProgram();
                    break;

                case "btnRestart":
                    ResetProgram();
                    break;
            }
        }

        public void Display(Bitmap bitmap, eCamSide eCam)
        {
            switch (eCam)
            {
                case eCamSide.CAM_TAPE:
                    pictureBoxCamTape.Image?.Dispose();
                    pictureBoxCamTape.Image = bitmap;
                    pictureBoxCamTape.Invalidate();
                    break;

                case eCamSide.CAM_JIG:
                    pictureBoxCamJig.Image?.Dispose();
                    pictureBoxCamJig.Image = bitmap;
                    pictureBoxCamJig.Invalidate();
                    break;

            }
        }


        private void contextMenuStripTape_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.WriteLine(e.ClickedItem.Name);
            switch (e.ClickedItem.Name)
            {
                case "clearLogTapeToolStripMenuItem":
                    lvLogCamTape.Items.Clear();
                    break;
                case "openImageTapeToolStripMenuItem":
                    if (lvLogCamTape.SelectedItems.Count > 0)
                    {
                        var item = lvLogCamTape.SelectedItems[0];
                        Console.WriteLine(item.Text);
                        Console.WriteLine(item.SubItems[1].Text);
                        var x = MyLib.getImagePath(item.SubItems[1].Text);
                        try
                        {
                            Console.WriteLine(x);
                            Process.Start(x);
                        }
                        catch { }
                    }
                    break;
            }
        }

        private void contextMenuStripJig_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.WriteLine(e.ClickedItem.Name);
            switch (e.ClickedItem.Name)
            {
                case "clearLogJigToolStripMenuItem":
                    lvLogCamJig.Items.Clear();
                    break;
                case "openImageJigToolStripMenuItem":
                    if (lvLogCamJig.SelectedItems.Count > 0)
                    {
                        var item = lvLogCamJig.SelectedItems[0];
                        Console.WriteLine(item.Text);
                        Console.WriteLine(item.SubItems[1].Text);
                        var x = MyLib.getImagePath(item.SubItems[1].Text);
                        try
                        {
                            Console.WriteLine(x);
                            Process.Start(x);
                        }
                        catch { }
                    }
                    break;
            }
        }
        

        

        public void AddLogAuto(string message)
        {
            MyLib.ShowLogListview(MyParam.autoForm.lvLogJig, message);
            MyLib.log(message, SvLogger.LogType.RECIPE);
        }


        private void btnTrigger_Click(object sender, EventArgs e)
        {
            
        }

       
       
    }
}
