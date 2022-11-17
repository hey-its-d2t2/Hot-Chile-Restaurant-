using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hot_Chile_Restaurant
{
    public partial class SplashWin : Form
    {
        public SplashWin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CircProg.ForeColor = Color.FromArgb(29, 29, 27);            
            CircProg.Value += 2;
            if(CircProg.Value >= 100)
            {
                timer1.Enabled = false;
                AdminLoginForm adlf = new AdminLoginForm();
                adlf.Show();
                this.Hide();
            }
        }

        private void SplashWin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
