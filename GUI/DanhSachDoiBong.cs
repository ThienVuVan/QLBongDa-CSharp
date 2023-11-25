using BLL;
using DTO;
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
			List<string> doinha = DoiBongService.RetrieveAllNameDoiBong();
			foreach (string doi in doinha)
			{
				cbTenDoiBong.Items.Add(doi);
			}

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
		private void btnXuatFile_Click(object sender, EventArgs e)
		{
			if (dgvDoiBong.SelectedRows.Count > 0)
			{
				List<string> MaDoi = new List<string>();
				for (int i = 0; i < dgvDoiBong.SelectedRows.Count; i++)
				{
					DataGridViewRow selectedRow = dgvDoiBong.SelectedRows[i];
					MaDoi.Add(selectedRow.Cells["MADOI"].Value.ToString());

				}
				Excel1 excel1 = new Excel1();
				excel1.MaDoi = MaDoi;
				excel1.ShowDialog();	
			}
		}

        private void btnViewDetail_Click_1(object sender, EventArgs e)
        {
            if (dgvDoiBong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn đội bóng!");
            }

            DataGridViewRow selectedRow = dgvDoiBong.SelectedRows[0];
            string MaDoi = selectedRow.Cells["MADOI"].Value.ToString();
            teamDetail detail = new teamDetail(MaDoi);
            detail.Show();
        }
		private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				MessageBox.Show("Kí tự nhập vào phải là số");
				e.Handled = true;
			}
		}
		private void guna2Button2_Click(object sender, EventArgs e)
        {
			if(txtDiem.Text != "")
			{
                if (!int.TryParse(txtDiem.Text, out int number))
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên.");
                    return;
                }
                if (number <= 0)
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên lớn hơn không.");
                    return;
                }
            }

			int? soDiem = null;
			string tenDoi = cbTenDoiBong.SelectedItem?.ToString();

			if (!string.IsNullOrWhiteSpace(txtDiem.Text) && int.TryParse(txtDiem.Text, out int diem))
			{
				soDiem = diem;
			}

			DataTable filteredData = DoiBongService.Filter(tenDoi, soDiem);

			if (filteredData.Rows.Count == 0)
			{
				dgvDoiBong.DataSource = null;
				MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			dgvDoiBong.DataSource = filteredData;


		}


        private void Reset()
        {
            dgvDoiBong.DataSource = DoiBongService.GetAllDoiBong();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
			dgvDoiBong.DataSource = DoiBongService.GetAllDoiBong();
			txtDiem.Text = "";
			cbTenDoiBong.SelectedIndex = -1;

		}

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDoiBong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn đội bóng!");
            }
            DataGridViewRow selectedRow = dgvDoiBong.SelectedRows[0];
            string MaDoi = selectedRow.Cells["MADOI"].Value.ToString();
            if (MessageBox.Show("Nếu xóa đội bóng này, tất cả cầu thủ của đội bóng cũng sẽ bị xóa", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DoiBongService.DeleteDoiBong(MaDoi);
                Reset();
            }
        }
    }
}
