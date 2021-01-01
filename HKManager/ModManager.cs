using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKManager
{
    class ModManager
    {
        public struct Mod
        {
            public string name;
            public string path;
            public string readmePath;
            public bool enabled;
        }

        private Mod[] modList = new Mod[0];

        public void DisableMod(int modIndex)
        {
            modList[modIndex].enabled = false;
        }

        public void EnableMod(int modIndex)
        {
            modList[modIndex].enabled = true;
        }

        public void LoadModList(Mod[] newModList)
        {


        }
    }
}
