
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("idk probably multiworld");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Randomizer", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModDownloadForm));
            this.modTreeView = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.downloadLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.downloadProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ControlContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ModFolderButton = new System.Windows.Forms.Button();
            this.DriveButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.ControlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // modTreeView
            // 
            this.modTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modTreeView.Location = new System.Drawing.Point(12, 12);
            this.modTreeView.Name = "modTreeView";
            treeNode1.Name = "Node1";
            treeNode1.Text = "idk probably multiworld";
            treeNode2.Name = "Randomizer";
            treeNode2.Text = "Randomizer";
            this.modTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.modTreeView.Size = new System.Drawing.Size(339, 378);
            this.modTreeView.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadLabel,
            this.downloadProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(486, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = false;
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(120, 20);
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
            // ControlContainer
            // 
            this.ControlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlContainer.ColumnCount = 1;
            this.ControlContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlContainer.Controls.Add(this.ModFolderButton, 0, 1);
            this.ControlContainer.Controls.Add(this.DriveButton, 0, 3);
            this.ControlContainer.Controls.Add(this.DownloadButton, 0, 0);
            this.ControlContainer.Location = new System.Drawing.Point(357, 12);
            this.ControlContainer.Name = "ControlContainer";
            this.ControlContainer.RowCount = 3;
            this.ControlContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.ControlContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.ControlContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.ControlContainer.Size = new System.Drawing.Size(117, 378);
            this.ControlContainer.TabIndex = 2;
            // 
            // ModFolderButton
            // 
            this.ModFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModFolderButton.Location = new System.Drawing.Point(3, 72);
            this.ModFolderButton.Name = "ModFolderButton";
            this.ModFolderButton.Size = new System.Drawing.Size(111, 63);
            this.ModFolderButton.TabIndex = 3;
            this.ModFolderButton.Text = "Open Mods Folder";
            this.ModFolderButton.UseVisualStyleBackColor = true;
            // 
            // DriveButton
            // 
            this.DriveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DriveButton.Location = new System.Drawing.Point(3, 308);
            this.DriveButton.Name = "DriveButton";
            this.DriveButton.Size = new System.Drawing.Size(111, 67);
            this.DriveButton.TabIndex = 1;
            this.DriveButton.Text = "Open Google Drive";
            this.DriveButton.UseVisualStyleBackColor = true;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadButton.Location = new System.Drawing.Point(3, 3);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(111, 63);
            this.DownloadButton.TabIndex = 0;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            // 
            // ModDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 424);
            this.Controls.Add(this.ControlContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.modTreeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModDownloadForm";
            this.Text = "ModDownloadForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ControlContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView modTreeView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel downloadLabel;
        private System.Windows.Forms.ToolStripProgressBar downloadProgressBar;
        private System.Windows.Forms.TableLayoutPanel ControlContainer;
        private System.Windows.Forms.Button ModFolderButton;
        private System.Windows.Forms.Button DriveButton;
        private System.Windows.Forms.Button DownloadButton;
    }
}