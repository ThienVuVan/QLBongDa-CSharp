using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
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


        public static DataTable Filter(string Ten, string TenDoi, Nullable<int> SoBanThang)
        {
            string sql = $"select * from CAUTHU where TEN is not null ";
            string MaDoi;
            if(TenDoi == "")
            {
                MaDoi = "";
            }
            else
            {
                MaDoi = (string)DatabaseAccess.ExecuteScalar($"select MADOI from DOIBONG where TENDOI = N'{TenDoi}'");
            }
            if(Ten != "")
            {
                sql += $"and TEN = N'{Ten}'";
            }
            if(MaDoi != "")
            {
                sql += $" and MADOI = '{MaDoi}'";
            }
            if(SoBanThang != null)
            {
                sql += $" and SOBANTHANG = {SoBanThang}";
            }
            return DatabaseAccess.ReadTable(sql);
        }
        public static void SaveCauThu(CauThu cauThu)
        {
            string sql = $"insert into dbo.CAUTHU values('{cauThu.MaCauThu}', '{cauThu.MaDoi}'," +
               $"'{cauThu.MaQuocTinh}', N'{cauThu.Ten}', N'{cauThu.ViTriChoi}', '{cauThu.NgaySinh}'," +
               $"{cauThu.SoAo}, {cauThu.SoBanThang}, {cauThu.SoTheVang}," +
               $"{cauThu.SoTheDo}, {cauThu.SoLanRaSan}, '{cauThu.Anh}')";
            DatabaseAccess.Excute(sql);
        }

        public static DataTable FindThreeMaxGoal()
        {
            string sql = $"select top 3 with ties * from dbo.CAUTHU order by SoBanThang desc";
            return DatabaseAccess.ReadTable(sql);
        }

        public static void UpdateCauThu(CauThu cauThu)
        {
            string sql = $"update CAUTHU set MADOI = '{cauThu.MaDoi}',MAQUOCTICH = '{cauThu.MaQuocTinh}',TEN = N'{cauThu.Ten}',VITRICHOI = N'{cauThu.ViTriChoi}',NGAYSINH = '{cauThu.NgaySinh}',SOAO = {cauThu.SoAo},ANH = '{cauThu.Anh}' where MACAUTHU = '{cauThu.MaCauThu}'";
            DatabaseAccess.Excute(sql);
        }
        public static CauThu GetCauThu(string maCauThu)
        {
            string sql = $"select * from CAUTHU where MACAUTHU = '{maCauThu}'";
            DataTable dt = DatabaseAccess.ReadTable(sql);
            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
               CauThu cauThu = ConvertDataRowToCauThu(row);
                return cauThu;
            }
            return null;
        }
        private static CauThu ConvertDataRowToCauThu(DataRow row)
        {
            CauThu cauThu = new CauThu(
                row["MACAUTHU"].ToString(),
                row["MADOI"].ToString(),
                row["MAQUOCTICH"].ToString(),
                row["TEN"].ToString(),
                row["VITRICHOI"].ToString(),
                (DateTime)(row["NGAYSINH"] != DBNull.Value ? Convert.ToDateTime(row["NGAYSINH"]) : (DateTime?)null),
                int.Parse(row["SOAO"].ToString()),
                int.Parse(row["SOBANTHANG"].ToString()),
                int.Parse(row["SOTHEVANG"].ToString()),
                int.Parse(row["SOTHEDO"].ToString()),
                int.Parse(row["SOLANRASAN"].ToString()),
                row["ANH"].ToString()
            );
            return cauThu;
        }

        public static void DeleteCauThu(string MaCauThu)
        {
            string sql = $"delete from dbo.CAUTHU where MaCauThu = '{MaCauThu}'";
            string sql1 = $"delete from dbo.TRANDAU_BANTHANG where MaCauThu = '{MaCauThu}'";
            string sql2 = $"delete from dbo.TRANDAU_THE where MaCauThu = '{MaCauThu}'";
            string sql3 = $"delete from dbo.TRANDAU_CAUTHU where MaCauThu = '{MaCauThu}'";
            DatabaseAccess.Excute(sql1);
            DatabaseAccess.Excute(sql2);
            DatabaseAccess.Excute(sql3);
            DatabaseAccess.Excute(sql);
        }
        public static DataTable GetMemBerOfTeam(string maDoi)
        {
            string sql = $"select * from CAUTHU where MADOI = '{maDoi}'";
            return DatabaseAccess.ReadTable(sql);
        }
        public static List<string> GetAllName()
        {
            List<string> list = new List<string>();
            string sql = "select TEN from dbo.CAUTHU";
            DataTable dt = DatabaseAccess.ReadTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                string tenValue = row["TEN"].ToString();
                list.Add(tenValue);
            }
            return list;
        }

        public static List<string> GetAllIdByMaDoi(string MaDoi)
        {
            List<string> list = new List<string>();
            string sql = $"select MaCauThu from dbo.CAUTHU where MaDoi = '{MaDoi}'";
            DataTable dt = DatabaseAccess.ReadTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                string tenValue = row["MACAUTHU"].ToString();
                list.Add(tenValue);
            }
            return list;
        }
        public static DataTable GetMemBerOfListTeam(List<string> maDoi)
		{
			if (maDoi == null || maDoi.Count == 0)
			{
				// Trả về DataTable trống nếu danh sách mã đội rỗng hoặc null
				return new DataTable();
			}

			// Sử dụng phương thức string.Join để kết hợp danh sách mã đội thành một chuỗi được ngăn cách bởi dấu phẩy trong câu lệnh SQL
			string maDoiString = string.Join("','", maDoi);

			string sql = $"SELECT * FROM CAUTHU WHERE MADOI IN ('{maDoiString}')";

			return DatabaseAccess.ReadTable(sql);
		}
	}
}
