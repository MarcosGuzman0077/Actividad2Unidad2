using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Actividad2Unidad1.Models;

namespace Actividad2Unidad1.Controllers
{
    public class MonedaController : Controller
    {
        // GET: Moneda
        public ActionResult Index()
        {
            return View(new MonedaModel());
        }

        [HttpPost]
        public ActionResult Index(MonedaModel model)
        {
            decimal tasa = 0;

            switch (model.DivisaDestino)
            {
                case "USD":
                    tasa = 58.00m; // 1 USD = 58 DOP (ficticio)
                    break;
                case "EUR":
                    tasa = 63.00m; // 1 EUR = 63 DOP (ficticio)
                    break;
                default:
                    model.Mensaje = "Seleccione una divisa válida.";
                    return View(model);
            }

            model.Resultado = model.MontoDOP / tasa;
            model.Mensaje = $"El monto en {model.DivisaDestino} es {model.Resultado:F2}";
            return View(model);
        }
    }
}