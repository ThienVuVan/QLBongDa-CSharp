namespace GUI
{
	partial class DanhSachDoiBong
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachDoiBong));
			this.dgvDoiBong = new Guna.UI2.WinForms.Guna2DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnFind = new Guna.UI2.WinForms.Guna2Button();
			this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
			this.txtTIm = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.cbTenDoiBong = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtDiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.btnXuatFile = new System.Windows.Forms.Button();
			this.dlgSave = new System.Windows.Forms.SaveFileDialog();
			this.btnViewDetail = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoiBong)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.guna2GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvDoiBong
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.dgvDoiBong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvDoiBong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDoiBong.BackgroundColor = System.Drawing.Color.White;
			this.dgvDoiBong.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDoiBong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvDoiBong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDoiBong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvDoiBong.ColumnHeadersHeight = 52;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDoiBong.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgvDoiBong.EnableHeadersVisualStyles = false;
			this.dgvDoiBong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDoiBong.Location = new System.Drawing.Point(0, 32);
			this.dgvDoiBong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvDoiBong.Name = "dgvDoiBong";
			this.dgvDoiBong.RowHeadersVisible = false;
			this.dgvDoiBong.RowHeadersWidth = 51;
			this.dgvDoiBong.RowTemplate.Height = 24;
			this.dgvDoiBong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDoiBong.Size = new System.Drawing.Size(750, 285);
			this.dgvDoiBong.TabIndex = 0;
			this.dgvDoiBong.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.dgvDoiBong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvDoiBong.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvDoiBong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvDoiBong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvDoiBong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvDoiBong.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvDoiBong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDoiBong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvDoiBong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvDoiBong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvDoiBong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvDoiBong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvDoiBong.ThemeStyle.HeaderStyle.Height = 52;
			this.dgvDoiBong.ThemeStyle.ReadOnly = false;
			this.dgvDoiBong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvDoiBong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvDoiBong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvDoiBong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.dgvDoiBong.ThemeStyle.RowsStyle.Height = 24;
			this.dgvDoiBong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDoiBong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(483, 474);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 30);
			this.button1.TabIndex = 3;
			this.button1.Text = "Chỉnh sửa ";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(620, 474);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 30);
			this.button2.TabIndex = 4;
			this.button2.Text = "Xoá";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.btnFind);
			this.guna2Panel1.Controls.Add(this.btnAdd);
			this.guna2Panel1.Controls.Add(this.txtTIm);
			this.guna2Panel1.Controls.Add(this.label3);
			this.guna2Panel1.Location = new System.Drawing.Point(9, 29);
			this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(1094, 65);
			this.guna2Panel1.TabIndex = 6;
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(958, 4);
			this.btnReset.Margin = new System.Windows.Forms.Padding(4);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(100, 33);
			this.btnReset.TabIndex = 9;
			this.btnReset.Text = "Làm Mới";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
			this.btnFind.Location = new System.Drawing.Point(544, 12);
			this.btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnFind.Name = "btnFind";
			this.btnFind.ShadowDecoration.Parent = this.btnFind;
			this.btnFind.Size = new System.Drawing.Size(24, 28);
			this.btnFind.TabIndex = 8;
			// 
			// btnAdd
			// 
			this.btnAdd.BorderRadius = 15;
			this.btnAdd.BorderThickness = 1;
			this.btnAdd.CheckedState.Parent = this.btnAdd;
			this.btnAdd.CustomImages.Parent = this.btnAdd;
			this.btnAdd.FillColor = System.Drawing.Color.White;
			this.btnAdd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.Black;
			this.btnAdd.HoverState.BorderColor = System.Drawing.Color.Black;
			this.btnAdd.HoverState.Parent = this.btnAdd;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
			this.btnAdd.Location = new System.Drawing.Point(11, 12);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
			this.btnAdd.Size = new System.Drawing.Size(130, 33);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Thêm Đội";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtTIm
			// 
			this.txtTIm.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTIm.DefaultText = "";
			this.txtTIm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTIm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTIm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTIm.DisabledState.Parent = this.txtTIm;
			this.txtTIm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTIm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTIm.FocusedState.Parent = this.txtTIm;
			this.txtTIm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTIm.HoverState.Parent = this.txtTIm;
			this.txtTIm.Location = new System.Drawing.Point(351, 12);
			this.txtTIm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTIm.Name = "txtTIm";
			this.txtTIm.PasswordChar = '\0';
			this.txtTIm.PlaceholderText = "";
			this.txtTIm.SelectedText = "";
			this.txtTIm.ShadowDecoration.Parent = this.txtTIm;
			this.txtTIm.Size = new System.Drawing.Size(188, 28);
			this.txtTIm.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(256, 17);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tìm kiếm:";
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.Controls.Add(this.btnReset);
			this.guna2Panel2.Controls.Add(this.cbTenDoiBong);
			this.guna2Panel2.Controls.Add(this.txtDiem);
			this.guna2Panel2.Controls.Add(this.label2);
			this.guna2Panel2.Controls.Add(this.label1);
			this.guna2Panel2.Controls.Add(this.guna2Button2);
			this.guna2Panel2.Location = new System.Drawing.Point(9, 87);
			this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			this.guna2Panel2.Size = new System.Drawing.Size(1095, 53);
			this.guna2Panel2.TabIndex = 7;
			// 
			// cbTenDoiBong
			// 
			this.cbTenDoiBong.BackColor = System.Drawing.Color.Transparent;
			this.cbTenDoiBong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbTenDoiBong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTenDoiBong.FocusedColor = System.Drawing.Color.Empty;
			this.cbTenDoiBong.FocusedState.Parent = this.cbTenDoiBong;
			this.cbTenDoiBong.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbTenDoiBong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbTenDoiBong.FormattingEnabled = true;
			this.cbTenDoiBong.HoverState.Parent = this.cbTenDoiBong;
			this.cbTenDoiBong.ItemHeight = 30;
			this.cbTenDoiBong.ItemsAppearance.Parent = this.cbTenDoiBong;
			this.cbTenDoiBong.Location = new System.Drawing.Point(134, 6);
			this.cbTenDoiBong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbTenDoiBong.Name = "cbTenDoiBong";
			this.cbTenDoiBong.ShadowDecoration.Parent = this.cbTenDoiBong;
			this.cbTenDoiBong.Size = new System.Drawing.Size(217, 36);
			this.cbTenDoiBong.TabIndex = 13;
			// 
			// txtDiem
			// 
			this.txtDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDiem.DefaultText = "";
			this.txtDiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDiem.DisabledState.Parent = this.txtDiem;
			this.txtDiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtDiem.FocusedState.Parent = this.txtDiem;
			this.txtDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtDiem.HoverState.Parent = this.txtDiem;
			this.txtDiem.Location = new System.Drawing.Point(474, 8);
			this.txtDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDiem.Name = "txtDiem";
			this.txtDiem.PasswordChar = '\0';
			this.txtDiem.PlaceholderText = "";
			this.txtDiem.SelectedText = "";
			this.txtDiem.ShadowDecoration.Parent = this.txtDiem;
			this.txtDiem.Size = new System.Drawing.Size(88, 28);
			this.txtDiem.TabIndex = 12;
			this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(416, 8);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Điểm:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Tên Đội Bóng:";
			// 
			// guna2Button2
			// 
			this.guna2Button2.BorderRadius = 15;
			this.guna2Button2.BorderThickness = 1;
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = System.Drawing.Color.White;
			this.guna2Button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2Button2.ForeColor = System.Drawing.Color.Black;
			this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.Black;
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
			this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
			this.guna2Button2.Location = new System.Drawing.Point(836, 4);
			this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new System.Drawing.Size(76, 33);
			this.guna2Button2.TabIndex = 9;
			this.guna2Button2.Text = "Lọc";
			this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Controls.Add(this.dgvDoiBong);
			this.guna2GroupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
			this.guna2GroupBox1.Location = new System.Drawing.Point(9, 135);
			this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
			this.guna2GroupBox1.Size = new System.Drawing.Size(1095, 394);
			this.guna2GroupBox1.TabIndex = 8;
			this.guna2GroupBox1.Text = "Danh sách đội bóng ";
			// 
			// btnXuatFile
			// 
			this.btnXuatFile.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXuatFile.Location = new System.Drawing.Point(360, 474);
			this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnXuatFile.Name = "btnXuatFile";
			this.btnXuatFile.Size = new System.Drawing.Size(104, 30);
			this.btnXuatFile.TabIndex = 9;
			this.btnXuatFile.Text = "Thống kê";
			this.btnXuatFile.UseVisualStyleBackColor = true;
			this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
			// 
			// btnViewDetail
			// 
			this.btnViewDetail.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewDetail.Location = new System.Drawing.Point(29, 474);
			this.btnViewDetail.Name = "btnViewDetail";
			this.btnViewDetail.Size = new System.Drawing.Size(85, 30);
			this.btnViewDetail.TabIndex = 10;
			this.btnViewDetail.Text = "Xem Chi Tiết";
			this.btnViewDetail.UseVisualStyleBackColor = true;
			this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click_1);
			// 
			// DanhSachDoiBong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1119, 635);
			this.Controls.Add(this.btnViewDetail);
			this.Controls.Add(this.btnXuatFile);
			this.Controls.Add(this.guna2GroupBox1);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "DanhSachDoiBong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DanhSachDoiBong";
			this.Load += new System.EventHandler(this.DanhSachDoiBong_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDoiBong)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			this.guna2GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DataGridView dgvDoiBong;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Button btnAdd;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox txtDiem;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private System.Windows.Forms.Button btnXuatFile;
		private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button btnReset;
		private Guna.UI2.WinForms.Guna2ComboBox cbTenDoiBong;
	}
}
