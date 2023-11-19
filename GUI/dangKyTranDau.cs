using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
	public partial class dangKyTranDau : Form
	{
		public dangKyTranDau()
		{
			InitializeComponent();
		}

		private void dangKyTranDau_Load(object sender, EventArgs e)
		{
			List<String> doiNha = DoiBongService.RetrieveAllIdDoiBong();
			foreach (String doinha in doiNha)
			{
				cbNha.Items.Add(doinha);
			}

			List<String> doiKhach = DoiBongService.RetrieveAllIdDoiBong();
			foreach (String doikhach in doiKhach)
			{
				cbKhach.Items.Add(doikhach);
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Lấy thời gian hiện tại
			TimeSpan thoiGianHienTai = DateTime.Now.TimeOfDay;

			// Lấy tổng số giây và làm tròn nó về phần nguyên
			int soGiayNguyen = (int)Math.Round(thoiGianHienTai.TotalSeconds);

			// Chuyển đổi thành chuỗi
			string chuoiThoiGian = soGiayNguyen.ToString();


			TranDau tranDau = new TranDau();
			tranDau.MaTranDau = chuoiThoiGian + txtVongDau.Text.ToString() + txtLuotDau.Text.ToString();
			tranDau.LuotDau = int.Parse(txtLuotDau.Text);
			tranDau.VongDau = int.Parse(txtVongDau.Text);
			tranDau.GhiChu = cbStatus.SelectedIndex.ToString();
			tranDau.SoBanThangDoiNha = 0;
			tranDau.SoBanThangDoiKhach = 0;
			tranDau.SoTheDoDoiKhach = 0;
			tranDau.SoTheDoDoiNha = 0;
			tranDau.SotheVangDoiKhach = 0;
			tranDau.SoTheVangDoiNha = 0;
			tranDau.MaDoiNha = cbNha.SelectedItem.ToString();
			tranDau.MaDoiKhach = cbKhach.SelectedItem.ToString();

			MessageBox.Show(cbNha.SelectedItem.ToString());

			dgvDangKy.DataSource = TranDauService.RetrieveAllTranDau();
			dgvDangKy.Columns["MATRANDAU"].HeaderText = "Mã trận đấu";
			dgvDangKy.Columns["MADOINHA"].HeaderText = "Mã đội nhà";
			dgvDangKy.Columns["MADOIKHACH"].HeaderText = "Mã đội khách";
			dgvDangKy.Columns["LUOTDAU"].HeaderText = "Lượt đấu";
			dgvDangKy.Columns["VONGDAU"].HeaderText = "Vòng đấu";
			dgvDangKy.Columns["SOBANTHANGDOINHA"].HeaderText = "Số bàn thắng đội nhà";
			dgvDangKy.Columns["SOBANTHANGDOIKHACH"].HeaderText = "Số bàn thắng đội khách";
			dgvDangKy.Columns["SOBANTHANGDOINHA"].Visible = false;
			dgvDangKy.Columns["SOBANTHANGDOIKHACH"].Visible = false;
			dgvDangKy.Columns["SOTHEVANGDOINHA"].Visible = false;
			dgvDangKy.Columns["SOTHEVANGDOIKHACH"].Visible = false;
			dgvDangKy.Columns["SOTHEDODOIKHACH"].Visible = false;
			dgvDangKy.Columns["SOTHEDODOINHA"].Visible = false;



			dgvDangKy.Columns["SOTHEVANGDOINHA"].HeaderText = "Thẻ vàng đội nhà";
			dgvDangKy.Columns["SOTHEVANGDOIKHACH"].HeaderText = "Thẻ vàng đội khách";

			dgvDangKy.Columns["SOTHEDODOINHA"].HeaderText = "Thẻ đỏ đội nhà";
			dgvDangKy.Columns["SOTHEDODOIKHACH"].HeaderText = "Thẻ đỏ đội khách";

			dgvDangKy.Columns["GHICHU"].HeaderText = "Status";

			TranDauService.SaveTranDau(tranDau);

		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
