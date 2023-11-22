namespace GUI
{
    partial class CauThuDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauThuDetail));
            this.btnImg = new System.Windows.Forms.Button();
            this.cbQuocTich = new System.Windows.Forms.ComboBox();
            this.cbMaDoi = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbViTri = new System.Windows.Forms.ComboBox();
            this.txtSoAo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbanThang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTheVang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTheDo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLanRaSan = new System.Windows.Forms.TextBox();
            this.openImg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(33, 161);
            this.btnImg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(99, 21);
            this.btnImg.TabIndex = 25;
            this.btnImg.Text = "Tải ảnh lên";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // cbQuocTich
            // 
            this.cbQuocTich.FormattingEnabled = true;
            this.cbQuocTich.Location = new System.Drawing.Point(255, 85);
            this.cbQuocTich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbQuocTich.Name = "cbQuocTich";
            this.cbQuocTich.Size = new System.Drawing.Size(92, 21);
            this.cbQuocTich.TabIndex = 24;
            // 
            // cbMaDoi
            // 
            this.cbMaDoi.FormattingEnabled = true;
            this.cbMaDoi.Location = new System.Drawing.Point(255, 53);
            this.cbMaDoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMaDoi.Name = "cbMaDoi";
            this.cbMaDoi.Size = new System.Drawing.Size(92, 21);
            this.cbMaDoi.TabIndex = 23;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(470, 311);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 36);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Hủy";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(255, 157);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(92, 20);
            this.dtpNgaySinh.TabIndex = 22;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(341, 311);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 36);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbViTri
            // 
            this.cbViTri.FormattingEnabled = true;
            this.cbViTri.Items.AddRange(new object[] {
            "GK",
            "CB",
            "FB",
            "CDM",
            "CM",
            "AM",
            "RW",
            "LW",
            "ST"});
            this.cbViTri.Location = new System.Drawing.Point(255, 118);
            this.cbViTri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbViTri.Name = "cbViTri";
            this.cbViTri.Size = new System.Drawing.Size(92, 21);
            this.cbViTri.TabIndex = 21;
            // 
            // txtSoAo
            // 
            this.txtSoAo.Location = new System.Drawing.Point(255, 190);
            this.txtSoAo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoAo.Name = "txtSoAo";
            this.txtSoAo.Size = new System.Drawing.Size(92, 20);
            this.txtSoAo.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(255, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 20);
            this.txtName.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(167, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số áo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(167, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(167, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Vị trí chơi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(167, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quốc tịch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(167, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã đội bóng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(167, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Họ và tên:";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox.BackgroundImage")));
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox.Location = new System.Drawing.Point(17, 29);
            this.picBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(125, 125);
            this.picBox.TabIndex = 10;
            this.picBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(393, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bàn Thắng";
            // 
            // txtbanThang
            // 
            this.txtbanThang.Enabled = false;
            this.txtbanThang.Location = new System.Drawing.Point(488, 52);
            this.txtbanThang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbanThang.Name = "txtbanThang";
            this.txtbanThang.Size = new System.Drawing.Size(92, 20);
            this.txtbanThang.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(393, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Thẻ Vàng";
            // 
            // txtTheVang
            // 
            this.txtTheVang.Enabled = false;
            this.txtTheVang.Location = new System.Drawing.Point(488, 90);
            this.txtTheVang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTheVang.Name = "txtTheVang";
            this.txtTheVang.Size = new System.Drawing.Size(92, 20);
            this.txtTheVang.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(393, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Thẻ Đỏ";
            // 
            // txtTheDo
            // 
            this.txtTheDo.Enabled = false;
            this.txtTheDo.Location = new System.Drawing.Point(488, 122);
            this.txtTheDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTheDo.Name = "txtTheDo";
            this.txtTheDo.Size = new System.Drawing.Size(92, 20);
            this.txtTheDo.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(393, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Lần ra sân";
            // 
            // txtLanRaSan
            // 
            this.txtLanRaSan.Enabled = false;
            this.txtLanRaSan.Location = new System.Drawing.Point(488, 157);
            this.txtLanRaSan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLanRaSan.Name = "txtLanRaSan";
            this.txtLanRaSan.Size = new System.Drawing.Size(92, 20);
            this.txtLanRaSan.TabIndex = 19;
            // 
            // openImg
            // 
            this.openImg.FileName = "openFileDialog1";
            // 
            // CauThuDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(608, 355);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.cbQuocTich);
            this.Controls.Add(this.cbMaDoi);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbViTri);
            this.Controls.Add(this.txtLanRaSan);
            this.Controls.Add(this.txtTheDo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTheVang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbanThang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoAo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CauThuDetail";
            this.Text = "CauThuDetail";
            this.Load += new System.EventHandler(this.CauThuDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.ComboBox cbQuocTich;
        private System.Windows.Forms.ComboBox cbMaDoi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbViTri;
        private System.Windows.Forms.TextBox txtSoAo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbanThang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTheVang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTheDo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLanRaSan;
        private System.Windows.Forms.OpenFileDialog openImg;
        private System.Windows.Forms.PictureBox picBox;
    }
}