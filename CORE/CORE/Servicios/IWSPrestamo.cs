using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CORE.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSPrestamo
    {
        [OperationContract]
        void CrearPrestamo(int idCuenta, Decimal Tasa, Decimal MontoOriginal, Decimal MontoActual, DateTime FechaCorte);

        [OperationContract]
        void EliminarPrestamo(int id);

        [OperationContract]
        void ModificarPrestamo(int id, int idCuenta, decimal Tasa, Decimal MontoOriginal, decimal MontoActual, DateTime FechaCorte);

        [OperationContract]
        DataTable MostrarPrestamos();

        [OperationContract]
        DataTable BuscarPrestamo(int idCuenta);
    }

    [DataContract]
    public class Prestamo
    {
        [DataMember]
        public int idCuenta { get; set; }

        [DataMember]
        public decimal Tasa { get; set; }

        [DataMember]
        public decimal MontoOriginal { get; set; }

        [DataMember]
        public decimal MontoActual { get; set; }

        [DataMember]
        public DateTime FechaCorte { get; set; }
    }
}
