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

    [DataContract]
    public class ClCliente
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public int tipoDocumento { get; set; }
        [DataMember]
        public string documento { get; set; }
        [DataMember]
        public string correo{ get; set; }
        [DataMember]
        public string telefono { get; set; }
        [DataMember]
        public string direccion { get; set; }
        [DataMember]
        public DateTime FechaNacimiento { get; set; }

    }
}
