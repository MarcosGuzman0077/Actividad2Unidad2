using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Actividad2Unidad1.Models;

namespace Actividad2Unidad1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (model.Usuario == "admin" && model.Contrasena == "123456")
            {
                return RedirectToAction("Bienvenido");
            }
            else
            {
                model.Mensaje = "Usuario incorrecto";
                return View(model);
            }
        }

        public ActionResult Bienvenido()
        {
            return Content("Bienvenido");
        }
    }
}