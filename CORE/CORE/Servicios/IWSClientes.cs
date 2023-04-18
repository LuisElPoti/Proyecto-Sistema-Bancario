using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CORE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicios" in both code and config file together.
    [ServiceContract]
    public interface IWSClientes
    {
        [OperationContract]
        void AgregarCliente(string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, DateTime FechaNacimiento);

        [OperationContract]
        void EliminarCliente(int id);

        [OperationContract]
        void ActualizarCliente(int id, string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, DateTime FechaNacimiento);

        [OperationContract]
        void MostrarClientes();
    }
    
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int TipoDocumento { get; set; }
        [DataMember]
        public string Documento { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public DateTime FechaNacimiento { get; set; }
    }
    
}
