using EjercicioRestSalud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPIEmpresaSalud.Models;

namespace WEBAPIEmpresaSalud.Controllers
{
    public class ContratacionController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get([FromBody] int IDCobertura, int DNI)
        {
            Cobertura cobertura = CoberturaServicio.ConversorServicio_Logica(IDCobertura);
            if (LogicaPrincipal.Instancia.VerificacionPersonaCobertura(cobertura, DNI ).Resultado)
            {
                RespuestaServicio.instanciaRespuesta.Resultado = true;
                
                return Ok(RespuestaServicio.instanciaRespuesta.Resultado);
            }
            RespuestaServicio.instanciaRespuesta.Detalle = LogicaPrincipal.Instancia.VerificacionPersonaCobertura(cobertura, DNI).Detalle;
            return Ok(RespuestaServicio.instanciaRespuesta.Detalle);
        }


    }
}
