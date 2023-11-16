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

		private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];

				// Lấy giá trị từ dòng đã chọn
				string id = selectedRow.Cells["Mã đội"].Value.ToString();
				MessageBox.Show($"{id}");

				// Hiển thị form chi tiết

			}
		}
	}
}
