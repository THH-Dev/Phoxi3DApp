using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanHungHa.Common;
using TanHungHa.Common.PLC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TanHungHa.Tabs.ManualTab
{
    public partial class ManParamForm : MaterialForm
    {
        private static ManParamForm _instance;
        private static readonly object _lock = new object();
        public static ManParamForm GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ManParamForm();
                    }
                }
            }
            return _instance;
        }

        public ManParamForm()
        {
            InitializeComponent();
            InitTreeView();
        }


        public void InitTreeView()
        {
            treeView.Nodes.Clear();
            treeView.BeginUpdate();
            TreeNode treeNodeRunParam = new TreeNode(Text = MyDefine.treenodeRunParam);
            TreeNode treeNodeController = new TreeNode(Text = MyDefine.treenodeLightController);

            TreeNode treeNodePLC = new TreeNode(Text = MyDefine.treenodePLC);
            TreeNode subTreeNodePLCAssignment = new TreeNode(Text = MyDefine.subtreenodePLCAssignment);
            
            TreeNode treeNodeEzi = new TreeNode(Text = MyDefine.treenodeEzi);
            TreeNode treeNodeRobot = new TreeNode(Text = MyDefine.treenodeRobot);

            TreeNode treeNodeTime = new TreeNode(Text = MyDefine.treenodeTime);
            
            TreeNode treeNodeRS232 = new TreeNode(Text = MyDefine.treenodeRS232);
            TreeNode treeNodeTheme = new TreeNode(Text = MyDefine.treenodeTheme);
            TreeNode treeNodeDev = new TreeNode(Text = MyDefine.treenodeDev);
            TreeNode treeLinescan = new TreeNode(Text = MyDefine.treeLineScan);

            foreach (var plcReg in MyParam.list_plc_reg)
            {
                string plcAddress = plcReg.Register;
                subTreeNodePLCAssignment.Nodes.Add(new TreeNode(Text = plcAddress));
            }
            

            treeView.Nodes.Add(treeNodeRunParam);
            //treeView.Nodes.Add(treeNodeTheme);
            treeView.Nodes.Add(treeNodeDev);
            treeView.Nodes.Add(treeNodeTime);
            treeView.Nodes.Add(treeNodeController);
            treeNodePLC.Nodes.Add(subTreeNodePLCAssignment);
            treeView.Nodes.Add(treeNodePLC);
            treeView.Nodes.Add(treeNodeEzi);
            treeView.Nodes.Add(treeNodeRobot);
            treeView.Nodes.Add(treeLinescan);
            treeView.EndUpdate();

            treeView.SelectedNode = treeNodeRunParam;
        }


        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNodeText = e.Node.Text;
            Console.WriteLine(selectedNodeText);
            switch (selectedNodeText)
            {
                //Run param
                case MyDefine.treenodeRunParam:
                    propertyGrid.SelectedObject = MyParam.runParam;
                    break;
                    
                //Time
                case MyDefine.treenodeTime:
                    propertyGrid.SelectedObject = MyParam.commonParam.timeDelay;
                    break;

                
                //RS232
                case MyDefine.treenodeRS232:
                    propertyGrid.SelectedObject = MyParam.commonParam.myComport;
                    break;

                //PLC
                case MyDefine.treenodePLC:
                    propertyGrid.SelectedObject = MyParam.commonParam.PLCParam;
                    break;
                //PLC Assigment
                case MyDefine.subtreenodePLCAssignment:
                    propertyGrid.SelectedObject = MyParam.list_plc_reg;
                    break;
                //Theme
                case MyDefine.treenodeTheme:
                    propertyGrid.SelectedObject = MyParam.uIParam;
                    break;
                //Dev
                case MyDefine.treenodeDev:
                    propertyGrid.SelectedObject = MyParam.commonParam.devParam;
                    break;
               

                //case MyDefine.treeLineScan:
                //    propertyGrid.SelectedObject = MyParam.commonParam.lineScanLib;
                //    break;

                default:
                    foreach (var plcReg in MyParam.list_plc_reg)
                    {
                        string plcAddress = plcReg.Register;
                        if (selectedNodeText == plcAddress)
                        {
                            propertyGrid.SelectedObject = plcReg;
                        }
                    }

                    break;

            }
        }

        private void propertyGrid_SelectedObjectsChanged(object sender, EventArgs e)
        {
            propertyGrid.Update();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string selectedNodeText = treeView.SelectedNode.Text;
            Console.WriteLine(selectedNodeText);
            switch (selectedNodeText)
            {
                

                //Light controller
                case MyDefine.treenodeLightController:
                    //propertyGrid.SelectedObject = MyParam.commonParam.dpsController;
                    break;

                //RS232
                case MyDefine.treenodeRS232:
                    //propertyGrid.SelectedObject = MyParam.commonParam.myComport;
                    break;

                //PLC
                case MyDefine.treenodePLC:
                    //propertyGrid.SelectedObject = MyParam.commonParam.myPLC;
                    break;

                case MyDefine.subtreenodePLCAssignment:
                    //propertyGrid.SelectedObject = MyParam.list_plc_assignment;
                    break;



                case MyDefine.treenodeTheme:
                    //propertyGrid.SelectedObject = MyParam.uIParam;
                    break;
                case MyDefine.treenodeDev:
                    //propertyGrid.SelectedObject = MyParam.commonParam.devParam;
                    break;

                default:
                    //foreach (var plcReg in MyParam.list_plc_reg)
                    //{
                    //    string plcAddress = plcReg.Register;
                    //    if (selectedNodeText == plcAddress)
                    //    {
                    //        propertyGrid.SelectedObject = plcReg;
                    //    }
                    //}

                    break;

            }
        }

        private void btnSaveParam_Click(object sender, EventArgs e)
        {
            MyLib.SaveParamter();
        }

        private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            this.propertyGrid.Refresh();
        }
    }
}
