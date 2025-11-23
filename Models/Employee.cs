using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models

    ///EF support 4 ways for mapping classes to database(Table, viwe, function)
    ///1.by convention(default behavior)

///2.Data Annotations (Set Of Attributes)

    ///poco class
    ///plain old clr object (don't contain any functionality or behaviors )
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //(1,1)
        public int EmpId { get; set; }
        public string? Name { get; set; } //reference type :alow null[optional]
        public string Salary { get; set; } // value type : not allow null[required]
        public int? Age { get; set; } //Nullable<int> : alow null[optional]
        public int Adress { get ; set; } // New Property Added
    }
}
