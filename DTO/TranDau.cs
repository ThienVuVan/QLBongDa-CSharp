using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TranDau
    {
        public string MaTranDau { get; set; }
        public string MaDoiNha { get; set; }
        public string MaDoiKhach { get; set; }
        public int LuotDau { get; set; }
        public int VongDau { get; set; }
        public int SoBanThangDoiNha { get; set; }
        public int SoBanThangDoiKhach { get; set; }
        public int SoTheVangDoiNha { get; set; }
        public int SotheVangDoiKhach { get; set; }
        public int SoTheDoDoiNha { get; set; }
        public int SoTheDoDoiKhach { get; set; }
        public string GhiChu { get; set; }
    }
}
