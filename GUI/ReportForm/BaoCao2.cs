using BLL;
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

namespace GUI.ReportForm
{
	public partial class BaoCao2 : Form
	{
		string matran;
		public BaoCao2()
		{
			InitializeComponent();
		}

		public string Matran { get => matran; set => matran = value; }

		private void BaoCao2_Load(object sender, EventArgs e)
		{

			try
			{
				this.reportViewer1.RefreshReport();
				reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportForm.Report2.rdlc";
				ReportDataSource rpd = new ReportDataSource();
				rpd.Name = "DataSet1";
				rpd.Value = TranDauService.Filter(matran, null, null, null);
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
