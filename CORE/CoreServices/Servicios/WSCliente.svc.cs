using CoreServices.Clases;
using CoreServices.Operaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CoreServices.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSCliente : IWSCliente
    {
        OperacionesCliente Operaciones = new OperacionesCliente();

        public bool CrearCliente(string nombre, int tipoDocumento, string documento, string correo, string telefono, string direccion, DateTime fechaNacimiento)
        {
            return Operaciones.InsertCliente(nombre, tipoDocumento, documento, correo, telefono, direccion, fechaNacimiento);
        }

        public bool ActualizarCliente(int id, string nombre, int tipoDocumento, string documento, string correo, string telefono, string direccion, DateTime fechaNacimiento)
        {
            return Operaciones.UpdateClientes(id, nombre, tipoDocumento, documento, correo, telefono, direccion, fechaNacimiento);
        }

        public bool EliminarCliente(int id)
        {
            return Operaciones.EliminarCliente(id);
        }
        public DataTable MostrarClientes()
        {
            return Operaciones.GetClientes();
        }

        public DataTable BuscarCliente(int id)
        {
            return Operaciones.GetClientebyID(id);


        }
    }
}
