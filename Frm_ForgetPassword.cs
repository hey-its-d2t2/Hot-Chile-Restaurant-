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
    public partial class Frm_ForgetPassword : Form
    {
        DB_Function function = new DB_Function();
        string query;
        public Frm_ForgetPassword()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            AdminLoginForm lf = new AdminLoginForm();
            this .Close();
            lf.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
          
            if (TxtUID.Text != "")
            {
                LblMsgUID.Visible = false;
                MySqlConnection con = new MySqlConnection("data source  = MySQL Community Server - GPL;integrated security = True;server=localhost;user=root;database=Restaurant;port=3306;password=jinu0292");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from UserDetails where UserID  = '" + TxtUID.Text + "' ", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if (dataTable.Rows[i]["UserID"].ToString() == TxtUID.Text)
                        {
                            if (dataTable.Rows[i]["UserType"].ToString() == "Admin" || dataTable.Rows[i]["UserType"].ToString() == "SalesMan")
                            {
                                if (TxtPassword.Text == TxtConfPass.Text)
                                {
                                    try
                                    {
                                        query = "update UserDetails set Password = '" + TxtConfPass.Text + "' where UserID = '" + TxtUID.Text + "'";
                                        function.SetData(query, "Details updated.");
                                        AdminLoginForm alf = new AdminLoginForm();
                                        this.Close();
                                        alf.Show();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Try diffrernt password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        TxtUID.Text = "";
                                        TxtPassword.Text = "";
                                        TxtConfPass.Text = "";
                                    }
                                }
                                else
                                {
                                    LblPassNotSameMsg.Visible = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not exists...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                TxtUID.Text = "";
                                TxtPassword.Text = "";
                                TxtConfPass.Text = "";
                            }
                        }
                        else if (dataTable.Rows[i]["UserID"].ToString() != TxtUID.Text)
                        {
                            LblMsgUID.Visible = true;
                        }
                        else
                        {
                            LblPassNotSameMsg.Visible = true;
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
                            LblPassNotSameMsg.Visible = true;
                        }

                    }

                    MessageBox.Show("Invalid credentials..."+Environment.NewLine+"Or User not exists...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUID.Text = "";
                    TxtPassword.Text = "";
                    TxtConfPass.Text = "";
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
