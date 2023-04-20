using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CoreServices.Operaciones
{
    public class OperacionesPrestamo
    {
        public DataTable GetPrestamos()
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
                        cmd.CommandText = "spGetAllPrestamo";
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

        public bool InsertPrestamo(int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, DateTime fechaCorte)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertPrestamo(idCuenta, tasa, montoOriginal, montoActual, fechaCorte);

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

        public bool UpdatePrestamos(int idPrestamo, int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, DateTime fechaCorte)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spUpsertPrestamo(idPrestamo, idCuenta, tasa, montoOriginal, montoActual, fechaCorte);

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

        public bool DeletePrestamo (int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spDeletePrestamo(id);

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

        public DataTable GetPrestamobyCuenta(int id)
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
                        cmd.CommandText = "spGetPrestamoByCuenta";
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