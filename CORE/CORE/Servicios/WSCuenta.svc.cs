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
    public class WSCuenta : IWSCuenta
    {
        CuentaTableAdapter Adapter = new CuentaTableAdapter();

        public void AgregarCuenta(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado)
        {
            Adapter.Insert(idCliente, idTipoCuenta, idBanco, NumeroCuenta, Estado);
        }

        public void EliminarCuenta(int id)
        {
            Adapter.Delete(id);
        }

        public void ActualizarCuenta(int id, bool Estado, decimal Balance)
        {
            Adapter.Update(id, Estado, Balance);
        }
        
        public DataTable MostrarCuenta()
        {
            return Adapter.GetData();
        }

        public DataTable BuscarCuenta(int id)
        {
            return Adapter.GetDataBy(id);
        }
    }
}
