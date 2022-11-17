using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hot_Chile_Restaurant
{
    public partial class Frm_SalesManLogin : Form
    {
        public Frm_SalesManLogin()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
           AdminLoginForm adminLoginForm = new AdminLoginForm();
            this.Close();
            adminLoginForm.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //AdminPanelForm adf = new AdminPanelForm("RetailAssistant");
            //adf.Show();
            //this.Hide();
            if (TxtUID.Text != "")
            {
                LblMsgUID.Visible = false;
                MySqlConnection con = new MySqlConnection("data source  = MySQL Community Server - GPL;integrated security = True;server=localhost;user=root;database=Restaurant;port=3306;password=jinu0292");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from UserDetails where UserID  = '" + TxtUID.Text + "' and Password =  '" + TxtPassword.Text + "'", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if (dataTable.Rows[i]["UserID"].ToString() == TxtUID.Text && dataTable.Rows[i]["Password"].ToString() == TxtPassword.Text)
                        {
                            if (dataTable.Rows[i]["UserType"].ToString() == "SalesMan")
                            {
                                AdminPanelForm adf = new AdminPanelForm("RetailAssistant");
                                adf.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("User not exists...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (dataTable.Rows[i]["UserID"].ToString() != TxtUID.Text)
                        {
                            LblMsgUID.Visible = true;
                        }
                        else
                        {
                            LblMsgPass.Visible = true;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if (dataTable.Rows[i]["UserID"].ToString() != TxtUID.Text)
                        {
                            LblMsgUID.Visible = true;
                        }
                        else
                        {
                            LblMsgPass.Visible = true;
                        }

                    }

                    MessageBox.Show("Invalid credentials...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LblMsgUID.Visible = true;
                LblMsgUID.Text = "Enter user ID.";
            }
        }

        private void TxtUID_Click(object sender, EventArgs e)
        {
            if (LblMsgUID.Visible == true)
                LblMsgUID.Visible = false;
            else
                LblMsgUID.Visible = false;
        }
    }
}
