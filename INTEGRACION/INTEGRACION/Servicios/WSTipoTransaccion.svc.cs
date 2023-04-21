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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IWSTipoTransaccion" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IWSTipoTransaccion.svc or IWSTipoTransaccion.svc.cs at the Solution Explorer and start debugging.
    public class WSTipoTransaccion : IWSTipoTransaccion
    {
        OperacionesTipoTransaccion Operaciones = new OperacionesTipoTransaccion();

        public bool CrearTipoTransaccion(string nombre, string descripcion)
        {
            return Operaciones.InsertTipoTransaccion(nombre, descripcion);
        }

        public bool EliminarTipoTransaccion(int id)
        {
            return Operaciones.DeleteTipoTransaccion(id);
        }

        public bool ActualizarTipoTransaccion(int idTipo, string nombre, string descripcion)
        {
            return Operaciones.UpdateTipoTransaccion(idTipo, nombre, descripcion);
        }

        public DataTable MostrarTipoTransaccion()
        {
            return Operaciones.GetAllTipoTransaccion();
        }

        public DataTable BuscarTipoTransaccion()
        {
            throw new NotImplementedException();
        }

    }
}
