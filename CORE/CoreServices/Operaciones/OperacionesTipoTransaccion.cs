using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CoreServices.Servicios;

namespace CoreServices.Operaciones
{
    public class OperacionesTipoTransaccion
    {
        public DbSet<TipoTransaccion> GetAllTipoTransaccion()
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                return db.TipoTransaccion;
            }
        }

        public bool InsertTipoTransaccion(string nombre, string descripcion)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertTipoTransaccion(nombre, descripcion);

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

        public bool UpdateTipoTransaccion(int id, string nombre, string descripcion)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spUpsertTipoTransaccion(id, nombre, descripcion);

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

        public bool DeleteTipoTransaccion(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spDeleteTipoTransaccion(id);

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

        public TipoTransaccion GetTipoTransaccionbyID(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {

                var TipoTransaccion = db.TipoTransaccion.Where(i => i.idTipo == id).First();


                return TipoTransaccion;
            }
        }
    }
}