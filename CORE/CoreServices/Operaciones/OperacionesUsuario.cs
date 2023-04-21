using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace CoreServices.Clases
{
    public class OperacionesUsuario
    {
        public DataTable GetUsuario()
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                var dt = new DataTable();
                var conn = db.Database.Connection;
                var connectionState = conn.State;
                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "spGetAllUsuario";
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
        
        public bool InsertUsuario(int idPerfil, int idCliente, string nombre, string clave)
        {
            using(DBCoreEntities1 db = new DBCoreEntities1())
            {
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertUsuario(idPerfil, idCliente, nombre, clave);

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

        public bool UpdateUsuario(int idUsuario, int idPerfil, int idCliente, string nombre, string clave)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                int ReturnedValue = db.spUpsertUsuario(idUsuario, idPerfil, idCliente, nombre, clave);

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

        public bool DeleteUsuarios(int id)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                int ReturnedValue = db.spDeleteUsuario(id);

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

        public bool ContraseñaSegura(string clave)
        {
            return Regex.IsMatch(clave, @"^(?=.\d)(?=.[a-z])(?=.[A-Z])(?!.\s).{8,}$");
        }

        public bool ValidarUsuario(string nombre, string clave)
        {
            using(DBCoreEntities1 db = new DBCoreEntities1()) 
            {
                var conn = db.Database.Connection;
                var connectionState = conn.State;
                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "ValidarUsuario";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("nombre", nombre));
                        cmd.Parameters.Add(new SqlParameter("clave", clave));
                        using (var reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
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
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (connectionState != ConnectionState.Closed) conn.Close();
                }
            }
        }
        public DataTable GetUsuarioID(int id)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                var Cliente = db.Cliente();
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertPerfil(nombre, descripcion);

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
    }
}