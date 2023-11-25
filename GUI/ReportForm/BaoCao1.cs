using Microsoft.Reporting.WinForms;
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
using System.Data.SqlClient;


namespace GUI
{
	public partial class BaoCao1 : Form
	{
		private List<string> maDoi;
		public BaoCao1()
		{
			InitializeComponent();
		}

		public List<string> MaDoi { get => maDoi; set => maDoi = value; }

		private void BaoCao1cs_Load(object sender, EventArgs e)
		{
			try
			{
				this.reportViewer1.RefreshReport();
				reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportForm.Report1.rdlc";
				ReportDataSource rpd = new ReportDataSource();
				rpd.Name = "DataSet1";
				rpd.Value = CauThuService.GetMemBerOfListTeam(MaDoi);
				reportViewer1.LocalReport.DataSources.Add(rpd);
				this.reportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
            this.reportViewer1.RefreshReport();
        }
    }
}
