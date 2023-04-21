﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using log4net;

namespace CoreServices.Operaciones
{
    public class OperacionesCliente
    {
<<<<<<< HEAD
        log4net.ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
=======
        log4net.ILog log = LogManager.GetLogger(System.Environment.MachineName);
>>>>>>> c464aed82b45e56291b718127524f420952a1d28
        public DataTable GetClientes()
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                var dt = new DataTable();
                var conn = db.Database.Connection;
                var connectionState = conn.State;
                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "spGetAllCliente";
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
<<<<<<< HEAD
                    log.Info("Ayuda.");
=======
                    log.Info("Success.");
>>>>>>> c464aed82b45e56291b718127524f420952a1d28
                }
                catch (Exception ex)
                {
                    log.Error("Select Clientes Fallido." + ex);
                    throw;
                }
                finally
                {
                    if (connectionState != ConnectionState.Closed) conn.Close();
                }
                return dt;
            }
        }

        public bool InsertCliente(string nombre, int tipoDocumento, string documento, string correo, string telefono, string direccion, DateTime fechaNacimiento)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                try
                {
                    ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                    db.spInsertCliente(nombre, tipoDocumento, documento, correo, telefono, direccion, fechaNacimiento);

                    log.Info("Something");
                    return true;
                }
                catch(Exception ex)
                {
                    log.Error("Fallo Insert Clientes: "+ex);
                    return false;
                }
            }
        }

        public bool UpdateClientes(int id, string nombre, int tipoDocumento, string documento, string correo, string telefono, string direccion, DateTime fechaNacimiento)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                try
                {
                    int ReturnedValue = db.spUpsertCliente(id, nombre, tipoDocumento, documento, correo, telefono, direccion, fechaNacimiento);

                    log.Info("Update Clientes Realizado.");
                    return true;
                }
                catch(Exception ex)
                {
                    log.Error("Fallo Update Clientes: "+ex);
                    return false;
                }
            }
        }

        public DataTable GetClientebyID(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                var dt = new DataTable();
                var conn = db.Database.Connection;
                var connectionState = conn.State;
                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "spGetClienteById";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("Id", id));
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    log.Info("Select por ID Realizado.");
                }
                catch (Exception ex)
                {
                    log.Error("Fallo select por ID: "+ex);
                    throw;
                }
                finally
                {
                    if (connectionState != ConnectionState.Closed) conn.Close();
                }
                return dt;
            }
        }
    }
}