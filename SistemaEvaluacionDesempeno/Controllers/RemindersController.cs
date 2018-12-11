using SistemaEvaluacionDesempeno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaEvaluacionDesempeno.Controllers
{
    public class RemindersController : Controller
    {
        SistemaEvaluacionDesempeno.Models.EvaluacionEntities BDEv = new Models.EvaluacionEntities();

        [HttpPost]
        public JsonResult LoadDpts()
        {
            var LN = BDEv.sp_CargaDepartamentos().ToList();
            return Json(LN);
        }

        [HttpPost]
        public JsonResult LoadJefes()
        {
            var LN = BDEv.sp_CargaJefes().ToList();
            return Json(LN);
        }

        [HttpPost]
        public JsonResult getEmpleados()
        {
            var query = (BDEv.sp_CargaEmpleados().ToList());
            if (query.Count >= 1)
                return Json(query);
            else
                return Json(false);
        }


        [HttpPost]
        public JsonResult EnvioReminders(Reminders2 NUMS)
        {
            try
            {
                string[] numEE = NUMS.Num_Empleado.Split(',');
                int conteo = numEE.Count();
                for (int x = 0; x < conteo; x++)
                {
                    if (numEE[x] != "")
                    {
                        int numeroFinal = int.Parse(numEE[x]);
                        // string Correo = BDEv.EMPLEADOS.Where(s => s.No_Emp == numeroFinal).Select(s => s.Email).ToList()[0].ToString();
                        BDEv.sp_LoadReminders(NUMS.Reminder.ToString(), numeroFinal);
                        //aqui es donde se va a hacer el envio del correo
                        //mandaReminder(numeroFinal, NUMS.Reminder);

                    }
                }
                return Json("REMINDERS ENVIADOS");
            }
            catch (Exception Ex)
            {
                return Json(Ex.InnerException.Message);
            }
            //return Json("");
        }


        [HttpPost]
        public JsonResult LoadReminders()
        {
            var query = (BDEv.sp_Carga_ValorReminders().ToList());
            if (query.Count >= 1)
                return Json(query);
            else
                return Json(false);
        }


        [HttpPost]
        public JsonResult LoadTipos()
        {
            var query = (BDEv.sp_CargaTipos().ToList());
            if (query.Count >= 1)
                return Json(query);
            else
                return Json(false);
        }

        [HttpPost]
        public JsonResult getEmpleadosObjetivos()
        {
            //Devuelve todos los empleados Salaried para realizar sus objetivos.
            var query = (BDEv.sp_CargaEmpleadosSalary().ToList());
            if (query.Count >= 1)
                return Json(query);
            else
                return Json(false);
        }


        [HttpPost]
        public JsonResult EnvioObjetivos(Reminders2 NUMS, string Periodo)
        {
            try
            {
                string[] numEE = NUMS.Num_Empleado.Split(',');
                int conteo = numEE.Count();
                for (int x = 0; x < conteo; x++)
                {
                    if (numEE[x] != "")
                    {
                        int numeroFinal = int.Parse(numEE[x]);
                        // string Correo = BDEv.EMPLEADOS.Where(s => s.No_Emp == numeroFinal).Select(s => s.Email).ToList()[0].ToString();
                        BDEv.sp_LoadObjetivos(NUMS.Reminder.ToString(), numeroFinal, Periodo);
                        //aqui es donde se va a hacer el envio del correo
                        //mandaReminder(numeroFinal, NUMS.Reminder);

                    }
                }
                return Json("OBJETIVOS ENVIADOS");
            }
            catch (Exception Ex)
            {
                return Json(Ex.InnerException.Message);
            }
            //return Json("");
        }

        [HttpPost]
        public JsonResult LoadFiscalYear()
        {
            var query = (from tbl in BDEv.PERIODO
                         select new
                         {
                             Descripcion = tbl.Descripcion
                         }
                           ).ToList();

            return Json(query);
        }
        [HttpPost]
        public JsonResult LoadSpecificFiscalYear(int Periodo)
        {
            //var PeriodoFinal = (from tbl in BDEv.PeriodoObjetivo
            //                    where tbl.ID_Periodo == Periodo
            //                    orderby tbl.FechaRevision descending
            //                    select tbl.Periodo).ToList().First();


            var query = (from tbl in BDEv.PERIODO
                         join PO in BDEv.PeriodoObjetivo
                         on tbl.ID_Periodo equals PO.ID_Periodo
                         where tbl.ID_Periodo == Periodo
                         orderby PO.FechaRevision descending
                         select new
                         {
                             Descripcion = tbl.Descripcion,
                             IDPeriodo = tbl.ID_Periodo,
                             Periodo = PO.Periodo
                         }
                           ).ToList();
            //.First();

            return Json(query);
        }

    }
}