using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace INTEGRACION.Operaciones
{
    public class OperacionesPerfil
    {
        public DataTable GetPerfil()
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
                        cmd.CommandText = "spGetAllPerfil";
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
        public bool InsertPerfil(string nombre, string descripcion)
        {
            using (DBIntegracionEntities db = new DBIntegracionEntities())
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
            using (DBIntegracionEntities db = new DBIntegracionEntities())
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
            using (DBIntegracionEntities db = new DBIntegracionEntities())
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

        public List<Perfil> GetPerfilbyID(int id)
        {
            using (DBIntegracionEntities db = new DBIntegracionEntities())
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
                        while (reader.Read())
                        {
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
    }
}