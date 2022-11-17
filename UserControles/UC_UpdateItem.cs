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
    public partial class UC_UpdateItem : UserControl
    {
        DB_Function function = new DB_Function();
        string query;
        public UC_UpdateItem()
        {
            InitializeComponent();
        }

        protected void LoadData()
        {
            query = "select * from Items";
            DataSet ds = function.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }
        private void UC_UpdateItem_Load(object sender, EventArgs e)
        {
            LoadData();  
        }

        private void TxtSearchItem_OnValueChanged(object sender, EventArgs e)
        {
            query = "select * from Items where Name like '"+TxtSearchItem.Text+"%'";
            DataSet ds = function.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];

        }
        int id;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string category = DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()
;           string name = DataGridView1.Rows[e.RowIndex ].Cells[1].Value.ToString();
            int price = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            TxtItemCategory.Text = category;
            TxtItemName.Text= name;
            TxtItemPrice.Text = price.ToString();


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(TxtItemPrice.Text !=""&& TxtItemName.Text !="" && TxtItemCategory.Text !="")
            {
                query = "update items set Name = '"+TxtItemName.Text+ "',Category = '" + TxtItemCategory.Text+"', Price = "+TxtItemPrice.Text+ " where Id = "+id+"";
                function.SetData(query,"Details updated.");
                LoadData();
                TxtItemName.Text = "";
                TxtItemCategory.Text = "";
                TxtItemPrice.Text = "";
                TxtSearchItem.Text = "";
            }
            else
            {
                MessageBox.Show("Please select items from list and update it.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
