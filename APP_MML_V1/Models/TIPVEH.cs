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
    
    public partial class TIPVEH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPVEH()
        {
            this.VEHICULO = new HashSet<VEHICULO>();
        }
    
        public string CODTIP { get; set; }
        public string DESTIP { get; set; }
        public string ABRTIP { get; set; }
        public string USUARIO { get; set; }
        public Nullable<System.DateTime> FCONTROL { get; set; }
        public string ESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEHICULO> VEHICULO { get; set; }
    }
}
