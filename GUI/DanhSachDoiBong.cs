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
				DataTable dsIn = CauThuService.GetMemBerOfListTeam(MaDoi);
				//MessageBox.Show($"{MaDoi}");
				if (dsIn.Rows.Count > 0)
				{
					// Khai báo và khởi tạo các đối tượng Excel
					Excel.Application exApp = new Excel.Application();
					Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
					Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

					//Định dạng chung
					Excel.Range tenBaoCao = (Excel.Range)exSheet.Cells[1, 1];
					tenBaoCao.Font.Size = 12;
					tenBaoCao.Font.Bold = true;
					tenBaoCao.Font.Color = Color.Blue;
					tenBaoCao.Value = "Báo cáo danh sách các cầu thủ của đội bóng";

					Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
					exSheet.get_Range("B5:G5").Merge(true);
					header.Font.Size = 13;
					header.Font.Bold = true;
					header.Font.Color = Color.Red;
					header.Value = "DANH SÁCH ";

					//Định dạng tiêu đề bảng
					exSheet.get_Range("A7:J7").Font.Bold = true;
					exSheet.get_Range("A7:J7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
					exSheet.get_Range("A7").Value = "Mã Cầu Thủ";
					exSheet.get_Range("B7").Value = "Mã Đội";
					exSheet.get_Range("C7").Value = "Mã Quốc Tịch ";
					exSheet.get_Range("D7").Value = "Tên";
					exSheet.get_Range("E7").Value = "Vị Trí Chơi";
					exSheet.get_Range("F7").Value = "Ngày Sinh";
					exSheet.get_Range("G7").Value = "Số Áo";
					exSheet.get_Range("H7").Value = "Số Bàn Thắng";
					exSheet.get_Range("I7").Value = "Số Thẻ Vàng";
					exSheet.get_Range("J7").Value = "Số Thẻ Đỏ";
					exSheet.get_Range("K7").Value = "Số Lần Ra Sân";
					//exSheet.get_Range("L7").Value = "Số Lần Ra Sân";
					for (int row = 0; row < dsIn.Rows.Count - 1; row++)
					{
						exSheet.get_Range("A" + (row + 8).ToString()).Value = dsIn.Rows[row]["MACAUTHU"].ToString();
						exSheet.get_Range("B" + (row + 8).ToString()).Value = dsIn.Rows[row]["MADOI"].ToString();
						exSheet.get_Range("C" + (row + 8).ToString()).Value = dsIn.Rows[row]["MAQUOCTICH"].ToString();
						exSheet.get_Range("D" + (row + 8).ToString()).Value = dsIn.Rows[row]["TEN"].ToString();
						exSheet.get_Range("E" + (row + 8).ToString()).Value = dsIn.Rows[row]["VITRICHOI"].ToString();
						exSheet.get_Range("F" + (row + 8).ToString()).Value = dsIn.Rows[row]["NGAYSINH"].ToString();
						exSheet.get_Range("G" + (row + 8).ToString()).Value = dsIn.Rows[row]["SOAO"].ToString();
						exSheet.get_Range("H" + (row + 8).ToString()).Value = dsIn.Rows[row]["SOBANTHANG"].ToString();
						exSheet.get_Range("I" + (row + 8).ToString()).Value = dsIn.Rows[row]["SOTHEVANG"].ToString();
						exSheet.get_Range("J" + (row + 8).ToString()).Value = dsIn.Rows[row]["SOTHEDO"].ToString();
						exSheet.get_Range("K" + (row + 8).ToString()).Value = dsIn.Rows[row]["SOLANRASAN"].ToString();
					}
					exSheet.Name = "DanhSach";
					exBook.Activate();
					dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
					dlgSave.FilterIndex = 1;
					dlgSave.AddExtension = true;
					dlgSave.DefaultExt = ".xls";
					if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
					MessageBox.Show("Xuất file thành công", "Thông báo");
					exApp.Quit();//Thoát khỏi ứng dụng
				}
				else
				{
					MessageBox.Show("Không có danh sách hàng để xuất ra file");
				}
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

        private void button2_Click(object sender, EventArgs e)
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

		
	}
}
