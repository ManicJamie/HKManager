
namespace HKManager
{
    partial class PatchSelectionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatchSelectionDialog));
            this.TextLabel = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextLabel
            // 
            this.TextLabel.Location = new System.Drawing.Point(12, 9);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(283, 43);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Select your Hollow Knight Patch.\r\n(if you\'re unsure, select 1.4.3.2)\r\n";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "1.2.2.1",
            "1.4.3.2"});
            this.comboBox.Location = new System.Drawing.Point(26, 58);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(136, 24);
            this.comboBox.TabIndex = 2;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(228, 58);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(67, 35);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // PatchSelectionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 105);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.TextLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatchSelectionDialog";
            this.Text = "HKManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button OKButton;
    }
}