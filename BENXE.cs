//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyVeXe
{
    using System;
    using System.Collections.Generic;
    
    public partial class BENXE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BENXE()
        {
            this.LICHTRINHs = new HashSet<LICHTRINH>();
            this.LICHTRINHs1 = new HashSet<LICHTRINH>();
        }
    
        public string MaBenXe { get; set; }
        public string TenBenXe { get; set; }
        public string DiemXuatPhat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHTRINH> LICHTRINHs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHTRINH> LICHTRINHs1 { get; set; }
    }
}