
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestSalud
{
    public class LogicaPrincipal
    {
        private static LogicaPrincipal instancia = new LogicaPrincipal();
        private LogicaPrincipal()
        { }

        public static LogicaPrincipal Instancia { get { return instancia; } }
        public List<Cobertura> listadoCoberturas = new List<Cobertura>();

        internal int ObtenerUltimoNroAtencion()
        {
            return listadoAtenciones.Count();
        }



        public List<Persona> listadoPersonas = new List<Persona>();
        public List<Atencion> listadoAtenciones = new List<Atencion>();
        public List<Enfermedad> listadoEnfermedades = new List<Enfermedad>();
        public Respuesta VerificacionPersonaCobertura(Cobertura cobertura, int DNI)
        {
            
            if (cobertura.CostoCobertura() < listadoPersonas.Find(x => x.DNI == DNI).IngresosNetos )
            {
                Respuesta.instanciaRespuesta.Resultado = true;
             
                return Respuesta.instanciaRespuesta;
            }
            Respuesta.instanciaRespuesta.Resultado = false;
            Respuesta.instanciaRespuesta.Detalle = $"Sus ingresos no permiten la cobertura seleccionada: {cobertura.Descripcion}";
            return Respuesta.instanciaRespuesta;
        }

        public Respuesta CargarAtencion(int DNI, string NombreEnfermedad, int IdCobertura, DateTime FechaAtencion)
        {
            if (listadoCoberturas.Find(x => x.IDCobertura == IdCobertura).ListaEnfermedades.Find(x => x.Nombre == NombreEnfermedad ) != null & VerificacionPersonaCobertura(listadoCoberturas.Find(x => x.IDCobertura == IdCobertura), DNI).Resultado)
            {
                Atencion NuevaAtencion = new Atencion(FechaAtencion, listadoEnfermedades.Find(x => x.Nombre == NombreEnfermedad), listadoPersonas.Find(x => x.DNI == DNI), IdCobertura);
                Respuesta.instanciaRespuesta.Resultado = true;
                Respuesta.instanciaRespuesta.Detalle = $"El precio de la enfermedad es {listadoEnfermedades.Find(x => x.Nombre == NombreEnfermedad).Costo}";
                return Respuesta.instanciaRespuesta;
            }
            Respuesta.instanciaRespuesta.Resultado = false;
            Respuesta.instanciaRespuesta.Detalle = "No tiene la cobertura para esa enfermedad";
            return Respuesta.instanciaRespuesta;
        }

        public List<ReporteAtencionPorFecha> ListadoAntencionesFiltrado(DateTime fechaMayor, DateTime fechaMenor, int dNI)
        {
            List<ReporteAtencionPorFecha> listadoFiltrado = new List<ReporteAtencionPorFecha>();
            foreach (var atencion in listadoAtenciones)
            {
                if (atencion.FechaAtencion >= fechaMenor && atencion.FechaAtencion <= fechaMayor)
                {
                    ReporteAtencionPorFecha atencionFiltrada = new ReporteAtencionPorFecha();
                    atencionFiltrada.FechaAtencion = atencion.FechaAtencion;
                    atencionFiltrada.NombrePaciente = atencion.Paciente.Nombre +" " + atencion.Paciente.Apellido;
                    atencionFiltrada.NombreCobertura = atencion.CoberturaPaciente.Descripcion;
                    atencionFiltrada.NombreEnfermedad = atencion.EnfermedadIngresada.Nombre;
                    atencionFiltrada.CostoEnfermedad = atencion.EnfermedadIngresada.Costo;
                    listadoFiltrado.Add(atencionFiltrada);
                }
            }

            listadoFiltrado = listadoFiltrado.OrderByDescending(x => x.CostoEnfermedad).ToList();


            return listadoFiltrado;
            
        }
    }
}
