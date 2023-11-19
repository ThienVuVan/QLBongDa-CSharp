using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.Properties;
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

			dgvTeammate.DataSource = CauThuService.GetMemBerOfTeam(cbMaDoi.Text);
			dgvTeammate.Columns["MACAUTHU"].HeaderText = "Mã cầu thủ";
			dgvTeammate.Columns["MADOI"].HeaderText = "Mã đội bóng";
			dgvTeammate.Columns["MAQUOCTICH"].HeaderText = "Mã quốc tịch";
			dgvTeammate.Columns["TEN"].HeaderText = "Họ và tên";
			dgvTeammate.Columns["VITRICHOI"].HeaderText = "Vị trí";
			dgvTeammate.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
			dgvTeammate.Columns["SOAO"].HeaderText = "Số áo";
			dgvTeammate.Columns["SOBANTHANG"].HeaderText = "Số bàn thắng";
			dgvTeammate.Columns["SOTHEVANG"].HeaderText = "Thẻ vàng";
			dgvTeammate.Columns["SOTHEDO"].HeaderText = "Thẻ đỏ";
			dgvTeammate.Columns["SOLANRASAN"].HeaderText = "Ra sân";
			dgvTeammate.Columns["ANH"].HeaderText = "Ảnh";
            
			
        }
		

        private void txtName_TextChanged(object sender, EventArgs e)
		{
		
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if(txtName.Text == "" || txtSoAo.Text == "" || cbMaDoi.Text == "" || cbQuocTich.Text == "" || cbViTri.Text == "")
			{
				MessageBox.Show("Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
			}
			// Lấy thời gian hiện tại
			TimeSpan thoiGianHienTai = DateTime.Now.TimeOfDay;

			// Lấy tổng số giây và làm tròn nó về phần nguyên
			int soGiayNguyen = (int)Math.Round(thoiGianHienTai.TotalSeconds);

			// Chuyển đổi thành chuỗi
			string chuoiThoiGian = soGiayNguyen.ToString();



			CauThu cauThu =  new CauThu();


			cauThu.Ten = txtName.Text;
			cauThu.MaCauThu = chuoiThoiGian;
			cauThu.MaQuocTinh = cbQuocTich.SelectedItem.ToString();
			cauThu.MaDoi = cbMaDoi.SelectedItem.ToString();
			cauThu.NgaySinh = dtpNgaySinh.Value;
			cauThu.ViTriChoi = cbViTri.SelectedItem.ToString();
			cauThu.Anh = Path.GetFileName(openImg.FileName);
			cauThu.SoBanThang = 0;
			cauThu.SoLanRaSan = 0;
			cauThu.SoTheDo = 0;
			cauThu.SoTheVang = 0;


      string duongDanThuMuc = Path.Combine("F:\\Desktop\\BTL_Winform\\QLBongDa-CSharp\\GUI\\Resources\\IMGCauThu");
      // Đường dẫn đầy đủ cho việc lưu ảnh vào thư mục
      string duongDanLuu = Path.Combine(duongDanThuMuc,Path.GetFileName(openImg.FileName));
      // Copy tệp tin ảnh vào thư mục
			if (File.Exists(duongDanLuu))
			{
				MessageBox.Show("Anh da ton tai");
                CauThuService.SaveCauThu(cauThu);
                return;
			}
			else
			{
                File.Copy(openImg.FileName.Trim(), duongDanLuu);
                CauThuService.SaveCauThu(cauThu);
            }
			
			

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

        private void cbMaDoi_SelectedIndexChanged(object sender, EventArgs e)
        {
			dgvTeammate.DataSource = CauThuService.GetMemBerOfTeam(cbMaDoi.SelectedItem.ToString());
        }
    }
}
