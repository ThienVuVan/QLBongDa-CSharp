using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        UserAccess userAccess = new UserAccess();
        public string CheckLogin(User user) { 
        
            // kiem tra nghiep vu
            if(user.username == "")
            {
                return "yeu cau username";
            }
            if (user.password == "")
            {
                return "yeu cau password";
            }
            string info = userAccess.CheckLogin(user);
            return info;
        }
    }
}
