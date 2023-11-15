using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TranDauAccess
    {
        public static void SaveTranDau(TranDau tranDau)
        {
            string sql = $"insert into dbo.TRANDAU values({tranDau.MaTranDau},{tranDau.MaDoiNha}," +
                $"{tranDau.MaDoiKhach}, {tranDau.LuotDau}, {tranDau.VongDau}, {tranDau.SoBanThangDoiNha}," +
                $"{tranDau.SoBanThangDoiKhach}, {tranDau.SoTheVangDoiNha}, {tranDau.SotheVangDoiKhach}," +
                $"{tranDau.SoTheDoDoiNha}, {tranDau.SoTheDoDoiKhach}, {tranDau.GhiChu})";
            DatabaseAccess.Excute(sql);
        }

        public static DataTable RetrieveAllTranDau()
        {
            string sql = "select * from dbo.TRANDAU";
            return DatabaseAccess.ReadTable(sql);
        }

        public static DataTable Filter(TranDau tranDau)
        {
            string sql = $"select * from dbo.TRANDAU b where " +
                $"b.MaTranDau is null or b.MaTranDau = {tranDau.MaTranDau} and " +
                $"b.MaDoiNha is null or b.MaDoiNha = {tranDau.MaDoiNha} and " +
                $"b.SoBanThangDoiNha is null or b.SoBanThangDoiNha = {tranDau.SoBanThangDoiNha} and " +
                $"b.SoTheDoDoiNha is null or b.SoTheDoDoiNha = {tranDau.SoTheDoDoiNha}";
            return DatabaseAccess.ReadTable(sql);
        }

        public static void UpdateTranDau(TranDau tranDau)
        {
        }

        public static void DeleteTranDau(string MaTranDau)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        
    }
}
