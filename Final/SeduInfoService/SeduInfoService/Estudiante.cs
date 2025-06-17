using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeduInfoService
{
    public class Estudiante
    {
        public string CI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }
        public double Promedio { get; set; }

        
        public string TutorAsignado { get; set; }
        public string CorreoTutor { get; set; }
        public string TelefonoTutor { get; set; }
    }
    
}
