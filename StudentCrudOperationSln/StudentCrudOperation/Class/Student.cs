using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrudOperation.Class
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string FathersName { get; set; }
        public string InstituteName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal CourseFee { get; set; }
        public int CourseId { get; set; }
        public string ImageName { get; set; }
        public byte[] ImageData { get; set; }
    }   
}
