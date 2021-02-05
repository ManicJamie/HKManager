using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HKManager
{
    public struct Mod
    {
        public string name;
        public string fileName;
        public string description;
        public List<ModVersion> VersionList;
    }

    public struct ModVersion
    {
        public string buildNum;
        public string Iteration;
        public string patch;
        public string updateDetails;
        public string URI;
        public List<string> DependencyNames;
    }

    public class ModManager
    {
        private DownloadManager downloadManager;
        private FileManager fileManager;
        private List<Mod> mods;
        private List<Mod> onlineMods;

        public ModManager(DownloadManager downloader, FileManager file)
        {
            downloadManager = downloader;
            fileManager = file;
        }

        public void DisableMod()
        {
        }

        public void EnableMod()
        {
        }

        public void AddModToLocal(Mod mod)
        {

        }
        
        public List<Mod> GetModList() { return mods; }
        public FileManager GetFileManager() { return fileManager; }
    }
}
