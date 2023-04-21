using CoreServices.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Services;

namespace CoreServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSUsuario
    {

        [OperationContract]
        bool CrearUsuario(int idPerfil, int idCliente, string nombre, string clave);

        [OperationContract]
        bool EliminarUsuario(int id);

        [OperationContract]
        bool ActualizarUsuario(int idUsuario, int idPerfil, int idCliente, string nombre, string clave);

        [OperationContract]
        bool ValidarSesion(string nombre, string clave);

        [OperationContract]
        DataTable MostrarUsuarios();

        [OperationContract]
        DataTable BuscarUsuario(int id);

    }

}
