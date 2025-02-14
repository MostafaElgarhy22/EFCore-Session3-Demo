using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EFCore_Session3_Demo.Models;

namespace EFCore_Session3_Demo.Data
{
    internal class CompanyDbContextSeed
    {
        public static void Seed(CompanyDbContext dbContext)
        {
            if (!dbContext.Departments.Any())
            {
                var departmentsData = File.ReadAllText("../Data/DataSedd/department.json");
                var departments = JsonSerializer.Deserialize<List<Department>>(departmentsData);

                if (departments?.Count() > 0)
                {
                    foreach (var department in departments)
                    {
                        dbContext.Departments.Add(department);
                    }
                    dbContext.SaveChanges();
                }
            }


        }
    }
}
