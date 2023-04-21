using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Linq;
using System.Web;
using INTEGRACION.Servicios;
using System.Data;
using System.Data.SqlClient;

namespace INTEGRACION.Operaciones
{
    public class OperacionesTipoTransaccion
    {
        public DataTable GetAllTipoTransaccion()
        {
            using (DBIntegracionEntities db = new DBIntegracionEntities())
            {
                var dt = new DataTable();
                var conn = db.Database.Connection;
                var connectionState = conn.State;
                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "spGetAllTipoTransaccion";
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

        public bool InsertTipoTransaccion(string nombre, string descripcion)
        {
            using (DBIntegracionEntities db = new DBIntegracionEntities())
            {
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertTipoTransaccion(nombre, descripcion);

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

        public bool UpdateTipoTransaccion(int id, string nombre, string descripcion)
        {
            using (DBIntegracionEntities db = new DBIntegracionEntities())
            {
                int ReturnedValue = db.spUpsertTipoTransaccion(id, nombre, descripcion);

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

        public bool DeleteTipoTransaccion(int id)
        {
            using (DBIntegracionEntities db = new DBIntegracionEntities())
            {
                int ReturnedValue = db.spDeleteTipoTransaccion(id);

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

        public DataTable GetTipoTransaccionbyID(int id)
        {
            using (DBIntegracionEntities db = new DBIntegracionEntities())
            {
                var dt = new DataTable();
                var conn = db.Database.Connection;
                var connectionState = conn.State;
                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "spGetTipoTransaccionById";
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