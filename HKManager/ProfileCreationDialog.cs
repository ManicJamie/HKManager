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
    public partial class ProfileCreationDialog : Form
    {
        public string patch;
        public string path;
        public string name;
        public ProfileCreationDialog()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            patch = PatchComboBox.Text;
            path = PathTextBox.Text;
            name = NameTextBox.Text;
            Close();
        }
    }
}
