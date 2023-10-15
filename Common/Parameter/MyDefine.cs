using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TanHungHa.Common
{
    public class MyDefine
    {
        //public static DateTime expried_time = new DateTime(2024, 8, 13, 9, 0, 0);
        public const string VERSION = @"Ver 1.0.0.200823";
        public static readonly string title = "Phoxi3D App";

        public const string treenodeRunParam = "Run Param";

        public const string treenodeLightController = "LightController";
        public const string subtreenodeChannel1 = "Channel1";
        public const string subtreenodeChannel2 = "Channel2";
        public const string subtreenodeChannel3 = "Channel3";
        public const string subtreenodeChannel4 = "Channel4";

        public const string treenodeRS232 = "RS232";
        public const string treenodeEzi = "Ezi";
        public const string treenodeRobot = "Robot";
        public const string treenodePLC = "PLC";
        public const string subtreenodePLCAssignment = "PLC Param";


        public const string treenodeTime = "Time";
        public const string treenodeTheme = "Theme";
        public const string treenodeDev = "Developer";
        public const string treeLineScan = "LineScan";

        public const string PLC_DISCONNECT = "(PLC Disconnected)";
        public const string PLC_CONNECTED = "(PLC Connected)";
        public static readonly string PLC_CODE_STR = string.Empty;

        public const int NUM_FAIL_HEART_BEAR = 5;
        public const int NUM_THREAD = 10;
        public const int PAGE_SHOW_PLC = 24;
        public const int NUM_DEVICES = 2;
        public static int MAX_LIGHT_CHANNEL = 4;
        public static int MAX_FRAME_SIZE = 10;
        public const int MAX_QUEUE_DATA = 10;
        public static int ERROR_PLC_CODE = -999;
        public const int NUM_COL_PLC_REG = 5;
        public const int NUM_COL_SDK_ERROR = 2;

        public static int[] baudrates = new int[] { 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200 } ;
        public static int[] dataSize = new int[] { 7,8 };

        

        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        public static readonly string workspaceDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        public static readonly string regex_get_image_file = @"[^\s]+(.*?)\.(jpg|jpeg|png|gif|bmp|JPG|JPEG|PNG|GIF|BMP)$";
        public static readonly string regex_get_ip = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";


        #region Path file json
        public static readonly string file_plc_assignment = String.Format($"{workingDirectory}\\Configs\\plc_assignment.json");
        public static readonly string file_plc_reg = String.Format($"{workingDirectory}\\Configs\\PLCREG.csv");
        public static readonly string file_sdk_error = String.Format($"{workingDirectory}\\Configs\\SDKErrorCode.csv");

        
        public static readonly string file_config = String.Format($"{workingDirectory}\\Configs\\config_param.json");
        public static readonly string file_uiParam= String.Format($"{workingDirectory}\\Configs\\uiParameter.json");
        public static readonly string file_runParam= String.Format($"{workingDirectory}\\Configs\\runParameter.json");
        public static readonly string file_model= String.Format($"{workingDirectory}\\Configs\\models.json");
        
        //public static readonly string path_solution= String.Format($"{workingDirectory}\\Data\\TapeAlignment.sol");
        public static readonly string path_solution= @"C:\Users\Admin\Desktop\Alignment\Phoxi3DApp.sol";
        public static readonly string path_tape_emulator= @"C:\Users\Admin\Desktop\Alignment\tape";
        public static readonly string path_jig_emulator = @"C:\Users\Admin\Desktop\Alignment\jig";

        public static readonly string file_cameraParam= String.Format($"{workingDirectory}\\Configs\\camParameter.json");
        public static readonly string file_excel = String.Format($"{workingDirectory}\\Data\\ImportData.xlsx");

        public static readonly string file_config_format_data = String.Format($"{workingDirectory}\\Data\\configs\\format_data.json");
        public static readonly string file_config_common_param = String.Format($"{workingDirectory}\\Data\\configs\\common_param.json");
        public static readonly string file_config_filter_window = String.Format($"{workingDirectory}\\Data\\configs\\filter_window.json");
        public static readonly string path_load_img_database = @"C:\Program Files\Cognex\VisionPro\Images";
        public static readonly string path_load_vpp_file = @"C:\Users\Admin\Desktop\Vpp_file";
        public static readonly string path_save_images = String.Format("{0}\\Images", projectDirectory);
        public static readonly string path_grab_images = String.Format("{0}\\GrabImages", projectDirectory);

        public static readonly string path_save_jsMsg = String.Format($"{workingDirectory}\\jsLogs");

        public static readonly string key_thh = @"https://tanhungha.com.vn/";
        public static readonly string hash_key = "";
        #endregion

        #region api
        public static string API_OK = "success";
        public static string API_NG = "error";
        public static string API_Warning = "warning";
        public static string API_LOSS_CONNECTION = "network";
        public static string dev_pass = "tuanna@2022";
        public static string user_pass = "cttv@2022";
        #endregion

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);


        [DllImport("kernel32", SetLastError = true)]
        static extern IntPtr LoadLibrary(string lpFileName);

        public static bool CheckLibrary(string fileName)
        {
            return LoadLibrary(fileName) == IntPtr.Zero;
        }



    }
}
