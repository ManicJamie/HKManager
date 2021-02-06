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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("SeanprCore");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("3.10(xx)");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("3.10MW(xx)");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Randomizer lol", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HKManager));
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("SeanprCore");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("3.10(xx)");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("3.10MW(xx)");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Randomizer lol", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.ProfileContainer = new System.Windows.Forms.GroupBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ProfileBox = new System.Windows.Forms.ListBox();
            this.TabContainer = new System.Windows.Forms.TabControl();
            this.ModManageTab = new System.Windows.Forms.TabPage();
            this.PresetContainer = new System.Windows.Forms.GroupBox();
            this.PresetBox = new System.Windows.Forms.ListBox();
            this.LoadPresetButton = new System.Windows.Forms.Button();
            this.SavePresetButton = new System.Windows.Forms.Button();
            this.ModTreeView = new System.Windows.Forms.TreeView();
            this.ModDownloadTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.DriveButton = new System.Windows.Forms.Button();
            this.ModDescriptionBox = new System.Windows.Forms.TextBox();
            this.ModLabel = new System.Windows.Forms.Label();
            this.DownloadToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.DownloadLabel = new System.Windows.Forms.ToolStripLabel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.LevelTab = new System.Windows.Forms.TabPage();
            this.SkinTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.ProfileContainer.SuspendLayout();
            this.TabContainer.SuspendLayout();
            this.ModManageTab.SuspendLayout();
            this.PresetContainer.SuspendLayout();
            this.ModDownloadTab.SuspendLayout();
            this.DownloadToolStrip.SuspendLayout();
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
            this.MainContainer.Size = new System.Drawing.Size(625, 407);
            this.MainContainer.SplitterDistance = 207;
            this.MainContainer.TabIndex = 0;
            // 
            // ProfileContainer
            // 
            this.ProfileContainer.Controls.Add(this.VersionLabel);
            this.ProfileContainer.Controls.Add(this.button1);
            this.ProfileContainer.Controls.Add(this.PathLabel);
            this.ProfileContainer.Controls.Add(this.button2);
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
            this.VersionLabel.Size = new System.Drawing.Size(139, 18);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "Version: 1.4.3.2 - 57";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(106, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 55);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.Text = "Launch Modded";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PathLabel
            // 
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(6, 41);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(186, 50);
            this.PathLabel.TabIndex = 5;
            this.PathLabel.Text = "HK Path: C:/Some/Folder/Somewhere/Probably/HollowKnight";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(6, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 55);
            this.button2.TabIndex = 9;
            this.button2.TabStop = false;
            this.button2.Text = "Launch Unmodded";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ProfileBox
            // 
            this.ProfileBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBox.FormattingEnabled = true;
            this.ProfileBox.ItemHeight = 18;
            this.ProfileBox.Items.AddRange(new object[] {
            "1.2.2.1",
            "1.4.3.2",
            "MyOtherInstallOf1432"});
            this.ProfileBox.Location = new System.Drawing.Point(6, 94);
            this.ProfileBox.Name = "ProfileBox";
            this.ProfileBox.Size = new System.Drawing.Size(189, 220);
            this.ProfileBox.TabIndex = 9;
            // 
            // TabContainer
            // 
            this.TabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabContainer.Controls.Add(this.ModManageTab);
            this.TabContainer.Controls.Add(this.ModDownloadTab);
            this.TabContainer.Controls.Add(this.LevelTab);
            this.TabContainer.Controls.Add(this.SkinTab);
            this.TabContainer.Controls.Add(this.SettingsTab);
            this.TabContainer.Location = new System.Drawing.Point(3, 3);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.SelectedIndex = 0;
            this.TabContainer.Size = new System.Drawing.Size(407, 401);
            this.TabContainer.TabIndex = 9;
            // 
            // ModManageTab
            // 
            this.ModManageTab.Controls.Add(this.PresetContainer);
            this.ModManageTab.Controls.Add(this.ModTreeView);
            this.ModManageTab.Location = new System.Drawing.Point(4, 22);
            this.ModManageTab.Name = "ModManageTab";
            this.ModManageTab.Padding = new System.Windows.Forms.Padding(3);
            this.ModManageTab.Size = new System.Drawing.Size(399, 375);
            this.ModManageTab.TabIndex = 0;
            this.ModManageTab.Text = "Manage Mods";
            this.ModManageTab.UseVisualStyleBackColor = true;
            // 
            // PresetContainer
            // 
            this.PresetContainer.Controls.Add(this.PresetBox);
            this.PresetContainer.Controls.Add(this.LoadPresetButton);
            this.PresetContainer.Controls.Add(this.SavePresetButton);
            this.PresetContainer.Location = new System.Drawing.Point(266, 6);
            this.PresetContainer.Name = "PresetContainer";
            this.PresetContainer.Size = new System.Drawing.Size(127, 363);
            this.PresetContainer.TabIndex = 9;
            this.PresetContainer.TabStop = false;
            this.PresetContainer.Text = "Mod Presets";
            // 
            // PresetBox
            // 
            this.PresetBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresetBox.FormattingEnabled = true;
            this.PresetBox.ItemHeight = 15;
            this.PresetBox.Items.AddRange(new object[] {
            "Randomizer",
            "Practice",
            "Custom Levels"});
            this.PresetBox.Location = new System.Drawing.Point(6, 19);
            this.PresetBox.Name = "PresetBox";
            this.PresetBox.Size = new System.Drawing.Size(115, 274);
            this.PresetBox.TabIndex = 8;
            // 
            // LoadPresetButton
            // 
            this.LoadPresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadPresetButton.Location = new System.Drawing.Point(6, 304);
            this.LoadPresetButton.Name = "LoadPresetButton";
            this.LoadPresetButton.Size = new System.Drawing.Size(56, 53);
            this.LoadPresetButton.TabIndex = 6;
            this.LoadPresetButton.TabStop = false;
            this.LoadPresetButton.Text = "Load Preset";
            this.LoadPresetButton.UseVisualStyleBackColor = true;
            // 
            // SavePresetButton
            // 
            this.SavePresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePresetButton.Location = new System.Drawing.Point(65, 304);
            this.SavePresetButton.Name = "SavePresetButton";
            this.SavePresetButton.Size = new System.Drawing.Size(56, 53);
            this.SavePresetButton.TabIndex = 7;
            this.SavePresetButton.TabStop = false;
            this.SavePresetButton.Text = "Save Preset";
            this.SavePresetButton.UseVisualStyleBackColor = true;
            // 
            // ModTreeView
            // 
            this.ModTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModTreeView.CheckBoxes = true;
            this.ModTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ModTreeView.Location = new System.Drawing.Point(3, 3);
            this.ModTreeView.Name = "ModTreeView";
            treeNode9.Checked = true;
            treeNode9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            treeNode9.Name = "Node0";
            treeNode9.Text = "SeanprCore";
            treeNode9.ToolTipText = "Description";
            treeNode10.Checked = true;
            treeNode10.Name = "Node1";
            treeNode10.Text = "3.10(xx)";
            treeNode11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            treeNode11.Name = "Node2";
            treeNode11.Text = "3.10MW(xx)";
            treeNode12.Checked = true;
            treeNode12.Name = "Mod1";
            treeNode12.Text = "Randomizer lol";
            this.ModTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12});
            this.ModTreeView.ShowNodeToolTips = true;
            this.ModTreeView.Size = new System.Drawing.Size(254, 366);
            this.ModTreeView.TabIndex = 0;
            // 
            // ModDownloadTab
            // 
            this.ModDownloadTab.Controls.Add(this.button3);
            this.ModDownloadTab.Controls.Add(this.DriveButton);
            this.ModDownloadTab.Controls.Add(this.ModDescriptionBox);
            this.ModDownloadTab.Controls.Add(this.ModLabel);
            this.ModDownloadTab.Controls.Add(this.DownloadToolStrip);
            this.ModDownloadTab.Controls.Add(this.treeView1);
            this.ModDownloadTab.Location = new System.Drawing.Point(4, 22);
            this.ModDownloadTab.Name = "ModDownloadTab";
            this.ModDownloadTab.Padding = new System.Windows.Forms.Padding(3);
            this.ModDownloadTab.Size = new System.Drawing.Size(399, 375);
            this.ModDownloadTab.TabIndex = 1;
            this.ModDownloadTab.Text = "Download Mods";
            this.ModDownloadTab.UseVisualStyleBackColor = true;
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
            this.DownloadToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DownloadToolStrip.AutoSize = false;
            this.DownloadToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.DownloadToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.DownloadToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.DownloadLabel});
            this.DownloadToolStrip.Location = new System.Drawing.Point(3, 350);
            this.DownloadToolStrip.Name = "DownloadToolStrip";
            this.DownloadToolStrip.Size = new System.Drawing.Size(393, 25);
            this.DownloadToolStrip.TabIndex = 3;
            this.DownloadToolStrip.Text = "toolStrip1";
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
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            treeNode13.Name = "Node0";
            treeNode13.Text = "SeanprCore";
            treeNode13.ToolTipText = "Description";
            treeNode14.Name = "Node1";
            treeNode14.Text = "3.10(xx)";
            treeNode15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            treeNode15.Name = "Node2";
            treeNode15.Text = "3.10MW(xx)";
            treeNode16.Name = "Mod1";
            treeNode16.Text = "Randomizer lol";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode16});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(212, 344);
            this.treeView1.TabIndex = 1;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(399, 375);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // LevelTab
            // 
            this.LevelTab.Location = new System.Drawing.Point(4, 22);
            this.LevelTab.Name = "LevelTab";
            this.LevelTab.Padding = new System.Windows.Forms.Padding(3);
            this.LevelTab.Size = new System.Drawing.Size(399, 375);
            this.LevelTab.TabIndex = 3;
            this.LevelTab.Text = "Custom Levels";
            this.LevelTab.UseVisualStyleBackColor = true;
            // 
            // SkinTab
            // 
            this.SkinTab.Location = new System.Drawing.Point(4, 22);
            this.SkinTab.Name = "SkinTab";
            this.SkinTab.Padding = new System.Windows.Forms.Padding(3);
            this.SkinTab.Size = new System.Drawing.Size(399, 375);
            this.SkinTab.TabIndex = 4;
            this.SkinTab.Text = "Custom Skins";
            this.SkinTab.UseVisualStyleBackColor = true;
            // 
            // HKManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
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
            this.TabContainer.ResumeLayout(false);
            this.ModManageTab.ResumeLayout(false);
            this.PresetContainer.ResumeLayout(false);
            this.ModDownloadTab.ResumeLayout(false);
            this.ModDownloadTab.PerformLayout();
            this.DownloadToolStrip.ResumeLayout(false);
            this.DownloadToolStrip.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ProfileBox;
        private System.Windows.Forms.GroupBox PresetContainer;
        private System.Windows.Forms.TreeView treeView1;
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
    }
}

