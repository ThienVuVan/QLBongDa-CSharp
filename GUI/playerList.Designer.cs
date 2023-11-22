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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnFind = new Guna.UI2.WinForms.Guna2Button();
			this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
			this.lbSoLuong = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.gridCauThu = new Guna.UI2.WinForms.Guna2DataGridView();
			this.ANHCAUTHU = new System.Windows.Forms.DataGridViewImageColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTenDoiBong = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSoBanThang = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
			this.btnTop3 = new System.Windows.Forms.Button();
			this.dlgSave = new System.Windows.Forms.SaveFileDialog();
			this.btnReset = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCauThu)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.btnReset);
			this.guna2Panel1.Controls.Add(this.btnFind);
			this.guna2Panel1.Controls.Add(this.btnAdd);
			this.guna2Panel1.Controls.Add(this.lbSoLuong);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Location = new System.Drawing.Point(0, 34);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(1296, 67);
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
			this.btnFind.Location = new System.Drawing.Point(1142, 17);
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
			// lbSoLuong
			// 
			this.lbSoLuong.AutoSize = true;
			this.lbSoLuong.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSoLuong.Location = new System.Drawing.Point(371, 14);
			this.lbSoLuong.Name = "lbSoLuong";
			this.lbSoLuong.Size = new System.Drawing.Size(26, 29);
			this.lbSoLuong.TabIndex = 1;
			this.lbSoLuong.Text = "0";
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
			this.txtTen.Location = new System.Drawing.Point(129, 113);
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
			this.label3.Location = new System.Drawing.Point(23, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên cầu thủ:";
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(875, 594);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(147, 46);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Chỉnh sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(1036, 594);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(95, 46);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// gridCauThu
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.gridCauThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.gridCauThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridCauThu.BackgroundColor = System.Drawing.Color.White;
			this.gridCauThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridCauThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gridCauThu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridCauThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.gridCauThu.ColumnHeadersHeight = 50;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridCauThu.DefaultCellStyle = dataGridViewCellStyle6;
			this.gridCauThu.EnableHeadersVisualStyles = false;
			this.gridCauThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gridCauThu.Location = new System.Drawing.Point(13, 165);
			this.gridCauThu.Name = "gridCauThu";
			this.gridCauThu.RowHeadersVisible = false;
			this.gridCauThu.RowHeadersWidth = 51;
			this.gridCauThu.RowTemplate.Height = 24;
			this.gridCauThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridCauThu.Size = new System.Drawing.Size(1283, 415);
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
			this.gridCauThu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gridCauThu.ThemeStyle.HeaderStyle.Height = 50;
			this.gridCauThu.ThemeStyle.ReadOnly = false;
			this.gridCauThu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.gridCauThu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gridCauThu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.gridCauThu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.gridCauThu.ThemeStyle.RowsStyle.Height = 24;
			this.gridCauThu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gridCauThu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.gridCauThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCauThu_CellContentClick);
			// 
			// ANHCAUTHU
			// 
			this.ANHCAUTHU.FillWeight = 150F;
			this.ANHCAUTHU.HeaderText = "ANHCAUTHU";
			this.ANHCAUTHU.MinimumWidth = 8;
			this.ANHCAUTHU.Name = "ANHCAUTHU";
			this.ANHCAUTHU.Width = 125;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(460, 121);
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
			this.txtTenDoiBong.Location = new System.Drawing.Point(583, 113);
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
			this.label5.Location = new System.Drawing.Point(910, 121);
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
			this.txtSoBanThang.Location = new System.Drawing.Point(1036, 113);
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
			this.btnFilter.Location = new System.Drawing.Point(1210, 113);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
			this.btnFilter.Size = new System.Drawing.Size(70, 34);
			this.btnFilter.TabIndex = 6;
			this.btnFilter.Text = "Lọc";
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// btnTop3
			// 
			this.btnTop3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTop3.Location = new System.Drawing.Point(27, 594);
			this.btnTop3.Name = "btnTop3";
			this.btnTop3.Size = new System.Drawing.Size(147, 46);
			this.btnTop3.TabIndex = 7;
			this.btnTop3.Text = "Top 3 Player";
			this.btnTop3.UseVisualStyleBackColor = true;
			this.btnTop3.Click += new System.EventHandler(this.btnTop3_Click);
			// 
			// btnReset
			// 
			this.btnReset.BorderRadius = 10;
			this.btnReset.BorderThickness = 1;
			this.btnReset.CheckedState.Parent = this.btnReset;
			this.btnReset.CustomImages.Parent = this.btnReset;
			this.btnReset.FillColor = System.Drawing.Color.White;
			this.btnReset.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.Color.Black;
			this.btnReset.HoverState.Parent = this.btnReset;
			this.btnReset.Location = new System.Drawing.Point(1200, 31);
			this.btnReset.Name = "btnReset";
			this.btnReset.ShadowDecoration.Parent = this.btnReset;
			this.btnReset.Size = new System.Drawing.Size(93, 33);
			this.btnReset.TabIndex = 9;
			this.btnReset.Text = "Làm mới";
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// playerList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1308, 652);
			this.Controls.Add(this.btnTop3);
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
		private System.Windows.Forms.DataGridViewImageColumn ANHCAUTHU;
		private System.Windows.Forms.Button btnTop3;
		private System.Windows.Forms.SaveFileDialog dlgSave;
		private Guna.UI2.WinForms.Guna2Button btnReset;
	}
}