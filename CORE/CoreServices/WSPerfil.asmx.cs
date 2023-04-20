using CoreServices.Clases;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CoreServices
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSPerfil : System.Web.Services.WebService
    {
        OperacionesPerfil Operaciones = new OperacionesPerfil();

        [WebMethod]
        public bool CrearPerfil(string nombre, string descripcion)
        {
            return Operaciones.InsertPerfil(nombre, descripcion);
        }

        [WebMethod]
        public bool EliminarPerfil(int id)
        {
            return Operaciones.DeletePerfil(id);
        }

        [WebMethod]
        public bool ActualizarPerfil(int idPerfil, string nombre, string descripcion)
        {
            return Operaciones.UpdatePerfiles(idPerfil, nombre, descripcion);
        }

        [WebMethod]
        public DbSet<Perfil> MostrarPerfiles()
        {
            return Operaciones.GetPerfil();
        }
        /*
        [WebMethod]
        public Perfil BuscarPerfil(int id)
        {
            return Operaciones.GetPerfilbyID(id);
        }*/
    }
}
