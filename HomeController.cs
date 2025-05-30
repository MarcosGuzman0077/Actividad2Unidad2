using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Saludo(string nombre)
        {
            ViewBag.Mensaje = "Hola, " + nombre + ", bienvenido a ASP.NET MVC.";
            return View("Index");
        }
    }
}