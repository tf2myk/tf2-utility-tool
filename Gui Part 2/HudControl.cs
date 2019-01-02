using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_Part_2
{
    public partial class HudControl : UserControl
    {
        public HudControl()
        {
            InitializeComponent();
        }





        public int Disp;
        //MOREHUD BUTTON 1
        private void more_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/sxOyM";

            webBrowser1.Navigate(web);
            Disp = 1;
        }


        private void HudControl_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            hudleft.Visible = false;
        }

        //
        //PAGE 1
        //

        //HYPNOTIZE 
        public void hypnotize_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/4sgZ1";
            Disp = 2;

            webBrowser1.Navigate(web);
            

        }
        //TFTV
        private void TFTV_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/MIlTm";
            Disp = 3;

            webBrowser1.Navigate(web);

        }
        //Broesel-Old
        private void BroeselOld_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/fG2xQ";
            Disp = 4;

            webBrowser1.Navigate(web);

        }
        //1Shot-Hud
        private void OneShot_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/HieQg";
            Disp = 5;

            webBrowser1.Navigate(web);


        }
        //Ace-Hud
        private void Ace_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/uBg83";
            Disp = 6;

            webBrowser1.Navigate(web);

        }
        //Bast-Hud
        private void Bast_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/gDjCp";
            Disp = 7;

            webBrowser1.Navigate(web);

        }
        //Baz 
        private void Baz_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/982kf";
            Disp = 8;

            webBrowser1.Navigate(web);

        }
        //Black-Hud
        private void Black_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/CykiS";
            Disp = 9;

            webBrowser1.Navigate(web);

        }
        //Bonerjamz
        private void bonerjamz_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/OHMFf";
            Disp = 10;

            webBrowser1.Navigate(web);
        }
        //Broesel
        private void broesel_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/YxG82";
            Disp = 11;

            webBrowser1.Navigate(web);
        }
        //Broken Hud
        private void broken_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/fu94w";
            Disp = 12;
            webBrowser1.Navigate(web);
        }
        //bw
        private void bw_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/JVVDx";
            Disp = 13;

            webBrowser1.Navigate(web);
        }
        //bx
        private void bx_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/gGOow";
            Disp = 14;

            webBrowser1.Navigate(web);
        }
        //bxmore
        private void bxmore_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/gsGjG";
            Disp = 15;

            webBrowser1.Navigate(web);
        }
        //CB
        private void cb_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/zO0ju";
            Disp = 16;

            webBrowser1.Navigate(web);
        }
        //mix centered hud
        private void mix_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/P6h4D";
            Disp = 17;

            webBrowser1.Navigate(web);
        }
        //clip hud
        private void clip_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/172lD";
            Disp = 18;

            webBrowser1.Navigate(web);



        }
        ///
        //PAGE 2 STARTS
        //
        private void crspbroesel_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/Ywblk";
            Disp = 19;

            webBrowser1.Navigate(web);
        }

        private void delihud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/AOznT";
            Disp = 20;

            webBrowser1.Navigate(web);
        }

        private void dinohud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/rHr5T";
            Disp = 21;

            webBrowser1.Navigate(web);
        }

        private void egghud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/LC3No";
            Disp = 22;

            webBrowser1.Navigate(web);
        }

        private void ellshud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/L4vPB";
            Disp = 23;

            webBrowser1.Navigate(web);
        }

        private void evanshud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/RlFLP";
            Disp = 24;

            webBrowser1.Navigate(web);
        }

        private void evolvehud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/C9Ij8";
            Disp = 25;

            webBrowser1.Navigate(web);
        }

        private void hypnotizem0rehud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/2gckG";
            Disp = 26;

            webBrowser1.Navigate(web);
        }

        private void fkhud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/BM9vJ";
            Disp = 27;

            webBrowser1.Navigate(web);
        }

        private void flamehud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/NHBdv";
            Disp = 28;

            webBrowser1.Navigate(web);
        }

        private void flathud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/k8Dff";
            Disp = 29;

            webBrowser1.Navigate(web);
        }

        private void gmanghud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/IZKZA";
            Disp = 30;

            webBrowser1.Navigate(web);
        }

        private void garmen7mf_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/lwAFh";
            Disp = 31;

            webBrowser1.Navigate(web);
        }

        private void garmen8mg_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/0Mn7x";
            Disp = 32;

            webBrowser1.Navigate(web);
        }

        private void garmenolx_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/TbukW";
            Disp = 33;

            webBrowser1.Navigate(web);
        }

        private void garmenqm_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/urYMd";
            Disp = 34;

            webBrowser1.Navigate(web);
        }

        private void garmenql_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/NuVAM";
            Disp = 35;

            webBrowser1.Navigate(web);
        }

        private void garmenqledit_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/Zvasl";
            Disp = 36;

            webBrowser1.Navigate(web);
        }

        //Page Switching
        public int pagenum;
        private void hudright_Click(object sender, EventArgs e)
        {
            pagenum = 2;
            pagenumber.Text = pagenum.ToString();

            if (pagenum == 2)
            {
                hudpage2.Visible = true;
                hudpage1.Visible = false;
                hudleft.Visible = true;
                pagenumber.Text = pagenum.ToString();
            }

        }

        private void hudleft_Click(object sender, EventArgs e)
        {
            pagenum = 1;
            if (pagenum == 1)
            {
                hudpage1.Visible = true;
                hudpage2.Visible = false;
                pagenumber.Text = pagenum.ToString();
                hudleft.Visible = false;
            }
        }
    }
}
