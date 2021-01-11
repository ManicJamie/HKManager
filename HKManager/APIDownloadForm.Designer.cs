
namespace HKManager
{
    partial class APIDownloadForm
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
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.DownloadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(12, 48);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(304, 32);
            this.downloadProgressBar.TabIndex = 0;
            // 
            // DownloadLabel
            // 
            this.DownloadLabel.Location = new System.Drawing.Point(12, 22);
            this.DownloadLabel.Name = "DownloadLabel";
            this.DownloadLabel.Size = new System.Drawing.Size(304, 23);
            this.DownloadLabel.TabIndex = 1;
            this.DownloadLabel.Text = "Downloading ModdingAPI ";
            this.DownloadLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // APIDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 96);
            this.ControlBox = false;
            this.Controls.Add(this.DownloadLabel);
            this.Controls.Add(this.downloadProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "APIDownloadForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "APIDownloadForm";
            this.Load += new System.EventHandler(this.APIDownloadForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar downloadProgressBar;
        private System.Windows.Forms.Label DownloadLabel;
    }
}