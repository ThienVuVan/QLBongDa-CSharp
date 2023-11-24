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
    }
}
