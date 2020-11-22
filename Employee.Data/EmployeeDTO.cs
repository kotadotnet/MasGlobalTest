using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Data
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescreption { get; set; }
        public long HourlySalary { get; set; }
        public long MonthlySalary { get; set; }
        public long AnnualSalary { get; set; }
    }
}
