﻿using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Text.Json;
using System.Linq;
using System;



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
            Directory.CreateDirectory(Path.Combine(HKManager.GetSavesPath(), "HKM"));
            using StreamWriter settingWriter = new StreamWriter(Path.Combine(HKManager.GetSavesPath(), "HKM/HKManagerData.json"));
            settingWriter.Write(JsonSerializer.Serialize(this, this.GetType()));
        }

        public static ProfileList LoadProfileList()
        {
            if (File.Exists(Path.Combine(HKManager.GetSavesPath(), "HKM/HKManagerData.json")))
            {
                using StreamReader settingReader = new StreamReader(Path.Combine(HKManager.GetSavesPath(), "HKM/HKManagerData.json"));
                return (ProfileList)JsonSerializer.Deserialize(settingReader.ReadToEnd(), typeof(ProfileList));
            }
            else return null;
        }
        #endregion

    }
    /// <summary>
    /// Reference to a game installation. Contains path, patch, modlist and list of presets.
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
            // get all the files in mods folders that are not already in profile
            foreach (string fileName in Directory.GetFiles(Path.Combine(HKManager.GetManagedPath(InstallPath), "/Mods"))) if (!ContainsFile(fileName))
            {
                    // search downloadlist for a mod w/ same SHA1, if none found, add closest match by file name and disable updates by default
                    bool modConstructed = false;
                    bool modFound = false;
                    Mod modConstruct = new Mod();
                foreach (Mod mod in HKManager.DefaultInstance.DownloadList) if (mod.Files.ContainsKey(Path.GetFileName(fileName)))
                {
                    if (HKManager.SHA1Equals(fileName ,mod.Files[Path.GetFileName(fileName)])) {
                        Mods.Add(mod);
                        HKManager.DefaultInstance.DownloadList.Remove(mod);
                        modFound = true;
                        break;
                    } else 
                    {
                        modConstruct = new Mod() {
                            Name = mod.Name,
                            Description = mod.Description,
                            FullDescription = mod.FullDescription,
                            Dependencies = mod.Dependencies,
                            CheckUpdates = false };

                        modConstruct.Files.Add(Path.GetFileName(fileName), HKManager.ComputeSHA1(fileName));
                        modConstructed = true;
                    }
                }
                if (modConstructed && !modFound)
                {
                    using (ModCreationForm modForm = new ModCreationForm(modConstruct))
                    {
                        modForm.ShowDialog();
                        Mods.Add(modForm.Mod);
                    }
                }
            }
            foreach (string fileName in Directory.GetFiles(HKManager.GetManagedPath(InstallPath)))
            {
                foreach (Mod mod in Mods) if (mod.Files.ContainsKey(Path.GetFileName(fileName)))
                {

                }
            }
        }
        
        private bool ContainsFile(string filename)
        {
            foreach (Mod mod in Mods) if (mod.Files.Keys.Contains(filename))
            {
                return true;
            }
            return false;
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
        public string ID { get; set; } // Unique identifier used to identify mods in a preset.
        public string Name { get; set; }
        public string Description { get; set; } // Description to be shown on hover
        public string FullDescription { get; set; } // Long description seen when installing mods.
        public string BranchName { get; set; } // if empty, mod is not a member of a branch.
        public string BranchDescription { get; set; } // Description of a branch.
        public string Link { get; set; } // Download link.
        public Dictionary<string, string> Files { get; set; } // Key is file name, value is SHA1.
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

    /// <summary>
    /// List of mods from the manifest.
    /// </summary>
    public class DownloadList
    {
        private List<Mod> Downloads = new List<Mod>();
        public List<string> IDs { get; set; }
        public Profile LinkedProfile { get; set; }

        public Mod this[string ID]
        {
            get => Downloads.Find(x => x.ID == ID);
        }

        public void FillIDsFromProfile()
        {
            IDs = new List<string>();
            foreach (Mod mod in LinkedProfile.Mods)
            {
                IDs.Add(mod.ID);
            }
        }

        public List<Mod> GetUninstalledDownloads()
        {
            List<Mod> tmp = new List<Mod>();
            foreach (Mod mod in Downloads) if (!IDs.Contains(mod.ID))
            {
                tmp.Add(mod);
            }
            return tmp;
        }


    }
}
