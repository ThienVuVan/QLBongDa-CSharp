using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CauThuDetail : Form
    {
        string maCauThu;

        public CauThuDetail(string ma)
        {
            InitializeComponent();
            this.maCauThu = ma;
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            openImg.ShowDialog();
            picBox.Image = Image.FromFile(openImg.FileName);
        }

        private void CauThuDetail_Load(object sender, EventArgs e)
        {
            CauThu cauThu = CauThuService.GetCauThu(maCauThu);
            txtName.Text = cauThu.Ten.ToString();
            cbMaDoi.Text = cauThu.MaDoi.ToString();
            cbQuocTich.Text = cauThu.MaQuocTinh.ToString();
            cbViTri.Text = cauThu.ViTriChoi.ToString();
            dtpNgaySinh.Text = cauThu.NgaySinh.ToString();
            txtSoAo.Text = cauThu.SoAo.ToString();
            txtbanThang.Text = cauThu.SoBanThang.ToString();
            txtTheDo.Text = cauThu.SoTheDo.ToString();
            txtTheVang.Text = cauThu.SoTheVang.ToString();
            txtLanRaSan.Text = cauThu.SoLanRaSan.ToString();
            picBox.Image = Image.FromFile(Path.Combine("../../Resources/IMGCauThu", cauThu.Anh));
            openImg.FileName = cauThu.Anh;
            List<String> list = DoiBongService.RetrieveAllIdDoiBong();
            foreach (String name in list)
            {
                cbMaDoi.Items.Add(name);
            }

            List<String> listQt = QuocTichService.RetrieveAllIdQuocTich();
            foreach (String qt in listQt)
            {
                cbQuocTich.Items.Add(qt);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (Validate())
            {
                if (MessageBox.Show("Bạn có muốn chỉnh sửa thông tin của cầu thủ không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CauThu updatedCauThu = new CauThu
                    {
                        MaCauThu = maCauThu,
                        Ten = txtName.Text,
                        MaDoi = cbMaDoi.Text,
                        MaQuocTinh = cbQuocTich.Text,
                        ViTriChoi = cbViTri.Text,
                        NgaySinh = DateTime.Parse(dtpNgaySinh.Text),
                        SoAo = int.Parse(txtSoAo.Text),
                        SoBanThang = int.Parse(txtbanThang.Text),
                        SoTheDo = int.Parse(txtTheDo.Text),
                        SoTheVang = int.Parse(txtTheVang.Text),
                        SoLanRaSan = int.Parse(txtLanRaSan.Text),
                        Anh = Path.GetFileName(openImg.FileName)
                    };
                    try
                    {
                        CauThuService.UpdateCauThu(updatedCauThu);
                        MessageBox.Show("Update Thành công");
                        this.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Update không thành công");
                    }

                }
            }
            else
            {
                MessageBox.Show("Dữ liệu chưa đủ");
            }

        }

        private bool Validate()
        {
            if (txtName.Text.Trim() == "" || txtSoAo.Text.Trim() == "" || cbMaDoi.Text.Trim() == "" || cbQuocTich.Text.Trim() == "" || cbViTri.Text.Trim() == "")
            {
                return false;
            }
            return true;

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập vào chữ cái a - z");
                e.Handled = true;
            }
        }

        private void txtSoAo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("chỉ được nhập vào số");
                e.Handled = true;
            }
        }
    }
}
