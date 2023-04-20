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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICuenta" in both code and config file together.
    [ServiceContract]
    public interface IWSCuenta
    {
        [OperationContract]
        bool CrearCuenta(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado);

        [OperationContract]
        bool EliminarCuenta(int id);

        [OperationContract]
        bool ActualizarCuenta(int idCuenta, bool Estado, decimal Balance);

        [OperationContract]
        DataTable MostrarCuentas();

        [OperationContract]
        DataTable BuscarCuenta(int id);

    }
}
