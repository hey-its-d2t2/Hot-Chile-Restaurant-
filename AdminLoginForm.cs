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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void LblAdmin_MouseHover(object sender, EventArgs e)
        {
            LblRetailAssistant.ForeColor = Color.FromArgb(254, 35, 31);
        }

        private void LblForgotPass_MouseLeave(object sender, EventArgs e)
        {
            LblRetailAssistant.ForeColor = Color.DarkGray;

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
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
                            if (dataTable.Rows[i]["UserType"].ToString() == "Admin")
                            {
                                AdminPanelForm adf = new AdminPanelForm("admin");
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

        private void LblRetailAssistant_Click(object sender, EventArgs e)
        {
            Frm_SalesManLogin sl = new Frm_SalesManLogin();
            sl.Show();
            this.Close();
          
        }

        private void LblForgotPass_MouseHover(object sender, EventArgs e)
        {
            LblForgotPass.ForeColor = Color.FromArgb(254, 35, 31);
        }

        private void LblForgotPass_MouseLeave_1(object sender, EventArgs e)
        {
            LblForgotPass.ForeColor = Color.DarkGray;

        }

        private void LblForgotPass_Click(object sender, EventArgs e)
        {
            Frm_ForgetPassword fp = new Frm_ForgetPassword();
            this.Hide();
            fp.Show();

        }
    }
}
