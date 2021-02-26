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
        private Mod mod;
        public Mod Mod => mod;

        private readonly bool newModCreation = false;
        
        public ModCreationForm()
        {
            newModCreation = true;
            InitializeComponent();
        }

        public ModCreationForm(Mod modConstructor)
        {
            mod = modConstructor;
            FileNameBox.Text = mod.Files.First().Key;
            FileNameBox.Enabled = false;
            NameBox.Text = mod.Name;
            NameBox.Enabled = false;
            DescBox.Text = mod.Description;
            DescBox.Enabled = false;
            BDescBox.Text = mod.FullDescription;
            BDescBox.Enabled = false;
        }

        private void ModCreationForm_Load(object sender, EventArgs e)
        {
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
