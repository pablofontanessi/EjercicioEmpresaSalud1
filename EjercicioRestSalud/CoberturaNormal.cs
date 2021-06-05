using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestSalud
{
    public class CoberturaNormal: Cobertura
    {
        public override int CostoCobertura()
        {
            int Costo = this.CostoBase + Enfermedad.PromedioCostoEnfermedades(this.ListaEnfermedades);

            return Costo;
        }
    }
}
