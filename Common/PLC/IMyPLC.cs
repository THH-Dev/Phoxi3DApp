using HslCommunication.Profinet.Melsec;
using HslCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanHungHa.Common.PLC
{
    public interface IMyPLC
    {
        string GetInfo();

        bool ConnectToPlc(bool bShow = false);

        bool DisconnectPLC();

        bool SetValue(int value, PLCRegister assignment);

        int GetValue(PLCRegister assignment);

        string Ping();

        bool IsConnected();
        
    }
}
