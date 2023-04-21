using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NETBANKING
{
    public class User
    {
        public int id { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
       

        public void SetDatosUsuarios(string nombre, string clave)
        {
            NombreUsuario = nombre;
            Clave = clave;
        }
    }
}