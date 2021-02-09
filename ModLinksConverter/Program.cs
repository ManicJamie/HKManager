using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ModLinksConverter
{
    class Program
    {
        private const string MODLINKS_URI = "https://raw.githubusercontent.com/ManicJamie/HKManager/main/HKManager/Resources/ModLinks.xml";

        static void Main(string[] args)
        {
            XDocument modLinksOld = new XDocument();
            XDocument.Load(MODLINKS_URI);
        }
    }
}
