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
    public partial class CrosshairControl : UserControl
    {
        public string crosspick;
        public CrosshairControl()
        {
            InitializeComponent();
        }

        private void crossdot_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://cdn.discordapp.com/attachments/530625335746625536/530631077874761728/Screenshot_12.png";
            webBrowser1.Navigate(web);
            crosspick = "Crossdot";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://cdn.discordapp.com/attachments/530625335746625536/530629650095800340/Screenshot_2.png";
            webBrowser1.Navigate(web);
            crosspick = "Wings";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://cdn.discordapp.com/attachments/530625335746625536/530629793608368128/Screenshot_3.png";
            webBrowser1.Navigate(web);
            crosspick = "Dot";
        }

        private void circle_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://cdn.discordapp.com/attachments/530625335746625536/530629964870057984/Screenshot_4.png";
            webBrowser1.Navigate(web);
            crosspick = "Circle";
        }

        private void sniper_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://cdn.discordapp.com/attachments/530625335746625536/530630095048671260/Screenshot_5.png";
            webBrowser1.Navigate(web);
            crosspick = "Sniper";
        }

        private void crosshair11_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://cdn.discordapp.com/attachments/530625335746625536/530630200522965033/Screenshot_6.png";
            webBrowser1.Navigate(web);
            crosspick = "Crosshair11";
        }

        private void wingsdot_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://cdn.discordapp.com/attachments/530625335746625536/530630337319927818/Screenshot_7.png";
            webBrowser1.Navigate(web);
            crosspick = "Wingsdot";
        }

        private void seeker_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://cdn.discordapp.com/attachments/530625335746625536/530630465191936000/Screenshot_8.png";
            webBrowser1.Navigate(web);
            crosspick = "Seeker";
        }

        private void circledot_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://cdn.discordapp.com/attachments/530625335746625536/530630583450075146/Screenshot_9.png";
            webBrowser1.Navigate(web);
            crosspick = "Circledot";
        }

        private void bigcross_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://cdn.discordapp.com/attachments/530625335746625536/530630711624073226/Screenshot_10.png";
            webBrowser1.Navigate(web);
            crosspick = "Bigcross";
        }

        private void fatcross_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            string web = "https://cdn.discordapp.com/attachments/530625335746625536/530631077874761728/Screenshot_12.png";
            webBrowser1.Navigate(web);
            crosspick = "fatcross";
        }
    }
}
