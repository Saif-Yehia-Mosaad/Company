using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        //Navigational Property =>Many
        //public ICollection<Course> Courses { get; set; } = new HashSet<Course>(); //By Convention

        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>(); //Using Fluent APIs
    }
}
