using CORE.DSGeneralTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CORE.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSUsuario : IWSUsuario
    {
        UsuarioTableAdapter Adapter = new UsuarioTableAdapter();

        public void AgregarUsuario(int idPerfil, string Nombre, string Clave)
        {
            Adapter.Insert(idPerfil, Nombre, Clave);
        }

        public void EliminarUsuario (int id)
        {
            Adapter.Delete(id);
        }

        public void ActualizarUsuario (int id, int idPerfil, string Nombre, string Clave)
        {
            Adapter.Update(id, idPerfil, Nombre, Clave);
        }

        public DataTable MostrarUsuarios()
        {
            return Adapter.GetData();
        }

        public DataTable BuscarUsuario(int id)
        {
            return Adapter.GetDataBy(id);
        }
    }
}
