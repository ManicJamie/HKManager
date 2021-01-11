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
        private SettingsManager settingsManager;

        public APIManager(FileManager manager)
        {
            fileManager = manager;
            settingsManager = fileManager.GetSettingsManager();
        }

        public void UpdateAPIManager()
        {
            APIenabled = fileManager.IsGameModded(settingsManager.GetPatch());
        }

        public bool EnableAPI()
        {
            switch (fileManager.GetSettingsManager().GetPatch())
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

        public bool DisableAPI()
        {
            switch (fileManager.GetSettingsManager().GetPatch())
            {
                case "1.2.2.1":
                    fileManager.SetAPI(APILocation + "1221/Vanilla.dll");
                    APIenabled = false;
                    return true;
                case "1.4.3.2":
                    fileManager.SetAPI(APILocation + "1432/Vanilla.dll");
                    APIenabled = false;
                    return true;
                default:
                    return false;
            }
        }

        public bool IsAPIEnabled() { return APIenabled; }
    }
}
