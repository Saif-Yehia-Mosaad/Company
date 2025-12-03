using System;
using System.Collections.Generic;
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
        public ICollection<Employee> Employees { get; set; } //Navigation Property To Represent Relationship Between Department And Employee => Each Department Has Many Employees

        public Department() //Constructor
        {
            Employees = new List<Employee>();
        }
    }
}

//IEnumerable => Used To Represent Collection Of Items That Can Be Iterated Over Can't Be Modified Directly
//ICollection => Used To Represent Collection Of Items That Can Be Iterated Over And Can Be Modified Directly (Add, Remove)


