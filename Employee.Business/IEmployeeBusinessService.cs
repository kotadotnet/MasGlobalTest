using Employee.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Business
{
    public interface IEmployeeBusinessService
    {
        List<EmployeeDTO> GetEmployees(int Id);
    }
}
