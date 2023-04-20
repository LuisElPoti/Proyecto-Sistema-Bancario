using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoreServices.Operaciones
{
    public class OperacionesPrestamo
    {
        public DbSet<Prestamo> GetPrestamos()
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                return db.Prestamo;
            }
        }

        public bool InsertPrestamo(int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, DateTime fechaCorte)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertPrestamo(idCuenta, tasa, montoOriginal, montoActual, fechaCorte);

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

        public bool UpdatePrestamos(int idPrestamo, int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, DateTime fechaCorte)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spUpsertPrestamo(idPrestamo, idCuenta, tasa, montoOriginal, montoActual, fechaCorte);

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

        public bool DeletePrestamo (int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spDeletePrestamo(id);

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

        public Prestamo GetPrestamobyID(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                var Prestamo = db.Prestamo.Where(i => i.idPrestamo == id).First();

                return Prestamo;
            }
        }
    }
}