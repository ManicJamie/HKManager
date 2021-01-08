using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HKManager
{
    public partial class HKManager : Form
    {
        private const string Version = "a1.0";
        private SettingsManager settingsManager = new SettingsManager();
        private ModManager modManager = new ModManager();
        private APIManager apiManager = new APIManager();

        public HKManager()
        {
            InitializeComponent();
        }

        private void HKManager_Load(object sender, EventArgs e)
        {
        }
    }
}
