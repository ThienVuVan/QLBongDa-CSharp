using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Login : Form
    {
        User user = new User();
        UserBLL userBLL = new BLL.UserBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user.username = txtUserName.Text;
            user.password = txtPassWord.Text;
            string check = userBLL.CheckLogin(user);
            switch (check)
            {
                case "yeu cau username":
                    MessageBox.Show("username khong bo trong");
                    return;
                case "yeu cau password":
                    MessageBox.Show("password khong bo trong");
                    return;
                case "Tai khoan khong dung":
                    MessageBox.Show("tai khoan khong dung");
                    return;
            }
            MessageBox.Show("Login Success");
        }
    }
}
