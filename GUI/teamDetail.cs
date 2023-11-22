using BLL;
using DTO;
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
    public partial class teamDetail : Form
    {
        private string MaDoi;
        private DoiBong doiBong;
        public teamDetail(string MaDoiBong)
        {
            this.MaDoi = MaDoiBong;
            InitializeComponent();
        }

        private void teamDetail_Load(object sender, EventArgs e)
        {
            doiBong = DoiBongService.GetDoiBongById(MaDoi);
            txtTenDoi.Text = doiBong.TenDoi;
            txtMaTinh.Text = doiBong.MaTinh;
            txtHLV.Text = doiBong.HLV;
            txtSoCauThu.Text = doiBong.SoLuongCauThu.ToString();

            DataTable listCauThu = CauThuService.GetMemBerOfTeam(MaDoi);
            guna2DataGridView1.DataSource = listCauThu;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }
    }
}
