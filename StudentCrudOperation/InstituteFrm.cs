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
    public partial class InstituteFrm : Form
        
    {
        
        string constr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public InstituteFrm()
        {
            InitializeComponent();
            LoadDgvInstituteInfo();


        }
        Institute aInstitute = new Institute();
        int instId;

        private void btnInsertInstitute_Click(object sender, EventArgs e)
        {
            int count;
            aInstitute.InstituteName = txtInstituteName.Text;
            using (var con = new SqlConnection(constr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Institute(InstituteName) VALUES" + " ('" + aInstitute.InstituteName + "')";
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count != 0)
                {
                    MessageBox.Show("Data Insert Succfullay");
                }
            }
            LoadDgvInstituteInfo();
            ClearAll();
        }

        private void btnUpdateInstitute_Click(object sender, EventArgs e)
        {
            int count;
            aInstitute.InstituteName = txtInstituteName.Text;
            using (var con = new SqlConnection(constr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Institute SET InstituteName='" + aInstitute.InstituteName + "' Where InstituteId='" + instId + "'";
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count != 0)
                {
                    MessageBox.Show("Data Update Succfullay");
                }
            }
            LoadDgvInstituteInfo();
            ClearAll();
        }


        private void LoadDgvInstituteInfo()
        {
            using (var con = new SqlConnection(constr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT InstituteId, InstituteName FROM Institute";
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr, LoadOption.Upsert);
                con.Close();
                dgvInstituteInfo.DataSource = dt;
                dgvInstituteInfo.RowTemplate.Height = 80;               
            }
        }

        private void dgvInstituteInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellId = e.RowIndex;
            DataGridViewRow row = dgvInstituteInfo.Rows[cellId];
            try
            {
                instId = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                instId = 0;
            }           
            txtInstituteId.Text = row.Cells[0].Value.ToString();
            txtInstituteName.Text = row.Cells[1].Value.ToString();            
        }

        private void btnDeleteInstitute_Click(object sender, EventArgs e)
        {
            int count;
            using (var con = new SqlConnection(constr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Institute WHERE InstituteId='" + instId + "'";
                con.Open();
                count = cmd.ExecuteNonQuery();
                if (count != 0)
                {
                    MessageBox.Show("Data Delete Succfullay");
                }
            }
            LoadDgvInstituteInfo();
            ClearAll();
        }
        

        private void ClearAll()
        {
            txtInstituteId.Text = "";
            txtInstituteName.Text = "";           
        }
    }
}
