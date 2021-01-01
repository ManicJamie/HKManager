using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HKManager
{
    class SettingsManager
    {
        private string OS;
        private List<string> defaultpaths;

        public bool CheckPathExists()
        {
            if (!Directory.Exists(Properties.Settings.Default.HKFolder))
            {
                return false;
            }
            else return true;
        }

        private void FillDefaultPaths()
        {
            switch (OS)
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
        }

        private void GetOS()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                OS = "Windows";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                OS = "MacOS";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                OS = "Linux";
            else
                OS = "Windows";
        }

        public void SetDefaultPath(string path)
        {
            DialogResult dialogResult = MessageBox.Show("Is this your Hollow Knight installation path?\n" + path,"Confirm:", MessageBoxButtons.YesNo);
        }
    }
}
