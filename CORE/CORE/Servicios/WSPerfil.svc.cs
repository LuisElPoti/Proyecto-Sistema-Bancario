using CORE.DSGeneralTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;

namespace CORE.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSPerfil : IWSPerfil
    {

        PerfilTableAdapter Adapter = new PerfilTableAdapter();

        public void AgregarPerfil(string Nombre, string Descripcion)
        {
            Adapter.Insert(Nombre,Descripcion);
        }
        public void EliminarPerfil(int id)
        {
            Adapter.Delete(id);
        }
        public void ActualizarPerfil(int id, string Nombre, string Descripcion)
        {
            Adapter.Update(id, Nombre, Descripcion);
        }
        public DataTable MostrarPerfil()
        {
            return Adapter.GetData();
        }
    }
}
