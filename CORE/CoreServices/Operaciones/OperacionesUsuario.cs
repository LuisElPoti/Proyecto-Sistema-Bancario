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
        public List<Usuario> GetUsuario()
        {

            List<Usuario> clientes = new List<Usuario>();
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                var usuarios = new List<Usuario>();
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
                            while (reader.Read())
                            {
                                var usuario = new Usuario
                                {
                                    idUsuario = (int)reader[0],
                                    idCliente = (int)reader[1],
                                    idPerfil = (int)reader[2],
                                    Nombre = reader[3].ToString(),
                                    Clave = reader[4].ToString()
                                    // etc. para cada propiedad de Usuario
                                };
                                usuarios.Add(usuario);
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

                return usuarios;
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
        public List<Usuario> GetUsuarioID(int id)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                var usuarios = new List<Usuario>();
                var conn = db.Database.Connection;
                var connectionState = conn.State;

                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "spGetUsuarioById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("Id", id));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.idUsuario = (int)reader[0];
                            usuario.idCliente = (int)reader[1];
                            usuario.idPerfil = (int)reader[2];
                            usuario.Nombre = reader[3].ToString();
                            usuario.Clave = reader[4].ToString();
                            usuarios.Add(usuario);
                        }

                        
                    }
                }
                return usuarios;

            }
            

        }
    }
}