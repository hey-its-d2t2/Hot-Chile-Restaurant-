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
    public partial class Frm_ViewAllUser : Form
    {
        DB_Function function = new DB_Function();
        string query;
        public Frm_ViewAllUser()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ViewAllUser_Load(object sender, EventArgs e)
        {
            query = "select * from UserDetails";
            DataSet ds2 = function.GetData(query);
            DataGridView1.DataSource = ds2.Tables[0];
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete item.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from UserDetails where Id = " + id + "";
                function.SetData(query, "User deleted.");
                Frm_ViewAllUser_Load(this, null);
            }
        }
    }
}
