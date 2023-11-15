namespace GUI
{
	partial class DanhSachTranDau
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachTranDau));
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnDangKy = new System.Windows.Forms.Button();
			this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
			this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtSoBanThang = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenDoiBong = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnFind = new Guna.UI2.WinForms.Guna2Button();
			this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
			this.guna2GroupBox1.Location = new System.Drawing.Point(12, 158);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
			this.guna2GroupBox1.Size = new System.Drawing.Size(999, 504);
			this.guna2GroupBox1.TabIndex = 1;
			this.guna2GroupBox1.Text = "Danh sách các trận đấu";
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapNhat.Location = new System.Drawing.Point(694, 603);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(180, 37);
			this.btnCapNhat.TabIndex = 2;
			this.btnCapNhat.Text = "Cập nhật kết quả";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			// 
			// btnDangKy
			// 
			this.btnDangKy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangKy.Location = new System.Drawing.Point(496, 603);
			this.btnDangKy.Name = "btnDangKy";
			this.btnDangKy.Size = new System.Drawing.Size(180, 37);
			this.btnDangKy.TabIndex = 2;
			this.btnDangKy.Text = "Đăng ký trận đấu";
			this.btnDangKy.UseVisualStyleBackColor = true;
			this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
			// 
			// btnFilter
			// 
			this.btnFilter.BorderRadius = 10;
			this.btnFilter.BorderThickness = 1;
			this.btnFilter.CheckedState.Parent = this.btnFilter;
			this.btnFilter.CustomImages.Parent = this.btnFilter;
			this.btnFilter.FillColor = System.Drawing.Color.White;
			this.btnFilter.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFilter.ForeColor = System.Drawing.Color.Black;
			this.btnFilter.HoverState.Parent = this.btnFilter;
			this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
			this.btnFilter.Location = new System.Drawing.Point(942, 104);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
			this.btnFilter.Size = new System.Drawing.Size(70, 32);
			this.btnFilter.TabIndex = 14;
			this.btnFilter.Text = "Lọc";
			// 
			// txtTen
			// 
			this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTen.DefaultText = "";
			this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTen.DisabledState.Parent = this.txtTen;
			this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTen.FocusedState.Parent = this.txtTen;
			this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTen.HoverState.Parent = this.txtTen;
			this.txtTen.Location = new System.Drawing.Point(139, 104);
			this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTen.Name = "txtTen";
			this.txtTen.PasswordChar = '\0';
			this.txtTen.PlaceholderText = "";
			this.txtTen.SelectedText = "";
			this.txtTen.ShadowDecoration.Parent = this.txtTen;
			this.txtTen.Size = new System.Drawing.Size(221, 32);
			this.txtTen.TabIndex = 11;
			// 
			// txtSoBanThang
			// 
			this.txtSoBanThang.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSoBanThang.DefaultText = "";
			this.txtSoBanThang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSoBanThang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSoBanThang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSoBanThang.DisabledState.Parent = this.txtSoBanThang;
			this.txtSoBanThang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSoBanThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSoBanThang.FocusedState.Parent = this.txtSoBanThang;
			this.txtSoBanThang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSoBanThang.HoverState.Parent = this.txtSoBanThang;
			this.txtSoBanThang.Location = new System.Drawing.Point(863, 104);
			this.txtSoBanThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSoBanThang.Name = "txtSoBanThang";
			this.txtSoBanThang.PasswordChar = '\0';
			this.txtSoBanThang.PlaceholderText = "";
			this.txtSoBanThang.SelectedText = "";
			this.txtSoBanThang.ShadowDecoration.Parent = this.txtSoBanThang;
			this.txtSoBanThang.Size = new System.Drawing.Size(57, 32);
			this.txtSoBanThang.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "Tên cầu thủ:";
			// 
			// txtTenDoiBong
			// 
			this.txtTenDoiBong.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTenDoiBong.DefaultText = "";
			this.txtTenDoiBong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTenDoiBong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTenDoiBong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenDoiBong.DisabledState.Parent = this.txtTenDoiBong;
			this.txtTenDoiBong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenDoiBong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenDoiBong.FocusedState.Parent = this.txtTenDoiBong;
			this.txtTenDoiBong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenDoiBong.HoverState.Parent = this.txtTenDoiBong;
			this.txtTenDoiBong.Location = new System.Drawing.Point(502, 104);
			this.txtTenDoiBong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTenDoiBong.Name = "txtTenDoiBong";
			this.txtTenDoiBong.PasswordChar = '\0';
			this.txtTenDoiBong.PlaceholderText = "";
			this.txtTenDoiBong.SelectedText = "";
			this.txtTenDoiBong.ShadowDecoration.Parent = this.txtTenDoiBong;
			this.txtTenDoiBong.Size = new System.Drawing.Size(227, 32);
			this.txtTenDoiBong.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(744, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 21);
			this.label5.TabIndex = 9;
			this.label5.Text = "Số bàn thắng:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(388, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 21);
			this.label4.TabIndex = 10;
			this.label4.Text = "Tên đội bóng:";
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.btnFind);
			this.guna2Panel1.Controls.Add(this.btnUpdate);
			this.guna2Panel1.Controls.Add(this.btnAdd);
			this.guna2Panel1.Controls.Add(this.comboBox1);
			this.guna2Panel1.Controls.Add(this.label2);
			this.guna2Panel1.Location = new System.Drawing.Point(1, 30);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(1022, 67);
			this.guna2Panel1.TabIndex = 7;
			// 
			// btnFind
			// 
			this.btnFind.CheckedState.Parent = this.btnFind;
			this.btnFind.CustomImages.Parent = this.btnFind;
			this.btnFind.FillColor = System.Drawing.Color.Transparent;
			this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnFind.ForeColor = System.Drawing.Color.White;
			this.btnFind.HoverState.Parent = this.btnFind;
			this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
			this.btnFind.ImageSize = new System.Drawing.Size(30, 30);
			this.btnFind.Location = new System.Drawing.Point(1156, 22);
			this.btnFind.Name = "btnFind";
			this.btnFind.ShadowDecoration.Parent = this.btnFind;
			this.btnFind.Size = new System.Drawing.Size(32, 34);
			this.btnFind.TabIndex = 8;
			// 
			// btnAdd
			// 
			this.btnAdd.BorderRadius = 15;
			this.btnAdd.BorderThickness = 1;
			this.btnAdd.CheckedState.Parent = this.btnAdd;
			this.btnAdd.CustomImages.Parent = this.btnAdd;
			this.btnAdd.FillColor = System.Drawing.Color.White;
			this.btnAdd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.Black;
			this.btnAdd.HoverState.BorderColor = System.Drawing.Color.Black;
			this.btnAdd.HoverState.Parent = this.btnAdd;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
			this.btnAdd.Location = new System.Drawing.Point(27, 6);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
			this.btnAdd.Size = new System.Drawing.Size(190, 52);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Đăng ký trận đấu";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "A - Z",
            "Z - A",
            "Số bàn thắng",
            "Số thẻ đỏ",
            "Số thẻ vàng"});
			this.comboBox1.Location = new System.Drawing.Point(846, 19);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(698, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Sắp xếp theo:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.BorderRadius = 15;
			this.btnUpdate.BorderThickness = 1;
			this.btnUpdate.CheckedState.Parent = this.btnUpdate;
			this.btnUpdate.CustomImages.Parent = this.btnUpdate;
			this.btnUpdate.FillColor = System.Drawing.Color.White;
			this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.Black;
			this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Black;
			this.btnUpdate.HoverState.Parent = this.btnUpdate;
			this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
			this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
			this.btnUpdate.Location = new System.Drawing.Point(248, 6);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
			this.btnUpdate.Size = new System.Drawing.Size(190, 52);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Cập nhật kết quả";
			// 
			// DanhSachTranDau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 652);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.txtSoBanThang);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTenDoiBong);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.btnDangKy);
			this.Controls.Add(this.btnCapNhat);
			this.Controls.Add(this.guna2GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DanhSachTranDau";
			this.Text = "Danh sách trận đấu";
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnDangKy;
		private Guna.UI2.WinForms.Guna2Button btnFilter;
		private Guna.UI2.WinForms.Guna2TextBox txtTen;
		private Guna.UI2.WinForms.Guna2TextBox txtSoBanThang;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txtTenDoiBong;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Button btnFind;
		private Guna.UI2.WinForms.Guna2Button btnAdd;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2Button btnUpdate;
	}
}