﻿using BLL;
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
			hienChiTiet(false);
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

		private void btnThem_Click(object sender, EventArgs e)
		{
            if (cbNha.Text == "" || cbKhach.Text == "" || cbStatus.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa đầy đủ!");
                return;
            }
            if (MessageBox.Show("Xác Nhận Đăng Ký Trận Đấu!", "Xác Nhận", MessageBoxButtons.OKCancel) != DialogResult.OK) return;
			if (btnThemMoi.Enabled == true)
			{
				// Lấy thời gian hiện tại
				TimeSpan thoiGianHienTai = DateTime.Now.TimeOfDay;

				// Lấy tổng số giây và làm tròn nó về phần nguyên
				int soGiayNguyen = (int)Math.Round(thoiGianHienTai.TotalSeconds);

				// Chuyển đổi thành chuỗi
				string chuoiThoiGian = soGiayNguyen.ToString();


				TranDau tranDau = new TranDau();
				tranDau.MaTranDau = chuoiThoiGian;
				tranDau.MaDoiNha = cbNha.SelectedItem.ToString();
				tranDau.MaDoiKhach = cbKhach.SelectedItem.ToString();
				tranDau.LuotDau = txtLuotDau.Text;
				tranDau.VongDau = txtVongDau.Text;
				tranDau.GhiChu = cbStatus.SelectedItem.ToString();
				tranDau.SoBanThangDoiNha = 0;
				tranDau.SoBanThangDoiKhach = 0;
				tranDau.SoTheDoDoiKhach = 0;
				tranDau.SoTheDoDoiNha = 0;
				tranDau.SotheVangDoiKhach = 0;
				tranDau.SoTheVangDoiNha = 0;


				TranDauService.SaveTranDau(tranDau);
				dgvDangKy.DataSource = TranDauService.RetrieveAllTranDau();
				dgvDangKy.Columns["MATRANDAU"].HeaderText = "Mã trận đấu";
				dgvDangKy.Columns["MADOINHA"].HeaderText = "Mã đội nhà";
				dgvDangKy.Columns["MADOIKHACH"].HeaderText = "Mã đội khách";
				dgvDangKy.Columns["LUOTDAU"].HeaderText = "Lượt đấu";
				dgvDangKy.Columns["VONGDAU"].HeaderText = "Vòng đấu";
				
				dgvDangKy.Columns["SOBANTHANGDOINHA"].HeaderText = "Số bàn thắng đội nhà";
				dgvDangKy.Columns["SOBANTHANGDOIKHACH"].HeaderText = "Số bàn thắng đội khách";
				//dgvDangKy.Columns["SOBANTHANGDOINHA"].Visible = false;
				//dgvDangKy.Columns["SOBANTHANGDOIKHACH"].Visible = false;
				//dgvDangKy.Columns["SOTHEVANGDOINHA"].Visible = false;
				//dgvDangKy.Columns["SOTHEVANGDOIKHACH"].Visible = false;
				//dgvDangKy.Columns["SOTHEDODOIKHACH"].Visible = false;
				//dgvDangKy.Columns["SOTHEDODOINHA"].Visible = false;
				dgvDangKy.Columns["SOTHEVANGDOINHA"].HeaderText = "Thẻ vàng đội nhà";
				dgvDangKy.Columns["SOTHEVANGDOIKHACH"].HeaderText = "Thẻ vàng đội khách";
				dgvDangKy.Columns["SOTHEDODOINHA"].HeaderText = "Thẻ đỏ đội nhà";
				dgvDangKy.Columns["SOTHEDODOIKHACH"].HeaderText = "Thẻ đỏ đội khách";
				dgvDangKy.Columns["GHICHU"].HeaderText = "Status";
				MessageBox.Show("Đăng Ký Thành Công, Xem Kết Quả Bên Dưới");
			}
			
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			Close();
		}


		private void dgvDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//Hiển thị nút sửa
			btnThem.Enabled = false;
			try
			{
				txtLuotDau.Text = dgvDangKy.CurrentRow.Cells[3].Value.ToString();
				txtVongDau.Text = dgvDangKy.CurrentRow.Cells[4].Value.ToString();
				cbNha.Text = dgvDangKy.CurrentRow.Cells["MADOINHA"].Value.ToString();
				cbKhach.Text = dgvDangKy.CurrentRow.Cells["MADOIKHACH"].Value.ToString();
				cbStatus.Text = dgvDangKy.CurrentRow.Cells["GHICHU"].Value.ToString();
			}
			catch (Exception ex)
			{

			}

		}

		private void hienChiTiet(bool hien)
		{
			txtLuotDau.Enabled = hien;
			txtVongDau.Enabled = hien;
			cbKhach.Enabled = hien;
			cbNha.Enabled = hien;
			cbStatus.Enabled = hien;

			//Ẩn hiện 2 nút Lưu và Hủy
			btnThem.Enabled = hien;
			btnHuy.Enabled = hien;
		}

		private void TrangChiTiet()
		{
			txtLuotDau.Enabled = true;
			txtVongDau.Enabled = true;
			cbNha.Enabled = true;
			cbKhach.Enabled = true;
			cbStatus.Enabled = true;
		}

		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			TrangChiTiet();
			btnThem.Enabled = true;
			btnHuy.Enabled = true;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			hienChiTiet(true);
			btnThemMoi.Enabled = false;
		}

        private void txtVongDau_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVongDau.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị.");
                return;
            }
            // Kiểm tra nếu có kí tự đặc biệt
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVongDau.Text, "[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ và số.");
                txtVongDau.Text = ""; // Xóa kí tự đặc biệt
            }

            // Kiểm tra giới hạn chiều dài
            if (txtVongDau.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập không quá 50 kí tự.");
                txtVongDau.Text = txtVongDau.Text.Substring(0, 50);
            }
        }

        private void txtLuotDau_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLuotDau.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị.");
                return;
            }
            // Kiểm tra nếu có kí tự đặc biệt
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVongDau.Text, "[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ và số.");
                txtVongDau.Text = ""; // Xóa kí tự đặc biệt
            }

            // Kiểm tra giới hạn chiều dài
            if (txtVongDau.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập không quá 50 kí tự.");
                txtVongDau.Text = txtVongDau.Text.Substring(0, 50); // Giới hạn chiều dài
            }
        }
    }
}
