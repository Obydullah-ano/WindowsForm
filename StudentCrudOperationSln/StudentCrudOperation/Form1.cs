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
    public partial class Form1 : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            HideSubmenu();
        }

        private void HideSubmenu()
        {
            subMenuPanel.Visible = false;
        }
        private void ShowSubMenuPanel()
        {
            if (subMenuPanel.Visible == false)
            {
                HideSubmenu();
                subMenuPanel.Visible = true;
            }
            else
            {
                subMenuPanel.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel();
        }
        private Form activeForm = null;
        private void OpenChiledFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(childForm);
            contentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenChiledFormInPanel(new Login());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rgt = new Register();
            rgt.Show();           
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {           
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {          
        }

        private void btnReport_Click(object sender, EventArgs e)
        {            
            List<ReportStudentView> list = new List<ReportStudentView>();
            using (var con = new SqlConnection(constr))
            {                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Id, StudentName, FathersName, InstituteName, DateOfBirth, CourseFee, Course.CourseId, ImageData FROM Student join Course on Student.CourseId=Course.CourseId";
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr, LoadOption.Upsert);

                ReportStudentView obj;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    obj = new ReportStudentView();
                    obj.Id = Convert.ToInt32(dt.Rows[i]["Id"].ToString());
                    obj.StudentName = dt.Rows[i]["StudentName"].ToString();
                    obj.FathersName = dt.Rows[i]["FathersName"].ToString();
                    obj.InstituteName = dt.Rows[i]["InstituteName"].ToString();
                    obj.DateOfBirth = Convert.ToDateTime(dt.Rows[i]["DateOfBirth"].ToString());
                    obj.CourseFee = Convert.ToDecimal(dt.Rows[i]["CourseFee"].ToString());
                    obj.CourseId = Convert.ToInt32(dt.Rows[i]["CourseId"].ToString());
                    list.Add(obj);
                }
            }
            using (Report frm = new Report(list))
            {
                frm.ShowDialog();
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            OpenChiledFormInPanel(new StudentCrudFrm());
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            OpenChiledFormInPanel(new StudentCrudFrm());
        }

        private void btnCourse_Click_1(object sender, EventArgs e)
        {
        }
    }
}
