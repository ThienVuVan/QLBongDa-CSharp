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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                CauThuService.UpdateCauThu(updatedCauThu);
            }
            
        }
        private bool Validate()
        {
            if()
            return false;
               
        }
    }
}
