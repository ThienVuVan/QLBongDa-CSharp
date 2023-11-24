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
	public partial class detailTranDau : Form
	{
        private string MaTranDau;
        private TranDau tranDau;
        public detailTranDau(string MaTranDau)
		{
			this.MaTranDau = MaTranDau.Trim();
			InitializeComponent();
		}

        private void detailTranDau_Load(object sender, EventArgs e)
        {
            tranDau = TranDauService.GetTranDauById(MaTranDau);
            txtLuotDau.Text = tranDau.LuotDau.ToString();
            txtVongDau.Text = tranDau.VongDau.ToString();
            txtBanThangNha.Text = tranDau.SoBanThangDoiNha.ToString();
            txtBanThangKhach.Text = tranDau.SoBanThangDoiKhach.ToString();
            txtDoNha.Text = tranDau.SoTheDoDoiNha.ToString();
            txtKhach.Text = tranDau.SoTheDoDoiKhach.ToString();
            txtVangNha.Text = tranDau.SoTheVangDoiNha.ToString();
            txtVangKhach.Text = tranDau.SotheVangDoiKhach.ToString();
            txtMaNha.Text = tranDau.MaDoiNha.ToString();
            txtMaKhach.Text = tranDau.MaDoiKhach.ToString();
            cbGhiChu.Text = tranDau.GhiChu;

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

		private void txtBanThangNha_TextChanged(object sender, EventArgs e)
		{
			txtBanThangNha.ReadOnly = true;
		}

		private void txtBanThangKhach_TextChanged(object sender, EventArgs e)
		{
			txtBanThangKhach.ReadOnly = true;
		}

		private void txtVangNha_TextChanged(object sender, EventArgs e)
		{
			txtVangNha.ReadOnly=true;
		}

		private void txtVangKhach_TextChanged(object sender, EventArgs e)
		{
			txtVangKhach.ReadOnly=true;
		}

		private void txtDoNha_TextChanged(object sender, EventArgs e)
		{
			txtDoNha.ReadOnly=true;
		}

		private void txtKhach_TextChanged(object sender, EventArgs e)
		{
			txtKhach.ReadOnly=true;
		}

		private void cbGhiChu_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
