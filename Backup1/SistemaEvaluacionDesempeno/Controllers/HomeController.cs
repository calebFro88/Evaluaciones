using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaEvaluacionDesempeno.Models;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.IO;
using Org.BouncyCastle.Utilities;
namespace SistemaEvaluacionDesempeno.Controllers
{
    public class HomeController : Controller
    {
       EvaluacionEntities BDEv = new Models.EvaluacionEntities();
        public string usuarioRed = "";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
     

        public ActionResult RecordatorioObjetivos()
        {
            return View();
        }

        public ActionResult FormulacionDeObjetivos()
        {
            ViewBag.Message = "Formulacion de objetivos";
            return View();
        }

        public ActionResult DefinirPeriodo()
        {
            ViewBag.Message = "Definir periodo de evaluacion";
            return View();
        }

        public ActionResult Competencias()
        {
            return View();
        }

        public ActionResult EnviarReminders()
        {
            ViewBag.Message = "Inicio de evaluacion";
           // ViewBag.Message = "Definir periodo de evaluacion";
            return View();
        }

        public ActionResult EvaluacionDeEmpleado()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            ViewBag.Message = "Inicio de sesion.";
            return View();
        }

        public ActionResult EvaluacionDeEmpleadoHourly()
        {
            return View();
        }

        public ActionResult EvaluacionDeEmpleadoSalary()
        {
            return View();
        }

        public ActionResult ReportSalary()
        {
            return View();
        }

        public ActionResult ReporteHourly()
        {
            return View();
        }

        public ActionResult ReporteSalarySup()
        {
            return View();
        }

        public ActionResult ReporteHourlySup()
        {
            return View();
        }

        public ActionResult NoExisteEvaluacion()
        {
            return View();
        }

        public ActionResult RevisionHourly()
        {
            return View();
        }

        public ActionResult EmpleadosSinCorreo()
        {
            return View();
        }

        public ActionResult Error()
        {
            return PartialView();
        }

        public ActionResult EstatusEvaluaciones()
        {
            return View();
        }

        public ActionResult EvaluacionesTerminadas()
        {
            return View();
        }

