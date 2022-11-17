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
    public partial class AdminPanelForm : Form
    {
        Frm_AboutDev ad = new Frm_AboutDev();
        public AdminPanelForm()
        {
            InitializeComponent();
         
        }
        public AdminPanelForm(String user)
        {
            InitializeComponent();
            if(user == "RetailAssistant")
            {
                uC_Home1.BringToFront();
                BtnAddItem.Hide(); 
                BtnUpdateItem.Hide();
                BtnRemoveItem.Hide();
                BtnAdmin.Hide();
                uC_AddItem1.Hide();
                uC_RemoveItem1.Hide();
                uC_UpdateItem1.Hide();
                uC_AdminControleForm1.Hide();

            }
            else if(user == "admin")
            {
                uC_Home1.BringToFront();
                BtnAddItem.Show();
                BtnUpdateItem.Show();
                BtnRemoveItem.Show();
                BtnAdmin.Show();
                BtnOrderPlace.Show();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            //if(WindowState == FormWindowState.Normal)
            //     WindowState = FormWindowState.Maximized;
            //else
            //    WindowState = FormWindowState.Normal;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState |= FormWindowState.Minimized;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            AdminLoginForm adlf = new AdminLoginForm();
            ad.Close();
            this.Hide();
            adlf.ShowDialog();
            
        }

        private void PnlTitleBar_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            ad.Close();
            uC_AddItem1.BringToFront();
            
            BtnAddItem.BackColor = Color.Turquoise;
        }

        private void BtnOrderPlace_Click(object sender, EventArgs e)
        {
            ad.Close();
            uC_PlaceOrder1.BringToFront();
           
            BtnOrderPlace.BackColor = Color.Turquoise;
        }

        private void BtnUpdateItem_Click(object sender, EventArgs e)
        {
            ad.Close();
            uC_UpdateItem1.BringToFront();
       
            BtnUpdateItem.BackColor = Color.Turquoise;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ad.Close();
            uC_Home1.BringToFront();
            BtnHome.BackColor = Color.Turquoise;
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            ad.Close();
            uC_RemoveItem1.BringToFront();
            BtnRemoveItem.BackColor = Color.Turquoise;
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Frm_AboutDev ad = new Frm_AboutDev();
            ad.Show();
         
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            ad.Close();
            uC_AdminControleForm1.BringToFront();
         
            BtnAdmin.BackColor = Color.Turquoise;
        }
    }
}
