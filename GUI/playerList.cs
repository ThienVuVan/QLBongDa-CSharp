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
using GUI;
using Guna.UI2.WinForms;

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

			gridCauThu.DataSource = CauThuService.Filter(txtTen.Text, txtTenDoiBong.Text,txtSoBanThang.Text == "" ? 0 : int.Parse(txtSoBanThang.Text));
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			addPlayer addNewPlayer = new addPlayer();
			addNewPlayer.ShowDialog();
			
		}

		private void playerList_Load(object sender, EventArgs e)
		{
			DataTable dt = CauThuService.RetrieveAllCauThu();
			int numberCauThu = dt.Rows.Count;
			lbSoLuong.Text = numberCauThu.ToString();
			gridCauThu.DataSource = dt;
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
			gridCauThu.Columns["ANH"].HeaderText = "Anh";

            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)gridCauThu.Columns["ANHCAUTHU"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
		

            foreach (DataGridViewRow row in gridCauThu.Rows)
			{
				if (row.Cells["ANH"].Value != null)
				{
					string path = Path.Combine("../../Resources/IMGCauThu", row.Cells["ANH"].Value.ToString());
					Image image = Image.FromFile(path);
                    row.Cells["ANHCAUTHU"].Value = image;
                }
			}



		}

		private void gridCauThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			if(MessageBox.Show("Bạn có muốn xóa cầu thủ này không?","Thông Báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
                string MaCauThu = gridCauThu.SelectedRows[0].Cells[0].Value.ToString();
                CauThuService.DeleteCauThu(MaCauThu);
                gridCauThu.Rows.Remove(gridCauThu.SelectedRows[0]);
            }
        }
    }
}
