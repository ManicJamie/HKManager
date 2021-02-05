using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Xml;

namespace HKManager
{
    public class FileManager
    {
        private SettingsManager settingsManager;
        private XmlDocument localManifest;
        
        // INIT
        public FileManager(SettingsManager manager)
        {
            settingsManager = manager;
            LoadLocalManifest();
        }

        public bool FileTreeExists() // Check if file tree exists. If not, create file tree with user confirmation. 
        {
            if (!Directory.Exists("HKManager_Data"))
            {
                switch (MessageBox.Show("OK to create file tree? Note file tree will be created in the same folder as the installer executable.", "HKManager", MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
                        Directory.CreateDirectory("HKManager_Data");
                        Directory.CreateDirectory("HKManager_Data/APIs");
                        Directory.CreateDirectory("HKManager_Data/APIs/1432");
                        Directory.CreateDirectory("HKManager_Data/APIs/1221");
                        Directory.CreateDirectory("HKManager_Data/Mods");
                        Directory.CreateDirectory("HKManager_Data/temp");
                        return true;
                    default:
                        return false;
                }
            }
            else return true;
        }

        public void SetAPI(string APIPath)
        {
            string newPath = settingsManager.GetPath() + "/hollow_knight_data/Managed/Assembly-CSharp.dll";
            File.Copy(APIPath, newPath, true);
        }

        public void IngestAPI(string patch) // Extract API to own directory and delete zip.
        {
            ZipFile.ExtractToDirectory("HKManager_Data/temp/" + patch + ".zip", "HKManager_Data/APIs/");
            File.Copy("HKManager_Data/APIs/" + patch + "/Assembly-CSharp.xml", settingsManager.GetPath() + "/Hollow_Knight_Data/Managed/Assembly-CSharp.xml", true);
            File.Delete("HKManager_Data/temp/" + patch + ".zip");
        }

        public void IngestMod(Mod mod)
        {
            ZipFile.ExtractToDirectory("HKManager_Data/temp/" + mod.name + ".zip", "HKManager_Data/Mods/");
            File.Delete("HKManager_Data/temp/" + mod.name + ".zip");
        }

        public bool IsAPIDownloaded(string patch)
        {
            if (Directory.Exists("HKManager_Data/APIs/" + patch.Replace(".","")))
            {
                if (File.Exists("HKManager_Data/APIs/" + patch.Replace(".", "") + "/modded.dll") && File.Exists("HKManager_Data/APIs/" + patch.Replace(".", "") + "/vanilla.dll")) return true; else return false;
            } else return false;
        } 

        public bool IsGameModded(string patch)
        {
            if (IsAPIDownloaded(patch))
            {
                if (!File.Exists(settingsManager.GetPath() + "/Hollow_Knight_Data/Managed/Assembly-CSharp.dll")) 
                { // Manage issues arising from Assembly-CSharp.dll not existing.
                    throw new FileNotFoundException("HK assembly file not found.");
                }
                byte[] gameAPI = File.ReadAllBytes(settingsManager.GetPath() + "/Hollow_Knight_Data/Managed/Assembly-CSharp.dll");
                byte[] moddingAPI = File.ReadAllBytes("HKManager_Data/APIs/" + patch.Replace(".", "") + "/modded.dll");
                if (gameAPI.Equals(moddingAPI)) return true;
                else return false;
            } else {
            } return false;
        }

        // Handling localManifest
        public void LoadLocalManifest()
        {
            if (!File.Exists("HKManager_Data/localmanifest.xml")) { return; }
            localManifest = new XmlDocument();
            localManifest.Load("HKManager_Data/localmanifest.xml");
        }

        public void SaveLocalManifest()
        {
            localManifest.Save("HKManager_Data/localmanifest.xml");
        }

        public void AddModToLocalManifest(Mod mod)
        {
            XmlNode modNode = localManifest.CreateNode(XmlNodeType.Element, "Mod", "");

            XmlNode nameNode = localManifest.CreateNode(XmlNodeType.Element, "Name", ""); 
            nameNode.InnerText = mod.name;
            modNode.AppendChild(nameNode);

            XmlNode fileNameNode = localManifest.CreateNode(XmlNodeType.Element, "Filename", "");
            fileNameNode.InnerText = mod.fileName;
            modNode.AppendChild(fileNameNode);

            XmlNode descriptonNode = localManifest.CreateNode(XmlNodeType.Element, "Description", "");
            descriptonNode.InnerText = mod.description;
            modNode.AppendChild(descriptonNode);

            modNode.AppendChild(VersionListToXML(mod));
        }

        private XmlNode VersionListToXML(Mod mod)
        {
            XmlNode versionListNode = localManifest.CreateNode(XmlNodeType.Element, "VersionList", "");
            foreach (ModVersion version in mod.VersionList)
            {
                XmlNode versionNode = localManifest.CreateNode(XmlNodeType.Element, "Version", "");

                XmlNode BuildNode = localManifest.CreateNode(XmlNodeType.Element, "BuildNum", "");
                BuildNode.InnerText = version.buildNum;
                versionNode.AppendChild(BuildNode);

                XmlNode IterationNode = localManifest.CreateNode(XmlNodeType.Element, "Iteration", "");
                IterationNode.InnerText = version.Iteration;
                versionNode.AppendChild(IterationNode);

                XmlNode PatchNode = localManifest.CreateNode(XmlNodeType.Element, "Patch", "");
                PatchNode.InnerText = version.patch;
                versionNode.AppendChild(PatchNode);

                XmlNode UpdateDetailsNode = localManifest.CreateNode(XmlNodeType.Element, "UpdateDetails", "");
                UpdateDetailsNode.InnerText = version.patch;
                versionNode.AppendChild(UpdateDetailsNode);

                XmlNode DependenciesNode = localManifest.CreateNode(XmlNodeType.Element, "Dependencies", "");

                versionListNode.AppendChild(versionNode);
            }
            return versionListNode;
        }

        private XmlNode DependenciesListToXML(ModVersion version)
        {
            XmlNode dependenciesListNode = localManifest.CreateNode(XmlNodeType.Element, "Dependencies", "");
            foreach (string dependency in version.DependencyNames)
            {
                XmlNode nameNode = localManifest.CreateNode(XmlNodeType.Element, "Name", "");
                nameNode.InnerText = dependency;
                dependenciesListNode.AppendChild(nameNode);
            }
            return dependenciesListNode;
        }

        public SettingsManager GetSettingsManager() { return settingsManager; } // Provide settingsManager
        
    }
}
