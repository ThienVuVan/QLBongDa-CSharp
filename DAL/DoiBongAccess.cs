using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DoiBongAccess
    {
        public static void SaveDoiBong(DoiBong doiBong)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void UpdateDoiBong(DoiBong doiBong)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void DeleteDoiBong(string MaDoi)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }
    }
}
