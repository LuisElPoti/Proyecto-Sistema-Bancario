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

        public static void SetUser(int id, string username, string password)
        {
            Id = id;
            Name = username;
            Password = password;
        }

        public static void ClearUser()
        {
            Id = 0;
            Name = null;
            Password = null;
        }
    }
}
