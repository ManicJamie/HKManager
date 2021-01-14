﻿using System;
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

        public SettingsManager GetSettingsManager() { return settingsManager; } // Provide settingsManager
        
    }
}
