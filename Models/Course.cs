using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //Navigational Property =>Many
        //public ICollection<Student> Students { get; set; } = new HashSet<Student>(); //By Convention

        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>(); //Using Fluent APIs
    }
}
