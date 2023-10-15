namespace TanHungHa.Tabs
{
    partial class FormAuto
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
            this.lvLogCamTape = new MaterialSkin.Controls.MaterialListView();
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLog = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripTape = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearLogTapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageTapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnTrigger = new MaterialSkin.Controls.MaterialButton();
            this.btnInitial = new MaterialSkin.Controls.MaterialButton();
            this.btnStart = new MaterialSkin.Controls.MaterialButton();
            this.btnRestart = new MaterialSkin.Controls.MaterialButton();
            this.btnStop = new MaterialSkin.Controls.MaterialButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.panelTape = new System.Windows.Forms.Panel();
            this.pictureBoxCamTape = new System.Windows.Forms.PictureBox();
            this.contextMenuStripConfig = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.panelJig = new System.Windows.Forms.Panel();
            this.pictureBoxCamJig = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvLogCamJig = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripJig = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearLogJigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageJigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvLogJig = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelBot = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttRAM = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttCamTape = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttCamJig = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttPLC = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttController = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripTape.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            this.panelTape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamTape)).BeginInit();
            this.contextMenuStripConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            this.panelJig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamJig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripJig.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLogCamTape
            // 
            this.lvLogCamTape.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvLogCamTape.AutoSizeTable = false;
            this.lvLogCamTape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvLogCamTape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLogCamTape.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTime,
            this.columnHeaderLog});
            this.lvLogCamTape.ContextMenuStrip = this.contextMenuStripTape;
            this.lvLogCamTape.Depth = 0;
            this.lvLogCamTape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLogCamTape.FullRowSelect = true;
            this.lvLogCamTape.HideSelection = false;
            this.lvLogCamTape.HotTracking = true;
            this.lvLogCamTape.HoverSelection = true;
            this.lvLogCamTape.Location = new System.Drawing.Point(0, 0);
            this.lvLogCamTape.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvLogCamTape.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvLogCamTape.MouseState = MaterialSkin.MouseState.OUT;
            this.lvLogCamTape.Name = "lvLogCamTape";
            this.lvLogCamTape.OwnerDraw = true;
            this.lvLogCamTape.Size = new System.Drawing.Size(478, 100);
            this.lvLogCamTape.TabIndex = 1;
            this.lvLogCamTape.UseCompatibleStateImageBehavior = false;
            this.lvLogCamTape.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "TimeStamp";
            this.columnHeaderTime.Width = 110;
            // 
            // columnHeaderLog
            // 
            this.columnHeaderLog.Text = "Info";
            this.columnHeaderLog.Width = 1200;
            // 
            // contextMenuStripTape
            // 
            this.contextMenuStripTape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogTapeToolStripMenuItem,
            this.openImageTapeToolStripMenuItem});
            this.contextMenuStripTape.Name = "contextMenuStrip";
            this.contextMenuStripTape.Size = new System.Drawing.Size(140, 48);
            this.contextMenuStripTape.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripTape_ItemClicked);
            // 
            // clearLogTapeToolStripMenuItem
            // 
            this.clearLogTapeToolStripMenuItem.Name = "clearLogTapeToolStripMenuItem";
            this.clearLogTapeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clearLogTapeToolStripMenuItem.Text = "Clear Log";
            // 
            // openImageTapeToolStripMenuItem
            // 
            this.openImageTapeToolStripMenuItem.Name = "openImageTapeToolStripMenuItem";
            this.openImageTapeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openImageTapeToolStripMenuItem.Text = "Open Image";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnTrigger);
            this.panelTop.Controls.Add(this.btnInitial);
            this.panelTop.Controls.Add(this.btnStart);
            this.panelTop.Controls.Add(this.btnRestart);
            this.panelTop.Controls.Add(this.btnStop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(928, 49);
            this.panelTop.TabIndex = 1;
            // 
            // btnTrigger
            // 
            this.btnTrigger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrigger.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTrigger.Depth = 0;
            this.btnTrigger.HighEmphasis = true;
            this.btnTrigger.Icon = null;
            this.btnTrigger.Location = new System.Drawing.Point(4, 7);
            this.btnTrigger.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrigger.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTrigger.Size = new System.Drawing.Size(64, 36);
            this.btnTrigger.TabIndex = 0;
            this.btnTrigger.Text = "Trig";
            this.btnTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrigger.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnTrigger.UseAccentColor = false;
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // btnInitial
            // 
            this.btnInitial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInitial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInitial.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInitial.Depth = 0;
            this.btnInitial.HighEmphasis = true;
            this.btnInitial.Icon = global::TanHungHa.Properties.Resources.outline_play_circle_black_24dp;
            this.btnInitial.Location = new System.Drawing.Point(525, 6);
            this.btnInitial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInitial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInitial.Size = new System.Drawing.Size(99, 36);
            this.btnInitial.TabIndex = 1;
            this.btnInitial.Text = "INITIAL";
            this.btnInitial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInitial.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnInitial.UseAccentColor = true;
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnProgramAction);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStart.Depth = 0;
            this.btnStart.Enabled = false;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.HighEmphasis = true;
            this.btnStart.Icon = global::TanHungHa.Properties.Resources.outline_play_circle_black_24dp;
            this.btnStart.Location = new System.Drawing.Point(632, 6);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStart.Size = new System.Drawing.Size(95, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnStart.UseAccentColor = true;
            this.btnStart.UseCompatibleTextRendering = true;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnProgramAction);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRestart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRestart.Depth = 0;
            this.btnRestart.Enabled = false;
            this.btnRestart.HighEmphasis = true;
            this.btnRestart.Icon = global::TanHungHa.Properties.Resources.outline_restart_alt_black_24dp;
            this.btnRestart.Location = new System.Drawing.Point(825, 6);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRestart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRestart.Size = new System.Drawing.Size(93, 36);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "RESET";
            this.btnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRestart.UseAccentColor = true;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnProgramAction);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStop.Depth = 0;
            this.btnStop.Enabled = false;
            this.btnStop.HighEmphasis = true;
            this.btnStop.Icon = global::TanHungHa.Properties.Resources.outline_stop_black_24dp;
            this.btnStop.Location = new System.Drawing.Point(733, 6);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStop.Size = new System.Drawing.Size(86, 36);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "STOP";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnStop.UseAccentColor = true;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnProgramAction);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 49);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainerRight);
            this.splitContainer2.Size = new System.Drawing.Size(928, 444);
            this.splitContainer2.SplitterDistance = 478;
            this.splitContainer2.TabIndex = 2;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.panelTape);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.lvLogCamTape);
            this.splitContainerLeft.Size = new System.Drawing.Size(478, 444);
            this.splitContainerLeft.SplitterDistance = 340;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // panelTape
            // 
            this.panelTape.Controls.Add(this.pictureBoxCamTape);
            this.panelTape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTape.Location = new System.Drawing.Point(0, 0);
            this.panelTape.Name = "panelTape";
            this.panelTape.Size = new System.Drawing.Size(478, 340);
            this.panelTape.TabIndex = 0;
            // 
            // pictureBoxCamTape
            // 
            this.pictureBoxCamTape.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxCamTape.ContextMenuStrip = this.contextMenuStripConfig;
            this.pictureBoxCamTape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCamTape.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCamTape.Name = "pictureBoxCamTape";
            this.pictureBoxCamTape.Size = new System.Drawing.Size(478, 340);
            this.pictureBoxCamTape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamTape.TabIndex = 1;
            this.pictureBoxCamTape.TabStop = false;
            // 
            // contextMenuStripConfig
            // 
            this.contextMenuStripConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showConfigToolStripMenuItem});
            this.contextMenuStripConfig.Name = "contextMenuStripConfig";
            this.contextMenuStripConfig.Size = new System.Drawing.Size(143, 26);
            // 
            // showConfigToolStripMenuItem
            // 
            this.showConfigToolStripMenuItem.Name = "showConfigToolStripMenuItem";
            this.showConfigToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.showConfigToolStripMenuItem.Text = "Show Config";
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.panelJig);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainerRight.Size = new System.Drawing.Size(446, 444);
            this.splitContainerRight.SplitterDistance = 340;
            this.splitContainerRight.TabIndex = 1;
            // 
            // panelJig
            // 
            this.panelJig.Controls.Add(this.pictureBoxCamJig);
            this.panelJig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJig.Location = new System.Drawing.Point(0, 0);
            this.panelJig.Name = "panelJig";
            this.panelJig.Size = new System.Drawing.Size(446, 340);
            this.panelJig.TabIndex = 0;
            // 
            // pictureBoxCamJig
            // 
            this.pictureBoxCamJig.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxCamJig.ContextMenuStrip = this.contextMenuStripConfig;
            this.pictureBoxCamJig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCamJig.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCamJig.Name = "pictureBoxCamJig";
            this.pictureBoxCamJig.Size = new System.Drawing.Size(446, 340);
            this.pictureBoxCamJig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamJig.TabIndex = 1;
            this.pictureBoxCamJig.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvLogCamJig);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvLogJig);
            this.splitContainer1.Size = new System.Drawing.Size(446, 100);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 2;
            // 
            // lvLogCamJig
            // 
            this.lvLogCamJig.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvLogCamJig.AutoSizeTable = false;
            this.lvLogCamJig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvLogCamJig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLogCamJig.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvLogCamJig.ContextMenuStrip = this.contextMenuStripJig;
            this.lvLogCamJig.Depth = 0;
            this.lvLogCamJig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLogCamJig.FullRowSelect = true;
            this.lvLogCamJig.HideSelection = false;
            this.lvLogCamJig.HotTracking = true;
            this.lvLogCamJig.HoverSelection = true;
            this.lvLogCamJig.Location = new System.Drawing.Point(0, 0);
            this.lvLogCamJig.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvLogCamJig.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvLogCamJig.MouseState = MaterialSkin.MouseState.OUT;
            this.lvLogCamJig.Name = "lvLogCamJig";
            this.lvLogCamJig.OwnerDraw = true;
            this.lvLogCamJig.Size = new System.Drawing.Size(331, 100);
            this.lvLogCamJig.TabIndex = 1;
            this.lvLogCamJig.UseCompatibleStateImageBehavior = false;
            this.lvLogCamJig.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TimeStamp";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Info";
            this.columnHeader2.Width = 1200;
            // 
            // contextMenuStripJig
            // 
            this.contextMenuStripJig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogJigToolStripMenuItem,
            this.openImageJigToolStripMenuItem});
            this.contextMenuStripJig.Name = "contextMenuStrip";
            this.contextMenuStripJig.Size = new System.Drawing.Size(140, 48);
            this.contextMenuStripJig.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripJig_ItemClicked);
            // 
            // clearLogJigToolStripMenuItem
            // 
            this.clearLogJigToolStripMenuItem.Name = "clearLogJigToolStripMenuItem";
            this.clearLogJigToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clearLogJigToolStripMenuItem.Text = "Clear Log";
            // 
            // openImageJigToolStripMenuItem
            // 
            this.openImageJigToolStripMenuItem.Name = "openImageJigToolStripMenuItem";
            this.openImageJigToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openImageJigToolStripMenuItem.Text = "Open Image";
            // 
            // lvLogJig
            // 
            this.lvLogJig.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvLogJig.AutoSizeTable = false;
            this.lvLogJig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvLogJig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLogJig.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvLogJig.ContextMenuStrip = this.contextMenuStripJig;
            this.lvLogJig.Depth = 0;
            this.lvLogJig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLogJig.FullRowSelect = true;
            this.lvLogJig.HideSelection = false;
            this.lvLogJig.HotTracking = true;
            this.lvLogJig.HoverSelection = true;
            this.lvLogJig.Location = new System.Drawing.Point(0, 0);
            this.lvLogJig.MinimumSize = new System.Drawing.Size(100, 100);
            this.lvLogJig.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvLogJig.MouseState = MaterialSkin.MouseState.OUT;
            this.lvLogJig.Name = "lvLogJig";
            this.lvLogJig.OwnerDraw = true;
            this.lvLogJig.Size = new System.Drawing.Size(111, 100);
            this.lvLogJig.TabIndex = 2;
            this.lvLogJig.UseCompatibleStateImageBehavior = false;
            this.lvLogJig.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Jig Position";
            this.columnHeader4.Width = 250;
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.statusStrip1);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(3, 493);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(928, 25);
            this.panelBot.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttRAM,
            this.sttCamTape,
            this.sttCamJig,
            this.sttPLC,
            this.sttController});
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(928, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttRAM
            // 
            this.sttRAM.Name = "sttRAM";
            this.sttRAM.Size = new System.Drawing.Size(33, 17);
            this.sttRAM.Text = "RAM";
            // 
            // sttCamTape
            // 
            this.sttCamTape.Name = "sttCamTape";
            this.sttCamTape.Size = new System.Drawing.Size(63, 17);
            this.sttCamTape.Text = "CAM-Tape";
            // 
            // sttCamJig
            // 
            this.sttCamJig.Name = "sttCamJig";
            this.sttCamJig.Size = new System.Drawing.Size(53, 17);
            this.sttCamJig.Text = "CAM-Jig";
            // 
            // sttPLC
            // 
            this.sttPLC.Name = "sttPLC";
            this.sttPLC.Size = new System.Drawing.Size(28, 17);
            this.sttPLC.Text = "PLC";
            // 
            // sttController
            // 
            this.sttController.Name = "sttController";
            this.sttController.Size = new System.Drawing.Size(58, 17);
            this.sttController.Text = "Light-Ctrl";
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 521);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBot);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "FormAuto";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "FormAuto";
            this.contextMenuStripTape.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.panelTape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamTape)).EndInit();
            this.contextMenuStripConfig.ResumeLayout(false);
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.panelJig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamJig)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripJig.ResumeLayout(false);
            this.panelBot.ResumeLayout(false);
            this.panelBot.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderLog;
        public MaterialSkin.Controls.MaterialListView lvLogCamTape;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public MaterialSkin.Controls.MaterialListView lvLogCamJig;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTape;
        private System.Windows.Forms.ToolStripMenuItem clearLogTapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageTapeToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel sttRAM;
        public System.Windows.Forms.ToolStripStatusLabel sttCamTape;
        public System.Windows.Forms.ToolStripStatusLabel sttCamJig;
        public System.Windows.Forms.ToolStripStatusLabel sttPLC;
        public System.Windows.Forms.ToolStripStatusLabel sttController;
        private MaterialSkin.Controls.MaterialButton btnInitial;
        private System.Windows.Forms.PictureBox pictureBoxCamTape;
        private System.Windows.Forms.PictureBox pictureBoxCamJig;
        public System.Windows.Forms.Panel panelTape;
        public System.Windows.Forms.Panel panelJig;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripJig;
        private System.Windows.Forms.ToolStripMenuItem clearLogJigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageJigToolStripMenuItem;
        public MaterialSkin.Controls.MaterialButton btnTrigger;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public MaterialSkin.Controls.MaterialListView lvLogJig;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripConfig;
        private System.Windows.Forms.ToolStripMenuItem showConfigToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public MaterialSkin.Controls.MaterialButton btnRestart;
        public MaterialSkin.Controls.MaterialButton btnStop;
        public MaterialSkin.Controls.MaterialButton btnStart;
    }
}