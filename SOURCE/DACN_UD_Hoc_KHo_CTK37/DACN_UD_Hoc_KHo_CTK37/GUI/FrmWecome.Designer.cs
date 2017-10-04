using System.ComponentModel;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37
{
	partial class FrmWecome
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DACN_UD_Hoc_KHo_CTK37.WaitForm), true, true);
			
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWecome));
			this.picE = new DevExpress.XtraEditors.PictureEdit();
			
			((System.ComponentModel.ISupportInitialize)(this.picE.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// picE
			// 
			this.picE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			
			this.picE.Enabled = false;
			this.picE.Location = new System.Drawing.Point(0, 0);
			this.picE.Name = "picE";
			this.picE.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
			this.picE.Size = new System.Drawing.Size(675, 328);
			this.picE.TabIndex = 0;
			// 
			// FrmWecome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 328);
			this.ControlBox = false;
			this.Controls.Add(this.picE);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmWecome";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Ứng dụng học ngôn ngữ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.picE.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PictureEdit picE;}
}