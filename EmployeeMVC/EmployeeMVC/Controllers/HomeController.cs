using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Merhaba";
        }

        public IActionResult Index1()
        {
            return View();
        }
    }
}
