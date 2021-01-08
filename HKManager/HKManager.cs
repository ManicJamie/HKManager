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
    public partial class HKManager : Form
    {
        private const string Version = "a1.0";
        private SettingsManager settingsManager = new SettingsManager();
        private ModManager modManager = new ModManager();
        private APIManager apiManager = new APIManager();
        private FileManager fileManager = new FileManager();

        public HKManager()
        {
            InitializeComponent();
        }

        private void HKManager_Load(object sender, EventArgs e)
        {
            if (!fileManager.FileTreeExists()) // close app if user denies creating file tree
            {
                this.Close(); Application.Exit();
            } 
            if (settingsManager.AreSettingsEmpty())
            {
                settingsManager.CreateNewAppSettings();
            }
            UpdatePathLabel();
            this.Size = this.MinimumSize;
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            settingsManager.SetUserPath();
            UpdatePathLabel();
        }

        public void CloseSignalReceived(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePathLabel()
        {
            PathLabel.Text = "Path: " + settingsManager.GetPath();
        }

        private void HKManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingsManager.SaveSettings();
        }
    }
}
