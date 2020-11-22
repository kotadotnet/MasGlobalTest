using Employee.Data;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Employee.Business.UnitTests
{

    public class EmployeeBusinessServiceTests
    {
        Mock<IEmployeeDataService> _employeeDataService;
        EmployeeBusinessService employeeBusinessService;
        public EmployeeBusinessServiceTests()
        {
            _employeeDataService = new Mock<IEmployeeDataService>();
            employeeBusinessService = new EmployeeBusinessService(_employeeDataService.Object);
        }
        [Fact]
        public void GetEmployees_return_type_validate()
        {
            //arrange

            int empId = 1;
            _employeeDataService.Setup(repo => repo.GetEmployees(empId))
              .Returns(this.GetEmployees(empId));
            //Act
            var response = employeeBusinessService.GetEmployees(empId);

            //assert
            var result = Assert.IsType<List<EmployeeDTO>>(response);
        }

        private async Task<List<EmployeeDTO>> GetEmployees(int Id)
        {
            string data = "[\r\n  {\r\n    \"id\": 1,\r\n    \"name\": \"Juan\",\r\n    \"contractTypeName\": \"HourlySalaryEmployee\",\r\n    \"roleId\": 1,\r\n    \"roleName\": \"Administrator\",\r\n    \"roleDescription\": null,\r\n    \"hourlySalary\": 60000,\r\n    \"monthlySalary\": 80000\r\n  },\r\n  {\r\n    \"id\": 2,\r\n    \"name\": \"Sebastian\",\r\n    \"contractTypeName\": \"MonthlySalaryEmployee\",\r\n    \"roleId\": 2,\r\n    \"roleName\": \"Contractor\",\r\n    \"roleDescription\": null,\r\n    \"hourlySalary\": 60000,\r\n    \"monthlySalary\": 80000\r\n  }\r\n]";
            return JsonConvert.DeserializeObject<List<EmployeeDTO>>(data);
        }
    }
}
