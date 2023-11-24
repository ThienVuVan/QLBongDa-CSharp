using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Guna.UI2.WinForms.Suite;

namespace GUI
{
	public partial class dangKyDoiBong : Form
	{
		public dangKyDoiBong()
		{
			InitializeComponent();
		}

		private void btnAddImg_Click(object sender, EventArgs e)
		{
			//         OpenFileDialog ofd = new OpenFileDialog();
			//ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
			//         ofd.FilterIndex = 1;
			//         ofd.Title = "Chọn ảnh";
			//ofd.ShowDialog(this);
			// open file dialog   

			// image filters  
			openImg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
			if (openImg.ShowDialog() == DialogResult.OK)
			{
				// display image in picture box  
				picBox.Image = new Bitmap(openImg.FileName);


			}

		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtTenDoi.Text = "";
			txtMaTinh.Text = "";
			txtHLV.Text = "";
			txtSoCauThu.Text = "";
			picBox.Image = Image.FromFile("E:\\Year3\\SEMESTER 1\\BTL Csharp\\QLBongDa-CSharp\\GUI\\Resources\\395976310_6668012846643044_8059022898882066628_n.png");
		}

		private void btnFinish_Click(object sender, EventArgs e)
		{
			if (txtTenDoi.Text == "" || txtMaTinh.Text == "" || txtHLV.Text == "")
			{
				MessageBox.Show("Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
			}
			if (int.TryParse(txtSoCauThu.Text, out int value))
			{
				// Kiểm tra xem giá trị có lớn hơn 0 hay không
				if (value < 0)
				{
					MessageBox.Show("Giá trị phải là số nguyên lớn hơn 0.");
					txtSoCauThu.Clear();
				}
			}
			// Lấy thời gian hiện tại
			TimeSpan thoiGianHienTai = DateTime.Now.TimeOfDay;
			// Lấy tổng số giây và làm tròn nó về phần nguyên
			int soGiayNguyen = (int)Math.Round(thoiGianHienTai.TotalSeconds);

			// Chuyển đổi thành chuỗi
			string chuoiThoiGian = soGiayNguyen.ToString();

			DoiBong doiBong = new DoiBong();

			doiBong.TenDoi = txtTenDoi.Text;
			doiBong.MaTinh = txtMaTinh.Text;
			doiBong.MaDoi = chuoiThoiGian;
			doiBong.HLV = txtHLV.Text;
			doiBong.SoLuongCauThu = 0;
			doiBong.LoGo = openImg.FileName.Trim().Split('\\').Last();
			doiBong.SoBanThang = 0;
			doiBong.SoBanThua = 0;
			doiBong.SoDiem = 0;
			doiBong.MaSan = "S01";
			DoiBongService.SaveDoiBong(doiBong);
			try
			{
				// Đường dẫn thư mục mà bạn muốn lưu ảnh vào
				string duongDanThuMuc = Path.Combine("E:\\Year3\\SEMESTER 1\\BTL Csharp\\QLBongDa-CSharp\\GUI\\Resources\\IMGLogo\\");
				// Đường dẫn đầy đủ cho việc lưu ảnh vào thư mục
				string duongDanLuu = Path.Combine(duongDanThuMuc, doiBong.LoGo);

				// Copy tệp tin ảnh vào thư mục
				File.Copy(openImg.FileName.Trim(), duongDanLuu, true);

				MessageBox.Show("Dữ liệu đã được nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Đã xảy ra lỗi khi nhập ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this.Close();

		}

		private void dangKyDoiBong_Load(object sender, EventArgs e)
		{
			txtSoCauThu.Enabled = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtTenDoi_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				// Huỷ bỏ sự kiện KeyPress
				e.Handled = true;
			}
		}

		private void txtHLV_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				// Huỷ bỏ sự kiện KeyPress
				e.Handled = true;
			}
		}

		private void txtMaTinh_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				// Huỷ bỏ sự kiện KeyPress
				e.Handled = true;
			}
		}
	}
}
