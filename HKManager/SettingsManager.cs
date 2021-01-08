using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace HKManager
{
    class SettingsManager
    {
        public List<string> GetDefaultPaths()
        {
            List<string> defaultpaths = new List<string>();
            switch (GetOS())
            {
                case "Windows":
                    //Default Steam and GOG install paths for Windows.
                    defaultpaths.Add("Program Files (x86)/Steam/steamapps/Common/Hollow Knight");
                    defaultpaths.Add("Program Files/Steam/steamapps/Common/Hollow Knight");
                    defaultpaths.Add("Steam/steamapps/common/Hollow Knight");
                    defaultpaths.Add("Program Files (x86)/GOG Galaxy/Games/Hollow Knight");
                    defaultpaths.Add("Program Files/GOG Galaxy/Games/Hollow Knight");
                    defaultpaths.Add("GOG Galaxy/Games/Hollow Knight");
                    break;
                case "Linux":
                    // Default steam installation path for Linux.
                    defaultpaths.Add(Environment.GetEnvironmentVariable("HOME") + "/.steam/steam/steamapps/common/Hollow Knight");
                    break;
                case "MacOS":
                    //Default steam installation path for Mac.
                    defaultpaths.Add
                        (Environment.GetEnvironmentVariable("HOME") + "/Library/Application Support/Steam/steamapps/common/Hollow Knight/hollow_knight.app");
                    break;
            }
            return defaultpaths;
        }

        private string GetOS()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return "Windows";

            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return "MacOS" ;


            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return "Linux" ;

            else return "Windows";
                
        }

        public void CreateNewAppSettings()
        {
            FindDefaultPath();
        }

        private void FindDefaultPath()
        {
            string path = "";
            foreach (string testPath in GetDefaultPaths())
            {
                if (CheckPathForHK(testPath))
                {
                    path = testPath;
                    SetPath(path);
                    return;
                }
            }
            
            if (!SetUserPath())
            {
                MessageBox.Show("HKManager requires to know the location of your Hollow Knight Install. \r\nThe application will now exit.", "HKManager");
            }
        }

        public bool SetUserPath()
        {
            string path = "";
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            browserDialog.Description = "Select the Hollow Knight folder";
            while (path == "")
            {
                switch (browserDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        if (CheckPathForHK(browserDialog.SelectedPath)) path = browserDialog.SelectedPath;
                        break;
                    case DialogResult.Cancel:
                    case DialogResult.Abort:
                        return false;
                }

            }
            SetPath(path);
            return true;
        }

        private bool CheckPathForHK(string probe)
        {
            if (File.Exists(probe + "/hollow_knight.exe")) return true;
            else return false;
        }
        
        public void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }

        public string GetPath() { return Properties.Settings.Default.HKPath; }
        public void SetPath(string newPath) { Properties.Settings.Default.HKPath = newPath; }
        public bool AreSettingsEmpty() { if (Properties.Settings.Default.HKPath == "") return true; else return false; }
    }
}
