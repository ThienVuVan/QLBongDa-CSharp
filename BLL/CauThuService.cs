using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CauThuService
    {
        public static void SaveCauThu(CauThu cauThu)
        {
            CauThuAccess.SaveCauThu(cauThu);
        }

        public static DataTable RetrieveAllCauThu()
        {
            return CauThuAccess.RetrieveAllCauThu();
        }

        public static DataTable Filter(CauThu cauThu)
        {
            return CauThuAccess.Filter(cauThu);
        }

        public static DataTable FindThreeMaxGoal()
        {
            return CauThuAccess.FindThreeMaxGoal();
        }
    }
}
