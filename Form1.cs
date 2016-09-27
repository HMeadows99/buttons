using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttons
{
    public partial class Frmbuttons : Form
    {
        public Frmbuttons()
        {
            InitializeComponent();
        }

        private void btncow_Click(object sender, EventArgs e)
        {
            lblmilkshake.Text = ("a milkshake");
        }

        private void btnpizza_Click(object sender, EventArgs e)
        {
            lblcheesy.Text = ("nevermind, its too cheesy");
        }

        private void btnsquid_Click(object sender, EventArgs e)
        {
            lbltickles.Text = ("ten-tickles");
        }
    }
}
