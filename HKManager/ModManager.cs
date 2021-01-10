using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKManager
{
    class ModManager
    {
        private DownloadManager downloadManager;
        private FileManager fileManager;

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

        
    }
}
