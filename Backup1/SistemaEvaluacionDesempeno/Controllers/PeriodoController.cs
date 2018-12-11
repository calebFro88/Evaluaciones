using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaEvaluacionDesempeno.Controllers
{
    public class PeriodoController : Controller
    {
        // GET: Periodo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CrearNuevo()
        {

            return Json(true);
        }

        [HttpPost]
        public JsonResult Eliminar()
        {

            return Json(true);
        }

        [HttpPost]
        public JsonResult Editar()
        {

            return Json(true);
        }
    }
}