using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CORE.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSCuenta
    {
        [OperationContract]
        void AgregarCuenta(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado);

        [OperationContract]
        void EliminarCuenta(int id);

        [OperationContract]
        void ActualizarCuenta(int id, bool Estado, decimal Balance);

        [OperationContract]
        DataTable MostrarCuenta();
    }

    [DataContract]
    public class Cuenta
    {
        [DataMember]
        public int idCliente { get; set; }

        [DataMember]
        public int idTipoCuenta { get; set; }

        [DataMember]
        public int idBanco { get; set; }

        [DataMember]
        public string NumeroCuenta { get; set; }

        [DataMember]
        public bool Estado { get; set; }

        [DataMember]
        public decimal Balance { get; set; }

    }
}
