﻿using System;
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
        private Dictionary<string, string> SHA1ToPatch;
        private List<string> Patches;

        public ProfileCreationDialog(List<API> apis)
        {
            APIs = apis;
            SHA1ToPatch = GetSHA1ToPatches();
            InitializeComponent();
            FillPatchComboBox();
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

        private Dictionary<string,string> GetSHA1ToPatches()
        {
            Dictionary<string, string> SHA1Dict = new Dictionary<string, string>();
            Patches = new List<string>();
            foreach (API aPI in APIs)
            {
                SHA1Dict.Add(aPI.SHA1, aPI.Patch);
                if (!Patches.Contains(aPI.Patch))
                {
                    Patches.Add(aPI.Patch);
                }
            }
            Patches.Sort();
            return SHA1Dict;
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
            if (Directory.Exists(testPath) && File.Exists(Path.Combine(HKManager.GetManagedPath(testPath), "Assembly-CSharp.dll")))
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
                patch = GetPatch();
                PatchComboBox.SelectedItem = patch;
                PatchComboBox.Enabled = (patch != null) ? false : true;
            } else
            {
                PatchComboBox.Enabled = false;
                PatchComboBox.SelectedItem = null;
                APIComboBox.Enabled = false;
                APIComboBox.SelectedItem = null;
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
            string returnPatch = null;
            string sha1 = HKManager.ComputeSHA1(Path.Combine(HKManager.GetManagedPath(path), "Assembly-CSharp.dll"));
            SHA1ToPatch.TryGetValue(HKManager.ComputeSHA1(Path.Combine(HKManager.GetManagedPath(path), "Assembly-CSharp.dll")).ToUpperInvariant(), out returnPatch);
            return returnPatch;
        }

        private void FillPatchComboBox()
        {
            PatchComboBox.Items.AddRange(Patches.ToArray());
        }
    }
}
