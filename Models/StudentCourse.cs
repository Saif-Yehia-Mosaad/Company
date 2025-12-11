using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    internal class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }
    }
}
#region Navigation Properties
//not nessesary but good for navigation
//Navigation Properties => Many-to-Many Relationship
//public Student Student { get; set; }
//        public Course Course { get; set; }
#endregion