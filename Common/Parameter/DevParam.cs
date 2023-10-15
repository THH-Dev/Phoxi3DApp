using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanHungHa.Common
{
    public class DevParam
    {
        private static DevParam _instance;
        private static readonly object _lock = new object();
        public static DevParam GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DevParam();
                    }
                }
            }
            return _instance;
        }


        //--------------------Variable------------------

        [Category("Layout"), DescriptionAttribute("Layout size when zoom out")]
        public Size LayoutMax { get; set; }
        [Category("Layout"), DescriptionAttribute("Layout size when zoom in")]
        public Size LayoutMin { get; set; }
        [Category("Layout"), DescriptionAttribute("Show/Hide Trigger button")]
        public bool EnableTriggerBtn { get; set; }
        
        [Category("Common Param"), DescriptionAttribute("Save Job when close application")]
        public bool IsSaveJobBeforeClose { get; set; }
        
        [Category("Common Param"), DescriptionAttribute("Program will stop when loss connection with PLC, if IgnorePLC program still run without plc")]
        public bool ignorePLC { get; set; }

        [Category("Common Param"), DescriptionAttribute("CamJig always send OK to PLC")]
        public bool ignoreCamJig { get; set; }
        [Category("Common Param"), DescriptionAttribute("Don't notify over value when write to PLC")]
        public bool mutePLCOverValue { get; set; }
        [Category("Common Param"), DescriptionAttribute("If have dongle-key, set to True, else set to False")]
        public bool isUsingDongleKey { get; set; }

        [Category("Common Param"), DescriptionAttribute("Save Image when camera trigger")]
        public bool isUsingGrabMode { get; set; }  
        
        private int numFile;
        private int daySaveImage;
        
        [Category("Logging Param"), DescriptionAttribute("Max log file can save")]
        public int iNumberSaveFileLog
        {
            get { return numFile; }
            set
            {
                if (value != numFile)
                {
                    if (value > 0)
                    {
                        numFile = value;
                    }
                    else
                    {
                        numFile = 7;
                    }
                }

            }
        }
        
        
        

        [Category("Logging Param"), DescriptionAttribute("Max log day can save")]
        public int iDateSaveImage
        {
            get { return daySaveImage; }
            set
            {
                if (value != daySaveImage)
                {
                    if (value > 0)
                    {
                        daySaveImage = value;
                    }
                    else
                    {
                        daySaveImage = 7;
                    }
                }

            }
        }

        [Category("Logging Param"), DescriptionAttribute("Hide date in log line")]
        public bool hideDate
        {
            get; set;
        }

        [Category("Logging Param"), DescriptionAttribute("Max log line in listview")]
        public int maxLine
        {
            get; set;
        }

        [Category("Logging Param"), DescriptionAttribute("Thresh to consider jig NG")]
        public float jigAccuracy
        {
            get; set;
        }



        [Category("Debug Param"), DescriptionAttribute("Auto/Manual read Row Target")]
        public bool bModeAuto
        {
            get; set;
        }

        //--------------------------------------------
        DevParam()
        {
            isUsingGrabMode = false;
            isUsingDongleKey = false;
            IsSaveJobBeforeClose = false;
            LayoutMax = new Size(100, 1500);
            LayoutMin = new Size(400, 1050);
            iNumberSaveFileLog = 30;
            iDateSaveImage = 30;

            maxLine = 1000;
            hideDate = true;
            bModeAuto = false;
            ignoreCamJig = false;
            ignorePLC = false;
            mutePLCOverValue = false;
            jigAccuracy = 0.05f;
            EnableTriggerBtn = false;
        }
    }

}
