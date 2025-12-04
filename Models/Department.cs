using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }


        //Navigation Property To Represent Relationship Between Department And Employee => Each Department Has Many Employees
        //Use it when you have multiple relationships between two entities to specify which navigation property corresponds to which foreign key
        [InverseProperty("Department")]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); 


        //public Department() //Constructor
        //{
        //    Employees = new HashSet<Employee>();
        //}
    }
}

//IEnumerable => Used To Represent Collection Of Items That Can Be Iterated Over Can't Be Modified Directly
//ICollection => Used To Represent Collection Of Items That Can Be Iterated Over And Can Be Modified Directly (Add, Remove)
//HashSet => Implementation Of ICollection That Represents A Set Of Unique Items (No Duplicates Allowed)


