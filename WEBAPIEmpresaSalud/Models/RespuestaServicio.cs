using EjercicioRestSalud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WEBAPIEmpresaSalud.Models
{
    public class RespuestaServicio
    {
        private static RespuestaServicio respuesta = new RespuestaServicio();
        private RespuestaServicio()
        { }
        
        public static RespuestaServicio instanciaRespuesta { get { return respuesta; } }
        
        public bool Resultado { get; set; }
        public String Detalle { get; set; }
       
       
    }
}