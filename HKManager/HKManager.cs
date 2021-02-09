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
        private const string MODLINKS_URI = "https://raw.githubusercontent.com/ManicJamie/HKManager/main/HKManager/Resources/ModLinks.xml";
        public static readonly string OS;
        public bool IsOffline;

        private ProfileList profileList;
        private XDocument ModLinks;
        private List<Mod> DownloadList;
        public List<API> APIList;

        public HKManager()
        {
            InitializeComponent();
        }

        static HKManager()
        {
            // Get OS
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                OS = "Windows";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                OS = "MacOS";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                OS = "Linux";
            else
                OS = "Windows";
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
                DownloadList = CreateDownloadList();
                APIList = CreateAPIList();
            } else
            {
                TabContainer.TabPages.Remove(ModDownloadTab); 
            }

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

        private void LoadOrCreateProfiles()
        {
            profileList = ProfileList.LoadProfileList();
            if (profileList == null) // If no profileList exists:
            {
                if (!CreateNewProfile()) // Attempt to create new profile.
                {
                    // Application needs at least one profile to exist.
                    MessageBox.Show("HKManager needs you to create a profile in order to function properly.", "Exiting...", MessageBoxButtons.OK);
                    Application.Exit(); 
                } 
            }
        }

        private bool CreateNewProfile()
        {
            profileList = new ProfileList();
            using (ProfileCreationDialog creationDialog = new ProfileCreationDialog(APIList))
            {
                switch (creationDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        profileList.CreateProfile(creationDialog.profileName, creationDialog.path, creationDialog.patch);
                        profileList.SaveProfileList();
                        return true;
                    default:
                        return false;
                }
            }
            
        }
        #endregion

        #region Profile loading / mod discovery
        private void PopulateModListFromFile()
        {

        }

        private List<Mod> CreateDownloadList()
        {
            List<Mod> _downloadList = new List<Mod>();
            foreach (XElement element in ModLinks.Root.Element("ModList").Elements("Mod"))
            {
                Mod modConstructor = new Mod()
                {
                    Name = element.Element("Name").Value,
                    Description = element.Element("Description").Value,
                    FullDescription = element.Element("FullDescription").Value,
                    BranchName = element.Element("BranchName").Value,
                    BranchDescription = element.Element("BranchDescription").Value,
                    Link = element.Element("Link").Value
                };
                foreach (XElement file in element.Element("Files").Elements("File"))
                {
                    modConstructor.Files.Add(file.Element("Name").Value, file.Element("SHA1").Value);
                }
                if (element.Elements("Dependencies").Any())
                {
                    foreach (XElement dependency in element.Element("Dependencies").Elements("string"))
                    {
                        modConstructor.Dependencies.Add(dependency.Value);
                    }
                }
                _downloadList.Add(modConstructor);
            }
            return _downloadList;
        }

        private List<API> CreateAPIList()
        {
            List<API> _apis = new List<API>();
            foreach (XElement element in ModLinks.Root.Element("APIList").Elements("API"))
            {
                API apiConstructor = new API()
                {
                    Name = element.Element("Name").Value,
                    Patch = element.Attribute("Patch").Value,
                    Version = element.Element("Version").Value,
                    Link = element.Element("Link").Value,
                    SHA1 = element.Element("SHA1").Value
                };
                _apis.Add(apiConstructor);
            }
            return _apis;
        }

        #endregion

        #region SHA1 computation
        private static bool SHA1Equals(string file, string sha1) => string.Equals(ComputeSHA1(file), sha1, StringComparison.InvariantCultureIgnoreCase);
        private static string ComputeSHA1(string file)
        {
            var sha1 = SHA1.Create();

            FileStream stream = File.OpenRead(file);

            byte[] hash = sha1.ComputeHash(stream);

            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
        #endregion
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
