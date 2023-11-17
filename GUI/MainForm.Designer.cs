namespace GUI
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.slidebar = new System.Windows.Forms.FlowLayoutPanel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.formspanel = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.slidebar.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button2);
			this.panel3.Location = new System.Drawing.Point(3, 239);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(267, 56);
			this.panel3.TabIndex = 2;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.button6);
			this.panel7.Location = new System.Drawing.Point(3, 419);
			this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(267, 56);
			this.panel7.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.button4);
			this.panel5.Location = new System.Drawing.Point(3, 359);
			this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(267, 56);
			this.panel5.TabIndex = 4;
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Transparent;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(-12, -9);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.button4.Size = new System.Drawing.Size(284, 70);
			this.button4.TabIndex = 1;
			this.button4.Text = "          Cầu thủ";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.button5);
			this.panel6.Location = new System.Drawing.Point(3, 299);
			this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(267, 56);
			this.panel6.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button1);
			this.panel2.Location = new System.Drawing.Point(3, 119);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(267, 56);
			this.panel2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(3, 2);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(267, 113);
			this.panel1.TabIndex = 0;
			// 
			// slidebar
			// 
			this.slidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.slidebar.Controls.Add(this.panel1);
			this.slidebar.Controls.Add(this.panel2);
			this.slidebar.Controls.Add(this.panel10);
			this.slidebar.Controls.Add(this.panel3);
			this.slidebar.Controls.Add(this.panel6);
			this.slidebar.Controls.Add(this.panel5);
			this.slidebar.Controls.Add(this.panel7);
			this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.slidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.slidebar.Location = new System.Drawing.Point(0, 0);
			this.slidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.slidebar.MaximumSize = new System.Drawing.Size(233, 0);
			this.slidebar.MinimumSize = new System.Drawing.Size(75, 0);
			this.slidebar.Name = "slidebar";
			this.slidebar.Size = new System.Drawing.Size(233, 652);
			this.slidebar.TabIndex = 0;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.button8);
			this.panel10.Location = new System.Drawing.Point(3, 179);
			this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(267, 56);
			this.panel10.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 40);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(42, 41);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(-12, -9);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.button1.Size = new System.Drawing.Size(284, 70);
			this.button1.TabIndex = 1;
			this.button1.Text = "          Trang chủ";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button8
			// 
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.White;
			this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
			this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.Location = new System.Drawing.Point(-12, -9);
			this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button8.Name = "button8";
			this.button8.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.button8.Size = new System.Drawing.Size(284, 70);
			this.button8.TabIndex = 1;
			this.button8.Text = "          Giải đấu";
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.UseVisualStyleBackColor = true;
			// 
			// formspanel
			// 
			this.formspanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formspanel.Location = new System.Drawing.Point(233, 0);
			this.formspanel.Name = "formspanel";
			this.formspanel.Size = new System.Drawing.Size(1024, 652);
			this.formspanel.TabIndex = 1;
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(-12, -9);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(284, 70);
			this.button2.TabIndex = 1;
			this.button2.Text = "          Trận đấu";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.Location = new System.Drawing.Point(-12, -9);
			this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button5.Name = "button5";
			this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.button5.Size = new System.Drawing.Size(284, 70);
			this.button5.TabIndex = 1;
			this.button5.Text = "          Đội bóng";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Transparent;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(-12, -9);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.button4.Size = new System.Drawing.Size(284, 70);
			this.button4.TabIndex = 1;
			this.button4.Text = "          Cầu thủ";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.Location = new System.Drawing.Point(-12, -9);
			this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button6.Name = "button6";
			this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.button6.Size = new System.Drawing.Size(284, 70);
			this.button6.TabIndex = 1;
			this.button6.Text = "          Cài đặt";
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1257, 652);
			this.Controls.Add(this.slidebar);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý đội bóng";
			this.Load += new System.EventHandler(this.Test_Load);
			this.panel3.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.slidebar.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.FlowLayoutPanel slidebar;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Panel formspanel;
	}
}
