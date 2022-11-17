﻿using System;
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
    public partial class Frm_AddUser : Form
    {
        DB_Function function = new DB_Function();
        string query;
        public Frm_AddUser()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            LblMsg_InvalidKey.Visible = false;  

        }
        protected void ClearAll()
        {
            TxtUserName.Text = "";
            TxtUID.Text = "";
            TxtKey.Text = "";
            TxtPassword.Text = "";
            TxtConfPass.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text != "" && TxtKey.Text != "" && TxtUID.Text != "" && TxtPassword.Text != "" && TxtConfPass.Text != "")
            {
                LblPassNotSameMsg.Visible = false;
                LblMsg_InvalidKey.Visible = false;
                if (TxtKey.Text == "0292")
                {
                    LblPassNotSameMsg.Visible = false;
                    if (TxtPassword.Text == TxtConfPass.Text)
                    {
                        try
                        {
                            string usertype = "Admin";
                            query = "insert into UserDetails(Name,UserID,Password,UserType) values ('" + TxtUserName.Text + "','" + TxtUID.Text + "','" + TxtConfPass.Text + "','" + usertype + "')";
                            function.SetData(query, "User added.");
                            ClearAll();
                        }
                        catch
                        {
                            MessageBox.Show(" Try diffrent User Id or Password...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearAll();
                        }
                    }
                    else
                    {
                        LblPassNotSameMsg.Visible = true;
                    }
                }
                else
                {
                    ClearAll();
                    LblMsg_InvalidKey.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Fill proper details...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
            }

        }

        private void TxtConfPass_Click(object sender, EventArgs e)
        {
            LblPassNotSameMsg.Visible = false;
        }
    }
}
