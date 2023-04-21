using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace INTEGRACION.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITipoTransaccion" in both code and config file together.
    [ServiceContract]
    public interface IWSTipoTransaccion
    {
        [OperationContract]
        bool CrearTipoTransaccion(string nombre, string descripcion);

        [OperationContract]
        bool ActualizarTipoTransaccion(int idTipo, string nombre, string descripcion);

        [OperationContract]
        bool EliminarTipoTransaccion(int id);

        [OperationContract]
        DataTable MostrarTipoTransaccion();

        [OperationContract]
        DataTable BuscarTipoTransaccion();
    }
}
