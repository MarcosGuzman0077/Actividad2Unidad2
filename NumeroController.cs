using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Actividad2Unidad1.Models;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroController : Controller
    {
        // GET: Numero
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Verificar(NumeroModel model)
        {
            if (EsPrimo(model.Numero))
            {
                model.Mensaje = $"El número {model.Numero} es primo.";
            }
            else
            {
                model.Mensaje = $"El número {model.Numero} no es primo.";
            }

            return View("Index", model);
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= System.Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}
    
