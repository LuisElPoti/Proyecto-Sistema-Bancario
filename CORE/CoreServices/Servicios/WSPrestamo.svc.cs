using CoreServices.Operaciones;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CoreServices.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSPrestamo : IWSPrestamo
    {
        OperacionesPrestamo Operaciones = new OperacionesPrestamo();
        public bool CrearPrestamo(int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, DateTime fechaCorte)
        {
            return Operaciones.InsertPrestamo(idCuenta, tasa, montoOriginal, montoActual, fechaCorte);
        }

        public bool EliminarPrestamo(int id)
        {
            return Operaciones.DeletePrestamo(id);
        }
        public bool ActualizarPrestamo(int idPrestamo, int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, DateTime fechaCorte)
        {
            return Operaciones.UpdatePrestamos(idPrestamo, idCuenta, tasa, montoOriginal, montoActual, fechaCorte);
        }

        public DbSet<Prestamo> MostrarPrestamos()
        {
            return Operaciones.GetPrestamos();
        }

        public Prestamo BuscarPrestamo(int id)
        {
            return Operaciones.GetPrestamobyID(id);
        }

    }
}
