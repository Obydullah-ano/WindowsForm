using StudentCrudOperation.Class;
using System;
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
    public partial class Login : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }
        private void btnRegisterWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }
        private void btnCreateLogin_Click(object sender, EventArgs e)
        {
            string query = "Select * from Login_tbl where userName='" + txtEnterUserName.Text.Trim() + "' and passWord='" + txtEnterPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, constr);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count==1)
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }            

        }
    }
}
