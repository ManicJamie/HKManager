using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace HKManager
{
    /// <summary>
    /// List of profiles. Contains method to serialize into XML document, to be stored in settings.
    /// </summary>
    public class ProfileList
    {
        // Must be a public property for serialization.
        public List<Profile> _ProfileList { get; set; }

        public ProfileList()
        {
            _ProfileList = new List<Profile>();
        }

        public void CreateProfile(string name, string path, string patch, API aPI)
        {
            Profile newProfile = new Profile()
            {
                Name = name,
                InstallPath = path,
                Patch = patch,
                Api = aPI
            };
            _ProfileList.Add(newProfile);
        }

        public Profile ProfileWithName(string name)
        {
            foreach (Profile profile in _ProfileList) if (profile.Name == name)
            {
                return profile;
            }
            return null;
        }

        #region Serialization
        public void SaveProfileList()
        {
            Properties.Settings.Default.ProfileList = JsonSerializer.Serialize(this, this.GetType());
            Properties.Settings.Default.Save();
        }

        public static ProfileList LoadProfileList()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ProfileList))
            {
                return (ProfileList)JsonSerializer.Deserialize(Properties.Settings.Default.ProfileList, typeof(ProfileList));
            }
            else return null;
        }
        #endregion
    }
    /// <summary>
    /// Reference to a game installation. Contains path, patch and list of presets.
    /// </summary>
    public class Profile
    {
        public string Name { get; set; }
        public string InstallPath { get; set; }
        public string Patch { get; set; }
        public API Api { get; set; }
        public List<Preset> Presets { get; set; }
        public List<Mod> Mods { get; set; }

        public void PopulateModListFromFiles()
        {
            List<string> filenames = new List<string>();
            // get all the files in mods folders
            foreach (string fileName in Directory.GetFiles(HKManager.OS == "MacOS" ? 
                $"{InstallPath}/Contents/Resources/Data/Managed"
                : $"{InstallPath}/hollow_knight_Data/Managed"))
            {
                foreach (Mod mod in Mods) if (mod.Files.ContainsKey(Path.GetFileName(fileName)))
                {
                    if (HKManager.SHA1Equals(fileName ,mod.Files[Path.GetFileName(fileName)])) {

                    }
                }
            }
            foreach (string fileName in Directory.GetFiles(HKManager.OS == "MacOS" ?
                $"{InstallPath}/Contents/Resources/Data/Managed/Disabled"
                : $"{InstallPath}/hollow_knight_Data/Managed/Disabled"))
            {
                foreach (Mod mod in Mods) if (mod.Files.ContainsKey(Path.GetFileName(fileName)))
                {

                }
            }
        }

    }

    /// <summary>
    /// List of ModIDs, stored by the profile.
    /// </summary>
    public class Preset
    {
        string Name { get; set; }
        List<string> IDList { get; }

        public Preset()
        {
            IDList = new List<string>();
        }

        public void AddToPreset(string modID)
        {
            IDList.Add(modID);
        }

        public void RemoveFromPreset(string modID)
        {
            IDList.Remove(modID);
        }

    }

    /// <summary>
    /// Mod.
    /// </summary>
    public class Mod
    {
        public int ID { get; set; } // Unique identifier used to identify mods in a preset.
        public string Name { get; set; }
        public string Description { get; set; } // Description to be shown on hover
        public string FullDescription { get; set; } // Long description seen when installing mods.
        public string BranchName { get; set; } // if empty, mod is not a member of a branch.
        public string BranchDescription { get; set; } // Description of a branch.
        public string Link { get; set; } // Download link.
        public Dictionary<string, string> Files { get; set; } // Key is file path, value is SHA1.
        public List<string> Dependencies { get; set; }
        public List<string> Optional { get; set; }
        public bool Enabled { get => Enabled; set => EnableOrDisable(value); } // Use custom setter to move files when enabled/disabled.
        public bool UpdateRequired { get; set; } = false;
        public bool CheckUpdates { get; set; } = true;

        public Mod()
        {
            Files = new Dictionary<string, string>();
            Dependencies = new List<string>();
            Optional = new List<string>();
        }

        private void EnableOrDisable(bool value)
        {
            if (value) { Enable(); } else { Disable(); }
        }

        private void Enable()
        {

        }

        private void Disable()
        {

        }
    }

    /// <summary>
    /// API. Any mod that replaces Assembly-CSharp.dll. File path is inferred from Enabled and profile path.
    /// </summary>
    public class API
    {
        public string Name { get; set; }
        public string Patch { get; set; }
        public string Version { get; set; } 
        public string Link { get; set; }
        public string SHA1 { get; set; }
        public string Enabled { get; }
    }

}
