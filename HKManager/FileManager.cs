using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HKManager
{
    class FileManager
    {
        public bool FileTreeExists() // Check if file tree exists. If not, create file tree.
        {
            if (!Directory.Exists("HKManager_Data"))
            {
                switch (MessageBox.Show("OK to create file tree? Note file tree will be created in the same folder as the installer executable.", "HKManager", MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
                        Directory.CreateDirectory("HKManager_Data");
                        Directory.CreateDirectory("HKManager_Data/APIs");
                        Directory.CreateDirectory("HKManager_Data/Mods");
                        Directory.CreateDirectory("HKManager_Data/Downloads");
                        return true;
                    default:
                        return false;
                }
            }
            else return true;
        }
    }
}
