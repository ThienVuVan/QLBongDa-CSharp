﻿namespace GUI
{
	partial class dangKyTranDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangKyTranDau));
            this.btnThem = new System.Windows.Forms.Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLuotDau = new System.Windows.Forms.TextBox();
            this.txtVongDau = new System.Windows.Forms.TextBox();
            this.cbNha = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbKhach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvDangKy = new System.Windows.Forms.DataGridView();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(328, 213);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 27);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cbStatus);
            this.guna2GroupBox1.Controls.Add(this.txtLuotDau);
            this.guna2GroupBox1.Controls.Add(this.txtVongDau);
            this.guna2GroupBox1.Controls.Add(this.btnThemMoi);
            this.guna2GroupBox1.Controls.Add(this.cbNha);
            this.guna2GroupBox1.Controls.Add(this.btnHuy);
            this.guna2GroupBox1.Controls.Add(this.btnThem);
            this.guna2GroupBox1.Controls.Add(this.cbKhach);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(10, 25);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(749, 257);
            this.guna2GroupBox1.TabIndex = 6;
            this.guna2GroupBox1.Text = "Thông tin trận đấu";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbStatus.FocusedState.Parent = this.cbStatus;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.HoverState.Parent = this.cbStatus;
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "On time",
            "Finished",
            "Not yet"});
            this.cbStatus.ItemsAppearance.Parent = this.cbStatus;
            this.cbStatus.Location = new System.Drawing.Point(328, 144);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.ShadowDecoration.Parent = this.cbStatus;
            this.cbStatus.Size = new System.Drawing.Size(106, 36);
            this.cbStatus.TabIndex = 5;
            // 
            // txtLuotDau
            // 
            this.txtLuotDau.Location = new System.Drawing.Point(336, 73);
            this.txtLuotDau.Margin = new System.Windows.Forms.Padding(2);
            this.txtLuotDau.Name = "txtLuotDau";
            this.txtLuotDau.Size = new System.Drawing.Size(76, 24);
            this.txtLuotDau.TabIndex = 2;
            this.txtLuotDau.TextChanged += new System.EventHandler(this.txtLuotDau_TextChanged_1);
            // 
            // txtVongDau
            // 
            this.txtVongDau.Location = new System.Drawing.Point(336, 46);
            this.txtVongDau.Margin = new System.Windows.Forms.Padding(2);
            this.txtVongDau.Name = "txtVongDau";
            this.txtVongDau.Size = new System.Drawing.Size(76, 24);
            this.txtVongDau.TabIndex = 2;
            this.txtVongDau.TextChanged += new System.EventHandler(this.txtVongDau_TextChanged_1);
            // 
            // cbNha
            // 
            this.cbNha.FormattingEnabled = true;
            this.cbNha.Location = new System.Drawing.Point(142, 104);
            this.cbNha.Margin = new System.Windows.Forms.Padding(2);
            this.cbNha.Name = "cbNha";
            this.cbNha.Size = new System.Drawing.Size(238, 25);
            this.cbNha.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(452, 213);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 27);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbKhach
            // 
            this.cbKhach.FormattingEnabled = true;
            this.cbKhach.Location = new System.Drawing.Point(471, 105);
            this.cbKhach.Margin = new System.Windows.Forms.Padding(2);
            this.cbKhach.Name = "cbKhach";
            this.cbKhach.Size = new System.Drawing.Size(243, 25);
            this.cbKhach.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vòng đấu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng Thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lượt đấu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đội khách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đội nhà:";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.dgvDangKy);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(10, 287);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(748, 232);
            this.guna2GroupBox2.TabIndex = 7;
            this.guna2GroupBox2.Text = "Kết quả đăng ký trận đấu:";
            // 
            // dgvDangKy
            // 
            this.dgvDangKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangKy.Location = new System.Drawing.Point(1, 41);
            this.dgvDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDangKy.Name = "dgvDangKy";
            this.dgvDangKy.RowHeadersWidth = 51;
            this.dgvDangKy.RowTemplate.Height = 24;
            this.dgvDangKy.Size = new System.Drawing.Size(745, 189);
            this.dgvDangKy.TabIndex = 0;
            this.dgvDangKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDangKy_CellContentClick);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(197, 213);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(106, 27);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm trận đấu";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(735, -3);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // dangKyTranDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 530);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dangKyTranDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký trận đấu";
            this.Load += new System.EventHandler(this.dangKyTranDau_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnThem;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private System.Windows.Forms.TextBox txtLuotDau;
		private System.Windows.Forms.TextBox txtVongDau;
		private System.Windows.Forms.ComboBox cbNha;
		private System.Windows.Forms.ComboBox cbKhach;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
		private System.Windows.Forms.DataGridView dgvDangKy;
		private System.Windows.Forms.Button btnThemMoi;
		private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}