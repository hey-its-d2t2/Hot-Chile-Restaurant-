using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hot_Chile_Restaurant.UserControles
{
    public partial class UC_AdminControleForm : UserControl
    {
        DB_Function function = new DB_Function();
        string query;
        public UC_AdminControleForm()
        {
            InitializeComponent();
        }

        private void BtnAddSalesMan_Click_1(object sender, EventArgs e)
        {
            Frm_AddSalesMan asm = new Frm_AddSalesMan();
            asm.Show();
        }

        private void BtnDelItemCat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete all item & Categorry.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from Items";
                function.SetData(query, "User deleted.");
            }
        }

        private void BtnAddAdminUser_Click_1(object sender, EventArgs e)
        {
            Frm_AddUser au = new Frm_AddUser();
            au.Show();
        }

        private void BtnView_DelUser_Click_1(object sender, EventArgs e)
        {
            Frm_ViewAllUser vu = new Frm_ViewAllUser();
            vu.Show();
        }

        private void BtnView_DelCustomer_Click_1(object sender, EventArgs e)
        {
            Frm_ViewDelCustomerData vd = new Frm_ViewDelCustomerData();
            vd.Show();
        }

        private void BtnCahngeAdminPass_Click_1(object sender, EventArgs e)
        {
            Frm_ChangeAdminPass cp = new Frm_ChangeAdminPass();
            cp.Show();
        }
    }
}
