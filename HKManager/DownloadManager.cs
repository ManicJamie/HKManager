using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HKManager
{
    class DownloadManager
    {
        private FileDownloader downloader = new FileDownloader();
        private FileManager fileManager;

        public DownloadManager(FileManager manager)
        {
            fileManager = manager;
        }


    }
}

