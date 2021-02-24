
namespace HKManager
{
    partial class ModCreationForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BNameBox = new System.Windows.Forms.TextBox();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LongDescBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BDescBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 73);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(133, 20);
            this.NameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Branch Name:";
            // 
            // BNameBox
            // 
            this.BNameBox.Location = new System.Drawing.Point(12, 113);
            this.BNameBox.Name = "BNameBox";
            this.BNameBox.Size = new System.Drawing.Size(100, 20);
            this.BNameBox.TabIndex = 3;
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(12, 25);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(133, 20);
            this.FileNameBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "File Name:";
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(201, 23);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(221, 49);
            this.DescBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Extended Description:";
            // 
            // LongDescBox
            // 
            this.LongDescBox.Location = new System.Drawing.Point(201, 96);
            this.LongDescBox.Multiline = true;
            this.LongDescBox.Name = "LongDescBox";
            this.LongDescBox.Size = new System.Drawing.Size(221, 92);
            this.LongDescBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Branch Description:";
            // 
            // BDescBox
            // 
            this.BDescBox.Location = new System.Drawing.Point(12, 152);
            this.BDescBox.Multiline = true;
            this.BDescBox.Name = "BDescBox";
            this.BDescBox.Size = new System.Drawing.Size(172, 36);
            this.BDescBox.TabIndex = 10;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 205);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(172, 43);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "Add Mod";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(201, 195);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(221, 56);
            this.InfoLabel.TabIndex = 13;
            this.InfoLabel.Text = "Please note: Mods added from this dialog will not be kept up-to-date. Please add " +
    "mods from the \"Download Mods\" tab if you wish to stay up-to-date.";
            // 
            // ModCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 260);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BDescBox);
            this.Controls.Add(this.LongDescBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.BNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.DescBox);
            this.Name = "ModCreationForm";
            this.Text = "Mod Details";
            this.Load += new System.EventHandler(this.ModCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BNameBox;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LongDescBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BDescBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label InfoLabel;
    }
}