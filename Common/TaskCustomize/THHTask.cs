using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanHungHa.Common.PLC;
using System.Threading;

namespace TanHungHa.Common.TaskCustomize
{
    public enum eTaskToDo
    {
        OPEN_CAM_TAPE,
        OPEN_CAM_JIG,
        LOAD_JOB_VISION,
        OPEN_PLC,
        OPEN_CONTROLLER,
        HEATBEAT,
        LOAD_VPRO,
        OPEN_LINESCAN,
        OPEN_EZI
    }
    static class THHTask
    {
        static Func<object, bool> callFunction = (object taskToDo2) =>
        {
            bool bResult = false;
            eTaskToDo taskToDo = (eTaskToDo)taskToDo2; 
            Console.WriteLine($"---------callFunction = {taskToDo}");
            switch (taskToDo)
            {
                case eTaskToDo.OPEN_CAM_TAPE:
                    bResult = true;
                    //bResult = MyParam.runParam.camTape.InitCamera();
                    break;

                case eTaskToDo.OPEN_CAM_JIG:
                    bResult = true;
                    //bResult = MyParam.runParam.camJig.InitCamera();
                    break;

                case eTaskToDo.OPEN_PLC:
                    bResult = MyPLC.GetInstance().ConnectToPlc();
                    //Thread.Sleep(100);
                    //MyPLC.GetInstance().DisconnectPLC();
                    //Thread.Sleep(100);
                    //bResult = MyPLC.GetInstance().ConnectToPlc();
                    break;

                case eTaskToDo.LOAD_JOB_VISION:
                    bResult = true;

                    //bResult = MyParam.runParam.LoadSolution();
                    //if(bResult)
                    //{
                    //    MyParam.tabCalib.UpdateProcessComboBox(MyParam.runParam.processList);
                    //}
                    break;

                
                case eTaskToDo.HEATBEAT:
                    bResult = MainProcess.RunLoopHeartBeat();
                    break;

                

                default:
                    break;
            }
            Console.WriteLine($"---------callFunction {taskToDo}, result = {bResult}");
            return bResult;
        };

        public static async Task<bool> RunTask(object taskToDo)
        {
            //bool result = await Task.Run(() => callFunction(taskToDo));
            //Console.WriteLine($"Task run --- {taskToDo}: {result}");
            //return result;
            Task<bool> task = new Task<bool>(callFunction, taskToDo);
            task.Start();
            await task;
            Console.WriteLine($"Task run --- {taskToDo}: {task.Result}");
            return task.Result;
        }
    }
}
