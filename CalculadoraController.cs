using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Actividad2Unidad1.Models;

namespace Actividad2Unidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: Calculadora
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calcular(OperacionModel model)
        {
            switch (model.Operacion)
            {
                case "+":
                    model.Resultado = model.Numero1 + model.Numero2;
                    break;
                case "-":
                    model.Resultado = model.Numero1 - model.Numero2;
                    break;
                case "*":
                    model.Resultado = model.Numero1 * model.Numero2;
                    break;
                case "/":
                    model.Resultado = model.Numero2 != 0 ? model.Numero1 / model.Numero2 : 0;
                    break;
                default:
                    ModelState.AddModelError("", "Operación no válida");
                    break;
            }

            return View("Index", model);
        }
    }
}