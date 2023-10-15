using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;


namespace TanHungHa.Common
{
    public enum ePRGSTATUS
    {
        Start_Up,
        Initial,
        Started,
        Stoped,
        Reset
    }

    public class RunParam
    {
        private static RunParam _instance;
        private static readonly object _lock = new object();
        public static RunParam GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new RunParam();
                    }
                }
            }
            return _instance;
        }

        [JsonIgnore]
        [Browsable(false)]
        public bool isLoadSol = false;
        
        [JsonIgnore]
        [Browsable(false)]
        public string robotMessage = String.Empty;
        
        [JsonIgnore]
        [Browsable(false)]
        public bool visionResult = false;

        [JsonIgnore]
        public Stopwatch ioWatchTimeout;

        [JsonIgnore]
        [Browsable(false)]
        public ePRGSTATUS ProgramStatus = ePRGSTATUS.Start_Up;

       

        [Category("Logging"), DescriptionAttribute("Path Output Image, which processed and render")]
        public string ImagePath { get; set; }

        [Category("Logging"), DescriptionAttribute("Path Original Image when camera trigger")]
        public string ImageGrabPath { get; set; }

        [Category("Logging"), DescriptionAttribute("Enable Save Image Output, which processed")]
        public bool SaveImage { get; set; }

       

        //--------------------------------------------
        RunParam()
        {
            SaveImage = false;
            isLoadSol = false;
            

            ImagePath = MyDefine.path_save_images;
            ImageGrabPath = MyDefine.path_grab_images;
            

            //robot | vision | io
            robotMessage = String.Empty;
            visionResult = false;
            ioWatchTimeout = new Stopwatch();
    }



    }
}
