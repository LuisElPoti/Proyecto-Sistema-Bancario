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
    public class OperacionesPerfil
    {
        public List<Perfil> GetPerfil()
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                var perfiles = new List<Perfil>();
                try
                {
                    using (var cmd = db.Database.Connection.CreateCommand())
                    {
                        cmd.CommandText = "spGetAllPerfil";
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (cmd.Connection.State != ConnectionState.Open) cmd.Connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var perfil = new Perfil();
                                perfil.idPerfil = reader.GetInt32(reader.GetOrdinal("idPerfil"));
                                perfil.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                                perfil.Descripcion = reader.GetString(reader.GetOrdinal("Nombre"));
                                // Aquí deberías agregar el resto de las propiedades de Perfil
                                perfiles.Add(perfil);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los perfiles", ex);
                }
                return perfiles;
            }
        }

        public bool InsertPerfil(string nombre, string descripcion)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
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

        public bool UpdatePerfiles(int idPerfil, string nombre, string descripcion)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                int ReturnedValue = db.spUpsertPerfil(idPerfil, nombre, descripcion);

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

        public bool DeletePerfil(int id)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                int ReturnedValue = db.spDeletePerfil(id);

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
        
        public List <Perfil> GetPerfilbyID(int id)
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                var perfiles = new List<Perfil>();
                var conn = db.Database.Connection;
                var connectionState = conn.State;

                if (connectionState != ConnectionState.Open) conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "spGetPerfilbyID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("IdPerfil", id));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) {
                            Perfil perfil = new Perfil();
                            perfil.idPerfil = int.Parse(reader[0].ToString());
                            perfil.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                            perfil.Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"));
                            perfil.FechaIngreso = reader.GetDateTime(reader.GetOrdinal("FechaIngreso"));

                            perfiles.Add(perfil);


                        }
                    }
                }
                return perfiles;
            }

        }
        //public DataTable GetPerfilbyID(int id)
        //{
        //    using (DBCoreEntities1 db = new DBCoreEntities1())
        //    {
        //        var dt = new DataTable();
        //        var conn = db.Database.Connection;
        //        var connectionState = conn.State;
        //        try
        //        {
        //            if (connectionState != ConnectionState.Open) conn.Open();
        //            using (var cmd = conn.CreateCommand())
        //            {
        //                cmd.CommandText = "spGetPerfilById";
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.Add(new SqlParameter("Id", id));
        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    dt.Load(reader);
        //                }
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        finally
        //        {
        //            if (connectionState != ConnectionState.Closed) conn.Close();
        //        }
        //        return dt;
        //    }
        //}
    }
}