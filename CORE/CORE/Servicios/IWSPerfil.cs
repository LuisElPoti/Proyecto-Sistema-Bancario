using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CORE.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSPerfil
    {
        [OperationContract]
        void CrearPerfil(string Nombre, string Descripcion);

        [OperationContract]
        void EliminarPerfil(int id);

        [OperationContract]
        void ModificarPerfil (int id, string Nombre, string Descripcion);

        [OperationContract]
        DataTable MostrarPerfiles();

        [OperationContract]
        DataTable BuscarPerfil(int id);
    }
}
