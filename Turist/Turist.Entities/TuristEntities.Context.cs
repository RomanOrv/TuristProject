﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Turist.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class turistEntities : DbContext
    {
        public turistEntities()
            : base("name=turistEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Informative> Informatives { get; set; }
        public DbSet<Safety> Safeties { get; set; }
        public DbSet<StaffQualification> StaffQualifications { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Сomfort> Сomfort { get; set; }
    }
}
