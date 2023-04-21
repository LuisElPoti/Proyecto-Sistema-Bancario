using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace INTEGRACION.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIWSPrestamo" in both code and config file together.
    [ServiceContract]
    public interface IWSPrestamo
    {
        [OperationContract]
        bool CrearPrestamo(int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, DateTime fechaCorte);

        [OperationContract]
        bool EliminarPrestamo(int id);

        [OperationContract]
        bool ActualizarPrestamo(int idPrestamo, int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, DateTime fechaCorte);

        [OperationContract]
        DataTable MostrarPrestamos();

        [OperationContract]
        DataTable BuscarPrestamo(int id);

        [OperationContract]
        DataTable MostarPrestamoCliente();
    }
}
