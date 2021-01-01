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
        public bool IsAPIInstalled()
        {
            return true;
        }

        public bool SetDLL()
        {
            if (File.Exists(Properties.Settings.Default.installFolder + "/hollow_knight_Data/Managed/Assembly-CSharp.dll")) {
                //set dll
                return true;
            }
            return false;
        }

        public void GetDLL(int patch)
        {
            switch (patch)
            {
                case 1432:
                    Console.WriteLine("a");
                    break;
                case 1221:
                    Console.WriteLine("a");
                    break;
                default:
                    MessageBox.Show("Something went wrong internally. (Wrong patch num received by GetDLL)");
                    break;
            }
        }
    }
}
