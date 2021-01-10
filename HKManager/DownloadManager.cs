using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace HKManager
{
    class DownloadManager
    {
        const string manifestLink = "https://drive.google.com/file/d/1vGl3pTN-RcdsbL3Xt2qm_6aVCx8vHbCn/view?usp=sharing";
        private XmlDocument manifest;
        private FileDownloader downloader = new FileDownloader();
        private FileManager fileManager;
        

        public DownloadManager(FileManager manager)
        {
            fileManager = manager;
            DownloadManifest();
        }

        public void DownloadManifest()
        {
            downloader.DownloadFileAsync(manifestLink, "temp/manifest.xml");
            downloader.DownloadFileCompleted += (sender, e) => IngestManifest();
        }

        private void IngestManifest()
        {
            manifest = new XmlDocument();
            manifest.Load("temp/manifest.xml");
            downloader.DownloadFileCompleted -= (sender, e) => IngestManifest(); // remove self from file completed event
        }

        public void DownloadAPIs()
        {
            foreach (XmlNode API in manifest.DocumentElement.FirstChild.ChildNodes)
            {
                downloader.DownloadFileAsync(API.LastChild.InnerText, "HKManager_Data/Downloads/" + API.FirstChild.InnerText.Replace(".","") + ".zip"); //PatchNo is FirstChild, URI is LastChild
                downloader.DownloadFileCompleted += (sender, e) => fileManager.IngestAPI(API.FirstChild.InnerText.Replace(".", ""));
            }
        }

        public XmlDocument GetManifest() { return manifest; }
    }
}

