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

		private void dgDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

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
				MessageBox.Show($"{maTranDau}");
				DataTable dsIn = TranDauService.Filter(maTranDau, null, null, null);
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
					exSheet.get_Range("A7").Value = "Mã Trận Đấu";
					exSheet.get_Range("B7").Value = "Mã Đội Nhà";
					exSheet.get_Range("C7").Value = "Mã Đội Khách";
					exSheet.get_Range("D7").Value = "Lượt Đấu";
					exSheet.get_Range("E7").Value = "Vòng Đấu";
					exSheet.get_Range("F7").Value = "Số Bàn Thắng Đội Nhà";
					exSheet.get_Range("G7").Value = "Số Bàn Thắng Đội Khách";
					exSheet.get_Range("H7").Value = "Số Thẻ Vàng Đội Nhà";
					exSheet.get_Range("I7").Value = "Số Thẻ Vàng Đội Khách";
					exSheet.get_Range("J7").Value = "Số Thẻ Đỏ Đội Nhà";
					exSheet.get_Range("K7").Value = "Số Thẻ Đỏ Đội Khách";
					exSheet.get_Range("L7").Value = "Ghi Chú";
					//exSheet.get_Range("L7").Value = "Số Lần Ra Sân";
					for (int row = 0; row < dsIn.Rows.Count; row++)
					{
						exSheet.get_Range("A" + (row + 8).ToString()).Value = dsIn.Rows[row]["MATRANDAU"].ToString();
						exSheet.get_Range("B" + (row + 8).ToString()).Value = dsIn.Rows[row]["MADOINHA"].ToString();
						exSheet.get_Range("C" + (row + 8).ToString()).Value = dsIn.Rows[row]["MADOIKHACH"].ToString();
						exSheet.get_Range("D" + (row + 8).ToString()).Value = dsIn.Rows[row]["LUOTDAU"].ToString();
						exSheet.get_Range("E" + (row + 8).ToString()).Value = dsIn.Rows[row]["VONGDAU"].ToString();
						exSheet.get_Range("F" + (row + 8).ToString()).Value = dsIn.Rows[row]["SOBANTHANGDOINHA"].ToString();
						exSheet.get_Range("G" + (row + 8).ToString()).Value = dsIn.Rows[row]["SOBANTHANGDOIKHACH"].ToString();
						exSheet.get_Range("H" + (row + 8).ToString()).Value = dsIn.Rows[row]["SOBANTHANGDOINHA"].ToString();
						exSheet.get_Range("I" + (row + 8).ToString()).Value = dsIn.Rows[row]["SOBANTHANGDOIKHACH"].ToString();
						exSheet.get_Range("J" + (row + 8).ToString()).Value = dsIn.Rows[row]["SOTHEDODOINHA"].ToString();
						exSheet.get_Range("K" + (row + 8).ToString()).Value = dsIn.Rows[row]["SOTHEDODOIKHACH"].ToString();
						exSheet.get_Range("L" + (row + 8).ToString()).Value = dsIn.Rows[row]["GHICHU"].ToString();
					}
					exSheet.Name = "KetQuaTranDau";
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
	}
}
