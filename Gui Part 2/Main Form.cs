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
        public Form1()
        {
            InitializeComponent();
        }


        //PUBLIC DEFFITNIONS

        public string TF2Directory { get; set; }
        //private int Disp { get; set; }
        private int Dlfin { get; set; }

        //MOVEABLE WINDOW

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private string hudzip;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }




        ///
        //EVENTS (USUALLY BUTTONS
        ///
        
            
            // (PATH BUTTON)
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

        private void hudtop_Click(object sender, EventArgs e)
        {
            hudControl1.Visible = true;
            label3.Text = "* Huds";
            hudtop.ForeColor = Color.DarkGray;
        }

        //DOWNLOAD BUTTON
        private void Download_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(2000);
            status.Text = "Installing...";
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

            status.Text = "Uninstall Successful";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            hudControl1.Visible = false;
            if (Properties.Settings.Default.SavedDirectory != "Insert")
            {
                TF2Directory = Properties.Settings.Default.SavedDirectory;
                button10.Enabled = true;
                button12.Visible = false;
                label2.Visible = false;


            }
        }



        //METHODS

        private void worker()
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();

        }



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

            if (Directory.Exists(TF2Directory + "\\Crsp Broesel"))
                Directory.Delete(TF2Directory + "\\Crsp Broesel", true);

            if (Directory.Exists(TF2Directory + "\\Deli Hud Normal"))
                Directory.Delete(TF2Directory + "\\Deli Hud Normal", true);

            if (Directory.Exists(TF2Directory + "\\Dino Hud"))
                Directory.Delete(TF2Directory + "\\Dino Hud", true);

            if (Directory.Exists(TF2Directory + "\\Egg Hud"))
                Directory.Delete(TF2Directory + "\\Egg Hud", true);

            if (Directory.Exists(TF2Directory + "\\Ells Hud"))
                Directory.Delete(TF2Directory + "\\Ells Hud", true);

            if (Directory.Exists(TF2Directory + "\\Clip Hud"))
                Directory.Delete(TF2Directory + "\\Clip Hud", true);

            if (Directory.Exists(TF2Directory + "\\Evans Hud"))
                Directory.Delete(TF2Directory + "\\Evans Hud", true);

            if (Directory.Exists(TF2Directory + "\\Evolve Hud"))
                Directory.Delete(TF2Directory + "\\Evolve Hud", true);

            if (Directory.Exists(TF2Directory + "\\Hypnotize m0rehud"))
                Directory.Delete(TF2Directory + "\\Hypnotize m0rehud", true);

            if (Directory.Exists(TF2Directory + "\\FK Hud"))
                Directory.Delete(TF2Directory + "\\FK Hud", true);

            if (Directory.Exists(TF2Directory + "\\Flame Hud"))
                Directory.Delete(TF2Directory + "\\Flame Hud", true);

            if (Directory.Exists(TF2Directory + "\\Flat Hud"))
                Directory.Delete(TF2Directory + "\\Flat Hud", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n 7MF"))
                Directory.Delete(TF2Directory + "\\Garm3n 7MF", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n 8MG"))
                Directory.Delete(TF2Directory + "\\Garm3n 8MG", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n OLX"))
                Directory.Delete(TF2Directory + "\\Garm3n OLX", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n QL EDIT"))
                Directory.Delete(TF2Directory + "\\Garm3n QL EDIT", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n QL"))
                Directory.Delete(TF2Directory + "\\Garm3n QL", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n Q-M"))
                Directory.Delete(TF2Directory + "\\Garm3n Q-M", true);

            if (Directory.Exists(TF2Directory + "\\G-Mang Hud"))
                Directory.Delete(TF2Directory + "\\G-Mang Hud", true);

        }


       
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 2: //Hypnotize
                            HudR();
                            hudzip = "HypnotizeHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/q1c8z32szcrpc43/hypnotize%20hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 3: //TFTV
                            HudR();
                            hudzip = "TFTVHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/meflcuxgsr48ibr/TFTV%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 4: //Broesel
                            HudR();
                            hudzip = "BroeselOldHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/55e5jjrwm8cehqg/Broesel%20Old.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 5://1shot
                            HudR();
                            hudzip = "1ShotHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/om28sjg4g4f80c6/1%20Shot%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 6: //ace
                            HudR();
                            hudzip = "AceHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/dakcc7pb6irh30l/Ace%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 7: //bast
                            HudR();
                            hudzip = "BastHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/z1768y1ogtqbpv6/Bast%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 8: //baz
                            HudR();
                            hudzip = "BazHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/3s5eoc2l2lbwv0f/Baz%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 9: //black
                            HudR();
                            hudzip = "BlackHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/7m0gi9w3v6mdqxa/Black%20Hud.zip?dl=1", hudzip);
                            string HudL = "BlackHud.zip";
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + HudL, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 10: //bonerjamz
                            HudR();
                            hudzip = "Bonerjamz Hud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/vsvr9s5mv4uo80x/Bonerjamz%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 11: //broesel
                            HudR();
                            hudzip = "Broesel.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/rn0ukusl3w3pqt1/Broesel%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 12: //broken hud
                            HudR();
                            hudzip = "Broken Hud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/eirvoovponeohmf/Broken%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 13: //bw hud
                            System.Threading.Thread.Sleep(3000);
                            HudR();
                            hudzip = "BW Hud Hex.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/jd7xqv0acg2oqu7/BW%20Hud%20Hex.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 14: //bx hud
                            hudzip = "Bx Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/6bj9o2hjprd6on4/BX%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            Dlfin = 8;
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 15: //Bx More
                            HudR();
                            hudzip = "bx-m0re Hud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/fcvj2dcnib8vyk8/bx-m0re%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 16: //Cb Hud
                            HudR();
                            hudzip = "CB hud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/vi9ed0dc5my9vjb/CB%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 17: //Centered Mix
                            HudR();
                            hudzip = "Centered Mix Hud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/rx0s1txzaqxn20g/Centred%20Mix%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 18: //clip hud
                            hudzip = "Clip Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/cksguy0go8mzhzb/Clip%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 19: //Crsp Broesel
                            hudzip = "Crsp Broesel.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/t6vev0o9qcr1y9w/Crsp%20Broesel.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 20: //Deli hud
                            hudzip = "Deli Hud Normal.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/nmuhhy7clgnrq3t/Deli%20Hud%20Normal.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 21: //Dino hud
                            hudzip = "Dino Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/fhfw3jwg50eegkh/Dino%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 22: //Egg hud
                            hudzip = "Egg Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/o08irz7fru7a9gs/Egg%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 23: //Ells hud
                            hudzip = "Ells Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/ku862spyi0sisio/Ells%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 24: //Evans hud
                            hudzip = "Evans Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/yzxq9jz0gocqc65/Evans%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 25: //evolve hud
                            hudzip = "Evolve Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/n3uaebv5k5407f4/Evolve%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 26: //clip hud
                            hudzip = "Hypnotize m0rehud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/4qlj2tzn030r7q8/Hypnotize%20m0rehud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 27: //FK hud
                            hudzip = "FK Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/n8ka2z5o4lwsyk9/FK%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 28: //Flame hud
                            hudzip = "Flame Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/y018c3ge17sy8ku/Flame%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 29: //Flat hud
                            hudzip = "Flat Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/e2z9xfl4dzjma46/Flat%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 30: //G-Mang hud
                            hudzip = "G-Mang Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/cs4m0y1jk1o1hzu/G-Mang%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 31: //7mf hud
                            hudzip = "Garm3n 7MF.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/ncao42r4l808qpw/Garm3n%207MF.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 32: //8mg hud
                            hudzip = "Garm3n 8MG.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/aez7jhxj6bl9fez/Garm3n%208MG.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 33: //olx hud
                            hudzip = "Garm3n OLX.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/qjr9xsivxglc2dl/Garm3n%20OLX.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 34: //q-m hud
                            hudzip = "Garm3n Q-M.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/3vrw7kb18hy62pw/Garm3n%20Q-M.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 35: //ql hud
                            hudzip = "Garm3n QL.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/094ot7qbhz13mup/Garm3n%20QL.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 36: //ql-edit hud
                            hudzip = "Garm3n QL Edit.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/8sgpi84ds7rvlbn/Garm3n%20QL%20Edit.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
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
                    if (File.Exists($"{Application.StartupPath}" + "\\Bonerjamz Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Bonerjamz Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Broesel Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Broesel Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Broken Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Broken Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\BW Hud Hex.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\BW Hud Hex.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\BX Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\BX Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\bx-m0re Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\bx-m0re Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\CB Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\CB Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Centred Mix Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Centred Mix Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Crsp Broesel.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Crsp Broesel.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Deli Hud Normal .zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Deli Hud Normal.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Dino Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Dino Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Egg Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Egg Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Ells Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Ells Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Evans Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Evans Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Evolve Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Evolve Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Hypnotize m0rehud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Hypnotize m0rehud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Flame Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Flame Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\G-Mang Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\G-Mang Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Garm3n 8MG.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Garm3n 8MG.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Garm3n OLX.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Garm3n OLX.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Garm3n Q-M.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Garm3n Q-M.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Garm3n QL Edit.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Garm3n QL Edit.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\FK Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\FK Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Flat Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Flat Hud.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Garm3n 7MF.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Garm3n 7MF.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Garm3n QL.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Garm3n QL.zip");
                    if (File.Exists($"{Application.StartupPath}" + "\\Clip Hud.zip"))
                        File.Delete($"{Application.StartupPath}" + "\\Clip Hud.zip");


                }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            status.Text = "Installation Successful";
        }

    }

}
