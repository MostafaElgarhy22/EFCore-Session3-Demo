using EFCore_Session3_Demo.Data;
using EFCore_Session3_Demo.Models;
using System;

namespace EFCore_Session3_Demo
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            #region Loading Navigational Properties

            #region Example 01
            //using CompanyDbContext context = new CompanyDbContext();

            //var employee = (from E in dbContext.Employees
            //               where E.Code == 1
            //               select E).FirstOrDefault();
            //if (employee is not null)
            //{
            //    Console.WriteLine($"Employee: {employee.Name}, Department: {employee.Department?.Name ?? "No Department"}");
            //} 
            #endregion

            #region Example 02
            //var department = (from D in dbContext.Departments
            //                 where D.DeptId == 10
            //                 select D).FirstOrDefault();

            //if (department is not null )
            //{
            //    Console.WriteLine($"Department: Id = {department.DeptId}, Name = {department.Name}");

            //    foreach(var employee in department.Employees)
            //    {
            //        Console.WriteLine($"....Employee: Code = {employee.Code}, Name = {employee.Name}");
            //    }
            //} 
            #endregion

            #endregion
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


