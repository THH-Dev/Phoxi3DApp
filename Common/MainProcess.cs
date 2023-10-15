using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using TanHungHa.Common.PLC;

namespace TanHungHa.Common
{
    public enum eCamSide
    {
        CAM_NONE,
        CAM_TAPE,
        CAM_JIG,
        CAM_BOTH,
        CAM_TAPE_TEACHING,
        CAM_TAPE_CALIB,
        CAM_JIG_CALIB
    }
    public class MainProcess
    {
        //string codeData = null;
        public static MyPLC myPLC = MyPLC.GetInstance();

        public static StepControl MainTape_StepCtrl = new StepControl();
        public static StepControl MainJig_StepCtrl = new StepControl();
        public static StepControl MainIO_StepCtrl = new StepControl();
        public string TAG = null;
        public MainProcess()
        {
            MainTape_StepCtrl.Cur_Processing = eProcessing.None;
            MainJig_StepCtrl.Cur_Processing = eProcessing.None;
            MainIO_StepCtrl.Cur_Processing = eProcessing.None;
            TAG = "TuanNA";
        }


       


        public static void AddLogAuto(string message, eCamSide side = eCamSide.CAM_TAPE)
        {
            //if (!MyParam.autoForm.IsHandleCreated) return;
            switch (side)
            {
                case eCamSide.CAM_TAPE:
                    MyLib.ShowLogListview(MyParam.autoForm.lvLogCamTape, message);
                    break;

                case eCamSide.CAM_JIG:
                    MyLib.ShowLogListview(MyParam.autoForm.lvLogCamJig, message);
                    break;

                case eCamSide.CAM_BOTH:
                    MyLib.ShowLogListview(MyParam.autoForm.lvLogCamTape, message);
                    MyLib.ShowLogListview(MyParam.autoForm.lvLogCamJig, message);
                    break;
                default:
                    break;
            }
            MyLib.log(message, SvLogger.LogType.SEQUENCE);
        }

        
        #region RS232
        public static void StopLoopRS232()
        {
            MyParam.taskLoops[(int)eTaskLoop.Task_RS232].StopLoop();
        }
        public static void RunLoopRS232()
        {
            MyParam.taskLoops[(int)eTaskLoop.Task_RS232].ResetToken();
            MyParam.taskLoops[(int)eTaskLoop.Task_RS232].RunLoop(MyParam.commonParam.timeDelay.timeLoop, LoopProcessRS232).ContinueWith((a) =>
            {
                MyLib.showDlgInfo($"Done task!");
            });

        }

        public static void LoopProcessRS232()
        {
            lock (MyParam.commonParam.queueLock)
            {
                int queueSize = MyParam.commonParam.queueData.Count;
                if (queueSize > 0)
                {
                    var data = MyParam.commonParam.queueData.Dequeue();
                    //MyParam.tabRS232.setText(data);
                }
            }
        }
        #endregion End RS232


        #region Heartbeat
        //Thread scan RAM
        public static Process cur = null;
        public static PerformanceCounter curpcp = null;
        //private static PerformanceCounter myAppCpu = null;
        public const int MB_DIV = 1024 * 1024;

        public static void StopLoopHeartbeat()
        {
            MyParam.taskLoops[(int)eTaskLoop.Task_HEATBEAT].StopLoop();
        }
        public static bool RunLoopHeartBeat()
        {
            try
            {
                //RAM
                //myAppCpu = new PerformanceCounter("Process", "% Processor Time", cur.ProcessName);
                //myAppCpu.NextValue();
                cur = Process.GetCurrentProcess();
                curpcp = new PerformanceCounter("Process", "Working Set - Private", cur.ProcessName);
                Console.WriteLine("----------------------");


            }
            catch
            {

            }



#if !TEST
            MyParam.taskLoops[(int)eTaskLoop.Task_HEATBEAT].ResetToken();
            MyParam.taskLoops[(int)eTaskLoop.Task_HEATBEAT].RunLoop(MyParam.commonParam.timeDelay.delayHeatbeat, LoopProcessHEARTBEAT).ContinueWith((a) =>
            {
                //MyLib.showDlgInfo($"Done task Task_RESOURCE!");
                MyLib.log("Done task Task_RESOURCE!");
            });
#else
            MyParam.taskLoops[(int)eTaskLoop.Task_HEATBEAT].ResetToken();
            _ = MyParam.taskLoops[(int)eTaskLoop.Task_HEATBEAT].RunLoop(MyParam.commonParam.timeDelay.delayHeatbeat, LoopProcessHEARTBEAT);
#endif

            return true;
        }

