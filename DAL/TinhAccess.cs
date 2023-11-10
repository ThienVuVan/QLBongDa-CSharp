using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TinhAccess
    {
        public static void SaveTinh(Tinh tinh)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void UpdateTinh(Tinh tinh)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void DeleteTinh(string MaTinh)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }
    }
}
