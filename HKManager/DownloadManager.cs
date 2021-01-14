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
            WaitManifest();
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
            WaitManifest(); // wait for manifest to be ingested before attempting to use
            foreach (XmlNode API in manifest.DocumentElement.SelectSingleNode("APIList").ChildNodes)
            {
                if (API.SelectSingleNode("Number").InnerText == patch) {
                    downloader.DownloadFileAsync(API.LastChild.InnerText, "HKManager_Data/temp/" + API.SelectSingleNode("Number").InnerText.Replace(".", "") + ".zip"); //PatchNo is FirstChild, URI is LastChild
                    downloader.DownloadFileCompleted += (sender, e) => fileManager.IngestAPI(API.SelectSingleNode("Number").InnerText.Replace(".", ""));
                    return;
                }
            }
        }

        public void DownloadMod(Mod mod)
        {
            
        }

        // Handling Manifest.xml
        public List<Mod> GetManifestModList()
        {
            return ParseModListXML(GetManifest().DocumentElement.SelectSingleNode("ModList"));
        }

        private List<Mod> ParseModListXML(XmlNode xmlModList)
        {
            List<Mod> modList = new List<Mod>();
            foreach (XmlNode node in xmlModList.ChildNodes)
            {
                modList.Append(ParseModNodeXML(node));
            }
            return modList;
        }

        private Mod ParseModNodeXML(XmlNode node)
        {
            Mod parsedMod;
            parsedMod.name = node.SelectSingleNode("Name").InnerText;
            parsedMod.fileName = node.SelectSingleNode("Filename").InnerText;
            parsedMod.description = node.SelectSingleNode("Description").InnerText;
            parsedMod.VersionList = ParseVersionNodesXML(node.SelectSingleNode("VersionList").ChildNodes);
            return parsedMod;
        }

        private List<ModVersion> ParseVersionNodesXML(XmlNodeList nodes)
        {
            List<ModVersion> Versions = new List<ModVersion>();
            foreach (XmlNode node in nodes)
            {
                ModVersion VersionConstruct = new ModVersion();
                VersionConstruct.buildNum = node.SelectSingleNode("BuildNum").InnerText;
                VersionConstruct.Iteration = int.Parse(node.SelectSingleNode("Iteration").InnerText);
                VersionConstruct.patch = node.SelectSingleNode("Patch").InnerText;
                VersionConstruct.updateDetails = node.SelectSingleNode("UpdateDetails").InnerText;
                VersionConstruct.URI = node.SelectSingleNode("URI").InnerText;
                foreach (XmlNode dependency in node.SelectSingleNode("Dependencies").ChildNodes)
                {
                    VersionConstruct.DependencyNames.Append(dependency.InnerText);
                }
                Versions.Append(VersionConstruct);
            }
            return Versions;
        }

        public void WaitManifest() { manifestDownloading.WaitOne(); }
        public XmlDocument GetManifest() { WaitManifest(); return manifest; }
        public FileDownloader GetDownloader() { return downloader; }
    }
}

