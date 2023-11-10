using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TranDau_CauThuAccess
    {
        public static void SaveTranDau_CauThu(TranDau_CauThu tranDau_CauThu)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void UpdateTranDau_CauThu(TranDau_CauThu tranDau_CauThu)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void DeleteTranDau_CauThu(string MaTranDau, string MaCauThu)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }
    }
}
