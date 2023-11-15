using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class TranDauService
    {
        public static void SaveTranDau(TranDau tranDau)
        {
            TranDauAccess.SaveTranDau(tranDau);
        }
        public static DataTable RetrieveAllTranDau()
        {
            return TranDauAccess.RetrieveAllTranDau();
        }
        public static DataTable Filter(TranDau tranDau)
        {
            return TranDauAccess.Filter(tranDau);
        }
    }
}
