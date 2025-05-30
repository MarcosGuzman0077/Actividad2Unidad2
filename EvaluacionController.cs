using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Actividad2Unidad1.Models;

namespace Actividad2Unidad1.Controllers
{
    public class EvaluacionController : Controller
    {
        // GET: Evaluacion
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calcular(EvaluacionModel model)
        {
            model.Promedio = (model.Calificacion1 + model.Calificacion2 + model.Calificacion3 + model.Calificacion4) / 4.0;

            if (model.Promedio >= 70)
                model.Estado = "Aprobado";
            else if (model.Promedio >= 60)
                model.Estado = "En recuperación";
            else
                model.Estado = "Reprobado";

            return View("Index", model);
        }
    }
}