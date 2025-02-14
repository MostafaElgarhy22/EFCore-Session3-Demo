using EFCore_Session3_Demo.Data;
using EFCore_Session3_Demo.Models;
using System;

namespace EFCore_Session3_Demo
{
    internal class Program
    {
        private static readonly Models.CompanyDbContext dbContext;

        static void Main(string[] args)
        {
            using CompanyDbContext context = new CompanyDbContext();

          //  CompanyDbContextSeed.Seed(dbContext);
        }
        internal class CompanyDbContext : DbContext, IDisposable
        {
            public void Dispose()
            {
                // Dispose resources here
            }
        }

        internal class DbContext
        {
        }

        

    }
}