        public static int iCountFailHeartBear = 0;
        public static void LoopProcessHEARTBEAT()
        {
            //RAM
            string RamInfo = "";
            if (curpcp != null)
            {
                RamInfo = (curpcp.NextValue() / MB_DIV).ToString("F1") + "MB";
            }

            //Camera Tape
            /*string camTape = $"(CamTape Open:{MyParam.runParam.camTape.IsOpen}, Ready:{MyParam.runParam.camTape.IsCamReady})";
            if (!MyParam.runParam.camTape.IsOpen)
            {
                if (MyParam.list_plc_reg[(int)eIndex.IsVisionTapeReady].Value == MyDefine.VISION_READY)
                {
                    WriteDataToPLC.WriteVisionNotReady(eCamSide.CAM_TAPE, eMainView.AUTO_VIEW);
                }

                if (MyParam.runParam.ProgramStatus == ePRGSTATUS.Started)
                {
                    iCountFailHeartBear++;
                    if (iCountFailHeartBear >= MyDefine.NUM_FAIL_HEART_BEAR)
                    {
                        iCountFailHeartBear = 0;
                        AddLogAuto($"CAMERA TAPE = FALSE, CHECK CONNECTION PLS!", eCamSide.CAM_TAPE);
                        MyParam.autoForm.StopProgram();
                    }
                }
            }*/

            //camera Jig
            /*string camJig = $"(CamJig Open:{MyParam.runParam.camJig.IsOpen}, Ready:{MyParam.runParam.camJig.IsCamReady})";
            if (!MyParam.runParam.camJig.IsOpen)
            {
                if (MyParam.list_plc_reg[(int)eIndex.IsVisionJigReady].Value == MyDefine.VISION_READY)
                {
                    WriteDataToPLC.WriteVisionNotReady(eCamSide.CAM_JIG, eMainView.AUTO_VIEW);
                }

                if (MyParam.runParam.ProgramStatus == ePRGSTATUS.Started)
                {
                    iCountFailHeartBear++;
                    if (iCountFailHeartBear >= MyDefine.NUM_FAIL_HEART_BEAR)
                    {
                        iCountFailHeartBear = 0;
                        AddLogAuto($"CAMERA JIG = FALSE, CHECK CONNECTION PLS!", eCamSide.CAM_TAPE);
                        MyParam.autoForm.StopProgram();
                    }
                }
            }*/


            //PLC
            string plcStatus = myPLC.Ping();
            if (!MyParam.commonParam.devParam.ignorePLC)
            {
                if (plcStatus == MyDefine.PLC_DISCONNECT
                && MyParam.runParam.ProgramStatus == ePRGSTATUS.Started)
                {

                    iCountFailHeartBear++;
                    if (iCountFailHeartBear >= MyDefine.NUM_FAIL_HEART_BEAR)
                    {
                        iCountFailHeartBear = 0;
                        AddLogAuto($"PLC = FALSE, CHECK CONNECTION PLS!", eCamSide.CAM_TAPE);
                        AddLogAuto($"PLC = FALSE, CHECK CONNECTION PLS!", eCamSide.CAM_JIG);
                        MyParam.autoForm.StopProgram();
                    }
                }
            }

            //Controller
            //string controllerStatus = $"(LightCtrl Open:{MyParam.commonParam.dpsController.GetStatus()})";

            //Controller

            if (!MyParam.mainForm.IsHandleCreated)
                return;
            if (MyParam.mainForm.statusStrip1.InvokeRequired)
            {
                MyParam.mainForm.statusStrip1.BeginInvoke(new Action(() =>
                {
                    MyParam.mainForm.sttRAM.Text = $"(RAM: {RamInfo})";
                    /*MyParam.mainForm.sttCamTape.Text = camTape;
                    MyParam.mainForm.sttCamJig.Text = camJig;*/
                    MyParam.mainForm.sttPLC.Text = plcStatus;
                    //MyParam.mainForm.sttController.Text = controllerStatus;
                }));

            }

        }
        #endregion

