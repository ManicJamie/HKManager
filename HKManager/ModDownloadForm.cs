using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;
using System.Runtime;
using System.Diagnostics;

namespace HKManager
{
    public partial class ModDownloadForm : Form
    {
        private ModManager modManager;
        const string DriveURL = "https://drive.google.com/drive/u/4/folders/1sG2cWt0AtjbRmlE2TWeDswfSruJVoBjf";

        public ModDownloadForm(ModManager manager)
        {
            InitializeComponent();
            modManager = manager;
        }

        private void ModDownloadForm_Load(object sender, EventArgs e)
        {
            
        }

        private void DriveButton_Click(object sender, EventArgs e) // Opens HKManager google drive.
        {
            Process.Start(DriveURL);
        }

        private void ModFolderButton_Click(object sender, EventArgs e) // Opens mod folder.
        {
            Process.Start(modManager.GetFileManager().GetSettingsManager().GetPath() + "/Hollow_Knight_Data/Managed/Mods");
        }
    }
}
