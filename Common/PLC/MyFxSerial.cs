using HslCommunication;
using HslCommunication.Profinet.Melsec;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanHungHa.Common.PLC
{
    public class MyFxSerial : IMyPLC
    {
        private static MyFxSerial _instance;
        private static readonly object _lock = new object();
        public static MyFxSerial GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MyFxSerial();
                    }
                }
            }
            return _instance;
        }

        [JsonIgnore]
        MelsecFxSerial melsecSerial = null;

        [JsonIgnore]
        string Comport { get; set; }

        [JsonIgnore]
        int Baudrate { get; set; }

        MyFxSerial()
        {
            melsecSerial = new MelsecFxSerial();
            Comport = MyParam.commonParam.PLCParam.Comport;
            Baudrate = MyParam.commonParam.PLCParam.Baudrate;
        }

        public string GetInfo()
        {
            return $"{Comport}:{Baudrate}";
        }
        public bool ConnectToPlc(bool bShow = false)
        {
            //update param
            Comport = MyParam.commonParam.PLCParam.Comport;
            Baudrate = MyParam.commonParam.PLCParam.Baudrate;

            bool bConnectResult = false;
            melsecSerial?.Close();
            melsecSerial = new MelsecFxSerial();
            melsecSerial.IsNewVersion = false;
            melsecSerial.AutoChangeBaudRate = false;
            //melsecSerial.LogNet = LogNet;

            try
            {
                melsecSerial.SerialPortInni(sp =>
                {
                    sp.PortName = this.Comport;
                    sp.BaudRate = this.Baudrate;
                    sp.DataBits = 7;
                    sp.StopBits = StopBits.One;
                    sp.Parity = Parity.Even;
                });


#if !Ignore_CHECK
                OperateResult connect = melsecSerial.Open();
                if (connect.IsSuccess)
                {
                    if (bShow)
                    {
                        MyLib.showDlgInfo($"Connected to PLC {Comport}:{Baudrate} successfully!");
                    }

                    Console.WriteLine($"Connected to PLC {Comport}:{Baudrate} successfully!");
                    bConnectResult = true;
                }
                else
                {
                    if (bShow)
                    {
                        MyLib.showDlgError($"Connection {Comport}:{Baudrate} failed!");
                    }
                    bConnectResult = false;
                }
#else
                if (bShow)
                {
                    MyLib.showDlgInfo($"Connected to PLC {Comport}:{Baudrate} successfully!");
                }

                Console.WriteLine($"Connected to PLC {Comport}:{Baudrate} successfully!");
                bConnectResult = true;
#endif
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return bConnectResult;
        }

        public bool DisconnectPLC()
        {

            melsecSerial?.Close();

            bool bCloseResult = !melsecSerial.IsOpen();
            if (bCloseResult)
            {
                Console.WriteLine("Close connection PLC successfully!");
            }
            else
            {
                Console.WriteLine("Close connection failed!");
            }


            return bCloseResult;
        }

        public bool SetValue(int value, PLCRegister assignment)
        {

            if (melsecSerial == null || !IsConnected())
            {
                return false;
            }
            string plc_adress = "";
            string Reg = assignment.Register;
            string Flag = Reg.Substring(0, 1);
            string Address = Reg.Substring(1);

            if (Flag.Equals("D") || Flag.Equals("M"))
            {
                plc_adress = Reg;
            }
            else
            {
                plc_adress = $"{Flag}{OctalConverter.hex2Octal(Address)}";
            }

            try
            {
                if (Flag.Equals("X") ||
                Flag.Equals("Y") ||
                Flag.Equals("M"))
                {
                    switch (assignment.ModeRW)
                    {
                        case eModeRW.BOOL:
                            bool b_val = Convert.ToBoolean(value);
                            //Console.WriteLine($"{plc_adress} -> {b_val}");
                            var writeResult = melsecSerial.Write(plc_adress, b_val);
                            if (!writeResult.IsSuccess)
                            {
                                MyLib.showDlgWarning(writeResult.Message);
                                return false;
                            }
                            break;

                        default:
                            MyLib.showDlgWarning($"{plc_adress} -> not support mode {assignment.ModeRW}");
                            break;

                    }


                }
                else
                {
                    switch (assignment.ModeRW)
                    {
                        case eModeRW.BOOL:
                            bool BoolVal = Convert.ToBoolean(value);
                            //Console.WriteLine($"{plc_adress} -> {b_val}");
                            var BoolWriteResult = melsecSerial.Write(plc_adress, BoolVal);
                            if (!BoolWriteResult.IsSuccess)
                            {
                                MyLib.showDlgWarning(BoolWriteResult.Message);
                                return false;
                            }
                            break;


                        case eModeRW.INT16:
                            short Int16Val = Convert.ToInt16(value);
                            var Int16WriteResult = melsecSerial.Write(plc_adress, Int16Val);
                            if (!Int16WriteResult.IsSuccess)
                            {
                                MyLib.showDlgWarning(Int16WriteResult.Message);
                                return false;
                            }
                            //Console.WriteLine($"{plc_adress} -> {i_val}");
                            break;
                        case eModeRW.INT32:
                            int Int32Val = Convert.ToInt32(value);
                            var Int32WriteResult = melsecSerial.Write(plc_adress, Int32Val);
                            if (!Int32WriteResult.IsSuccess)
                            {
                                MyLib.showDlgWarning(Int32WriteResult.Message);
                                return false;
                            }
                            //Console.WriteLine($"{plc_adress} -> {i_val}");
                            break;
                        case eModeRW.INT64:
                            long Int64Val = Convert.ToInt64(value);
                            var i64writeResult = melsecSerial.Write(plc_adress, Int64Val);
                            if (!i64writeResult.IsSuccess)
                            {
                                MyLib.showDlgWarning(i64writeResult.Message);
                                return false;
                            }
                            //Console.WriteLine($"{plc_adress} -> {i_val}");
                            break;
                        case eModeRW.UINT16:
                            ushort UInt16Val = Convert.ToUInt16(value);
                            var UInt16WriteResult = melsecSerial.Write(plc_adress, UInt16Val);
                            if (!UInt16WriteResult.IsSuccess)
                            {
                                MyLib.showDlgWarning(UInt16WriteResult.Message);
                                return false;
                            }
                            //Console.WriteLine($"{plc_adress} -> {i_val}");
                            break;
                        case eModeRW.UINT32:
                            uint UInt32Val = Convert.ToUInt32(value);
                            var UInt32WriteResult = melsecSerial.Write(plc_adress, UInt32Val);
                            if (!UInt32WriteResult.IsSuccess)
                            {
                                MyLib.showDlgWarning(UInt32WriteResult.Message);
                                return false;
                            }
                            //Console.WriteLine($"{plc_adress} -> {i_val}");
                            break;
                        case eModeRW.UINT64:
                            ulong UInt64Val = Convert.ToUInt64(value);
                            var UInt64WriteResult = melsecSerial.Write(plc_adress, UInt64Val);
                            if (!UInt64WriteResult.IsSuccess)
                            {
                                MyLib.showDlgWarning(UInt64WriteResult.Message);
                                return false;
                            }
                            //Console.WriteLine($"{plc_adress} -> {i_val}");
                            break;
                        case eModeRW.DOUBLE:
                        case eModeRW.FLOAT:
                        case eModeRW.STRING:
                        default:
                            MyLib.showDlgWarning($"{plc_adress} -> not support mode {assignment.ModeRW}");
                            break;

                    }


                }
            }
            catch (Exception ex)
            {
                if (!MyParam.commonParam.devParam.mutePLCOverValue)
                {
                    MyLib.showDlgError(ex.Message);
                }
                MyLib.log(ex.Message, SvLogger.LogType.ERROR);
                return false;
            }


            return true;
        }


        public int GetValue(PLCRegister assignment)
        {
            int value = MyDefine.ERROR_PLC_CODE;
            if (melsecSerial == null || !IsConnected())
            {
                return value;
            }
            else
            {
                string plc_adress = "";
                string Reg = assignment.Register;
                string Flag = Reg.Substring(0, 1);
                string Address = Reg.Substring(1);

                if (Flag.Equals("D") || Flag.Equals("M"))
                {
                    plc_adress = Reg;
                }
                else
                {
                    plc_adress = $"{Flag}{OctalConverter.hex2Octal(Address)}";
                }

                try
                {
                    if (Flag.Equals("X") ||
                        Flag.Equals("Y") ||
                        Flag.Equals("M"))
                    {
                        switch (assignment.ModeRW)
                        {
                            case eModeRW.BOOL:
                                OperateResult<bool[]> M_reg = melsecSerial.ReadBool(plc_adress, 1);
                                if (M_reg.IsSuccess)
                                {
                                    bool[] M_relay = M_reg.Content;//read whether M100 works, decimal address
                                    if (M_relay != null)
                                    {
                                        value = Convert.ToInt16(M_relay[0]);
                                        //Console.WriteLine($"{plc_adress} -> {M_relay[0]}");
                                    }
                                }
                                else
                                {
                                    MyLib.showDlgWarning($"{plc_adress} -> read error {M_reg.Message}");
                                }
                                break;

                            default:
                                MyLib.showDlgWarning($"{plc_adress} -> not support mode {assignment.ModeRW}");
                                break;

                        }


                    }
                    else
                    {

                        switch (assignment.ModeRW)
                        {
                            case eModeRW.BOOL:
                                OperateResult<bool[]> M_reg = melsecSerial.ReadBool(plc_adress, 1);
                                if (M_reg.IsSuccess)
                                {
                                    bool[] M_relay = M_reg.Content;//read whether M100 works, decimal address
                                    if (M_relay != null)
                                    {
                                        value = Convert.ToInt16(M_relay[0]);
                                        //Console.WriteLine($"{plc_adress} -> {M_relay[0]}");
                                    }
                                }
                                else
                                {
                                    MyLib.showDlgWarning($"{plc_adress} -> read error {M_reg.Message}");
                                }
                                break;


                            case eModeRW.INT16:
                                OperateResult<short> D_reg_int16 = melsecSerial.ReadInt16(plc_adress);
                                if (D_reg_int16.IsSuccess)
                                {
                                    value = (int)D_reg_int16.Content;
                                }
                                else
                                {
                                    MyLib.showDlgWarning($"{plc_adress} -> read error {D_reg_int16.ErrorCode}");
                                }
                                break;
                            case eModeRW.INT32:
                                OperateResult<int> D_reg_int32 = melsecSerial.ReadInt32(plc_adress);
                                if (D_reg_int32.IsSuccess)
                                {
                                    value = D_reg_int32.Content;
                                }
                                else
                                {
                                    MyLib.showDlgWarning($"{plc_adress} -> read error {D_reg_int32.ErrorCode}");
                                }
                                break;
                            case eModeRW.INT64:
                                OperateResult<long> D_reg_int64 = melsecSerial.ReadInt64(plc_adress);
                                if (D_reg_int64.IsSuccess)
                                {
                                    value = (int)D_reg_int64.Content;
                                }
                                else
                                {
                                    MyLib.showDlgWarning($"{plc_adress} -> read error {D_reg_int64.ErrorCode}");
                                }
                                break;
                            case eModeRW.UINT16:
                                OperateResult<ushort> D_reg_uint16 = melsecSerial.ReadUInt16(plc_adress);
                                if (D_reg_uint16.IsSuccess)
                                {
                                    value = (int)D_reg_uint16.Content;
                                }
                                else
                                {
                                    MyLib.showDlgWarning($"{plc_adress} -> read error {D_reg_uint16.ErrorCode}");
                                }
                                break;
                            case eModeRW.UINT32:
                                OperateResult<uint> D_reg_uint32 = melsecSerial.ReadUInt32(plc_adress);
                                if (D_reg_uint32.IsSuccess)
                                {
                                    value = (int)D_reg_uint32.Content;
                                }
                                else
                                {
                                    MyLib.showDlgWarning($"{plc_adress} -> read error {D_reg_uint32.ErrorCode}");
                                }
                                break;
                            case eModeRW.UINT64:
                                OperateResult<ulong> D_reg_uint64 = melsecSerial.ReadUInt64(plc_adress);
                                if (D_reg_uint64.IsSuccess)
                                {
                                    value = (int)D_reg_uint64.Content;
                                }
                                else
                                {
                                    MyLib.showDlgWarning($"{plc_adress} -> read error {D_reg_uint64.ErrorCode}");
                                }
                                break;
                            case eModeRW.DOUBLE:
                            case eModeRW.FLOAT:
                            case eModeRW.STRING:
                            default:
                                MyLib.showDlgWarning($"{plc_adress} -> not support mode {assignment.ModeRW}");
                                break;

                        }
                    }
                }
                catch (Exception ex)
                {
                    if (!MyParam.commonParam.devParam.mutePLCOverValue)
                    {
                        MyLib.showDlgError(ex.Message);
                    }

                    MyLib.log($"{plc_adress} - {ex.Message}", SvLogger.LogType.ERROR);
                }
            }

            return value;
        }


        public string Ping()
        {
            string stt = MyDefine.PLC_DISCONNECT;
            if (melsecSerial == null || !IsConnected())
            {
                return stt;
            }

            if (melsecSerial.IsOpen())
            {
                stt = MyDefine.PLC_CONNECTED;
            }

            return stt;
        }

        public bool IsConnected()
        {
            if(melsecSerial == null)
                return false;

            bool b = melsecSerial.IsOpen();
            //Console.WriteLine($"PLC connected = {b}");
            return b;
        }
    }
}
