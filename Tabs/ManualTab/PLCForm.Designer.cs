namespace TanHungHa.Tabs.ManualTab
{
    partial class PLCForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbModeRW = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAutoScanPLC = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnRead = new MaterialSkin.Controls.MaterialButton();
            this.btnWrite = new MaterialSkin.Controls.MaterialButton();
            this.btnLoadREG = new MaterialSkin.Controls.MaterialButton();
            this.btnScanREG = new MaterialSkin.Controls.MaterialButton();
            this.btnConnectPLC = new MaterialSkin.Controls.MaterialButton();
            this.txtPLCVal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPLCAdress = new MaterialSkin.Controls.MaterialTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel_X = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_M = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel_Y = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_D = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(9, 31);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 41);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "PLC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbModeRW);
            this.panel1.Controls.Add(this.btnAutoScanPLC);
            this.panel1.Controls.Add(this.btnRead);
            this.panel1.Controls.Add(this.btnWrite);
            this.panel1.Controls.Add(this.btnLoadREG);
            this.panel1.Controls.Add(this.btnScanREG);
            this.panel1.Controls.Add(this.btnConnectPLC);
            this.panel1.Controls.Add(this.txtPLCVal);
            this.panel1.Controls.Add(this.txtPLCAdress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 81);
            this.panel1.TabIndex = 14;
            // 
            // cbbModeRW
            // 
            this.cbbModeRW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbModeRW.AutoResize = false;
            this.cbbModeRW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbModeRW.Depth = 0;
            this.cbbModeRW.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbModeRW.DropDownHeight = 118;
            this.cbbModeRW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbModeRW.DropDownWidth = 121;
            this.cbbModeRW.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbModeRW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbModeRW.FormattingEnabled = true;
            this.cbbModeRW.Hint = "Mode R/W";
            this.cbbModeRW.IntegralHeight = false;
            this.cbbModeRW.ItemHeight = 29;
            this.cbbModeRW.Location = new System.Drawing.Point(374, 30);
            this.cbbModeRW.MaxDropDownItems = 4;
            this.cbbModeRW.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbModeRW.Name = "cbbModeRW";
            this.cbbModeRW.Size = new System.Drawing.Size(131, 35);
            this.cbbModeRW.StartIndex = 0;
            this.cbbModeRW.TabIndex = 12;
            this.cbbModeRW.UseTallSize = false;
            // 
            // btnAutoScanPLC
            // 
            this.btnAutoScanPLC.AutoSize = true;
            this.btnAutoScanPLC.Checked = true;
            this.btnAutoScanPLC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAutoScanPLC.Depth = 0;
            this.btnAutoScanPLC.Location = new System.Drawing.Point(209, 30);
            this.btnAutoScanPLC.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutoScanPLC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnAutoScanPLC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAutoScanPLC.Name = "btnAutoScanPLC";
            this.btnAutoScanPLC.ReadOnly = false;
            this.btnAutoScanPLC.Ripple = true;
            this.btnAutoScanPLC.Size = new System.Drawing.Size(108, 37);
            this.btnAutoScanPLC.TabIndex = 11;
            this.btnAutoScanPLC.Text = "Auto Scan";
            this.btnAutoScanPLC.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.AutoSize = false;
            this.btnRead.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRead.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRead.Depth = 0;
            this.btnRead.Enabled = false;
            this.btnRead.HighEmphasis = true;
            this.btnRead.Icon = global::TanHungHa.Properties.Resources.outline_sensors_black_24dp;
            this.btnRead.Location = new System.Drawing.Point(793, 45);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRead.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRead.Name = "btnRead";
            this.btnRead.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRead.Size = new System.Drawing.Size(92, 27);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "Read";
            this.btnRead.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRead.UseAccentColor = false;
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnPLCActionClick);
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite.AutoSize = false;
            this.btnWrite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWrite.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnWrite.Depth = 0;
            this.btnWrite.Enabled = false;
            this.btnWrite.HighEmphasis = true;
            this.btnWrite.Icon = global::TanHungHa.Properties.Resources.outline_sensors_black_24dp;
            this.btnWrite.Location = new System.Drawing.Point(793, 12);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnWrite.Size = new System.Drawing.Size(92, 27);
            this.btnWrite.TabIndex = 10;
            this.btnWrite.Text = "Write";
            this.btnWrite.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnWrite.UseAccentColor = false;
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnPLCActionClick);
            // 
            // btnLoadREG
            // 
            this.btnLoadREG.AutoSize = false;
            this.btnLoadREG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadREG.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoadREG.Depth = 0;
            this.btnLoadREG.HighEmphasis = true;
            this.btnLoadREG.Icon = global::TanHungHa.Properties.Resources.outline_sensors_black_24dp;
            this.btnLoadREG.Location = new System.Drawing.Point(343, 31);
            this.btnLoadREG.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadREG.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadREG.Name = "btnLoadREG";
            this.btnLoadREG.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoadREG.Size = new System.Drawing.Size(126, 36);
            this.btnLoadREG.TabIndex = 10;
            this.btnLoadREG.Text = "Load REG";
            this.btnLoadREG.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoadREG.UseAccentColor = false;
            this.btnLoadREG.UseVisualStyleBackColor = true;
            this.btnLoadREG.Visible = false;
            this.btnLoadREG.Click += new System.EventHandler(this.btnPLCActionClick);
            // 
            // btnScanREG
            // 
            this.btnScanREG.AutoSize = false;
            this.btnScanREG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScanREG.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnScanREG.Depth = 0;
            this.btnScanREG.HighEmphasis = true;
            this.btnScanREG.Icon = global::TanHungHa.Properties.Resources.outline_sensors_black_24dp;
            this.btnScanREG.Location = new System.Drawing.Point(209, 31);
            this.btnScanREG.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnScanREG.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScanREG.Name = "btnScanREG";
            this.btnScanREG.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnScanREG.Size = new System.Drawing.Size(126, 36);
            this.btnScanREG.TabIndex = 10;
            this.btnScanREG.Text = "SCAN REG";
            this.btnScanREG.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnScanREG.UseAccentColor = false;
            this.btnScanREG.UseVisualStyleBackColor = true;
            this.btnScanREG.Visible = false;
            this.btnScanREG.Click += new System.EventHandler(this.btnPLCActionClick);
            // 
            // btnConnectPLC
            // 
            this.btnConnectPLC.AutoSize = false;
            this.btnConnectPLC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnectPLC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConnectPLC.Depth = 0;
            this.btnConnectPLC.HighEmphasis = true;
            this.btnConnectPLC.Icon = global::TanHungHa.Properties.Resources.outline_sensors_black_24dp;
            this.btnConnectPLC.Location = new System.Drawing.Point(75, 31);
            this.btnConnectPLC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnectPLC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnectPLC.Name = "btnConnectPLC";
            this.btnConnectPLC.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConnectPLC.Size = new System.Drawing.Size(126, 36);
            this.btnConnectPLC.TabIndex = 10;
            this.btnConnectPLC.Text = "Connect";
            this.btnConnectPLC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConnectPLC.UseAccentColor = false;
            this.btnConnectPLC.UseVisualStyleBackColor = true;
            this.btnConnectPLC.Click += new System.EventHandler(this.btnPLCActionClick);
            // 
            // txtPLCVal
            // 
            this.txtPLCVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPLCVal.AnimateReadOnly = false;
            this.txtPLCVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPLCVal.Depth = 0;
            this.txtPLCVal.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPLCVal.Hint = "Value";
            this.txtPLCVal.LeadingIcon = global::TanHungHa.Properties.Resources.outline_settings_black_18dp;
            this.txtPLCVal.Location = new System.Drawing.Point(641, 22);
            this.txtPLCVal.MaxLength = 50;
            this.txtPLCVal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPLCVal.Multiline = false;
            this.txtPLCVal.Name = "txtPLCVal";
            this.txtPLCVal.Size = new System.Drawing.Size(115, 50);
            this.txtPLCVal.TabIndex = 7;
            this.txtPLCVal.Text = "1";
            this.txtPLCVal.TrailingIcon = global::TanHungHa.Properties.Resources.outline_close_black_24dp;
            this.txtPLCVal.LeadingIconClick += new System.EventHandler(this.txtPLCVal_LeadingIconClick);
            this.txtPLCVal.TrailingIconClick += new System.EventHandler(this.txtPLCVal_TrailingIconClick);
            // 
            // txtPLCAdress
            // 
            this.txtPLCAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPLCAdress.AnimateReadOnly = false;
            this.txtPLCAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPLCAdress.Depth = 0;
            this.txtPLCAdress.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPLCAdress.Hint = "Reg Adress";
            this.txtPLCAdress.LeadingIcon = null;
            this.txtPLCAdress.Location = new System.Drawing.Point(511, 22);
            this.txtPLCAdress.MaxLength = 50;
            this.txtPLCAdress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPLCAdress.Multiline = false;
            this.txtPLCAdress.Name = "txtPLCAdress";
            this.txtPLCAdress.Size = new System.Drawing.Size(115, 50);
            this.txtPLCAdress.TabIndex = 7;
            this.txtPLCAdress.Text = "M4";
            this.txtPLCAdress.TrailingIcon = global::TanHungHa.Properties.Resources.outline_close_black_24dp;
            this.txtPLCAdress.TrailingIconClick += new System.EventHandler(this.txtPLCAdress_TrailingIconClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 81);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(898, 401);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.TabIndex = 15;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel_X);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel_M);
            this.splitContainer2.Size = new System.Drawing.Size(457, 401);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel_X
            // 
            this.flowLayoutPanel_X.AutoScroll = true;
            this.flowLayoutPanel_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_X.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_X.Name = "flowLayoutPanel_X";
            this.flowLayoutPanel_X.Size = new System.Drawing.Size(457, 25);
            this.flowLayoutPanel_X.TabIndex = 5;
            // 
            // flowLayoutPanel_M
            // 
            this.flowLayoutPanel_M.AutoScroll = true;
            this.flowLayoutPanel_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_M.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_M.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_M.Name = "flowLayoutPanel_M";
            this.flowLayoutPanel_M.Size = new System.Drawing.Size(457, 372);
            this.flowLayoutPanel_M.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.flowLayoutPanel_Y);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.flowLayoutPanel_D);
            this.splitContainer3.Size = new System.Drawing.Size(437, 401);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 0;
            // 
            // flowLayoutPanel_Y
            // 
            this.flowLayoutPanel_Y.AutoScroll = true;
            this.flowLayoutPanel_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Y.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_Y.Name = "flowLayoutPanel_Y";
            this.flowLayoutPanel_Y.Size = new System.Drawing.Size(437, 25);
            this.flowLayoutPanel_Y.TabIndex = 6;
            // 
            // flowLayoutPanel_D
            // 
            this.flowLayoutPanel_D.AutoScroll = true;
            this.flowLayoutPanel_D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_D.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_D.Name = "flowLayoutPanel_D";
            this.flowLayoutPanel_D.Size = new System.Drawing.Size(437, 372);
            this.flowLayoutPanel_D.TabIndex = 6;
            // 
            // PLCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 485);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "PLCForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "PLCForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_X;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_M;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Y;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_D;
        private MaterialSkin.Controls.MaterialButton btnConnectPLC;
        private MaterialSkin.Controls.MaterialButton btnRead;
        private MaterialSkin.Controls.MaterialButton btnWrite;
        private MaterialSkin.Controls.MaterialTextBox txtPLCVal;
        private MaterialSkin.Controls.MaterialButton btnScanREG;
        private MaterialSkin.Controls.MaterialButton btnLoadREG;
        private MaterialSkin.Controls.MaterialCheckbox btnAutoScanPLC;
        private MaterialSkin.Controls.MaterialComboBox cbbModeRW;
        public MaterialSkin.Controls.MaterialTextBox txtPLCAdress;
    }
}