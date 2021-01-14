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
        public const string Version = "0.1";
        private SettingsManager settingsManager = new SettingsManager();
        private FileManager fileManager;
        private APIManager apiManager;
        private ModManager modManager;
        private DownloadManager downloadManager;

        public HKManager()
        {
            InitializeComponent();
            // instantiate classes
            this.Text = "HKManager " + Version;
            fileManager = new FileManager(settingsManager);
            apiManager = new APIManager(fileManager);
            modManager = new ModManager(downloadManager, fileManager);
            downloadManager = new DownloadManager(fileManager);
        }

        private void HKManager_Load(object sender, EventArgs e)
        {
            if (!fileManager.FileTreeExists()) // close app if user denies creating file tree
            {
                Application.Exit(); Close(); 
            }
            // generate settings if they are not found
            if (settingsManager.AreSettingsEmpty())
            {
                settingsManager.CreateNewAppSettings();
            }
            UpdatePathLabel();
            UpdatePatchLabel();
            this.Size = this.MaximumSize;
            downloadManager.DownloadManifest();
            // download apis if they are not found
            if (!fileManager.IsAPIDownloaded(settingsManager.GetPatch()))
            {
                using (APIDownloadForm apiform = new APIDownloadForm(downloadManager, settingsManager.GetPatch()))
                {
                    apiform.ShowDialog();
                }
            }
            // check status of api and update visuals
            apiManager.UpdateAPIManager();
            if (apiManager.IsAPIEnabled())
            {
                ModdedButton.Checked = true;
            }
            else
            {
                VanillaButton.Checked = true;
            }
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            if (!settingsManager.SetUserPath()) { return; }
            UpdatePathLabel();
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
            } catch (System.NullReferenceException)
            {
                // leave label text as patch is not known
            }
        }

        private void HKManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingsManager.SaveSettings();
        }

        private void PatchButton_Click(object sender, EventArgs e)
        {
            PatchSelectionDialog myPatchDialog = new PatchSelectionDialog();
            switch (myPatchDialog.ShowDialog())
            {
                case DialogResult.OK:
                    settingsManager.SetPatch(myPatchDialog.selectedPatch);
                    break;
                default:
                    return;
            }
            // download apis if they are not found
            if (!fileManager.IsAPIDownloaded(settingsManager.GetPatch()))
            {
                using (APIDownloadForm apiform = new APIDownloadForm(downloadManager, settingsManager.GetPatch()))
                {
                    apiform.ShowDialog();
                }
            }
            // check status of api and update visuals
            apiManager.UpdateAPIManager();
            if (apiManager.IsAPIEnabled())
            {
                ModdedButton.Checked = true;
            }
            else
            {
                VanillaButton.Checked = true;
            }
            UpdatePatchLabel();
        }

        private void modButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton pressedButton = sender as RadioButton;
            if (pressedButton == null)
            {
                MessageBox.Show("Sender is not a radio button");
            }
            
            if (pressedButton == VanillaButton && apiManager.IsAPIEnabled())
            {
                apiManager.DisableAPI();
            } else if (pressedButton == ModdedButton && !apiManager.IsAPIEnabled())
            {
                apiManager.EnableAPI();
            }
            if (apiManager.IsAPIEnabled()) { Size = MaximumSize; }
            else { Size = MinimumSize; }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            ModDownloadForm modDownloadForm = new ModDownloadForm(modManager);
            modDownloadForm.ShowDialog();
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm here to reserve a spot for a function (scanning mods already in the folder) that proved too difficult to initially implement. Expect me to be replaced in future.");
        }
    }
}
