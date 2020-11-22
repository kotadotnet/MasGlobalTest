using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Employee.Data
{
    public class EmployeeDataService : IEmployeeDataService
    {
        public async Task<List<EmployeeDTO>> GetEmployees(int Id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://masglobaltestapi.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //GET Method  
                var response = await client.GetAsync("api/employees");
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    List<EmployeeDTO> employeeDTO = JsonConvert.DeserializeObject<List<EmployeeDTO>>(responseContent);
                    if (Id != 0)
                        employeeDTO = employeeDTO.Where(e => e.Id == Id).ToList();
                    return employeeDTO;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
