using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaEvaluacionDesempeno.Controllers
{
    public class ObjetivosController : Controller
    {
        Models.EvaluacionEntities BDEv = new Models.EvaluacionEntities();
        // GET: Objetivos
        public ActionResult Index()
        {
            return View();
        }

        //Metodo para obtener los objetivos pendientes de todos los empleados//
        [HttpPost]
        public JsonResult getObjetivosPendientes()
        {
            var query = (BDEv.sp_ListarPendienteDeObjetivos().ToList());
            if (query.Count >= 1)
                return Json(query);
            else
                return Json(false);
        }

        //Solo se obtienen los objetivos de empleado logeado en el sistema...
        [HttpPost]
        public JsonResult getMisObjetivosPendientes(int NumeroEmpleado, int Periodo)
        {
            var query = BDEv.sp_MisObjetivos(NumeroEmpleado, Periodo).ToList();

            return Json(query);
        }

        [HttpPost]
        public JsonResult getObjetivosPendientesDeValidar(int NumeroEmpleado, int Periodo)
        {
             var misObjPendientes = BDEv.sp_MisObjetivosRealizados(NumeroEmpleado, Periodo).ToList();

             if (misObjPendientes.Count() >= 1)
             {
                 return Json(misObjPendientes);
             }
             else
             {
                 return Json("NO");
             } 
        }

        //Agregar Un nuevo objetivo, practicamente se agregan en forma de listado con el valor por default: EstadoDeObjetivo = 'En Espera',
        //Hasta que se terminan de formular los objetivos pasaran a: EstadoDeObjetivo = 'Pendiente De Revision'
        [HttpPost]
        public JsonResult setNuevoObjetivo(int NumeroEmpleado, string DescObjetivo, int intPeso, int Periodo, DateTime FechaLimiteEsperada, int? ID_Objetivo)
        {
            //DateTime miFecha;
            //miFecha = DateTime.Parse(FechaLimiteEsperada);
            
            var query = BDEv.sp_CrearNuevoObjetivo(NumeroEmpleado, DescObjetivo, intPeso, Periodo,FechaLimiteEsperada);
            return Json(true);
        }

        //Paso final del empleado, de aqui espera a que su superior valide sus objetivos.
        [HttpPost]
        public JsonResult setTerminarDeFormularObjetivos(int NumeroEmpleado, int Periodo)
        {
            try
            {
                var query = BDEv.sp_TerminarDeFormularObjetivos(NumeroEmpleado, Periodo);

                if (query >= 1)
                {
                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
            }
            catch (Exception exc)
            {
                return Json(exc.InnerException);
            }
        }

        //Editar El objetivo que esta en espera..
        [HttpPost]
        public JsonResult setEditarObjetivo(int ID_Objetivo, int NumeroEmpleado, string DescObjetivo, int intPeso, int Periodo)
        {
            var QUERY = BDEv.sp_EditarObjetivo(ID_Objetivo, NumeroEmpleado, DescObjetivo, intPeso, Periodo);

            if (QUERY >= 1)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

        [HttpPost]
        public JsonResult setEliminarObjetivo(int ID_Objetivo)
        {
            var query = BDEv.sp_EliminarMiObjetivo(ID_Objetivo);

            if (query >= 1)
            {
                return Json("Se ha eliminado el objetivo correctamente.");
            }
            else
            {
                return Json(false);
            }
        }
    }
}