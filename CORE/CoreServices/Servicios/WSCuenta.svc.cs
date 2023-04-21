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

namespace CoreServices.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Cuenta" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Cuenta.svc or Cuenta.svc.cs at the Solution Explorer and start debugging.
    public class WSCuenta : IWSCuenta
    {
        OperacionesCuenta Operaciones = new OperacionesCuenta();

        public bool CrearCuenta(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado)
        {
            return Operaciones.InsertCuentas(idCliente, idTipoCuenta, idBanco, NumeroCuenta, Estado);
        }

        public bool EliminarCuenta(int id)
        {
            return Operaciones.DeleteCuentas(id);
        }
        public bool ActualizarCuenta(int idCuenta, bool Estado, decimal Balance)
        {
            return Operaciones.UpdateCuentas(idCuenta, Estado, Balance);
        }

        public List<Cuenta> MostrarCuentas()
        {
            return Operaciones.GetCuentas();
        }

        public List<Cuenta> BuscarCuenta(int id)
        {
            return Operaciones.GetCuentabyID(id);
        }

        public List<Cuenta> MostrarCuentaCliente(int idCliente)
        {
            return Operaciones.GetCuentabyCliente(idCliente);
        }

        
        public bool Deposito_Retiro(int tipo, string NumeroCuenta, decimal Monto)
        {
            return Operaciones.Deposito_Retiro(tipo, NumeroCuenta, Monto);
        }

        public bool Pago_Prestamo(int idCliente, decimal Monto)
        {
            return Operaciones.Pago(idCliente, Monto);
        }

        public bool CrearTransferencia(int CuentaOrigen, int CuentaDestino, decimal Monto, int idEstado, int idMoneda, int idTipo)
        {
            return Operaciones.InsertTransferencia(CuentaOrigen, CuentaDestino, Monto, idEstado, idMoneda, idTipo);
        }

        public bool Transferencia_MismoBanco(int CuentaOrigen, int CuentaDestino, decimal Monto)
        {
            return Operaciones.Transferencia_Mismo(CuentaOrigen, CuentaDestino, Monto);
        }
    }
}
