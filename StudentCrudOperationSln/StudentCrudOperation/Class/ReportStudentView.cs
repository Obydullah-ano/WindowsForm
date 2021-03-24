using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrudOperation.Class
{
    public class ReportStudentView
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string FathersName { get; set; }
        public string InstituteName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Decimal CourseFee { get; set; }
        public int CourseId { get; set; }
        //public string CourseName { get; set; }
        //public byte[] ImageData { get; set; }
    }
}
