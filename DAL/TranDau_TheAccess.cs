using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TranDau_TheAccess
    {
        public static void SaveTranDau_The(TranDau_The tranDau_The)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void UpdateTranDau_The(TranDau_The tranDau_The)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void DeleteTranDau_The(string MaTranDau, string MaCauThu, string MaViPham)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }
    }
}
