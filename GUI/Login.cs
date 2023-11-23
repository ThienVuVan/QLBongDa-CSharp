using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class login : Form
    {

		private BackgroundWorker loginWorker;
		private Loading loading;
		public login()
        {
            InitializeComponent();
			loginWorker = new BackgroundWorker();
			loginWorker.DoWork += LoginWorker_DoWork;
			loginWorker.RunWorkerCompleted += LoginWorker_RunWorkerCompleted;

			
		}

       

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
			{
				MessageBox.Show("Vui lòng nhập mật khẩu.");
				return;
			}

			string pattern = @"^(?=.*[A-Za-z])(?=.*\d).{6,}$"; // Ít nhất 6 ký tự, bao gồm cả số và chữ
			if (!System.Text.RegularExpressions.Regex.IsMatch(txtMatKhau.Text, pattern))
			{
				MessageBox.Show("Mật khẩu không hợp lệ. Phải có ít nhất 6 ký tự và bao gồm cả số và chữ.");

				txtMatKhau.Text = "";
				return;
			}

			if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
			{
				return;
			}

			string patternn = @"^[a-zA-Z0-9_]{5,}$";
			if (!System.Text.RegularExpressions.Regex.IsMatch(txtTenDangNhap.Text, patternn))
			{
				MessageBox.Show("Tên đăng nhập không hợp lệ. Phải có ít nhất 5 kí tự và không chứa kí tự đặc biệt.");

				txtTenDangNhap.Text = ""; // Xóa giá trị không hợp lệ
				return;
			}

			//Hien thi form loading
			loading = new Loading();
			loading.Show();

            //Lay thong tin nguoi dung
            User user = new User();
            user.username = txtTenDangNhap.Text;
            user.password = txtMatKhau.Text;

			//thuc hien dang nhap
			loginWorker.RunWorkerAsync(user);

		}
		private void LoginWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			// Thực hiện công việc đăng nhập ở đây
			User user = e.Argument as User;

			// Simulate login process (Replace this with your actual login logic)
			Thread.Sleep(3000);

			// Kiểm tra đăng nhập thành công hay không
			bool loginSuccess = AuthService.CheckLogin(user);

			// Trả kết quả về cho sự kiện RunWorkerCompleted
			e.Result = loginSuccess;
		}

		private void LoginWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			// Ẩn form loading
			loading.Hide();

			// Kiểm tra kết quả đăng nhập
			if ((bool)e.Result)
			{
				// Nếu đăng nhập thành công, hiển thị MessageBox
				MessageBox.Show("Đăng nhập thành công");

				MainForm mainForm = new MainForm();
				this.Hide();
				mainForm.Show();
			}
			else
			{
				// Nếu đăng nhập không thành công, hiển thị MessageBox
				MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
			}
		}

		private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			// Xóa dữ liệu trong TextBox tên đăng nhập và mật khẩu
			txtTenDangNhap.Text = string.Empty;
			txtMatKhau.Text = string.Empty;
		}

		private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				btnDangNhap.PerformClick(); 
			}
		}

		private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				btnDangNhap.PerformClick();
			}
		}
	}
}
