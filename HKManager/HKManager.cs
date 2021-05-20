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
        public static string OS;
        private bool IsOffline;
        public static HKManager DefaultInstance { get; set; }
        private bool Terminating = false; // Application.Exit() doesn't immediately terminate the program, so we must prevent it from continuing manually.

        private ProfileList profileList;
        private XDocument ModLinks;
        public List<Mod> DownloadList;
        private List<API> APIList;

        private Profile currentProfile;

        public HKManager()
        {
            InitializeComponent();
            // Get OS
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                OS = "Windows";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                OS = "MacOS";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                OS = "Linux";
            else
                OS = "Windows";

            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12; // Forces TLS 1.2 for github downloads, since some OS don't select it by default.
            DefaultInstance = this;
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
                #if !DEBUG
                CheckUpdate();
                #endif

                DownloadList = CreateDownloadList();
                APIList = CreateAPIList();
            } 
            else
            {
                TabContainer.TabPages.Remove(ModDownloadTab); 
            }

            LoadOrCreateProfiles();
            if (Terminating) { Close(); return; }

            UpdateProfileBox();
            ProfileBox.SelectedIndex = 0;

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
                    Terminating = true;
                }
            }
        }
#endregion

#region Profile Handling
        private bool CreateNewProfile()
        {
            profileList = new ProfileList();
            using (ProfileCreationDialog creationDialog = new ProfileCreationDialog(APIList))
            {
                switch (creationDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        profileList.CreateProfile(creationDialog.profileName, creationDialog.path, creationDialog.patch, creationDialog.aPI);
                        profileList.SaveProfileList();
                        SwitchProfile(profileList.ProfileWithName(creationDialog.profileName));
                        return true;
                    default:
                        return false;
                }
            }
        }

        private void SwitchProfile(Profile profile)
        {
            currentProfile = profile;
            UpdateProfileLabels();
        }
#endregion

#region ModLinks handling
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
                if (element.Element("OS").Value == "Universal" || element.Element("OS").Value == OS) // Only add to APIs if compatible OS.
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

        public Mod CheckDownloadListForFile(string filename)
        {
            foreach (Mod mod in DownloadList) if (mod.Files.Keys.Contains(filename)) // for each mod w/ this filename present
            {
                if (SHA1Equals(filename, mod.Files[filename])) // if SHA1 is same, add it.
                {
                    return mod;
                }
            }
            return null;
        }

#endregion

#region SHA1 computation & Static Methods
        public static bool SHA1Equals(string file, string sha1) => string.Equals(ComputeSHA1(file), sha1, StringComparison.InvariantCultureIgnoreCase);
        public static string ComputeSHA1(string file)
        {
            var sha1 = SHA1.Create();

            FileStream stream = File.OpenRead(file);

            byte[] hash = sha1.ComputeHash(stream);

            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }

        public static string GetSavesPath()
        {
            switch (OS)
            {
                case "Windows":
                    return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"..\LocalLow\Team Cherry\Hollow Knight\");
                case "MacOS":
                    return @"~/Library/Application Support/unity.Team Cherry.Hollow Knight/";
                case "Linux":
                    return @"~/.config/unity3d/Team Cherry/Hollow Knight/";
                default:
                    return "";
            }
        }

        public static string GetManagedPath(string InstallPath)
        {
            return HKManager.OS == "MacOS"
                ? $"{InstallPath}/Contents/Resources/Data/Managed"
                : $"{InstallPath}/hollow_knight_Data/Managed";
        }
#endregion

#region Display
        private void UpdateProfileBox()
        {
            string selectedItem = (string)ProfileBox.SelectedItem;
            ProfileBox.Items.Clear();
            foreach (Profile profile in profileList._ProfileList)
            {
                ProfileBox.Items.Add(profile.Name);
            }
            ProfileBox.SelectedItem = selectedItem;
        }

        private void UpdateProfileLabels()
        {
            PathLabel.Text = currentProfile.InstallPath;
            VersionLabel.Text = "Version: " + currentProfile.Patch + " | " + currentProfile.Api.Version;
        }

        /// <summary>
        /// Restructures the mod list view completely. Only use when a file is changed.
        /// </summary>
        private void BuildModTreeView()
        {
            ModTreeView.BeginUpdate();
            ModTreeView.Nodes.Clear();
            List<Mod> addedMods = new List<Mod>();
            ModNameComparer modNameComparer = new ModNameComparer();
            foreach (Mod mod in currentProfile.Mods)
            {
                if (!addedMods.Contains(mod, modNameComparer)) // if the mod does not already exist in the treeview
                {
                    ModTreeView.Nodes.Add(new ModNode(mod));
                } else
                {
                    ModNode parent = (ModNode)ModTreeView.Nodes.Find(mod.Name, false)[0];
                    if (parent.FirstNode == null) 
                    {
                        parent.Nodes.Add(new ModNode(parent.mod, true)
                        {
                            Name = parent.mod.BranchName == null ? "Main" : parent.mod.BranchName
                        }); // create child for main branch
                    }
                    parent.Nodes.Add(new ModNode(mod, true)); // add new branch
                }
                addedMods.Add(mod);
            }
            ModTreeView.EndUpdate();
        }
#endregion

#region Handlers
        private void DriveButton_Click(object sender, EventArgs e)
        {
            // apparently there can be issues finding the default browser if we don't do this. better to be safe ¯\_(ツ)_/¯
            var ps = new ProcessStartInfo(ModLinks.Root.Element("DriveLink").Value)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void GameFolderButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(currentProfile.InstallPath))
            {
                Process.Start(new ProcessStartInfo()
                {
                    Arguments = currentProfile.InstallPath,
                    FileName = "explorer.exe"
                }
);
            }
        }

        private void SaveFolderButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(GetSavesPath()))
            {
                Process.Start(new ProcessStartInfo()
                {
                    Arguments = GetSavesPath(),
                    FileName = "explorer.exe"
                }
                );
            }
        }

        private void ProfileBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchProfile(profileList.ProfileWithName(ProfileBox.SelectedItem.ToString()));
        }

        private void ModTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {

        }

        private void JamieLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo((string)e.Link.LinkData)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
        #endregion

        private void PBoxContext_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void MainContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    class ModNameComparer : IEqualityComparer<Mod>
    {
        public bool Equals(Mod m1, Mod m2)
        {
            if (m1 == null && m2 == null) { return true; }
            if (m1 == null || m2 == null) { return false; }
            if (m1.Name == m2.Name) { return true; }
            return false;
        }

        public int GetHashCode(Mod m)
        {
            return (m.Name).GetHashCode();
        }
    }

    class ModNode : TreeNode
    {
        public Mod mod;

        public ModNode(Mod m, bool isBranch = false) : base(!isBranch ? m.Name : m.BranchName)
        {
            mod = m;
            Checked = m.Enabled;
        }
        public ModNode(string s) : base(s) { }
    }
}
