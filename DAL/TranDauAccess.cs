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
            string sql = $"insert into dbo.TRANDAU values('{tranDau.MaTranDau}','{tranDau.MaDoiNha}'," +
                $"'{tranDau.MaDoiKhach}', {tranDau.LuotDau}, {tranDau.VongDau}, {tranDau.SoBanThangDoiNha}," +
                $"{tranDau.SoBanThangDoiKhach}, {tranDau.SoTheVangDoiNha}, {tranDau.SotheVangDoiKhach}," +
                $"{tranDau.SoTheDoDoiNha}, {tranDau.SoTheDoDoiKhach}, '{tranDau.GhiChu}')";

            DatabaseAccess.Excute(sql);
        }

        public static DataTable RetrieveAllTranDau()
        {
            string sql = "select * from dbo.TRANDAU";
            return DatabaseAccess.ReadTable(sql);
        }

        public static DataTable Filter(string MaTranDau, string TenDoiNha, Nullable<int> SoBanThangDoiNha, Nullable<int> SoTheDoDoiNha)
        {
            string MaDoiNha;
            if (TenDoiNha == null) MaDoiNha = "none";
            else
            {
                string sql1 = $"select MaDoi from dbo.DOIBONG where TenDoi = N'{TenDoiNha}'";
                MaDoiNha = (string)DatabaseAccess.ExecuteScalar(sql1);

            }


            if (MaTranDau == null) MaTranDau = "none";
            if (SoBanThangDoiNha == null) SoBanThangDoiNha = -1;
            if (SoTheDoDoiNha == null) SoTheDoDoiNha = -1;
            string sql = $"select * from dbo.TRANDAU b where " +
                $"('{MaTranDau}' = 'none' or b.MaTranDau = '{MaTranDau}') and " +
                $"('{MaDoiNha}' = 'none' or b.MaDoiNha = '{MaDoiNha}') and " +
                $"({SoBanThangDoiNha} = -1 or b.SoBanThangDoiNha = {SoBanThangDoiNha}) and " +
                $"({SoTheDoDoiNha} = -1 or b.SoTheDoDoiNha = {SoTheDoDoiNha})";
            return DatabaseAccess.ReadTable(sql);
        }

        public static void UpdateTranDau(TranDau tranDau)
        {
            if (tranDau.GhiChu == "Finished")
            {
                string sql = $"update dbo.TRANDAU c set " +
                $"set c.SoBanThangDoiNha = {tranDau.SoBanThangDoiNha}," +
                $"c.SoBanThangDoiKhach = {tranDau.SoBanThangDoiKhach}," +
                $"c.SoTheVangDoiNha = {tranDau.SoTheVangDoiNha}," +
                $"c.SotheVangDoiKhach = {tranDau.SotheVangDoiKhach}," +
                $"c.SoTheDoDoiNha = {tranDau.SoTheDoDoiNha}," +
                $"c.SoTheDoDoiKhach = {tranDau.SoTheDoDoiKhach}," +
                $"c.GhiChu = {tranDau.GhiChu})" +
                $"where c.MaTranDau = N'{tranDau.MaTranDau}'";
                DatabaseAccess.Excute(sql);

                int DiemDoiNha = (int)DatabaseAccess.ExecuteScalar($"select Diem from dbo.DOIBONG where MaDoi = N'{tranDau.MaDoiNha}'");
                int DiemDoiKhach = (int)DatabaseAccess.ExecuteScalar($"select Diem from dbo.DOIBONG where MaDoi = N'{tranDau.MaDoiKhach}'");
                string updateKhach = $"update dbo.DOIBONG set Diem = {DiemDoiKhach} where MaDoi = N'{tranDau.MaDoiKhach}'";
                string updateNha = $"update dbo.DOIBONG set Diem = {DiemDoiNha} where MaDoi = N'{tranDau.MaDoiNha}'";
                if (tranDau.SoBanThangDoiNha > tranDau.SoBanThangDoiKhach)
                {
                    DiemDoiNha += 3;
                    DatabaseAccess.Excute(updateNha);

                }
                else if (tranDau.SoBanThangDoiNha < tranDau.SoBanThangDoiKhach)
                {
                    DiemDoiKhach += 3;
                    DatabaseAccess.Excute(updateKhach);
                }
                else
                {
                    DiemDoiNha += 1;
                    DiemDoiKhach += 1;
                    DatabaseAccess.Excute(updateNha);
                    DatabaseAccess.Excute(updateKhach);
                }
            }
            else
            {
                string sql = $"update dbo.TRANDAU c set " +
                $"set c.SoBanThangDoiNha = {tranDau.SoBanThangDoiNha}," +
                $"c.SoBanThangDoiKhach = {tranDau.SoBanThangDoiKhach}," +
                $"c.SoTheVangDoiNha = {tranDau.SoTheVangDoiNha}," +
                $"c.SotheVangDoiKhach = {tranDau.SotheVangDoiKhach}," +
                $"c.SoTheDoDoiNha = {tranDau.SoTheDoDoiNha}," +
                $"c.SoTheDoDoiKhach = {tranDau.SoTheDoDoiKhach}," +
                $"c.GhiChu = {tranDau.GhiChu})" +
                $"where c.MaTranDau = N'{tranDau.MaTranDau}'";
                DatabaseAccess.Excute(sql);
            }
        }

        public static void DeleteTranDau(string MaTranDau)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static TranDau GetTranDauById(string MaTranDau)
        {
            string sql = $"select * from dbo.TRANDAU where MATRANDAU = '{MaTranDau}'";
            DataTable result = DatabaseAccess.ReadTable(sql);
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                TranDau tranDau = ConvertDataRowToTranDau(row);
                return tranDau;
            }
            return null;
        }

        private static TranDau ConvertDataRowToTranDau(DataRow row)
        {
            TranDau tranDau = new TranDau(
                    row["MATRANDAU"].ToString(),
                    row["MADOINHA"].ToString(),
                    row["MADOIKHACH"].ToString(),
                    row["LUOTDAU"].ToString(),
                    row["VONGDAU"].ToString(),
                    int.Parse(row["SOBANTHANGDOINHA"].ToString().Trim()),
                    int.Parse(row["SOBANTHANGDOIKHACH"].ToString().Trim()),
                    int.Parse(row["SOTHEVANGDOINHA"].ToString().Trim()),
                    int.Parse(row["SOTHEVANGDOIKHACH"].ToString().Trim()),
                    int.Parse(row["SOTHEDODOINHA"].ToString().Trim()),
                    int.Parse(row["SOTHEDODOIKHACH"].ToString().Trim()),
                    row["GHICHU"].ToString()
                );
            return tranDau;
        }
    }
}
