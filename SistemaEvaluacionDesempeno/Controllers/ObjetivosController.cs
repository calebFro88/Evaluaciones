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

        [HttpPost]
        public JsonResult getmisEmpleadosConObjetivos(string PrimerNombre, string PrimerApellido)
        {
            var query = BDEv.sp_misEmpleadosConObjetivosPendientes(PrimerNombre, PrimerApellido).ToList();
            return Json(query);
        }

        [HttpPost]
        public JsonResult updateMeta(string Meta, int NumEmp)
        {
            //aqui va el store que actualiza la meta
           var query = BDEv.sp_ActualizaMeta(Meta, NumEmp);

            return Json(true);
        }
        [HttpPost]
        public JsonResult updateMetaEdit(string Meta, int NumEmp,int idObjetivo)
        {
            //aqui va el store que actualiza la meta
            var query = BDEv.sp_ActualizaMetaEdit(Meta, NumEmp, idObjetivo);

            return Json(true);
        }
        [HttpPost]
        public JsonResult getMisObjetivosPendientesXD(int NumeroEmpleado, int Periodo)
        {
            var query = BDEv.sp_MisObjetivosXD(NumeroEmpleado, Periodo).ToList();
            if (query.Any(s => s.ID_Objetivo == null))
            {
                return Json(false);
            }
            else
                return Json(query);
        }



        //Solo se obtienen los objetivos de empleado logeado en el sistema...
        [HttpPost]
        public JsonResult getMisObjetivosPendientes(int NumeroEmpleado, int Periodo)
        {
            var query = BDEv.sp_MisObjetivos(NumeroEmpleado, Periodo).ToList();
            if (query.Any(s => s.ID_Objetivo == null))
            {
                return Json(false);
            }
            else
                return Json(query);
        }

        [HttpPost]
        public JsonResult getComentariosCalifJefe(int NumeroEmpleado, int Periodo)
        {
            var query = BDEv.sp_RevisionObjetivosTerminados(NumeroEmpleado, Periodo);
            return Json(query);
        }




        [HttpPost]
        public JsonResult setNuevoObjetivo(int IDObj, int? NumEmp, string DescObjetivo, int? intPeso,string Tipo, int? Periodo, int Categoria, string PeriodoObj)
        {

            if (NumEmp == null || DescObjetivo == null)
            {
                return Json(false);
            }
            else
            {
                //int Tipo2 = 0;
                var query = BDEv.sp_CrearNuevoObjetivo(IDObj, NumEmp, DescObjetivo, intPeso,Tipo, Periodo, Categoria, PeriodoObj);
                return Json(query);
            }
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
        public JsonResult setEditarObjetivo(int IDObj, int NumEmp, string DescObjetivo, int intPeso, string Tipo, int Periodo, int PesoAnt, string DescAnt, int Categoria, int PeriodoObj)
        {
            //int IDObj, int? NumEmp, string DescObjetivo, int? intPeso, string Tipo, int? Periodo, int Categoria, string PeriodoObj)
            var QUERY = BDEv.sp_EditarObjetivo(IDObj, NumEmp, DescObjetivo, intPeso, Tipo, Periodo, PesoAnt, DescAnt, Categoria, PeriodoObj);

            return Json(true);
        }

        [HttpPost]
        public JsonResult setEliminarObjetivo(int NumEmp, string DescObjetivo, int intPeso, int Periodo)
        {
            var query = BDEv.sp_EliminarMiObjetivo(NumEmp, DescObjetivo, intPeso, Periodo);

            return Json(query);
        }

        public JsonResult getmisEmpleadosConObjetivosPendientes(string PrimerNombre, string PrimerApellido)
        {
            var query = BDEv.sp_misEmpleadosConObjetivosPendientes(PrimerNombre, PrimerApellido).ToList();
            return Json(query);
        }

        [HttpPost]


        public JsonResult cargarObjetivosPendientesDeRevision(int No_Emp, string Operacion)
        {
            try
            {
                Session["PendEvNombre"] = (from tbl in BDEv.Emp where tbl.No_Emp == No_Emp select tbl.Nombre).ToList()[0].ToString();
                Session["PendEvApellido"] = (from tbl in BDEv.Emp where tbl.No_Emp == No_Emp select tbl.APELLIDO).ToList()[0].ToString();
                Session["JefeM"] = (from tbl in BDEv.Emp where tbl.No_Emp == No_Emp select tbl.JEFE).ToList()[0].ToString();
                Session["NumEmpleadoConEvPendiente"] = No_Emp;
                //Session["IDPeriodo"] = int.Parse(BDEv.sp_ObtenerUltimoPeriodo().ToList()[0].ToString());
                Session["IDPeriodo"] = ObtenerPeriodo(No_Emp);

                string TipoEmpleado = (from tbl in BDEv.Emp where tbl.No_Emp == No_Emp select tbl.TipoEmpleado).ToList()[0].ToString();
                string userNameEmp = (from tbl in BDEv.ACTIVE_DIRECTORY where tbl.userNumber == No_Emp select tbl.userName).ToList()[0].ToString();
                Session["EmpPendTipoEmpleado"] = BDEv.sp_ValidarUsuario(userNameEmp).ToList()[0].ToString();
                //AQUI SE HIZO CAMBIO PARA VALIDAR SI ES JUAN ELYD EL QUE REVISARA...

                if (Operacion == "RevisionObj")
                {
                    Session["Operacion"] = "Revision";
                    Session["Periodo"] = (from tbl in BDEv.Re_Objetivo where tbl.No_Emp == No_Emp select tbl.PeriodoActual).ToList()[0].ToString();
                }

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

                Session["ID_ReObjetivo"] = (from tbl in BDEv.Re_Objetivo
                                            where tbl.No_Emp == No_Emp
                                            orderby tbl.FechaInicio descending
                                            select tbl.ID_ReObjetivo).ToList().Last();
                return Json(TipoEmpleado);
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }



        [HttpPost]
        public ActionResult setGuardarEstadoObjetivo(int[] Objetivos, int NumEmp, int Periodo, string[] Comentarios, int[] Avance, string onGoing)
        {
            try
            {
                ////////////////////////////////////////
                string[] cadena = onGoing.Replace("},{","").Replace(",","").Split('\"');
                bool esOnGoing = false;
                int valor;
                int indice;
                ///////////////////////////////////////
                string userName = Session["user"].ToString();
                Session["ID_ReObjetivo"] = (from tbl in BDEv.Re_Objetivo where tbl.No_Emp == NumEmp select tbl.ID_ReObjetivo).ToList().Last();
                int IDReEvaluacion = int.Parse(Session["ID_ReObjetivo"].ToString());
                       for (int i = 0; i < Objetivos.Length; i++)
                 {
                    //recorrer la cadena 
                    for(int x= 0; x < cadena.Length; x++)
                    {
                        if(cadena[x].Contains(Objetivos[i].ToString()))
                        {
                            // string con = "";
                            esOnGoing = true;
                            break;
                        }
                    }

                    if (esOnGoing == true)
                    {
                        for (int x = 0; x < cadena.Length; x++)
                        {
                            if (cadena[x].Contains(Objetivos[i].ToString() + "_Q1"))
                            {
                                 indice = x + 4;
                                 valor = int.Parse(cadena[indice]);

                                //aqui va el store que actuliza
                                var guardarEstadoActual = BDEv.sp_GuardarEstadoDeObjetivoOnGoing(Objetivos[i], NumEmp, Periodo, Comentarios[i], IDReEvaluacion, valor, "Q1");

                            }
                            else if(cadena[x].Contains(Objetivos[i].ToString() + "_Q2"))
                            {
                                indice = x + 4;
                                valor = int.Parse(cadena[indice]);
                                var guardarEstadoActual = BDEv.sp_GuardarEstadoDeObjetivoOnGoing(Objetivos[i], NumEmp, Periodo, Comentarios[i], IDReEvaluacion, valor, "Q2");

                            }
                            else if(cadena[x].Contains(Objetivos[i].ToString() + "_Q3"))
                            {
                                indice = x + 4;
                                valor = int.Parse(cadena[indice]);
                                var guardarEstadoActual = BDEv.sp_GuardarEstadoDeObjetivoOnGoing(Objetivos[i], NumEmp, Periodo, Comentarios[i], IDReEvaluacion, valor, "Q3");

                            }
                            else if (cadena[x].Contains(Objetivos[i].ToString() + "_Q4"))
                            {
                                indice = x + 4;
                                valor = int.Parse(cadena[indice]);
                                var guardarEstadoActual = BDEv.sp_GuardarEstadoDeObjetivoOnGoing(Objetivos[i], NumEmp, Periodo, Comentarios[i], IDReEvaluacion, valor, "Q4");

                            }
                        }
                    }
                    else
                    {
                        var guardarEstadoActual = BDEv.sp_GuardarEstadoDeObjetivo(Objetivos[i], NumEmp, Periodo, Comentarios[i], IDReEvaluacion, Avance[i]);

                    }
                    esOnGoing = false;
                }
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(ex.Message.ToString());
            }
        }

        public int ObtenerPeriodo(int NumEmp)
        {
            Session["IDPeriodo"] = (from tbl in BDEv.Re_Objetivo
                                    where tbl.No_Emp == NumEmp
                                    orderby tbl.FechaInicio descending
                                    select tbl.ID_Periodo).ToList()[0].ToString();
            return int.Parse(Session["IDPeriodo"].ToString());
        }

        [HttpPost]
        public JsonResult guardarYEnviarObjetivos(int NumEmp, int Periodo, string Revision)
        {
            try
            {
                Session["ID_ReObjetivo"] = (from tbl in BDEv.Re_Objetivo where tbl.No_Emp == NumEmp select tbl.ID_ReObjetivo).ToList().Last();
                int IDReObjetivo = int.Parse(Session["ID_ReObjetivo"].ToString());

                BDEv.sp_GuardarYTerminarObjetivos(IDReObjetivo, NumEmp, Periodo, Revision);
                return Json(true);
            }
            catch (Exception)
            {

                return Json(false);
            }
        }

        [HttpPost]
        public JsonResult ObjetivoTerminado(int NumEmp, string Objetivo, int IDPeriodo)
        {
            Session["PendEvNombre"] = (from tbl in BDEv.Emp where tbl.No_Emp == NumEmp select tbl.Nombre).ToList()[0].ToString();
            Session["PendEvApellido"] = (from tbl in BDEv.Emp where tbl.No_Emp == NumEmp select tbl.APELLIDO).ToList()[0].ToString();
            Session["NumEmpleadoConEvPendiente"] = NumEmp;
            int aux = ObtenerPeriodo(NumEmp);
            return Json(true);
        }

        [HttpPost]
        public JsonResult Aprovar(int NumEmp, string Comentario)
        {
            //Cambia el Reminder para el correo
            var qu = BDEv.sp_FinalizaObjetivo(NumEmp);
            BDEv.sp_AprobarObj(NumEmp, Comentario);
            //var query = BDEv.sp_validaRecursos(No_Emp, Comentario);
            return Json(true);
        }

        [HttpPost]
        public JsonResult rechaza(int No_Emp, string Comentario)
        {
            //Cambia el Reminder para el correo
            BDEv.sp_RechazaObjetivos(No_Emp);
            BDEv.sp_RechazarObjetivo(No_Emp, Comentario);
            return Json(true);
        }

        [HttpPost]
        public JsonResult CargarPeriodos()
        {
            var query = BDEv.sp_getPeriodos();
            return Json(query);
        }

        [HttpPost]
        public JsonResult CargarCategorias()
        {
            var query2 = (from tbl in BDEv.CategoriaObjetivos
                          select new
                          {
                              CategoryID = tbl.ID_CategoriaObjetivos,
                              Tipo = tbl.Valor
                          }
                           ).ToList();
            return Json(query2);
        }

        public JsonResult CargarTipos()
        {
            var query2 = (from tbl in BDEv.TiposObjetivos
                          select new
                          {
                              CategoryID = tbl.ID,
                              Tipo = tbl.valor
                          }
                           ).ToList();
            return Json(query2);
        }
    }
}