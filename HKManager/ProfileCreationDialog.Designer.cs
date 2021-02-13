
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
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathBrowseButton = new System.Windows.Forms.Button();
            this.PatchComboBox = new System.Windows.Forms.ComboBox();
            this.PatchLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.APILabel = new System.Windows.Forms.Label();
            this.APIComboBox = new System.Windows.Forms.ComboBox();
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
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(16, 11);
            this.PathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(52, 24);
            this.PathLabel.TabIndex = 1;
            this.PathLabel.Text = "Path:";
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
            this.PathBrowseButton.Click += new System.EventHandler(this.PathBrowseButton_Click);
            // 
            // PatchComboBox
            // 
            this.PatchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatchComboBox.Enabled = false;
            this.PatchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatchComboBox.FormattingEnabled = true;
            this.PatchComboBox.Location = new System.Drawing.Point(16, 112);
            this.PatchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatchComboBox.Name = "PatchComboBox";
            this.PatchComboBox.Size = new System.Drawing.Size(109, 28);
            this.PatchComboBox.TabIndex = 3;
            this.PatchComboBox.SelectedIndexChanged += new System.EventHandler(this.PatchComboBox_SelectedIndexChanged);
            // 
            // PatchLabel
            // 
            this.PatchLabel.AutoSize = true;
            this.PatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatchLabel.Location = new System.Drawing.Point(16, 87);
            this.PatchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatchLabel.Name = "PatchLabel";
            this.PatchLabel.Size = new System.Drawing.Size(62, 24);
            this.PatchLabel.TabIndex = 4;
            this.PatchLabel.Text = "Patch:";
            // 
            // OKButton
            // 
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(353, 172);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(125, 43);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "Create Profile";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameLabel.Location = new System.Drawing.Point(16, 154);
            this.NicknameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(100, 24);
            this.NicknameLabel.TabIndex = 6;
            this.NicknameLabel.Text = "Nickname:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameTextBox.Location = new System.Drawing.Point(16, 180);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(184, 26);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.Text = "\r\n";
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // APILabel
            // 
            this.APILabel.AutoSize = true;
            this.APILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APILabel.Location = new System.Drawing.Point(145, 87);
            this.APILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.APILabel.Name = "APILabel";
            this.APILabel.Size = new System.Drawing.Size(114, 24);
            this.APILabel.TabIndex = 8;
            this.APILabel.Text = "API Version:";
            // 
            // APIComboBox
            // 
            this.APIComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.APIComboBox.Enabled = false;
            this.APIComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APIComboBox.FormattingEnabled = true;
            this.APIComboBox.Location = new System.Drawing.Point(149, 112);
            this.APIComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.APIComboBox.Name = "APIComboBox";
            this.APIComboBox.Size = new System.Drawing.Size(193, 28);
            this.APIComboBox.TabIndex = 9;
            this.APIComboBox.SelectedIndexChanged += new System.EventHandler(this.APIComboBox_SelectedIndexChanged);
            // 
            // ProfileCreationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 230);
            this.Controls.Add(this.APIComboBox);
            this.Controls.Add(this.APILabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.PatchLabel);
            this.Controls.Add(this.PatchComboBox);
            this.Controls.Add(this.PathBrowseButton);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProfileCreationDialog";
            this.Text = "Create a Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button PathBrowseButton;
        private System.Windows.Forms.ComboBox PatchComboBox;
        private System.Windows.Forms.Label PatchLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.FolderBrowserDialog BrowserDialog;
        private System.Windows.Forms.Label APILabel;
        private System.Windows.Forms.ComboBox APIComboBox;
    }
}