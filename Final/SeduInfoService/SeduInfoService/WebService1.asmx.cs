using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SeduInfoService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public Estudiante ObtenerDatosAcademicos(string CI)
        {
            
            return new Estudiante
            {
                CI = "12345",
                Nombres = "Juan",
                Apellidos = "Pérez",
                Carrera = "Ingeniería Civil",
                Semestre = 6,
                Promedio = 8.7
            };
        }

        [WebMethod]
        public Estudiante ObtenerDatosTutor(string CI)
        {
            
            return new Estudiante
            {
                CI = "12345",
                Nombres = "Juan Pérez",
                TutorAsignado = "Dra. García",
                CorreoTutor = "garcia@universidad.edu",
                TelefonoTutor = "76543210"
            };
        }
    }
}
