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
	public partial class addPlayer : Form
	{
		public addPlayer()
		{
			InitializeComponent();
		}

		private void addPlayer_Load(object sender, EventArgs e)
		{
			List<String> list = DoiBongService.RetrieveAllIdDoiBong();
			foreach (String name in list)
			{
				cbMaDoi.Items.Add(name);
			}

			List<String> listQt = QuocTichService.RetrieveAllIdQuocTich();
			foreach (String qt in listQt)
			{
				cbQuocTich.Items.Add(qt);	
			}
		}

		private void txtName_TextChanged(object sender, EventArgs e)
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



			CauThu cauThu =  new CauThu();


			cauThu.Ten = txtName.Text;
			cauThu.MaCauThu = chuoiThoiGian;
			cauThu.MaQuocTinh = cbQuocTich.SelectedIndex.ToString();
			cauThu.MaDoi = cbMaDoi.SelectedIndex.ToString();
			cauThu.NgaySinh = dtpNgaySinh.Value;
			cauThu.ViTriChoi = cbViTri.SelectedIndex.ToString();
			cauThu.Anh = openImg.FileName.Trim().Split('\\').Last();
			cauThu.SoBanThang = 0;
			cauThu.SoLanRaSan = 0;
			cauThu.SoTheDo = 0;
			cauThu.SoTheVang = 0;

			// Đường dẫn thư mục mà bạn muốn lưu ảnh vào
			string duongDanThuMuc = Path.Combine("D:\\LapTrinhTrucQuan\\QLBongDa-CSharp\\GUI\\Resources\\IMGCauThu");
			// Đường dẫn đầy đủ cho việc lưu ảnh vào thư mục
			string duongDanLuu = Path.Combine(duongDanThuMuc, cauThu.Anh);

			// Copy tệp tin ảnh vào thư mục
			File.Copy(openImg.FileName.Trim(), duongDanLuu, true);

		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtName.Text = "";
			cbQuocTich.SelectedIndex = -1;
			txtSoAo.Text = "";
			cbMaDoi.SelectedIndex = -1;
			cbViTri.SelectedIndex = -1;
			dtpNgaySinh.Text = string.Empty;	

		}

		private void btnImg_Click(object sender, EventArgs e)
		{
			// open file dialog   
			
			// image filters  
			openImg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
			if (openImg.ShowDialog() == DialogResult.OK)
			{
				// display image in picture box  
				picBox.Image = new Bitmap(openImg.FileName);

				
			}
		}
	}
}
