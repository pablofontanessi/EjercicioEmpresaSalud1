using EjercicioRestSalud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPIEmpresaSalud.Models
{
    public class CoberturaServicio
    {
        public int idCobertura { get; set; }
        public string Descripcion { get; set; }
        public string Empresa { get; set; }
        public int CantMaxGrupo { get; set; }
        public int CostoBase { get; set; }
        public List<EnfermedadServicio> ListaEnfermedades { get; set; }

        public CoberturaServicio(Cobertura cobertura)
        {
            this.idCobertura = cobertura.IDCobertura;
            this.Descripcion = cobertura.Descripcion;
            this.Empresa = cobertura.Empresa;
            this.CantMaxGrupo = cobertura.CantMaxGrupo;
            this.CostoBase = cobertura.CostoBase;
            this.ListaEnfermedades = EnfermedadServicio.ConversorServicio_Logica(cobertura.ListaEnfermedades);
        }
        public static Cobertura ConversorServicio_Logica(int ID)
        {
            Cobertura cobertura = LogicaPrincipal.Instancia.listadoCoberturas.Find(X => X.IDCobertura == ID);
            return cobertura;
        }
        public static CoberturaServicio ConversorServicio_Logica(Cobertura Cobertura)
        {
            CoberturaServicio cobertura = new CoberturaServicio(Cobertura);
            return cobertura;
        }
    }
}