using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System.Collections.Generic;

namespace SalesWebMVC.Controllers
{
    public class Departments : Controller
    {
        public IActionResult Index() // mesmo nome da view
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });
            
            return View(list); // mandando dados do controller para view
        }
    }
}
