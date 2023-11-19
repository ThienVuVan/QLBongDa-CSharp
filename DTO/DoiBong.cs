using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoiBong
    {
        public DoiBong(string maDoi, string maSan, string maTinh, string tenDoi, string hLV, string loGo, int soDiem, int soBanThang, int soBanThua, int soLuongCauThu)
        {
            MaDoi = maDoi;
            MaSan = maSan;
            MaTinh = maTinh;
            TenDoi = tenDoi;
            HLV = hLV;
            LoGo = loGo;
            SoDiem = soDiem;
            SoBanThang = soBanThang;
            SoBanThua = soBanThua;
            SoLuongCauThu = soLuongCauThu;
        }

        public string MaDoi { get; set; }
        public string MaSan { get; set; }
        public string MaTinh { get; set; }
        public string TenDoi { get; set; }
        public string HLV { get; set; }
        public string LoGo { get; set; }
        public int SoDiem { get; set; }
        public int SoBanThang { get; set; }
        public int SoBanThua { get; set; }
        public int SoLuongCauThu { get; set; }
    }
}
