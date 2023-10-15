namespace TanHungHa.Tabs.UC
{
    partial class UCPLCReg
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.State = new System.Windows.Forms.Button();
            this.NameObj = new System.Windows.Forms.Label();
            this.PLCAddress = new System.Windows.Forms.Label();
            this.RegValue = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // State
            // 
            this.State.FlatAppearance.BorderSize = 0;
            this.State.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.State.Image = global::TanHungHa.Properties.Resources.Log_On;
            this.State.Location = new System.Drawing.Point(6, 3);
            this.State.Margin = new System.Windows.Forms.Padding(4);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(41, 34);
            this.State.TabIndex = 0;
            this.State.UseVisualStyleBackColor = true;
            // 
            // NameObj
            // 
            this.NameObj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NameObj.Location = new System.Drawing.Point(149, 11);
            this.NameObj.Name = "NameObj";
            this.NameObj.Size = new System.Drawing.Size(184, 21);
            this.NameObj.TabIndex = 1;
            this.NameObj.Text = "Sensor";
            this.NameObj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PLCAddress
            // 
            this.PLCAddress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PLCAddress.ForeColor = System.Drawing.Color.Black;
            this.PLCAddress.Location = new System.Drawing.Point(339, 11);
            this.PLCAddress.Name = "PLCAddress";
            this.PLCAddress.Size = new System.Drawing.Size(82, 21);
            this.PLCAddress.TabIndex = 1;
            this.PLCAddress.Text = "PLC";
            this.PLCAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegValue
            // 
            this.RegValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RegValue.Location = new System.Drawing.Point(54, 10);
            this.RegValue.Name = "RegValue";
            this.RegValue.Size = new System.Drawing.Size(89, 23);
            this.RegValue.TabIndex = 4;
            this.RegValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHint
            // 
            this.labelHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelHint.ForeColor = System.Drawing.Color.Black;
            this.labelHint.Location = new System.Drawing.Point(427, 11);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(23, 21);
            this.labelHint.TabIndex = 1;
            this.labelHint.Text = "?";
            this.labelHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCPLCReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.PLCAddress);
            this.Controls.Add(this.NameObj);
            this.Controls.Add(this.RegValue);
            this.Controls.Add(this.State);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCPLCReg";
            this.Size = new System.Drawing.Size(456, 42);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button State;
        public System.Windows.Forms.Label NameObj;
        public System.Windows.Forms.Label PLCAddress;
        private System.Windows.Forms.Label RegValue;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label labelHint;
    }
}
