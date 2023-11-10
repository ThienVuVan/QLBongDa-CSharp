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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
            Loading loading = new Loading();
            loading.Show();
		}
	}
}
