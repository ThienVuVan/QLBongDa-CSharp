namespace GUI
{
	partial class BaoCao1
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
			this.CAUTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			((System.ComponentModel.ISupportInitialize)(this.CAUTHUBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// CAUTHUBindingSource
			// 
			this.CAUTHUBindingSource.DataMember = "CAUTHU";
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer1.DocumentMapWidth = 34;
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1192, 585);
			this.reportViewer1.TabIndex = 0;
			// 
			// BaoCao1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 585);
			this.Controls.Add(this.reportViewer1);
			this.Name = "BaoCao1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BaoCao1cs";
			this.Load += new System.EventHandler(this.BaoCao1cs_Load);
			((System.ComponentModel.ISupportInitialize)(this.CAUTHUBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource CAUTHUBindingSource;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}