using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class TranDauService
    {
        public static void SaveTranDau(TranDau tranDau)
        {
            TranDauAccess.SaveTranDau(tranDau);
        }
        public static DataTable RetrieveAllTranDau()
        {
            return TranDauAccess.RetrieveAllTranDau();
        }
        public static DataTable Filter(string MaTranDau, string TenDoiNha, Nullable<int> SoBanThangDoiNha, Nullable<int> SoTheDoDoiNha)
        {
            return TranDauAccess.Filter(MaTranDau, TenDoiNha, SoBanThangDoiNha, SoTheDoDoiNha);
        }

        public static void UpdateTranDau(TranDau tranDau, string MaCtNha, string MaCtKhach, bool ThangNha,
           bool VangNha, bool DoNha, bool ThangKhach, bool VangKhach, bool DoKhach)
        {
            TranDauAccess.UpdateTranDau(tranDau, MaCtNha, MaCtKhach, ThangNha, VangNha, DoNha, ThangKhach, VangKhach, DoKhach);
        }

        public static TranDau GetTranDauById(string MaTranDau)
        {
            return TranDauAccess.GetTranDauById(MaTranDau);
        }

        public static void DeleteTranDau(string MaTranDau)
        {
            TranDauAccess.DeleteTranDau(MaTranDau);
        }
    }
}
