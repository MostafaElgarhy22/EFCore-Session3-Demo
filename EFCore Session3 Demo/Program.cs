using EFCore_Session3_Demo.Data;
using EFCore_Session3_Demo.Models;
using System;

namespace EFCore_Session3_Demo
{
    internal class Program
    {


        static void Main(string[] args)
        {
            using CompanyDbContext context = new CompanyDbContext();
            #region Loading Navigational Properties

        #region 1. Explicit Loading


            #region Example 01


            //var employee = (from E in dbContext.Employees
            //                where E.Code == 1
            //                select E).FirstOrDefault();
            //if (employee is not null)
            //{
            //    DbContext.Entry(employee).Reference(nameof(Employee.Department)).Load(); // Loading Explicitly

            //    Console.WriteLine($"Employee: {employee.Name}, Department: {employee.Department?.Name ?? "No Department"}");
        }
        #endregion

        #region Example 02
        //var department = (from D in dbContext.Departments
        //                 where D.DeptId == 10
        //                 select D).FirstOrDefault();

        //if (department is not null )
        //{
        //    Console.WriteLine($"Department: Id = {department.DeptId}, Name = {department.Name}");

        //    dbContext.Entry(department).Reference(nameof(Department.Employees)).Load(); // Loading Explicitly

        //    foreach(var employee in department.Employees)
        //    {
        //        Console.WriteLine($"....Employee: Code = {employee.Code} Name = {employee.Name}");
        //    }
        //} 
        #endregion
        #endregion

        #region 2. Eager Loading

        #region Example 01
        //var employee = (from E in dbContext.Employees.Include(E => E.Department)   // we have also (ThenInclude)
        //                where E.Code == 1
        //                select E).FirstOrDefault();
        //if (employee is not null)
        //{
        //    DbContext.Entry(employee).Reference(nameof(Employee.Department)).Load(); // Loading Explicitly

        //    Console.WriteLine($"Employee: {employee.Name}, Department: {employee.Department?.Name ?? "No Department"}"); 
        #endregion

        #region Example 02

        //var department = (from D in dbContext.Departments.Include(D => D.Employees)
        //                 where D.DeptId == 10
        //                 select D).FirstOrDefault();

        //if (department is not null )
        //{
        //    Console.WriteLine($"Department: Id = {department.DeptId}, Name = {department.Name}");

        //    dbContext.Entry(department).Reference(nameof(Department.Employees)).Load(); // Loading Explicitly

        //    foreach(var employee in department.Employees)
        //    {
        //        Console.WriteLine($"....Employee: Code = {employee.Code} Name = {employee.Name}");
        //    }
        //} 
        #endregion
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




