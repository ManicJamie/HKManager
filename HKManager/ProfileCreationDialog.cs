using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HKManager
{
    public partial class ProfileCreationDialog : Form
    {
        public string patch;
        public string path;
        public string profileName;
        public string APIName;
        public API aPI;
        private List<string> _defaultPaths = new List<string>();
        private List<API> APIs;
        private Dictionary<string, string> VanillaSHA1s;

        public ProfileCreationDialog(List<API> apis, Dictionary<string,string> SHA1s)
        {
            APIs = apis;
            VanillaSHA1s = SHA1s;
            InitializeComponent();
            FillDefaultPaths();
            PathTextBox.Text = FindDefaultInstallation();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            patch = PatchComboBox.Text;
            path = PathTextBox.Text;
            profileName = NameTextBox.Text;
            APIName = APIComboBox.Text;
            foreach (API testapi in APIs) if (testapi.Name == APIName && testapi.Patch == patch)
            {
                aPI = testapi;
                break;
            }
            Close();
        }

        private void PathBrowseButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(PathTextBox.Text)) {
                BrowserDialog.SelectedPath = PathTextBox.Text;
            }
            BrowserDialog.ShowDialog();
            PathTextBox.Text = BrowserDialog.SelectedPath;
        }

        private void FillDefaultPaths()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives().Where(d => d.DriveType == DriveType.Fixed))
            {
                switch (HKManager.OS)
                {

                    case "Windows":
                        //Default Steam and GOG install paths for Windows.
                        _defaultPaths.Add(drive.Name + "Program Files (x86)/Steam/steamapps/Common/Hollow Knight");
                        _defaultPaths.Add(drive.Name + "Program Files/Steam/steamapps/Common/Hollow Knight");
                        _defaultPaths.Add(drive.Name + "Steam/steamapps/common/Hollow Knight");
                        _defaultPaths.Add(drive.Name + "Program Files (x86)/GOG Galaxy/Games/Hollow Knight");
                        _defaultPaths.Add(drive.Name + "Program Files/GOG Galaxy/Games/Hollow Knight");
                        _defaultPaths.Add(drive.Name + "GOG Galaxy/Games/Hollow Knight");
                        break;
                    case "Linux":
                        // Default steam installation path for Linux.
                        _defaultPaths.Add(Environment.GetEnvironmentVariable("HOME") + "/.steam/steam/steamapps/common/Hollow Knight");
                        break;
                    case "MacOS":
                        //Default steam installation path for Mac.
                        _defaultPaths.Add
                            (Environment.GetEnvironmentVariable("HOME") + "/Library/Application Support/Steam/steamapps/common/Hollow Knight/hollow_knight.app");
                        break;
                }
            }
        }

        private string FindDefaultInstallation()
        {
            foreach (string testPath in _defaultPaths)
            {
                if (InstallExists(testPath))
                {
                    return testPath;
                }
            }
            return null;
        }

        private bool InstallExists(string testPath)
        {
            if (Directory.Exists(testPath) && File.Exists(testPath + @"\Hollow_Knight_Data\Managed\Assembly-CSharp.dll"))
            {
                return true;
            }
            else return false;
        }

        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InstallExists(PathTextBox.Text))
            {
                path = PathTextBox.Text;
                PatchComboBox.Enabled = true;
                PatchComboBox.SelectedItem = GetPatch();
            } else
            {
                PatchComboBox.Enabled = false;
                APIComboBox.Enabled = false;
            }
        }

        private void PatchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            patch = (string)PatchComboBox.SelectedItem;
            UpdateAPIComboBox();
        }

        private void UpdateAPIComboBox()
        {
            APIComboBox.Enabled = true;
            APIComboBox.Items.Clear();
            foreach (API API in APIs) if (API.Patch == patch)
            {
                APIComboBox.Items.Add(API.Name);
            }
        }

        private void APIComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (APIComboBox.SelectedItem != null)
            {
                NameTextBox.Enabled = true;
            } else
            {
                NameTextBox.Enabled = false;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text == null || NameTextBox.Text == "")
            {
                OKButton.Enabled = false;
            } else
            {
                OKButton.Enabled = true;
            }
        }

        private string GetPatch()
        {
            foreach (string testPatch in VanillaSHA1s.Keys)
            {
                if (HKManager.SHA1Equals(Path.Combine(path, "Hollow_Knight_Data/Managed/Assembly-CSharp.dll") , VanillaSHA1s[testPatch])) { return testPatch; }
            }
            return null;
        }
    }
}
