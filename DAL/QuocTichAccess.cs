using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class QuocTichAccess
	{
		public static List<string> RetrieveAllIdQuocTich()
		{
			List<string> list = new List<string>();
			string sql = "select * from dbo.QUOCTICH";
			DataTable dt = DatabaseAccess.ReadTable(sql);
			foreach (DataRow row in dt.Rows)
			{
				string tenValue = row["MAQUOCTICH"].ToString();
				list.Add(tenValue);
			}
			return list;
		}
	}
}
