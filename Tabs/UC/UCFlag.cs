using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanHungHa.Tabs.UC
{
    public partial class UCFlag : UserControl
    {

        private bool _val;

        public bool val
        {
            get { return _val; }
            set { 
                
                if(_val != value)
                {
                    _val = value;
                    SetValue(_val);
                }
            
            }
        }
        public UCFlag()
        {
            InitializeComponent();
            val = false;
        }

        public void SetValue(bool val)
        {
            State.BeginInvoke(new Action(() =>
            {


                if (val)
                    this.State.Image = Properties.Resources.Log_On;
                else
                    this.State.Image = Properties.Resources.Log_Off;

                this.State.Update();


            }));
        }

        public void SetInfo(string val)
        {
            Info.BeginInvoke(new Action(() =>
            {
                Info.Text = val;
            }));
        }
    }
}
