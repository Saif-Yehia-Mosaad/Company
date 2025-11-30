using Company.Context;
using Company.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;
using System.Runtime.CompilerServices;
 
namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();

            #region Insert
            //Employee E01 = new Employee()
            //{
            //    Name = "John Doe",
            //    Salary = 60000,
            //    Age = 30,
            //    EmailAddress = "saif58@gmail.com"
            //};

            //Employee E02 = new Employee()
            //{
            //    Name = "Saif Doe",
            //    Salary = 60000,
            //    Age = 30,
            //    EmailAddress = "sisi58@gmail.com"
            //};
            //Console.WriteLine(dbContext.Entry(E01).State); //Detached State

            //dbContext.Employees.Add(E01);
            //dbContext.Employees.Add(E02);//Add To Context In Added State

            //Console.WriteLine(dbContext.Entry(E01).State); //Added State


            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(E01).State); //Unchanged State
            #endregion

            #region Select

            //var employee = (from E in dbContext.Employees  //Select Using Linq Query Syntax
            //                where E.EmpId == 8
            //                select E).FirstOrDefault(); 
            //Console.WriteLine(employee?.Name?? "NA"); //select top1


            //var employee = (from E in dbContext.Employees  //Select Using Linq Query Syntax
            //                where E.EmpId == 8
            //                select E).SingleOrDefault(); 

            //Console.WriteLine(employee?.Name?? "NA"); //select top2 
            #endregion

            #region Update

            //var employee = (from E in dbContext.Employees  //Select Using Linq Query Syntax
            //                where E.EmpId == 8
            //                select E).FirstOrDefault();

            //Console.WriteLine(dbContext.Entry(employee).State);//Unchanged

            //employee.Name = "Hamada";

            //Console.WriteLine(dbContext.Entry(employee).State);//Modified

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(employee).State);//Unchanged
            #endregion`

            #region Delete

            //var employee = (from E in dbContext.Employees  //Select Using Linq Query Syntax
            //                where E.EmpId == 12
            //                select E).FirstOrDefault();
            //var employee2 = (from E in dbContext.Employees  //Select Using Linq Query Syntax
            //                where E.EmpId == 13
            //                select E).FirstOrDefault();

            //Console.WriteLine(dbContext.Entry(employee).State);//Unchanged

            //dbContext.Employees.Remove(employee);
            //dbContext.Employees.Remove(employee2);
          
            //Console.WriteLine(dbContext.Entry(employee).State);//Deleted

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(employee).State);//Detached

            #endregion

        }
    }
}

#region My Comments
///dbContext.Employees.Where(E => E.Id == 1); //Linq
///dbContext.Set<Employee>(); //Ef Core Way To Get DbSet Used In Data Annotations Way

///dbContext.Database.EnsureDeleted();//If Exist Delete It
///          // ===>This Way Isn't Effective Anymore Because In This Way Any Change Affect In Whole Data 
///dbContext.Database.EnsureCreated();//If Not Exist Create It
///But In
///Migration Use To Make Manipulating Whith Db Consistence And  Apply Changes Without Affect On Existing Data More Effective Than Enshure

///dbContext.Database.Migrate();//Apply All Migration That Not Applied Yet

//"Throw exception"(or throw exception) means forcing your program to stop normal execution and report an error.

//In simple words:

//👉 You tell the program: “Something went wrong—stop and send an error message.”

#region AnotherWay Intade Of using "using" Statement
//CompanyDbContext dbContext = new CompanyDbContext(); //Open Connection
//try
//{
////CRUD operation

//}
//finally 
//{
////Close | Dispose Database Connection
//dbContext.Dispose();
//}
#endregion
#endregion