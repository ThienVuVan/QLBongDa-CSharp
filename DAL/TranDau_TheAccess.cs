using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
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
        public static DataTable GetPenatylCard(string matranDau)
        {
            string sql = $"select * from TRANDAU_THE where MATRANDAU = {matranDau}";
            return DatabaseAccess.ReadTable(sql);
        }
    }
}
