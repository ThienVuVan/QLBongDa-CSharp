﻿using BLL;
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

namespace GUI.ReportForm
{
	public partial class Excel3 : Form
	{
		public Excel3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataTable dsIn = CauThuService.FindThreeMaxGoal();
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
				tenBaoCao.Value = "Báo cáo top 3 Cau Thu";

				Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
				exSheet.get_Range("B5:G5").Merge(true);
				header.Font.Size = 13;
				header.Font.Bold = true;
				header.Font.Color = Color.Red;
				header.Value = "Top 3 Cau Thu ";

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
				exSheet.Name = "KetQuaTranDau";
				exBook.Activate();
				dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
				dlgSave.FilterIndex = 1;
				dlgSave.AddExtension = true;
				dlgSave.DefaultExt = ".xls";
				if (dlgSave.ShowDialog() == DialogResult.OK)
					exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
				MessageBox.Show("Xuất file thành công", "Thông báo");
				exApp.Quit();//Thoát khỏi ứng dụng
			}
			else
			{
				MessageBox.Show("Không có danh sách hàng để xuất ra file");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			BaoCao3 baoCao3 = new BaoCao3();
			this.Hide();
			baoCao3.ShowDialog();
			this.Close();
		}

		private void Excel3_Load(object sender, EventArgs e)
		{

		}
	}
}
