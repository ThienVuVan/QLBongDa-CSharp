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

namespace GUI
{
    public partial class UpdateTranDau : Form
    {
        private string MaTranDau;
        private TranDau tranDau;
        public UpdateTranDau(string MaTranDau)
        {
            this.MaTranDau = MaTranDau;
            InitializeComponent();
        }

        private void UpdateTranDau_Load(object sender, EventArgs e)
        {
            tranDau = TranDauService.GetTranDauById(MaTranDau);
            // mai update thêm
            List<string> MaNha = CauThuService.GetAllIdByMaDoi(tranDau.MaDoiNha);
            List<string> MaKhach = CauThuService.GetAllIdByMaDoi(tranDau.MaDoiKhach);
            foreach (string MaCT in MaNha) cbMaCTNha.Items.Add(MaCT);
            foreach (string MaCT in MaKhach) cbMaCTKhach.Items.Add(MaCT);
            txtLuotDau.Text = tranDau.LuotDau.ToString();
            txtVongDau.Text = tranDau.VongDau.ToString();
            txtMaNha.Text = tranDau.MaDoiNha.ToString();
            txtMaKhach.Text = tranDau.MaDoiKhach.ToString();
            //cbGhiChu.Text = tranDau.GhiChu;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
			// cần validate
			// nếu ấn nứt lưu là phải chọn GhiChu của trận đấu

			if (cbGhiChu.Text == "")
			{
				MessageBox.Show("Vui lòng cập nhật trạng thái trận đấu vào mục Ghi chú!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// nếu chọn radiobutton thì phải chọn Mã Cầu thủ.
            //Doi nha
			if ((rThangNha.Checked || rVangNha.Checked || rDoNha.Checked))
			{
				if (string.IsNullOrEmpty(cbMaCTNha.SelectedItem?.ToString()))
				{
					MessageBox.Show("Vui lòng chọn Mã Cầu thủ cho đội nhà.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
            //Doi khach
			if ((rThangKhach.Checked || rDoKhach.Checked || rVangKhach.Checked))
			{
				if (string.IsNullOrEmpty(cbMaCTKhach.SelectedItem?.ToString()))
				{
					MessageBox.Show("Vui lòng chọn Mã Cầu thủ cho đội khách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			if (MessageBox.Show("Xác nhận Cập Nhật", "xác nhận", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }
            TranDau update = new TranDau();
            update.MaTranDau = tranDau.MaTranDau;
            update.MaDoiNha = tranDau.MaDoiNha;
            update.MaDoiKhach = tranDau.MaDoiKhach;
            update.GhiChu = cbGhiChu.SelectedItem.ToString();
            string MaCtNha = "";
            string MaCtKhach = "";
            if (cbMaCTNha.Text != "") MaCtNha = cbMaCTNha.SelectedItem.ToString();
            if(cbMaCTKhach.Text != "") MaCtKhach = cbMaCTKhach.SelectedItem.ToString();
            bool ThangNha, VangNha, DoNha, ThangKhach, VangKhach, DoKhach;
            ThangNha = rThangNha.Checked;
            VangNha = rVangNha.Checked;
            DoNha = rDoNha.Checked;
            ThangKhach = rThangKhach.Checked;
            VangKhach = rVangKhach.Checked;
            DoKhach = rDoKhach.Checked;
            TranDauService.UpdateTranDau(update, MaCtNha, MaCtKhach, ThangNha, VangNha, DoNha, ThangKhach, VangKhach, DoKhach);

			MessageBox.Show("Cập nhật thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void txtLuotDau_TextChanged(object sender, EventArgs e)
		{
            txtLuotDau.ReadOnly = true;
		}

		private void txtVongDau_TextChanged(object sender, EventArgs e)
		{
            txtVongDau.ReadOnly = true;
		}

		private void txtMaNha_TextChanged(object sender, EventArgs e)
		{
            txtMaNha.ReadOnly = true;
		}

		private void txtMaKhach_TextChanged(object sender, EventArgs e)
		{
            txtMaKhach.ReadOnly = true;
		}

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            List<string> MaNha = CauThuService.GetAllIdByMaDoi(tranDau.MaDoiNha);
            List<string> MaKhach = CauThuService.GetAllIdByMaDoi(tranDau.MaDoiKhach);
            foreach (string MaCT in MaNha) cbMaCTNha.Items.Add(MaCT);
            foreach (string MaCT in MaKhach) cbMaCTKhach.Items.Add(MaCT);
            txtLuotDau.Text = tranDau.LuotDau.ToString();
            txtVongDau.Text = tranDau.VongDau.ToString();
            txtMaNha.Text = tranDau.MaDoiNha.ToString();
            txtMaKhach.Text = tranDau.MaDoiKhach.ToString();
            rThangNha.Checked = false;
            rVangNha.Checked = false;
            rDoNha.Checked = false;
            rThangKhach.Checked = false;
            rVangKhach.Checked = false;
            rDoKhach.Checked = false;
            cbMaCTNha.Text = "";
            cbMaCTKhach.Text = "";
        }
    }
}
