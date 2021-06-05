using EjercicioRestSalud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPIEmpresaSalud.Models
{
    public class ReporteListaAtencionFiltrada
    {
        public DateTime FechaAtencion { get; set; }
        public string NombrePaciente { get; set; }
        public string NombreEnfermedad { get; set; }
        public string NombreCobertura { get; set; }
        public int CostoEnfermedad { get; set; }

        public ReporteListaAtencionFiltrada(ReporteAtencionPorFecha reporteAtencionPorFecha)
        {
            this.FechaAtencion = reporteAtencionPorFecha.FechaAtencion;
            this.NombrePaciente = reporteAtencionPorFecha.NombrePaciente;
            this.NombreEnfermedad = reporteAtencionPorFecha.NombrePaciente;
            this.NombreCobertura = reporteAtencionPorFecha.NombreCobertura;
            this.CostoEnfermedad = reporteAtencionPorFecha.CostoEnfermedad;

        }
        internal static List<ReporteListaAtencionFiltrada> ConvertirLista(List<ReporteAtencionPorFecha> reporteAtencionPorFechas)
        {
            List<ReporteListaAtencionFiltrada> listaAtencionFiltradas = new List<ReporteListaAtencionFiltrada>();
            if (reporteAtencionPorFechas != null)
            {
                foreach (var atencion in reporteAtencionPorFechas)
                {
                    ReporteListaAtencionFiltrada reporteListaAtencionFiltrada = new ReporteListaAtencionFiltrada(atencion);
                    listaAtencionFiltradas.Add(reporteListaAtencionFiltrada);
                }
                return listaAtencionFiltradas;
            }
            return listaAtencionFiltradas;
        }
    }
}