        public void miEvaluacion()
        {
            try
            {
                int NumeroDeEmpleado = int.Parse(Session["No_Empleado"].ToString());
                var ExisteEvaluacionPendiente =
                    BDEv.sp_ValidarEvaluacionExistente(NumeroDeEmpleado).ToList()[0].ToString();
                if (ExisteEvaluacionPendiente == "Salary")
                {
                    //return View(EvaluacionDeEmpleadoSalary());
                    //Response.Redirect(Url.Action("EvaluacionDeEmpleadoSalary", "Home"));
                    Response.Redirect(Url.Action("Competencias", "Home"));
                }
                //else if (existeevaluacionpendiente == "hourly c")
                //{
                //    //return view(evaluaciondeempleadohourly());
                //    response.redirect(url.action("evaluaciondeempleadohourly", "home"));
                //}
                else
                {
                    Response.Redirect(Url.Action("NoExisteEvaluacion", "Home"));
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public ActionResult CerrarSesion()
        {
            Session.RemoveAll();
            return View("LogIn");
        }
        
        [HttpPost]
        public JsonResult ValidarCorreo(string Correo)
        {
            try
            {
                //string email = "Caleb.Alamos@Emerson.com";
                string email = BDEv.traeEmail(Correo).ToList()[0].ToString();
                if (email != "")
                {
                    return Json(true);
                }
                else
                {
                    return Json(false);
                } 
            }
            catch (Exception ex)
            {
                return Json(ex.Message.ToString());
            }
        }

        [HttpPost]
        public JsonResult ValidarActiveDirectory(string NombreUsuario, string Password)
        {
            //SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ToString());
            //SqlCommand comand;   
            try
            {
                NombreUsuario = NombreUsuario.ToUpper();
                //Esta seccion se encuentra comentada exclusivamente para hacer pruebas sin autenticacion en el sistema.
                #region ValidacionTemporal
                // VALIDACION TEMPORAL
                var datos = BDEv.sp_ValidarNombreDeUsuario(NombreUsuario).ToList();

                if (NombreUsuario == "AACALD" || NombreUsuario == "AABARR" || NombreUsuario == "VMCRIS")
                {
                    Session["Nombre"] = datos[0].NombreAD.ToString();
                    Session["Apellido"] = datos[0].ApellidoAD.ToString();
                }
                else
                {
                    Session["Nombre"] = datos[0].Nombre.ToString();
                    Session["Apellido"] = datos[0].Apellido.ToString();
                }
                Session["Estado"] = true;
                Session["user"] = datos[0].userName.ToString();//NombreUsuario;
                Session["IDPeriodo"] = int.Parse(BDEv.sp_ObtenerUltimoPeriodo().ToList()[0].ToString());
                int numEmp;
                numEmp = datos[0].No_Emp;//int.Parse((from tbl in BDEv.ACTIVE_DIRECTORY where tbl.userName == "AABARR" select tbl.userNumber).ToList()[0].ToString());
                var tipoUsuario = BDEv.sp_ValidarUsuario(NombreUsuario).ToList();
                if (tipoUsuario[0] == "RecursosHumanos")
                {
                    Session["TipoEmpleado"] = "RecursosHumanos";
                    Session["No_Empleado"] = numEmp;//numEmp;
                    Session["Jefe"] = datos[0].JEFE.ToString();
                    Session["rol"] = "RH";
                }
                else if (tipoUsuario[0] == "PM")//Plant Manager
                {
                    Session["TipoEmpleado"] = "PlantManager";
                    Session["No_Empleado"] = numEmp; //numEmp;
                    Session["Jefe"] = datos[0].JEFE.ToString();
                    //Session["MisEmpleados"] 
                    Session["rol"] = "No";
                }
                else if (tipoUsuario[0] == "Gerente")
                {
                    Session["TipoEmpleado"] = "Gerente";
                    Session["No_Empleado"] = numEmp;
                    Session["Jefe"] = datos[0].JEFE.ToString();
                    Session["rol"] = "No";
                }
                else if (tipoUsuario[0] == "Supervisor")
                {
                    Session["TipoEmpleado"] = "Supervisor";
                    Session["No_Empleado"] = numEmp;
                    Session["Jefe"] = datos[0].JEFE.ToString();
                    Session["rol"] = "No";
                }
                else
                {
                    Session["TipoEmpleado"] = "Empleado";
                    Session["No_Empleado"] = numEmp;
                    Session["Jefe"] = datos[0].JEFE.ToString();
                    Session["rol"] = "No";
                }
                return Json(true);
                #endregion
                #region Active_Directory
                //DirectoryEntry entry = new DirectoryEntry();
                //DirectorySearcher buscarUsuario = new DirectorySearcher(entry);
                //buscarUsuario.Filter = "(&(objectClass=user)(anr=" + NombreUsuario + "))";
                //buscarUsuario.PropertiesToLoad.Add("department");
                //buscarUsuario.PropertiesToLoad.Add("givenName");
                //buscarUsuario.PropertiesToLoad.Add("sn");

                //SearchResult result = buscarUsuario.FindOne();
                //if (result != null)
                //{
                //    using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, "emrsn"))
                //    {
                //        bool isValid = pc.ValidateCredentials(NombreUsuario, Password);
                //        if (isValid)
                //        {
                //            var datos = BDEv.sp_ValidarNombreDeUsuario(NombreUsuario).ToList();
                //            Session["Estado"] = true;
                //            Session["user"] = datos[0].userName.ToString();//NombreUsuario;
                //            Session["IDPeriodo"] = int.Parse(BDEv.sp_ObtenerUltimoPeriodo().ToList()[0].ToString());

                //            if (NombreUsuario == "AACALD" || NombreUsuario == "AABARR" || NombreUsuario == "VMCRIS")
                //            {
                //                Session["Nombre"] = datos[0].NombreAD.ToString();
                //                Session["Apellido"] = datos[0].ApellidoAD.ToString();
                //            }
                //            else
                //            {
                //                Session["Nombre"] = datos[0].Nombre.ToString();
                //                Session["Apellido"] = datos[0].Apellido.ToString();
                //            }

                //            int numEmp;
                //            numEmp = datos[0].No_Emp;//int.Parse((from tbl in BDEv.ACTIVE_DIRECTORY where tbl.userName == "AABARR" select tbl.userNumber).ToList()[0].ToString());
                //            var tipoUsuario = BDEv.sp_ValidarUsuario(NombreUsuario).ToList();

                //            if (tipoUsuario[0] == "RecursosHumanos")
                //            {
                //                Session["TipoEmpleado"] = "RecursosHumanos";
                //                Session["rol"] = "RH";
                //            }
                //            else if (tipoUsuario[0] == "PM")//Plant Manager
                //            {
                //                Session["TipoEmpleado"] = "PlantManager";
                //                Session["rol"] = "No";

                //            }
                //            else if (tipoUsuario[0] == "Gerente")
                //            {
                //                Session["TipoEmpleado"] = "Gerente";
                //                Session["rol"] = "No";

                //            }
                //            else if (tipoUsuario[0] == "Supervisor")
                //            {
                //                Session["TipoEmpleado"] = "Supervisor";
                //                Session["rol"] = "No";

                //            }
                //            else
                //            {
                //                Session["TipoEmpleado"] = "Empleado";
                //                Session["rol"] = "No";
                //            }

                //            Session["No_Empleado"] = numEmp; //numEmp;
                //            Session["Jefe"] = datos[0].JEFE.ToString();


                //            return Json(true);
                //        }
                //        else
                //        {
                //            return Json("Usuario y/o Contraseña Incorrectos");
                //        }
                //    }
                //}
                //else
                //{
                //    return Json("Usuario y/o Contraseña Incorrectos");
                //}
                #endregion
            }
            catch (Exception X)
            {
                return Json(X.Message);
            }
        }


        [HttpPost]
        public JsonResult retornaJefe(string Nombre, string Apellido)
        {
            var dato = "";
            return Json(dato);
        }
        //Para el reporte telerik...
        [HttpPost]
        public JsonResult cargarMisParametros()
        {
            List<string> misDatos = new List<string>();

            misDatos.Add(Session["No_Empleado"].ToString());
            misDatos.Add(Session["IDPeriodo"].ToString());
            return Json(misDatos);
        }

        private string retornCorreo(string nombreUsuario)
        {
            string Correo = "";
            return Correo;
        }

        public ActionResult ReporteGeneral()
        {
            return View();
        }
        
        //REPORTES PDF ==================================================================================================================
        public ActionResult OpenPDF(int No_Emp)
        {
           // Session["No_EmpleadoPDF"] = No_Emp;
            var pendnumemp = @Session["NumEmpleadoConEvPendiente"];

            return View();
        }

        public ActionResult Bitacora(int No_Emp)
        {
            // Session["No_EmpleadoPDF"] = No_Emp;
            var pendnumemp = @Session["NumEmpleadoConEvPendiente"];

            return View();
        }

        public ActionResult OpenKARDEX(int No_Emp)
        {
            //Session["No_EmpleadoPDF"] = No_Emp;
            //.Cache.SetCacheability(HttpCacheability.NoCache);
            return View();
        }

        public ActionResult OpenPERMISOS(int No_Emp)
        {

            //Session["No_EmpleadoPDF"] = No_Emp;
            //.Cache.SetCacheability(HttpCacheability.NoCache);
            return View();
        }

        //FFIN DE REPORTES PDF==================================================================================================================

        [DllImport("advapi32.dll", SetLastError = true)]
        //private static extern bool LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, out IntPtr phToken);
        private static extern bool LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, out IntPtr phToken);

        [DllImport("kernel32.dll")]
        private static extern Boolean CloseHandle(IntPtr hObject);


        [HttpPost]
        public JsonResult CargarPdf()
        {
            try
            {
                int pendnumemp = int.Parse(Session["NumEmpleadoConEvPendiente"].ToString());
                int Numero = int.Parse(Session["No_EmpleadoPDF"].ToString()); //int.Parse(Session["No_EmpleadoPDF"].ToString());

                //if (Numero != pendnumemp)
                //{
                //    Numero = int.Parse(Session["NumEmpleadoConEvPendiente"].ToString());
                //}
                string TipoDeEmpleado = BDEv.sp_GetTipoEmpleado(Numero).ToList()[0].ToString();
                //return File(fileName: @"C:\Expedientes\"+ numero.ToString() + ".pdf", contentType: "application/pdf");
                IntPtr token = IntPtr.Zero;
                var success = LogonUser("NUFSMS", "emrsn", "Emerson2016", 2, 0, out token);
                if (false == success)
                {
                    return Json("No se ha podido comprobar credenciales.");
                }
                else
                {
                    //string Ruta = @"//mxnl-fs02/evalesc$";
                    string Ruta = @"\\mxnl-fs02\evalesc$";
                    byte[] pdfEv;
                    string RutaFinal = "";

                    WindowsImpersonationContext person = new WindowsIdentity(token).Impersonate();

                    if (TipoDeEmpleado == "Salary")
                    {
                        RutaFinal = (Ruta + "\\SALARY\\" + Numero.ToString() + ".pdf");
                    }
                    else if (TipoDeEmpleado == "Hourly C")
                    {
                        RutaFinal = (Ruta + "\\TECNICO\\" + Numero.ToString() + ".pdf");
                    }
                    else
                    {
                        return Json(false);
                    }

                    pdfEv = System.IO.File.ReadAllBytes(RutaFinal);
                    //var str = System.Text.Encoding.Default.GetString(picArray);
                    //var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(str);
                    string Dato = System.Convert.ToBase64String(pdfEv);
                    //person.Undo();
                    return Json(Dato);
                    #region validacionAnterior
                    //if (success)
                    //{
                    //    using (WindowsImpersonationContext person = new WindowsIdentity(token).Impersonate())
                    //    {
                    //        try
                    //        {
                    //            archivoHourly = Directory.GetFiles(Ruta + "\\TECNICO\\");
                    //            archivoSalary = Directory.GetFiles(Ruta + "\\SALARY\\");
                    //            string RutaFinalHourly = (Ruta + "\\TECNICO\\" + Numero.ToString() + ".pdf");
                    //            string RutaFinalSalary = (Ruta + "\\SALARY\\" + Numero.ToString() + ".pdf");

                    //            return Json(RutaFinalSalary);

                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            //return ex.InnerException.Message);

                    //            return Json(false);
                    //        }
                    //    }
                    //}
                    //else
                    //{

                    //    return Json(false);
                    //}
                    #endregion
                }
            }
            catch (Exception exc)
            {
                return Json(exc.Message);
            }
        }

        [HttpPost]
        public JsonResult CargarKARDEX()
        {
            try
            {
                int Numero = int.Parse(Session["No_EmpleadoPDF"].ToString());
                string TipoDeEmpleado = BDEv.sp_GetTipoEmpleado(Numero).ToList()[0].ToString();
                //return File(fileName: @"C:\Expedientes\"+ numero.ToString() + ".pdf", contentType: "application/pdf");
                IntPtr token = IntPtr.Zero;
                var success = LogonUser("NUFSMS", "emrsn", "Emerson2016", 2, 0, out token);
                if (false == success)
                {
                    return Json("No se ha podido comprobar credenciales.");
                }
                else
                {
                    //string Ruta = @"//mxnl-fs02/evalesc$";
                    string Ruta = @"\\mxnl-fs02\evalesc$\kardex\";
                    byte[] pdfEv;
                    string RutaFinal = "";

                    WindowsImpersonationContext person = new WindowsIdentity(token).Impersonate();
                    //hay que validar la ruta //

                    RutaFinal = (Ruta + Numero.ToString() + ".pdf");
                    //if (TipoDeEmpleado == "Salary")
                    //{
                    //    RutaFinal = (Ruta + "\\SALARY\\" + Numero.ToString() + ".pdf");
                    //}
                    //else if (TipoDeEmpleado == "Hourly C")
                    //{
                    //    RutaFinal = (Ruta + "\\TECNICO\\" + Numero.ToString() + ".pdf");
                    //}
                    //else
                    //{
                    //    return Json(false);
                    //}

                    pdfEv = System.IO.File.ReadAllBytes(RutaFinal);

                    string Dato = System.Convert.ToBase64String(pdfEv);
                    return Json(Dato);
                    #region validacionAnterior

                    #endregion
                }
            }
            catch (Exception exc)
            {
                return Json(exc.Message);
            }
        }


        [HttpPost]
        public JsonResult CargarPERMISOS()
        {
            try
            {
                int Numero = int.Parse(Session["No_EmpleadoPDF"].ToString());
                string TipoDeEmpleado = BDEv.sp_GetTipoEmpleado(Numero).ToList()[0].ToString();
                //return File(fileName: @"C:\Expedientes\"+ numero.ToString() + ".pdf", contentType: "application/pdf");
                IntPtr token = IntPtr.Zero;
                var success = LogonUser("NUFSMS", "emrsn", "Emerson2016", 2, 0, out token);
                if (false == success)
                {
                    return Json("No se ha podido comprobar credenciales.");
                }
                else
                {
                    //string Ruta = @"//mxnl-fs02/evalesc$";
                    string Ruta = @"\\mxnl-fs02\evalesc$\permisos\";
                    byte[] pdfEv;
                    string RutaFinal = "";

                    WindowsImpersonationContext person = new WindowsIdentity(token).Impersonate();
                    //hay que validar la ruta //

                    RutaFinal = (Ruta + Numero.ToString() + ".pdf");


                    pdfEv = System.IO.File.ReadAllBytes(RutaFinal);

                    string Dato = System.Convert.ToBase64String(pdfEv);
                    return Json(Dato);
                    #region validacionAnterior

                    #endregion
                }
            }
            catch (Exception exc)
            {
                return Json(exc.Message);
            }
        }
        //////////////////////////////// Asistencia a los Cursos ////////////////////////////////////////////
        // Para mostrar los cursos que se ha realizado por los empleados
        public ActionResult CursosAsistidos(int No_Emp)
        {
            Session["No_EmpleadoPDF"] = No_Emp;
            return View();
        }

        public JsonResult ListarCursosAsistidos()
        {
            //var ListaCursos = BDEv.sp_ListarCursosAsistidos(No_Emp).ToList();
            var ListaCursos = BDEv.sp_ListarCursosAsistidos(int.Parse(Session["No_EmpleadoPDF"].ToString()));
            return Json(ListaCursos);
        }

        //////////////////////////////// Fin Asistencia a los cursos ////////////////////////////////////////
    }
}