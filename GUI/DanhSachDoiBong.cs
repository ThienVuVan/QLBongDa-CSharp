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

	public partial class DanhSachDoiBong : Form
	{
		public DanhSachDoiBong()
		{
			InitializeComponent();
		}

		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void DanhSachDoiBong_Load(object sender, EventArgs e)
		{
			dgvDoiBong.DataSource = DoiBongService.GetAllDoiBong();
			dgvDoiBong.Columns["MADOI"].HeaderText = "Mã đội";
			dgvDoiBong.Columns["MASAN"].HeaderText = "Mã sân";
			dgvDoiBong.Columns["MATINH"].HeaderText = "Mã tỉnh";
			dgvDoiBong.Columns["TENDOI"].HeaderText = "Tên đội";
			dgvDoiBong.Columns["HLV"].HeaderText = "HLV";
			dgvDoiBong.Columns["LOGO"].HeaderText = "Logo";
			dgvDoiBong.Columns["SODIEM"].HeaderText = "Điểm";
			dgvDoiBong.Columns["SOBANTHANG"].HeaderText = "Bàn thắng";
			dgvDoiBong.Columns["SOBANTHUA"].HeaderText = "Bàn thua";
			dgvDoiBong.Columns["SOLUONGCAUTHU"].HeaderText = "Số cầu thủ";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			dangKyDoiBong dangKyDoiBong = new dangKyDoiBong();
			dangKyDoiBong.ShowDialog(this);
		}
	}
}
