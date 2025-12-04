using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Models;

namespace Company.Configrations
{
    internal class DepartmentConfigrations : IEntityTypeConfiguration<Department>
    {
        #region 4.ConfigrationClass
        //ConfigrationClass Per Entity --> Organize Fluent APIs In Separate Class
        #endregion
        public void Configure(EntityTypeBuilder<Department> E)
        {
            //Fluent APIs For Department Entity
            E.ToTable("Departments", "dbo"); //InstadeOf public DbSet<Department> Departments { get; set; }
            E.HasKey(d => d.DeptId); //Set Primary Key Using Fluent APIs
                                     //E.HasKey("DeptId");   //Other Ways
                                     //E.HasKey(nameof(Department.DeptId));

            E
                .Property(D => D.Name)
                .IsRequired(true)
                .HasColumnType("Varchar")
                .HasColumnName("DepartmentName")
                .HasMaxLength(100)
                .HasDefaultValue("Test");
            //.HasAnnotation("MaxLenth", 50)

            E
                .Property(D => D.DateOfCreation)
                .HasComputedColumnSql("GETDATE()");
        }
    }
}
//See You Tomorrow