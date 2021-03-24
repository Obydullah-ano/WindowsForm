using StudentCrudOperation.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentCrudOperation
{
    public partial class StudentCrudFrm : Form
    {
        string CourseName;
        int CoId = 0;
        int StudId = 0;
        string imgLocation="";
        


        string constr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public StudentCrudFrm()
        {
            InitializeComponent();
           
        }
        private void UpdateAndDeleteFrm_Load(object sender, EventArgs e)
        {
            LoaddgVStudentUpdateDeletetInfo();
            LoadcmbCourseName();
        }
        private void LoadcmbCourseName()
        {
            using (var con = new SqlConnection(constr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Course";
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr, LoadOption.Upsert);
                con.Close();
                cmbCourseName.ValueMember = "CourseId";
                cmbCourseName.DisplayMember = "CourseName";
                cmbCourseName.DataSource = dt;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int count;
            Student obj = new Student();
            obj.StudentName = txtStudentName.Text;
            obj.FathersName = txtFatherName.Text;
            obj.InstituteName = cmbInstituteName.Text;
            obj.DateOfBirth = Convert.ToDateTime(dateTimeDateOfBirth.Text);
            obj.CourseFee = Convert.ToDecimal(txtCourseFee.Text);
            obj.CourseId = Convert.ToInt32(cmbCourseName.SelectedValue.ToString());
            obj.ImageName = imgLocation;
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brdr = new BinaryReader(stream);
            images = brdr.ReadBytes((int)stream.Length);
            obj.ImageData = images;

            using (var con = new SqlConnection(constr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Student(StudentName, FathersName, InstituteName, DateOfBirth,CourseFee,CourseId, ImageName, imageData) VALUES" +
                    " ('" + obj.StudentName + "', '" + obj.FathersName + "','" + obj.InstituteName + "','" + obj.DateOfBirth + "','" + obj.CourseFee + "','" + obj.CourseId + "','" + obj.ImageName + "',@img)";
                cmd.Parameters.Add(new SqlParameter("@img", obj.ImageData));
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count != 0)
                {
                    MessageBox.Show("Data Insert Succfullay");
                }
            }
            LoaddgVStudentUpdateDeletetInfo();
            ClearAll();
        }

        private void ClearAll()
        {
            txtStudentName.Text = "";
            txtFatherName.Text = "";
            cmbInstituteName.Text = "";
            dateTimeDateOfBirth.Text = "";
            txtCourseFee.Text = "";          
        }
        private void LoaddgVStudentUpdateDeletetInfo()
        {
            using (var con = new SqlConnection(constr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Id, StudentName, FathersName, InstituteName, CourseName, DateOfBirth, CourseFee, Course.CourseId, ImageName, ImageData FROM Student join Course on Student.CourseId=Course.CourseId";
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr, LoadOption.Upsert);
                con.Close();
                dgvStudentCrud.DataSource = dt;
                dgvStudentCrud.RowTemplate.Height = 80;
                DataGridViewImageColumn image = new DataGridViewImageColumn();
                image = (DataGridViewImageColumn)dgvStudentCrud.Columns[9];
                image.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }
        private void dgvUpdateDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellId = e.RowIndex;
            DataGridViewRow row = dgvStudentCrud.Rows[cellId];            
            try
            {
                StudId = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                StudId = 0;
            }
            try
            {
                CoId = Convert.ToInt32(row.Cells[7].Value.ToString());
            }
            catch (Exception)
            {
                CoId = 0;
            }
            txtStudentName.Text = row.Cells[1].Value.ToString();
            txtFatherName.Text = row.Cells[2].Value.ToString();
            cmbInstituteName.Text = row.Cells[3].Value.ToString();
            cmbCourseName.SelectedValue = CoId;
            txtCourseName.Text = row.Cells[4].Value.ToString();
            dateTimeDateOfBirth.Text = row.Cells[5].Value.ToString();
            txtCourseFee.Text = row.Cells[6].Value.ToString();
            txtCourseId.Text = row.Cells[7].Value.ToString();
            byte[] data = (byte[])row.Cells[9].Value;
            MemoryStream stream = new MemoryStream(data);
            pictureBoxStudentPhoto.Image = Image.FromStream(stream);
            pictureBoxStudentPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }    
        private void dgvUpdateDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        } 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            int count = 0;           
            obj.ImageName = imgLocation;
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brdr = new BinaryReader(stream);
            images = brdr.ReadBytes((int)stream.Length);
            obj.ImageData = images;
            obj.StudentName = txtStudentName.Text;
            obj.FathersName = txtFatherName.Text;
            obj.InstituteName = cmbInstituteName.Text;            
            obj.DateOfBirth = Convert.ToDateTime(dateTimeDateOfBirth.Text);
            obj.CourseFee = Convert.ToDecimal(txtCourseFee.Text);
            obj.CourseId = Convert.ToInt32(cmbCourseName.SelectedValue.ToString());            

            using (var con = new SqlConnection(constr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Student SET StudentName='" + obj.StudentName + "', FathersName='" + obj.FathersName + "', InstituteName='" + obj.InstituteName + "', " + " DateOfBirth='" + obj.DateOfBirth + "',CourseFee='" + obj.CourseFee + "',CourseId='" + obj.CourseId + "', ImageName='" + obj.ImageName + "', ImageData=@img Where id='" + StudId + "'";
                cmd.Parameters.Add(new SqlParameter("@img", obj.ImageData));
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Data Update Succfullay");
                }
            }
            LoaddgVStudentUpdateDeletetInfo();
            ClearAll();
            StudId = 0;
        }        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(constr))
            {
                int count = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Student WHERE id='" + StudId + "'";
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Data deleted Succfullay");
                }
            }
            LoaddgVStudentUpdateDeletetInfo();
            ClearAll();
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                imgLocation = d.FileName.ToString();
                pictureBoxStudentPhoto.ImageLocation = imgLocation;
                pictureBoxStudentPhoto.SizeMode = PictureBoxSizeMode.StretchImage;               
            }
        }

        private void btnInsertCourse_Click(object sender, EventArgs e)
        {
            int count;            
            CourseName = txtCourseName.Text;
            using (var con = new SqlConnection(constr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Course(CourseName) VALUES" + " ('" +CourseName + "')";                
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count != 0)
                {
                    MessageBox.Show("Data Insert Succfullay");
                }
            }
            LoaddgVStudentUpdateDeletetInfo();
            ClearAll();
        }
        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            int count;
            CourseName = txtCourseName.Text;
            using (var con = new SqlConnection(constr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Course SET CourseName='" + CourseName + "' Where CourseId='" + CoId + "'";                
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count != 0)
                {
                    MessageBox.Show("Data Insert Succfullay");
                }
            }
            LoaddgVStudentUpdateDeletetInfo();
            ClearAll();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            int count;
            using (var con = new SqlConnection(constr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Course WHERE CourseId='" + CoId + "'";               
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count != 0)
                {
                    MessageBox.Show("Data Delete Succfullay");
                }
            }
            LoaddgVStudentUpdateDeletetInfo();
            ClearAll();
        }

        private void btnReportView_Click(object sender, EventArgs e)
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
    }    
}
