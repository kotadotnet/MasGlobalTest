using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data
{
    public interface IEmployeeDataService
    {
        Task<List<EmployeeDTO>> GetEmployees(int Id);
    }
}
