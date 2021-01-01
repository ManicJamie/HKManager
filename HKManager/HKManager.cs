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
        private const string Version = "b0.0";

        private APIManager aPIManager = new APIManager();


        public HKManager()
        {
            InitializeComponent();
        }

        private void HKManager_Load(object sender, EventArgs e)
        {
            
        }


    }
}
