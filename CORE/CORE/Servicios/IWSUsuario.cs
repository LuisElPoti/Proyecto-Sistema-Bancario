using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CORE.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSUsuario
    {
        [OperationContract]
        void AgregarUsuario(int idPerfil, string Nombre, string Clave);

        [OperationContract]
        void EliminarUsuario(int id);

        [OperationContract]
        void ActualizarUsuario(int id, int idPerfil, string Nombre, string Clave);

        [OperationContract]
        void MostrarUsuarios();
    }

    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int idPerfil { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Clave { get; set; }
    }
}
