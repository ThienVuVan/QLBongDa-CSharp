using Guna.UI2.WinForms.Suite;
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
   
    public partial class MainForm : Form
    {
        bool slidebarExpand;
        public MainForm()
        {
            InitializeComponent();
		}

        private void Test_Load(object sender, EventArgs e)
        {
			OpenForm<HomePage>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
            if (slidebarExpand)
            {
                // if slidebar is expand, minimize
                slidebar.Width -= 8;
                if (slidebar.Width == slidebar.MinimumSize.Width)
                {
                    slidebarExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
       

                slidebar.Width += 8;
                if (slidebar.Width == slidebar.MaximumSize.Width )
                {
                    slidebarExpand = true;
                    timer1.Stop();
                }
            }
        }
        //show other form in panel MainForm
		public void OpenForm<MyForm>() where MyForm : Form, new()
		{
			
			Form form = panelform.Controls.OfType<MyForm>().FirstOrDefault();
			if (form == null)
			{
				form = new MyForm();
				form.TopLevel = false;
				form.FormBorderStyle = FormBorderStyle.None;
				form.Dock = DockStyle.Fill;
				panelform.Controls.Add(form);
				panelform.Tag = form;
				form.Show();
				form.BringToFront();
			}
			else
			{
				// Nếu form đã tồn tại, tạo một instance mới của MyForm
				MyForm newForm = new MyForm();
				newForm.TopLevel = false;
				newForm.FormBorderStyle = FormBorderStyle.None;
				newForm.Dock = DockStyle.Fill;
				panelform.Controls.Add(newForm);
				panelform.Tag = newForm;
				newForm.Show();
				newForm.BringToFront();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
            OpenForm<playerList>();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			OpenForm<DanhSachDoiBong>();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenForm<DanhSachTranDau>();
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		// để hiển thị form bên trong panel của MainForm dùng OpenForm
		// Hiển thị nổi Form.Show()



	}
}
