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
    
    public partial class UC_RemoveItem : UserControl
    {
        DB_Function function = new DB_Function();
        string query;
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        protected void LoadData()
        {
            //Lading Data from database

            //Lading all data from database
            query = "select * from Items";
            DataSet ds = function.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
            //Loading Category from database
            query = "select Category from Items";
            DataSet ds2 = function.GetData(query);
            DataGridView2.DataSource = ds2.Tables[0];

        }
        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            //When form loads the loding data to datd Grid
            LoadData();
        }

        private void TxtSearchItem_OnValueChanged(object sender, EventArgs e)
        {
            //searching Items from items coulmn from databse
            query = "select * from Items where Name like '" + TxtSearchItem.Text + "%'";
            DataSet ds = function.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }
        private void TxtCategorySearch_OnValueChanged(object sender, EventArgs e)
        {
            //searching Category from items coulmn from databs
            query = "select Category from Items where Category like '" + TxtCategorySearch.Text + "%'";
            DataSet ds = function.GetData(query);
            DataGridView2.DataSource = ds.Tables[0];
        }

        //Deleating item
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item.","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from Items where Id = " + id + "";
                function.SetData(query, "Data deleted.");
                LoadData();
            }

        }
        //Deleating category 
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Category.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               
                query = "delete from Items where Category  = '" + DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                function.SetData(query, "Data deleted.");
                LoadData();
            }
        }


        //Help labe 
        private void label3_MouseHover(object sender, EventArgs e)
        {
            LblDelMsg.Visible = true;
            label3.ForeColor = Color.FromArgb(254, 35, 31);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            LblDelMsg.Visible = false;
            label3.ForeColor = Color.White;
        }

       

    }
}
