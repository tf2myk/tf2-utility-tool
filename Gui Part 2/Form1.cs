using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Net;

namespace Gui_Part_2
{
    public partial class Form1 : Form
    {

        public string TF2Directory { get; set; }
        private int Disp { get; set; }
        
        
            

        public Form1()
        {
            InitializeComponent();
        }

   
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //MOREHUD BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            
            string more = "https://imgur.com/a/sxOyM";

            webBrowser1.Navigate(more);
            Disp = 2;
        }
        //HYPNOTIZE BUTTON
        public void button2_Click(object sender, EventArgs e)
        {

            string more = "https://imgur.com/a/4sgZ1";
            Disp = 1;
   
            webBrowser1.Navigate(more);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string more = "https://imgur.com/a/sxOyM";
            webBrowser1.Navigate(more);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string more = "https://imgur.com/a/sxOyM";
            webBrowser1.Navigate(more);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            string more = "https://imgur.com/a/sxOyM";
            webBrowser1.Navigate(more);

            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string more = "https://imgur.com/a/sxOyM";
            webBrowser1.Navigate(more);

        }

        private void button7_Click(object sender, EventArgs e)
        {

            string more = "https://imgur.com/a/sxOyM";
            webBrowser1.Navigate(more);

        }

        private void button8_Click(object sender, EventArgs e)
        {

            string more = "https://imgur.com/a/sxOyM";
            webBrowser1.Navigate(more);

        }

        private void button9_Click(object sender, EventArgs e)
        {

            string more = "https://imgur.com/a/sxOyM";
            webBrowser1.Navigate(more);
            

        }

        //PATH BUTTON
        private void button12_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) //&& folderBrowserDialog1.SelectedPath.Contains("tf\\custom"))
             {
                 button12.Text = (folderBrowserDialog1.SelectedPath);
                button10.Enabled = true;
                TF2Directory = folderBrowserDialog1.SelectedPath;
            }
             else
             {
                 button12.Text = "INVALID PATH";
            }
        }

        //DOWNLOAD BUTTON
        private void button10_Click(object sender, EventArgs e)
        {

            switch (Disp)
            {
                case 1:
                    var client = new WebClient();
                    client.DownloadFile("https://github.com/Hypnootize/Hypnotize-Hud/zipball/master/", "HypnotizeHud.zip");
                    ZipFile.ExtractToDirectory(Application.StartupPath + "\\HypnotizeHud.zip", TF2Directory);
                    break;
                case 2:
                    new WebClient().DownloadFile("https://github.com/Hypnootize/m0rehud/zipball/master/", "m0rehud");
                    ZipFile.ExtractToDirectory(Application.StartupPath + "\\m0rehud.zip", TF2Directory);
                    break;
                default:
                    // Do for everything else
                    break;
            }
        }
    }
}
