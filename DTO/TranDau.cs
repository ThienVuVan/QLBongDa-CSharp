using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TranDau
    {
        public TranDau()
        {
        }

        public TranDau(string maTranDau, string maDoiNha, string maDoiKhach, string luotDau, string vongDau, int soBanThangDoiNha, int soBanThangDoiKhach, int soTheVangDoiNha, int sotheVangDoiKhach, int soTheDoDoiNha, int soTheDoDoiKhach, string ghiChu)
        {
            MaTranDau = maTranDau;
            MaDoiNha = maDoiNha;
            MaDoiKhach = maDoiKhach;
            LuotDau = luotDau;
            VongDau = vongDau;
            SoBanThangDoiNha = soBanThangDoiNha;
            SoBanThangDoiKhach = soBanThangDoiKhach;
            SoTheVangDoiNha = soTheVangDoiNha;
            SotheVangDoiKhach = sotheVangDoiKhach;
            SoTheDoDoiNha = soTheDoDoiNha;
            SoTheDoDoiKhach = soTheDoDoiKhach;
            GhiChu = ghiChu;
        }

        public string MaTranDau { get; set; }
        public string MaDoiNha { get; set; }
        public string MaDoiKhach { get; set; }
        public string LuotDau { get; set; }
        public string VongDau { get; set; }
        public int SoBanThangDoiNha { get; set; }
        public int SoBanThangDoiKhach { get; set; }
        public int SoTheVangDoiNha { get; set; }
        public int SotheVangDoiKhach { get; set; }
        public int SoTheDoDoiNha { get; set; }
        public int SoTheDoDoiKhach { get; set; }
        public string GhiChu { get; set; }
    }
}
