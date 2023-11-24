using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DoiBongAccess
    {
        public static DoiBong GetDoiBongById(string MaDoi)
        {
            string sql = $"select * from dbo.DOIBONG where MADOI = '{MaDoi}'";
            DataTable result = DatabaseAccess.ReadTable(sql);
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                DoiBong doiBong = ConvertDataRowToDoiBong(row);
                return doiBong;
            }
            return null;
        }

        private static DoiBong ConvertDataRowToDoiBong(DataRow row)
        {
            DoiBong doiBong = new DoiBong(
                    row["MADOI"].ToString(),
                    row["MASAN"].ToString(),
                    row["MATINH"].ToString(),
                    row["TENDOI"].ToString(),
                    row["HLV"].ToString(),
                    row["LOGO"].ToString(),
                    int.Parse(row["SODIEM"].ToString()),
                    int.Parse(row["SOBANTHANG"].ToString()),
                    int.Parse(row["SOBANTHUA"].ToString()),
                    int.Parse(row["SOLUONGCAUTHU"].ToString())
                );
            return doiBong;
        }

        public static List<string> RetrieveAllNameDoiBong()
        {
            List<string> list = new List<string>();
            string sql = "select * from dbo.DOIBONG";
            DataTable dt = DatabaseAccess.ReadTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                string tenValue = row["TENDOI"].ToString();
                list.Add(tenValue);
            }
            return list;
        }

		public static List<string> RetrieveAllIdDoiBong()
		{
			List<string> list = new List<string>();
			string sql = "select * from dbo.DOIBONG";
			DataTable dt = DatabaseAccess.ReadTable(sql);
			foreach (DataRow row in dt.Rows)
			{
				string tenValue = row["MADOI"].ToString();
				list.Add(tenValue);
			}
			return list;
		}
		public static void SaveDoiBong(DoiBong doiBong)
        {
            string sql = $"insert into DOIBONG ([MADOI],[MASAN],[MATINH],[TENDOI],[HLV],[LOGO],[SODIEM],[SOBANTHANG],[SOBANTHUA],[SOLUONGCAUTHU]) " +
                $"values('{doiBong.MaDoi}','{doiBong.MaSan}','{doiBong.MaTinh}',N'{doiBong.TenDoi}',N'{doiBong.HLV}','{doiBong.LoGo}',0,0,0,0)";
            DatabaseAccess.Excute(sql);
        }

        public static void UpdateDoiBong(DoiBong doiBong)
        {
            string sql = $"Update DOIBONG set MASAN = '{doiBong.MaSan}',MATINH = '{doiBong.MaTinh}'," +
                $"TENDOI = N'{doiBong.TenDoi}',HLV = N'{doiBong.HLV}', LOGO = '{doiBong.LoGo}' where MADOI = '{doiBong.MaDoi}'";
            DatabaseAccess.Excute(sql);
        }
 
        public static void DeleteDoiBong(string MaDoi)
        {
            string sql1 = $"delete from dbo.CAUTHU where MaDoi = '{MaDoi}'";
            string sql2 = $"delete from dbo.DOIBONG where MaDoi = '{MaDoi}'";
            DatabaseAccess.Excute(sql1);
            DatabaseAccess.Excute(sql2);
        }
        public static DataTable GetAllTeam()
        {
            string sql = "select * from DOIBONG";
            return DatabaseAccess.ReadTable(sql);
        }
		public static DataTable Filter(string TenDoi, Nullable<int> Diem)
		{
			string MaDoi;
			if (TenDoi == null) MaDoi = "none";
			else
			{
				string sql1 = $"select MaDoi from dbo.DOIBONG where TenDoi = N'{TenDoi}'";
				MaDoi = (string)DatabaseAccess.ExecuteScalar(sql1);

			}
			if (Diem == null) Diem = -1;
			string sql = $"select * from dbo.DOIBONG b where " +
				$"('{MaDoi}' = 'none' or b.MADOI = '{MaDoi}') and " +
				$"({Diem} = -1 or b.SODIEM = {Diem})";
			return DatabaseAccess.ReadTable(sql);
		}
        public static DataTable SortDoiByScore()
        {
            string sql = $"select * from DOIBONG order by SODIEM desc";
            return DatabaseAccess.ReadTable(sql);
        }
        public static DoiBong DoiBongHayNhat()
        {
            string sql = "select top(1) * from DOIBONG order by SODIEM desc";
            DataTable res = DatabaseAccess.ReadTable(sql);
            if(res.Rows.Count > 0)
            {
                DataRow row = res.Rows[0];
                DoiBong doiBong = ConvertDataRowToDoiBong(row);
                return doiBong;
            }
            return null;
        }
	}
}
