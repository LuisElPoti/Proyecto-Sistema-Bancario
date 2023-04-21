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
        public List<Prestamo> GetPrestamosbyID(int id)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                var Prestamos = new List<Prestamo>();
                var conn = db.Database.Connection;
                var connectionState = conn.State;

                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "spGetPerfilById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("IdPefil", id));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Prestamo Prestamo = new Prestamo();
                            Prestamo.idPrestamo = int.Parse(reader[0].ToString());
                            Prestamo.idCuenta = reader.GetInt16(reader.GetOrdinal("idCuenta"));
                            Prestamo.Tasa = reader.GetDecimal(reader.GetOrdinal("Tasa"));
                            Prestamo.MontoActual = reader.GetDecimal(reader.GetOrdinal("MontoActual"));
                            Prestamo.MontoOriginal = reader.GetDecimal(reader.GetOrdinal("MontoOriginal"));
                            Prestamo.FechaCorte = reader.GetDateTime(reader.GetOrdinal("FechCorte"));
                            Prestamo.FechaIngreso = reader.GetDateTime(reader.GetOrdinal("FechaIngreso"));

                            Prestamos.Add(Prestamo);
                        }
                    }
                }

                //catch (Exception ex)
                //{
                //    log.Error("Fallo select por ID: " + ex);
                //    throw;
                //}
                //finally
                //{
                //    if (connectionState != ConnectionState.Closed) conn.Close();
                //}
                return Prestamos;
            }
        }

        public bool InsertPrestamo(int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, DateTime fechaCorte)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
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
            using (DBCoreEntities1 db = new DBCoreEntities1())
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
            using (DBCoreEntities1 db = new DBCoreEntities1())
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

        }
    }
}