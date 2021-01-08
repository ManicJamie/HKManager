using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HKManager
{
    class APIManager
    {
        private const string APILocation = "HKManager_Data/APIs/";
        private bool APIenabled = false;
        private FileManager fileManager;
        private string patch;
        private string OS;

        public APIManager(FileManager manager)
        {
            fileManager = manager;
            OS = fileManager.GetOS();
        }

        public bool EnableAPI()
        {
            switch (patch)
            {
                case "1.2.2.1":
                    fileManager.SetAPI(APILocation + "1221/Modded.dll");
                    APIenabled = true;
                    return true;
                case "1.4.3.2":
                    fileManager.SetAPI(APILocation + "1432/Modded.dll");
                    APIenabled = true;
                    return true;
                default:
                    return false;
            }
        }

        public void SetPatch(string newpatch) { patch = newpatch; }
        public string GetPatch() { return patch; }
    }
}
