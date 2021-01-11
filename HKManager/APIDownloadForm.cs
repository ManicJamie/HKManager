using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace HKManager
{
    public partial class APIDownloadForm : Form
    {
        private DownloadManager downloader;
        private string myPatch;

        public APIDownloadForm(DownloadManager download, string patch)
        {
            InitializeComponent();
            downloader = download;
            myPatch = patch;
            DownloadLabel.Text = "Downloading ModdingAPI for " + patch;
        }

        public void DownloadAPI()
        {
            downloader.GetDownloader().DownloadProgressChanged += UpdateProgressBar;
            downloader.GetDownloader().DownloadFileCompleted += DownloadFinished;
            downloader.DownloadAPI(myPatch);
        }

        private void UpdateProgressBar(object sender, FileDownloader.DownloadProgress progress)
        {
            downloadProgressBar.Value = progress.ProgressPercentage;
        }

        private void DownloadFinished(object sender, EventArgs e)
        {
            this.Close();
        }

        private void APIDownloadForm_Load(object sender, EventArgs e)
        {
            DownloadAPI();
        }
    }
}
