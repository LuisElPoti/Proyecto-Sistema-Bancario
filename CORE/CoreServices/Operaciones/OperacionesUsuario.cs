using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace CoreServices.Clases
{
    public class OperacionesUsuario
    {
        public DbSet<Usuario> GetUsuario()
        {
            using(DBCoreEntities db = new DBCoreEntities())
            {
                return db.Usuario;
            }
        }
        
        public bool InsertUsuario(int idPerfil, int idCliente, string nombre, string clave)
        {
            using(DBCoreEntities db = new DBCoreEntities())
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
            using (DBCoreEntities db = new DBCoreEntities())
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
            using (DBCoreEntities db = new DBCoreEntities())
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

        public Usuario GetUsuarioID(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                Usuario Usuario = null;

                try
                {
                    Usuario Correspondiente = db.Usuario.First((p) => p.idUsuario == id);

                    Usuario = new Usuario();

                    Usuario.idPerfil = Correspondiente.idPerfil;
                    Usuario.Nombre = Correspondiente.Nombre;
                    Usuario.Clave = Correspondiente.Clave;

                    return Usuario;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}