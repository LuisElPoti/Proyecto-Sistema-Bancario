using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace INTEGRACION.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSCliente
    {
        [OperationContract]
        bool CrearCliente(string nombre, int tipoDocumento, string documento, string correo, string telefono, string direccion, DateTime fechaNacimiento);

        [OperationContract]
        bool ActualizarCliente(int id, string nombre, int tipoDocumento, string documento, string correo, string telefono, string direccion, DateTime fechaNacimiento);

        [OperationContract]
        DataTable MostrarClientes();

        [OperationContract]
        DataTable BuscarCliente(int id);
    }
}
