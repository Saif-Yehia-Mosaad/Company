using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Models;


namespace Company.Context
{
    internal class CompanyDbContext : DbContext //inherait from class Dbcontext
    {

        //connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =. ;Database = Company; Trusted_Connection =True" );
        }

        public DbSet<Employee> Employees { get; set; } //Mapping Class As A Table In DB
    }
}
   