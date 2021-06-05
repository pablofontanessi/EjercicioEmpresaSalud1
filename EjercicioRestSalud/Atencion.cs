using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestSalud
{
    public class Atencion
    {
        public Atencion(DateTime fechaAtencion, Enfermedad enfermedad, Persona persona, int idCobertura)
        {
            FechaAtencion = fechaAtencion;
            this.EnfermedadIngresada = enfermedad;
            this.Paciente = persona;
            IDAtencion = 1 + LogicaPrincipal.Instancia.ObtenerUltimoNroAtencion();
            CoberturaPaciente = LogicaPrincipal.Instancia.listadoCoberturas.Find(x => x.IDCobertura == idCobertura);
        }

        public Persona Paciente { get; set; }
        public Enfermedad EnfermedadIngresada { get; set; }
        public DateTime FechaAtencion { get; set; }
        public int IDAtencion { get; set; }
        public Cobertura CoberturaPaciente { get; set; }

    }
}
