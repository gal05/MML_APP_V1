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
    
    public partial class PAIS_P
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PAIS_P()
        {
            this.DEPARTAMENTO_P = new HashSet<DEPARTAMENTO_P>();
        }
    
        public string COD_PAIS { get; set; }
        public string DES_PAIS { get; set; }
        public string ESTADO { get; set; }
        public Nullable<System.DateTime> FCONTROL { get; set; }
        public string USUARIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTAMENTO_P> DEPARTAMENTO_P { get; set; }
    }
}
