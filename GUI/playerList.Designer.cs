namespace GUI
{
	partial class playerList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerList));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnFind = new Guna.UI2.WinForms.Guna2Button();
			this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbSoLuong = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.gridCauThu = new Guna.UI2.WinForms.Guna2DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTenDoiBong = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSoBanThang = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCauThu)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.btnFind);
			this.guna2Panel1.Controls.Add(this.btnAdd);
			this.guna2Panel1.Controls.Add(this.comboBox1);
			this.guna2Panel1.Controls.Add(this.label2);
			this.guna2Panel1.Controls.Add(this.lbSoLuong);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Location = new System.Drawing.Point(0, 34);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(1022, 67);
			this.guna2Panel1.TabIndex = 1;
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
			this.btnAdd.Size = new System.Drawing.Size(155, 52);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Thêm cầu thủ";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
			// lbSoLuong
			// 
			this.lbSoLuong.AutoSize = true;
			this.lbSoLuong.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSoLuong.Location = new System.Drawing.Point(371, 14);
			this.lbSoLuong.Name = "lbSoLuong";
			this.lbSoLuong.Size = new System.Drawing.Size(38, 29);
			this.lbSoLuong.TabIndex = 1;
			this.lbSoLuong.Text = "60";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(415, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "cầu thủ";
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
			this.txtTen.Location = new System.Drawing.Point(126, 108);
			this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTen.Name = "txtTen";
			this.txtTen.PasswordChar = '\0';
			this.txtTen.PlaceholderText = "";
			this.txtTen.SelectedText = "";
			this.txtTen.ShadowDecoration.Parent = this.txtTen;
			this.txtTen.Size = new System.Drawing.Size(221, 34);
			this.txtTen.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên cầu thủ:";
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(650, 586);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(147, 46);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Chỉnh sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(835, 586);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(95, 46);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// gridCauThu
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.gridCauThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridCauThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridCauThu.BackgroundColor = System.Drawing.Color.White;
			this.gridCauThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridCauThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gridCauThu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridCauThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridCauThu.ColumnHeadersHeight = 10;
			this.gridCauThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridCauThu.DefaultCellStyle = dataGridViewCellStyle3;
			this.gridCauThu.EnableHeadersVisualStyles = false;
			this.gridCauThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gridCauThu.Location = new System.Drawing.Point(13, 157);
			this.gridCauThu.Name = "gridCauThu";
			this.gridCauThu.RowHeadersVisible = false;
			this.gridCauThu.RowHeadersWidth = 51;
			this.gridCauThu.RowTemplate.Height = 24;
			this.gridCauThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridCauThu.Size = new System.Drawing.Size(999, 423);
			this.gridCauThu.TabIndex = 4;
			this.gridCauThu.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.gridCauThu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.gridCauThu.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.gridCauThu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.gridCauThu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.gridCauThu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.gridCauThu.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.gridCauThu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gridCauThu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.gridCauThu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridCauThu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.gridCauThu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.gridCauThu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridCauThu.ThemeStyle.HeaderStyle.Height = 10;
			this.gridCauThu.ThemeStyle.ReadOnly = false;
			this.gridCauThu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.gridCauThu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gridCauThu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.gridCauThu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.gridCauThu.ThemeStyle.RowsStyle.Height = 24;
			this.gridCauThu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gridCauThu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(354, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 21);
			this.label4.TabIndex = 4;
			this.label4.Text = "Tên đội bóng:";
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
			this.txtTenDoiBong.Location = new System.Drawing.Point(483, 108);
			this.txtTenDoiBong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTenDoiBong.Name = "txtTenDoiBong";
			this.txtTenDoiBong.PasswordChar = '\0';
			this.txtTenDoiBong.PlaceholderText = "";
			this.txtTenDoiBong.SelectedText = "";
			this.txtTenDoiBong.ShadowDecoration.Parent = this.txtTenDoiBong;
			this.txtTenDoiBong.Size = new System.Drawing.Size(227, 34);
			this.txtTenDoiBong.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(729, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 21);
			this.label5.TabIndex = 4;
			this.label5.Text = "Số bàn thắng:";
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
			this.txtSoBanThang.Location = new System.Drawing.Point(862, 108);
			this.txtSoBanThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSoBanThang.Name = "txtSoBanThang";
			this.txtSoBanThang.PasswordChar = '\0';
			this.txtSoBanThang.PlaceholderText = "";
			this.txtSoBanThang.SelectedText = "";
			this.txtSoBanThang.ShadowDecoration.Parent = this.txtSoBanThang;
			this.txtSoBanThang.Size = new System.Drawing.Size(57, 34);
			this.txtSoBanThang.TabIndex = 5;
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
			this.btnFilter.Location = new System.Drawing.Point(942, 108);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
			this.btnFilter.Size = new System.Drawing.Size(70, 34);
			this.btnFilter.TabIndex = 6;
			this.btnFilter.Text = "Lọc";
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// playerList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 652);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.gridCauThu);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.txtSoBanThang);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTenDoiBong);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.guna2Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "playerList";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách cầu thủ";
			this.Load += new System.EventHandler(this.playerList_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCauThu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbSoLuong;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txtTen;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private Guna.UI2.WinForms.Guna2DataGridView gridCauThu;
		private Guna.UI2.WinForms.Guna2Button btnFind;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox txtTenDoiBong;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2TextBox txtSoBanThang;
		private Guna.UI2.WinForms.Guna2Button btnFilter;
	}
}