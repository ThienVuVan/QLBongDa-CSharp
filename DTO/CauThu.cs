using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CauThu
    {
        public string MaCauThu { get; set; }
        public string MaDoi { get; set; }
        public string MaQuocTinh { get; set; }
        public string Ten { get; set; }
        public string ViTriChoi { get; set; }
        public DateTime NgaySinh { get; set; }
        public int SoAo { get; set; }
        public int SoBanThang { get; set; }
        public int SoTheVang { get; set; }
        public int SoTheDo { get; set; }
        public int SoLanRaSan { get; set; }
        public string Anh { get; set; }
        public CauThu()
        {
        }
        public CauThu(string maCauThu, string maDoi, string maQuocTinh, string ten, string viTriChoi, DateTime ngaySinh, int soAo, int soBanThang, int soTheVang, int soTheDo, int soLanRaSan, string anh)
        {
            MaCauThu = maCauThu;
            MaDoi = maDoi;
            MaQuocTinh = maQuocTinh;
            Ten = ten;
            ViTriChoi = viTriChoi;
            NgaySinh = ngaySinh;
            SoAo = soAo;
            SoBanThang = soBanThang;
            SoTheVang = soTheVang;
            SoTheDo = soTheDo;
            SoLanRaSan = soLanRaSan;
            Anh = anh;
        }
    }
}
