//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaEvaluacionDesempeno.Models
{
    using System;
    
    public partial class sp_MisObjetivosRealizados_Result
    {
        public int ID_Objetivo { get; set; }
        public int No_Emp { get; set; }
        public int ID_Periodo { get; set; }
        public string Descripcion { get; set; }
        public int Peso { get; set; }
        public string EstadoDeObjetivo { get; set; }
        public System.DateTime FechaDeCreacion { get; set; }
        public Nullable<System.DateTime> FechaDeModificacion { get; set; }
        public Nullable<System.DateTime> FechaLimiteEsperada { get; set; }
        public Nullable<System.DateTime> FechaDeTerminacionDeObjetivo { get; set; }
        public string Comentarios { get; set; }
        public string Firma { get; set; }
    }
}