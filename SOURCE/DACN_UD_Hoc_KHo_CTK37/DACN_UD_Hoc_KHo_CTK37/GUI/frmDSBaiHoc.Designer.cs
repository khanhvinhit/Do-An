using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37
{
	partial class FrmDsBaiHoc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDsBaiHoc));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.flpBaiHoc = new System.Windows.Forms.FlowLayoutPanel();
			this.animator = new AnimatorNS.Animator(this.components);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.AllowTouchScroll = true;
			this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.flpBaiHoc);
			this.animator.SetDecoration(this.panelControl1, AnimatorNS.DecorationType.None);
			this.panelControl1.Location = new System.Drawing.Point(0, 1);
			this.panelControl1.LookAndFeel.SkinName = "Glass Oceans";
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(932, 468);
			this.panelControl1.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.animator.SetDecoration(this.labelControl1, AnimatorNS.DecorationType.BottomMirror);
			this.labelControl1.Location = new System.Drawing.Point(595, 5);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(177, 19);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Danh sách các bài học";
			// 
			// flpBaiHoc
			// 
			this.flpBaiHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flpBaiHoc.AutoScroll = true;
			this.animator.SetDecoration(this.flpBaiHoc, AnimatorNS.DecorationType.None);
			this.flpBaiHoc.Location = new System.Drawing.Point(48, 46);
			this.flpBaiHoc.Name = "flpBaiHoc";
			this.flpBaiHoc.Size = new System.Drawing.Size(848, 412);
			this.flpBaiHoc.TabIndex = 0;
			// 
			// animator
			// 
			this.animator.AnimationType = AnimatorNS.AnimationType.Transparent;
			this.animator.Cursor = null;
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
			animation1.TransparencyCoeff = 1F;
			this.animator.DefaultAnimation = animation1;
			// 
			// FrmDsBaiHoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 469);
			this.ControlBox = false;
			this.Controls.Add(this.panelControl1);
			this.animator.SetDecoration(this, AnimatorNS.DecorationType.None);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmDsBaiHoc";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách bài học";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private PanelControl panelControl1;
		private FlowLayoutPanel flpBaiHoc;
        private LabelControl labelControl1;
		private AnimatorNS.Animator animator;

	}
}