using System.ComponentModel;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37
{
	partial class FrmInfo
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
			AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfo));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.animator1 = new AnimatorNS.Animator(this.components);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl6);
			this.panelControl1.Controls.Add(this.labelControl5);
			this.panelControl1.Controls.Add(this.labelControl4);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.animator1.SetDecoration(this.panelControl1, AnimatorNS.DecorationType.None);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(917, 312);
			this.panelControl1.TabIndex = 0;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.animator1.SetDecoration(this.labelControl2, AnimatorNS.DecorationType.BottomMirror);
			this.labelControl2.Location = new System.Drawing.Point(363, 39);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(304, 25);
			this.labelControl2.TabIndex = 0;
			this.labelControl2.Text = "ỨNG DỤNG HỌC TIẾNG K\'HO";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.animator1.SetDecoration(this.labelControl6, AnimatorNS.DecorationType.None);
			this.labelControl6.Location = new System.Drawing.Point(187, 219);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(330, 19);
			this.labelControl6.TabIndex = 0;
			this.labelControl6.Text = "Giáo viên hướng dẫn: TS. Đinh Viết Tuấn";
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.animator1.SetDecoration(this.labelControl5, AnimatorNS.DecorationType.None);
			this.labelControl5.Location = new System.Drawing.Point(230, 194);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(518, 19);
			this.labelControl5.TabIndex = 0;
			this.labelControl5.Text = "Nguyễn Bá Quốc Anh Quân - 1312656 - anhquannbq@gmail.com";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.animator1.SetDecoration(this.labelControl4, AnimatorNS.DecorationType.None);
			this.labelControl4.Location = new System.Drawing.Point(230, 169);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(435, 19);
			this.labelControl4.TabIndex = 0;
			this.labelControl4.Text = "Sang Khánh Vinh - 1312667 - khanhvinhit@gmail.com";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.animator1.SetDecoration(this.labelControl3, AnimatorNS.DecorationType.None);
			this.labelControl3.Location = new System.Drawing.Point(187, 144);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(161, 19);
			this.labelControl3.TabIndex = 0;
			this.labelControl3.Text = "Sinh viên thực hiện:";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.animator1.SetDecoration(this.labelControl1, AnimatorNS.DecorationType.None);
			this.labelControl1.Location = new System.Drawing.Point(187, 39);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(170, 19);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Đồ án chuyên ngành:";
			// 
			// animator1
			// 
			this.animator1.AnimationType = AnimatorNS.AnimationType.VertSlide;
			this.animator1.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(0);
			animation1.RotateCoeff = 0F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 0F;
			this.animator1.DefaultAnimation = animation1;
			// 
			// FrmInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(917, 312);
			this.ControlBox = false;
			this.Controls.Add(this.panelControl1);
			this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmInfo";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông tin tác giả";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private PanelControl panelControl1;
		private LabelControl labelControl1;
		private LabelControl labelControl2;
		private LabelControl labelControl6;
		private LabelControl labelControl5;
		private LabelControl labelControl4;
		private LabelControl labelControl3;
		private AnimatorNS.Animator animator1;
	}
}