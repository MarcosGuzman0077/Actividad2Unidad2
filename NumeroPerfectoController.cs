using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Actividad2Unidad1.Models;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroPerfectoController : Controller
    {
        // GET: NumeroPerfecto
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verificar(NumeroPerfectoModel model)
        {
            if (EsPerfecto(model.Numero))
            {
                model.Mensaje = $"El número {model.Numero} es perfecto.";
            }
            else
            {
                model.Mensaje = $"El número {model.Numero} no es perfecto.";
            }

            return View("Index", model);
        }

        private bool EsPerfecto(int numero)
        {
            if (numero <= 1) return false;

            int suma = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }

            return suma == numero;
        }
    }
}