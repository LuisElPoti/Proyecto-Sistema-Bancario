using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using log4net;
using System.Xml.Linq;

namespace CoreServices.Operaciones
{
    public class OperacionesCliente
    {
        log4net.ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                try
                {
                    var cmd = db.Database.Connection.CreateCommand();
                    cmd.CommandText = "spGetAllCliente";
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (cmd.Connection.State != ConnectionState.Open)
                    {
                        cmd.Connection.Open();
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente();
                            cliente.idCliente = reader.GetInt32(reader.GetOrdinal("Id"));
                            cliente.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                            cliente.TipoDocumento = reader.GetInt32(reader.GetOrdinal("TipoDocumento"));
                            cliente.Documento = reader.GetString(reader.GetOrdinal("Documento"));
                            cliente.Correo = reader.GetString(reader.GetOrdinal("Correo"));
                            cliente.Telefono = reader.GetString(reader.GetOrdinal("Telefono"));
                            cliente.Direccion = reader.GetString(reader.GetOrdinal("Direccion"));
                            cliente.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));

                            clientes.Add(cliente);
                        }
                    }
                    log.Info("Ayuda.");
                }
                catch (Exception ex)
                {
                    log.Error("Select Clientes Fallido." + ex);
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
            return clientes;
        }
    

        public bool InsertCliente(string nombre, int tipoDocumento, string documento, string correo, string telefono, string direccion, DateTime fechaNacimiento)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
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

        public bool EliminarCliente(int id)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                try
                {
                    ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                    db.spDeleteCliente(id);

                    log.Info("Something");
                    return true;
                }
                catch (Exception ex)
                {
                    log.Error("Fallo Insert Clientes: " + ex);
                    return false;
                }
            }
        }
        public bool UpdateClientes(int id, string nombre, int tipoDocumento, string documento, string correo, string telefono, string direccion, DateTime fechaNacimiento)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
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

        public List<Cliente> GetClientebyID(int id)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                var clientes = new List<Cliente>();
                var conn = db.Database.Connection;
                var connectionState = conn.State;
                
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "spGetClienteById";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("Id", id));
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente();
                                cliente.idCliente = int.Parse(reader[0].ToString());     
                                cliente.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                                cliente.TipoDocumento = reader.GetInt32(reader.GetOrdinal("TipoDocumento"));
                                cliente.Documento = reader.GetString(reader.GetOrdinal("Documento"));
                                cliente.Correo = reader.GetString(reader.GetOrdinal("Correo"));
                                cliente.Telefono = reader.GetString(reader.GetOrdinal("Telefono"));
                                cliente.Direccion = reader.GetString(reader.GetOrdinal("Direccion"));
                                cliente.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));

                                clientes.Add(cliente);
                            }
                        }
                    }
                    log.Info("Select por ID Realizado.");
                
                //catch (Exception ex)
                //{
                //    log.Error("Fallo select por ID: " + ex);
                //    throw;
                //}
                //finally
                //{
                //    if (connectionState != ConnectionState.Closed) conn.Close();
                //}
                return clientes;
            }
        }
    }
}