//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace obs_çalışma
{
    using System;
    using System.Collections.Generic;
    
    public partial class ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ogrenci()
        {
            this.ders_alir = new HashSet<ders_alir>();
        }
    
        public string no { get; set; }
        public string tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string danisman_id { get; set; }
        public string bolum_id { get; set; }
    
        public virtual bolum bolum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ders_alir> ders_alir { get; set; }
        public virtual ogretmen ogretmen { get; set; }
    }
}
