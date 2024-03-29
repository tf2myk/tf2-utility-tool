﻿using System;
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
using System.IO;

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

        //MOREHUD BUTTON 1
        private void Morehud_Click(object sender, EventArgs e)
        {

            string web = "https://imgur.com/a/sxOyM";

            webBrowser1.Navigate(web);
            Disp = 1;
        }

        //HYPNOTIZE 
        public void Hypnotize_Click(object sender, EventArgs e)
        {

            string web = "https://imgur.com/a/4sgZ1";
            Disp = 2;

            webBrowser1.Navigate(web);

        }
        //TFTV
        private void TFTV_Click(object sender, EventArgs e)
        {

            string web = "https://imgur.com/a/MIlTm";
            Disp = 3;

            webBrowser1.Navigate(web);

        }
        //Broesel-Old
        private void BroeselOld_Click(object sender, EventArgs e)
        {

            string web = "https://imgur.com/a/fG2xQ";
            Disp = 4;

            webBrowser1.Navigate(web);

        }
        //1Shot-Hud
        private void OneShot_Click(object sender, EventArgs e)
        {

            string web = "https://imgur.com/a/HieQg";
            Disp = 5;

            webBrowser1.Navigate(web);


        }
        //Ace-Hud
        private void Ace_Click(object sender, EventArgs e)
        {

            string web = "https://imgur.com/a/uBg83";
            Disp = 6;

            webBrowser1.Navigate(web);

        }
        //Bast-Hud
        private void Bast_Click(object sender, EventArgs e)
        {

            string web = "https://imgur.com/a/gDjCp";
            Disp = 7;

            webBrowser1.Navigate(web);

        }
        //Baz 
        private void Baz_Click(object sender, EventArgs e)
        {

            string web = "https://imgur.com/a/982kf";
            Disp = 8;

            webBrowser1.Navigate(web);

        }
        //Black-Hud
        private void Black_Click(object sender, EventArgs e)
        {

            string web = "https://imgur.com/a/CykiS";
            Disp = 9;

            webBrowser1.Navigate(web);


        }

        //PATH BUTTON
        private void Path_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) //&& folderBrowserDialog1.SelectedPath.Contains("tf\\custom"))
            {
                Path.Text = (folderBrowserDialog1.SelectedPath);
                Install.Enabled = true;
                TF2Directory = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                Path.Text = "INVALID PATH";
            }
        }

        //DOWNLOAD BUTTON
        private void Install_Click(object sender, EventArgs e)
        {

            switch (Disp)
            {
                case 1:
                    new WebClient().DownloadFile("https://www.dropbox.com/s/ppbf4hp6rjz18h6/hypnotize%20hud.rar?dl=1", "m0rehud");
                    ZipFile.ExtractToDirectory(Application.StartupPath + "\\m0rehud.zip", TF2Directory);
                    //if (File.Exists($"{Application.StartupPath} + \\m0rehud.zip"))
                        //File.Delete($"{Application.StartupPath} + \\m0rehud.zip");
                    break;
                case 2:
                    var client = new WebClient();
                    client.DownloadFile("https://github.com/Hypnootize/Hypnotize-Hud/zipball/master/", "HypnotizeHud.zip");
                    ZipFile.ExtractToDirectory(Application.StartupPath + "\\HypnotizeHud.zip", TF2Directory);
                    break;
                case 3:
                    new WebClient().DownloadFile("https://www.dropbox.com/s/ppbf4hp6rjz18h6/hypnotize%20hud.rar?dl=1", "m0rehud");
                    ZipFile.ExtractToDirectory(Application.StartupPath + "\\m0rehud.zip", TF2Directory);
                    break;
                case 4:
                    new WebClient().DownloadFile("https://github.com/Hypnootize/m0rehud/zipball/master/", "m0rehud");
                    ZipFile.ExtractToDirectory(Application.StartupPath + "\\m0rehud.zip", TF2Directory);
                    break;
                case 5:
                    new WebClient().DownloadFile("https://github.com/Hypnootize/m0rehud/zipball/master/", "m0rehud");
                    ZipFile.ExtractToDirectory(Application.StartupPath + "\\m0rehud.zip", TF2Directory);
                    break;
                case 6:
                    new WebClient().DownloadFile("https://github.com/Hypnootize/m0rehud/zipball/master/", "m0rehud");
                    ZipFile.ExtractToDirectory(Application.StartupPath + "\\m0rehud.zip", TF2Directory);
                    break;
                case 7:
                    new WebClient().DownloadFile("https://github.com/Hypnootize/m0rehud/zipball/master/", "m0rehud");
                    ZipFile.ExtractToDirectory(Application.StartupPath + "\\m0rehud.zip", TF2Directory);
                    break;
                case 8:
                    new WebClient().DownloadFile("https://github.com/Hypnootize/m0rehud/zipball/master/", "m0rehud");
                    ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\m0rehud.zip", TF2Directory);
                    if (File.Exists($"{Application.StartupPath} + \\m0rehud.zip"))
                        File.Delete($"{Application.StartupPath} + \\m0rehud.zip");
                    break;
                case 9:
                    new WebClient().DownloadFile("https://github.com/Hypnootize/m0rehud/zipball/master/", "m0rehud");
                    ZipFile.ExtractToDirectory(Application.StartupPath + "\\m0rehud.zip", TF2Directory);
                    break;

                default:
                    // Do for everything else
                    break;
            }
        }

        private void Uninstall_Click(object sender, EventArgs e)
        {

        }
    }
}
