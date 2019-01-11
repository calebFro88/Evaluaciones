using SistemaEvaluacionDesempeno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaEvaluacionDesempeno.Controllers
{
    public class ReporteGeneralController : Controller
    {
        EvaluacionEntities BDEv = new Models.EvaluacionEntities();
        // GET: ReporteGeneral
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult getEmpleados()
        {
            var query = (BDEv.sp_CargaEmpleadosReporte().ToList());
            if (query.Count >= 1)
                return Json(query);
            else
                return Json(false);
        }

        public JsonResult getEmpleadospp()
        {
            var query = (BDEv.sp_CargaEmpleadosReportePP().ToList());
            if (query.Count >= 1)
                return Json(query);
            else
                return Json(false);
        }
    }
}