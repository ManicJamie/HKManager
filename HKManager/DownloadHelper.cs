using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace HKManager
{
    class DownloadHelper
    {
        private WebClient _webClient;
        private string _modname;

        public event EventHandler DownloadProgressChanged;
        public event EventHandler DownloadCompleted;

        private void StartDownload(Uri uri, string path, string modName)
        {
            _modname = modName;
            using (_webClient = new WebClient())
            {
                _webClient.DownloadFileCompleted += Completed;
                _webClient.DownloadProgressChanged += ProgressChanged;

                try
                {
                    // Start downloading the file
                    _webClient.DownloadFileAsync(uri, path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadProgressChanged.Invoke(this, e);
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            DownloadCompleted.Invoke(this, e);
        }

    }
}
