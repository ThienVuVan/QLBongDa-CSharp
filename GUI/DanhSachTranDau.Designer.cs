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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachTranDau));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgDanhSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.txtTheDo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbDoiNha = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dgDanhSach);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(9, 128);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(821, 349);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Danh sách các trận đấu";
            // 
            // dgDanhSach
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDanhSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDanhSach.ColumnHeadersHeight = 55;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgDanhSach.EnableHeadersVisualStyles = false;
            this.dgDanhSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDanhSach.Location = new System.Drawing.Point(0, 41);
            this.dgDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgDanhSach.Name = "dgDanhSach";
            this.dgDanhSach.RowHeadersVisible = false;
            this.dgDanhSach.RowHeadersWidth = 51;
            this.dgDanhSach.RowTemplate.Height = 24;
            this.dgDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDanhSach.Size = new System.Drawing.Size(819, 306);
            this.dgDanhSach.TabIndex = 0;
            this.dgDanhSach.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgDanhSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgDanhSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgDanhSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgDanhSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgDanhSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgDanhSach.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgDanhSach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDanhSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgDanhSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgDanhSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDanhSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgDanhSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgDanhSach.ThemeStyle.HeaderStyle.Height = 55;
            this.dgDanhSach.ThemeStyle.ReadOnly = false;
            this.dgDanhSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgDanhSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDanhSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDanhSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgDanhSach.ThemeStyle.RowsStyle.Height = 24;
            this.dgDanhSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDanhSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnFilter.Location = new System.Drawing.Point(674, 88);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
            this.btnFilter.Size = new System.Drawing.Size(52, 26);
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtTheDo
            // 
            this.txtTheDo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTheDo.DefaultText = "";
            this.txtTheDo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTheDo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTheDo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTheDo.DisabledState.Parent = this.txtTheDo;
            this.txtTheDo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTheDo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTheDo.FocusedState.Parent = this.txtTheDo;
            this.txtTheDo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTheDo.HoverState.Parent = this.txtTheDo;
            this.txtTheDo.Location = new System.Drawing.Point(604, 88);
            this.txtTheDo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheDo.Name = "txtTheDo";
            this.txtTheDo.PasswordChar = '\0';
            this.txtTheDo.PlaceholderText = "";
            this.txtTheDo.SelectedText = "";
            this.txtTheDo.ShadowDecoration.Parent = this.txtTheDo;
            this.txtTheDo.Size = new System.Drawing.Size(53, 26);
            this.txtTheDo.TabIndex = 12;
            this.txtTheDo.TextChanged += new System.EventHandler(this.txtTheDo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên đội nhà:";
            // 
            // txtSoBan
            // 
            this.txtSoBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoBan.DefaultText = "";
            this.txtSoBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoBan.DisabledState.Parent = this.txtSoBan;
            this.txtSoBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoBan.FocusedState.Parent = this.txtSoBan;
            this.txtSoBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoBan.HoverState.Parent = this.txtSoBan;
            this.txtSoBan.Location = new System.Drawing.Point(434, 88);
            this.txtSoBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoBan.Name = "txtSoBan";
            this.txtSoBan.PasswordChar = '\0';
            this.txtSoBan.PlaceholderText = "";
            this.txtSoBan.SelectedText = "";
            this.txtSoBan.ShadowDecoration.Parent = this.txtSoBan;
            this.txtSoBan.Size = new System.Drawing.Size(79, 26);
            this.txtSoBan.TabIndex = 13;
            this.txtSoBan.TextChanged += new System.EventHandler(this.txtSoBan_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số thẻ đỏ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số bàn thắng:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnFind);
            this.guna2Panel1.Controls.Add(this.btnUpdate);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 24);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(830, 54);
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
            this.btnFind.Location = new System.Drawing.Point(867, 18);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(24, 28);
            this.btnFind.TabIndex = 8;
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
            this.btnUpdate.Location = new System.Drawing.Point(186, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(142, 42);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật kết quả";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_2);
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
            this.btnAdd.Location = new System.Drawing.Point(20, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(142, 42);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Đăng ký trận đấu";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(740, 86);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 29);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // cbDoiNha
            // 
            this.cbDoiNha.BackColor = System.Drawing.Color.Transparent;
            this.cbDoiNha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDoiNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoiNha.FocusedColor = System.Drawing.Color.Empty;
            this.cbDoiNha.FocusedState.Parent = this.cbDoiNha;
            this.cbDoiNha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDoiNha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDoiNha.FormattingEnabled = true;
            this.cbDoiNha.HoverState.Parent = this.cbDoiNha;
            this.cbDoiNha.ItemHeight = 30;
            this.cbDoiNha.ItemsAppearance.Parent = this.cbDoiNha;
            this.cbDoiNha.Location = new System.Drawing.Point(105, 84);
            this.cbDoiNha.Margin = new System.Windows.Forms.Padding(2);
            this.cbDoiNha.Name = "cbDoiNha";
            this.cbDoiNha.ShadowDecoration.Parent = this.cbDoiNha;
            this.cbDoiNha.Size = new System.Drawing.Size(225, 36);
            this.cbDoiNha.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(632, 481);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(717, 481);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(105, 28);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Xem Chi Tiết";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(548, 481);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(80, 28);
            this.btnXuatFile.TabIndex = 17;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // DanhSachTranDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 516);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbDoiNha);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtTheDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DanhSachTranDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách trận đấu";
            this.Load += new System.EventHandler(this.DanhSachTranDau_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private Guna.UI2.WinForms.Guna2Button btnFilter;
		private Guna.UI2.WinForms.Guna2TextBox txtTheDo;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txtSoBan;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Button btnFind;
		private Guna.UI2.WinForms.Guna2Button btnAdd;
		private Guna.UI2.WinForms.Guna2Button btnUpdate;
		private Guna.UI2.WinForms.Guna2ComboBox cbDoiNha;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCapNhat;
		private Guna.UI2.WinForms.Guna2DataGridView dgDanhSach;
		private System.Windows.Forms.Button btnXuatFile;
		private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button buttonUpdate;
    }
}