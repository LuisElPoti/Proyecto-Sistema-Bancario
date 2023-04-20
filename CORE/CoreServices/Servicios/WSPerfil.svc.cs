using CoreServices.Clases;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Services;

namespace CoreServices.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Perfil" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Perfil.svc or Perfil.svc.cs at the Solution Explorer and start debugging.
    public class WSPerfil : IWSPerfil
    {
        OperacionesPerfil Operaciones = new OperacionesPerfil();

        public bool CrearPerfil(string nombre, string descripcion)
        {
            return Operaciones.InsertPerfil(nombre, descripcion);
        }

        public bool EliminarPerfil(int id)
        {
            return Operaciones.DeletePerfil(id);
        }

        public bool ActualizarPerfil(int idPerfil, string nombre, string descripcion)
        {
            return Operaciones.UpdatePerfiles(idPerfil, nombre, descripcion);
        }

        public DbSet<Perfil> MostrarPerfiles()
        {
            return Operaciones.GetPerfil();
        }
        
        public Perfil BuscarPerfil(int id)
        {
            return Operaciones.GetPerfilbyID(id);
        }
    }
}
