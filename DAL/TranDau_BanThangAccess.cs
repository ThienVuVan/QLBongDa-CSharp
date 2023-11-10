using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TranDau_BanThangAccess
    {
        public static void SaveTranDau_BanThang(TranDau_BanThang tranDau_BanThang)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void UpdateTranDau_BanThang(TranDau_BanThang tranDau_BanThang)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void DeleteTranDau_BanThang(string MaBanThang, string MaTranDau)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }
    }
}
