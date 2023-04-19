using CORE.DSGeneralTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;


namespace CORE.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSCliente : IWSCliente
    {
        ClientesTableAdapter Adapter = new ClientesTableAdapter();


        public void AgregarCliente(string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, DateTime FechaNacimiento)
        {
            Adapter.Insert(Nombre, TipoDocumento, Documento, Correo, Telefono, Direccion, FechaNacimiento);
        }

        public void EliminarCliente(int id)
        {
            Adapter.Delete(id);
        }

        public void ModificarCliente(int id, string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, DateTime FechaNacimiento)
        {
            Adapter.Update(id, Nombre, TipoDocumento, Documento, Correo, Telefono, Direccion, FechaNacimiento);
        }

        public void MostrarCliente()
        {
            Adapter.GetData();
        }

        public void BuscarCliente(int id)
        {
            Adapter.GetDataBy(id);
        }
    }
}
