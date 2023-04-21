using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoreServices.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
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
        List<Prestamo> MostrarPrestamos(int id);
    }

    [DataContract]
    public class ClPrestamo
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int idCuenta { get; set; }
        [DataMember]
        public decimal tasa { get; set; }
        [DataMember]
        public decimal montoActual { get; set; }
        [DataMember]
        public decimal montoOriginal { get; set; }
    }
}
