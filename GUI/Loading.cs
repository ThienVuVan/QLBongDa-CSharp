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
	public partial class Loading : Form
	{
		public Loading()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (guna2CircleProgressBar2.Value == 100)
			{
				timer1.Stop();
			}
			guna2CircleProgressBar2.Value += 1;
			lbDem.Text=(Convert.ToInt32(lbDem.Text)+1).ToString();
		}

		private void Loading_Load(object sender, EventArgs e)
		{
			guna2ShadowForm1.SetShadowForm(this);
			timer1.Start();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
