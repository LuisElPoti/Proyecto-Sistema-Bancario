using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CoreServices.Operaciones
{
    public class OperacionesCliente
    {

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
                }
                catch (Exception)
                {
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
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertCliente(nombre, tipoDocumento, documento, correo, telefono, direccion, fechaNacimiento);

                if (Convert.ToInt32(ReturnedValue.Value) >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdateClientes(int id, string nombre, int tipoDocumento, string documento, string correo, string telefono, string direccion, DateTime fechaNacimiento)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spUpsertCliente(id, nombre, tipoDocumento, documento, correo, telefono, direccion, fechaNacimiento);

                if (ReturnedValue >= 1)
                {
                    return true;
                }
                else
                {
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
                }
                catch (Exception)
                {
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