using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Web;

namespace CoreServices.Clases
{
    public class OperacionesCuenta
    {        
        public spGetAllCuenta_Result[] GetCuentas()
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                return db.spGetAllCuenta().ToArray();
            }
        }


        /*
         * public List<CollegeDetail> GetCollegeRecords()  
        {  
            using (CollegeDataEntities context = new CollegeDataEntities())  
            {  
                return context.CollegeDetails.ToList();  
            }  
        }
        */

        public bool InsertCuentas(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertCuenta(idCliente, idTipoCuenta, idBanco, NumeroCuenta, Estado);

                if (Convert.ToInt32(ReturnedValue.Value) >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }            
        }

        public bool UpdateCuentas(int idCuenta, bool Estado, decimal Balance)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spUpsertCuenta(idCuenta, Estado, Balance);

                if (ReturnedValue >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DeleteCuentas(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spDeleteCuenta(id);

                if (ReturnedValue >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Cuenta GetCuentabyID(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                Cuenta Cuenta = null;

                try
                {
                    Cuenta Correspondiente = db.Cuenta.First((p) => p.id == id);

                    Cuenta = new Cuenta();
                    Cuenta.idCuenta = Correspondiente.idCuenta;
                    Cuenta.idTipoCuenta = Correspondiente.idTipoCuenta;
                    Cuenta.idCliente = Correspondiente.idCliente;
                    Cuenta.idBanco = Correspondiente.idBanco;
                    Cuenta.NumeroCuenta = Correspondiente.NumeroCuenta;
                    Cuenta.Balance = Correspondiente.Balance;
                    Cuenta.Estado = Correspondiente.Estado;
                    Cuenta.FechaIngreso = Correspondiente.FechaIngreso;

                    return Cuenta;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}