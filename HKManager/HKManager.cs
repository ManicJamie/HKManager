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
        private FileManager fileManager;
        private APIManager apiManager;
        private ModManager modManager;

        public HKManager()
        {
            InitializeComponent();
        }

        private void HKManager_Load(object sender, EventArgs e)
        {
            this.Text = "HKManager " + Version;
            fileManager = new FileManager(settingsManager);
            apiManager = new APIManager(fileManager);
            modManager = new ModManager();
            if (!fileManager.FileTreeExists()) // close app if user denies creating file tree
            {
                this.Close(); Application.Exit();
            } 
            if (settingsManager.AreSettingsEmpty())
            {
                settingsManager.CreateNewAppSettings();
            }
            UpdatePathLabel();
            UpdatePatchLabel();
            this.Size = this.MinimumSize;
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            PatchSelectionDialog myPatchDialog = new PatchSelectionDialog();
            if (!settingsManager.SetUserPath()) { this.Close(); Application.Exit(); }
            switch (myPatchDialog.ShowDialog())
            {
                case DialogResult.OK:
                    settingsManager.SetPatch(myPatchDialog.selectedPatch);
                    break;
                default:
                    settingsManager.SetPatch("1.4.3.2"); // Assume user has no clue what patches are and set patch for them.
                    break;
            }
            UpdatePathLabel();
            UpdatePatchLabel();
        }

        public void CloseSignalReceived(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePathLabel()
        {
            PathLabel.Text = "Path: " + settingsManager.GetPath();
        }

        private void UpdatePatchLabel()
        {
            try
            {
                VersionLabel.Text = "Patch: " + settingsManager.GetPatch();
            } catch (System.NullReferenceException e)
            {
                MessageBox.Show("frick");
                // leave label text
            }
        }

        private void HKManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingsManager.SaveSettings();
        }
    }
}
