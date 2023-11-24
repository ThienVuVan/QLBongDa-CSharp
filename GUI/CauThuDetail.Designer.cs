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
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
			this.SuspendLayout();
			// 
			// btnImg
			// 
			this.btnImg.Location = new System.Drawing.Point(45, 215);
			this.btnImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnImg.Name = "btnImg";
			this.btnImg.Size = new System.Drawing.Size(132, 26);
			this.btnImg.TabIndex = 25;
			this.btnImg.Text = "Tải ảnh lên";
			this.btnImg.UseVisualStyleBackColor = true;
			this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
			// 
			// cbQuocTich
			// 
			this.cbQuocTich.FormattingEnabled = true;
			this.cbQuocTich.Location = new System.Drawing.Point(340, 122);
			this.cbQuocTich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbQuocTich.Name = "cbQuocTich";
			this.cbQuocTich.Size = new System.Drawing.Size(121, 24);
			this.cbQuocTich.TabIndex = 24;
			// 
			// cbMaDoi
			// 
			this.cbMaDoi.FormattingEnabled = true;
			this.cbMaDoi.Location = new System.Drawing.Point(340, 82);
			this.cbMaDoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbMaDoi.Name = "cbMaDoi";
			this.cbMaDoi.Size = new System.Drawing.Size(121, 24);
			this.cbMaDoi.TabIndex = 23;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgaySinh.Location = new System.Drawing.Point(340, 210);
			this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(121, 22);
			this.dtpNgaySinh.TabIndex = 22;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(636, 334);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(137, 35);
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
			this.cbViTri.Location = new System.Drawing.Point(340, 162);
			this.cbViTri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbViTri.Name = "cbViTri";
			this.cbViTri.Size = new System.Drawing.Size(121, 24);
			this.cbViTri.TabIndex = 21;
			// 
			// txtSoAo
			// 
			this.txtSoAo.Location = new System.Drawing.Point(340, 250);
			this.txtSoAo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSoAo.Name = "txtSoAo";
			this.txtSoAo.Size = new System.Drawing.Size(121, 22);
			this.txtSoAo.TabIndex = 19;
			this.txtSoAo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoAo_KeyPress);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(340, 34);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(317, 22);
			this.txtName.TabIndex = 20;
			this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(223, 255);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 21);
			this.label6.TabIndex = 13;
			this.label6.Text = "Số áo:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(223, 215);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 21);
			this.label5.TabIndex = 14;
			this.label5.Text = "Ngày sinh:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(223, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 21);
			this.label4.TabIndex = 15;
			this.label4.Text = "Vị trí chơi:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(223, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 21);
			this.label3.TabIndex = 16;
			this.label3.Text = "Quốc tịch:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(223, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 21);
			this.label2.TabIndex = 17;
			this.label2.Text = "Mã đội bóng:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(223, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 21);
			this.label1.TabIndex = 18;
			this.label1.Text = "Họ và tên:";
			// 
			// picBox
			// 
			this.picBox.BackColor = System.Drawing.Color.Transparent;
			this.picBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox.BackgroundImage")));
			this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picBox.Location = new System.Drawing.Point(24, 53);
			this.picBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(167, 154);
			this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBox.TabIndex = 10;
			this.picBox.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(525, 82);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 21);
			this.label7.TabIndex = 13;
			this.label7.Text = "Bàn Thắng";
			// 
			// txtbanThang
			// 
			this.txtbanThang.Enabled = false;
			this.txtbanThang.Location = new System.Drawing.Point(652, 81);
			this.txtbanThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtbanThang.Name = "txtbanThang";
			this.txtbanThang.Size = new System.Drawing.Size(121, 22);
			this.txtbanThang.TabIndex = 19;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(525, 127);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 21);
			this.label8.TabIndex = 13;
			this.label8.Text = "Thẻ Vàng";
			// 
			// txtTheVang
			// 
			this.txtTheVang.Enabled = false;
			this.txtTheVang.Location = new System.Drawing.Point(652, 127);
			this.txtTheVang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTheVang.Name = "txtTheVang";
			this.txtTheVang.Size = new System.Drawing.Size(121, 22);
			this.txtTheVang.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(525, 168);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 21);
			this.label9.TabIndex = 13;
			this.label9.Text = "Thẻ Đỏ";
			// 
			// txtTheDo
			// 
			this.txtTheDo.Enabled = false;
			this.txtTheDo.Location = new System.Drawing.Point(652, 167);
			this.txtTheDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTheDo.Name = "txtTheDo";
			this.txtTheDo.Size = new System.Drawing.Size(121, 22);
			this.txtTheDo.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(525, 211);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(91, 21);
			this.label10.TabIndex = 13;
			this.label10.Text = "Lần ra sân";
			// 
			// txtLanRaSan
			// 
			this.txtLanRaSan.Enabled = false;
			this.txtLanRaSan.Location = new System.Drawing.Point(652, 210);
			this.txtLanRaSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtLanRaSan.Name = "txtLanRaSan";
			this.txtLanRaSan.Size = new System.Drawing.Size(121, 22);
			this.txtLanRaSan.TabIndex = 19;
			// 
			// openImg
			// 
			this.openImg.FileName = "openFileDialog1";
			// 
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
			this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new System.Drawing.Point(699, 2);
			this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.Size = new System.Drawing.Size(40, 23);
			this.guna2ControlBox1.TabIndex = 26;
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
			this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox2.Location = new System.Drawing.Point(744, 2);
			this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.Size = new System.Drawing.Size(40, 23);
			this.guna2ControlBox2.TabIndex = 26;
			// 
			// CauThuDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(795, 388);
			this.Controls.Add(this.guna2ControlBox2);
			this.Controls.Add(this.guna2ControlBox1);
			this.Controls.Add(this.btnImg);
			this.Controls.Add(this.cbQuocTich);
			this.Controls.Add(this.cbMaDoi);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "CauThuDetail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}