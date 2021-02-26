using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography;

/// <summary>
/// Purely exists for utility purposes; you can use it to compute SHA1 hashes of files for addition to ModLinks.
/// </summary>
namespace ModLinksConverter
{
    class Program
    {
        private const string MODLINKS_URI = "https://raw.githubusercontent.com/Ayugradow/ModInstaller/master/modlinks.xml";

        static void Main(string[] args)
        {
            GenerateXMLFromModLinks();
        }

        private static bool SHA1Equals(string file, string sha1) => string.Equals(ComputeSHA1(file), sha1, StringComparison.InvariantCultureIgnoreCase);
        private static string ComputeSHA1(string file)
        {
            var sha1 = SHA1.Create();

            FileStream stream = File.OpenRead(file);

            byte[] hash = sha1.ComputeHash(stream);

            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
        static void GenerateXMLFromModLinks()
        {
            XDocument newModLinks = new XDocument();
            newModLinks.Add(new XElement("ModList"));
            XDocument modLinksOld = new XDocument();
            modLinksOld = XDocument.Load(MODLINKS_URI);
            foreach (XElement element in modLinksOld.Element("ModLinks").Element("ModList").Elements("ModLink"))
            {
                newModLinks.Element("ModList").Add(new XElement("ModLink",
                    element.Element("Name"),
                    element.Element("Description"),
                    new XElement("FullDescription"),
                    new XElement("Patches", new XElement("Patch", "1.4.3.2")),
                    element.Element("Files"),
                    element.Element("Link"),
                    element.Element("Dependencies")
                    ));
            }

            // write it to console for some reason, idk im goddamn stupid
            StringWriter writer = new StringWriter();
            newModLinks.Save(writer);
            Console.WriteLine(writer.ToString());
            Console.ReadLine();
        }

        static void GetAssemblySHA1s()
        {
            List<string> vs = new List<string>();
            vs.Add("1028.dll");
            vs.Add("1114.dll");
            vs.Add("1118.dll");
            vs.Add("1221.dll");
            vs.Add("1424.dll");
            vs.Add("1432.dll");
            vs.Add("1432Modded.dll");
            vs.Add("1028LoadExtender.dll");
            vs.Add("1221Modded.dll");
            vs.Add("1028Modded.dll");
            foreach (string a in vs)
            {
                Console.WriteLine(a + "|||" + ComputeSHA1(@"C:\Users\Jamie\Desktop\Speedrun\Assemblies\" + a).ToUpper());
            }
            // testing around w/ piracy SHA1s for jokes
            //Console.WriteLine("unins000.exe" + "|||" + ComputeSHA1(@"D:\MurkyWaters\Hollow Knight Godmaster\unins000.exe").ToUpper());
            //Console.WriteLine("unins000.dat" + "|||" + ComputeSHA1(@"D:\MurkyWaters\Hollow Knight Godmaster\unins000.dat").ToUpper());
            Console.ReadLine();
        }
    }
}
