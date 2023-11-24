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
        public static void DeleteCauThu(string maCauThu)
        {
            CauThuAccess.DeleteCauThu(maCauThu);
        }

        public static DataTable Filter(string Ten, string MaDoi, Nullable<int> SoBanThang)
        {
            return CauThuAccess.Filter(Ten, MaDoi, SoBanThang);
        }

        public static DataTable FindThreeMaxGoal()
        {
            return CauThuAccess.FindThreeMaxGoal();
        }
        public static DataTable GetMemBerOfTeam(string maDoi)
        {
            return CauThuAccess.GetMemBerOfTeam(maDoi);
        }
        public static List<string> GetAllName()
        {
            return CauThuAccess.GetAllName();
        }
        public static DataTable GetMemBerOfListTeam(List<string> maDoi)
        {
            return CauThuAccess.GetMemBerOfListTeam(maDoi);
        }
        public static CauThu GetCauThu (string maCauThu)
        {
            return CauThuAccess.GetCauThu(maCauThu);    
        }
        public static void UpdateCauThu(CauThu cauThu)
        {
            CauThuAccess.UpdateCauThu(cauThu);
        }
        public static DataTable SortCauThuByGoal()
        {
            return CauThuAccess.SortCauThuByGoal();
        }
        public static CauThu CauThuHayNhat()
        {
            return CauThuAccess.CauThuHayNhat();
        }

        public static List<string> GetAllIdByMaDoi(string MaDoi)
        {
            return CauThuAccess.GetAllIdByMaDoi(MaDoi);
        }
    }

}
