using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TranDau
    {
        string MaTranDau { get; set; }
        string MaDoiNha { get; set; }
        string MaDoiKhach { get; set; }
        int LuotDau { get; set; }
        int VongDau { get; set; }
        int SoBanThangDoiNha { get; set; }
        int SoBanThangDoiKhach { get; set; }
        int SoTheVangDoiNha { get; set; }
        int SotheVangDoiKhach { get; set; }
        int SoTheDoDoiNha { get; set; }
        int SoTheDoDoiKhach { get; set; }
        string GhiChu { get; set; }
    }
}
