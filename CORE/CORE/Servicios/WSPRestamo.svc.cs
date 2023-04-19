using CORE.DSGeneralTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CORE.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSPrestamo : IWSPrestamo
    {
        PrestamoTableAdapter Adapter = new PrestamoTableAdapter();

        public void CrearPrestamo(int idCuenta, Decimal Tasa, Decimal MontoOriginal, Decimal MontoActual, DateTime FechaCorte)
        {
            Adapter.Insert(idCuenta, Tasa, MontoOriginal, MontoActual, FechaCorte);
        }

        public void EliminarPrestamo (int id)
        {
            Adapter.Delete(id);
        }

        public void ModificarPrestamo (int id, int idCuenta, decimal Tasa, Decimal MontoOriginal, decimal MontoActual, DateTime FechaCorte)
        {
            Adapter.Update(id, idCuenta, Tasa, MontoOriginal, MontoActual, FechaCorte);
        }

        public DataTable MostrarPrestamos()
        {
            return Adapter.GetData();
        }

        public DataTable BuscarPrestamo(int idCuenta)
        {
            return Adapter.GetDataBy(idCuenta);
        }
    }
}
