using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using TanHungHa.Common.PLC;
using TanHungHa.Common.TaskLoopCustomize;
using TanHungHa.Tabs;
using TanHungHa.Tabs.ManualTab;
using static MaterialSkin.Controls.MaterialForm;

namespace TanHungHa.Common
{
    public enum eTaskLoop
    {
        Task_HEATBEAT,
        Task_RS232,
        Task_PLC,
        Task_Vision_Tape,
        Task_Vision_Jig,
        Task_Teaching,
        TaskIO,
        Task_LineScan,
        Task_LineScan_Merge,
        Task_IO
    }

   
    
    
    
    public enum eProcessing
    {
        None = 0,

        CheckConditionToRun,
        
        WaitSignalFromRobot,
        
        GripperIn1,
        WaitGripperIn1Done,
        
        TransferIn,
        WaitTransferInDone,
        
        CylinderDown,
        WaitCylinderDownDone,

        GripperOut1,
        WaitGripperOut1Done,

        EziRun,                     //Trigger On Vision
        WaitEziDone,
        
        EziStop,                    //Trigger Off Vision
        WaitEziStopDone,
        
        CylinderUp,
        WaitCylinderUpDone,

        GripperIn2,
        WaitGripperIn2Done,

        TransferOut,
        WaitTransferOutDone,

        GripperOut2,
        WaitGripperOut2Done,

        WaitVisionResult,
        SendResultToRobot,

        Finish

    }

    public class StepControl
    {
        public eProcessing Cur_Processing;
        public eProcessing Old_Processing;


        [JsonIgnore]
        public Stopwatch watchTimeprocess;

        public StepControl()
        {
            Cur_Processing = eProcessing.None;
            Old_Processing = eProcessing.None;
            watchTimeprocess = new Stopwatch();
        }

        public void SetStep(eProcessing step)
        {
            if (Cur_Processing == step)
            {
                Console.WriteLine("Dupplicate Step");
                return;
            }
            //Update step
            Old_Processing = Cur_Processing;
            Cur_Processing = step;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Old step = {Old_Processing}");
            Console.WriteLine($"Cur step = {Cur_Processing}");
        }
    }

    public class PineLine
    {
        //1. Camera  - Image
        //2. Process
        //3. Comport
    }
    public class ToolblockParam
    {
        public string path;
        public string isUsing;
    }

    public class TimeDelay
    {
        public int timeOut { get; set; }
        public int timeLoop { get; set; }
        public int delayReadPLC { get; set; }
        public int delayHeatbeat { get; set; }
        public int delayGripper { get; set; }
        public int delayTranfer { get; set; }
        public int delayCylinderUpDown { get; set; }
        public int delayRotation { get; set; }
        public int delayTrasferTimeOut { get; set; }
        public int delayEziRun { get; set; }


        public TimeDelay()
        {
            timeLoop = 50;
            timeOut = 1000;
            delayReadPLC = 50;
            delayHeatbeat = 1000;

            delayGripper = 1000;
            delayTranfer = 1000;
            delayCylinderUpDown = 1000;
            delayRotation = 1000;
            delayTrasferTimeOut = 1000;

            delayEziRun = 2000;
        }
    }


