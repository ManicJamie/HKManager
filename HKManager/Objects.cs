﻿using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Text.Json;

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
                Path = path,
                Patch = patch,
                api = aPI
            };
            _ProfileList.Add(newProfile);
        }

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
    }
    /// <summary>
    /// Reference to a game installation. Contains path, patch and list of presets.
    /// </summary>
    public class Profile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Patch { get; set; }
        public API api { get; set; }
        public List<Preset> Presets { get; set; }
        public List<Mod> Mods { get; set; }

        public void PopulateModListFromFiles()
        {
            foreach (string fileName in Directory.GetFiles(Path))
            {

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

        public Mod()
        {
            Files = new Dictionary<string, string>();
            Dependencies = new List<string>();
            Optional = new List<string>();
        }
    }

    /// <summary>
    /// API. Any mod that replaces Assembly-CSharp.dll
    /// </summary>
    public class API
    {
        public string Name { get; set; }
        public string Patch { get; set; }
        public string Version { get; set; } 
        public string Link { get; set; }
        public string SHA1 { get; set; }
    }

}
