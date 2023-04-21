using INTEGRACION.Operaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace INTEGRACION.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSMovimiento : IWSMovimiento
    {
        OperacionesMovimiento Operaciones = new OperacionesMovimiento();

        public DataTable MostrarMovimientoCuenta()
        {
            return Operaciones.GetAllMovimientobyCuenta();
        }
    }
}
