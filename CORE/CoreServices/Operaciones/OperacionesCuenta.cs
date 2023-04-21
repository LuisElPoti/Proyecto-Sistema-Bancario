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
        public List<Cuenta> GetCuentas()
        {
            List<Cuenta> Cuentas = new List<Cuenta>();
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                try
                {
                    var cmd = db.Database.Connection.CreateCommand();
                    cmd.CommandText = "spGetAllCuenta";
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (cmd.Connection.State != ConnectionState.Open)
                    {
                        cmd.Connection.Open();
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cuenta Cuenta = new Cuenta();
                            Cuenta.idCuenta = reader.GetInt32(reader.GetOrdinal("idCuenta"));
                            Cuenta.idCliente = reader.GetInt32(reader.GetOrdinal("idCliente"));
                            Cuenta.idTipoCuenta = reader.GetInt32(reader.GetOrdinal("idTipoCuenta"));
                            Cuenta.idBanco = reader.GetInt32(reader.GetOrdinal("idBanco"));
                            Cuenta.NumeroCuenta = reader.GetString(reader.GetOrdinal("NumeroCuenta"));
                            Cuenta.Estado = reader.GetBoolean(reader.GetOrdinal("Estado"));
                            Cuenta.Balance = reader.GetDecimal(reader.GetOrdinal("Balance"));
                            Cuenta.FechaIngreso = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));

                            Cuentas.Add(Cuenta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    if (db.Database.Connection.State != ConnectionState.Closed)
                    {
                        db.Database.Connection.Close();
                    }
                }
            }
            return Cuentas;
        }
        public bool InsertCuentas(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
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
            using (DBCoreEntities1 db = new DBCoreEntities1())
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
            using (DBCoreEntities1 db = new DBCoreEntities1())
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

        public List<Cuenta> GetCuentabyID(int id)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                var Cuentas = new List<Cuenta>();
                var conn = db.Database.Connection;
                var connectionState = conn.State;

                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "spGetCuentaById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("Id", id));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cuenta Cuenta = new Cuenta();
                            Cuenta.idCuenta = int.Parse(reader[0].ToString());      //GetInt32(reader.GetOrdinal("Id"));
                            Cuenta.idCliente = reader.GetInt32(reader.GetOrdinal("idCliente"));
                            Cuenta.idTipoCuenta = reader.GetInt32(reader.GetOrdinal("idTipoCuenta"));
                            Cuenta.idBanco = reader.GetInt32(reader.GetOrdinal("idBanco"));
                            Cuenta.NumeroCuenta = reader.GetString(reader.GetOrdinal("NumeroCuenta"));
                            Cuenta.Estado = reader.GetBoolean(reader.GetOrdinal("Estado"));
                            Cuenta.Balance = reader.GetDecimal(reader.GetOrdinal("Balance"));
                            Cuenta.FechaIngreso = reader.GetDateTime(reader.GetOrdinal("FechaIngreso"));

                            Cuentas.Add(Cuenta);
                        }
                    }
                }
                return Cuentas;
            }
        }

        public List<Cuenta> GetCuentabyCliente(int idCliente)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                var Cuentas = new List<Cuenta>();
                var conn = db.Database.Connection;
                var connectionState = conn.State;

                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "spGetCuentaByCliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cuenta Cuenta = new Cuenta();
                            Cuenta.idCuenta = int.Parse(reader[0].ToString());      //GetInt32(reader.GetOrdinal("Id"));
                            Cuenta.idCliente = reader.GetInt32(reader.GetOrdinal("idCliente"));
                            Cuenta.idTipoCuenta = reader.GetInt32(reader.GetOrdinal("idTipoCuenta"));
                            Cuenta.idBanco = reader.GetInt32(reader.GetOrdinal("idBanco"));
                            Cuenta.NumeroCuenta = reader.GetString(reader.GetOrdinal("NumeroCuenta"));
                            Cuenta.Estado = reader.GetBoolean(reader.GetOrdinal("Estado"));
                            Cuenta.Balance = reader.GetDecimal(reader.GetOrdinal("Balance"));
                            Cuenta.FechaIngreso = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));

                            Cuentas.Add(Cuenta);
                        }
                    }
                }
                return Cuentas;
            }
        }

        public bool Deposito_Retiro(int Tipo, string NumeroCuenta, decimal Monto)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                int ReturnedValue = db.spOperaciones(Tipo, NumeroCuenta, Monto);

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

        public bool Pago(int idCliente, decimal Monto)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                int ReturnedValue = db.spPagoPrestamo(idCliente,Monto);

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

        //public bool InsertTransferencia(int idTipo, int idMoneda, int idEstado, int CuentaOrigen, int CuentaDestino, decimal Monto)
        //{
        //    using (DBCoreEntities1 db = new DBCoreEntities1())
        //    {
        //        int ReturnedValue = db.spInsertTransaccion(idTipo, idMoneda, idEstado, CuentaOrigen, CuentaDestino, Monto);

        //        if(ReturnedValue >= 1)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

        //}

        public bool Transferencia_Mismo(int CuentaOrigen, int CuentaDestino, decimal Monto)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                int ReturnedValue = db.TransferenciaMismoBanco(Monto,CuentaOrigen,CuentaDestino);

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