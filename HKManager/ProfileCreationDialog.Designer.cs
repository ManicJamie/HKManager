
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
            this.PathTextBox.Location = new System.Drawing.Point(12, 30);
            this.PathTextBox.Multiline = true;
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(246, 37);
            this.PathTextBox.TabIndex = 0;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(12, 9);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(42, 18);
            this.PathLabel.TabIndex = 1;
            this.PathLabel.Text = "Path:";
            // 
            // PathBrowseButton
            // 
            this.PathBrowseButton.Location = new System.Drawing.Point(265, 30);
            this.PathBrowseButton.Name = "PathBrowseButton";
            this.PathBrowseButton.Size = new System.Drawing.Size(94, 37);
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
            this.PatchComboBox.Items.AddRange(new object[] {
            "1.1.1.8",
            "1.2.2.1",
            "1.3.1.5",
            "1.4.2.4",
            "1.4.3.2"});
            this.PatchComboBox.Location = new System.Drawing.Point(12, 91);
            this.PatchComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PatchComboBox.Name = "PatchComboBox";
            this.PatchComboBox.Size = new System.Drawing.Size(83, 24);
            this.PatchComboBox.TabIndex = 3;
            this.PatchComboBox.SelectedIndexChanged += new System.EventHandler(this.PatchComboBox_SelectedIndexChanged);
            // 
            // PatchLabel
            // 
            this.PatchLabel.AutoSize = true;
            this.PatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatchLabel.Location = new System.Drawing.Point(12, 71);
            this.PatchLabel.Name = "PatchLabel";
            this.PatchLabel.Size = new System.Drawing.Size(50, 18);
            this.PatchLabel.TabIndex = 4;
            this.PatchLabel.Text = "Patch:";
            // 
            // OKButton
            // 
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(265, 140);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(94, 35);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "Create Profile";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameLabel.Location = new System.Drawing.Point(12, 125);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(79, 18);
            this.NicknameLabel.TabIndex = 6;
            this.NicknameLabel.Text = "Nickname:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameTextBox.Location = new System.Drawing.Point(12, 146);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(139, 23);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.Text = "\r\n";
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // APILabel
            // 
            this.APILabel.AutoSize = true;
            this.APILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APILabel.Location = new System.Drawing.Point(109, 71);
            this.APILabel.Name = "APILabel";
            this.APILabel.Size = new System.Drawing.Size(88, 18);
            this.APILabel.TabIndex = 8;
            this.APILabel.Text = "API Version:";
            // 
            // APIComboBox
            // 
            this.APIComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.APIComboBox.Enabled = false;
            this.APIComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APIComboBox.FormattingEnabled = true;
            this.APIComboBox.Location = new System.Drawing.Point(112, 91);
            this.APIComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APIComboBox.Name = "APIComboBox";
            this.APIComboBox.Size = new System.Drawing.Size(146, 24);
            this.APIComboBox.TabIndex = 9;
            this.APIComboBox.SelectedIndexChanged += new System.EventHandler(this.APIComboBox_SelectedIndexChanged);
            // 
            // ProfileCreationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 187);
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
            this.Name = "ProfileCreationDialog";
            this.Text = "ProfileCreationDialog";
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