using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UserAccess
    {
        public string CheckLogin(User user)
        {
            string info = DatabaseAccess.CheckLogin(user);
            return info;
        }
    }
}
