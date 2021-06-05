using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestSalud
{
    public abstract class Cobertura
    {
        public int IDCobertura { get; set; }
        public string Descripcion { get; set; }
        public string Empresa { get; set; }
        public int CantMaxGrupo { get; set; }
        public int CostoBase { get; set; }
        public List<Enfermedad> ListaEnfermedades { get; set; }

        public virtual int  CostoCobertura()
        {
            return CostoBase;
        }
    }
}
