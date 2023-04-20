using CoreServices.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CoreServices.WebServices
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSCuenta : System.Web.Services.WebService
    {
        /*
        OperacionesCuenta Operaciones = new OperacionesCuenta();

        [WebMethod]
        public bool CrearCuenta(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado)
        {

            return Operaciones.InsertCuentas(idCliente, idTipoCuenta, idBanco, NumeroCuenta , Estado);
        }

        [WebMethod]
        public bool EliminarCuenta(int id)
        {
            return Operaciones.DeleteCuentas(id);
        }

        [WebMethod]
        public bool ActualizarCuenta(int idCuenta, bool Estado, decimal Balance)
        {
            return Operaciones.UpdateCuentas(idCuenta, Estado, Balance);
        }
        
        [WebMethod]
        public spGetAllCuenta_Result[] MostrarCuentas()
        {
            return Operaciones.GetCuentas().ToArray();
        }

        [WebMethod]
        public Cuenta BuscarCuenta(int id)
        {
            return Operaciones.GetCuentabyID(id);
        }
        */
    }
}
