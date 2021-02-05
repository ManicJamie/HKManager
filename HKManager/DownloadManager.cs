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

        // Manifest encapsulation
        private XmlDocument manifest;
        private ManualResetEvent manifestDownloading = new ManualResetEvent(false);

        public XmlDocument Manifest { get => GetManifest(); private set => manifest = value; }
        private XmlDocument GetManifest() { manifestDownloading.WaitOne(); return manifest; }

        // Downloader & FileManager encapsulation
        private FileDownloader downloader = new FileDownloader();
        private FileManager fileManager;

        public FileDownloader Downloader { get => downloader; private set => downloader = value; }
        public FileManager FileManager { get => fileManager; set => fileManager = value; }

        // Initialisation
        public DownloadManager(FileManager manager)
        {
            FileManager = manager;
        }

        // Manifest Downloading
        public void DownloadManifest()
        {
            Downloader.DownloadFileCompleted += (sender, e) => IngestManifest();
            Downloader.DownloadFile(manifestLink, "HKManager_Data/temp/manifest.xml");
        }

        private void IngestManifest()
        {
            Manifest = new XmlDocument();
            Manifest.Load("HKManager_Data/temp/manifest.xml");
            manifestDownloading.Set();
            Downloader.DownloadFileCompleted -= (sender, e) => IngestManifest(); // remove self from file completed event
        }

        // File Downloading
        public void DownloadAPI(string patch)
        {
            foreach (XmlNode API in Manifest.DocumentElement.SelectSingleNode("APIList").ChildNodes)
            {
                if (API.SelectSingleNode("Number").InnerText == patch) {
                    Downloader.DownloadFileAsync(API.LastChild.InnerText, "HKManager_Data/temp/" + API.SelectSingleNode("Number").InnerText.Replace(".", "") + ".zip"); //PatchNo is FirstChild, URI is LastChild
                    Downloader.DownloadFileCompleted += (sender, e) => FileManager.IngestAPI(API.SelectSingleNode("Number").InnerText.Replace(".", ""));
                    return;
                }
            }
        }

        public void DownloadMod(Mod mod)
        {
            
        }

        // Handling XML
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
                VersionConstruct.Iteration = node.SelectSingleNode("Iteration").InnerText;
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

        public FileDownloader GetDownloader() { return Downloader; }
    }
}

