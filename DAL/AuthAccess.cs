using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuthAccess
    {
        public static string username = "admin";
        public static string password = "admin12345";
        public static bool CheckAuth(User user)
        {
            if (user.username == username && user.password == password) return true;
            return false;
        }
    }
}
