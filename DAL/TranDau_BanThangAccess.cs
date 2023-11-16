using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static DataTable PlayerHaveScore(TranDau tranDau)
        {
            string sql = $"select b.MATRANDAU,b.MACAUTHU,b.THOIGIAN,a.MADOI,a.VITRI from TRANDAU_BANTHANG b join TRANDAU_CAUTHU a on a.MATRANDAU = b.MATRANDAU where MATRANDAU = {tranDau.MaTranDau} ";
            
            return DatabaseAccess.ReadTable(sql);
        }
    }
}
