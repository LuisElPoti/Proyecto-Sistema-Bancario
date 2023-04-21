using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAJA
{
    internal class CurrentUser
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Password { get; set; }
        public static int Id_caja { get; set; }

        public static int Id_sucursal { get; set; }

        public static void SetUser(int id, string username, string password, int id_caja, int id_sucursal)
        {
            Id = id;
            Name = username;
            Password = password;
            Id_caja = id_caja;
            Id_sucursal= id_sucursal;
        }

        public static void ClearUser()
        {
            Id = 0;
            Name = null;
            Password = null;
            Id_caja = 0;
            Id_sucursal = 0;
        }
    }
}
