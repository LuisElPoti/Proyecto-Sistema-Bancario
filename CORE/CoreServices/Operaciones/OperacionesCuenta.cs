using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CoreServices.Clases
{
    public class OperacionesCuenta
    {        
        public DataTable GetCuentas()
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
                        cmd.CommandText = "spGetAllCuenta";
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch(Exception)
                {
                    throw;
                }
                finally
                {
                    if(connectionState != ConnectionState.Closed) conn.Close();
                }
                return dt;
            }
        }

        public bool InsertCuentas(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertCuenta(idCliente, idTipoCuenta, idBanco, NumeroCuenta, Estado);

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

        public bool UpdateCuentas(int idCuenta, bool Estado, decimal Balance)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spUpsertCuenta(idCuenta, Estado, Balance);

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

        public bool DeleteCuentas(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spDeleteCuenta(id);

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

        public DataTable GetCuentabyID(int id)
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
                        cmd.CommandText = "spGetCuentaById";
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