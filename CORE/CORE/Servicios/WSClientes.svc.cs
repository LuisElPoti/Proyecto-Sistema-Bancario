using CORE.DSGeneralTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CORE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Servicios" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Servicios.svc or Servicios.svc.cs at the Solution Explorer and start debugging.
    public class WSClientes : IWSClientes
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

        public void ActualizarCliente(int id, string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, DateTime FechaNacimiento)
        {
            Adapter.Update(id, Nombre, TipoDocumento, Documento, Correo, Telefono, Direccion, FechaNacimiento);
        }

        public DataTable MostrarClientes()
        {
            return Adapter.GetData();
        }

    }
}
