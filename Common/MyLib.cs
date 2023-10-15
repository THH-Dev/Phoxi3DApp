﻿using MaterialSkin;
using MaterialSkin.Controls;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using TanHungHa.Common.phoxi3D;
using TanHungHa.Common.PLC;
using TanHungHa.Tabs.UC;


namespace TanHungHa.Common
{    
    public static class MyLib
    {

        #region Fake keyboard
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);


        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);


        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);


        #endregion

        public static int[] text2arr(string text, int length)
        {
            int[] arr = new int[length];

            if (text == null | !text.Contains(","))
                return arr;

            var x = text.Split(',');
            for (int i = 0; i < x.Length; i++)
                arr[i] = int.Parse(x[i]);
            return arr;
        }

        static Random rnd = new Random();
        public static string GetRandomImg(string dir = "C:\\Users\\Admin\\Desktop\\Alignment\\jig", string extension = "*.bmp")
        {
            try
            {
                string[] fileArray = Directory.GetFiles(dir, extension);
                if (fileArray.Length > 0)
                {
                    int index = rnd.Next(0, fileArray.Length);
                    return fileArray[index];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MyLib.log(ex.Message, SvLogger.LogType.ERROR);
                return null;
            }
              
        }


        

        public static bool fileIsExists(string file_name)
        {
            return File.Exists(file_name);
        }
        
        


        public static void CloseAllDevices()
        {
            //disconnect camera manual task
            PhoxiFunc._phoXiDevice.Disconnect();

            //Disconnect comport
            MyComport.GetInstance().DisConnect();

            //Disconnect plc
            MyPLC.GetInstance().DisconnectPLC();
            
            //close all task
            for (int i = 0; i < MyDefine.NUM_THREAD; i++)
            {
                MyParam.taskLoops[i].StopLoop();
                //Thread.Sleep(100);
            }
            

            
        }
        
        public static void CloseAllDevices(int ignoreThread)
        {
            //close all task
            for (int i = 0; i < MyDefine.NUM_THREAD; i++)
            {
                if (i == ignoreThread)
                    continue;
                MyParam.taskLoops[i].StopLoop();
                //Thread.Sleep(100);
            }

            //disconnect camera manual task
            PhoxiFunc._phoXiDevice.Disconnect();

            //Disconnect comport
            MyComport.GetInstance().DisConnect();

            //Disconnect plc
            MyPLC.GetInstance().DisconnectPLC();


        }
        public static void SaveParamter()
        {
            SaveLoadParameter.Save_Parameter(MyParam.uIParam, MyDefine.file_uiParam);
            SaveLoadParameter.Save_Parameter(MyParam.commonParam, MyDefine.file_config);
            SaveLoadParameter.Save_Parameter(MyParam.runParam, MyDefine.file_runParam);

        }

        public static void LoadParameter()
        {
            MyParam.uIParam = SaveLoadParameter.Load_Parameter(MyParam.uIParam, MyDefine.file_uiParam) as UIParam;
            if (MyParam.uIParam == null)
            {
                MyParam.uIParam = UIParam.GetInstance();
                //MyLib.showDlgError("Create default uiParam");
                ShowInfo("Create default uiParam");
            }
            
            MyParam.commonParam = SaveLoadParameter.Load_Parameter(MyParam.commonParam, MyDefine.file_config) as CommonParam;
            if (MyParam.commonParam == null)
            {
                MyParam.commonParam = CommonParam.GetInstance();
                //MyLib.showDlgError("Create default commonParam");
                ShowInfo("Create default commonParam");
            }
            
            MyParam.runParam = SaveLoadParameter.Load_Parameter(MyParam.runParam, MyDefine.file_runParam) as RunParam;
            if (MyParam.runParam == null)
            {
                MyParam.runParam = RunParam.GetInstance();
                ShowInfo("Create default runParam");
            }
            
            

            MyParam.list_plc_reg = MyLib.GetListPLCREG();
        }


        public static void showDlgError(string message)
        {
            if (MyParam.mainForm == null)
            {
                SvLogger.Log.Debug("MyParam.mainForm = null, at MyLib::ShowInfo");
                return;
            }

            if (!MyParam.mainForm.IsHandleCreated)
                return;

            if (MyParam.mainForm.InvokeRequired)
            {
                MyParam.mainForm.BeginInvoke(new Action(() =>
                {
                    MaterialDialog materialDialog = new MaterialDialog(MyParam.mainForm, "Error", message, "OK");
                    DialogResult result = materialDialog.ShowDialog(MyParam.mainForm);
                }));
            }
            else
            {
                MaterialDialog materialDialog = new MaterialDialog(MyParam.mainForm, "Error", message, "OK");
                DialogResult result = materialDialog.ShowDialog(MyParam.mainForm);
            }


        }

        public static void showDlgWarning(string message)
        {
            if (MyParam.mainForm == null)
            {
                SvLogger.Log.Debug("MyParam.mainForm = null, at MyLib::ShowInfo");
                return;
            }

            if (MyParam.mainForm.InvokeRequired)
            {
                MyParam.mainForm.BeginInvoke(new Action(() =>
                {
                    MaterialDialog materialDialog = new MaterialDialog(MyParam.mainForm, "Warning", message, "OK");
                    DialogResult result = materialDialog.ShowDialog(MyParam.mainForm);
                }));
            }
            else
            {
                MaterialDialog materialDialog = new MaterialDialog(MyParam.mainForm, "Warning", message, "OK");
                DialogResult result = materialDialog.ShowDialog(MyParam.mainForm);
            }

        }

        public static void showDlgInfo(string message)
        {
            if (MyParam.mainForm == null)
            {
                SvLogger.Log.Debug("MyParam.mainForm = null, at MyLib::ShowInfo");
                return;
            }
            if(MyParam.mainForm.InvokeRequired)
            {
                MyParam.mainForm.BeginInvoke(new Action(() =>
                {
                    MaterialDialog materialDialog = new MaterialDialog(MyParam.mainForm, "Info", message, "OK");
                    DialogResult result = materialDialog.ShowDialog(MyParam.mainForm);
                }));
            }
            else
            {
                MaterialDialog materialDialog = new MaterialDialog(MyParam.mainForm, "Info", message, "OK");
                DialogResult result = materialDialog.ShowDialog(MyParam.mainForm);
            }
        }

        public static void ShowInfo(string message, string title = "Warning")
        {
            if (MyParam.mainForm == null)
            {
                SvLogger.Log.Debug("MyParam.mainForm = null, at MyLib::ShowInfo");
                return;
            }

            if (MyParam.mainForm.InvokeRequired)
            {
                MyParam.mainForm.BeginInvoke(new Action(() =>
                {
                    MaterialDialog materialDialog = new MaterialDialog(MyParam.mainForm, title, message, "OK");
                    DialogResult result = materialDialog.ShowDialog(MyParam.mainForm);
                }));
            }
            else
            {
                MaterialDialog materialDialog = new MaterialDialog(MyParam.mainForm, title, message, "OK");
                DialogResult result = materialDialog.ShowDialog(MyParam.mainForm);
            }

        }

        public static void log(string message)
        {
            Console.WriteLine(message);
            SvLogger.Log.Debug(message);
        }

        public static void log(string message, SvLogger.LogType logType)
        {
            Console.WriteLine(message);
            switch (logType)
            {
                case SvLogger.LogType.DATA:
                    SvLogger.Log.Data(message);
                    break;
                case SvLogger.LogType.ERROR:
                    SvLogger.Log.Error(message);
                    break;
                case SvLogger.LogType.DEBUG:
                    SvLogger.Log.Debug(message);
                    break;
                case SvLogger.LogType.SEQUENCE:
                    SvLogger.Log.Sequence(message);
                    break;
                case SvLogger.LogType.RECIPE:
                    SvLogger.Log.Recipe(message);
                    break;
            }

        }

        public static void log(string TAG, string message)
        {
            Console.WriteLine(TAG + ": " + message);
        }
        

        
        
        public static void closeCom()
        {
            //close comport
            MyParam.commonParam.myComport.DisConnect();
            
        }
       

        public static String GetTimestamp(DateTime value)
        {
            if(MyParam.commonParam.devParam.hideDate)
            {
                return value.ToString("HH:mm:ss:ffff");
            }
            return value.ToString("yyyy/MM/dd-HH:mm:ss:ffff");
        }
        

        public static void updateColor()
        {
            //These are just example color schemes
            switch (MyParam.uIParam.colorSchemeIndex)
            {
                case 0:
                    MyParam.materialSkinManager.ColorScheme = new ColorScheme(
                        MyParam.materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        MyParam.materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        MyParam.materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;

                case 1:
                    MyParam.materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red100,
                        TextShade.WHITE);
                    break;

                case 2:
                    MyParam.materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
            }
            
        }


        public static byte[] serialize(Object obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFomatter = new BinaryFormatter();
            binaryFomatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }

        

        

        public static string createMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                //return Convert.ToString(hashBytes); // .NET 5 +

                // Convert the byte array to hexadecimal string prior to .NET 5
                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }


        public static List<PLCRegister> GetListPLCREG()
        {
            List < PLCRegister > listPLCREG = new List<PLCRegister> ();
            string filePLCREG = MyDefine.file_plc_reg;

            try
            {
                string[] lines = File.ReadAllLines(filePLCREG);
                if (lines.Length <= 1)
                    return listPLCREG;

                //ignore first line - header row
                for (int i = 1; i < lines.Length; i++)
                {

                    //Console.WriteLine(lines[i]);
                    if (!lines[i].Contains(","))
                        continue;

                    var data = lines[i].Split(',');
                    if(data.Length != MyDefine.NUM_COL_PLC_REG)
                    {
                        MyLib.showDlgWarning("PLC Register file wrong format!");
                        return listPLCREG;
                    }

                    PLCRegister reg = new PLCRegister(
                            data[(int)ePLCREG.PLCREG],
                            data[(int)ePLCREG.PURPOSE],
                            data[(int)ePLCREG.DESCRIPT],
                            (eModeRW)(int.Parse(data[(int)ePLCREG.MODE_RW]))
                        );
                    Console.WriteLine(reg.PrintInfo());
                    listPLCREG.Add(reg);
                }

            }
            catch (Exception ex)
            {
                //MyParam.msgPrinter.PrintError(ex.Message);
                MyLib.showDlgError(ex.Message);
                MyLib.log(ex.Message, SvLogger.LogType.ERROR);
            }
            
            return listPLCREG;
        }
        
        
        public static bool CreateFolder(string path_folder)
        {
            bool result = Directory.Exists(path_folder);
            if (!result)
            {
                Directory.CreateDirectory(path_folder);
                result = Directory.Exists(path_folder);
            }
            return result;
        }
        public static string GetFileName(eCamSide side)
        {
            string path2save = String.Empty; 
            string filename = String.Empty;
            switch(side)
            {
                case eCamSide.CAM_TAPE:
                    path2save = $"{MyParam.runParam.ImagePath}\\Tape";
                    break;

                    case eCamSide.CAM_JIG:
                    path2save = $"{MyParam.runParam.ImagePath}\\Jig";
                    break;
            }
            if(string.IsNullOrEmpty(path2save))
            {
                return filename;
            }

            if (CreateFolder(path2save))
            {
                filename = String.Format("{0}\\{1}.bmp", path2save, DateTime.Now.ToString("yyyyMMdd_hhmmss"));
            }

            return filename;
        }
        
        public static string getImagePath(string input)
        {
            var regex = new Regex("\"(.*?)\"");
            var x = regex.Match(input).Groups[1].Value;
            return x;
        }

        public static int GetNumberImg(string dir = "C:\\Users\\Admin\\Desktop\\Alignment\\jig", string extension = "*.bmp")
        {
            try
            {
                string[] fileArray = Directory.GetFiles(dir, extension);
                return fileArray.Length;
            }
            catch (Exception ex)
            {
                MyLib.log(ex.Message, SvLogger.LogType.ERROR);
                return -1;
            }

        }

        public static void Convert2Gray(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                return;

            string[] fileArray = Directory.GetFiles(folderPath, "*.bmp");
            foreach (string file in fileArray)
            {
                //load & convert
                using (Mat m = Cv2.ImRead(file, ImreadModes.Grayscale))
                {
                    string fileNew = file + "_Gray.bmp";
                    Cv2.ImWrite(fileNew, m);
                }
            }
        }

        public static int String2Int(string data)
        {
            int i = 0;
            bool bResult = int.TryParse(data, out i);
            if(bResult)
            {
                return i;
            }
            return MyDefine.ERROR_PLC_CODE;
        }
        
        public static float String2Float(string data)
        {
            float i = 0;
            bool bResult = float.TryParse(data, out i);
            if(bResult)
            {
                return i;
            }
            return MyDefine.ERROR_PLC_CODE;
        }

        public static void ShowLogListview(MaterialListView listview, string message)
        {
            if (listview.InvokeRequired)
            {
                listview.BeginInvoke(new Action(() =>
                {
                    if (listview.Items.Count >= MyParam.commonParam.devParam.maxLine)
                    {
                        listview.Items.Clear();
                    }

                    listview.Items.Insert(0,
                        new ListViewItem(new string[] { MyLib.GetTimestamp(DateTime.Now), $"{message}" }));
                }));
            }
            else
            {
                if (listview.Items.Count >= MyParam.commonParam.devParam.maxLine)
                {
                    listview.Items.Clear();
                }

                listview.Items.Insert(0,
                        new ListViewItem(new string[] { MyLib.GetTimestamp(DateTime.Now), $"{message}" }));
            }
        }

        public static void ShowException(Exception exception)
        {
            showDlgInfo("Exception caught:\n" + exception.Message);
        }

    }
}
