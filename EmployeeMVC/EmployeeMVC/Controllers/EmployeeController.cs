using EmployeeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        // three differend kind of implementing this employee-repo-view relation below.

        public IActionResult Index()
        {
            IEmployeeRepository repo = new EmployeeRepository();
            return View("Index", repo.GetEmployees());
        }
        public IActionResult IndexByAnnotation([FromServices] IEmployeeRepository repo)
        {

            return View("Index", repo.GetEmployees());
        }
        public IActionResult IndexByDI() // used dependenCy injection as DI
        {

            return View("Index", _repo.GetEmployees());
        }
    }
}
