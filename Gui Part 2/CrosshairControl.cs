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
        public int crosspick;
        public CrosshairControl()
        {
            InitializeComponent();
        }

        private void crossdot_Click(object sender, EventArgs e)
        {
            crosspick = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crosspick = 2;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            crosspick = 3;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            crosspick = 4;
        }

        private void sniper_Click(object sender, EventArgs e)
        {
            crosspick = 5;
        }

        private void crosshair11_Click(object sender, EventArgs e)
        {
            crosspick = 6;
        }

        private void wingsdot_Click(object sender, EventArgs e)
        {
            crosspick = 7;
        }

        private void seeker_Click(object sender, EventArgs e)
        {
            crosspick = 8;
        }

        private void circledot_Click(object sender, EventArgs e)
        {
            crosspick = 9;
        }

        private void bigcross_Click(object sender, EventArgs e)
        {
            crosspick = 10;
        }

        private void fatcross_Click(object sender, EventArgs e)
        {
            crosspick = 11;
        }
    }
}
