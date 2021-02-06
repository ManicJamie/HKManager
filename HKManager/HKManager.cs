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
        private const string Version = "0.1";

        public HKManager()
        {
            InitializeComponent();
        }

        private void HKManager_Load(object sender, EventArgs e)
        {
            this.Text = "HKManager " + Version;
        }

        #region Loading HKManager
        #endregion
    }
}
