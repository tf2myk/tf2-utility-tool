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
using Microsoft.WindowsAPICodePack.Dialogs;

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

        CommonOpenFileDialog dialog = new CommonOpenFileDialog();


        private void button12_Click(object sender, EventArgs e)
        {
            
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (dialog.FileName.Contains("tf\\custom"))
                {
                    button10.Enabled = true;
                    Uninstall.Enabled = true;
                    hudtop.Visible = true;
                    crosshairstop.Visible = true;
                    extrastop.Visible = true;
                    TF2Directory = dialog.FileName;
                    Properties.Settings.Default.SavedDirectory = dialog.FileName;
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
                    hudControl1.Visible = false;
                    hudtop.Visible = false;
                    crosshairstop.Visible = false;
                    extrastop.Visible = false;
                    Uninstall.Enabled = false;
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
            System.Diagnostics.Process.Start(TF2Directory);
        }

        private void hudtop_Click(object sender, EventArgs e)
        {
            hudControl1.Visible = true;
            crosshairControl1.Visible = false;
            label3.Text = "* Huds";
            hudtop.ForeColor = Color.DarkGray;
            crosshairstop.ForeColor = Color.White;
        }

        //DOWNLOAD BUTTON
        private void Download_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(2000);
            button10.Enabled = false;
            Uninstall.Enabled = false;
            status.Text = "Installing...";
        }

        private void Uninstall_click(object sender, EventArgs e)
        {
            try
            {
            backgroundWorker2.RunWorkerAsync(2000);
            button10.Enabled = false;
            Uninstall.Enabled = false;
            status.Text = "Uninstalling...";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Properties.Settings.Default.ErrorInstall}\n{ex.Message}", "Error Uninstalling Huds", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Set Path TF/Custom Folder";
            hudControl1.Visible = false;
            button10.Enabled = false;
            hudControl1.Visible = false;
            hudtop.Visible = false;
            crosshairstop.Visible = false;
            extrastop.Visible = false;
            Uninstall.Enabled = false;
            crosshairControl1.Visible = false;
            if (Properties.Settings.Default.SavedDirectory != "Insert")
            {
                TF2Directory = Properties.Settings.Default.SavedDirectory;
                button10.Enabled = true;
                button12.Visible = false;
                label2.Visible = false;
                Uninstall.Enabled = true;
                hudtop.Visible = true;
                crosshairstop.Visible = true;
                extrastop.Visible = true;


            }
        }



        //METHODS

        private void worker()
        {

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

            if (Directory.Exists(TF2Directory + "\\Garm3n R-B"))
                Directory.Delete(TF2Directory + "\\Garm3n R-B", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n REX"))
                Directory.Delete(TF2Directory + "\\Garm3n REX", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n SDX 2013"))
                Directory.Delete(TF2Directory + "\\Garm3n SDX 2013", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n TanLight"))
                Directory.Delete(TF2Directory + "\\Garm3n TanLight", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n TCF-XL"))
                Directory.Delete(TF2Directory + "\\Garm3n TCF-XL", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n VIP Beavern"))
                Directory.Delete(TF2Directory + "\\Garm3n VIP Beavern", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n VIP Konr"))
                Directory.Delete(TF2Directory + "\\Garm3n VIP Konr", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n VIP Quad"))
                Directory.Delete(TF2Directory + "\\Garm3n VIP Quad", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n VIP Stefan"))
                Directory.Delete(TF2Directory + "\\Garm3n VIP Stefan", true);

            if (Directory.Exists(TF2Directory + "\\GeaR Hud"))
                Directory.Delete(TF2Directory + "\\Gear Hud", true);

            if (Directory.Exists(TF2Directory + "\\Goat Hud"))
                Directory.Delete(TF2Directory + "\\Goat Hud", true);

            if (Directory.Exists(TF2Directory + "\\Grape Default Hud"))
                Directory.Delete(TF2Directory + "\\Grape Default Hud", true);

            if (Directory.Exists(TF2Directory + "\\Grape Hud"))
                Directory.Delete(TF2Directory + "\\Grape Hud", true);

            if (Directory.Exists(TF2Directory + "\\Grape knm0re"))
                Directory.Delete(TF2Directory + "\\Grape knm0re", true);

            if (Directory.Exists(TF2Directory + "\\grape m0rehud"))
                Directory.Delete(TF2Directory + "\\grape m0rehud", true);

            if (Directory.Exists(TF2Directory + "\\Grape Oxide"))
                Directory.Delete(TF2Directory + "\\Grape Oxide", true);

            if (Directory.Exists(TF2Directory + "\\Helvetica Hud"))
                Directory.Delete(TF2Directory + "\\Helvetica Hud", true);

            if (Directory.Exists(TF2Directory + "\\Evans Hud"))
                Directory.Delete(TF2Directory + "\\Evans Hud", true);

            if (Directory.Exists(TF2Directory + "\\Jishin Hud"))
                Directory.Delete(TF2Directory + "\\Jishin Hud", true);

            if (Directory.Exists(TF2Directory + "\\Julias Hud"))
                Directory.Delete(TF2Directory + "\\Julias Hud", true);

            if (Directory.Exists(TF2Directory + "\\kA_Hud"))
                Directory.Delete(TF2Directory + "\\ka_Hud", true);

            if (Directory.Exists(TF2Directory + "\\Kered Hud"))
                Directory.Delete(TF2Directory + "\\Kered Hud", true);

            if (Directory.Exists(TF2Directory + "\\KN Edit"))
                Directory.Delete(TF2Directory + "\\KN Edit", true);

            if (Directory.Exists(TF2Directory + "\\KN Hud Old"))
                Directory.Delete(TF2Directory + "\\KN Hud Old", true);

            if (Directory.Exists(TF2Directory + "\\KN Hud"))
                Directory.Delete(TF2Directory + "\\KN Hud", true);

            if (Directory.Exists(TF2Directory + "\\Lansky Oxide"))
                Directory.Delete(TF2Directory + "\\Lansky Oxide", true);

            if (Directory.Exists(TF2Directory + "\\m0re Old"))
                Directory.Delete(TF2Directory + "\\m0re Old", true);

            if (Directory.Exists(TF2Directory + "\\m0re Quake"))
                Directory.Delete(TF2Directory + "\\m0re Quake", true);

            if (Directory.Exists(TF2Directory + "\\m0rehud Black 2.0"))
                Directory.Delete(TF2Directory + "\\m0rehud Black 2.0", true);

            if (Directory.Exists(TF2Directory + "\\m0rehud Black"))
                Directory.Delete(TF2Directory + "\\m0rehud Black", true);

            if (Directory.Exists(TF2Directory + "\\Material Hud"))
                Directory.Delete(TF2Directory + "\\Material Hud", true);

            if (Directory.Exists(TF2Directory + "\\medHUD"))
                Directory.Delete(TF2Directory + "\\medHUD", true);

            if (Directory.Exists(TF2Directory + "\\Metro Hud"))
                Directory.Delete(TF2Directory + "\\Metro Hud", true);

            if (Directory.Exists(TF2Directory + "\\Milky Hud"))
                Directory.Delete(TF2Directory + "\\Milky Hud", true);

            if (Directory.Exists(TF2Directory + "\\MN-Hud-master"))
                Directory.Delete(TF2Directory + "\\MN-Hud-master", true);

            if (Directory.Exists(TF2Directory + "\\Noto-KN Hud"))
                Directory.Delete(TF2Directory + "\\Noto-KN Hud", true);

            if (Directory.Exists(TF2Directory + "\\Hudas Iscariote"))
                Directory.Delete(TF2Directory + "\\Hudas Iscariote", true);

            if (Directory.Exists(TF2Directory + "\\Omp Hud Redux"))
                Directory.Delete(TF2Directory + "\\Omp Hud Redux", true);

            if (Directory.Exists(TF2Directory + "\\Omp Hud"))
                Directory.Delete(TF2Directory + "\\Omp Hud", true);

            if (Directory.Exists(TF2Directory + "\\Orbiculatus Hud"))
                Directory.Delete(TF2Directory + "\\Orbiculatus Hud", true);

            if (Directory.Exists(TF2Directory + "\\OTL Hud"))
                Directory.Delete(TF2Directory + "\\OTL Hud", true);

            if (Directory.Exists(TF2Directory + "\\Oxide Hud"))
                Directory.Delete(TF2Directory + "\\Oxide Hud", true);

            if (Directory.Exists(TF2Directory + "\\Prism Hud"))
                Directory.Delete(TF2Directory + "\\Prism Hud", true);

            if (Directory.Exists(TF2Directory + "\\Product Hud"))
                Directory.Delete(TF2Directory + "\\Product Hud", true);

            if (Directory.Exists(TF2Directory + "\\PV Hud"))
                Directory.Delete(TF2Directory + "\\PV Hud", true);

            if (Directory.Exists(TF2Directory + "\\QTC Hud"))
                Directory.Delete(TF2Directory + "\\QTC Hud", true);

            if (Directory.Exists(TF2Directory + "\\Rads Hud"))
                Directory.Delete(TF2Directory + "\\Rads Hud", true);

            if (Directory.Exists(TF2Directory + "\\Rain Hud"))
                Directory.Delete(TF2Directory + "\\Rain Hud", true);

            if (Directory.Exists(TF2Directory + "\\Rev Hud"))
                Directory.Delete(TF2Directory + "\\Rev Hud", true);

            if (Directory.Exists(TF2Directory + "\\Reverto Hud"))
                Directory.Delete(TF2Directory + "\\Reverto Hud", true);

            if (Directory.Exists(TF2Directory + "\\rhB Hud"))
                Directory.Delete(TF2Directory + "\\rhB Hud", true);

            if (Directory.Exists(TF2Directory + "\\Roboto Hud"))
                Directory.Delete(TF2Directory + "\\Roboto Hud", true);

            if (Directory.Exists(TF2Directory + "\\Shlaner Hud"))
                Directory.Delete(TF2Directory + "\\Shlaner Hud", true);

            if (Directory.Exists(TF2Directory + "\\SK Hud"))
                Directory.Delete(TF2Directory + "\\SK Hud", true);

            if (Directory.Exists(TF2Directory + "\\Slay Hud"))
                Directory.Delete(TF2Directory + "\\Slay Hud", true);

            if (Directory.Exists(TF2Directory + "\\Soft Hud"))
                Directory.Delete(TF2Directory + "\\Soft Hud", true);

            if (Directory.Exists(TF2Directory + "\\Solano Hud"))
                Directory.Delete(TF2Directory + "\\Solano Hud", true);

            if (Directory.Exists(TF2Directory + "\\TF2Hud+ Old"))
                Directory.Delete(TF2Directory + "\\TF2Hud+ Old", true);

            if (Directory.Exists(TF2Directory + "\\Thwartzki Hud"))
                Directory.Delete(TF2Directory + "\\Thwartzki Hud", true);

            if (Directory.Exists(TF2Directory + "\\Toasty Hud"))
                Directory.Delete(TF2Directory + "\\Toasty Hud", true);

            if (Directory.Exists(TF2Directory + "\\Topsh_it-Hud-master"))
                Directory.Delete(TF2Directory + "\\Topsh_it-Hud-master", true);

            if (Directory.Exists(TF2Directory + "\\Tresh Hud"))
                Directory.Delete(TF2Directory + "\\Tresh Hud", true);

            if (Directory.Exists(TF2Directory + "\\Vabe Hud"))
                Directory.Delete(TF2Directory + "\\Vabe Hud", true);

            if (Directory.Exists(TF2Directory + "\\Wavesui"))
                Directory.Delete(TF2Directory + "\\Wavesui", true);

            if (Directory.Exists(TF2Directory + "\\X Hud"))
                Directory.Delete(TF2Directory + "\\X Hud", true);

            if (Directory.Exists(TF2Directory + "\\Yahud 5MD"))
                Directory.Delete(TF2Directory + "\\Yahud 5MD", true);

            if (Directory.Exists(TF2Directory + "\\Yahud Black"))
                Directory.Delete(TF2Directory + "\\Slay Hud", true);

            if (Directory.Exists(TF2Directory + "\\Yahud 5MD"))
                Directory.Delete(TF2Directory + "\\Yahud 5MD", true);

            if (Directory.Exists(TF2Directory + "\\Yahud CMYK"))
                Directory.Delete(TF2Directory + "\\Yahud CMYK", true);

            if (Directory.Exists(TF2Directory + "\\Yahud CX"))
                Directory.Delete(TF2Directory + "\\Yahud CX", true);

            if (Directory.Exists(TF2Directory + "\\Yahud FL"))
                Directory.Delete(TF2Directory + "\\Yahud FL", true);

            if (Directory.Exists(TF2Directory + "\\Yahud M-X"))
                Directory.Delete(TF2Directory + "\\Yahud M-X", true);

            if (Directory.Exists(TF2Directory + "\\Yahud Old"))
                Directory.Delete(TF2Directory + "\\Yahud Old", true);

            if (Directory.Exists(TF2Directory + "\\yayahud"))
                Directory.Delete(TF2Directory + "\\yayahud", true);

            if (Directory.Exists(TF2Directory + "\\Z Hud"))
                Directory.Delete(TF2Directory + "\\Z Hud", true);

            if (Directory.Exists(TF2Directory + "\\Zim Hud"))
                Directory.Delete(TF2Directory + "\\Zim Hud", true);

            if (Directory.Exists(TF2Directory + "\\Zoub Hud"))
                Directory.Delete(TF2Directory + "\\Zoub Hud", true);
        }


       
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                try
                {
                    switch (hudControl1.Disp)
                    {
                        case 1: 
                            HudR();
                            hudzip = "m0rehud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/4vl217j2klgkafv/m0rehud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        case 2: 
                            HudR();
                            hudzip = "HypnotizeHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/q1c8z32szcrpc43/hypnotize%20hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 3: 
                            HudR();
                            hudzip = "TFTVHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/meflcuxgsr48ibr/TFTV%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 4: 
                            HudR();
                            hudzip = "BroeselOldHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/55e5jjrwm8cehqg/Broesel%20Old.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 5:
                            HudR();
                            hudzip = "1ShotHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/om28sjg4g4f80c6/1%20Shot%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 6: 
                            HudR();
                            hudzip = "AceHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/dakcc7pb6irh30l/Ace%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 7: 
                            HudR();
                            hudzip = "BastHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/z1768y1ogtqbpv6/Bast%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 8: 
                            HudR();
                            hudzip = "BazHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/3s5eoc2l2lbwv0f/Baz%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 9: 
                            HudR();
                            hudzip = "BlackHud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/7m0gi9w3v6mdqxa/Black%20Hud.zip?dl=1", hudzip);
                            string HudL = "BlackHud.zip";
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + HudL, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 10: 
                            HudR();
                            hudzip = "Bonerjamz Hud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/vsvr9s5mv4uo80x/Bonerjamz%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 11: 
                            HudR();
                            hudzip = "Broesel.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/rn0ukusl3w3pqt1/Broesel%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 12: 
                            HudR();
                            hudzip = "Broken Hud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/eirvoovponeohmf/Broken%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 13: 
                            System.Threading.Thread.Sleep(3000);
                            HudR();
                            hudzip = "BW Hud Hex.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/jd7xqv0acg2oqu7/BW%20Hud%20Hex.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 14: 
                            hudzip = "Bx Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/6bj9o2hjprd6on4/BX%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            Dlfin = 8;
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 15: 
                            HudR();
                            hudzip = "bx-m0re Hud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/fcvj2dcnib8vyk8/bx-m0re%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 16: 
                            HudR();
                            hudzip = "CB hud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/vi9ed0dc5my9vjb/CB%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 17: 
                            HudR();
                            hudzip = "Centered Mix Hud.zip";
                            new WebClient().DownloadFile("https://www.dropbox.com/s/rx0s1txzaqxn20g/Centred%20Mix%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 18: 
                            hudzip = "Clip Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/cksguy0go8mzhzb/Clip%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 19: 
                            hudzip = "Crsp Broesel.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/t6vev0o9qcr1y9w/Crsp%20Broesel.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 20: 
                            hudzip = "Deli Hud Normal.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/nmuhhy7clgnrq3t/Deli%20Hud%20Normal.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 21: 
                            hudzip = "Dino Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/fhfw3jwg50eegkh/Dino%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 22: 
                            hudzip = "Egg Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/o08irz7fru7a9gs/Egg%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 23: 
                            hudzip = "Ells Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/ku862spyi0sisio/Ells%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 24: 
                            hudzip = "Evans Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/yzxq9jz0gocqc65/Evans%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 25: 
                            hudzip = "Evolve Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/n3uaebv5k5407f4/Evolve%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 26: 
                            hudzip = "Hypnotize m0rehud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/4qlj2tzn030r7q8/Hypnotize%20m0rehud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 27: 
                            hudzip = "FK Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/n8ka2z5o4lwsyk9/FK%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 28: 
                            hudzip = "Flame Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/y018c3ge17sy8ku/Flame%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 29: 
                            hudzip = "Flat Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/e2z9xfl4dzjma46/Flat%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 30: 
                            hudzip = "G-Mang Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/cs4m0y1jk1o1hzu/G-Mang%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 31: 
                            hudzip = "Garm3n 7MF.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/ncao42r4l808qpw/Garm3n%207MF.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 32: 
                            hudzip = "Garm3n 8MG.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/aez7jhxj6bl9fez/Garm3n%208MG.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 33: 
                            hudzip = "Garm3n OLX.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/qjr9xsivxglc2dl/Garm3n%20OLX.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 34:
                            hudzip = "Garm3n Q-M.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/3vrw7kb18hy62pw/Garm3n%20Q-M.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 35: 
                            hudzip = "Garm3n QL.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/094ot7qbhz13mup/Garm3n%20QL.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 36: 
                            hudzip = "Garm3n QL Edit.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/8sgpi84ds7rvlbn/Garm3n%20QL%20Edit.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        case 37: 
                            hudzip = "Garm3n R-B.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/qu7n84r9kb936bb/Garm3n%20R-B.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 38: 
                            hudzip = "Garm3n REX.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/koatakxfj0f1rkq/Garm3n%20REX.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 39: 
                            hudzip = "Garm3n SDX 2013.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/i76239vqzj8r67i/Garm3n%20SDX%202013.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 40: 
                            hudzip = "Garm3n Tanlight.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/0k6ws5qpk864z6x/Garm3n%20TanLight.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        case 41: 
                            hudzip = "Garm3n TCF-XL.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/3l0obq42zlwkk4q/Garm3n%20TCF-XL.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        case 42: 
                            hudzip = "Garm3n VIP Beavern.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/awzhiwgqnu5pzah/Garm3n%20VIP%20Beavern.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        case 43: 
                            hudzip = "Garm3n VIP Konr.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/lq1m2xxsubj9tx0/Garm3n%20VIP%20Konr.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        case 44: 
                            hudzip = "Garm3n VIP Quad.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/jc556afwz80lpch/Garm3n%20VIP%20Quad.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        case 45: 
                            hudzip = "Garm3n VIP Stefan.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/cngxugpdnug42zc/Garm3n%20VIP%20Stefan.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        case 46: 
                            hudzip = "Gear Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/m3lg4ea4dwwwq3x/GeaR%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        case 47: 
                            hudzip = "Goat Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/1wseocfz3v82w72/Goat%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        case 48: 
                            hudzip = "Grape Default Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/lznxl69ujfvc8go/Grape%20Default%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        case 49: 
                            hudzip = "Grape Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/34ytxs45buh5pd4/Grape%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        
                        case 50: 
                            hudzip = "Grape knm0re.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/leyx1i2m2tqehmw/Grape%20knm0re.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        
                        case 51: 
                            hudzip = "Grape m0rehud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/iqgtjj7gxygb0to/Grape%20m0rehud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        
                        case 52: 
                            hudzip = "Grape Oxide.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/5876fhemb0vjrqd/Grape%20Oxide.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        
                        case 53: 
                            hudzip = "Helvetica Hud.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/zwn1lk243z9o8z2/Helvetica%20Hud.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;

                        
                        case 54: 
                            hudzip = "Hudas Iscariote.zip";
                            HudR();
                            new WebClient().DownloadFile("https://www.dropbox.com/s/pe9z4wlvbqenuqy/Hudas%20Iscariote.zip?dl=1", hudzip);
                            ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                            if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                                File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                            worker();
                            break;
                        default:
                            // Nothing
                            break;

                    case 55:
                        hudzip = "Jishin Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/w4ijxwtm7tce36g/Jishin%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 56:
                        hudzip = "Julias Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/kpa8mktp7ur5h2l/Julias%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 57:
                        hudzip = "kA_Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/ezj5ag35mkn71nv/kA_Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 58:
                        hudzip = "Kered Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/zc3b9k06xkh0f9o/Kered%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 59:
                        hudzip = "KN Edit.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/wgcuqalgfrnyggz/KN%20Edit.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 60:
                        hudzip = "KN Hud Old.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/5lnks021wc10h1o/KN%20Hud%20Old.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 61:
                        hudzip = "KN Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/9pc5fv2cht6tx3p/KN%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 62:
                        hudzip = "Lanskys Oxide.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/g2dsq3y7xfwvns8/Lansky%20Oxide.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 63:
                        hudzip = "m0re old.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/axikpjiwu9qll64/m0re%20Old.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 64:
                        hudzip = "m0re Quake.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/z0vs0alvww11bgg/m0re%20Quake.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 65:
                        hudzip = "m0rehouse Black 2.0.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/nyurpmnsnbz1zhw/m0rehud%20Black%202.0.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 66:
                        hudzip = "m0rehud Black.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/8ukzcfyg0jp1280/m0rehud%20Black.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 67:
                        hudzip = "Material Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/6xeml6c1scar67f/Material%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 68:
                        hudzip = "medHUD.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/ij5uf7ewmpthzvz/medHUD.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 69:
                        hudzip = "Metro Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/l125352tfual88d/Metro%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 70:
                        hudzip = "Milky Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/zwn1lk243z9o8z2/Helvetica%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 71:
                        hudzip = "MN-Hud-master.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/mv29s7g2kzsgltj/MN-Hud-master.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 72:
                        hudzip = "Noto-KN Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/nphrpwimt48h7ba/Noto-KN%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 73:
                        hudzip = "OMP Hud Redux.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/q2xgbewpri8djs8/OMP%20Hud%20Redux.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 74:
                        hudzip = "OMP Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/oo5eceomeb0imdc/OMP%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 75:
                        hudzip = "Orbiculatus Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/olfc8nd7u4br9qb/Orbiculatus%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 76:
                        hudzip = "OTL Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/zjc843f0t7kbaqi/OTL%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 77:
                        hudzip = "Oxide Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/i60s79urchsrg8q/Oxide%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 78:
                        hudzip = "Prism Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/donujxfm22ajczm/Prism%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 79:
                        hudzip = "Product Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/1pgg9l89wruwbmd/Product%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 80:
                        hudzip = "PV Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/nnajyw11en8enjh/PV%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 81:
                        hudzip = "QTC Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/un6m38kt8d4bz2q/QTC%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 82:
                        hudzip = "Rads Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/s20i9gvjqy45j5s/Rads%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 83:
                        hudzip = "Rain Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/1da2ytxkav1cc2x/Rain%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 84:
                        hudzip = "Rev Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/zzne9aft4u1z0wv/Rev%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 85:
                        hudzip = "Reverto Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/filpjbdmfa94c5f/Reverto%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 86:
                        hudzip = "rHB Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/gq89l08xgic297a/rhB%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 87:
                        hudzip = "Roboto Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/rs7uk4s8dk5gkx4/Roboto%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 88:
                        hudzip = "Shlaner Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/kbw5jeu2scevda4/Shlaner%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 89:
                        hudzip = "SK Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/o20k8fejc7s2f86/SK%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;
                    case 90:
                        hudzip = "Slay Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/9alkewjgli9lzg6/Slay%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 91:
                        hudzip = "Soft Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/3q9emd68pitjjlk/Soft%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 92:
                        hudzip = "Solano Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/6ty5q6c145ntmn8/Solano%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 93:
                        hudzip = "TF2Hud+ Old.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/ycr0x3u7blcg5li/TF2Hud%2B%20Old.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 94:
                        hudzip = "Thwartzki Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/mf7rdqeg4pktpqs/Thwartzki%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 95:
                        hudzip = "Toasty Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/lsbjb5nibfe39ih/Toasty%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 96:
                        hudzip = "Topsh_it-Hud-master.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/rzfjkki9we451ab/Topsh_it-Hud-master.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 97:
                        hudzip = "Tresh Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/j4ahc8pn3krdsxo/Tresh%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 98:
                        hudzip = "Vabe Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/gjzcvwr34efhni9/Vabe%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 99:
                        hudzip = "Wavesui Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/13ttctj3h9vwgp5/Wavesui%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 100:
                        hudzip = "X Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/nqzvwbhuj08as52/X%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 101:
                        hudzip = "Yahud 5MD.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/9alkewjgli9lzg6/Slay%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 102:
                        hudzip = "Yahud Black.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/9alkewjgli9lzg6/Slay%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 103:
                        hudzip = "Yahud CMYK.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/9alkewjgli9lzg6/Slay%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 104:
                        hudzip = "Yahud CX.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/9alkewjgli9lzg6/Slay%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 105:
                        hudzip = "YaHud FL.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/9alkewjgli9lzg6/Slay%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 106:
                        hudzip = "Yahud M-X.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/9alkewjgli9lzg6/Slay%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 107:
                        hudzip = "Yahud Old.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/9alkewjgli9lzg6/Slay%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 108:
                        hudzip = "yayahud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/9alkewjgli9lzg6/Slay%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 109:
                        hudzip = "Z Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/rl48ccd3srhf2hp/Z%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 110:
                        hudzip = "Zim Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/vw5kf4gsu1eiyd2/Zim%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                    case 111:
                        hudzip = "Zoub Hud.zip";
                        HudR();
                        new WebClient().DownloadFile("https://www.dropbox.com/s/js5hddrhw03wpy7/Zoub%20Hud.zip?dl=1", hudzip);
                        ZipFile.ExtractToDirectory($"{Application.StartupPath}" + "\\" + hudzip, TF2Directory);
                        if (File.Exists($"{Application.StartupPath}" + "\\" + hudzip))
                            File.Delete($"{Application.StartupPath}" + "\\" + hudzip);
                        worker();
                        break;

                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{Properties.Settings.Default.ErrorInstall}\n{ex.Message}", "Error installing the thingy check your custom folder and delete stuff", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (File.Exists($"{Application.StartupPath}" + "\\Garm3n R-B.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\Garm3n R-B.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\Garm3n REX.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\Garm3n REX.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\Garm3n SDX 2013.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\Garm3n SDX 2013.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\Garm3n TanLight.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\Garm3n TanLight.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\Garm3n TCF-XL.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\Garm3n TCF-XL.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\Garm3n VIP Beavern.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\Garm3n VIP Beavern.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\Garm3n VIP Konr.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\Garm3n VIP Konr.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\Garm3n VIP Quad.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\Garm3n VIP Quad.zip");
                if (File.Exists($"{Application.StartupPath}" + "\\Garm3n VIP Stefan.zip"))
                    File.Delete($"{Application.StartupPath}" + "\\Garm3n VIP Stefan.zip");





                }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            status.Text = "Installation Successful";
            button10.Enabled = true;
            Uninstall.Enabled = true;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
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

            if (Directory.Exists(TF2Directory + "\\Garm3n R-B"))
                Directory.Delete(TF2Directory + "\\Garm3n R-B", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n REX"))
                Directory.Delete(TF2Directory + "\\Garm3n REX", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n SDX 2013"))
                Directory.Delete(TF2Directory + "\\Garm3n SDX 2013", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n TanLight"))
                Directory.Delete(TF2Directory + "\\Garm3n TanLight", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n TCF-XL"))
                Directory.Delete(TF2Directory + "\\Garm3n TCF-XL", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n VIP Beavern"))
                Directory.Delete(TF2Directory + "\\Garm3n VIP Beavern", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n VIP Konr"))
                Directory.Delete(TF2Directory + "\\Garm3n VIP Konr", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n VIP Quad"))
                Directory.Delete(TF2Directory + "\\Garm3n VIP Quad", true);

            if (Directory.Exists(TF2Directory + "\\Garm3n VIP Stefan"))
                Directory.Delete(TF2Directory + "\\Garm3n VIP Stefan", true);

            if (Directory.Exists(TF2Directory + "\\GeaR Hud"))
                Directory.Delete(TF2Directory + "\\Gear Hud", true);

            if (Directory.Exists(TF2Directory + "\\Goat Hud"))
                Directory.Delete(TF2Directory + "\\Goat Hud", true);

            if (Directory.Exists(TF2Directory + "\\Grape Default Hud"))
                Directory.Delete(TF2Directory + "\\Grape Default Hud", true);

            if (Directory.Exists(TF2Directory + "\\Grape Hud"))
                Directory.Delete(TF2Directory + "\\Grape Hud", true);

            if (Directory.Exists(TF2Directory + "\\Grape knm0re"))
                Directory.Delete(TF2Directory + "\\Grape knm0re", true);

            if (Directory.Exists(TF2Directory + "\\grape m0rehud"))
                Directory.Delete(TF2Directory + "\\grape m0rehud", true);

            if (Directory.Exists(TF2Directory + "\\Grape Oxide"))
                Directory.Delete(TF2Directory + "\\Grape Oxide", true);

            if (Directory.Exists(TF2Directory + "\\Helvetica Hud"))
                Directory.Delete(TF2Directory + "\\Helvetica Hud", true);

            if (Directory.Exists(TF2Directory + "\\Evans Hud"))
                Directory.Delete(TF2Directory + "\\Evans Hud", true);

            if (Directory.Exists(TF2Directory + "\\Jishin Hud"))
                Directory.Delete(TF2Directory + "\\Jishin Hud", true);

            if (Directory.Exists(TF2Directory + "\\Julias Hud"))
                Directory.Delete(TF2Directory + "\\Julias Hud", true);

            if (Directory.Exists(TF2Directory + "\\kA_Hud"))
                Directory.Delete(TF2Directory + "\\ka_Hud", true);

            if (Directory.Exists(TF2Directory + "\\Kered Hud"))
                Directory.Delete(TF2Directory + "\\Kered Hud", true);

            if (Directory.Exists(TF2Directory + "\\KN Edit"))
                Directory.Delete(TF2Directory + "\\KN Edit", true);

            if (Directory.Exists(TF2Directory + "\\KN Hud Old"))
                Directory.Delete(TF2Directory + "\\KN Hud Old", true);

            if (Directory.Exists(TF2Directory + "\\KN Hud"))
                Directory.Delete(TF2Directory + "\\KN Hud", true);

            if (Directory.Exists(TF2Directory + "\\Lansky Oxide"))
                Directory.Delete(TF2Directory + "\\Lansky Oxide", true);

            if (Directory.Exists(TF2Directory + "\\m0re Old"))
                Directory.Delete(TF2Directory + "\\m0re Old", true);

            if (Directory.Exists(TF2Directory + "\\m0re Quake"))
                Directory.Delete(TF2Directory + "\\m0re Quake", true);

            if (Directory.Exists(TF2Directory + "\\m0rehud Black 2.0"))
                Directory.Delete(TF2Directory + "\\m0rehud Black 2.0", true);

            if (Directory.Exists(TF2Directory + "\\m0rehud Black"))
                Directory.Delete(TF2Directory + "\\m0rehud Black", true);

            if (Directory.Exists(TF2Directory + "\\Material Hud"))
                Directory.Delete(TF2Directory + "\\Material Hud", true);

            if (Directory.Exists(TF2Directory + "\\medHUD"))
                Directory.Delete(TF2Directory + "\\medHUD", true);

            if (Directory.Exists(TF2Directory + "\\Metro Hud"))
                Directory.Delete(TF2Directory + "\\Metro Hud", true);

            if (Directory.Exists(TF2Directory + "\\Milky Hud"))
                Directory.Delete(TF2Directory + "\\Milky Hud", true);

            if (Directory.Exists(TF2Directory + "\\MN-Hud-master"))
                Directory.Delete(TF2Directory + "\\MN-Hud-master", true);

            if (Directory.Exists(TF2Directory + "\\Noto-KN Hud"))
                Directory.Delete(TF2Directory + "\\Noto-KN Hud", true);

            if (Directory.Exists(TF2Directory + "\\Hudas Iscariote"))
                Directory.Delete(TF2Directory + "\\Hudas Iscariote", true);

            if (Directory.Exists(TF2Directory + "\\Omp Hud Redux"))
                Directory.Delete(TF2Directory + "\\Omp Hud Redux", true);

            if (Directory.Exists(TF2Directory + "\\Omp Hud"))
                Directory.Delete(TF2Directory + "\\Omp Hud", true);

            if (Directory.Exists(TF2Directory + "\\Orbiculatus Hud"))
                Directory.Delete(TF2Directory + "\\Orbiculatus Hud", true);

            if (Directory.Exists(TF2Directory + "\\OTL Hud"))
                Directory.Delete(TF2Directory + "\\OTL Hud", true);

            if (Directory.Exists(TF2Directory + "\\Oxide Hud"))
                Directory.Delete(TF2Directory + "\\Oxide Hud", true);

            if (Directory.Exists(TF2Directory + "\\Prism Hud"))
                Directory.Delete(TF2Directory + "\\Prism Hud", true);

            if (Directory.Exists(TF2Directory + "\\Product Hud"))
                Directory.Delete(TF2Directory + "\\Product Hud", true);

            if (Directory.Exists(TF2Directory + "\\PV Hud"))
                Directory.Delete(TF2Directory + "\\PV Hud", true);

            if (Directory.Exists(TF2Directory + "\\QTC Hud"))
                Directory.Delete(TF2Directory + "\\QTC Hud", true);

            if (Directory.Exists(TF2Directory + "\\Rads Hud"))
                Directory.Delete(TF2Directory + "\\Rads Hud", true);

            if (Directory.Exists(TF2Directory + "\\Rain Hud"))
                Directory.Delete(TF2Directory + "\\Rain Hud", true);

            if (Directory.Exists(TF2Directory + "\\Rev Hud"))
                Directory.Delete(TF2Directory + "\\Rev Hud", true);

            if (Directory.Exists(TF2Directory + "\\Reverto Hud"))
                Directory.Delete(TF2Directory + "\\Reverto Hud", true);

            if (Directory.Exists(TF2Directory + "\\rhB Hud"))
                Directory.Delete(TF2Directory + "\\rhB Hud", true);

            if (Directory.Exists(TF2Directory + "\\Roboto Hud"))
                Directory.Delete(TF2Directory + "\\Roboto Hud", true);

            if (Directory.Exists(TF2Directory + "\\Shlaner Hud"))
                Directory.Delete(TF2Directory + "\\Shlaner Hud", true);

            if (Directory.Exists(TF2Directory + "\\SK Hud"))
                Directory.Delete(TF2Directory + "\\SK Hud", true);

            if (Directory.Exists(TF2Directory + "\\Slay Hud"))
                Directory.Delete(TF2Directory + "\\Slay Hud", true);

            if (Directory.Exists(TF2Directory + "\\Soft Hud"))
                Directory.Delete(TF2Directory + "\\Soft Hud", true);

            if (Directory.Exists(TF2Directory + "\\Solano Hud"))
                Directory.Delete(TF2Directory + "\\Solano Hud", true);

            if (Directory.Exists(TF2Directory + "\\TF2Hud+ Old"))
                Directory.Delete(TF2Directory + "\\TF2Hud+ Old", true);

            if (Directory.Exists(TF2Directory + "\\Thwartzki Hud"))
                Directory.Delete(TF2Directory + "\\Thwartzki Hud", true);

            if (Directory.Exists(TF2Directory + "\\Toasty Hud"))
                Directory.Delete(TF2Directory + "\\Toasty Hud", true);

            if (Directory.Exists(TF2Directory + "\\Topsh_it-Hud-master"))
                Directory.Delete(TF2Directory + "\\Topsh_it-Hud-master", true);

            if (Directory.Exists(TF2Directory + "\\Tresh Hud"))
                Directory.Delete(TF2Directory + "\\Tresh Hud", true);

            if (Directory.Exists(TF2Directory + "\\Vabe Hud"))
                Directory.Delete(TF2Directory + "\\Vabe Hud", true);

            if (Directory.Exists(TF2Directory + "\\Wavesui"))
                Directory.Delete(TF2Directory + "\\Wavesui", true);

            if (Directory.Exists(TF2Directory + "\\X Hud"))
                Directory.Delete(TF2Directory + "\\X Hud", true);

            if (Directory.Exists(TF2Directory + "\\Yahud 5MD"))
                Directory.Delete(TF2Directory + "\\Yahud 5MD", true);

            if (Directory.Exists(TF2Directory + "\\Yahud Black"))
                Directory.Delete(TF2Directory + "\\Slay Hud", true);

            if (Directory.Exists(TF2Directory + "\\Yahud 5MD"))
                Directory.Delete(TF2Directory + "\\Yahud 5MD", true);

            if (Directory.Exists(TF2Directory + "\\Yahud CMYK"))
                Directory.Delete(TF2Directory + "\\Yahud CMYK", true);

            if (Directory.Exists(TF2Directory + "\\Yahud CX"))
                Directory.Delete(TF2Directory + "\\Yahud CX", true);

            if (Directory.Exists(TF2Directory + "\\Yahud FL"))
                Directory.Delete(TF2Directory + "\\Yahud FL", true);

            if (Directory.Exists(TF2Directory + "\\Yahud M-X"))
                Directory.Delete(TF2Directory + "\\Yahud M-X", true);

            if (Directory.Exists(TF2Directory + "\\Yahud Old"))
                Directory.Delete(TF2Directory + "\\Yahud Old", true);

            if (Directory.Exists(TF2Directory + "\\yayahud"))
                Directory.Delete(TF2Directory + "\\yayahud", true);

            if (Directory.Exists(TF2Directory + "\\Z Hud"))
                Directory.Delete(TF2Directory + "\\Z Hud", true);

            if (Directory.Exists(TF2Directory + "\\Zim Hud"))
                Directory.Delete(TF2Directory + "\\Zim Hud", true);

            if (Directory.Exists(TF2Directory + "\\Zoub Hud"))
                Directory.Delete(TF2Directory + "\\Zoub Hud", true);
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
                status.Text = "Uninstallation Finished";
                button10.Enabled = true;
                Uninstall.Enabled = true;
        }

        private void crosshairstop_Click(object sender, EventArgs e)
        {
            hudControl1.Visible = false;
            crosshairControl1.Visible = true;
            label3.Text = "* Crosshairs";
            hudtop.ForeColor = Color.White;
            crosshairstop.ForeColor = Color.Gray;

        }
    }

}
