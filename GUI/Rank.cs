using BLL;
using DTO;
using GUI.Properties;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class Rank : Form
	{
		public Rank()
		{
			InitializeComponent();
		}

        private void Rank_Load(object sender, EventArgs e)
        {
			CauThu cauThu = CauThuService.CauThuHayNhat();
			DoiBong doiBong = DoiBongService.DoiBongHayNhat();
			TranDau tranDau	= TranDauService.TranDauHayNhat();
			lbTendoi.Text = doiBong.TenDoi.ToString();
			lbTenCT.Text = cauThu.Ten.ToString();
			lbMaTran.Text = tranDau.MaTranDau.ToString();
			lbTongBT.Text = (tranDau.SoBanThangDoiNha + tranDau.SoBanThangDoiKhach).ToString();
			lbDiem.Text = doiBong.SoDiem.ToString();
			lbSobtCT.Text = cauThu.SoBanThang.ToString();
			picLogo.Image = Image.FromFile("../../Resources/Image Giai Bong/Logo/"+doiBong.LoGo);
            picCT.Image = Image.FromFile("../../Resources/IMGCauThu/" + cauThu.Anh);
            picTranDau.Image = Image.FromFile("../../Resources/IMGLogo/download.jpg");
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
			DataTable dt = DoiBongService.SortDoiByScore();
			RankDetail detail = new RankDetail("Bảng Xếp Hạng Đội Bóng", dt);
			detail.ShowDialog();
        }

        private void btnCauthu_Click(object sender, EventArgs e)
        {
            DataTable dt = CauThuService.SortCauThuByGoal();
            RankDetail detail = new RankDetail("Bảng Xếp Hạng Cầu Thủ", dt);
            detail.ShowDialog();
        }

        private void btnTran_Click(object sender, EventArgs e)
        {
            DataTable dt = TranDauService.SortTranDauBySoBanThang();
            RankDetail detail = new RankDetail("Bảng Xếp Hạng Trận Đấu Hay", dt);
            detail.ShowDialog();
        }
    }
}
