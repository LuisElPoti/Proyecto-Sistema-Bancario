using CoreServices.Operaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoreServices.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Movimiento" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Movimiento.svc or Movimiento.svc.cs at the Solution Explorer and start debugging.
    public class WSMovimiento : IWSMovimiento
    {
        OperacionesMovimiento Operaciones = new OperacionesMovimiento();

        public List<Movimiento> MostrarMovimientoCuenta()
        {
            return Operaciones.GetAllMovimientobyCuenta();
        }
    }
}
