using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session3_Demo.Models
{
    public class EmployeesDepartmentsView
    {
        public int EmployeeCode { get; set; }
        public string EmployeeName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
    }
}
