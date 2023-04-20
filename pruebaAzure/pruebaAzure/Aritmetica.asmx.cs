using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;

namespace pruebaAzure
{
    /// <summary>
    /// Summary description for Aritmetica
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    
    public class Aritmetica : System.Web.Services.WebService
    {
        
        public Aritmetica()
        {
            //Uncomment the following line if using designed components  
            //InitializeComponent();  
        }
        [WebMethod]
        public void PostMoneda(string Nombre, String Descripcion)
        {
            //clsMoneda moneda = new clsMoneda();

            DBCoreEntities entity = new DBCoreEntities();
            entity.Moneda.Add(new Moneda()
            {
                Nombre = Nombre,
                Descripcion = Descripcion
            });

            entity.SaveChanges();
        }
        [WebMethod]
        public int Sub(int x, int y)
        {
            return x - y;
        }
        [WebMethod]
        public int Mul(int x, int y)
        {
            return x * y;
        }
        [WebMethod]
        public int Div(int x, int y)
        {
            return x / y;
        }
    }
}
