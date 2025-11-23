using System;
using System.IO;
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
            optionsBuilder.UseSqlServer("Server=DESKTOP-0MDMFGG\\MSSQLSERVER04;Database=Company;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        }
        /// <summary>
        ///If You Face This Error: A connection was successfully established with the server, but then an error occurred during the login process. (provider: SSL Provider, error: 0 - The certificate chain was issued by an authority that is not trusted.)
        ///Add This To Your Connection String : Encrypt=True;TrustServerCertificate=True;
        /// </summary>
