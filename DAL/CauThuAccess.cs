using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CauThuAccess
    {
        public static DataTable RetrieveAllCauThu()
        {
            string sql = "select * from dbo.CAUTHU";
            return DatabaseAccess.ReadTable(sql);
        }

        public static DataTable Filter(CauThu cauThu)
        {
            string sql = $"select * from dbo.CAUTHU c where " +
                $"c.Ten is null or c.Ten = N'{cauThu.Ten}'";
            return DatabaseAccess.ReadTable(sql);
        }
        public static void SaveCauThu(CauThu cauThu)
        {
            string sql = $"insert into dbo.CAUTHU values({cauThu.MaCauThu}, {cauThu.MaDoi}," +
               $"{cauThu.MaQuocTinh}, {cauThu.Ten}, {cauThu.ViTriChoi}, {cauThu.NgaySinh}," +
               $"{cauThu.SoAo}, {cauThu.SoBanThang}, {cauThu.SoTheVang}," +
               $"{cauThu.SoTheDo}, {cauThu.SoLanRaSan}, {cauThu.Anh})";
            DatabaseAccess.Excute(sql);
        }

        public static DataTable FindThreeMaxGoal()
        {
            string sql = $"select top 3 from dbo.CAUTHU order by SoBanThang desc";
            return DatabaseAccess.ReadTable(sql);
        }

        public static void UpdateCauThu(CauThu cauThu)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void DeleteCauThu(string MaCauThu)
        {
            string sql = $"delete from dbo.CAUTHU where MaCauThu = {MaCauThu}";
            DatabaseAccess.Excute(sql);
        }
    }
}
