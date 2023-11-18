using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI;

namespace GUI
{
	public partial class playerList : Form
	{
		public playerList()
		{
			InitializeComponent();
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			CauThu cauThu = new CauThu();
			cauThu.Ten = txtTen.Text;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			addPlayer addNewPlayer = new addPlayer();
			addNewPlayer.ShowDialog();
			
		}

		private void playerList_Load(object sender, EventArgs e)
		{
			gridCauThu.DataSource = CauThuService.RetrieveAllCauThu();
			gridCauThu.Columns["MACAUTHU"].HeaderText = "Mã cầu thủ";
			gridCauThu.Columns["MADOI"].HeaderText = "Mã đội bóng";
			gridCauThu.Columns["MAQUOCTICH"].HeaderText = "Mã quốc tịch";
			gridCauThu.Columns["TEN"].HeaderText = "Họ và tên";
			gridCauThu.Columns["VITRICHOI"].HeaderText = "Vị trí";
			gridCauThu.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
			gridCauThu.Columns["SOAO"].HeaderText = "Số áo";
			gridCauThu.Columns["SOBANTHANG"].HeaderText = "Số bàn thắng";
			gridCauThu.Columns["SOTHEVANG"].HeaderText = "Thẻ vàng";
			gridCauThu.Columns["SOTHEDO"].HeaderText = "Thẻ đỏ";
			gridCauThu.Columns["SOLANRASAN"].HeaderText = "Ra sân";
			gridCauThu.Columns["ANH"].HeaderText = "Ảnh";

		}

		private void gridCauThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
