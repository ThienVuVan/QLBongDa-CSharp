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
            if(tranDau.GhiChu == "Finished")
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
                else if(tranDau.SoBanThangDoiNha < tranDau.SoBanThangDoiKhach)
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
        

        
    }
}
