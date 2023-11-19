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
    public partial class dangKyDoiBong : Form
    {
        public dangKyDoiBong()
        {
            InitializeComponent();
        }

		private void btnAddImg_Click(object sender, EventArgs e)
		{
            OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            ofd.FilterIndex = 1;
            ofd.Title = "Chọn ảnh";
			ofd.ShowDialog(this);
            
		}

		private void btnReset_Click(object sender, EventArgs e)
		{

		}

		private void btnFinish_Click(object sender, EventArgs e)
		{

		}
	}
}
