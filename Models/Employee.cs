using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

///poco class 
///plain old clr object (don't contain any functionality or behaviors )

namespace Company.Models
{
    [Table("Employees" , Schema ="dbo")] //Using To Rename Classes And Select A Specific Schema
    internal class Employee
    {
        ///EF support 4 ways for mapping classes to database(Table, viwe, function)

        #region 1.By Convention
        /////1.by convention(default behavior)
        /////public int Id { get; set; } //public numeric property named as "Id" | "EmployeeId --> pk[Use Identity(1,1)]
        ///// ? => Nullable
        /////public string? Name { get; set; } //reference type :alow null[optional]
        /////public string Salary { get; set; } // value type : not allow null[required]
        /////public int? Age { get; set; } //Nullable<int> : alow null[optional]
        /////Add New Column
        /////public int Adress { get ; set; } // New Property Added
        #endregion

        #region 2.data annotations
        ///2.Data Annotations (Set Of Attributes Use For Data Validation)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //(1,1)
        public int EmpId { get; set; }
        ///[Required]
        ///[Column(TypeName = "varchar(100)")]
        ///[MaxLength(100)]
        ///[StringLength(100, MinimumLength = 10)]
        public string? Name { get; set; } //reference type :alow null[optional]
        ///[AllowNull]
        ///in the app it will be required but in the db it will allow null
        ///[DataType(DataType.Currency)]
        ///it change only the way of displaying data not the data type in the db from double to money
        public double Salary { get; set; } // value type : not allow null[required]
        [Range(18, 65)]
        public int? Age { get; set; } //Nullable<int> : alow null[optional]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [NotMapped] //ignore this property
        [Phone]
        public string PhoneNumber { get; set; }
        [NotMapped] //it will not create column in the db
        [DataType(DataType.Password)] //frontend validation 
        public string Password { get; set; }
        #endregion

        #region 3.Fluent APIs
        //3.Fluent APIs (In OnModelCreating Method In DbContext Class)
        #endregion

        #region 4.ConfigrationClass
        //ConfigrationClass Per Entity --> Organize Fluent APIs In Separate Class
        #endregion

        public Department Department { get; set; } //Navigation Property To Represent Relationship Between Employee And Department => Each Employee Belong To One Department

    }
}
