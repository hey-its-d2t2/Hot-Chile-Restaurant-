using DGVPrinterHelper;
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
    public partial class UC_PlaceOrder : UserControl
    {
        DB_Function function = new DB_Function();
        string query;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void ComoboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Showing item name relate to category 
            string category = ComoboCategory.Text;
            query = "select Name from Items where Category = '" + category+"'";
            ShowItemList(query);
        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {
            //When form loads setting Category into category listbox(ComboCategory) form database
            //query = "select * from Items";
            //DataSet ds = function.GetData(query);
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    string cat = ds.Tables[0].Rows[i][2].ToString();
            //   // if(cat!="")
            //        ComoboCategory.Items.Add(cat);
            //}


            ////
            query = " select distinct Category from Items";
            DataSet ds = function.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
             ComoboCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            //ComoboCategory.Items = 
        }

        private void TxtSearchItem_OnValueChanged(object sender, EventArgs e)
        {
            string category = ComoboCategory.Text;
            //query = "select Name from Items where Category = '" + category + "' and Name like '"+TxtSearchItem.Text+"%'";
            query = "select Name from Items where Name like '" + TxtSearchItem.Text + "%'";
            ShowItemList(query);
        }
        private void ShowItemList(string query)
        {
            ItemsListBox.Items.Clear();
            DataSet ds = function.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString() != "") ;
                    ItemsListBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAll();
            string text = ItemsListBox.GetItemText(ItemsListBox.SelectedItem);
            TxtNameItem.Text = text;
            query = "select Price from Items where Name = '"+text+"' ";
            DataSet ds = function.GetData(query);
            try
            {
                TxtPriceItem.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }

        }
        private void ClearAll()
        {
            TxtNameItem.Text = "";
            TxtPriceItem.Text = "";
            TxtQuantity.ResetText();
            LblMsgPrice.ResetText();
        }

        private void TxtQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(TxtQuantity.Value.ToString());
            Int64 price = Int64.Parse(TxtPriceItem.Text);
            LblMsgPrice.Text = (quan*price).ToString();
        }


        protected int n, total = 0;
        int amount;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                amount = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }catch { }

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            //Remove selected item
            try
            {
                DataGridView1.Rows.RemoveAt(this.DataGridView1.SelectedRows[0].Index);


            }catch { }

            //Decreasing total amount
            total -= amount;
            LblFinalPrice.Text = total.ToString();
        }


        //Printing Data
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (TxtCustomerName.Text != "")
            {
                //Saving Customer Details 
                query = "insert into CustomerDetails(Name,Mobile,Email) values('" + TxtCustomerName.Text + "','"+TxtCustomerMobile.Text+"','"+TxtCustomerEmail.Text+"')";
                function.SetData(query);

                //Printing Details
                DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Hot Chilli\n Adampur, Near Aakashwani Chouck Bhagalpur";
                printer.SubTitle = String.Format("----------------------------------------------------------------------------------------------------------------------------" +
                    "\n                                                                      Customer Order Bill\n\nName : {0}\nMobile : " +
                    "{1}\nEmail  : {2}\n-------------------------------------\nPayable amount : {3}\nDate : {4},                                                                                    " +
                    "Time : {4}\n\n", TxtCustomerName.Text, TxtCustomerMobile.Text, TxtCustomerEmail.Text, LblFinalPrice.Text,
                    DateTime.Now.ToString("dd MMMM yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
                //printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                //  printer.PrintPreviewDataGridView(DataGridView1);
                printer.SubTitleAlignment = StringAlignment.Near;

                // printer.PageText = "Total payable amount : " + LblFinalPrice.Text;
                printer.PageNumberInHeader = false;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.PrintMargins = new System.Drawing.Printing.Margins(35, 35, 50, 50);
                printer.Footer = "Total payable amount : " + LblFinalPrice.Text;
                printer.FooterSpacing = 150;
                printer.PrintDataGridView(DataGridView1);
                //Reset 
                total = 0;
                LblFinalPrice.Text = "00.0";
                DataGridView1.Rows.Clear();
                DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            }
            else
            {
                MessageBox.Show("Please enter customer details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //When leave the controle Place order clears fields data
        private void UC_PlaceOrder_Leave(object sender, EventArgs e)
        {
            ClearAll();
            TxtCustomerName.Text = "";
            TxtCustomerMobile.Text = "";
            TxtCustomerEmail.Text = "";
            TxtNameItem.Text = "";
            TxtPriceItem.Text = "";
            TxtSearchItem.Text = "";
            TxtQuantity.ResetText();
            LblMsgPrice.ResetText();
            ComoboCategory.Text = "";
            LblFinalPrice.Text = "00.0";
            ItemsListBox.Items.Clear();
            DataGridView1.Rows.Clear();

        }

        //Clear all fields data
        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            TxtCustomerName.Text = "";
            TxtCustomerMobile.Text = "";
            TxtCustomerEmail.Text = "";
            TxtNameItem.Text = "";
            TxtPriceItem.Text = "";
            TxtSearchItem.Text = "";
            ComoboCategory.Text = "";
            TxtQuantity.ResetText();
            LblMsgPrice.ResetText();
            ItemsListBox.Text = "";
            DataGridView1.Rows.Clear();
            LblFinalPrice.Text = "00.0";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            { //Adding data to DataGrid 
                if (LblMsgPrice.Text != "0" && LblMsgPrice.Text != "")
                {

                    n = DataGridView1.Rows.Add();
                    DataGridView1.Rows[n].Cells[0].Value = TxtNameItem.Text;
                    DataGridView1.Rows[n].Cells[1].Value = TxtPriceItem.Text;
                    DataGridView1.Rows[n].Cells[2].Value = TxtQuantity.Value;
                    DataGridView1.Rows[n].Cells[3].Value = LblMsgPrice.Text;
                    //Calculating total price
                    total += int.Parse(LblMsgPrice.Text);
                    LblFinalPrice.Text = total.ToString();
                }
                else
                {
                    //If Quantity not selected the shows error message
                    MessageBox.Show("Minimum quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch 
            { 
            }
        }
    }
}
