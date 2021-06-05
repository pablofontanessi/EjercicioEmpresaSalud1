using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestSalud
{
    public class Respuesta
    {
        private static Respuesta respuesta = new Respuesta();
        private Respuesta()
        { }

        public static Respuesta instanciaRespuesta { get { return respuesta; } }

        public bool Resultado { get; set; }
        public String Detalle { get; set; }
        

    }
}
