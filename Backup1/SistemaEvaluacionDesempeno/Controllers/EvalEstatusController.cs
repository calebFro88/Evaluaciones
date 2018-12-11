using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaEvaluacionDesempeno.Controllers
{
    public class EvalEstatusController : Controller
    {
        // GET: EvalEstatus
        SistemaEvaluacionDesempeno.Models.EvaluacionEntities BDEv = new Models.EvaluacionEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult EstadoMisEvaluaciones()
        {
            int numeroEmp = int.Parse(Session["No_Empleado"].ToString());
            var query = BDEv.sp_EstatusEvaluaciones(numeroEmp).ToList();

            if (query.Count >= 1)
            {
                return Json(query);
            }
            else
            {
                return Json(false);
            }
        }

        
        [HttpPost]
        public JsonResult EvalucionesTerminadas()
        {
            int numeroEmp = int.Parse(Session["No_Empleado"].ToString());
            var query = BDEv.EstatusEvaluacionesTerminadas(numeroEmp).ToList();

            if (query.Count >= 1)
            {
                return Json(query);
            }
            else
            {
                return Json(false);
            }
        }
    }
}