    public class CommonParam
    {
        private static CommonParam _instance;
        private static readonly object _lock = new object();
        public static CommonParam GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CommonParam();
                    }
                }
            }
            return _instance;
        }


        //--------------------Variable------------------
        public MyComport myComport { get; set; }
        public PLCParameter PLCParam { get; set; }
       
        public DevParam devParam {get; set;}
        public TimeDelay timeDelay { get; set; }


        [JsonIgnore]
        public Queue<string> queueData;
        [JsonIgnore]
        public object queueLock;
        public string ToolBlockPath { get; set; }
        

        //--------------------------------------------
        CommonParam()
        {

            devParam = DevParam.GetInstance();
            timeDelay = new TimeDelay();
            myComport = MyComport.GetInstance();
            PLCParam = PLCParameter.GetInstance();

            queueData = new Queue<string>(MyDefine.MAX_QUEUE_DATA);
            queueLock = new object();
            ToolBlockPath = "D:\\Git\\THH-Dev\\Phoxi3DApp\\ApplicationPackage\\Configs\\exhiToolB.vpp";
        }
    }
    
    



    
    

    public enum eMainView
    {
        AUTO_VIEW,
        MANUAL_VIEW,
        TEACHING_VIEW,
        MANAGER_VIEW,
        LOGGING_VIEW,
        INFOR_VIEW,
        EXIT_VIEW
    }
    
    public enum eManagerView
    {
        MANAGER_PARAMTER_VIEW,
        MANAGER_MODEL_VIEW,
        MANAGER_THEME_VIEW
    }

    public static class MyParam
    {
        static int number_create = 0;
        public static List<TaskLoop> taskLoops = new List<TaskLoop>();
        public static MaterialSkinManager materialSkinManager;
        
        [JsonIgnore]
        public static eMainView curMainView = eMainView.AUTO_VIEW;
        
        [JsonIgnore]
        public static eManagerView curManagerView = eManagerView.MANAGER_PARAMTER_VIEW;

        //[TypeConverter(typeof(PLCAssignmentCvt))]
        //public static List<PLCAssignment> list_plc_assignment = new List<PLCAssignment>();

        public static List<PLCRegister> list_plc_reg = new List<PLCRegister>();

        public static UIParam uIParam = null;
        public static CommonParam commonParam = null;
        public static RunParam runParam = null;


        public static FormAuto autoForm = null;
        public static FormInfo infoForm = null;
        public static FormLog logForm = null;
        public static FormManager managerForm = null;
        public static FormManual manualForm = null;
        public static FormMain mainForm = null;


        //sub tab of Manual TAB
        public static RS232Form tabRS232 = null;
        public static PLCForm tabPLC = null;
        public static CameraForm tabCamera = null;




        //sub tab of Manager TAB
        public static ManParamForm tabManagerParam = null;
        public static ManThemeForm tabManagerTheme = null;



        public static void initial()
        {
            //task
            for (int i = 0; i < MyDefine.NUM_THREAD; i++)
            {
                taskLoops.Add(new TaskLoop());
            }

            //param
            uIParam = UIParam.GetInstance();
            commonParam = CommonParam.GetInstance();
            runParam = RunParam.GetInstance();

            //form
            tabRS232 = RS232Form.GetInstance();
            tabPLC = PLCForm.GetInstance();
            tabCamera = CameraForm.GetInstance();
            

            //manual
            tabManagerParam = ManParamForm.GetInstance();
            tabManagerTheme = ManThemeForm.GetInstance();

            autoForm = FormAuto.GetInstance();
            infoForm = FormInfo.GetInstance();
            logForm = FormLog.GetInstance();
            managerForm = FormManager.GetInstance();
            manualForm = FormManual.GetInstance();
            mainForm = FormMain.GetInstance();

        }
        static MyParam()
        {
            Console.WriteLine($"Constructor MyParam = {number_create++}");
            initial();
        }
    }

    public class UIParam
    {
        private static UIParam _instance;
        private static readonly object _lock = new object();
        public static UIParam GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UIParam();
                    }
                }
            }
            return _instance;
        }
        public MaterialSkinManager.Themes themes { get; set; }
        public MaterialForm.FormStyles styles { get; set; }
        public bool swUserColors { get; set; }
        public bool swHighlightWithAccent { get; set; }
        public bool swBackgroundWithAccent { get; set; }
        public bool swDisplayIconWhenHidden { get; set; }
        public bool swAutoShow { get; set; }
        public int colorSchemeIndex { get; set; }

        UIParam()
        {
            themes = MaterialSkinManager.Themes.LIGHT;
            styles = FormStyles.StatusAndActionBar_None;
            swUserColors = true;
            swHighlightWithAccent = true;
            swBackgroundWithAccent = true;
            swDisplayIconWhenHidden = true;
            swAutoShow = true;
            colorSchemeIndex = 2;
        }


    }
}
