using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanHungHa.Common.Parameter
{
    public static class VpCommonParammm
    {
        public static Cognex.VisionPro.CogRecordDisplay CogRecordDisplay;
        public static CogToolBlock toolBlockProcess;
        public static CogToolBlockEditV2 toolBlockEdit;
        public static string toolBlockPath;
        public static string outputImageName;
        public static bool bQueueFrame = false;

        public enum TOOLBLOCK_TYPE
        {
            AcqFifo,
            ImageProcess
        }
    }

    public class VpParam
    {
        public string pathToolBlockProcess { get; set; }
        public VpParam() 
        {
            pathToolBlockProcess = string.Empty;
        }
    }
}
