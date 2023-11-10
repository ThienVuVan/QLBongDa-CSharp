using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanBongAccess
    {
        public static void SaveSanBong(SanBong sanBong)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void UpdateSanBong(SanBong sanBong)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }

        public static void DeleteSanBong(string MaSan)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }
    }
}
