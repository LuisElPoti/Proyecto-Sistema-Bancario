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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICuenta" in both code and config file together.
    [ServiceContract]
    public interface IWSCuenta
    {
        [OperationContract]
        bool CrearCuenta(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado);

        [OperationContract]
        bool EliminarCuenta(int id);

        [OperationContract]
        bool ActualizarCuenta(int idCuenta, bool Estado, decimal Balance);

        [OperationContract]
        List<Cuenta> MostrarCuentas();

        [OperationContract]
        List<Cuenta> BuscarCuenta(int id);

        [OperationContract]
        bool Deposito_Retiro(int tipo, string NumeroCuenta, decimal Monto);

        [OperationContract]
        bool Pago_Prestamo(int idPrestamo, decimal Monto);

        [OperationContract]
        bool CrearTransferencia(int idTipo, int idMoneda, int idEstado, int CuentaOrigen, int CuentaDestino, decimal Monto);
        [OperationContract]
        bool Transferencia_MismoBanco(int CuentaOrigen, int CuentaDestino, decimal Monto);
    }
    [DataContract]
    public class ClCuenta
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
    }
}
