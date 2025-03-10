﻿using EFCore_Session3_Demo.Data;
using EFCore_Session3_Demo.Models;
using System;

namespace EFCore_Session3_Demo
{
    internal class Program
    {


        static void Main(string[] args)
        {

 #region Loading Navigational Properties
            // using CompanyDbContext context = new CompanyDbContext();
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

        #region 3. Lazy Loading
        #region Example 01


        //var employee = (from E in dbContext.Employees
        //                where E.Code == 1
        //                select E).FirstOrDefault();
        //if (employee is not null)
        //{
        //    DbContext.Entry(employee).Reference(nameof(Employee.Department)).Load(); // Loading Explicitly

        //    Console.WriteLine($"Employee: {employee.Name}, Department: {employee.Department?.Name ?? "No Department"}");
    }
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

#endregion

#region LINQ - Join Operators [Join(), GroupJoing()]

#region Inner Join

//var Result = from D in dbContext.Departments
//             join E in dbContext.Employees
//             on D.DeptId equals E.DepartmentId
//             select new
//             {
//                 EmployeeId = E.Code,
//                 EmployeeName = E.Name,
//                 DepartmentId = D.DeptId,
//                 DepartmentName = D.Name,
//             };

// Result = dbContext.Departments.Join(dbContext.Employees,
//                                     D => D.DeptId,
//                                     E => E.DepartmenId
//                                     (D,E) => new
//                                     {
//                                         EmployeeId = E.Code,
//                                         EmployeeName = E.Name,
//                                         DepartmentId = D.DeptId,
//                                         DepartmentName = D.Name,
//                                     });

//      foreach(var item in Result)
//          Console.Writeline(); 
#endregion

#region Group Join

//var Result = dbContext.Departments.GroupJoin(dbContext.Employees,
//                                             D => D.DeptId,
//                                             E => E.DepartmentId,
//                                            (Department, Employee) => new
//                                            {
//                                                Department,
//                                                Employee
//                                            }).Where(X => X.Employees.Count() > 0);

//   foreach(var item in Result)
//   {
//        Console.WriteLine($"Department: Id = {item.Department.DeptId}, Name = {Item.Department.Name}");
//       foreach(var employee in item.Employees)
//      {
//         Console.WriteLine($".......Employee: Code = {employee.Code}, Name = {employee.Name}");
//      }
//   }

#endregion

#region Left Outer Join

#region Example 01
//var Result = dbContext.Departments.GroupJoin(dbContext.Employees,
//                                             D => D.DeptId,
//                                             E => E.DepartmentId,
//                                            (Department, Employee) => new
//                                            {
//                                                Department,
//                                                Employee = Employees.DfaultEmpty()
//                                            }).SelectMany(X => X.Employees, (X, Employee) => new {X.Depatment, Employee});

//   foreach(var item in Result)
//   {
//        Console.WriteLine($"Department: Id = {item.Department.DeptId}, Name = {Item.Department.Name}");
//   } 
#endregion

#endregion

#region Cross Join

//var Result = dbContext.Departments.GroupJoin(dbContext.Employees,
//                                             D => D.DeptId,
//                                             E => E.DepartmentId,
//                                            (Department, Employee) => new
//                                            {
//                                                Employee = E,
//                                                Department = D
//                                            };

//   foreach(var item in Result)
//   {
//        Console.WriteLine($"Department: Id = {item.Department.DeptId}, Name = {Item.Department.Name}");
//   } 
#endregion

#endregion

#region View - Mapping
// var Result = dbContext.EmployeesDepartmentsView;
//
//  foreach(var item in Result)
//{
//    Console.WriteLine($"Employee: {IThreadPoolWorkItem.EmployeeName}, Department: {item.DepartmentName}");
//} 
#endregion














