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
    
    public partial class LICHTRINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LICHTRINH()
        {
            this.CHUYENXEs = new HashSet<CHUYENXE>();
        }
    
        public string MaLichTrinh { get; set; }
        public string ThoiGian { get; set; }
        public string QuangDuong { get; set; }
        public string MaBenDi { get; set; }
        public string MaBenDen { get; set; }
        public Nullable<int> MaLoaiXe { get; set; }
    
        public virtual BENXE BENXE { get; set; }
        public virtual BENXE BENXE1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUYENXE> CHUYENXEs { get; set; }
        public virtual LOAIXE LOAIXE { get; set; }
    }
}
