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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSUsuario : IWSUsuario
    {
        OperacionesUsuario Operaciones = new OperacionesUsuario();

        public bool CrearUsuario(int idPerfil, int idCliente, string nombre, string clave)
        {
            return Operaciones.InsertUsuario(idPerfil, idCliente,  nombre, clave);
        }

        public bool EliminarUsuario(int id)
        {
            return Operaciones.DeleteUsuarios(id);
        }

        public bool ActualizarUsuario(int idUsuario, int idPerfil, int idCliente, string nombre, string clave)
        {
            return Operaciones.UpdateUsuario(idUsuario, idPerfil, idCliente, nombre, clave);
        }

        public bool ValidarSeguridad(string clave)
        {
            return Operaciones.ContraseñaSegura(clave);
        }
        public bool ValidarSesion(string nombre, string clave)
        {
            return Operaciones.ValidarUsuario(nombre, clave);
        }
        public List<Usuario> MostrarUsuarios()
        {
            return Operaciones.GetUsuario();
        }

        public List<Usuario> BuscarUsuario(int id)
        {
            return Operaciones.GetUsuarioID(id);
        }
    }
}
