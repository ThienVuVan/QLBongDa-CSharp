using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CauThu
    {

        string MaCauThu { get; set; }
        string MaDoi { get; set; }
        string MaQuocTinh { get; set; }
        string Ten { get; set; }
        string ViTriChoi { get; set; }
        DateTime NgaySinh { get; set; }
        int SoAo { get; set; }
        int SoBanThang { get; set; }
        int SoTheVang { get; set; }
        int SoTheDo { get; set; }
        int SoLanRaSan { get; set; }
        string Anh { get; set; }
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
