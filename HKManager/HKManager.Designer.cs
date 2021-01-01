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
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VanillaButton = new System.Windows.Forms.RadioButton();
            this.ModdedButton = new System.Windows.Forms.RadioButton();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.LaunchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainContainer.IsSplitterFixed = true;
            this.MainContainer.Location = new System.Drawing.Point(0, 0);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.LaunchButton);
            this.MainContainer.Panel1.Controls.Add(this.UpdateButton);
            this.MainContainer.Panel1.Controls.Add(this.DownloadButton);
            this.MainContainer.Panel1.Controls.Add(this.ModdedButton);
            this.MainContainer.Panel1.Controls.Add(this.VanillaButton);
            this.MainContainer.Panel1.Controls.Add(this.VersionLabel);
            this.MainContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.MainContainer.Size = new System.Drawing.Size(556, 450);
            this.MainContainer.SplitterDistance = 258;
            this.MainContainer.TabIndex = 0;
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
            // VanillaButton
            // 
            this.VanillaButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.VanillaButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VanillaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VanillaButton.Location = new System.Drawing.Point(12, 32);
            this.VanillaButton.Name = "VanillaButton";
            this.VanillaButton.Size = new System.Drawing.Size(105, 53);
            this.VanillaButton.TabIndex = 5;
            this.VanillaButton.Text = "Vanilla";
            this.VanillaButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VanillaButton.UseVisualStyleBackColor = true;
            // 
            // ModdedButton
            // 
            this.ModdedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModdedButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModdedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModdedButton.Location = new System.Drawing.Point(140, 32);
            this.ModdedButton.Name = "ModdedButton";
            this.ModdedButton.Size = new System.Drawing.Size(105, 53);
            this.ModdedButton.TabIndex = 6;
            this.ModdedButton.Text = "Modded";
            this.ModdedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModdedButton.UseVisualStyleBackColor = true;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(12, 110);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(233, 47);
            this.DownloadButton.TabIndex = 7;
            this.DownloadButton.Text = "Download Mods";
            this.DownloadButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 163);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(233, 47);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Check For Updates";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(140, 386);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(105, 52);
            this.LaunchButton.TabIndex = 9;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = true;
            // 
            // HKManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.MainContainer);
            this.Name = "HKManager";
            this.Text = "HKManager";
            this.Load += new System.EventHandler(this.HKManager_Load);
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
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
    }
}

