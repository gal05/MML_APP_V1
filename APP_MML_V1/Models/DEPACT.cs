//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APP_MML_V1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEPACT
    {
        public string ANODEP { get; set; }
        public string MESDEP { get; set; }
        public string CODGEN { get; set; }
        public string CODESP { get; set; }
        public string CODART { get; set; }
        public string TIPBIE { get; set; }
        public string NUMSEC { get; set; }
        public Nullable<decimal> VALCOM { get; set; }
        public Nullable<decimal> VALDEP { get; set; }
        public Nullable<decimal> VALAJU { get; set; }
        public Nullable<System.DateTime> FECOPE { get; set; }
        public Nullable<decimal> VALLIB { get; set; }
        public string CODCTA { get; set; }
        public string ESTREG { get; set; }
    
        public virtual DATACT DATACT { get; set; }
    }
}
