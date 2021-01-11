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
    public class DownloadManager
    {
        const string manifestLink = "https://drive.google.com/file/d/1vGl3pTN-RcdsbL3Xt2qm_6aVCx8vHbCn/view?usp=sharing";
        private XmlDocument manifest;
        private FileDownloader downloader = new FileDownloader();
        private FileManager fileManager;
        private ManualResetEvent manifestDownloading = new ManualResetEvent(false);
        public ManualResetEvent downloadInProgress = new ManualResetEvent(true);

        public DownloadManager(FileManager manager)
        {
            fileManager = manager;
        }

        public void DownloadManifest()
        {
            downloader.DownloadFileCompleted += (sender, e) => IngestManifest();
            downloader.DownloadFile(manifestLink, "HKManager_Data/temp/manifest.xml");
            manifestDownloading.WaitOne();
        }

        private void IngestManifest()
        {
            manifest = new XmlDocument();
            manifest.Load("HKManager_Data/temp/manifest.xml");
            manifestDownloading.Set();
            downloader.DownloadFileCompleted -= (sender, e) => IngestManifest(); // remove self from file completed event
        }

        public void DownloadAPI(string patch)
        {
            manifestDownloading.WaitOne(); // wait for manifest to be ingested before attempting to use
            foreach (XmlNode API in manifest.DocumentElement.FirstChild.ChildNodes)
            {
                if (API.FirstChild.InnerText == patch) {
                    downloader.DownloadFileAsync(API.LastChild.InnerText, "HKManager_Data/temp/" + API.FirstChild.InnerText.Replace(".", "") + ".zip"); //PatchNo is FirstChild, URI is LastChild
                    downloader.DownloadFileCompleted += (sender, e) => fileManager.IngestAPI(API.FirstChild.InnerText.Replace(".", ""));
                    return;
                }
            }
        }

        public XmlDocument GetManifest() { return manifest; }
        public FileDownloader GetDownloader() { return downloader; }
    }
}

