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
    public partial class teamDetail : Form
    {
        private string MaDoi;
        private DoiBong doiBong;
        public teamDetail(string MaDoiBong)
        {
            this.MaDoi = MaDoiBong;
            InitializeComponent();
        }

        private void teamDetail_Load(object sender, EventArgs e)
        {
            doiBong = DoiBongService.GetDoiBongById(MaDoi);
            txtTenDoi.Text = doiBong.TenDoi;
            txtMaTinh.Text = doiBong.MaTinh;
            txtHLV.Text = doiBong.HLV;
            txtSoCauThu.Text = doiBong.SoLuongCauThu.ToString();
            txtSoCauThu.Enabled = false;

            DataTable listCauThu = CauThuService.GetMemBerOfTeam(MaDoi);
            guna2DataGridView1.DataSource = listCauThu;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(txtTenDoi.Text == ""||txtMaTinh.Text == ""||txtHLV.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ dữ liệu","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DoiBong update = new DoiBong();

            update.MaDoi = MaDoi;
            update.TenDoi = txtTenDoi.Text;
            update.MaTinh = txtMaTinh.Text;
            update.HLV = txtHLV.Text;
            update.SoLuongCauThu = int.Parse(txtSoCauThu.Text);
            update.SoBanThang = doiBong.SoBanThang;
            update.MaSan = doiBong.MaSan;
            update.SoBanThua = doiBong.SoBanThua;
            update.LoGo = doiBong.LoGo;
            update.SoDiem = doiBong.SoDiem;

            DoiBongService.UpdateDoiBong(update);
            MessageBox.Show("Chỉnh sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            doiBong = DoiBongService.GetDoiBongById(MaDoi);
            txtTenDoi.Text = doiBong.TenDoi;
            txtMaTinh.Text = doiBong.MaTinh;
            txtHLV.Text = doiBong.HLV;
            txtSoCauThu.Text = doiBong.SoLuongCauThu.ToString();
            txtSoCauThu.Enabled = false;
        }
    }
}
