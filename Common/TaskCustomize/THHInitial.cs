using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanHungHa.Common.TaskCustomize;

namespace TanHungHa.Common.TaskCustomize
{
    public static class THHInitial
    {
        public static async Task<bool> InitDevice()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            var task1 = THHTask.RunTask(eTaskToDo.OPEN_CAM_TAPE);
            var task2 = THHTask.RunTask(eTaskToDo.OPEN_CAM_JIG);
            var task3 = THHTask.RunTask(eTaskToDo.LOAD_VPRO);
            var task4 = THHTask.RunTask(eTaskToDo.OPEN_PLC);
            var task5 = THHTask.RunTask(eTaskToDo.OPEN_EZI);
            var task6 = THHTask.RunTask(eTaskToDo.OPEN_LINESCAN);
            var task7 = THHTask.RunTask(eTaskToDo.OPEN_CONTROLLER);
            var task8 = THHTask.RunTask(eTaskToDo.LOAD_VPRO);

            await task1;
            bool bInitCamTape = task1.Result;
            MainProcess.AddLogAuto($"Init cam tape = {bInitCamTape}", eCamSide.CAM_TAPE);

            await task2;
            bool bInitCamJig = task2.Result;
            MainProcess.AddLogAuto($"Init cam jig = {bInitCamJig}", eCamSide.CAM_JIG);

            await task3;
            bool bLoadSol = task3.Result;
            MainProcess.AddLogAuto($"Init Job = {bLoadSol}", eCamSide.CAM_BOTH);

            await task4;
            bool bConnectPLc = task4.Result;
            MainProcess.AddLogAuto($"Init PLC = {bConnectPLc}", eCamSide.CAM_BOTH);

            

            await task7;
            bool bOpenController = task7.Result;

            await task8;
            bool bLoadVproOK = task8.Result;

            var timeProcess = watch.Elapsed.TotalMilliseconds.ToString();
            Console.WriteLine($"Time process total = {timeProcess}");

            //notify
            //MyLib.showDlgInfo(  $"CamTape = {bInitCamTape}" +
            //                    $", CamJig = {bInitCamJig}" +
            //                    $", LoadJob = {bLoadSol}" +
            //                    $"\r\nPLC = {bConnectPLc}" +
            //                    $", Light = {bConnectController}");
            //return bInitCamTape && bInitCamJig && bLoadSol && bConnectPLc && bConnectController;

            MyLib.showDlgInfo($"CamTape = {bInitCamTape}" +
                                $", CamJig = {bInitCamJig}" +
                                $", LoadJob = {bLoadSol}" +
                                $"\r\nPLC = {bConnectPLc}");
            return bInitCamTape && bInitCamJig && bLoadSol && bConnectPLc && bOpenController;
        }
        
        public static async Task<bool> TaskLoadToolBlock()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            var task1 = THHTask.RunTask(eTaskToDo.LOAD_VPRO);
            await task1;

            watch.Stop();
            Console.WriteLine($"Time heatbeat total = {watch.ElapsedMilliseconds}");
            return task1.Result;
        }

        public static async Task<bool> RunHeatbeat()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            var task1 = THHTask.RunTask(eTaskToDo.HEATBEAT);
            await task1;
            
            var timeProcess = watch.Elapsed.TotalMilliseconds.ToString();
            Console.WriteLine($"Time heatbeat total = {timeProcess}");
            return true;
        }
    }
}
