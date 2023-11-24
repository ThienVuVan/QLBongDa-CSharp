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
                $"'{tranDau.MaDoiKhach}', N'{tranDau.LuotDau}', N'{tranDau.VongDau}', {tranDau.SoBanThangDoiNha}," +
                $"{tranDau.SoBanThangDoiKhach}, {tranDau.SoTheVangDoiNha},{tranDau.SoTheDoDoiNha}, {tranDau.SotheVangDoiKhach}," +
                $"{tranDau.SoTheDoDoiKhach}, N'{tranDau.GhiChu}')";

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


        public static void UpdateTranDau(TranDau tranDau, string MaCtNha, string MaCtKhach, bool ThangNha,
           bool VangNha, bool DoNha, bool ThangKhach, bool VangKhach, bool DoKhach)
        {
            if (ThangNha)
            {
                string sql = $"insert into dbo.TRANDAU_BANTHANG (MACAUTHU, MATRANDAU) values('{MaCtNha}','{tranDau.MaTranDau}')";
                DatabaseAccess.Excute(sql);
            }
            if (VangNha)
            {
                string sql = $"insert into dbo.TRANDAU_THE (MACAUTHU, MATRANDAU, LOAITHE) values('{MaCtNha}','{tranDau.MaTranDau}', 'Vang')";
                DatabaseAccess.Excute(sql);
            }
            if (DoNha)
            {
                string sql = $"insert into dbo.TRANDAU_BANTHANG (MACAUTHU, MATRANDAU, LOAITHE) values('{MaCtNha}','{tranDau.MaTranDau}', 'Do')";
                DatabaseAccess.Excute(sql);
            }
            if (ThangKhach)
            {
                string sql = $"insert into dbo.TRANDAU_BANTHANG (MACAUTHU, MATRANDAU) values('{MaCtKhach}','{tranDau.MaTranDau}')";
                DatabaseAccess.Excute(sql);
            }
            if (VangKhach)
            {
                string sql = $"insert into dbo.TRANDAU_BANTHANG (MACAUTHU, MATRANDAU, LOAITHE) values('{MaCtKhach}','{tranDau.MaTranDau}', 'Vang')";
                DatabaseAccess.Excute(sql);
            }
            if (DoKhach)
            {
                string sql = $"insert into dbo.TRANDAU_BANTHANG (MACAUTHU, MATRANDAU, LOAITHE) values('{MaCtKhach}','{tranDau.MaTranDau}', 'Do')";
                DatabaseAccess.Excute(sql);
            }
            if (tranDau.GhiChu == "Finished")
            {
                TranDau tranDau1 = TranDauAccess.GetTranDauById(tranDau.MaTranDau);
                int DiemDoiNha = (int)DatabaseAccess.ExecuteScalar($"select SoDiem from dbo.DOIBONG where MaDoi = '{tranDau.MaDoiNha}'");
                int DiemDoiKhach = (int)DatabaseAccess.ExecuteScalar($"select SODIEM from dbo.DOIBONG where MaDoi = '{tranDau.MaDoiKhach}'");

                if (tranDau1.SoBanThangDoiNha > tranDau1.SoBanThangDoiKhach)
                {
                    DiemDoiNha += 3;
                    string updateNha = $"update dbo.DOIBONG set SoDiem = {DiemDoiNha} where MaDoi = '{tranDau1.MaDoiNha}'";
                    DatabaseAccess.Excute(updateNha);

                }
                else if (tranDau1.SoBanThangDoiNha < tranDau1.SoBanThangDoiKhach)
                {
                    DiemDoiKhach += 3;
                    string updateKhach = $"update dbo.DOIBONG set SoDiem = {DiemDoiKhach} where MaDoi = '{tranDau1.MaDoiKhach}'";
                    DatabaseAccess.Excute(updateKhach);
                }
                else
                {
                    DiemDoiNha += 1;
                    DiemDoiKhach += 1;
                    string updateNha = $"update dbo.DOIBONG set SoDiem = {DiemDoiNha} where MaDoi = '{tranDau1.MaDoiNha}'";
                    string updateKhach = $"update dbo.DOIBONG set SoDiem = {DiemDoiKhach} where MaDoi = '{tranDau1.MaDoiKhach}'";
                    DatabaseAccess.Excute(updateNha);
                    DatabaseAccess.Excute(updateKhach);
                }
                string sql = $"update dbo.TranDau set GhiChu = N'{tranDau.GhiChu}'";
                DatabaseAccess.Excute(sql);
            }
            else
            {
                string sql = $"update dbo.TranDau set GhiChu = N'{tranDau.GhiChu}'";
                DatabaseAccess.Excute(sql);
            }
        }

        public static void DeleteTranDau(string MaTranDau)
        {
            string sql = $"delete from dbo.TRANDAU where MaTranDau = '{MaTranDau}'";
            // this section will call trigger to delete data in three other table as well;
            // choose not effect trigger;
            string sql1 = $"delete from dbo.TRANDAU_BANTHANG where MaTranDau = '{MaTranDau}'";
            string sql2 = $"delete from dbo.TRANDAU_THE where MaTranDau = '{MaTranDau}'";
            string sql3 = $"delete from dbo.TRANDAU_CAUTHU where MaTranDau = '{MaTranDau}'";
            DatabaseAccess.Excute(sql1);
            DatabaseAccess.Excute(sql2);
            DatabaseAccess.Excute(sql3);
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
