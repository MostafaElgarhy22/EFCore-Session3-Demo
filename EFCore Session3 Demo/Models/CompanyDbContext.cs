using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Session3_Demo.Models
{
    internal class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base()
        {

        }

        public object Departments { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Company;Trusted_Connection=True;");
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}


    

