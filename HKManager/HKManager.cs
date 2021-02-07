using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HKManager
{
    public partial class HKManager : Form
    {
        private const string Version = "v0.1";
        private const string MODLINKS_URI = "https://raw.githubusercontent.com/Ayugradow/ModInstaller/master/modlinks.xml";
        private string OS;
        private List<string> _defaultPaths = new List<string>();
        public bool IsOffline;

        private ProfileList profileList;
        private XDocument ModLinks;

        public HKManager()
        {
            InitializeComponent();
        }

        private void HKManager_Load(object sender, EventArgs e)
        {
            if (!GetModLinks())
            {
                Application.Exit();
                return;
            }
            if (!IsOffline)
            {
            //CheckUpdate(); // DONT HAVE THIS COMMENTED OUT WHEN YOU BUILD DUMMY
            } else
            {
                TabContainer.TabPages.Remove(ModDownloadTab);
            }
            GetCurrentOS();
            FillDefaultPaths();
            LoadOrCreateProfiles();


            // Remove unused tabs from TabContainer
            TabContainer.TabPages.Remove(SkinTab);
            TabContainer.TabPages.Remove(LevelTab);

            this.Text = "HKManager " + Version + (IsOffline ? " (Offline Mode)" : "");
        }

        #region Loading HKManager
        /// <summary>
        /// Downloads Modlinks.xml. If connection failed, offer user option to enter offline mode, retry or exit.
        /// </summary>
        /// <returns>true if application should proceed, false if application should exit.</returns>
        private bool GetModLinks()
        {
            while (true)
            {
                try
                {
                    ModLinks = XDocument.Load(MODLINKS_URI);
                    return true;
                }
                catch (Exception)
                {
                    switch (new ConnectionFailedForm().ShowDialog())
                    {
                        case DialogResult.OK: // Should enter offline mode
                            IsOffline = true;
                            return true;
                        case DialogResult.Retry:
                            break;
                        default: // User cancelled, should exit application
                            return false;
                    }
                }
            }

        }
        private void CheckUpdate()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            string file = Path.GetFileName(Assembly.GetEntryAssembly()?.Location);
           

            if (File.Exists($"{dir}/lol.exe"))
                File.Delete($"{dir}/lol.exe");

            if (File.Exists($"{dir}/AU.exe"))
                File.Delete($"{dir}/AU.exe");

            XElement installer = ModLinks.Element("ModLinks")?.Element("Installer");

            // If the SHA1s are non-equal, update.
            if (installer == null || SHA1Equals($"{dir}/{file}", installer.Element("SHA1")?.Value)) return;

            var dl = new WebClient();
            dl.DownloadFile
            (
                new Uri
                (
                    installer.Element("AULink")?.Value ?? throw new NoNullAllowedException("AULink Missing!")
                ),
                $"{dir}/AU.exe"
            );
            var process = new Process
            {
                StartInfo =
                {
                    FileName = $"{dir}/AU.exe",
                    Arguments = $"\"{dir}\" {installer.Element("Link")?.Value} {file}"
                }
            };
            process.Start();
            Application.Exit();
        }

        private void GetCurrentOS()
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

        private void FillDefaultPaths()
        {
            switch (OS)
            {
                case "Windows":
                    //Default Steam and GOG install paths for Windows.
                    _defaultPaths.Add("Program Files (x86)/Steam/steamapps/Common/Hollow Knight");
                    _defaultPaths.Add("Program Files/Steam/steamapps/Common/Hollow Knight");
                    _defaultPaths.Add("Steam/steamapps/common/Hollow Knight");
                    _defaultPaths.Add("Program Files (x86)/GOG Galaxy/Games/Hollow Knight");
                    _defaultPaths.Add("Program Files/GOG Galaxy/Games/Hollow Knight");
                    _defaultPaths.Add("GOG Galaxy/Games/Hollow Knight");
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

        private void LoadOrCreateProfiles()
        {
            profileList = ProfileList.LoadProfileList();
            if (profileList == null)
            {
                profileList = new ProfileList();
                
                profileList.CreateProfile("","","");
            }
        }
        #endregion

        private static bool SHA1Equals(string file, string sha1) => string.Equals(ComputeSHA1(file), sha1, StringComparison.InvariantCultureIgnoreCase);
        private static string ComputeSHA1(string file)
        {
            var sha1 = SHA1.Create();

            FileStream stream = File.OpenRead(file);

            byte[] hash = sha1.ComputeHash(stream);

            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }

        #region Handlers
        private void DriveButton_Click(object sender, EventArgs e)
        {
            // apparently there can be issues finding the default browser if we don't do this
            var ps = new ProcessStartInfo(ModLinks.Element("DriveLink").Value)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
        #endregion
    }
}
