using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static List<DataTable> RetriveAll(TranDau tranDau)
        {
            List<DataTable> list=  new List<DataTable>();   
            string sql = $"select * from TRANDAU_CAUTHU where MATRANDAU = {tranDau.MaTranDau} and MADOI = {tranDau.MaDoiNha}";
            DataTable doinha = DatabaseAccess.ReadTable(sql);
            list.Add(doinha);
            sql = $"select * from TRANDAU_CAUTHU where MATRANDAU = {tranDau.MaTranDau} and MADOI = {tranDau.MaDoiKhach}";
            DataTable khach = DatabaseAccess.ReadTable(sql);
            list.Add(khach);
            return list;
        }
    }
}
