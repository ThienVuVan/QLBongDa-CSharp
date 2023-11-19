using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class QuocTichService
	{
		public static List<string> RetrieveAllIdQuocTich()
		{
			return QuocTichAccess.RetrieveAllIdQuocTich();
		}
	}
}
