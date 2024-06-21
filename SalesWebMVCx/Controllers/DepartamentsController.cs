using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWebMVCx.Models;
using SalesWebMVCx.Models.ViewModels;

namespace SalesWebMVCx.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "Eletronics" });
            list.Add(new Departament { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
