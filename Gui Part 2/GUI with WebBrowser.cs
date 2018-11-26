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
        private int Uninst { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        //MOREHUD BUTTON 1
        private void more_Click(object sender, EventArgs e)
        {

            string web = "https://imgur.com/a/sxOyM";

            webBrowser1.Navigate(web);
            Disp = 1;
        }

        //HYPNOTIZE 
        public void hypnotize_Click(object sender, EventArgs e)
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
        private void Download_Click(object sender, EventArgs e)
        {

            switch (Disp)
            {
                case 1: //MoreHud
                    new WebClient().DownloadFile("https://www.dropbox.com/s/4vl217j2klgkafv/m0rehud.zip?dl=1", "m0rehud.zip");
                    ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\m0rehud.zip", TF2Directory);
                    Uninst = 1;
                    if (File.Exists($"{Application.StartupPath}" + "\\m0rehud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\m0rehud.zip");
                    break;
                case 2: //Hypnotize
                    new WebClient().DownloadFile("https://www.dropbox.com/s/q1c8z32szcrpc43/hypnotize%20hud.zip?dl=1", "HypnotizeHud.zip");
                    ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\HypnotizeHud.zip", TF2Directory);
                    Uninst = 2;
                    if (File.Exists($"{Application.StartupPath}" + "\\HypnotizeHud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\HypnotizeHud.zip");
                    break;
                case 3: //TFTV
                    new WebClient().DownloadFile("https://www.dropbox.com/s/meflcuxgsr48ibr/TFTV%20Hud.zip?dl=1", "TFTVHud.zip");
                    ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\TFTVHud.zip", TF2Directory);
                    Uninst = 3;
                    if (File.Exists($"{Application.StartupPath}" + "\\TFTVHud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\TFTVHud.zip");
                    break;
                case 4: //Broesel
                    new WebClient().DownloadFile("https://www.dropbox.com/s/55e5jjrwm8cehqg/Broesel%20Old.zip?dl=1", "BroeselOldHud.zip");
                    ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\BroeselOldHud.zip", TF2Directory);
                    Uninst = 4;
                    if (File.Exists($"{Application.StartupPath}" + "\\BroeselOldHud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\BroeselOldHud.zip");
                    break;
                case 5://1shot
                    new WebClient().DownloadFile("https://www.dropbox.com/s/om28sjg4g4f80c6/1%20Shot%20Hud.zip?dl=1", "1ShotHud.zip");
                    ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\1ShotHud.zip", TF2Directory);
                    Uninst = 5;
                    if (File.Exists($"{Application.StartupPath}" + "\\1ShotHud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\1ShotHud.zip");
                    break;
                case 6: //ace
                    new WebClient().DownloadFile("https://www.dropbox.com/s/dakcc7pb6irh30l/Ace%20Hud.zip?dl=1", "AceHud.zip");
                    ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\AceHud.zip", TF2Directory);
                    Uninst = 6;
                    if (File.Exists($"{Application.StartupPath}" + "\\AceHud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\AceHud.zip");
                    break;
                case 7: //bast
                    new WebClient().DownloadFile("https://www.dropbox.com/s/z1768y1ogtqbpv6/Bast%20Hud.zip?dl=1", "BastHud.zip");
                    ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\BastHud.zip", TF2Directory);
                    Uninst = 7;
                    if (File.Exists($"{Application.StartupPath}" + "\\BastHud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\BastHud.zip");
                    break;
                case 8: //baz
                    new WebClient().DownloadFile("https://www.dropbox.com/s/3s5eoc2l2lbwv0f/Baz%20Hud.zip?dl=1", "BazHud.zip");
                    ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\BazHud.zip", TF2Directory);
                    Uninst = 8;
                    if (File.Exists($"{Application.StartupPath}" + "\\BazHud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\BazHud.zip");
                    break;
                case 9: //black
                    new WebClient().DownloadFile("https://www.dropbox.com/s/7m0gi9w3v6mdqxa/Black%20Hud.zip?dl=1", "BlackHud.zip");
                    ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\BlackHud.zip", TF2Directory);
                    Uninst = 9;
                    if (File.Exists($"{Application.StartupPath}" + "\\BlackHud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\BlackHud.zip");
                    break;



                default:
                    // ayo
                    break;
            }
        }

        private void Uninstall_click(object sender, EventArgs e)
        {

        }
    }
}
