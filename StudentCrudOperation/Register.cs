using StudentCrudOperation.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCrudOperation
{
    public partial class Register : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public Register()
        {
            InitializeComponent();
        }

        private void btnLoginWindo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void btnCreateRegister_Click(object sender, EventArgs e)
        {
            int count;
            Login_tbl obj = new Login_tbl();

            using (var con = new SqlConnection(constr))
            {
                if (txtCreateUserName.Text == "" && txtCreatePassword.Text == "")
                {
                    MessageBox.Show("Fill up username and password");
                }
                else
                {                    
                    if (txtCreateUserName.Text == "")
                    {
                        MessageBox.Show("insert your username");                       
                    }
                    else
                    {
                        if (txtCreatePassword.Text == "")
                        {
                            MessageBox.Show("Insert your password ");
                        }
                        else
                        {
                            obj.userName = txtCreateUserName.Text;
                            obj.passWord = txtCreatePassword.Text;
                            using (var cons = new SqlConnection(constr))
                            {
                                SqlCommand cmd = cons.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "INSERT INTO Login_tbl(userName, passWord) VALUES" +
                                    " ('" + obj.userName + "', '" + obj.passWord + "')";
                                cons.Open();
                                count = cmd.ExecuteNonQuery();
                                if (count > 0)
                                {
                                    MessageBox.Show("Data Insert successfully");
                                }
                            }
                        }
                    }                    
                }              
            }                          
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
