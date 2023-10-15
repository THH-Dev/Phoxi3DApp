using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanHungHa.Common.PLC
{
    public static class WriteDataToPLC
    {
        public static void GripperInOut(int value)
        {
            bool bGripper = MyParam.list_plc_reg[(int)eIndexIO.Cylinder_Gripper].SetValue(value);
            if (bGripper)
            {
                //if (mainView == eMainView.AUTO_VIEW)
                {
                    MainProcess.AddLogAuto($"Set Gripper In/out " +
                        $"({MyParam.list_plc_reg[(int)eIndexIO.Cylinder_Gripper].Register} = {value})");
                }
            }
            else
            {
                //if (mainView == eMainView.AUTO_VIEW)
                {
                    MainProcess.AddLogAuto($"Error: Can't set Gripper In/Out to PLC " +
                                                    $"({MyParam.list_plc_reg[(int)eIndexIO.Cylinder_Gripper].Register} = {value})");
                }
            }
        }   
        
        
        
        public static void TransferInOut(int value)
        {
            bool bTransfer = MyParam.list_plc_reg[(int)eIndexIO.Cylinder_Transfer].SetValue(value);
            if (bTransfer)
            {
                //if (mainView == eMainView.AUTO_VIEW)
                {
                    MainProcess.AddLogAuto($"Set Transfer In/out " +
                        $"({MyParam.list_plc_reg[(int)eIndexIO.Cylinder_Transfer].Register} = {value})");
                }
            }
            else
            {
                //if (mainView == eMainView.AUTO_VIEW)
                {
                    MainProcess.AddLogAuto($"Error: Can't set Transfer In/Out to PLC " +
                                                    $"({MyParam.list_plc_reg[(int)eIndexIO.Cylinder_Transfer].Register} = {value})");
                }
            }
        }   
        
        public static void CylinderUpDown(int value)
        {
            bool bCylinderUpDown = MyParam.list_plc_reg[(int)eIndexIO.Cylinder_UpDown].SetValue(value);
            if (bCylinderUpDown)
            {
                //if (mainView == eMainView.AUTO_VIEW)
                {
                    MainProcess.AddLogAuto($"Set Cylinder Up/Down " +
                        $"({MyParam.list_plc_reg[(int)eIndexIO.Cylinder_UpDown].Register} = {value})");
                }
            }
            else
            {
                //if (mainView == eMainView.AUTO_VIEW)
                {
                    MainProcess.AddLogAuto($"Error: Can't set Cylinder Up/Down to PLC " +
                                                    $"({MyParam.list_plc_reg[(int)eIndexIO.Cylinder_UpDown].Register} = {value})");
                }
            }
        }        
        
        public static void VacumnOnOff(int value)
        {
            bool bVacumnOnOff = MyParam.list_plc_reg[(int)eIndexIO.Vacumn].SetValue(value);
            if (bVacumnOnOff)
            {
                //if (mainView == eMainView.AUTO_VIEW)
                {
                    MainProcess.AddLogAuto($"Set Vacumn On/Off " +
                        $"({MyParam.list_plc_reg[(int)eIndexIO.Vacumn].Register} = {value})");
                }
            }
            else
            {
                //if (mainView == eMainView.AUTO_VIEW)
                {
                    MainProcess.AddLogAuto($"Error: Can't set Vacumn On/Off to PLC " +
                                                    $"({MyParam.list_plc_reg[(int)eIndexIO.Vacumn].Register} = {value})");
                }
            }
        } 
        
        
        
        public static void WriteVisionFree(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {

        }

        public static void WriteVisionNotReady(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {

        }
        
        public static void WriteVisionReady(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {

        }
        public static void WriteSetTrigger(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {

        }

#if IgnoreCode
        public static void WritePLCReady(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bTrigOff = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bTrigOff = MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].SetValue(MyDefine.TRIGGER_OFF);
                        if (bTrigOff)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {

                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {

                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {

                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {

                            }
                        }
                    }
                    break;

                case eCamSide.CAM_JIG:
                    bTrigOff = MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].SetValue(MyDefine.TRIGGER_OFF);
                    if (bTrigOff)
                    {
                        if (mainView == eMainView.AUTO_VIEW)
                        {

                        }
                        else if (mainView == eMainView.TEACHING_VIEW)
                        {

                        }
                    }
                    else
                    {
                        if (mainView == eMainView.AUTO_VIEW)
                        {

                        }
                        else if (mainView == eMainView.TEACHING_VIEW)
                        {

                        }
                    }
                    break;
            }
        }
        public static void WritePLCNotReady(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bTrigOff = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bTrigOff = MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].SetValue(MyDefine.TRIGGER_OFF);
                        if (bTrigOff)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {

                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {

                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {

                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {

                            }
                        }
                    }
                    break;

                case eCamSide.CAM_JIG:
                    bTrigOff = MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].SetValue(MyDefine.TRIGGER_OFF);
                    if (bTrigOff)
                    {
                        if (mainView == eMainView.AUTO_VIEW)
                        {

                        }
                        else if (mainView == eMainView.TEACHING_VIEW)
                        {

                        }
                    }
                    else
                    {
                        if (mainView == eMainView.AUTO_VIEW)
                        {

                        }
                        else if (mainView == eMainView.TEACHING_VIEW)
                        {

                        }
                    }
                    break;
            }
        }

        public static void WriteVisionFree(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bVisionFree = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bVisionFree = MyParam.list_plc_reg[(int)eIndex.IsVisionTapeProcessing].SetValue(MyDefine.VISION_FREE);
                        if (bVisionFree)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision Free to PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeProcessing].Register} = {MyDefine.VISION_FREE})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision Free to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeProcessing].Register} = {MyDefine.VISION_FREE})");
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't set vision Free to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeProcessing].Register} = {MyDefine.VISION_FREE})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't set vision Free to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeProcessing].Register} = {MyDefine.VISION_FREE})");
                            }
                        }
                    }
                    break;

                case eCamSide.CAM_JIG:
                    {
                        bVisionFree = MyParam.list_plc_reg[(int)eIndex.IsVisionJigProcessing].SetValue(MyDefine.VISION_FREE);
                        if (bVisionFree)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision Free to PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigProcessing].Register} = {MyDefine.VISION_FREE})"
                                    , eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision Free to PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigProcessing].Register} = {MyDefine.VISION_FREE})"
                                    , eCamSide.CAM_JIG);
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't set vision Free to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigProcessing].Register} = {MyDefine.VISION_FREE})"
                                                                , eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't set vision Free to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigProcessing].Register} = {MyDefine.VISION_FREE})"
                                                                , eCamSide.CAM_JIG);
                            }
                        }
                    }
                    break;
            }
        }

        public static void WriteVisionBusy(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bVisionBusy = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bVisionBusy = MyParam.list_plc_reg[(int)eIndex.IsVisionTapeProcessing].SetValue(MyDefine.VISION_BUSY);
                        if (bVisionBusy)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision busy to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeProcessing].Register} = {MyDefine.VISION_BUSY})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision busy to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeProcessing].Register} = {MyDefine.VISION_BUSY})");
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't set vision busy to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeProcessing].Register} = {MyDefine.VISION_BUSY})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't set vision busy to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeProcessing].Register} = {MyDefine.VISION_BUSY})");
                            }
                        }

                    }
                    break;

                case eCamSide.CAM_JIG:
                    {
                        bVisionBusy = MyParam.list_plc_reg[(int)eIndex.IsVisionJigProcessing].SetValue(MyDefine.VISION_BUSY);
                        if (bVisionBusy)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision busy to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigProcessing].Register} = {MyDefine.VISION_BUSY})",
                                                                eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision busy to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigProcessing].Register} = {MyDefine.VISION_BUSY})",
                                                                eCamSide.CAM_JIG);
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't set vision busy to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigProcessing].Register} = {MyDefine.VISION_BUSY})",
                                                                eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't set vision busy to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigProcessing].Register} = {MyDefine.VISION_BUSY})",
                                                                eCamSide.CAM_JIG);
                            }
                        }
                    }
                    break;
            }
        }

        public static void WriteVisionOK(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bVisionOK = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bVisionOK = MyParam.list_plc_reg[(int)eIndex.IsVisionTapeException].SetValue(MyDefine.VISION_OK);
                        if (bVisionOK)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision OK to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeException].Register} = {MyDefine.VISION_OK})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision OK to PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeException].Register} = {MyDefine.VISION_OK})");
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't set vision OK to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeException].Register} = {MyDefine.VISION_OK})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't set vision OK to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeException].Register} = {MyDefine.VISION_OK})");
                            }
                        }
                    }
                    break;

                case eCamSide.CAM_JIG:
                    {
                        bVisionOK = MyParam.list_plc_reg[(int)eIndex.IsVisionJigException].SetValue(MyDefine.VISION_OK);
                        if (bVisionOK)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision OK to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigException].Register} = {MyDefine.VISION_OK})"
                                                                , eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision OK to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigException].Register} = {MyDefine.VISION_OK})"
                                                                , eCamSide.CAM_JIG);
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't set vision OK to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigException].Register} = {MyDefine.VISION_OK})"
                                                                , eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't set vision OK to PLC " +
                                                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigException].Register} = {MyDefine.VISION_OK})"
                                                                , eCamSide.CAM_JIG);
                            }
                        }
                    }
                    break;
            }
        }

        public static void WriteVisionNG(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bVisionNG = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bVisionNG = MyParam.list_plc_reg[(int)eIndex.IsVisionTapeException].SetValue(MyDefine.VISION_NG);
                        if (bVisionNG)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision NG to PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeException].Register} = {MyDefine.VISION_NG})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision NG to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeException].Register} = {MyDefine.VISION_NG})");
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't set vision NG to PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeException].Register} = {MyDefine.VISION_NG})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't set vision NG to PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeException].Register} = {MyDefine.VISION_NG})");
                            }
                        }
                    }
                    break;

                case eCamSide.CAM_JIG:
                    {
                        bVisionNG = MyParam.list_plc_reg[(int)eIndex.IsVisionJigException].SetValue(MyDefine.VISION_NG);
                        if (bVisionNG)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision NG to PLC " +
                                                            $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigException].Register} = {MyDefine.VISION_NG})"
                                                            , eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision NG to PLC " +
                                                            $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigException].Register} = {MyDefine.VISION_NG})"
                                                            , eCamSide.CAM_JIG);
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't set vision NG to PLC " +
                                                            $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigException].Register} = {MyDefine.VISION_NG})"
                                                            , eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't set vision NG to PLC " +
                                                            $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigException].Register} = {MyDefine.VISION_NG})"
                                                            , eCamSide.CAM_JIG);
                            }
                        }
                    }
                    
                    break;
            }
        }

        public static void WriteVisionReady(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bVisionReady = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bVisionReady = MyParam.list_plc_reg[(int)eIndex.IsVisionTapeReady].SetValue(MyDefine.VISION_READY);
                        if (bVisionReady)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeReady].Register} = {MyDefine.VISION_READY})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeReady].Register} = {MyDefine.VISION_READY})");
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't Write Vision Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeReady].Register} = {MyDefine.VISION_READY})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't Write Vision Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeReady].Register} = {MyDefine.VISION_READY})");
                            }
                        }
                    }
                    break;

                case eCamSide.CAM_JIG:
                    {
                        bVisionReady = MyParam.list_plc_reg[(int)eIndex.IsVisionJigReady].SetValue(MyDefine.VISION_READY);
                        if (bVisionReady)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigReady].Register} = {MyDefine.VISION_READY})",
                                eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigReady].Register} = {MyDefine.VISION_READY})",
                                eCamSide.CAM_JIG);
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't Write Vision Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigReady].Register} = {MyDefine.VISION_READY})",
                                eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't Write Vision Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigReady].Register} = {MyDefine.VISION_READY})",
                                eCamSide.CAM_JIG);
                            }
                        }
                    }
                    break;
            }
        }

        public static void WriteVisionNotReady(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bVisionNotReady = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bVisionNotReady = MyParam.list_plc_reg[(int)eIndex.IsVisionTapeReady].SetValue(MyDefine.VISION_NOT_READY);
                        if (bVisionNotReady)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision Not Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeReady].Register} = {MyDefine.VISION_NOT_READY})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision Not Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeReady].Register} = {MyDefine.VISION_NOT_READY})");
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't Write Vision Not Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeReady].Register} = {MyDefine.VISION_NOT_READY})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't Write Vision Not Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionTapeReady].Register} = {MyDefine.VISION_NOT_READY})");
                            }
                        }
                    }
                    break;

                case eCamSide.CAM_JIG:
                    {
                        bVisionNotReady = MyParam.list_plc_reg[(int)eIndex.IsVisionJigReady].SetValue(MyDefine.VISION_NOT_READY);
                        if (bVisionNotReady)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Vision Not Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigReady].Register} = {MyDefine.VISION_NOT_READY})",
                                eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Vision Not Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigReady].Register} = {MyDefine.VISION_NOT_READY})",
                                eCamSide.CAM_JIG);
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't Write Vision Not Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigReady].Register} = {MyDefine.VISION_NOT_READY})",
                                eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't Write Vision Not Ready to PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsVisionJigReady].Register} = {MyDefine.VISION_NOT_READY})",
                                eCamSide.CAM_JIG);
                            }
                        }
                    }
                    break;
            }
        }

        public static void WriteSlotOK(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bTrigOff = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bTrigOff = MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].SetValue(MyDefine.TRIGGER_OFF);
                        if (bTrigOff)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {

                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {

                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {

                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {

                            }
                        }
                    }
                    break;

                case eCamSide.CAM_JIG:
                    bTrigOff = MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].SetValue(MyDefine.TRIGGER_OFF);
                    if (bTrigOff)
                    {
                        if (mainView == eMainView.AUTO_VIEW)
                        {

                        }
                        else if (mainView == eMainView.TEACHING_VIEW)
                        {

                        }
                    }
                    else
                    {
                        if (mainView == eMainView.AUTO_VIEW)
                        {

                        }
                        else if (mainView == eMainView.TEACHING_VIEW)
                        {

                        }
                    }
                    break;
            }
        }

        public static void WriteSlotNG(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bTrigOff = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bTrigOff = MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].SetValue(MyDefine.TRIGGER_OFF);
                        if (bTrigOff)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {

                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {

                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {

                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {

                            }
                        }
                    }
                    break;

                case eCamSide.CAM_JIG:
                    bTrigOff = MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].SetValue(MyDefine.TRIGGER_OFF);
                    if (bTrigOff)
                    {
                        if (mainView == eMainView.AUTO_VIEW)
                        {

                        }
                        else if (mainView == eMainView.TEACHING_VIEW)
                        {

                        }
                    }
                    else
                    {
                        if (mainView == eMainView.AUTO_VIEW)
                        {

                        }
                        else if (mainView == eMainView.TEACHING_VIEW)
                        {

                        }
                    }
                    break;
            }
        }



        public static void WriteResetTrigger(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bTrigOff = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bTrigOff = MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].SetValue(MyDefine.TRIGGER_OFF);
                        if (bTrigOff)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Reset Trigger signal from PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].Register} = {MyDefine.TRIGGER_OFF})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Reset Trigger signal from PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].Register} = {MyDefine.TRIGGER_OFF})");
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't reset trigger signal from PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].Register} = {MyDefine.TRIGGER_OFF})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't reset trigger signal from PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].Register} = {MyDefine.TRIGGER_OFF})");
                            }
                        }
                    }
                    break;

                case eCamSide.CAM_JIG:
                    {
                        bTrigOff = MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].SetValue(MyDefine.TRIGGER_OFF);
                        if (bTrigOff)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Reset Trigger signal from PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].Register} = {MyDefine.TRIGGER_OFF})",
                                    eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Reset Trigger signal from PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].Register} = {MyDefine.TRIGGER_OFF})",
                                    eCamSide.CAM_JIG);
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't reset trigger signal from PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].Register} = {MyDefine.TRIGGER_OFF})",
                                    eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't reset trigger signal from PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].Register} = {MyDefine.TRIGGER_OFF})",
                                    eCamSide.CAM_JIG);
                            }
                        }
                    }
                    break;
            }
        }
        
        public static void WriteSetTrigger(eCamSide camSide, eMainView mainView = eMainView.AUTO_VIEW)
        {
            bool bTrigOn = false;
            switch (camSide)
            {
                case eCamSide.CAM_TAPE:
                    {
                        bTrigOn = MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].SetValue(MyDefine.TRIGGER_ON);
                        if (bTrigOn)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Trigger signal from PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].Register} = {MyDefine.TRIGGER_ON})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Trigger signal from PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].Register} = {MyDefine.TRIGGER_ON})");
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't Set trigger signal from PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].Register} = {MyDefine.TRIGGER_ON})");
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't Set trigger signal from PLC " +
                                $"({MyParam.list_plc_reg[(int)eIndex.IsPLCTapeTrigger].Register} = {MyDefine.TRIGGER_ON})");
                            }
                        }
                    }
                    break;

                case eCamSide.CAM_JIG:
                    {
                        bTrigOn = MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].SetValue(MyDefine.TRIGGER_ON);
                        if (bTrigOn)
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Set Trigger signal from PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].Register} = {MyDefine.TRIGGER_ON})",
                                    eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Set Trigger signal from PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].Register} = {MyDefine.TRIGGER_ON})",
                                    eCamSide.CAM_JIG);
                            }
                        }
                        else
                        {
                            if (mainView == eMainView.AUTO_VIEW)
                            {
                                MainProcess.AddLogAuto($"Error: Can't set trigger signal from PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].Register} = {MyDefine.TRIGGER_ON})",
                                    eCamSide.CAM_JIG);
                            }
                            else if (mainView == eMainView.TEACHING_VIEW)
                            {
                                MainProcess.AddLogTeaching($"Error: Can't set trigger signal from PLC " +
                                    $"({MyParam.list_plc_reg[(int)eIndex.IsPLCJigTrigger].Register} = {MyDefine.TRIGGER_ON})",
                                    eCamSide.CAM_JIG);
                            }
                        }
                    }
                    break;
            }
        }
#endif

        }
}
