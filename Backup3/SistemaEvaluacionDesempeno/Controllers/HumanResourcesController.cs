using SistemaEvaluacionDesempeno.Models;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SistemaEvaluacionDesempeno.Controllers
{
    public class HumanResourcesController : Controller
    {
        SistemaEvaluacionDesempeno.Models.EvaluacionEntities BDEv = new Models.EvaluacionEntities();
        // GET: HumanResources
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult getListadoEmpleados()
        {
            var query = BDEv.Emp.ToList();
            if (query.Count >= 1)
            {
                return Json(query);
            }
            return Json(false);
        }

        [HttpPost]
        public JsonResult RecordatorioObjetivosEmpleado(string Nombre)
        {
            DirectoryEntry entry = new DirectoryEntry();
            DirectorySearcher buscar = new DirectorySearcher(entry);
            buscar.Filter = "(&(objectClass=user)(anr=" + Nombre + "))";
            string correo = System.Environment.GetEnvironmentVariable("mail");
            buscar.PropertiesToLoad.Add("mail");
            try
            {
                SearchResult result = buscar.FindOne();
                if (result != null)
                {
                    string Correo = result.Properties["mail"][0].ToString();
                    return Json(Correo);
                }
                else
                {
                    return Json(false);
                }
            }
            catch (Exception exc)
            {

                throw exc.InnerException;
            }
        }

        [HttpPost]
        public JsonResult setDefinirPeriodoEvaluacion(DateTime FechaInicio, DateTime FechaFin, string Descripcion)
        {
            var query = BDEv.sp_CrearPeriodo(FechaInicio, FechaFin, Descripcion);
            if (query >= 1)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

        
      



    }
}