using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaEvaluacionDesempeno.Controllers
{
    public class CompetenciasController : Controller
    {

        //Instancia de modelo de base de datos
        SistemaEvaluacionDesempeno.Models.EvaluacionEntities BDEv = new Models.EvaluacionEntities();

        // GET: Competencias
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult getCargarPlantilla(int No_Emp, string CompetencieType)
        {
            var competencie = BDEv.sp_CargarPlantilla(No_Emp, CompetencieType).OrderBy(m=>m.OrdenPlantilla).ToList();
            return Json(competencie);
        }
        [HttpPost]
        public JsonResult getCargarBitacora(int No_Emp)
        {

            return Json(false);
        }


        [HttpPost]
        public JsonResult CargarCompetenciasGuardadas(string TipoDeCompetencia, int No_Emp, int IDPeriodo, int idEvaluacion)
        {
            //aqui debe de ir el idEvaluacion 

            Session["No_EmpleadoPDF"] = No_Emp;
            var precargarMisCompetencias = BDEv.sp_CargarCompetenciasGuardadas(TipoDeCompetencia, No_Emp, IDPeriodo, idEvaluacion).OrderBy(m=>m.OrdenPlantilla).ToList();
            if (precargarMisCompetencias.Count()>=1)
                return Json(precargarMisCompetencias);
            else
                return Json(false);
        }


        //Funcion Para Guardar La Evaluacion...
        [HttpPost]
        public ActionResult setGuardarEstadoCompetencia(int[] idCompetencia, int No_emp, int Periodo, string []Comentarios, int[] Calificacion)
        {
            try
            {
                List<string> lstCalificacion = new List<string>();
                string userName = Session["user"].ToString();
                //Session["ID_ReEvaluacion"] = (from tbl in BDEv.Re_Evaluacion where tbl.No_Emp == No_emp select tbl.ID_ReEvaluacion).ToList().Last();
                int IDReEvaluacion = int.Parse(Session["ID_ReEvaluacion"].ToString());

                for (int i = 0; i < Calificacion.Count(); i++)
                {
                    if (Calificacion[i] == 0)
                        lstCalificacion.Add("NA");//No aplica (fECHA DE MODIFICACION 10/26/17)
                    if (Calificacion[i] == 1)
                        lstCalificacion.Add("E");
                    if (Calificacion[i] == 2)
                        lstCalificacion.Add("EX");
                    if (Calificacion[i] == 3)
                        lstCalificacion.Add("CE");
                    if (Calificacion[i] == 4)
                        lstCalificacion.Add("NM");
                    if (Calificacion[i] == 5)
                        lstCalificacion.Add("I");
                }
                //string[] miCalificacion = Calificacion.Split(',');
                for (int i = 0; i < idCompetencia.Length; i++)
                {
                    if (idCompetencia.Length > Comentarios.Length)
                    {
                        var guardarEstadoActual = BDEv.sp_GuardarEstadoDeCompetencia(idCompetencia[i], No_emp, Periodo, "", lstCalificacion[i], userName, IDReEvaluacion);
                    }
                    else
                    {
                        var guardarEstadoActual = BDEv.sp_GuardarEstadoDeCompetencia(idCompetencia[i], No_emp, Periodo, Comentarios[i].ToString(), lstCalificacion[i], userName, IDReEvaluacion);
                    }
                }

                return Json(true);
            }
            catch (Exception ex )
            {

                return Json(ex.Message.ToString());
            }
            //string[] misComentarios = Comentarios.Split(',');
          
        }

        //funcion para cargar la barra de estatus total.
        [HttpPost]
        public JsonResult getEstadoTotalDeCompetencias(int No_emp, int Periodo, int idEvaluacion)
        {
            var query = BDEv.sp_EstatusTotalEvaluacion(No_emp, Periodo, idEvaluacion);
            return Json(query);
        }

        [HttpPost]
        public JsonResult getEstadoTotalDeCompetenciasJefe(int No_emp, int Periodo)//Cuando el jefe revisa (para cargar la barra durante la evaluacion del empleado por parte del jefe).
        {
            int idEv = int.Parse(Session["ID_ReEvaluacion"].ToString());
            var query = BDEv.sp_EstatusTotalEvaluacionJefe(No_emp, Periodo, idEv);
            return Json(query);
        }

        [HttpPost]
        public JsonResult getmisEmpleadosConEvaluacionesPendientesDeRevision(string PrimerNombre, string PrimerApellido)
        {
            var query = BDEv.sp_misEmpleadosConEvaluacionPendiente(PrimerNombre, PrimerApellido).ToList();
            return Json(query);
        }

        [HttpPost]
        public JsonResult GuardarYEnviarMiEvaluacionParaRevision(int No_emp, int Periodo,string No_Evaluador, string idEvaluacion)
        {
            int idEv = int.Parse(idEvaluacion);
             var query = BDEv.sp_GuardarYTerminarEvaluacion(No_emp, Periodo, int.Parse(No_Evaluador),"",idEv);
            var query2 = BDEv.sp_ApruebaRH(No_emp, idEv);
            return Json(true);
            //comentario de cambio
        }


        //Revisar el id del periodo...
        [HttpPost]
        public ActionResult CargarEvaluacionPendienteDeAprobacion(int No_Emp, string Operacion, int idEvaluacion)
        {
            //Aqui se cargan los datos del empleado al que se revisara la ev.
            try
            {
                Session["PendEvNombre"] = (from tbl in BDEv.Emp where tbl.No_Emp == No_Emp select tbl.Nombre).ToList()[0].ToString();
                Session["PendEvApellido"] = (from tbl in BDEv.Emp where tbl.No_Emp == No_Emp select tbl.APELLIDO).ToList()[0].ToString();
                Session["JefeM"] = (from tbl in BDEv.Emp where tbl.No_Emp == No_Emp  select tbl.JEFE).ToList()[0].ToString();
                Session["NumEmpleadoConEvPendiente"] = No_Emp;
                string TipoEmpleado = (from tbl in BDEv.Emp where tbl.No_Emp == No_Emp select tbl.TipoEmpleado).ToList()[0].ToString();
                string userNameEmp = (from tbl in BDEv.ACTIVE_DIRECTORY where tbl.userNumber == No_Emp select tbl.userName).ToList()[0].ToString();
                Session["EmpPendTipoEmpleado"] = BDEv.sp_ValidarUsuario(userNameEmp).ToList()[0].ToString();
                //AQUI SE HIZO CAMBIO PARA VALIDAR SI ES JUAN ELYD EL QUE REVISARA...

                if (Operacion == "Revision")
                {
                    Session["Operacion"] = "Revision";
                    if (Session["TipoEmpleado"].ToString() == "PlantManager" || Session["TipoEmpleado"].ToString() == "RecursosHumanos")
                    {
                        Session["TipoEmpleado"] = "Gerente";
                    }
                }

                if (Operacion == "Aprobacion")
                {
                    Session["Operacion"] = "Aprobacion";
                }
                //if (TipoEmpleado == "Hourly C")
                //{
                //    var query = BDEv.sp_crearNuevaEvaluacion(No_Emp, "Pendiente");

                //    Session["ID_ReEvaluacion"] = (from tbl in BDEv.Re_Evaluacion where tbl.No_Emp == No_Emp select tbl.ID_ReEvaluacion).ToList().Last();
                //}

                Session["ID_ReEvaluacion"] = idEvaluacion.ToString(); //(from tbl in BDEv.Re_Evaluacion where tbl.No_Emp == No_Emp select tbl.ID_ReEvaluacion).ToList().Last();
                return Json(TipoEmpleado);
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpPost]
        public JsonResult VerNotificaciones(int No_Emp, int Periodo)
        {
            var query = BDEv.sp_MisNotificaciones(No_Emp, Periodo);
            return Json(query);
        }

        [HttpPost]
        public JsonResult MarcarNotificacionComoLeida(int No_Emp, int IDNotificacion)
        {
            var query = BDEv.sp_MarcarNotificacionComoLeida(No_Emp, IDNotificacion);
            return Json(query);
        }

        [HttpPost]
        public JsonResult lstEvPendientesDeAprobacion(int No_Emp)
        {
            var query = BDEv.sp_PendientesDeAprobacion(No_Emp);
            return Json(query);
        }


        //Aprobacion De Evaluacion Por Parte De RH.
        [HttpPost]
        public JsonResult revision(int No_Emp, string Comentario, int No_Evaluador, int idEvaluacion)
        {
            int Periodo = int.Parse(Session["IDPeriodo"].ToString());
            string TipoEmpleado = Session["TipoEmpleado"].ToString();
            
            if (TipoEmpleado == "PlantManager")
            {
               var query = BDEv.sp_GuardarYTerminarEvaluacion(No_Emp, Periodo, No_Evaluador, Comentario, idEvaluacion);
                var qu = BDEv.sp_FinalizaPM(No_Emp, idEvaluacion);
            }
            
            else
            {
               var  query = BDEv.sp_GuardarYTerminarEvaluacion(No_Emp, Periodo, No_Evaluador, Comentario, idEvaluacion);
               // var query2 = BDEv.sp_ApruebaRH(No_Emp);
                var que = BDEv.sp_FinalizaPM(No_Emp, idEvaluacion);
            }

            BDEv.sp_AprobarEv(No_Emp, Comentario, TipoEmpleado, idEvaluacion);
           // var query = BDEv.sp_GuardarYTerminarEvaluacion(No_Emp, Periodo, No_Evaluador, Comentario);
            //var query = BDEv.sp_validaRecursos(No_Emp, Comentario);
            
              return Json(true);
        }

        [HttpPost]
        public JsonResult rechaza(int No_Emp, string Comentario,string Evaluador, int idEvaluacion)
        {
            string TipoEmp = Session["TipoEmpleado"].ToString();
            if (TipoEmp == "RecursosHumanos")
            {
                var query = BDEv.sp_RechazaRH(No_Emp);
                //var query2 = BDEv.sp_rechazaRecursos(No_Emp, Comentario);
            }
            else if (TipoEmp == "PlantManager")
            {
                var query = BDEv.sp_RechazaPM(No_Emp);
                //var query2 = BDEv.sp_regresaEvPM(No_Emp, Comentario);
            }
            else
            {
                var query = BDEv.sp_RechazaRH(No_Emp);
            }

            BDEv.sp_RetroalimentarEv(No_Emp, Comentario, TipoEmp,Evaluador,idEvaluacion);
            return Json(true);
        }


        [HttpPost]
        public JsonResult MarcarComoImpresa2()
        {
            int Periodo = int.Parse(Session["IDPeriodo"].ToString());
            Session["EmpPendImp"] = Session["NumEmpleadoConEvPendiente"];
            Session["EmpReporte"] = Session["NumEmpleadoConEvPendiente"];
            int No_Emp = int.Parse(Session["NumEmpleadoConEvPendiente"].ToString());
            Session["NivelJefe"] = int.Parse(BDEv.sp_Bnivel(No_Emp).ToList()[0].ToString());

            int Numero = int.Parse(Session["No_EmpleadoPDF"].ToString());
            string TipoEmpleado = (from tbl in BDEv.Emp where tbl.No_Emp == Numero select tbl.TipoEmpleado).ToList()[0].ToString();
            return Json(TipoEmpleado);
        }



        [HttpPost]
        public JsonResult MarcarComoImpresa(int No_Emp, string idEvaluacion)
        {
            int idEv = int.Parse(idEvaluacion);
            Session["ID_ReEvaluacion"] = idEv;
            int Periodo = int.Parse(Session["IDPeriodo"].ToString());
            Session["EmpPendImp"] = No_Emp;
            Session["EmpReporte"] = No_Emp;
            Session["NivelJefe"] = int.Parse(BDEv.sp_Bnivel(No_Emp).ToList()[0].ToString());
            //verificar aqui
            //int numeroJefe = int.Parse(Session["No_Empleado"].ToString());



            BDEv.sp_EvImpresa(No_Emp);//Reminder
            BDEv.sp_GuardarYTerminarEvaluacion(No_Emp, Periodo,0,"", idEv);//Estado
            string TipoEmpleado = (from tbl in BDEv.Emp where tbl.No_Emp == No_Emp select tbl.TipoEmpleado).ToList()[0].ToString();
            return Json(TipoEmpleado);
        }

        [HttpPost]
        public JsonResult VerEstatusDeEvaluacionPDF(int No_Emp)
        {
            int Periodo = int.Parse(Session["IDPeriodo"].ToString());
            Session["EmpPendImp"] = No_Emp;
            Session["NivelJefe"] = int.Parse(BDEv.sp_Bnivel(No_Emp).ToList()[0].ToString());
            string TipoEmpleado = (from tbl in BDEv.Emp where tbl.No_Emp == No_Emp select tbl.TipoEmpleado).ToList()[0].ToString();
            return Json(TipoEmpleado);
        }


        [HttpPost]
        public JsonResult VerReporteDeEvaluacion(int No_Emp)
        {
            Session["EmpReporte"] = No_Emp;
            int Periodo = int.Parse(Session["IDPeriodo"].ToString());
            Session["NivelJefe"] = int.Parse(BDEv.sp_Bnivel(No_Emp).ToList()[0].ToString());
            //Session["EmpPendImp"] = No_Emp;
            string TipoEmpleado = (from tbl in BDEv.Emp where tbl.No_Emp == No_Emp select tbl.TipoEmpleado).ToList()[0].ToString();
            return Json(TipoEmpleado);
        }

        [HttpPost]
        public JsonResult FinalizarEvaluacion(int No_Emp, string idEvaluacion)
        {
            int idEv = int.Parse(idEvaluacion);
            int Periodo = int.Parse(Session["IDPeriodo"].ToString());
            var query = BDEv.sp_FinEvaluacion(No_Emp);
            var query2 = BDEv.sp_GuardarYTerminarEvaluacion(No_Emp, Periodo,47,"", idEv);
            return Json(true);
        }

        [HttpPost]
        public JsonResult getMisEmpleadosSinCorreo()
        {
            var query = BDEv.sp_misEmpleadosSinCorreo().ToList();

           if(query.Count>=1)
            {
                return Json(query);
            }
            else
            {
               return Json(false);
            }
        }

        [HttpPost]
        public JsonResult setCorreoDeEmpleado(int NumeroEmpleado, string Correo, string NombreUsuario)
        {
            var query = BDEv.sp_AsignarCorreoEmpleado(NombreUsuario, NumeroEmpleado, Correo);
            
            if(query>=1)
                return Json(true);
            else
                return Json(false);
        }

        [HttpPost]
        public JsonResult setActualizarEmpleadosAD()
        {
            var query = BDEv.sp_ActualizarEmpleadosAD();
            return Json(true);
        }

        //Json para listar las evaluaciones que tenga en la tabla Re_Evaluacion
        [HttpPost]
        public JsonResult CargarMiEvaluacionPend()
        {
            var query = BDEv.sp_MiEvaluacion(int.Parse(Session["No_Empleado"].ToString())).ToList();
            return Json(query);
        }

        public JsonResult getmisEmpleadosConEvaluacionesEnEspera(string PrimerNombre, string PrimerApellido)
        {
            /*sp_misEmpleadosConEvaluacionPendiente(PrimerNombre, PrimerApellido).ToList();*/
            var query = BDEv.sp_misEmpleadosConEvaluacionEnEspera(PrimerNombre, PrimerApellido).ToList();
            return Json(query);
        }

        public JsonResult getmisEmpleadosConEvaluacionesTerminadas(string PrimerNombre, string PrimerApellido)
        {
            /*sp_misEmpleadosConEvaluacionPendiente(PrimerNombre, PrimerApellido).ToList();*/
            var query = BDEv.sp_misEmpleadosConEvaluacionTerminada(PrimerNombre, PrimerApellido).ToList();
            return Json(query);
        }
    }
}