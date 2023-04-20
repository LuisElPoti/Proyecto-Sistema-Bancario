using CoreServices.Clases;
using CoreServices.Operaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoreServices.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Cuenta" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Cuenta.svc or Cuenta.svc.cs at the Solution Explorer and start debugging.
    public class WSCuenta : IWSCuenta
    {
        OperacionesCuenta Operaciones = new OperacionesCuenta();

        public bool CrearCuenta(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado)
        {
            return Operaciones.InsertCuentas(idCliente, idTipoCuenta, idBanco, NumeroCuenta, Estado);
        }

        public bool EliminarCuenta(int id)
        {
            return Operaciones.DeleteCuentas(id);
        }
        public bool ActualizarCuenta(int idCuenta, bool Estado, decimal Balance)
        {
            return Operaciones.UpdateCuentas(idCuenta, Estado, Balance);
        }

        public DataTable MostrarClientes()
        {
            return Operaciones.GetCuentas();
        }

        public DataTable BuscarCliente(int id)
        {
            return Operaciones.GetCuentabyID(id);
        }
    }
}
