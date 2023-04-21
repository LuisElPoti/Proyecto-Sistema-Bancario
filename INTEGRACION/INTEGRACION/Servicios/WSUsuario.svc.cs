using INTEGRACION.Operaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace INTEGRACION.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IWSUsuario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IWSUsuario.svc or IWSUsuario.svc.cs at the Solution Explorer and start debugging.
    public class WSUsuario : IWSUsuario
    {
        OperacionesUsuario Operaciones = new OperacionesUsuario();

        public bool CrearUsuario(int idPerfil, int idCliente, string nombre, string clave)
        {
            return Operaciones.InsertUsuario(idPerfil, idCliente, nombre, clave);
        }

        public bool EliminarUsuario(int id)
        {
            return Operaciones.DeleteUsuarios(id);
        }

        public bool ActualizarUsuario(int idUsuario, int idPerfil, int idCliente, string nombre, string clave)
        {
            return Operaciones.UpdateUsuario(idUsuario, idPerfil, idCliente, nombre, clave);
        }

        public bool ValidarSesion(string nombre, string clave)
        {
            return Operaciones.ValidarUsuario(nombre, clave);
        }
        public DataTable MostrarUsuarios()
        {
            return Operaciones.GetUsuario();
        }

        public DataTable BuscarUsuario(int id)
        {
            return Operaciones.GetUsuarioID(id);
        }
    }
}
