﻿using System;
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
	public partial class DanhSachTranDau : Form
	{
		public DanhSachTranDau()
		{
			InitializeComponent();
		}

		private void btnDangKy_Click(object sender, EventArgs e)
		{
			dangKyTranDau dangKyTranDau = new dangKyTranDau();
			dangKyTranDau.ShowDialog();
		}
	}
}
