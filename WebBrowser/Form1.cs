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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (webBrows.CanGoForward)
            {
                webBrows.GoForward();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrows.Stop();
        }

        private void home_Click(object sender, EventArgs e)
        {
            webBrows.GoHome();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (webBrows.CanGoBack)
            {
                webBrows.GoBack();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            webBrows.Refresh();
        }

        private void go_Click(object sender, EventArgs e)
        {
            string WebPage = textBox1.Text.Trim();
            webBrows.Navigate(WebPage);
        }
    }
}
