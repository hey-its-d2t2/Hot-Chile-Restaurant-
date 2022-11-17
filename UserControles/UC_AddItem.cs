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
    public partial class UC_AddItem : UserControl
    {
        DB_Function function  =new DB_Function();
        string query;
        public UC_AddItem()
        {
            InitializeComponent();
        }
        //BtnAdd  Add Item
        //BtnAdd add the Items and category to the DataGridView1
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtItemName.Text != "" && TxtCategory.Text != "" && TxtPrice.Text != "")
            {
                try
                {
                    long price = long.Parse(TxtPrice.Text);
                    //string cat = TxtCategory.SelectedText;
                    // TxtCategory.SelectedText.ToString()
                    query = "insert into Items(Name,Category,Price) values ('" + TxtItemName.Text + "','"+ TxtNewCategory.Text + "'," + price + ")";
                    function.SetData(query, "Item added.");

                    UC_AddItem_Load(this, null);
                   // query = "select * from Items";
                   // DataSet ds = function.GetData(query);
                   // TxtCategory.Items.Add(ds.Tables[1]);
                }
                catch
                { //MessageBox.Show("InCatch","", MessageBoxButtons.OK);

                }
            }
            else
            {
                //If all fields are empty then shows error messaage                
                MessageBox.Show("Fill proper details","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //Function to clear all field values
        public void CleareAll()
        {
            TxtPrice.Text = "";
            TxtItemName.Text = "";
            TxtCategory.SelectedIndex = -1;
            TxtNewCategory.Text = "";
            LblCatNMsg.Visible = false;
        }

        private void UC_AddItem_Leave(object sender, EventArgs e)
        {
            CleareAll();
        }
        private void UC_AddItem_Load(object sender, EventArgs e)
        {
            //Form load event 
            // When the form loads it sets the data to  Category selection list (TxtCategory)
            // 
            // TxtCategory.Text = "";
            NewCatAdded();
            //Set values to Data Grid
            query = "select * from Items";
            DataSet ds = function.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
            //query = "select * from Category";
            //DataSet ds1 = function.GetData(query);
            //TxtCategory.Items.Add(ds.Tables[1]);
            
        }

        //BtnAddCategory it adds the new category 
        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            if (TxtNewCategory.Text != "")
            {
                try
                {
                    //string item = null;
                    //long p = 0;
                 
                    query = "insert into Items(Category) values ('" + TxtNewCategory.Text + "')";
                    function.SetData(query, "Category added.");

                    //Reloding form for geting data at a time
                    TxtCategory.Items.Clear();
                    UC_AddItem_Load(this, null);
                }
                catch
                {
                    //if category already exixts then message displays
                    MessageBox.Show("Category already exists.", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    TxtNewCategory.Text = "";
                }
            }
            else
            {
                //If TxtNewCategory.Text is empty the shows the message on label
                LblCatNMsg.Visible = true;
            }
        }

        //Function tho add category in Category selection list boc
        private void NewCatAdded()
        {
                CleareAll();
                TxtCategory.Items.Clear();
                query = "select Category from Items";
                DataSet ds = function.GetData(query);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string cat = ds.Tables[0].Rows[i][0].ToString();
                    if (cat!= "")
                    {

                        TxtCategory.Items.Add(cat);
                    }
                }
           
        }

        private void TxtNewCategory_Click(object sender, EventArgs e)
        {
            LblCatNMsg.Visible = false;
        }
    }
}
