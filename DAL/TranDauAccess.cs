using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TranDauAccess
    {
        public static void SaveTranDau(TranDau tranDau)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void UpdateTranDau(TranDau tranDau)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void DeleteTranDau(string MaTranDau)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }
    }
}
