using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestSalud
{
     public class Enfermedad
    {
        public string TipoEnfermedad { get; set; }
        public string Nombre { get; set; }

        public static int CalculoCostoEnfermedades(List<Enfermedad> listaEnfermedades)
        {
            int Costo = 0;
            foreach (var enfermedad in listaEnfermedades)
            {
                Costo += enfermedad.Costo;
            }
            return Costo;
        }

        public int Costo { get; set; }

        public static int PromedioCostoEnfermedades(List<Enfermedad> listaEnfermedades)
        {
            int costo = CalculoCostoEnfermedades(listaEnfermedades) / listaEnfermedades.Count();
           
            return costo;
        }
    }
}
