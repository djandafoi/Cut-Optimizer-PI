﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_PI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CutOptimizerEntities3 : DbContext
    {
        public CutOptimizerEntities3()
            : base("name=CutOptimizerEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Materijal> Materijals { get; set; }
        public virtual DbSet<Materijal_na_Skladište> Materijal_na_Skladište { get; set; }
        public virtual DbSet<Ostatak> Ostataks { get; set; }
        public virtual DbSet<Plan_rezanja> Plan_rezanja { get; set; }
        public virtual DbSet<Skladišna_primka> Skladišna_primka { get; set; }
        public virtual DbSet<Skladište> Skladište { get; set; }
        public virtual DbSet<Stavka_primke> Stavka_primke { get; set; }
        public virtual DbSet<Stavka_rezanja> Stavka_rezanja { get; set; }
    }
}
