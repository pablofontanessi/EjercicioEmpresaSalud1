using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPIEmpresaSalud.Models
{
    public class PersonaServicio
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
        public int IngresosNetos { get; set; }
    }
}