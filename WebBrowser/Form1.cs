using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Browser : Form
    {
        public Browser()
        {

            InitializeComponent();
            disableStuff();
            searchBar.Text = "google.com";
            webBrows.Navigate("google.com");
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            webBrows.Navigate("google.com");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (webBrows.CanGoBack)
            {
                webBrows.GoBack();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (webBrows.CanGoForward)
            {
                webBrows.GoForward();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            webBrows.Refresh();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrows.Stop();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            disableStuff();
            string WebPage = searchBar.Text.Trim();
            webBrows.Navigate(WebPage);
        }

        

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                disableStuff();
                string webPage = searchBar.Text.Trim();
                webBrows.Navigate(webPage);
            }
        }

        private void webBrows_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            searchBar.Enabled = true;
            toolStripButton6.Enabled = true;
        }
        private void disableStuff()
        {
            searchBar.Enabled = false;
            toolStripButton6.Enabled = false;
        }
    }
}
