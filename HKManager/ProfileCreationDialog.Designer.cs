
namespace HKManager
{
    partial class ProfileCreationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileCreationDialog));
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PathBrowseButton = new System.Windows.Forms.Button();
            this.PatchComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(16, 37);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PathTextBox.Multiline = true;
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(327, 45);
            this.PathTextBox.TabIndex = 0;
            this.PathTextBox.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // PathBrowseButton
            // 
            this.PathBrowseButton.Location = new System.Drawing.Point(353, 37);
            this.PathBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PathBrowseButton.Name = "PathBrowseButton";
            this.PathBrowseButton.Size = new System.Drawing.Size(125, 46);
            this.PathBrowseButton.TabIndex = 2;
            this.PathBrowseButton.Text = "Browse";
            this.PathBrowseButton.UseVisualStyleBackColor = true;
            // 
            // PatchComboBox
            // 
            this.PatchComboBox.Enabled = false;
            this.PatchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatchComboBox.FormattingEnabled = true;
            this.PatchComboBox.Items.AddRange(new object[] {
            "1.1.1.8",
            "1.2.2.1",
            "1.3.1.5",
            "1.4.2.4",
            "1.4.3.2"});
            this.PatchComboBox.Location = new System.Drawing.Point(16, 128);
            this.PatchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatchComboBox.Name = "PatchComboBox";
            this.PatchComboBox.Size = new System.Drawing.Size(89, 28);
            this.PatchComboBox.TabIndex = 3;
            this.PatchComboBox.Text = "1.4.3.2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patch:";
            // 
            // OKButton
            // 
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(353, 117);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(124, 43);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "Create Profile";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nickname:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameTextBox.Location = new System.Drawing.Point(143, 128);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(184, 26);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.Text = "\r\n";
            // 
            // ProfileCreationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 175);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatchComboBox);
            this.Controls.Add(this.PathBrowseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProfileCreationDialog";
            this.Text = "ProfileCreationDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PathBrowseButton;
        private System.Windows.Forms.ComboBox PatchComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}