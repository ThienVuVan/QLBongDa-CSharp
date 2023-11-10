namespace GUI
{
	partial class Loading
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
			this.guna2CircleProgressBar2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
			this.lbDem = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.lbLoading = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.guna2CircleProgressBar2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2CircleProgressBar2
			// 
			this.guna2CircleProgressBar2.BackColor = System.Drawing.Color.Transparent;
			this.guna2CircleProgressBar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2CircleProgressBar2.BackgroundImage")));
			this.guna2CircleProgressBar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.guna2CircleProgressBar2.Controls.Add(this.lbDem);
			this.guna2CircleProgressBar2.Controls.Add(this.pictureBox9);
			this.guna2CircleProgressBar2.Controls.Add(this.lbLoading);
			this.guna2CircleProgressBar2.Controls.Add(this.pictureBox8);
			this.guna2CircleProgressBar2.Controls.Add(this.pictureBox5);
			this.guna2CircleProgressBar2.Controls.Add(this.pictureBox7);
			this.guna2CircleProgressBar2.Controls.Add(this.pictureBox3);
			this.guna2CircleProgressBar2.Controls.Add(this.pictureBox6);
			this.guna2CircleProgressBar2.Controls.Add(this.pictureBox4);
			this.guna2CircleProgressBar2.Controls.Add(this.pictureBox2);
			this.guna2CircleProgressBar2.Location = new System.Drawing.Point(-1, -536);
			this.guna2CircleProgressBar2.Name = "guna2CircleProgressBar2";
			this.guna2CircleProgressBar2.ProgressColor = System.Drawing.Color.Black;
			this.guna2CircleProgressBar2.ProgressColor2 = System.Drawing.Color.White;
			this.guna2CircleProgressBar2.ProgressThickness = 450;
			this.guna2CircleProgressBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleProgressBar2.ShadowDecoration.Parent = this.guna2CircleProgressBar2;
			this.guna2CircleProgressBar2.Size = new System.Drawing.Size(1844, 1800);
			this.guna2CircleProgressBar2.TabIndex = 0;
			this.guna2CircleProgressBar2.Value = 1;
			// 
			// lbDem
			// 
			this.lbDem.AutoSize = true;
			this.lbDem.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDem.Location = new System.Drawing.Point(703, 658);
			this.lbDem.Name = "lbDem";
			this.lbDem.Size = new System.Drawing.Size(79, 96);
			this.lbDem.TabIndex = 4;
			this.lbDem.Text = "0";
			this.lbDem.Click += new System.EventHandler(this.label2_Click);
			// 
			// pictureBox9
			// 
			this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
			this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox9.Location = new System.Drawing.Point(-44, 852);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(309, 296);
			this.pictureBox9.TabIndex = 3;
			this.pictureBox9.TabStop = false;
			// 
			// lbLoading
			// 
			this.lbLoading.AutoSize = true;
			this.lbLoading.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLoading.Location = new System.Drawing.Point(671, 762);
			this.lbLoading.Name = "lbLoading";
			this.lbLoading.Size = new System.Drawing.Size(128, 41);
			this.lbLoading.TabIndex = 2;
			this.lbLoading.Text = "Đang tải";
			// 
			// pictureBox8
			// 
			this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
			this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox8.Location = new System.Drawing.Point(146, 707);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(100, 100);
			this.pictureBox8.TabIndex = 1;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox5.Location = new System.Drawing.Point(389, 704);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(100, 100);
			this.pictureBox5.TabIndex = 1;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
			this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox7.Location = new System.Drawing.Point(506, 538);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(100, 100);
			this.pictureBox7.TabIndex = 1;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Location = new System.Drawing.Point(268, 588);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 100);
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
			this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox6.Location = new System.Drawing.Point(390, 974);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(100, 100);
			this.pictureBox6.TabIndex = 0;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox4.Location = new System.Drawing.Point(473, 843);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 100);
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Black;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(270, 841);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 100);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Loading
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 550);
			this.Controls.Add(this.guna2CircleProgressBar2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Loading";
			this.Text = "Loading";
			this.Load += new System.EventHandler(this.Loading_Load);
			this.guna2CircleProgressBar2.ResumeLayout(false);
			this.guna2CircleProgressBar2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label lbLoading;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label lbDem;
		private System.Windows.Forms.Timer timer1;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
		private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar2;
	}
}