using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employee.Models;
using Employee.Business;

namespace Employee.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeBusinessService _employeeBusinessService;
        public HomeController(IEmployeeBusinessService employeeBusinessService)
        {
            _employeeBusinessService = employeeBusinessService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Get(int Id)
        {
            var response = _employeeBusinessService.GetEmployees(Id);
            return View("Index",response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
