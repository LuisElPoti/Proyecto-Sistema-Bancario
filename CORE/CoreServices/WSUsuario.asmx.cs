using CoreServices.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CoreServices.WebServices
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSUsuario : System.Web.Services.WebService
    {
        OperacionesUsuario Operaciones = new OperacionesUsuario();

        [WebMethod]
        public bool CrearUsuario(int idPerfil, string nombre, string clave)
        {
            return Operaciones.InsertUsuario(idPerfil, nombre, clave);
        }

        [WebMethod]
        public bool EliminarUsuario(int id)
        {
            return Operaciones.DeleteUsuarios(id);
        }

        [WebMethod]
        public bool ActualizarUsuario(int idUsuario, int idPerfil, string nombre, string clave)
        {
            return Operaciones.UpdateUsuario(idUsuario, idPerfil, nombre, clave);
        }

        [WebMethod]
        public spGetAllUsuario_Result[] MostrarUsuarios()
        {
            return Operaciones.GetUsuario().ToArray();
        }

        [WebMethod]
        public Usuario BuscarUsuario(int id)
        {
            return Operaciones.GetUsuarioID(id);
        }
    }
}
