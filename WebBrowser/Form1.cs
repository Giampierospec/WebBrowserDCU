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
        /// <summary>
        /// This function initializes the browser
        /// </summary>
        public Browser()
        {

            InitializeComponent();
            disableStuff();
            searchBar.Text = "google.com";
            webBrows.Navigate("google.com");
        }
        /// <summary>
        /// This function returns the browser to home page
        /// </summary>

        private void homeBtn_Click(object sender, EventArgs e)
        {
            searchBar.Text = "google.com";
            webBrows.Navigate("google.com");
        }
        /// <summary>
        /// This function returns the page back
        /// </summary>

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (webBrows.CanGoBack)
            {
                PageUrl();
                webBrows.GoBack();
            }
        }
        /// <summary>
        /// Forwards the page
        /// </summary>

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (webBrows.CanGoForward)
            {
                PageUrl();
                webBrows.GoForward();
            }
        }
        /// <summary>
        /// Refreshes the page
        /// </summary>

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            webBrows.Refresh();
        }
        /// <summary>
        /// Stops the page
        /// </summary>

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrows.Stop();
        }
        /// <summary>
        /// Stops the page
        /// </summary>

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            disableStuff();
            string WebPage = searchBar.Text.Trim();
            webBrows.Navigate(WebPage);
        }


        /// <summary>
        /// When you hit enter it searchs the direction
        /// </summary>

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                disableStuff();
                string webPage = searchBar.Text.Trim();
                webBrows.Navigate(webPage);
            }
        }
        /// <summary>
        /// Checks when the page stops loading
        /// </summary>

        private void webBrows_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            searchBar.Enabled = true;
            toolStripButton6.Enabled = true;
            PageUrl();

        }
        /// <summary>
        /// Disables some buttons on page loading
        /// </summary>
        private void disableStuff()
        {
            searchBar.Enabled = false;
            toolStripButton6.Enabled = false;
        }
        private void PageUrl()
        {
            if (webBrows.Url != null)
            {
                searchBar.Text = webBrows.Url.AbsoluteUri;
            }
        }
    }
}
