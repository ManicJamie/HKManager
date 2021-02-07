using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace HKManager
{
    /// <summary>
    /// List of profiles. Contains method to serialize into XML document, to be stored in settings.
    /// </summary>
    class ProfileList
    {
        public List<Profile> _ProfileList = new List<Profile>();

        public void CreateProfile(string name, string path, string patch)
        {
            Profile newProfile = new Profile()
            {
                Name = name,
                Path = path,
                Patch = patch
            };
            _ProfileList.Add(newProfile);
        }

        public void SaveProfileList()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProfileList));
            StringWriter stringWriter = new StringWriter();
                
            xmlSerializer.Serialize(stringWriter, this);
            Properties.Settings.Default.ProfileList = stringWriter.ToString();
            stringWriter.Dispose();

            Properties.Settings.Default.Save();
        }

        public static ProfileList LoadProfileList()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ProfileList))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProfileList));
                using (StringReader stringReader = new StringReader(Properties.Settings.Default.ProfileList))
                {
                    return (ProfileList)xmlSerializer.Deserialize(stringReader);
                }
            }
            else return null;
        }
    }
    /// <summary>
    /// Reference to a game installation. Contains path, patch and list of presets.
    /// </summary>
    class Profile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Patch { get; set; }
        public List<Preset> Presets { get; set; }
        public List<Mod> Mods { get; set; }
    }

    /// <summary>
    /// List of ModIDs, stored by the profile.
    /// </summary>
    class Preset
    {
        string Name { get; set; }
        List<string> IDList { get; }

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
    class Mod
    {
        public string Name { get; set; }
        public string Description { get; set; } // Description to be shown on hover
        public string FullDescription { get; set; } // Long description seen when installing mods.
        public string BranchName { get; set; } // if empty, mod is not a member of a branch.
        public string BranchDescription { get; set; } // Description of a branch.
        public Dictionary<string, string> Files { get; set; } // Key is file path, value is SHA1.
        public List<string> Dependencies { get; set; }
    }

    /// <summary>
    /// API.
    /// </summary>
    class API
    {
        public string patch { get; set; }
        public string Version { get; set; } 
        public string Link { get; set; }
        public KeyValuePair<string, string> file { get; set; }

    }

}
