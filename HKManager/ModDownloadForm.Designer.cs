
namespace HKManager
{
    partial class ModDownloadForm
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
            this.modTreeView = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.downloadLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.downloadProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modTreeView
            // 
            this.modTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modTreeView.Location = new System.Drawing.Point(12, 12);
            this.modTreeView.Name = "modTreeView";
            this.modTreeView.Size = new System.Drawing.Size(375, 390);
            this.modTreeView.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadLabel,
            this.downloadProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(396, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = false;
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(108, 20);
            this.downloadLabel.Text = "Downloading...";
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.AutoSize = false;
            this.downloadProgressBar.AutoToolTip = true;
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(200, 18);
            this.downloadProgressBar.ToolTipText = "Download Progress";
            // 
            // ModDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 436);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.modTreeView);
            this.Name = "ModDownloadForm";
            this.Text = "ModDownloadForm";
            this.Load += new System.EventHandler(this.ModDownloadForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView modTreeView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel downloadLabel;
        private System.Windows.Forms.ToolStripProgressBar downloadProgressBar;
    }
}