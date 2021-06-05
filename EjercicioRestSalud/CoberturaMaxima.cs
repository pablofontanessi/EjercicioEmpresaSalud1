using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestSalud
{
    public class CoberturaMaxima: Cobertura
    {
        public override int CostoCobertura()
        {
            return Enfermedad.CalculoCostoEnfermedades(this.ListaEnfermedades);
        }
    }
}
