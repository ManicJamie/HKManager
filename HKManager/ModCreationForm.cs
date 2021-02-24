using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HKManager
{
    public partial class ModCreationForm : Form
    {
        public string FileName { get; set; }
        public string ModName { get; set; }
        public string BranchName { get; set; }
        public string BranchDesc { get; set; }
        public string Desc { get; set; }
        public string FullDesc { get; set; }

        private readonly bool newModCreation;
        
        public ModCreationForm(bool New)
        {
            newModCreation = New;
            InitializeComponent();
        }

        private void ModCreationForm_Load(object sender, EventArgs e)
        {
            if (FileName != null)
            {
                FileNameBox.Text = FileName;
                FileNameBox.Enabled = false;
            }
            if (!newModCreation)
            {
                InfoLabel.Visible = false;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
