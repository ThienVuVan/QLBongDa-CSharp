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
	public partial class RankDetail : Form
	{
		string TieuDe;
		DataTable dt;
		public RankDetail(string tieuDe,DataTable  table)
		{
			this.TieuDe = tieuDe;
			this.dt = table;
			InitializeComponent();
		}

        private void RankDetail_Load(object sender, EventArgs e)
        {
			label1.Text = TieuDe;
			dgvBangXepHang.DataSource = dt;
			
            if(dt.Columns.Count == 10)
            {
                dgvBangXepHang.Columns["MADOI"].HeaderText = "Mã đội";
                dgvBangXepHang.Columns["MASAN"].HeaderText = "Mã sân";
                dgvBangXepHang.Columns["MATINH"].HeaderText = "Mã tỉnh";
                dgvBangXepHang.Columns["TENDOI"].HeaderText = "Tên đội";
                dgvBangXepHang.Columns["HLV"].HeaderText = "HLV";
                dgvBangXepHang.Columns["LOGO"].HeaderText = "Logo";
                dgvBangXepHang.Columns["SODIEM"].HeaderText = "Điểm";
                dgvBangXepHang.Columns["SOBANTHANG"].HeaderText = "Bàn thắng";
                dgvBangXepHang.Columns["SOBANTHUA"].HeaderText = "Bàn thua";
                dgvBangXepHang.Columns["SOLUONGCAUTHU"].HeaderText = "Số cầu thủ";
                return;
            }
            if(dt.Columns.Count == 12 && dt.Columns[0].ColumnName == "MATRANDAU")
            {
                dgvBangXepHang.Columns["MATRANDAU"].HeaderText = "Mã trận đấu";
                dgvBangXepHang.Columns["MADOINHA"].HeaderText = "Mã đội nhà";
                dgvBangXepHang.Columns["MADOIKHACH"].HeaderText = "Mã đội khách";
                dgvBangXepHang.Columns["LUOTDAU"].HeaderText = "Lượt đấu";
                dgvBangXepHang.Columns["VONGDAU"].HeaderText = "Vòng đấu";
                dgvBangXepHang.Columns["SOBANTHANGDOINHA"].HeaderText = "Bàn thắng đội nhà";
                dgvBangXepHang.Columns["SOBANTHANGDOIKHACH"].HeaderText = "Bàn thắng đội khách";
                dgvBangXepHang.Columns["SOTHEVANGDOINHA"].HeaderText = "Thẻ vàng đội nhà";
                dgvBangXepHang.Columns["SOTHEVANGDOIKHACH"].HeaderText = "Thẻ vàng đội khách";
                dgvBangXepHang.Columns["SOTHEDODOINHA"].HeaderText = "Thẻ đỏ đội nhà";
                dgvBangXepHang.Columns["SOTHEDODOIKHACH"].HeaderText = "Thẻ đỏ đội khách";
                dgvBangXepHang.Columns["GHICHU"].HeaderText = "Ghi chú";
                return;
            }

            if (dt.Columns.Count == 12)
            {
                dgvBangXepHang.Columns["MACAUTHU"].HeaderText = "Mã cầu thủ";
                dgvBangXepHang.Columns["MADOI"].HeaderText = "Mã đội bóng";
                dgvBangXepHang.Columns["MAQUOCTICH"].HeaderText = "Mã quốc tịch";
                dgvBangXepHang.Columns["TEN"].HeaderText = "Họ và tên";
                dgvBangXepHang.Columns["VITRICHOI"].HeaderText = "Vị trí";
                dgvBangXepHang.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
                dgvBangXepHang.Columns["SOAO"].HeaderText = "Số áo";
                dgvBangXepHang.Columns["SOBANTHANG"].HeaderText = "Số bàn thắng";
                dgvBangXepHang.Columns["SOTHEVANG"].HeaderText = "Thẻ vàng";
                dgvBangXepHang.Columns["SOTHEDO"].HeaderText = "Thẻ đỏ";
                dgvBangXepHang.Columns["SOLANRASAN"].HeaderText = "Ra sân";
                dgvBangXepHang.Columns["ANH"].HeaderText = "Ảnh";
                return;
            }
        }
    }
}
