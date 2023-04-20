using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoreServices.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPerfil" in both code and config file together.
    [ServiceContract]
    public interface IWSPerfil
    {
        [OperationContract]
        bool CrearPerfil(string nombre, string descripcion);

        [OperationContract]
        bool EliminarPerfil(int id);

        [OperationContract]
        bool ActualizarPerfil(int idPerfil, string nombre, string descripcion);

        [OperationContract]
        DbSet<Perfil> MostrarPerfiles();
        
        [OperationContract]
        Perfil BuscarPerfil(int id);
        
    }
}
