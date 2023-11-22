using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
            string sql = $"update CAUTHU set ";
            DatabaseAccess.Excute(sql);
        }

        public static void DeleteCauThu(string MaCauThu)
        {
            string sql = $"delete from dbo.CAUTHU where MaCauThu = '{MaCauThu}'";
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
            list = (List<string>)DatabaseAccess.ExecuteScalar(sql);
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
