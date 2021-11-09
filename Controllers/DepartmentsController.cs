using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;

namespace VendasWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> listDept = new List<Department>();

            listDept.Add(new Department { Id = 1, Nome = "Eletrônicos" });
            listDept.Add(new Department { Id = 2, Nome = "Moda" });

            return View(listDept);
        }
    }
}
