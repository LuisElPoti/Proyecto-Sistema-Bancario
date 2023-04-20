using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace CoreServices.Clases
{
    public class OperacionesUsuario
    {
        public spGetAllUsuario_Result[] GetUsuario()
        {
            using(DBCoreEntities db = new DBCoreEntities())
            {
                return db.spGetAllUsuario().ToArray();
            }
        }
        
        public bool InsertUsuario(int idPerfil, string nombre, string clave)
        {
            using(DBCoreEntities db = new DBCoreEntities())
            {
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertUsuario(idPerfil, nombre, clave);

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

        public bool UpdateUsuario(int idUsuario, int idPerfil, string nombre, string clave)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spUpsertUsuario(idUsuario, idPerfil, nombre, clave);

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