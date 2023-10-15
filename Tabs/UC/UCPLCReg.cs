using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanHungHa.Common.PLC;

namespace TanHungHa.Tabs.UC
{
    public partial class UCPLCReg : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        private MyPLC myPLC = MyPLC.GetInstance();
        public PLCRegister obj { get; set; }

       

        public UCPLCReg()
        {
            InitializeComponent();
        }

        public UCPLCReg(PLCRegister _obj)
        {
            InitializeComponent();
            obj = _obj;
            FistUpdateStatus();


            //click
            State.Click += State_Click;

            obj.PropertyChanged += Obj_PropertyChanged;
            labelHint.Click += LabelHint_Click;

            toolTip1.SetToolTip(labelHint, obj.Description);
        }

        private void LabelHint_Click(object sender, EventArgs e)
        {
            toolTip1.Show(obj.Description, labelHint,0,0, 2000);
            OnPropertyChanged("LabelHintClick");
        }

        public void FistUpdateStatus()
        {
            //init param
            NameObj.Text = obj.Purpose;
            PLCAddress.Text = obj.Register.ToUpper();

            if (obj.Register.Contains("X") ||
                obj.Register.Contains("Y") ||
                obj.Register.Contains("M"))
            {
                RegValue.Visible = true;

                bool cur_val = Convert.ToBoolean(myPLC.GetValue(obj));
                if (cur_val)
                    State.Image = Properties.Resources.Log_On;
                else
                    State.Image = Properties.Resources.Log_Off;

                State.Update();
            }
            else
            {
                RegValue.Visible = true;
                RegValue.Text = obj.GetValue().ToString();
                //Binding dataRegBD = new Binding("Text", obj, "val", true, DataSourceUpdateMode.OnPropertyChanged);
                //RegValue.DataBindings.Add(dataRegBD);
                //RegValue.KeyDown += RegValue_KeyDown;

                State.Visible = false;

            }
        }

        private void Obj_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (!IsHandleCreated)
            //    return;
            //Console.WriteLine(e.PropertyName);
            switch (e.PropertyName)
            {
                case "purpose":

                    if (!NameObj.IsHandleCreated)
                        return;
                    if(NameObj.InvokeRequired)
                    {
                        NameObj.BeginInvoke(new Action(() =>
                                {
                                    NameObj.Text = obj.Purpose;
                                }));
                    }
                    break;

                case "register":
                    if (!PLCAddress.IsHandleCreated)
                        return;

                    if(PLCAddress.InvokeRequired)
                    {
                        PLCAddress.BeginInvoke(new Action(() =>
                                    {
                                        PLCAddress.Text = obj.Register;
                                    }));
                    }
                    break;

                case "value":

                    if (    obj.Register.Contains("X") ||
                            obj.Register.Contains("Y") ||
                            obj.Register.Contains("M"))
                        {

                        if (!State.IsHandleCreated)
                            return;
                        if(State.InvokeRequired)
                        {
                            State.BeginInvoke(new Action(() =>
                                            {
                                                bool cur_val = Convert.ToBoolean(myPLC.GetValue(obj));
                                                if (cur_val)
                                                {
                                                    this.State.Image = Properties.Resources.Log_On;
                                                }
                                                else
                                                {
                                                    this.State.Image = Properties.Resources.Log_Off;
                                                }
                                                this.State.Update();

                                            }));
                        }
                        
                    }
                    //else
                    {
                        if (!RegValue.IsHandleCreated)
                            return;
                        if(RegValue.InvokeRequired)
                        {
                            RegValue.BeginInvoke(new Action(() =>
                            {
                                RegValue.Text = obj.Value.ToString();
                            }));
                        }
                    }    
                    break;

                default:
                    break;
            }
        }

        private void State_Click(object sender, EventArgs e)
        {
            //get current value and toggle it
            if (obj.Register.Contains("X") ||
                obj.Register.Contains("Y") ||
                obj.Register.Contains("M"))
            {
                //get current value
                bool cur_val = Convert.ToBoolean(myPLC.GetValue(obj));

                //toggle
                myPLC.SetValue(Convert.ToInt16(!cur_val), obj);

                //read again
                cur_val = Convert.ToBoolean(myPLC.GetValue(obj));

                //update
                if (cur_val)
                    State.Image = Properties.Resources.Log_On;
                else
                    State.Image = Properties.Resources.Log_Off;
                
                State.Update();
            }


        }
    }
}
