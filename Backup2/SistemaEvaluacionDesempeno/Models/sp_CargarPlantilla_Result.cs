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
    
    public partial class sp_CargarPlantilla_Result
    {
        public int ID_PlantillaEvaluacionExcempt { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Contenido { get; set; }
        public string TipoDeCompetencia { get; set; }
        public string NombreTipoDePlantillaEvaluacion { get; set; }
        public Nullable<short> OrdenPlantilla { get; set; }
    }
}