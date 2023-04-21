﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAJA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBCajaEntities : DbContext
    {
        public DBCajaEntities()
            : base("name=DBCajaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<caja> cajas { get; set; }
        public virtual DbSet<cajero> cajeros { get; set; }
        public virtual DbSet<cuadre> cuadres { get; set; }
        public virtual DbSet<estado_transaccion> estado_transaccion { get; set; }
        public virtual DbSet<recibo> recibos { get; set; }
        public virtual DbSet<sucursale> sucursales { get; set; }
        public virtual DbSet<tipo_transaccion> tipo_transaccion { get; set; }
        public virtual DbSet<transaccione> transacciones { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    
        public virtual int sp_insertar_cuadres(Nullable<int> id_cajero, Nullable<decimal> monto_inicial, Nullable<decimal> monto_final, Nullable<decimal> diferencia_cuadre)
        {
            var id_cajeroParameter = id_cajero.HasValue ?
                new ObjectParameter("id_cajero", id_cajero) :
                new ObjectParameter("id_cajero", typeof(int));
    
            var monto_inicialParameter = monto_inicial.HasValue ?
                new ObjectParameter("monto_inicial", monto_inicial) :
                new ObjectParameter("monto_inicial", typeof(decimal));
    
            var monto_finalParameter = monto_final.HasValue ?
                new ObjectParameter("monto_final", monto_final) :
                new ObjectParameter("monto_final", typeof(decimal));
    
            var diferencia_cuadreParameter = diferencia_cuadre.HasValue ?
                new ObjectParameter("diferencia_cuadre", diferencia_cuadre) :
                new ObjectParameter("diferencia_cuadre", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insertar_cuadres", id_cajeroParameter, monto_inicialParameter, monto_finalParameter, diferencia_cuadreParameter);
        }
    
        public virtual int sp_insertar_recibo(Nullable<int> id_transaccion, Nullable<decimal> monto_transaccion)
        {
            var id_transaccionParameter = id_transaccion.HasValue ?
                new ObjectParameter("id_transaccion", id_transaccion) :
                new ObjectParameter("id_transaccion", typeof(int));
    
            var monto_transaccionParameter = monto_transaccion.HasValue ?
                new ObjectParameter("monto_transaccion", monto_transaccion) :
                new ObjectParameter("monto_transaccion", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insertar_recibo", id_transaccionParameter, monto_transaccionParameter);
        }
    
        public virtual int sp_insertar_transaccion(Nullable<int> id_cajero, Nullable<int> num_cuenta_origen, Nullable<int> num_cuenta_destino, Nullable<int> id_tipo_transaccion, Nullable<int> id_prestamo, Nullable<int> id_moneda, Nullable<decimal> monto_transaccion, Nullable<int> id_estado_transaccion)
        {
            var id_cajeroParameter = id_cajero.HasValue ?
                new ObjectParameter("id_cajero", id_cajero) :
                new ObjectParameter("id_cajero", typeof(int));
    
            var num_cuenta_origenParameter = num_cuenta_origen.HasValue ?
                new ObjectParameter("num_cuenta_origen", num_cuenta_origen) :
                new ObjectParameter("num_cuenta_origen", typeof(int));
    
            var num_cuenta_destinoParameter = num_cuenta_destino.HasValue ?
                new ObjectParameter("num_cuenta_destino", num_cuenta_destino) :
                new ObjectParameter("num_cuenta_destino", typeof(int));
    
            var id_tipo_transaccionParameter = id_tipo_transaccion.HasValue ?
                new ObjectParameter("id_tipo_transaccion", id_tipo_transaccion) :
                new ObjectParameter("id_tipo_transaccion", typeof(int));
    
            var id_prestamoParameter = id_prestamo.HasValue ?
                new ObjectParameter("id_prestamo", id_prestamo) :
                new ObjectParameter("id_prestamo", typeof(int));
    
            var id_monedaParameter = id_moneda.HasValue ?
                new ObjectParameter("id_moneda", id_moneda) :
                new ObjectParameter("id_moneda", typeof(int));
    
            var monto_transaccionParameter = monto_transaccion.HasValue ?
                new ObjectParameter("monto_transaccion", monto_transaccion) :
                new ObjectParameter("monto_transaccion", typeof(decimal));
    
            var id_estado_transaccionParameter = id_estado_transaccion.HasValue ?
                new ObjectParameter("id_estado_transaccion", id_estado_transaccion) :
                new ObjectParameter("id_estado_transaccion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insertar_transaccion", id_cajeroParameter, num_cuenta_origenParameter, num_cuenta_destinoParameter, id_tipo_transaccionParameter, id_prestamoParameter, id_monedaParameter, monto_transaccionParameter, id_estado_transaccionParameter);
        }
    }
}
