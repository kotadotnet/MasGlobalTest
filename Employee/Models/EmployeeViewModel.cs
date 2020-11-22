using Employee.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class EmployeeViewModel
    {
        [Display(Name = "Employee Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescreption { get; set; }
        public long HourlySalary { get; set; }
        public long MonthlySalary { get; set; }
    }
}
