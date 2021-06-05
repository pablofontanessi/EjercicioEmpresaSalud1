using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestSalud
{
    public class ReporteAtencionPorFecha
    {
        public DateTime FechaAtencion { get; set; }
        public string NombrePaciente { get; set; }
        public string NombreEnfermedad { get; set; }
        public string NombreCobertura { get; set; }
        public int CostoEnfermedad { get; set; }
    }
}
