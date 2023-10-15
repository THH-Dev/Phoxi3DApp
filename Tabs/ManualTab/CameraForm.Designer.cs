namespace TanHungHa.Tabs.ManualTab
{
    partial class CameraForm
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
            this.components = new System.ComponentModel.Container();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindDevices = new MaterialSkin.Controls.MaterialButton();
            this.cbbListCamera = new MaterialSkin.Controls.MaterialComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setCamTapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCamJigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnConnect = new MaterialSkin.Controls.MaterialButton();
            this.btnDisconnect = new MaterialSkin.Controls.MaterialButton();
            this.btnPrintCamInfo = new MaterialSkin.Controls.MaterialButton();
            this.btnChangeSetting = new MaterialSkin.Controls.MaterialButton();
            this.btnFreeRun = new MaterialSkin.Controls.MaterialButton();
            this.btnSwTrigger = new MaterialSkin.Controls.MaterialButton();
            this.btnChangeProfile = new MaterialSkin.Controls.MaterialButton();
            this.btnDataHandling = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(3, 4);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(121, 41);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Camera";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Select Excel File";
            this.openFileDialog.Filter = "image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnDataHandling);
            this.panel1.Controls.Add(this.btnChangeProfile);
            this.panel1.Controls.Add(this.btnChangeSetting);
            this.panel1.Controls.Add(this.btnSwTrigger);
            this.panel1.Controls.Add(this.btnFreeRun);
            this.panel1.Controls.Add(this.btnPrintCamInfo);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.btnFindDevices);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.cbbListCamera);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 524);
            this.panel1.TabIndex = 14;
            // 
            // btnFindDevices
            // 
            this.btnFindDevices.AutoSize = false;
            this.btnFindDevices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindDevices.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFindDevices.Depth = 0;
            this.btnFindDevices.HighEmphasis = true;
            this.btnFindDevices.Icon = global::TanHungHa.Properties.Resources.outline_search_white_24dp;
            this.btnFindDevices.Location = new System.Drawing.Point(10, 51);
            this.btnFindDevices.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindDevices.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFindDevices.Name = "btnFindDevices";
            this.btnFindDevices.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFindDevices.Size = new System.Drawing.Size(137, 33);
            this.btnFindDevices.TabIndex = 12;
            this.btnFindDevices.Text = "Find Devices";
            this.btnFindDevices.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFindDevices.UseAccentColor = false;
            this.btnFindDevices.UseVisualStyleBackColor = true;
            this.btnFindDevices.Click += new System.EventHandler(this.btnFindDevices_Click);
            // 
            // cbbListCamera
            // 
            this.cbbListCamera.AutoResize = false;
            this.cbbListCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbListCamera.Depth = 0;
            this.cbbListCamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbListCamera.DropDownHeight = 118;
            this.cbbListCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbListCamera.DropDownWidth = 121;
            this.cbbListCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbListCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbListCamera.FormattingEnabled = true;
            this.cbbListCamera.Hint = "Danh sách camera";
            this.cbbListCamera.IntegralHeight = false;
            this.cbbListCamera.ItemHeight = 29;
            this.cbbListCamera.Location = new System.Drawing.Point(10, 93);
            this.cbbListCamera.MaxDropDownItems = 4;
            this.cbbListCamera.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbListCamera.Name = "cbbListCamera";
            this.cbbListCamera.Size = new System.Drawing.Size(569, 35);
            this.cbbListCamera.StartIndex = 0;
            this.cbbListCamera.TabIndex = 11;
            this.cbbListCamera.UseTallSize = false;
            this.cbbListCamera.SelectedIndexChanged += new System.EventHandler(this.cbbListCamera_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCamTapeToolStripMenuItem,
            this.setCamJigToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 48);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // setCamTapeToolStripMenuItem
            // 
            this.setCamTapeToolStripMenuItem.Name = "setCamTapeToolStripMenuItem";
            this.setCamTapeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.setCamTapeToolStripMenuItem.Text = "Set cam Tape";
            // 
            // setCamJigToolStripMenuItem
            // 
            this.setCamJigToolStripMenuItem.Name = "setCamJigToolStripMenuItem";
            this.setCamJigToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.setCamJigToolStripMenuItem.Text = "Set cam Jig";
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = false;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConnect.Depth = 0;
            this.btnConnect.HighEmphasis = true;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(10, 176);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConnect.Size = new System.Drawing.Size(105, 33);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConnect.UseAccentColor = false;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AutoSize = false;
            this.btnDisconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisconnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDisconnect.Depth = 0;
            this.btnDisconnect.HighEmphasis = true;
            this.btnDisconnect.Icon = null;
            this.btnDisconnect.Location = new System.Drawing.Point(10, 221);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDisconnect.Size = new System.Drawing.Size(105, 33);
            this.btnDisconnect.TabIndex = 12;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDisconnect.UseAccentColor = false;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnPrintCamInfo
            // 
            this.btnPrintCamInfo.AutoSize = false;
            this.btnPrintCamInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintCamInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintCamInfo.Depth = 0;
            this.btnPrintCamInfo.HighEmphasis = true;
            this.btnPrintCamInfo.Icon = null;
            this.btnPrintCamInfo.Location = new System.Drawing.Point(143, 176);
            this.btnPrintCamInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintCamInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintCamInfo.Name = "btnPrintCamInfo";
            this.btnPrintCamInfo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintCamInfo.Size = new System.Drawing.Size(105, 33);
            this.btnPrintCamInfo.TabIndex = 12;
            this.btnPrintCamInfo.Text = "Print CAM Info";
            this.btnPrintCamInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintCamInfo.UseAccentColor = false;
            this.btnPrintCamInfo.UseVisualStyleBackColor = true;
            this.btnPrintCamInfo.Click += new System.EventHandler(this.btnPrintCamInfo_Click);
            // 
            // btnChangeSetting
            // 
            this.btnChangeSetting.AutoSize = false;
            this.btnChangeSetting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeSetting.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChangeSetting.Depth = 0;
            this.btnChangeSetting.HighEmphasis = true;
            this.btnChangeSetting.Icon = null;
            this.btnChangeSetting.Location = new System.Drawing.Point(143, 311);
            this.btnChangeSetting.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangeSetting.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangeSetting.Name = "btnChangeSetting";
            this.btnChangeSetting.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChangeSetting.Size = new System.Drawing.Size(105, 33);
            this.btnChangeSetting.TabIndex = 12;
            this.btnChangeSetting.Text = " CAM change setting";
            this.btnChangeSetting.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChangeSetting.UseAccentColor = false;
            this.btnChangeSetting.UseVisualStyleBackColor = true;
            this.btnChangeSetting.Click += new System.EventHandler(this.btnChangeSetting_Click);
            // 
            // btnFreeRun
            // 
            this.btnFreeRun.AutoSize = false;
            this.btnFreeRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFreeRun.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFreeRun.Depth = 0;
            this.btnFreeRun.HighEmphasis = true;
            this.btnFreeRun.Icon = null;
            this.btnFreeRun.Location = new System.Drawing.Point(143, 221);
            this.btnFreeRun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFreeRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFreeRun.Name = "btnFreeRun";
            this.btnFreeRun.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFreeRun.Size = new System.Drawing.Size(105, 33);
            this.btnFreeRun.TabIndex = 12;
            this.btnFreeRun.Text = "Free run";
            this.btnFreeRun.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFreeRun.UseAccentColor = false;
            this.btnFreeRun.UseVisualStyleBackColor = true;
            this.btnFreeRun.Click += new System.EventHandler(this.btnFreeRun_Click);
            // 
            // btnSwTrigger
            // 
            this.btnSwTrigger.AutoSize = false;
            this.btnSwTrigger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSwTrigger.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSwTrigger.Depth = 0;
            this.btnSwTrigger.HighEmphasis = true;
            this.btnSwTrigger.Icon = null;
            this.btnSwTrigger.Location = new System.Drawing.Point(143, 266);
            this.btnSwTrigger.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSwTrigger.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSwTrigger.Name = "btnSwTrigger";
            this.btnSwTrigger.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSwTrigger.Size = new System.Drawing.Size(105, 33);
            this.btnSwTrigger.TabIndex = 12;
            this.btnSwTrigger.Text = "SW TRig";
            this.btnSwTrigger.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSwTrigger.UseAccentColor = false;
            this.btnSwTrigger.UseVisualStyleBackColor = true;
            this.btnSwTrigger.Click += new System.EventHandler(this.btnSwTrigger_Click);
            // 
            // btnChangeProfile
            // 
            this.btnChangeProfile.AutoSize = false;
            this.btnChangeProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeProfile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChangeProfile.Depth = 0;
            this.btnChangeProfile.HighEmphasis = true;
            this.btnChangeProfile.Icon = null;
            this.btnChangeProfile.Location = new System.Drawing.Point(143, 356);
            this.btnChangeProfile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangeProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangeProfile.Name = "btnChangeProfile";
            this.btnChangeProfile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChangeProfile.Size = new System.Drawing.Size(105, 33);
            this.btnChangeProfile.TabIndex = 12;
            this.btnChangeProfile.Text = " CAM change profile";
            this.btnChangeProfile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChangeProfile.UseAccentColor = false;
            this.btnChangeProfile.UseVisualStyleBackColor = true;
            this.btnChangeProfile.Click += new System.EventHandler(this.btnChangeProfile_Click);
            // 
            // btnDataHandling
            // 
            this.btnDataHandling.AutoSize = false;
            this.btnDataHandling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDataHandling.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDataHandling.Depth = 0;
            this.btnDataHandling.HighEmphasis = true;
            this.btnDataHandling.Icon = null;
            this.btnDataHandling.Location = new System.Drawing.Point(143, 401);
            this.btnDataHandling.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDataHandling.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDataHandling.Name = "btnDataHandling";
            this.btnDataHandling.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDataHandling.Size = new System.Drawing.Size(105, 33);
            this.btnDataHandling.TabIndex = 12;
            this.btnDataHandling.Text = "Data handling";
            this.btnDataHandling.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDataHandling.UseAccentColor = false;
            this.btnDataHandling.UseVisualStyleBackColor = true;
            this.btnDataHandling.Click += new System.EventHandler(this.btnDataHandling_Click);
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 527);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "CameraForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "RS232Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialComboBox cbbListCamera;
        private MaterialSkin.Controls.MaterialButton btnFindDevices;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setCamTapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCamJigToolStripMenuItem;
        private MaterialSkin.Controls.MaterialButton btnDisconnect;
        private MaterialSkin.Controls.MaterialButton btnConnect;
        private MaterialSkin.Controls.MaterialButton btnPrintCamInfo;
        private MaterialSkin.Controls.MaterialButton btnChangeSetting;
        private MaterialSkin.Controls.MaterialButton btnSwTrigger;
        private MaterialSkin.Controls.MaterialButton btnFreeRun;
        private MaterialSkin.Controls.MaterialButton btnDataHandling;
        private MaterialSkin.Controls.MaterialButton btnChangeProfile;
    }
}