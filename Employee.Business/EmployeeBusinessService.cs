using System;
using System.Collections.Generic;
using System.Text;
using Employee.Data;

namespace Employee.Business
{
    public class EmployeeBusinessService : IEmployeeBusinessService
    {
        private IEmployeeDataService _employeeDataService;
        public EmployeeBusinessService(IEmployeeDataService employeeDataService)
        {
            _employeeDataService = employeeDataService;
        }
        public List<EmployeeDTO> GetEmployees(int Id)
        {
            var response = _employeeDataService.GetEmployees(Id).Result;
            foreach (var item in response)
            {
                if (item.ContractTypeName == "HourlySalaryEmployee")
                    item.AnnualSalary = 120 * item.HourlySalary * 12;
                else
                    item.AnnualSalary = item.MonthlySalary * 12;



            }
            return response;
        }
    }
}
