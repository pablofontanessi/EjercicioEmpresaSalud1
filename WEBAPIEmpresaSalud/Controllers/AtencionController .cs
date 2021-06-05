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
    public class AtencionController : ApiController
    {
        
        // GET api/values/5
        public IHttpActionResult Get(DateTime FechaMayor, DateTime FechaMenor, int DNI)
        {
            List<ReporteListaAtencionFiltrada> reporteListaAtencionFiltradas = ReporteListaAtencionFiltrada.ConvertirLista(LogicaPrincipal.Instancia.ListadoAntencionesFiltrado(FechaMayor, FechaMenor, DNI));
            if (reporteListaAtencionFiltradas !=null)
            {
                return Ok(reporteListaAtencionFiltradas);
            }
            
            RespuestaServicio.instanciaRespuesta.Detalle = "No se encontro atenciones para ese rango de fechas";
            return Ok(RespuestaServicio.instanciaRespuesta.Detalle);
        }

        // POST api/values
        public IHttpActionResult Post([FromBody] int DNI, int IDcobertura, string NombreEnfermedad, DateTime FechaAtencion)
        {
            RespuestaServicio.instanciaRespuesta.Resultado = LogicaPrincipal.Instancia.CargarAtencion(DNI, NombreEnfermedad, IDcobertura, FechaAtencion).Resultado;
            RespuestaServicio.instanciaRespuesta.Detalle = LogicaPrincipal.Instancia.CargarAtencion(DNI, NombreEnfermedad, IDcobertura, FechaAtencion).Detalle;
            if (RespuestaServicio.instanciaRespuesta.Resultado)
            {
                return Ok(RespuestaServicio.instanciaRespuesta.Detalle);
            }
            return Ok(RespuestaServicio.instanciaRespuesta.Detalle);
        }

       
    }
}
