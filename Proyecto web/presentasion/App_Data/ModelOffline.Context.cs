﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.App_Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_a7664c_tarea1Entities : DbContext
    {
        public db_a7664c_tarea1Entities()
            : base("name=db_a7664c_tarea1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Cuentas> Cuentas { get; set; }
        public virtual DbSet<Foro> Foro { get; set; }
    }
}