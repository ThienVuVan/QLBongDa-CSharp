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
			gridCauThu.DataSource = CauThuService.Filter(cauThu);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			addPlayer addNewPlayer = new addPlayer();
			addNewPlayer.ShowDialog();
			
			MainForm mainForm = new MainForm();
			mainForm.Opacity = 0.5;
		}

		private void playerList_Load(object sender, EventArgs e)
		{
			gridCauThu.DataSource = CauThuService.RetrieveAllCauThu();
		}
	}
}
