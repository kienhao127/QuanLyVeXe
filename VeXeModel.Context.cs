﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_BANVEXEEntities : DbContext
    {
        public DB_BANVEXEEntities()
            : base("name=DB_BANVEXEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BENXE> BENXEs { get; set; }
        public virtual DbSet<CHUYENXE> CHUYENXEs { get; set; }
        public virtual DbSet<LICHTRINH> LICHTRINHs { get; set; }
        public virtual DbSet<LOAINGUOIDUNG> LOAINGUOIDUNGs { get; set; }
        public virtual DbSet<LOAIXE> LOAIXEs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<PHANCONG> PHANCONGs { get; set; }
        public virtual DbSet<TAIXE> TAIXEs { get; set; }
        public virtual DbSet<TINHTRANGCHUYENXE> TINHTRANGCHUYENXEs { get; set; }
        public virtual DbSet<TINHTRANGVE> TINHTRANGVEs { get; set; }
        public virtual DbSet<VE> VEs { get; set; }
        public virtual DbSet<XE> XEs { get; set; }
    
        public virtual ObjectResult<layDanhSachLichTrinh_Result> layDanhSachLichTrinh()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<layDanhSachLichTrinh_Result>("layDanhSachLichTrinh");
        }
    
        public virtual ObjectResult<dangNhap_Result> dangNhap(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dangNhap_Result>("dangNhap", emailParameter, passwordParameter);
        }
    
        public virtual ObjectResult<layTatCaLichTrinh_Result> layTatCaLichTrinh()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<layTatCaLichTrinh_Result>("layTatCaLichTrinh");
        }
    }
}
