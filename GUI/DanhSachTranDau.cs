using BLL;
using GUI.ReportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI
{
	public partial class DanhSachTranDau : Form
	{
		public DanhSachTranDau()
		{
			InitializeComponent();
		}


		private void btnAdd_Click(object sender, EventArgs e)
		{
			dangKyTranDau dangKyTranDau = new dangKyTranDau();
			dangKyTranDau.ShowDialog();
		}

		private void DanhSachTranDau_Load(object sender, EventArgs e)
		{
			List<string> doinha = DoiBongService.RetrieveAllNameDoiBong();
			foreach (string doi in doinha)
			{
				cbDoiNha.Items.Add(doi);
			}

			dgDanhSach.DataSource = TranDauService.RetrieveAllTranDau();
			dgDanhSach.Columns["MATRANDAU"].HeaderText = "Mã trận đấu";
			dgDanhSach.Columns["MADOINHA"].HeaderText = "Mã đội nhà";
			dgDanhSach.Columns["MADOIKHACH"].HeaderText = "Mã đội khách";
			dgDanhSach.Columns["LUOTDAU"].HeaderText = "Lượt đấu";
			dgDanhSach.Columns["VONGDAU"].HeaderText = "Vòng đấu";
			dgDanhSach.Columns["SOBANTHANGDOINHA"].HeaderText = "Bàn thắng đội nhà";
			dgDanhSach.Columns["SOBANTHANGDOIKHACH"].HeaderText = "Bàn thắng đội khách";
			dgDanhSach.Columns["SOTHEVANGDOINHA"].HeaderText = "Thẻ vàng đội nhà";
			dgDanhSach.Columns["SOTHEVANGDOIKHACH"].HeaderText = "Thẻ vàng đội khách";
			dgDanhSach.Columns["SOTHEDODOINHA"].HeaderText = "Thẻ đỏ đội nhà";
			dgDanhSach.Columns["SOTHEDODOIKHACH"].HeaderText = "Thẻ đỏ đội khách";
			dgDanhSach.Columns["GHICHU"].HeaderText = "Ghi chú";
		}

		private void btnXuatFile_Click(object sender, EventArgs e)
		{
			if (dgDanhSach.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgDanhSach.SelectedRows[0];
				string maTranDau = selectedRow.Cells["MATRANDAU"].Value.ToString();
				Excel2 excel = new Excel2();
				excel.Ma = maTranDau;
				excel.ShowDialog();
			}
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			int? soBanThang = null;
			int? soTheDo = null;
			string tenDoiNha = cbDoiNha.SelectedItem?.ToString(); // Kiểm tra giá trị null

			// Kiểm tra và chuyển đổi dữ liệu từ TextBox sang kiểu int?
			if (!string.IsNullOrWhiteSpace(txtSoBan.Text) && int.TryParse(txtSoBan.Text, out int banThang))
			{
				soBanThang = banThang;
			}

			if (!string.IsNullOrWhiteSpace(txtTheDo.Text) && int.TryParse(txtTheDo.Text, out int theDo))
			{
				soTheDo = theDo;
			}

			DataTable filteredData = TranDauService.Filter(null, tenDoiNha, soBanThang, soTheDo);

			if (filteredData.Rows.Count == 0)
			{
				dgDanhSach.DataSource = null;
				MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			dgDanhSach.DataSource = filteredData;
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			if (dgDanhSach.SelectedRows.Count == 0)
			{
				MessageBox.Show("Hãy chọn tran dau!");
			}
			DataGridViewRow selectedRow = dgDanhSach.SelectedRows[0];
			string MaTranDau = selectedRow.Cells["MATRANDAU"].Value.ToString();
			detailTranDau detailTran = new detailTranDau(MaTranDau);
			detailTran.Show();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgDanhSach.SelectedRows.Count == 0)
			{
				MessageBox.Show("Hãy chọn tran dau!");
			}
			DataGridViewRow selectedRow = dgDanhSach.SelectedRows[0];
			string MaTranDau = selectedRow.Cells["MATRANDAU"].Value.ToString();
			if (MessageBox.Show("Xác Nhận Xóa Trận Đấu", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				TranDauService.DeleteTranDau(MaTranDau);
				Reset();
			}
		}

		private void Reset()
		{
			dgDanhSach.DataSource = TranDauService.RetrieveAllTranDau();
		}

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtSoBan.Text = "";
            txtTheDo.Text = "";
			cbDoiNha.Text = "";
            dgDanhSach.DataSource = TranDauService.RetrieveAllTranDau();
            dgDanhSach.Columns["MATRANDAU"].HeaderText = "Mã trận đấu";
            dgDanhSach.Columns["MADOINHA"].HeaderText = "Mã đội nhà";
            dgDanhSach.Columns["MADOIKHACH"].HeaderText = "Mã đội khách";
            dgDanhSach.Columns["LUOTDAU"].HeaderText = "Lượt đấu";
            dgDanhSach.Columns["VONGDAU"].HeaderText = "Vòng đấu";
            dgDanhSach.Columns["SOBANTHANGDOINHA"].HeaderText = "Bàn thắng đội nhà";
            dgDanhSach.Columns["SOBANTHANGDOIKHACH"].HeaderText = "Bàn thắng đội khách";
            dgDanhSach.Columns["SOTHEVANGDOINHA"].HeaderText = "Thẻ vàng đội nhà";
            dgDanhSach.Columns["SOTHEVANGDOIKHACH"].HeaderText = "Thẻ vàng đội khách";
            dgDanhSach.Columns["SOTHEDODOINHA"].HeaderText = "Thẻ đỏ đội nhà";
            dgDanhSach.Columns["SOTHEDODOIKHACH"].HeaderText = "Thẻ đỏ đội khách";
            dgDanhSach.Columns["GHICHU"].HeaderText = "Ghi chú";
        }

        private void btnUpdate_Click_2(object sender, EventArgs e)
        {
            if (dgDanhSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn tran dau!");
            }
            DataGridViewRow selectedRow = dgDanhSach.SelectedRows[0];
            string MaTranDau = selectedRow.Cells["MATRANDAU"].Value.ToString();
            UpdateTranDau updateTran = new UpdateTranDau(MaTranDau);
            updateTran.Show();
        }

        private void txtTheDo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoBan.Text, out int soBan))
            {
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên.");
            }
        }

        private void txtSoBan_TextChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoBan.Text, out int soBan))
            {
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên.");
            }
        }
    }
}
