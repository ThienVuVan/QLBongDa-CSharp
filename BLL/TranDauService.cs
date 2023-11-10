using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TranDauService
    {
        public static void LuuTranDau(TranDau tranDau)
        {
            TranDauAccess.LuuTranDau(tranDau);
        }
    }
}
