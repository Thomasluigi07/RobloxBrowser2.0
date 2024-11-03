using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RBLXBrowser : Form
    {
        public RBLXBrowser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.roblox.com/feeds/", System.UriKind.Absolute);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.roblox.com/my/avatar", System.UriKind.Absolute);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.roblox.com/games", System.UriKind.Absolute);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.roblox.com/develop", System.UriKind.Absolute);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.roblox.com/develop/library", System.UriKind.Absolute); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.roblox.com/catalog", System.UriKind.Absolute);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("http://www.roblox.com/User.aspx?", System.UriKind.Absolute);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.roblox.com/my/messages#!/inbox", System.UriKind.Absolute); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.roblox.com/users/friends#!/friends", System.UriKind.Absolute);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.roblox.com/home", System.UriKind.Absolute);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.roblox.com/my/money.aspx/", System.UriKind.Absolute);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
            var text = String.Concat(textBox1.Text, " - Browser");
            this.Text = text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("http://www.roblox.com/User.aspx?", System.UriKind.Absolute);
            var thing = String.Concat(textBox1.Text, "/inventory/");
            webBrowser1.Url = new System.Uri(thing, System.UriKind.Absolute);

        }
    }
}
