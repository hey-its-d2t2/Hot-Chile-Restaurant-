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

namespace Hot_Chile_Restaurant
{
    public partial class Frm_ViewDelCustomerData : Form
    {
        DB_Function function = new DB_Function();
        string query;
        public Frm_ViewDelCustomerData()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ViewDelCustomerData_Load(object sender, EventArgs e)
        {
            query = "select * from CustomerDetails";
            DataSet ds2 = function.GetData(query);
            DataGridView1.DataSource = ds2.Tables[0];
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
           

            //Printing Details
            DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Hot Chilli\n Adampur, Near Aakashwani Chouck Bhagalpur";
            printer.SubTitle = String.Format("----------------------------------------------------------------------------------------------------------------------------" +
                "\n                                                                      All Customer Details\n\nDate : {0},                                                                                    " +
                "Time : {1}\n\n", DateTime.Now.ToString("dd MMMM yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            //  printer.PrintPreviewDataGridView(DataGridView1);
            printer.SubTitleAlignment = StringAlignment.Near;

            // printer.PageText = "Total payable amount : " + LblFinalPrice.Text;
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintMargins = new System.Drawing.Printing.Margins(35, 35, 50, 50);
            printer.Footer = "Devloped by : Developers.02.92, Email:devlopers.02.92@gmail.com";
            printer.FooterSpacing = 80;
            printer.PrintDataGridView(DataGridView1);
            //Reset 
            //DataGridView1.Rows.Clear();
            DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete item.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from CustomerDetails where Id = " + id + "";
                function.SetData(query, "User deleted.");
                Frm_ViewDelCustomerData_Load(this, null);
            }
        }
    }
}
