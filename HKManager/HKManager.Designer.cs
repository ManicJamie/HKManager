namespace HKManager
{
    partial class HKManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HKManager));
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.ProfileContainer = new System.Windows.Forms.GroupBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.ProfileBox = new System.Windows.Forms.ListBox();
            this.PBoxContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ProfileBoxRClickAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.TabContainer = new System.Windows.Forms.TabControl();
            this.ModManageTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveFolderButton = new System.Windows.Forms.Button();
            this.GameFolderButton = new System.Windows.Forms.Button();
            this.PresetContainer = new System.Windows.Forms.GroupBox();
            this.PresetBox = new System.Windows.Forms.ListBox();
            this.LoadPresetButton = new System.Windows.Forms.Button();
            this.SavePresetButton = new System.Windows.Forms.Button();
            this.ModTreeView = new System.Windows.Forms.TreeView();
            this.ModDownloadTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DownloadTreeView = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.DriveButton = new System.Windows.Forms.Button();
            this.ModDescriptionBox = new System.Windows.Forms.TextBox();
            this.ModLabel = new System.Windows.Forms.Label();
            this.DownloadToolStrip = new System.Windows.Forms.ToolStrip();
            this.DownloadProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LevelTab = new System.Windows.Forms.TabPage();
            this.TrialTab = new System.Windows.Forms.TabPage();
            this.SkinTab = new System.Windows.Forms.TabPage();
            this.SavesTab = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.JamieLabel = new System.Windows.Forms.LinkLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.DownloadLabel = new System.Windows.Forms.ToolStripLabel();
            this.ModWatcher = new System.IO.FileSystemWatcher();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.ProfileContainer.SuspendLayout();
            this.PBoxContext.SuspendLayout();
            this.TabContainer.SuspendLayout();
            this.ModManageTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PresetContainer.SuspendLayout();
            this.ModDownloadTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DownloadToolStrip.SuspendLayout();
            this.LevelTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModWatcher)).BeginInit();
            this.SettingsBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainContainer.IsSplitterFixed = true;
            this.MainContainer.Location = new System.Drawing.Point(0, 0);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.ProfileContainer);
            this.MainContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.TabContainer);
            this.MainContainer.Panel2.Controls.Add(this.DownloadToolStrip);
            this.MainContainer.Size = new System.Drawing.Size(625, 407);
            this.MainContainer.SplitterDistance = 207;
            this.MainContainer.TabIndex = 0;
            // 
            // ProfileContainer
            // 
            this.ProfileContainer.Controls.Add(this.VersionLabel);
            this.ProfileContainer.Controls.Add(this.button1);
            this.ProfileContainer.Controls.Add(this.PathLabel);
            this.ProfileContainer.Controls.Add(this.ProfileBox);
            this.ProfileContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileContainer.Location = new System.Drawing.Point(3, 3);
            this.ProfileContainer.Name = "ProfileContainer";
            this.ProfileContainer.Size = new System.Drawing.Size(200, 401);
            this.ProfileContainer.TabIndex = 11;
            this.ProfileContainer.TabStop = false;
            this.ProfileContainer.Text = "Profile";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(6, 16);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(66, 18);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "Version: ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 71);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.Text = "Launch Game";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PathLabel
            // 
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(6, 41);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(186, 50);
            this.PathLabel.TabIndex = 5;
            this.PathLabel.Text = "HK Path: ";
            // 
            // ProfileBox
            // 
            this.ProfileBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileBox.ContextMenuStrip = this.PBoxContext;
            this.ProfileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBox.FormattingEnabled = true;
            this.ProfileBox.ItemHeight = 18;
            this.ProfileBox.Location = new System.Drawing.Point(6, 94);
            this.ProfileBox.Name = "ProfileBox";
            this.ProfileBox.Size = new System.Drawing.Size(189, 220);
            this.ProfileBox.TabIndex = 9;
            this.ProfileBox.SelectedIndexChanged += new System.EventHandler(this.ProfileBox_SelectedIndexChanged);
            // 
            // PBoxContext
            // 
            this.PBoxContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfileBoxRClickAdd});
            this.PBoxContext.Name = "ProfileBoxRClick";
            this.PBoxContext.Size = new System.Drawing.Size(97, 26);
            this.PBoxContext.Opening += new System.ComponentModel.CancelEventHandler(this.PBoxContext_Opening);
            // 
            // ProfileBoxRClickAdd
            // 
            this.ProfileBoxRClickAdd.Name = "ProfileBoxRClickAdd";
            this.ProfileBoxRClickAdd.Size = new System.Drawing.Size(96, 22);
            this.ProfileBoxRClickAdd.Text = "Add";
            // 
            // TabContainer
            // 
            this.TabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabContainer.Controls.Add(this.ModManageTab);
            this.TabContainer.Controls.Add(this.ModDownloadTab);
            this.TabContainer.Controls.Add(this.LevelTab);
            this.TabContainer.Controls.Add(this.TrialTab);
            this.TabContainer.Controls.Add(this.SkinTab);
            this.TabContainer.Controls.Add(this.SavesTab);
            this.TabContainer.Controls.Add(this.SettingsTab);
            this.TabContainer.Location = new System.Drawing.Point(3, 3);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.SelectedIndex = 0;
            this.TabContainer.Size = new System.Drawing.Size(407, 375);
            this.TabContainer.TabIndex = 9;
            // 
            // ModManageTab
            // 
            this.ModManageTab.Controls.Add(this.groupBox6);
            this.ModManageTab.Controls.Add(this.groupBox1);
            this.ModManageTab.Controls.Add(this.PresetContainer);
            this.ModManageTab.Location = new System.Drawing.Point(4, 22);
            this.ModManageTab.Name = "ModManageTab";
            this.ModManageTab.Padding = new System.Windows.Forms.Padding(3);
            this.ModManageTab.Size = new System.Drawing.Size(399, 349);
            this.ModManageTab.TabIndex = 0;
            this.ModManageTab.Text = "Manage Mods";
            this.ModManageTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveFolderButton);
            this.groupBox1.Controls.Add(this.GameFolderButton);
            this.groupBox1.Location = new System.Drawing.Point(266, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 111);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open Folders";
            // 
            // SaveFolderButton
            // 
            this.SaveFolderButton.Location = new System.Drawing.Point(7, 62);
            this.SaveFolderButton.Name = "SaveFolderButton";
            this.SaveFolderButton.Size = new System.Drawing.Size(114, 43);
            this.SaveFolderButton.TabIndex = 1;
            this.SaveFolderButton.Text = "Open Saves Folder";
            this.SaveFolderButton.UseVisualStyleBackColor = true;
            this.SaveFolderButton.Click += new System.EventHandler(this.SaveFolderButton_Click);
            // 
            // GameFolderButton
            // 
            this.GameFolderButton.Location = new System.Drawing.Point(7, 16);
            this.GameFolderButton.Name = "GameFolderButton";
            this.GameFolderButton.Size = new System.Drawing.Size(114, 43);
            this.GameFolderButton.TabIndex = 0;
            this.GameFolderButton.Text = "Open Game Folder";
            this.GameFolderButton.UseVisualStyleBackColor = true;
            this.GameFolderButton.Click += new System.EventHandler(this.GameFolderButton_Click);
            // 
            // PresetContainer
            // 
            this.PresetContainer.Controls.Add(this.PresetBox);
            this.PresetContainer.Controls.Add(this.LoadPresetButton);
            this.PresetContainer.Controls.Add(this.SavePresetButton);
            this.PresetContainer.Location = new System.Drawing.Point(266, 120);
            this.PresetContainer.Name = "PresetContainer";
            this.PresetContainer.Size = new System.Drawing.Size(127, 223);
            this.PresetContainer.TabIndex = 9;
            this.PresetContainer.TabStop = false;
            this.PresetContainer.Text = "Mod Presets";
            // 
            // PresetBox
            // 
            this.PresetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PresetBox.FormattingEnabled = true;
            this.PresetBox.ItemHeight = 16;
            this.PresetBox.Location = new System.Drawing.Point(6, 19);
            this.PresetBox.Name = "PresetBox";
            this.PresetBox.Size = new System.Drawing.Size(115, 132);
            this.PresetBox.TabIndex = 8;
            // 
            // LoadPresetButton
            // 
            this.LoadPresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadPresetButton.Location = new System.Drawing.Point(6, 164);
            this.LoadPresetButton.Name = "LoadPresetButton";
            this.LoadPresetButton.Size = new System.Drawing.Size(56, 53);
            this.LoadPresetButton.TabIndex = 6;
            this.LoadPresetButton.TabStop = false;
            this.LoadPresetButton.Text = "Load Preset";
            this.LoadPresetButton.UseVisualStyleBackColor = true;
            // 
            // SavePresetButton
            // 
            this.SavePresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SavePresetButton.Location = new System.Drawing.Point(65, 164);
            this.SavePresetButton.Name = "SavePresetButton";
            this.SavePresetButton.Size = new System.Drawing.Size(56, 53);
            this.SavePresetButton.TabIndex = 7;
            this.SavePresetButton.TabStop = false;
            this.SavePresetButton.Text = "Save Preset";
            this.SavePresetButton.UseVisualStyleBackColor = true;
            // 
            // ModTreeView
            // 
            this.ModTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModTreeView.CheckBoxes = true;
            this.ModTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ModTreeView.Location = new System.Drawing.Point(6, 19);
            this.ModTreeView.Name = "ModTreeView";
            this.ModTreeView.ShowNodeToolTips = true;
            this.ModTreeView.Size = new System.Drawing.Size(242, 312);
            this.ModTreeView.TabIndex = 0;
            this.ModTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.ModTreeView_AfterCheck);
            // 
            // ModDownloadTab
            // 
            this.ModDownloadTab.Controls.Add(this.groupBox2);
            this.ModDownloadTab.Controls.Add(this.button3);
            this.ModDownloadTab.Controls.Add(this.DriveButton);
            this.ModDownloadTab.Controls.Add(this.ModDescriptionBox);
            this.ModDownloadTab.Controls.Add(this.ModLabel);
            this.ModDownloadTab.Location = new System.Drawing.Point(4, 22);
            this.ModDownloadTab.Name = "ModDownloadTab";
            this.ModDownloadTab.Padding = new System.Windows.Forms.Padding(3);
            this.ModDownloadTab.Size = new System.Drawing.Size(399, 349);
            this.ModDownloadTab.TabIndex = 1;
            this.ModDownloadTab.Text = "Download Mods";
            this.ModDownloadTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SearchBox);
            this.groupBox2.Controls.Add(this.DownloadTreeView);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 347);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SearchBox.Location = new System.Drawing.Point(6, 19);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(203, 21);
            this.SearchBox.TabIndex = 12;
            // 
            // DownloadTreeView
            // 
            this.DownloadTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DownloadTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DownloadTreeView.Location = new System.Drawing.Point(6, 63);
            this.DownloadTreeView.Name = "DownloadTreeView";
            this.DownloadTreeView.ShowNodeToolTips = true;
            this.DownloadTreeView.Size = new System.Drawing.Size(203, 278);
            this.DownloadTreeView.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 49);
            this.button3.TabIndex = 7;
            this.button3.Text = "Download";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DriveButton
            // 
            this.DriveButton.Location = new System.Drawing.Point(224, 298);
            this.DriveButton.Name = "DriveButton";
            this.DriveButton.Size = new System.Drawing.Size(88, 49);
            this.DriveButton.TabIndex = 6;
            this.DriveButton.Text = "Open Mod Google Drive";
            this.DriveButton.UseVisualStyleBackColor = true;
            this.DriveButton.Click += new System.EventHandler(this.DriveButton_Click);
            // 
            // ModDescriptionBox
            // 
            this.ModDescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModDescriptionBox.Location = new System.Drawing.Point(224, 30);
            this.ModDescriptionBox.Multiline = true;
            this.ModDescriptionBox.Name = "ModDescriptionBox";
            this.ModDescriptionBox.Size = new System.Drawing.Size(169, 262);
            this.ModDescriptionBox.TabIndex = 5;
            this.ModDescriptionBox.Text = resources.GetString("ModDescriptionBox.Text");
            // 
            // ModLabel
            // 
            this.ModLabel.AutoSize = true;
            this.ModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ModLabel.Location = new System.Drawing.Point(221, 7);
            this.ModLabel.Name = "ModLabel";
            this.ModLabel.Size = new System.Drawing.Size(139, 15);
            this.ModLabel.TabIndex = 4;
            this.ModLabel.Text = "Randomizer 3 - 3.10(xx)";
            // 
            // DownloadToolStrip
            // 
            this.DownloadToolStrip.AutoSize = false;
            this.DownloadToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DownloadToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownloadToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.DownloadToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadProgressBar,
            this.toolStripLabel1});
            this.DownloadToolStrip.Location = new System.Drawing.Point(0, 382);
            this.DownloadToolStrip.Name = "DownloadToolStrip";
            this.DownloadToolStrip.Size = new System.Drawing.Size(414, 25);
            this.DownloadToolStrip.TabIndex = 3;
            this.DownloadToolStrip.Text = "toolStrip1";
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.AutoSize = false;
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(150, 22);
            this.DownloadProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(162, 22);
            this.toolStripLabel1.Text = "Downloading Randomizer 3...";
            // 
            // LevelTab
            // 
            this.LevelTab.Controls.Add(this.groupBox5);
            this.LevelTab.Controls.Add(this.groupBox3);
            this.LevelTab.Location = new System.Drawing.Point(4, 22);
            this.LevelTab.Name = "LevelTab";
            this.LevelTab.Padding = new System.Windows.Forms.Padding(3);
            this.LevelTab.Size = new System.Drawing.Size(399, 349);
            this.LevelTab.TabIndex = 3;
            this.LevelTab.Text = "Levels";
            this.LevelTab.UseVisualStyleBackColor = true;
            // 
            // TrialTab
            // 
            this.TrialTab.Location = new System.Drawing.Point(4, 22);
            this.TrialTab.Name = "TrialTab";
            this.TrialTab.Size = new System.Drawing.Size(399, 349);
            this.TrialTab.TabIndex = 6;
            this.TrialTab.Text = "Trials";
            this.TrialTab.UseVisualStyleBackColor = true;
            // 
            // SkinTab
            // 
            this.SkinTab.Location = new System.Drawing.Point(4, 22);
            this.SkinTab.Name = "SkinTab";
            this.SkinTab.Padding = new System.Windows.Forms.Padding(3);
            this.SkinTab.Size = new System.Drawing.Size(399, 349);
            this.SkinTab.TabIndex = 4;
            this.SkinTab.Text = "Skins";
            this.SkinTab.UseVisualStyleBackColor = true;
            // 
            // SavesTab
            // 
            this.SavesTab.Location = new System.Drawing.Point(4, 22);
            this.SavesTab.Name = "SavesTab";
            this.SavesTab.Padding = new System.Windows.Forms.Padding(3);
            this.SavesTab.Size = new System.Drawing.Size(399, 349);
            this.SavesTab.TabIndex = 5;
            this.SavesTab.Text = "Saves";
            this.SavesTab.UseVisualStyleBackColor = true;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.groupBox4);
            this.SettingsTab.Controls.Add(this.SettingsBox);
            this.SettingsTab.Controls.Add(this.button4);
            this.SettingsTab.Controls.Add(this.button2);
            this.SettingsTab.Controls.Add(this.JamieLabel);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(399, 349);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(283, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "Get Help Package\r\nFor HK Discord";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Join the Hollow Knight Discord!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // JamieLabel
            // 
            this.JamieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.JamieLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.JamieLabel.Location = new System.Drawing.Point(3, 355);
            this.JamieLabel.Name = "JamieLabel";
            this.JamieLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.JamieLabel.Size = new System.Drawing.Size(393, 17);
            this.JamieLabel.TabIndex = 1;
            this.JamieLabel.Text = "HKManager was made open-source by ManicJamie. Check her out!";
            this.JamieLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.JamieLabel.UseCompatibleTextRendering = true;
            this.JamieLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JamieLabel_LinkClicked);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 22);
            // 
            // DownloadLabel
            // 
            this.DownloadLabel.Name = "DownloadLabel";
            this.DownloadLabel.Size = new System.Drawing.Size(199, 22);
            this.DownloadLabel.Text = "Downloading Randomizer 3.10MW...";
            // 
            // ModWatcher
            // 
            this.ModWatcher.EnableRaisingEvents = true;
            this.ModWatcher.SynchronizingObject = this;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(176, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Launch Game from HKManager";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.checkBox3);
            this.SettingsBox.Controls.Add(this.checkBox2);
            this.SettingsBox.Controls.Add(this.checkBox1);
            this.SettingsBox.Location = new System.Drawing.Point(6, 6);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(190, 172);
            this.SettingsBox.TabIndex = 5;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "HKManager Settings";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Location = new System.Drawing.Point(202, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 172);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quick Fixes";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 43);
            this.button5.TabIndex = 0;
            this.button5.Text = "My Saves aren\'t showing!";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 43);
            this.button6.TabIndex = 1;
            this.button6.Text = "I\'m playing Randomizer 3 and I don\'t know where to go.";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 118);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 43);
            this.button7.TabIndex = 2;
            this.button7.Text = "I uninstalled Hollow Point and now healing is broken.";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(158, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Automatically install updates";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(6, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(133, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Check for API updates";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 228);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 255);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Installed Levels";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox2);
            this.groupBox5.Location = new System.Drawing.Point(203, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(190, 255);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Available Levels";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(6, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(177, 228);
            this.listBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Available Mods";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ModTreeView);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(254, 337);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Installed Mods";
            // 
            // HKManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(625, 408);
            this.Controls.Add(this.MainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HKManager";
            this.Text = "HKManager";
            this.Load += new System.EventHandler(this.HKManager_Load);
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.ProfileContainer.ResumeLayout(false);
            this.ProfileContainer.PerformLayout();
            this.PBoxContext.ResumeLayout(false);
            this.TabContainer.ResumeLayout(false);
            this.ModManageTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.PresetContainer.ResumeLayout(false);
            this.ModDownloadTab.ResumeLayout(false);
            this.ModDownloadTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DownloadToolStrip.ResumeLayout(false);
            this.DownloadToolStrip.PerformLayout();
            this.LevelTab.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModWatcher)).EndInit();
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button SavePresetButton;
        private System.Windows.Forms.Button LoadPresetButton;
        private System.Windows.Forms.TreeView ModTreeView;
        private System.Windows.Forms.ListBox PresetBox;
        private System.Windows.Forms.TabControl TabContainer;
        private System.Windows.Forms.TabPage ModManageTab;
        private System.Windows.Forms.TabPage ModDownloadTab;
        private System.Windows.Forms.GroupBox ProfileContainer;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ProfileBox;
        private System.Windows.Forms.GroupBox PresetContainer;
        private System.Windows.Forms.TreeView DownloadTreeView;
        private System.Windows.Forms.ToolStrip DownloadToolStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripLabel DownloadLabel;
        private System.Windows.Forms.TextBox ModDescriptionBox;
        private System.Windows.Forms.Label ModLabel;
        private System.Windows.Forms.Button DriveButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TabPage LevelTab;
        private System.Windows.Forms.TabPage SkinTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveFolderButton;
        private System.Windows.Forms.Button GameFolderButton;
        private System.IO.FileSystemWatcher ModWatcher;
        private System.Windows.Forms.ContextMenuStrip PBoxContext;
        private System.Windows.Forms.ToolStripMenuItem ProfileBoxRClickAdd;
        private System.Windows.Forms.TabPage SavesTab;
        private System.Windows.Forms.TabPage TrialTab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel JamieLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ToolStripProgressBar DownloadProgressBar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

