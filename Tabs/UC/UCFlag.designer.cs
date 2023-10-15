namespace TanHungHa.Tabs.UC
{
    partial class UCFlag
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
            this.Info = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Info.ForeColor = System.Drawing.Color.Black;
            this.Info.Location = new System.Drawing.Point(29, 1);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(104, 21);
            this.Info.TabIndex = 5;
            this.Info.Text = "PLC";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // State
            // 
            this.State.FlatAppearance.BorderSize = 0;
            this.State.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.State.Image = global::TanHungHa.Properties.Resources.Log_Off;
            this.State.Location = new System.Drawing.Point(-1, -1);
            this.State.Margin = new System.Windows.Forms.Padding(4);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(31, 25);
            this.State.TabIndex = 4;
            this.State.UseVisualStyleBackColor = true;
            // 
            // UCFlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Info);
            this.Controls.Add(this.State);
            this.Name = "UCFlag";
            this.Size = new System.Drawing.Size(136, 24);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label Info;
        public System.Windows.Forms.Button State;
    }
}
