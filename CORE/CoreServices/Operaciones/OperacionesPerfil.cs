using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace CoreServices.Clases
{
    public class OperacionesPerfil
    {
        public DbSet<Perfil> GetPerfil()
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                return db.Perfil;
            }
        }

        public bool InsertPerfil(string nombre, string descripcion)
        {
            using (DBCoreEntities db = new DBCoreEntities())
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
            using (DBCoreEntities db = new DBCoreEntities())
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
            using (DBCoreEntities db = new DBCoreEntities())
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
        
        public Perfil GetPerfilbyID(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {

                var Perfil = db.Perfil.Where(i => i.idPerfil == id).First();


                return Perfil;
            }
        }
    }
}