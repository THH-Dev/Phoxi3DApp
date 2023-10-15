using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TanHungHa.Common;
using TanHungHa.Common.phoxi3D;

namespace TanHungHa.Tabs.ManualTab
{
    public partial class CameraForm : MaterialForm
    {

        private static CameraForm _instance;
        private static readonly object _lock = new object();
        public static CameraForm GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CameraForm();
                    }
                }
            }
            return _instance;
        }
        CameraForm()
        {
            InitializeComponent();
        }


        private void btnFindDevices_Click(object sender, EventArgs e)
        {
            btnFindDevices.Enabled = false;
            try
            {
                PhoxiFunc.GetAvailableDevicesExample();
                UpdateDeviceList();
            }
            finally
            {
                btnFindDevices.Enabled = true;
            }
        }

        void UpdateDeviceList()
        {
                Console.WriteLine("PhoXi Factory found {0}  devices by GetDeviceList call.\n", PhoxiFunc._deviceList.Length);
                for (var i = 0; i < PhoxiFunc._deviceList.Length; i++)
                {
                    var hwID = PhoxiFunc._deviceList[i].HWIdentification;
                    cbbListCamera.Items.Add(hwID);
                }
                cbbListCamera.SelectedIndex = 0;
        }

        private void cbbListCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = (string)cbbListCamera.SelectedItem;
            Console.WriteLine(x);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var x = (string)cbbListCamera.SelectedItem;
            PhoxiFunc.ConnectPhoXiDeviceBySerialExample(x);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            PhoxiFunc.DisconnectExample();
        }

        private void btnPrintCamInfo_Click(object sender, EventArgs e)
        {
            PhoxiFunc.BasicDeviceInfo();
            PhoxiFunc.BasicDeviceStateExample();
        }

        

        private void btnFreeRun_Click(object sender, EventArgs e)
        {
            try
            {
                PhoxiFunc.FreerunExample();
            }
            catch (Exception ex)
            {
                MyLib.showDlgError(ex.Message);
            }
        }

        private void btnSwTrigger_Click(object sender, EventArgs e)
        {
            try
            {
                PhoxiFunc.SoftwareTriggerExample();
            }
            catch (Exception ex)
            {
                MyLib.showDlgError(ex.Message);
            }
        }

        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            try
            {
                PhoxiFunc.ChangeProfileExample();
            }
            catch (Exception ex)
            {
                MyLib.showDlgError(ex.Message);
            }
        }

        private void btnDataHandling_Click(object sender, EventArgs e)
        {
            try
            {
                PhoxiFunc.DataHandlingExample();
            }
            catch (Exception ex)
            {
                MyLib.showDlgError(ex.Message);
            }
        }

        private void btnChangeSetting_Click(object sender, EventArgs e)
        {
            try
            {
                PhoxiFunc.ChangeSettingsExample();
            }
            catch (Exception ex)
            {
                MyLib.showDlgError(ex.Message);
            }
        }

    }
}
