using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Models;
using System.Net.Sockets;
using LinkDev;
using Company.Configrations;

namespace Company.Context
{
    internal class CompanyDbContext : DbContext //inherait from class Dbcontext
    {

        #region Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0MDMFGG\\MSSQLSERVER04;Database=Company;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        }
        #endregion

        #region Fluent APIs
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure Department Entity Using Fluent API Configrations Class
            modelBuilder.ApplyConfiguration(new DepartmentConfigrations());
            base.OnModelCreating(modelBuilder);
        }
        #endregion
        public DbSet<Employee> Employees { get; set; }//Mapping Class As A Table In Db by convention
        

    }
 }  
#region My Comments
///Add-Migration RenameEmployeeNameCoulmn Use This Command In Package Manager Console To Create Migration For Rename Column For Example
///If You Want To Revert Applied Migration Use: PM> Update-Database -Migration InitialCreate
///Use Update-Database command to apply this migration to the database
///After Reverting Migration You Can Delete The Unwanted Migration File Manually Or Using Command Remove-Migration 
///If I Wanna Revert First Migration Use: Update-Database 0 This Is A Special Command To Revert All Migrations  
///If I Wanna Add New Column To Employee Class Use: Add-Migration AddEmployeeAdressColumn For Example */

///If you want to remove a migration that is not the latest one:
///Make the required code changes And I removed the line that declared the DbSet<Class> property, then create a new migration (Add-Migration).
///The tooling will remove the old migration and generate a new one reflecting your changes

/// <summary>
///If You Face This Error: A connection was successfully established with the server, but then an error occurred during the login process. (provider: SSL Provider, error: 0 - The certificate chain was issued by an authority that is not trusted.)
///Add This To Your Connection String : Encrypt=True;TrustServerCertificate=True;
/// </summary>
#endregion