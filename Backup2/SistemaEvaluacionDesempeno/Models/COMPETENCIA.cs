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
    using System.Collections.Generic;
    
    public partial class COMPETENCIA
    {
        public int ID_Competencia { get; set; }
        public string Comentarios { get; set; }
        public Nullable<int> No_Emp { get; set; }
        public Nullable<int> ID_Periodo { get; set; }
        public Nullable<int> ID_PlantillaEvaluacionExcempt { get; set; }
        public Nullable<int> ID_CalificacionDeRendimiento { get; set; }
        public int ID_Estatus_Evaluacion { get; set; }
        public Nullable<int> Evaluador { get; set; }
        public int ID_ReEvaluacion { get; set; }
        public string ComentariosJefe { get; set; }
        public Nullable<double> CalificacionJefe { get; set; }
    
        public virtual CALIFICACIONDERENDIMIENTO CALIFICACIONDERENDIMIENTO { get; set; }
        public virtual PERIODO PERIODO { get; set; }
        public virtual PLANTILLAEVALUACIONEXCEMPT PLANTILLAEVALUACIONEXCEMPT { get; set; }
        public virtual Re_Evaluacion Re_Evaluacion { get; set; }
    }
}