﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            string web = "https://imgur.com/a/MIlTm";

            webBrowser1.CoreWebView2.Navigate(web);
            Disp = 1;
        }




        private async void HudControl_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            hudleft.Visible = false;
            if (pagenum == 0)
            {
                pagenum = 1;
            }
            pagenumber.Text = pagenum.ToString();

            await webBrowser1.EnsureCoreWebView2Async();





            webBrowser1.ZoomFactor = 1.1;

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

            webBrowser1.CoreWebView2.Navigate(web);
            

        }
        //TFTV
        private void TFTV_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/MIlTm";
            Disp = 3;

            webBrowser1.CoreWebView2.Navigate(web);

        }
        //Broesel-Old
        private void BroeselOld_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/fG2xQ";
            Disp = 4;

            webBrowser1.CoreWebView2.Navigate(web);

        }
        //1Shot-Hud
        private void OneShot_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/HieQg";
            Disp = 5;

            webBrowser1.CoreWebView2.Navigate(web);


        }
        //Ace-Hud
        private void Ace_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/uBg83";
            Disp = 6;

            webBrowser1.CoreWebView2.Navigate(web);

        }
        //Bast-Hud
        private void Bast_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/gDjCp";
            Disp = 7;

            webBrowser1.CoreWebView2.Navigate(web);

        }
        //Baz 
        private void Baz_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/982kf";
            Disp = 8;

            webBrowser1.CoreWebView2.Navigate(web);

        }
        //Black-Hud
        private void Black_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/CykiS";
            Disp = 9;

            webBrowser1.CoreWebView2.Navigate(web);

        }
        //Bonerjamz
        private void bonerjamz_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/OHMFf";
            Disp = 10;

            webBrowser1.CoreWebView2.Navigate(web);
        }
        //Broesel
        private void broesel_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/YxG82";
            Disp = 11;

            webBrowser1.CoreWebView2.Navigate(web);
        }
        //Broken Hud
        private void broken_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/fu94w";
            Disp = 12;
            webBrowser1.CoreWebView2.Navigate(web);
        }
        //bw
        private void bw_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/JVVDx";
            Disp = 13;

            webBrowser1.CoreWebView2.Navigate(web);
        }
        //bx
        private void bx_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/gGOow";
            Disp = 14;

            webBrowser1.CoreWebView2.Navigate(web);
        }
        //bxmore
        private void bxmore_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/gsGjG";
            Disp = 15;

            webBrowser1.CoreWebView2.Navigate(web);
        }
        //CB
        private void cb_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/zO0ju";
            Disp = 16;

            webBrowser1.CoreWebView2.Navigate(web);
        }
        //mix centered hud
        private void mix_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/P6h4D";
            Disp = 17;

            webBrowser1.CoreWebView2.Navigate(web);
        }
        //clip hud
        private void clip_click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/172lD";
            Disp = 18;

            webBrowser1.CoreWebView2.Navigate(web);
        }
        ///
        //PAGE 2 STARTS
        //
        private void crspbroesel_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/Ywblk";
            Disp = 19;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void delihud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/AOznT";
            Disp = 20;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void dinohud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/rHr5T";
            Disp = 21;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void egghud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/LC3No";
            Disp = 22;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void ellshud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/L4vPB";
            Disp = 23;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void evanshud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/RlFLP";
            Disp = 24;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void evolvehud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/C9Ij8";
            Disp = 25;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void hypnotizem0rehud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/2gckG";
            Disp = 26;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void fkhud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/BM9vJ";
            Disp = 27;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void flamehud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/NHBdv";
            Disp = 28;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void flathud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/k8Dff";
            Disp = 29;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void gmanghud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/IZKZA";
            Disp = 30;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void garmen7mf_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/lwAFh";
            Disp = 31;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void garmen8mg_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/0Mn7x";
            Disp = 32;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void garmenolx_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/TbukW";
            Disp = 33;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void garmenqm_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/urYMd";
            Disp = 34;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void garmenql_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/NuVAM";
            Disp = 35;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void garmenqledit_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/Zvasl";
            Disp = 36;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void garm3nrb_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/SK9On";
            Disp = 37;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void rex_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/GLD5e";
            Disp = 38;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void SDX_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/ZWTQm";
            Disp = 39;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void tanlight_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/JYBQB";
            Disp = 40;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void tcf_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/Q7SLN";
            Disp = 41;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void beavern_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/tK9N1";
            Disp = 42;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void konr_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/cIa2N";
            Disp = 43;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void quad_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/gzaxK";
            Disp = 44;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void stefan_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/xgQiy";
            Disp = 45;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void gear_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/9YgR9";
            Disp = 46;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void Goat_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/T584p";
            Disp = 47;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void grapedefault_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/m2nyT";
            Disp = 48;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void grape_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/hDF9j";
            Disp = 49;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void grapeknmore_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/9pTHl";
            Disp = 50;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void grapemorehud_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/8KYR6";
            Disp = 51;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void grapeoxide_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/9Z9Z5";
            Disp = 52;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void helvetica_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/igBJ1";
            Disp = 53;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void hudasiscariote_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/ag9He";
            Disp = 54;

            webBrowser1.CoreWebView2.Navigate(web);
        }
        private void jishin_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/hlCAv";
            Disp = 55;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void julias_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/C67Dy";
            Disp = 56;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void ka_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/aZCiw";
            Disp = 57;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void kered_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/JV6hL";
            Disp = 58;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void knedit_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/odCHW";
            Disp = 59;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void knold_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/YblgN";
            Disp = 60;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void kn_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/MzCXa";
            Disp = 61;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void lanskyoxide_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/ZUl8l";
            Disp = 62;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void moreold_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/IcmXc";
            Disp = 63;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void morequake_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/7TlzO";
            Disp = 64;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void morehudblack2_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/wStS6";
            Disp = 65;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void morehudblack_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/DTWOm";
            Disp = 66;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void material_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/pN8KT";
            Disp = 67;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void med_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/1ufBE";
            Disp = 68;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void metro_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/QfU3Z";
            Disp = 69;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void milky_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://images.fonearena.com/blog/wp-content/uploads/2012/04/noScreenShot.jpg";
            Disp = 70;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void mn_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/YYTQV";
            Disp = 71;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void notokn_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/Hw6Yv";
            Disp = 72;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void ompredux_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/XCNB1";
            Disp = 73;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void omp_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/mCoYj";
            Disp = 74;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void orb_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://images.fonearena.com/blog/wp-content/uploads/2012/04/noScreenShot.jpg";
            Disp = 75;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void OTL_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/MC2zy";
            Disp = 76;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void oxide_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/R9a13";
            Disp = 77;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void Prism_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/pOmR6";
            Disp = 78;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void product_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://images.fonearena.com/blog/wp-content/uploads/2012/04/noScreenShot.jpg";
            Disp = 79;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void pv_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/C3dXl";
            Disp = 80;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void qtc_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/lS0SX";
            Disp = 81;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void rads_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/JdtsG";
            Disp = 82;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void rain_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/CZrFj";
            Disp = 83;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void Rev_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/LWnlW";
            Disp = 84;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void Reverto_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/iqXoZ";
            Disp = 85;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void rhb_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/VSPoa";
            Disp = 86;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void roboto_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://images.fonearena.com/blog/wp-content/uploads/2012/04/noScreenShot.jpg";
            Disp = 87;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void Shlaner_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/wXr6q";
            Disp = 88;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void sk_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/0euq9";
            Disp = 89;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void slay_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/TeEEs";
            Disp = 90;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void soft_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/CimzP";
            Disp = 91;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void Solano_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://images.fonearena.com/blog/wp-content/uploads/2012/04/noScreenShot.jpg";
            Disp = 92;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void tf2hudold_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/kPA9W";
            Disp = 93;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void thawrtzki_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/AKFci";
            Disp = 94;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void toasty_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/hPdke";
            Disp = 95;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void topsh_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/KtKEH";
            Disp = 96;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void tresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/aBoAV";
            Disp = 97;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void vabe_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/pfx2E";
            Disp = 98;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void waves_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/Xxxoc";
            Disp = 99;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void x_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/5kPfO";
            Disp = 100;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void fivemd_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/hdt35";
            Disp = 101;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void yahudblack_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/roorU";
            Disp = 102;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void cmyk_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/LrcV8";
            Disp = 103;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void cx_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/UXbjv";
            Disp = 104;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void fl_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/oFY3M";
            Disp = 105;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void mx_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/59N9S";
            Disp = 106;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void yahudold_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/oHoQ2";
            Disp = 107;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void yaya_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/LCENr";
            Disp = 108;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void z_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/3LOOs";
            Disp = 109;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void zim_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/kw4Ou";
            Disp = 110;

            webBrowser1.CoreWebView2.Navigate(web);
        }

        private void zoub_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://imgur.com/a/ie9GL";
            Disp = 111;

            webBrowser1.CoreWebView2.Navigate(web);
        }


        //Page Switching
        public int pagenum;
        
        private void hudright_Click(object sender, EventArgs e)
        {
            pagenum++;

            if (pagenum == 2)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage2.Visible = true;
                hudpage3.Visible = false;
                hudpage1.Visible = false;
                hudleft.Visible = true;
                hudright.Visible = true;
                
            }
            else if (pagenum == 3)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage3.Visible = true;
                hudpage4.Visible = false;
                hudpage1.Visible = false;
                hudpage2.Visible = false;
                hudleft.Visible = true;
                hudright.Visible = true;
                
            }
            else if (pagenum == 4)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage3.Visible = false;
                hudpage4.Visible = true;
                hudpage1.Visible = false;
                hudpage5.Visible = false;
                hudpage2.Visible = false;
                hudleft.Visible = true;
                hudright.Visible = true;

            }
            else if (pagenum == 5)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage3.Visible = false;
                hudpage4.Visible = false;
                hudpage5.Visible = true;
                hudpage6.Visible = false;
                hudpage1.Visible = false;
                hudpage2.Visible = false;
                hudleft.Visible = true;
                hudright.Visible = true;

            }
            else if (pagenum == 6)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage3.Visible = false;
                hudpage4.Visible = false;
                hudpage5.Visible = false;
                hudpage6.Visible = true;
                hudpage1.Visible = false;
                hudpage2.Visible = false;
                hudleft.Visible = true;
                hudright.Visible = true;

            }
            else if (pagenum == 7)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage3.Visible = false;
                hudpage4.Visible = false;
                hudpage5.Visible = false;
                hudpage7.Visible = true;
                hudpage6.Visible = false;
                hudpage1.Visible = false;
                hudpage2.Visible = false;
                hudleft.Visible = true;
                hudright.Visible = false;

            }


        }

        private void hudleft_Click(object sender, EventArgs e)
        {
            pagenum--;

            if (pagenum == 1)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage1.Visible = true;
                hudpage2.Visible = false;
                hudpage3.Visible = false;
                hudleft.Visible = false;
                hudright.Visible = true;
            }
            else if (pagenum == 2)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage3.Visible = true;
                hudpage1.Visible = false;
                hudpage2.Visible = true;
                hudpage3.Visible = false;
                hudleft.Visible = true;
                hudright.Visible = true;
            }
            else if (pagenum == 3)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage3.Visible = true;
                hudpage1.Visible = false;
                hudpage2.Visible = false;
                hudpage4.Visible = false;
                hudleft.Visible = true;
                hudright.Visible = true;
            }
            else if (pagenum == 4)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage3.Visible = false;
                hudpage1.Visible = false;
                hudpage2.Visible = false;
                hudpage4.Visible = true;
                hudpage5.Visible = false;
                hudleft.Visible = true;
                hudright.Visible = true;
            }
            else if (pagenum == 5)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage3.Visible = false;
                hudpage4.Visible = false;
                hudpage1.Visible = false;
                hudpage6.Visible = false;
                hudpage2.Visible = false;
                hudpage5.Visible = true;
                hudleft.Visible = true;
                hudright.Visible = true;
            }
            else if (pagenum == 6)
            {
                pagenumber.Text = pagenum.ToString();
                hudpage3.Visible = false;
                hudpage4.Visible = false;
                hudpage1.Visible = false;
                hudpage6.Visible = true;
                hudpage2.Visible = false;
                hudpage7.Visible = false;
                hudpage5.Visible = false;
                hudleft.Visible = true;
                hudright.Visible = true;
            }
        }
    }
}
