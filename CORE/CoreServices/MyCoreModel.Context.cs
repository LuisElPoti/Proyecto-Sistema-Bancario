﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreServices
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBCoreEntities : DbContext
    {
        public DBCoreEntities()
            : base("name=DBCoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<Beneficiario> Beneficiario { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<Cuenta_Beneficiario> Cuenta_Beneficiario { get; set; }
        public virtual DbSet<Detalle_Prestamo> Detalle_Prestamo { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<Movimiento> Movimiento { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Perfil_Rol> Perfil_Rol { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }
        public virtual DbSet<TipoTransaccion> TipoTransaccion { get; set; }
        public virtual DbSet<Transaccion> Transaccion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Log> Log { get; set; }
    
        public virtual int spDeleteCuenta(Nullable<int> idCuenta)
        {
            var idCuentaParameter = idCuenta.HasValue ?
                new ObjectParameter("idCuenta", idCuenta) :
                new ObjectParameter("idCuenta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteCuenta", idCuentaParameter);
        }
    
        public virtual int spDeletePerfil(Nullable<int> idPerfil)
        {
            var idPerfilParameter = idPerfil.HasValue ?
                new ObjectParameter("idPerfil", idPerfil) :
                new ObjectParameter("idPerfil", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeletePerfil", idPerfilParameter);
        }
    
        public virtual int spDeletePrestamo(Nullable<int> idPrestamo)
        {
            var idPrestamoParameter = idPrestamo.HasValue ?
                new ObjectParameter("idPrestamo", idPrestamo) :
                new ObjectParameter("idPrestamo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeletePrestamo", idPrestamoParameter);
        }
    
        public virtual int spDeleteTipoTransaccion(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteTipoTransaccion", idParameter);
        }
    
        public virtual int spDeleteUsuario(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteUsuario", idUsuarioParameter);
        }
    
        public virtual ObjectResult<spGetAllCliente_Result> spGetAllCliente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllCliente_Result>("spGetAllCliente");
        }
    
        public virtual ObjectResult<spGetAllCuenta_Result> spGetAllCuenta()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllCuenta_Result>("spGetAllCuenta");
        }
    
        public virtual ObjectResult<spGetAllPerfil_Result> spGetAllPerfil()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllPerfil_Result>("spGetAllPerfil");
        }
    
        public virtual ObjectResult<spGetAllPrestamo_Result> spGetAllPrestamo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllPrestamo_Result>("spGetAllPrestamo");
        }
    
        public virtual ObjectResult<spGetAllTipoTransaccion_Result> spGetAllTipoTransaccion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllTipoTransaccion_Result>("spGetAllTipoTransaccion");
        }
    
        public virtual ObjectResult<spGetAllUsuario_Result> spGetAllUsuario()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllUsuario_Result>("spGetAllUsuario");
        }
    
        public virtual ObjectResult<spGetClienteById_Result> spGetClienteById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetClienteById_Result>("spGetClienteById", idParameter);
        }
    
        public virtual ObjectResult<spGetCuentaById_Result> spGetCuentaById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetCuentaById_Result>("spGetCuentaById", idParameter);
        }
    
        public virtual ObjectResult<spGetPerfilById_Result> spGetPerfilById(Nullable<int> idPerfil)
        {
            var idPerfilParameter = idPerfil.HasValue ?
                new ObjectParameter("idPerfil", idPerfil) :
                new ObjectParameter("idPerfil", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetPerfilById_Result>("spGetPerfilById", idPerfilParameter);
        }
    
        public virtual ObjectResult<spGetPrestamoByCuenta_Result> spGetPrestamoByCuenta(Nullable<int> idCuenta)
        {
            var idCuentaParameter = idCuenta.HasValue ?
                new ObjectParameter("idCuenta", idCuenta) :
                new ObjectParameter("idCuenta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetPrestamoByCuenta_Result>("spGetPrestamoByCuenta", idCuentaParameter);
        }
    
        public virtual ObjectResult<spGetTipoTransaccionById_Result> spGetTipoTransaccionById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetTipoTransaccionById_Result>("spGetTipoTransaccionById", idParameter);
        }
    
        public virtual ObjectResult<spGetUsuarioById_Result> spGetUsuarioById(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUsuarioById_Result>("spGetUsuarioById", idUsuarioParameter);
        }
    
        public virtual int spInsertCliente(string nombre, Nullable<int> tipoDocumento, string documento, string correo, string telefono, string direccion, Nullable<System.DateTime> fechaNacimiento)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var tipoDocumentoParameter = tipoDocumento.HasValue ?
                new ObjectParameter("TipoDocumento", tipoDocumento) :
                new ObjectParameter("TipoDocumento", typeof(int));
    
            var documentoParameter = documento != null ?
                new ObjectParameter("Documento", documento) :
                new ObjectParameter("Documento", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertCliente", nombreParameter, tipoDocumentoParameter, documentoParameter, correoParameter, telefonoParameter, direccionParameter, fechaNacimientoParameter);
        }
    
        public virtual int spInsertCuenta(Nullable<int> idCliente, Nullable<int> idTipoCuenta, Nullable<int> idBanco, string numeroCuenta, Nullable<bool> estado)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            var idTipoCuentaParameter = idTipoCuenta.HasValue ?
                new ObjectParameter("idTipoCuenta", idTipoCuenta) :
                new ObjectParameter("idTipoCuenta", typeof(int));
    
            var idBancoParameter = idBanco.HasValue ?
                new ObjectParameter("idBanco", idBanco) :
                new ObjectParameter("idBanco", typeof(int));
    
            var numeroCuentaParameter = numeroCuenta != null ?
                new ObjectParameter("NumeroCuenta", numeroCuenta) :
                new ObjectParameter("NumeroCuenta", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertCuenta", idClienteParameter, idTipoCuentaParameter, idBancoParameter, numeroCuentaParameter, estadoParameter);
        }
    
        public virtual int spInsertPerfil(string nombre, string descripcion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertPerfil", nombreParameter, descripcionParameter);
        }
    
        public virtual int spInsertPrestamo(Nullable<int> idCuenta, Nullable<decimal> tasa, Nullable<decimal> montoOriginal, Nullable<decimal> montoActual, Nullable<System.DateTime> fechaCorte)
        {
            var idCuentaParameter = idCuenta.HasValue ?
                new ObjectParameter("idCuenta", idCuenta) :
                new ObjectParameter("idCuenta", typeof(int));
    
            var tasaParameter = tasa.HasValue ?
                new ObjectParameter("Tasa", tasa) :
                new ObjectParameter("Tasa", typeof(decimal));
    
            var montoOriginalParameter = montoOriginal.HasValue ?
                new ObjectParameter("MontoOriginal", montoOriginal) :
                new ObjectParameter("MontoOriginal", typeof(decimal));
    
            var montoActualParameter = montoActual.HasValue ?
                new ObjectParameter("MontoActual", montoActual) :
                new ObjectParameter("MontoActual", typeof(decimal));
    
            var fechaCorteParameter = fechaCorte.HasValue ?
                new ObjectParameter("FechaCorte", fechaCorte) :
                new ObjectParameter("FechaCorte", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertPrestamo", idCuentaParameter, tasaParameter, montoOriginalParameter, montoActualParameter, fechaCorteParameter);
        }
    
        public virtual int spInsertTipoTransaccion(string nombre, string descripcion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertTipoTransaccion", nombreParameter, descripcionParameter);
        }
    
        public virtual int spInsertUsuario(Nullable<int> idPerfil, string nombre, string clave)
        {
            var idPerfilParameter = idPerfil.HasValue ?
                new ObjectParameter("idPerfil", idPerfil) :
                new ObjectParameter("idPerfil", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("Clave", clave) :
                new ObjectParameter("Clave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertUsuario", idPerfilParameter, nombreParameter, claveParameter);
        }
    
        public virtual int spUpsertCliente(Nullable<int> id, string nombre, Nullable<int> tipoDocumento, string documento, string correo, string telefono, string direccion, Nullable<System.DateTime> fechaNacimiento)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var tipoDocumentoParameter = tipoDocumento.HasValue ?
                new ObjectParameter("TipoDocumento", tipoDocumento) :
                new ObjectParameter("TipoDocumento", typeof(int));
    
            var documentoParameter = documento != null ?
                new ObjectParameter("Documento", documento) :
                new ObjectParameter("Documento", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpsertCliente", idParameter, nombreParameter, tipoDocumentoParameter, documentoParameter, correoParameter, telefonoParameter, direccionParameter, fechaNacimientoParameter);
        }
    
        public virtual int spUpsertCuenta(Nullable<int> idCuenta, Nullable<bool> estado, Nullable<decimal> balance)
        {
            var idCuentaParameter = idCuenta.HasValue ?
                new ObjectParameter("idCuenta", idCuenta) :
                new ObjectParameter("idCuenta", typeof(int));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            var balanceParameter = balance.HasValue ?
                new ObjectParameter("Balance", balance) :
                new ObjectParameter("Balance", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpsertCuenta", idCuentaParameter, estadoParameter, balanceParameter);
        }
    
        public virtual int spUpsertPerfil(Nullable<int> idPerfil, string nombre, string descripcion)
        {
            var idPerfilParameter = idPerfil.HasValue ?
                new ObjectParameter("idPerfil", idPerfil) :
                new ObjectParameter("idPerfil", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpsertPerfil", idPerfilParameter, nombreParameter, descripcionParameter);
        }
    
        public virtual int spUpsertPrestamo(Nullable<int> idPrestamo, Nullable<int> idCuenta, Nullable<decimal> tasa, Nullable<decimal> montoOriginal, Nullable<decimal> montoActual, Nullable<System.DateTime> fechaCorte)
        {
            var idPrestamoParameter = idPrestamo.HasValue ?
                new ObjectParameter("idPrestamo", idPrestamo) :
                new ObjectParameter("idPrestamo", typeof(int));
    
            var idCuentaParameter = idCuenta.HasValue ?
                new ObjectParameter("idCuenta", idCuenta) :
                new ObjectParameter("idCuenta", typeof(int));
    
            var tasaParameter = tasa.HasValue ?
                new ObjectParameter("Tasa", tasa) :
                new ObjectParameter("Tasa", typeof(decimal));
    
            var montoOriginalParameter = montoOriginal.HasValue ?
                new ObjectParameter("MontoOriginal", montoOriginal) :
                new ObjectParameter("MontoOriginal", typeof(decimal));
    
            var montoActualParameter = montoActual.HasValue ?
                new ObjectParameter("MontoActual", montoActual) :
                new ObjectParameter("MontoActual", typeof(decimal));
    
            var fechaCorteParameter = fechaCorte.HasValue ?
                new ObjectParameter("FechaCorte", fechaCorte) :
                new ObjectParameter("FechaCorte", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpsertPrestamo", idPrestamoParameter, idCuentaParameter, tasaParameter, montoOriginalParameter, montoActualParameter, fechaCorteParameter);
        }
    
        public virtual int spUpsertTipoTransaccion(Nullable<int> id, string nombre, string descripcion)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpsertTipoTransaccion", idParameter, nombreParameter, descripcionParameter);
        }
    
        public virtual int spUpsertUsuario(Nullable<int> idUsuario, Nullable<int> idPerfil, string nombre, string clave)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            var idPerfilParameter = idPerfil.HasValue ?
                new ObjectParameter("idPerfil", idPerfil) :
                new ObjectParameter("idPerfil", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("Clave", clave) :
                new ObjectParameter("Clave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpsertUsuario", idUsuarioParameter, idPerfilParameter, nombreParameter, claveParameter);
        }
    
        public virtual ObjectResult<GetAllMovimientobyCuenta_Result> GetAllMovimientobyCuenta()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllMovimientobyCuenta_Result>("GetAllMovimientobyCuenta");
        }
    
        public virtual ObjectResult<GetAllPrestamobyCliente_Result> GetAllPrestamobyCliente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPrestamobyCliente_Result>("GetAllPrestamobyCliente");
        }
    
        public virtual ObjectResult<spGetCuentabyCliente_Result> spGetCuentabyCliente(Nullable<int> idCliente)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetCuentabyCliente_Result>("spGetCuentabyCliente", idClienteParameter);
        }
    
        public virtual int spOperaciones(Nullable<int> tipo, string numeroCuenta, Nullable<decimal> monto)
        {
            var tipoParameter = tipo.HasValue ?
                new ObjectParameter("Tipo", tipo) :
                new ObjectParameter("Tipo", typeof(int));
    
            var numeroCuentaParameter = numeroCuenta != null ?
                new ObjectParameter("NumeroCuenta", numeroCuenta) :
                new ObjectParameter("NumeroCuenta", typeof(string));
    
            var montoParameter = monto.HasValue ?
                new ObjectParameter("Monto", monto) :
                new ObjectParameter("Monto", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spOperaciones", tipoParameter, numeroCuentaParameter, montoParameter);
        }
    
        public virtual int spPagoPrestamo(Nullable<int> idPrestamo, Nullable<decimal> monto)
        {
            var idPrestamoParameter = idPrestamo.HasValue ?
                new ObjectParameter("idPrestamo", idPrestamo) :
                new ObjectParameter("idPrestamo", typeof(int));
    
            var montoParameter = monto.HasValue ?
                new ObjectParameter("Monto", monto) :
                new ObjectParameter("Monto", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spPagoPrestamo", idPrestamoParameter, montoParameter);
        }
    
        public virtual int TransferenciaMismoBanco(Nullable<decimal> monto, string cuentaOrigen, string cuentaDestino)
        {
            var montoParameter = monto.HasValue ?
                new ObjectParameter("monto", monto) :
                new ObjectParameter("monto", typeof(decimal));
    
            var cuentaOrigenParameter = cuentaOrigen != null ?
                new ObjectParameter("cuentaOrigen", cuentaOrigen) :
                new ObjectParameter("cuentaOrigen", typeof(string));
    
            var cuentaDestinoParameter = cuentaDestino != null ?
                new ObjectParameter("cuentaDestino", cuentaDestino) :
                new ObjectParameter("cuentaDestino", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TransferenciaMismoBanco", montoParameter, cuentaOrigenParameter, cuentaDestinoParameter);
        }
    
        public virtual ObjectResult<ValidarUsuario_Result> ValidarUsuario(string nombre, string clave)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ValidarUsuario_Result>("ValidarUsuario", nombreParameter, claveParameter);
        }
    
        public virtual int spDeleteCliente(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteCliente", idParameter);
        }
    
        public virtual ObjectResult<spCuentabyidCliente_Result> spCuentabyidCliente(Nullable<int> idCliente)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCuentabyidCliente_Result>("spCuentabyidCliente", idClienteParameter);
        }
    
        public virtual ObjectResult<spGetAllMovimientobyCuenta_Result> spGetAllMovimientobyCuenta()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllMovimientobyCuenta_Result>("spGetAllMovimientobyCuenta");
        }
    
        public virtual ObjectResult<spGetAllPrestamosbyCliente_Result> spGetAllPrestamosbyCliente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllPrestamosbyCliente_Result>("spGetAllPrestamosbyCliente");
        }
    }
}
