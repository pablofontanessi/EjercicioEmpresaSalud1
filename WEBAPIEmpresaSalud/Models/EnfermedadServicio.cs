using EjercicioRestSalud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPIEmpresaSalud.Models
{
    public class EnfermedadServicio
    {
        public string TipoEnfermedad { get; set; }
        public string Nombre { get; set; }
        public int Costo { get; set; }
        public EnfermedadServicio(Enfermedad enfermedad)
        {
            this.TipoEnfermedad = enfermedad.TipoEnfermedad;
            this.Nombre = enfermedad.Nombre;
            this.Costo = enfermedad.Costo;
        }
        public  static List<EnfermedadServicio> ConversorServicio_Logica(List<Enfermedad> listaEnfermedades)
        {
            List<EnfermedadServicio> lista = new List<EnfermedadServicio>();
            foreach (var enfemedad in listaEnfermedades)
            {
                EnfermedadServicio enfermedadServicio = new EnfermedadServicio(enfemedad);
                lista.Add(enfermedadServicio);
            }
            return lista;
        }
    }
}