        #region PLC
        //Thread scan PLC
        public static bool isRunLoopPLC = false;
        public static void StopLoopPLC()
        {
            MyParam.taskLoops[(int)eTaskLoop.Task_PLC].StopLoop();
            isRunLoopPLC = false;
        }
        public static void RunLoopPLC()
        {
            if (isRunLoopPLC)
            {
                MyLib.showDlgWarning("Loop PLC is running!");
                return;
            }

#if !TEST
            MyParam.taskLoops[(int)eTaskLoop.Task_PLC].ResetToken();
            MyParam.taskLoops[(int)eTaskLoop.Task_PLC].RunLoop(MyParam.commonParam.timeDelay.timeLoop, LoopProcessPLC).ContinueWith((a) =>
            {
                //MyLib.log($"Done task PLC!");
                MyLib.log($"Done task PLC!");
            });
#else
            MyParam.taskLoops[(int)eTaskLoop.Task_PLC].ResetToken();
            _ = MyParam.taskLoops[(int)eTaskLoop.Task_PLC].RunLoop(MyParam.commonParam.timeDelay.timeLoop, LoopProcessPLC);
#endif

            isRunLoopPLC = true;

        }

        public static void LoopProcessPLC()
        {
            //Thread.Sleep(100);
            if (!MyPLC.GetInstance().IsConnected())
            {
                StopLoopPLC();
            }

            //Get value
            foreach (var plc in MyParam.list_plc_reg)
            {
                _ = plc.GetValue();
            }

        }
        #endregion End PLC

        //Thread Vision
        public static bool isRunLoopVision = false;
        public static void StopLoopVision()
        {
            MyParam.taskLoops[(int)eTaskLoop.Task_Vision_Tape].StopLoop();
            MyParam.taskLoops[(int)eTaskLoop.Task_Vision_Jig].StopLoop();
            isRunLoopVision = false;
        }
        public static void RunLoopVision()
        {
            if (isRunLoopVision)
            {
                MyLib.showDlgWarning("Loop Vision is running!");
                return;
            }

#if !TEST
            //Tape
            MyParam.taskLoops[(int)eTaskLoop.Task_Vision_Tape].ResetToken();
            MyParam.taskLoops[(int)eTaskLoop.Task_Vision_Tape].RunLoop(MyParam.commonParam.timeDelay.timeLoop, LoopProcessVisionTape).ContinueWith((a) =>
            {
                MyLib.log($"Done task Vision Tape!");
            });

            //Jig
            MyParam.taskLoops[(int)eTaskLoop.Task_Vision_Jig].ResetToken();
            MyParam.taskLoops[(int)eTaskLoop.Task_Vision_Jig].RunLoop(MyParam.commonParam.timeDelay.timeLoop, LoopProcessVisionJig).ContinueWith((a) =>
            {
                MyLib.log($"Done task Vision Jig!");
            });
#else
            //Tape
            MyParam.taskLoops[(int)eTaskLoop.Task_Vision_Tape].ResetToken();
            _ = MyParam.taskLoops[(int)eTaskLoop.Task_Vision_Tape].RunLoop(MyParam.commonParam.timeDelay.timeLoop, LoopProcessVisionTape);

            //Jig
            MyParam.taskLoops[(int)eTaskLoop.Task_Vision_Jig].ResetToken();
            _ = MyParam.taskLoops[(int)eTaskLoop.Task_Vision_Jig].RunLoop(MyParam.commonParam.timeDelay.timeLoop, LoopProcessVisionJig);
#endif
            isRunLoopVision = true;
        }

        public static void LoopProcessVisionTape()
        {
            switch (MyParam.curMainView)
            {
                case eMainView.AUTO_VIEW:
                    break;

                case eMainView.MANUAL_VIEW:
                    break;

                case eMainView.TEACHING_VIEW:
                    break;
            }
        }
        public static void LoopProcessVisionJig()
        {
            switch (MyParam.curMainView)
            {
                case eMainView.AUTO_VIEW:
                    break;

                case eMainView.MANUAL_VIEW:
                    break;

                case eMainView.TEACHING_VIEW:
                    break;
            }
        }




       

    }
}
