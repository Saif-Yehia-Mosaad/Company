using Company.Context;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.IO;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
         CompanyDbContext dbContext = new CompanyDbContext();



        }
    }
}

///dbContext.Employees.Where(E => E.Id == 1); Linq

///dbContext.Database.EnsureDeleted();//If Exist Delete It
///          // ===>This Way Isn't Effective Anymore Because In This Way Any Change Affect In Whole Data 
///dbContext.Database.EnsureCreated();//If Not Exist Create It
///But In
///Migration Use To Make Manipulating Whith Db Consistence And  Apply Changes Without Affect On Existing Data More Effective Than Enshure

///dbContext.Database.Migrate();//Apply All Migration That Not Applied Yet