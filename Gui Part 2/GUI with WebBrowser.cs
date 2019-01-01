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
using System.IO;
using System.Runtime.InteropServices;

namespace Gui_Part_2
{
    public partial class Form1 : Form
    {
        public string TF2Directory { get; set; }
        //private int Disp { get; set; }
        private int Dlfin { get; set; }
        public Form1()
        {
            InitializeComponent();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private string hudzip;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Refreshes hud folder
        private void HudR()
        {
            if (Directory.Exists(TF2Directory + "\\m0rehud"))
                Directory.Delete(TF2Directory + "\\m0rehud", true);

            if (Directory.Exists(TF2Directory + "\\hypnotize hud"))
                Directory.Delete(TF2Directory + "\\hypnotize hud", true);

            if (Directory.Exists(TF2Directory + "\\TFTV Hud"))
                Directory.Delete(TF2Directory + "\\TFTV Hud", true);

            if (Directory.Exists(TF2Directory + "\\Broesel Old"))
                Directory.Delete(TF2Directory + "\\Broesel Old", true);

            if (Directory.Exists(TF2Directory + "\\1 Shot Hud"))
                Directory.Delete(TF2Directory + "\\1 Shot Hud", true);

            if (Directory.Exists(TF2Directory + "\\Ace Hud"))
                Directory.Delete(TF2Directory + "\\Ace Hud", true);

            if (Directory.Exists(TF2Directory + "\\Bast Hud"))
                Directory.Delete(TF2Directory + "\\Bast Hud", true);

            if (Directory.Exists(TF2Directory + "\\Baz Hud"))
                Directory.Delete(TF2Directory + "\\Baz Hud", true);

            if (Directory.Exists(TF2Directory + "\\Black Hud"))
                Directory.Delete(TF2Directory + "\\Black Hud", true);

            if (Directory.Exists(TF2Directory + "\\Bonerjamz Hud"))
                Directory.Delete(TF2Directory + "\\Bonerjamz Hud", true);

            if (Directory.Exists(TF2Directory + "\\Broesel Hud"))
                Directory.Delete(TF2Directory + "\\Broesel Hud", true);

            if (Directory.Exists(TF2Directory + "\\Broken Hud"))
                Directory.Delete(TF2Directory + "\\Broken Hud", true);

            if (Directory.Exists(TF2Directory + "\\BW Hud Hex"))
                Directory.Delete(TF2Directory + "\\BW Hud Hex", true);

            if (Directory.Exists(TF2Directory + "\\BX Hud"))
                Directory.Delete(TF2Directory + "\\BX Hud", true);

            if (Directory.Exists(TF2Directory + "\\bx-m0re Hud"))
                Directory.Delete(TF2Directory + "\\bx-m0re Hud", true);

            if (Directory.Exists(TF2Directory + "\\CB Hud"))
                Directory.Delete(TF2Directory + "\\CB Hud", true);

            if (Directory.Exists(TF2Directory + "\\Centered Mix Hud"))
                Directory.Delete(TF2Directory + "\\Centered Mix Hud", true);

            if (Directory.Exists(TF2Directory + "\\Clip Hud"))
                Directory.Delete(TF2Directory + "\\Clip Hud", true);
        }    

        private void TempD()
        {

        }

        public void Reset()
        {

        }




        //PATH BUTTON
        private void button12_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath.Contains("tf\\custom")) 
                {
                    
                    button10.Enabled = true;
                    TF2Directory = folderBrowserDialog1.SelectedPath;
                    Properties.Settings.Default.SavedDirectory = folderBrowserDialog1.SelectedPath;
                    Properties.Settings.Default.Save();
                    button12.Visible = false;
                    label2.Visible = false;
                }
                else
                {
                    label2.Visible = true;
                    button12.Visible = true;
                    label2.Text = "INVALID PATH TO CUSTOM FOLDER";
                    label2.ForeColor = Color.Red;
                    button10.Enabled = false;
                }
            }
        }

        //DOWNLOAD BUTTON
        private void Download_Click(object sender, EventArgs e)
        {
            try
            {
                switch (hudControl1.Disp)
                {
                    case 1: //MoreHud
                        HudR();
                        hudzip = "m0rehud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/4vl217j2klgkafv/m0rehud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 1;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 2: //Hypnotize
                        HudR();
                        hudzip = "HypnotizeHud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/q1c8z32szcrpc43/hypnotize%20hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 2;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 3: //TFTV
                        HudR();
                        hudzip = "TFTVHud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/meflcuxgsr48ibr/TFTV%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 3;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 4: //Broesel
                        HudR();
                        hudzip = "BroeselOldHud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/55e5jjrwm8cehqg/Broesel%20Old.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 4;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                        File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 5://1shot
                        HudR();
                        hudzip = "1ShotHud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/om28sjg4g4f80c6/1%20Shot%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 5;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 6: //ace
                        HudR();
                        hudzip = "AceHud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/dakcc7pb6irh30l/Ace%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 6;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 7: //bast
                        HudR();
                        hudzip = "BastHud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/z1768y1ogtqbpv6/Bast%20Hud.zip?dl=1", hudzip );
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 7;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 8: //baz
                        HudR();
                        hudzip = "BazHud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/3s5eoc2l2lbwv0f/Baz%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 8;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 9: //black
                        HudR();
                        hudzip = "BlackHud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/7m0gi9w3v6mdqxa/Black%20Hud.zip?dl=1", hudzip);
                        string HudL = "BlackHud.zip";
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + HudL, TF2Directory);
                        Dlfin = 9;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 10: //bonerjamz
                        HudR();
                        hudzip = "Bonerjamz Hud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/vsvr9s5mv4uo80x/Bonerjamz%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 8;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 11: //broesel
                        HudR();
                        hudzip = "Broesel.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/rn0ukusl3w3pqt1/Broesel%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 8;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 12: //broken hud
                        HudR();
                        hudzip = "Broken Hud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/eirvoovponeohmf/Broken%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 8;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 13: //bw hud
                        HudR();
                        hudzip = "BW Hud Hex.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/jd7xqv0acg2oqu7/BW%20Hud%20Hex.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 8;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 14: //bx hud
                        hudzip = "Bx Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/6bj9o2hjprd6on4/BX%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 8;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 15: //Bx More
                        HudR();
                        hudzip = "bx-m0re Hud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/fcvj2dcnib8vyk8/bx-m0re%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 8;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 16: //Cb Hud
                        HudR();
                        hudzip = "CB hud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/vi9ed0dc5my9vjb/CB%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 8;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 17: //Centered Mix
                        HudR();
                        hudzip = "Centered Mix Hud.zip";
                        new WebClient().DownloadFile("https://www.dropbox.com/s/rx0s1txzaqxn20g/Centred%20Mix%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 8;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;
                    case 18: //clip hud
                        hudzip = "Clip Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/cksguy0go8mzhzb/Clip%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        Dlfin = 8;
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        sucess.Visible = true;
                        break;

                    default:
                        // Nothing
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Properties.Settings.Default.ErrorInstall}\n{ex.Message}", "You installed the hud twice, go into your custom folder and delte the huds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (File.Exists($"{Application.StartupPath}" + "\\BlackHud.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\BlackHud.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\BazHud.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\BazHud.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\BastHud.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\BastHud.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\AceHud.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\AceHud.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\1ShotHud.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\1ShotHud.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\BroeselOldHud.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\BroeselOldHud.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\TFTVHud.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\TFTVHud.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\HypnotizeHud.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\HypnotizeHud.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\m0rehud.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\m0rehud.zip");
            }

            }

        private void Uninstall_click(object sender, EventArgs e)
        {
            try
            {
                HudR();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Properties.Settings.Default.ErrorInstall}\n{ex.Message}", "Error Uninstalling Huds", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SavedDirectory != "Insert")
            {
                TF2Directory = Properties.Settings.Default.SavedDirectory;
                button10.Enabled = true;
                button12.Visible = false;
                label2.Visible = false;
                hudControl1.Visible = false;

            }
        }
        //Windows Buttons
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Options_Click(object sender, EventArgs e)
        {

        }
        private void panel1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void hudtop_Click(object sender, EventArgs e)
        {
            hudControl1.Visible = true;
            label3.Text = "* Huds";
            hudtop.ForeColor = Color.DarkGray;
        }
    }
}
