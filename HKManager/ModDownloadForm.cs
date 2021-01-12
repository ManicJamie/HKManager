using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HKManager
{
    public partial class ModDownloadForm : Form
    {

        public struct Mod
        {
            public string name;
            public string description;
            public List<ModVersion> VersionList;
        }

        public struct ModVersion
        {
            public string buildNum;
            public int Iteration;
            public string patch;
            public string updateDetails;
            public string URI;
            public List<string> DependencyNames;
        }

        public ModDownloadForm(XmlNode modList)
        {
            InitializeComponent();
        }

        private void ModDownloadForm_Load(object sender, EventArgs e)
        {
            
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
    }
}
