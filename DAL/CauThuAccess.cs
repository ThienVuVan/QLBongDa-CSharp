using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CauThuAccess
    {
        public static void SaveCauThu(CauThu cauThu)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void UpdateCauThu(CauThu cauThu)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void DeleteCauThu(string MaCauThu)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }
    }
}
