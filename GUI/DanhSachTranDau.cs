using BLL;
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
	public partial class DanhSachTranDau : Form
	{
		public DanhSachTranDau()
		{
			InitializeComponent();
		}


		private void btnAdd_Click(object sender, EventArgs e)
		{
			dangKyTranDau dangKyTranDau = new dangKyTranDau();
			dangKyTranDau.ShowDialog();
		}

		private void dgDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void DanhSachTranDau_Load(object sender, EventArgs e)
		{
			dgDanhSach.DataSource = TranDauService.RetrieveAllTranDau();
			dgDanhSach.Columns["MATRANDAU"].HeaderText = "Mã trận đấu";
			dgDanhSach.Columns["MADOINHA"].HeaderText = "Mã đội nhà";
			dgDanhSach.Columns["MADOIKHACH"].HeaderText = "Mã đội khách";
			dgDanhSach.Columns["LUOTDAU"].HeaderText = "Lượt đấu";
			dgDanhSach.Columns["VONGDAU"].HeaderText = "Vòng đấu";
			dgDanhSach.Columns["SOBANTHANGDOINHA"].HeaderText = "Bàn thắng đội nhà";
			dgDanhSach.Columns["SOBANTHANGDOIKHACH"].HeaderText = "Bàn thắng đội khách";
			dgDanhSach.Columns["SOTHEVANGDOINHA"].HeaderText = "Thẻ vàng đội nhà";
			dgDanhSach.Columns["SOTHEVANGDOIKHACH"].HeaderText = "Thẻ vàng đội khách";
			dgDanhSach.Columns["SOTHEDODOINHA"].HeaderText = "Thẻ đỏ đội nhà";
			dgDanhSach.Columns["SOTHEDODOIKHACH"].HeaderText = "Thẻ đỏ đội khách";
			dgDanhSach.Columns["GHICHU"].HeaderText = "Ghi chú";
		}
	}
}
