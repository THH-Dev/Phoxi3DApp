using pho.api.csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanHungHa.Common.phoxi3D
{
    public class PhoxiParam
    {
        private static PhoxiParam _instance;
        private static readonly object _lock = new object();
        public static PhoxiParam GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PhoxiParam();
                    }
                }
            }
            return _instance;
        }

        public PhoXiDeviceInformation[] _deviceList;
        public PhoXi _phoXiDevice;
        public PhoXiFactory _factory;
        public Frame _sampleFrame;
        public const string FileCameraFolder = @"";
        public const string OutputFolder = @"G:\API";

        PhoxiParam()
        {
            _factory = new PhoXiFactory();
            _deviceList = null;

        }

        public void LogListDevices()
        {
            Console.WriteLine("PhoXi Factory found {0}  devices by GetDeviceList call.\n", _deviceList.Length);
            for (var i = 0; i < _deviceList.Length; i++)
            {
                Console.WriteLine("Device: {0}", i);
                Console.WriteLine("  Name:                    " + _deviceList[i].Name);
                Console.WriteLine("  Hardware Identification: " + _deviceList[i].HWIdentification);
                Console.WriteLine("  Type:                    " + _deviceList[i].Type);
                Console.WriteLine("  Firmware version:        " + _deviceList[i].FirmwareVersion);
                Console.WriteLine("  Variant:                 " + _deviceList[i].Variant);
                Console.WriteLine("  IsFileCamera:            " + (_deviceList[i].IsFileCamera ? "Yes" : "No"));
                Console.WriteLine("  Feaure-Alpha:            " + (_deviceList[i].CheckFeature("Alpha") ? "Yes" : "No"));
                Console.WriteLine("  Feaure-Color:            " + (_deviceList[i].CheckFeature("Color") ? "Yes" : "No"));
                Console.WriteLine("  Status:                  " +
                                  (_deviceList[i].Status.Attached
                                      ? "Attached to PhoXi Control. "
                                      : "Not Attached to PhoXi Control. ") +
                                  (_deviceList[i].Status.Ready ? "Ready to connect" : "Occupied") + "\n");
            }
        }

    }
}
