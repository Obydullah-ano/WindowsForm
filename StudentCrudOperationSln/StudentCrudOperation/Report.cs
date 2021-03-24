using StudentCrudOperation.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCrudOperation
{
    public partial class Report : Form
    {
        List<ReportStudentView> list;

        public Report()
        {
        }

        public Report(List<ReportStudentView> objlist)
        {
            InitializeComponent();
            list = objlist;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            StudentInformationReport rpt = new StudentInformationReport();
            rpt.SetDataSource(list);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
