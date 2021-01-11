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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HKManager));
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.PatchButton = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathButton = new System.Windows.Forms.Button();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.ModdedButton = new System.Windows.Forms.RadioButton();
            this.VanillaButton = new System.Windows.Forms.RadioButton();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.PresetBox = new System.Windows.Forms.ListBox();
            this.SavePresetButton = new System.Windows.Forms.Button();
            this.LoadPresetButton = new System.Windows.Forms.Button();
            this.ModManagerContainer = new System.Windows.Forms.GroupBox();
            this.ModTreeView = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.ModManagerContainer.SuspendLayout();
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
            this.MainContainer.Panel1.Controls.Add(this.PatchButton);
            this.MainContainer.Panel1.Controls.Add(this.PathLabel);
            this.MainContainer.Panel1.Controls.Add(this.PathButton);
            this.MainContainer.Panel1.Controls.Add(this.LaunchButton);
            this.MainContainer.Panel1.Controls.Add(this.UpdateButton);
            this.MainContainer.Panel1.Controls.Add(this.DownloadButton);
            this.MainContainer.Panel1.Controls.Add(this.ModdedButton);
            this.MainContainer.Panel1.Controls.Add(this.VanillaButton);
            this.MainContainer.Panel1.Controls.Add(this.VersionLabel);
            this.MainContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.PresetBox);
            this.MainContainer.Panel2.Controls.Add(this.SavePresetButton);
            this.MainContainer.Panel2.Controls.Add(this.LoadPresetButton);
            this.MainContainer.Panel2.Controls.Add(this.ModManagerContainer);
            this.MainContainer.Size = new System.Drawing.Size(806, 452);
            this.MainContainer.SplitterDistance = 258;
            this.MainContainer.TabIndex = 0;
            // 
            // PatchButton
            // 
            this.PatchButton.Location = new System.Drawing.Point(131, 295);
            this.PatchButton.Name = "PatchButton";
            this.PatchButton.Size = new System.Drawing.Size(114, 53);
            this.PatchButton.TabIndex = 12;
            this.PatchButton.Text = "Change HK Patch";
            this.PatchButton.UseVisualStyleBackColor = true;
            this.PatchButton.Click += new System.EventHandler(this.PatchButton_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.Location = new System.Drawing.Point(9, 222);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(236, 56);
            this.PathLabel.TabIndex = 11;
            this.PathLabel.Text = "Path: i am a dwarf and im digging a hole diggy diggy hole diggy diggy hole";
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(12, 295);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(114, 53);
            this.PathButton.TabIndex = 4;
            this.PathButton.Text = "Change HK Path";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // LaunchButton
            // 
            this.LaunchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchButton.Location = new System.Drawing.Point(124, 384);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(122, 59);
            this.LaunchButton.TabIndex = 5;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Location = new System.Drawing.Point(12, 163);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(233, 47);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Check For Updates";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadButton.Location = new System.Drawing.Point(12, 110);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(233, 47);
            this.DownloadButton.TabIndex = 2;
            this.DownloadButton.Text = "Download Mods";
            this.DownloadButton.UseVisualStyleBackColor = true;
            // 
            // ModdedButton
            // 
            this.ModdedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModdedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModdedButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModdedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModdedButton.Location = new System.Drawing.Point(140, 32);
            this.ModdedButton.Name = "ModdedButton";
            this.ModdedButton.Size = new System.Drawing.Size(105, 53);
            this.ModdedButton.TabIndex = 1;
            this.ModdedButton.Text = "Modded";
            this.ModdedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModdedButton.UseVisualStyleBackColor = true;
            this.ModdedButton.CheckedChanged += new System.EventHandler(this.modButtons_CheckedChanged);
            // 
            // VanillaButton
            // 
            this.VanillaButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.VanillaButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VanillaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VanillaButton.Location = new System.Drawing.Point(12, 32);
            this.VanillaButton.Name = "VanillaButton";
            this.VanillaButton.Size = new System.Drawing.Size(105, 53);
            this.VanillaButton.TabIndex = 0;
            this.VanillaButton.Text = "Vanilla";
            this.VanillaButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VanillaButton.UseVisualStyleBackColor = true;
            this.VanillaButton.CheckedChanged += new System.EventHandler(this.modButtons_CheckedChanged);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(12, 9);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(142, 20);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "Version: x.x.x.x-xx";
            // 
            // PresetBox
            // 
            this.PresetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresetBox.FormattingEnabled = true;
            this.PresetBox.ItemHeight = 18;
            this.PresetBox.Location = new System.Drawing.Point(403, 163);
            this.PresetBox.Name = "PresetBox";
            this.PresetBox.Size = new System.Drawing.Size(129, 166);
            this.PresetBox.TabIndex = 8;
            // 
            // SavePresetButton
            // 
            this.SavePresetButton.Location = new System.Drawing.Point(403, 91);
            this.SavePresetButton.Name = "SavePresetButton";
            this.SavePresetButton.Size = new System.Drawing.Size(129, 66);
            this.SavePresetButton.TabIndex = 7;
            this.SavePresetButton.TabStop = false;
            this.SavePresetButton.Text = "Save Preset";
            this.SavePresetButton.UseVisualStyleBackColor = true;
            // 
            // LoadPresetButton
            // 
            this.LoadPresetButton.Location = new System.Drawing.Point(403, 21);
            this.LoadPresetButton.Name = "LoadPresetButton";
            this.LoadPresetButton.Size = new System.Drawing.Size(129, 64);
            this.LoadPresetButton.TabIndex = 6;
            this.LoadPresetButton.TabStop = false;
            this.LoadPresetButton.Text = "Load Preset";
            this.LoadPresetButton.UseVisualStyleBackColor = true;
            // 
            // ModManagerContainer
            // 
            this.ModManagerContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModManagerContainer.Controls.Add(this.ModTreeView);
            this.ModManagerContainer.Location = new System.Drawing.Point(13, 12);
            this.ModManagerContainer.Name = "ModManagerContainer";
            this.ModManagerContainer.Size = new System.Drawing.Size(384, 429);
            this.ModManagerContainer.TabIndex = 1;
            this.ModManagerContainer.TabStop = false;
            this.ModManagerContainer.Text = "Manage Mods";
            // 
            // ModTreeView
            // 
            this.ModTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModTreeView.Location = new System.Drawing.Point(6, 21);
            this.ModTreeView.Name = "ModTreeView";
            this.ModTreeView.Size = new System.Drawing.Size(372, 402);
            this.ModTreeView.TabIndex = 0;
            // 
            // HKManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(806, 453);
            this.Controls.Add(this.MainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(824, 500);
            this.MinimumSize = new System.Drawing.Size(276, 500);
            this.Name = "HKManager";
            this.Text = "HKManager";
            this.Load += new System.EventHandler(this.HKManager_Load);
            this.Shown += new System.EventHandler(this.HKManager_Shown);
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel1.PerformLayout();
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.ModManagerContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.RadioButton ModdedButton;
        private System.Windows.Forms.RadioButton VanillaButton;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button SavePresetButton;
        private System.Windows.Forms.Button LoadPresetButton;
        private System.Windows.Forms.GroupBox ModManagerContainer;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button PatchButton;
        private System.Windows.Forms.TreeView ModTreeView;
        private System.Windows.Forms.ListBox PresetBox;
    }
}

