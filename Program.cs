using Company.Context;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
         CompanyDbContext dbContext = new CompanyDbContext();

            //dbContext.Employees.Where(E => E.Id == 1); Linq

        }
    }
}
