using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	partial class FrmBaiHocChiTiet
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
			DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DACN_UD_Hoc_KHo_CTK37.GUI.WaitForm), true, true);
			AnimatorNS.Animation animation10 = new AnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaiHocChiTiet));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
			this.lbcMucLuc = new DevExpress.XtraEditors.ListBoxControl();
			this.lbDanhMuc = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.pnBaiHoc = new DevExpress.XtraEditors.PanelControl();
			this.picChuDe = new System.Windows.Forms.PictureBox();
			this.btnAudio = new DevExpress.XtraEditors.SimpleButton();
			this.btnDictionary = new DevExpress.XtraEditors.SimpleButton();
			this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
			this.btnBack = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnNext = new DevExpress.XtraEditors.SimpleButton();
			this.lbLHViet = new DevExpress.XtraEditors.LabelControl();
			this.lbMucLuc = new DevExpress.XtraEditors.LabelControl();
			this.lbKhoHay = new DevExpress.XtraEditors.LabelControl();
			this.rkqBaiHoc = new DevExpress.XtraRichEdit.RichEditControl();
			this.lbViet = new DevExpress.XtraEditors.LabelControl();
			this.lbTenBai = new DevExpress.XtraEditors.LabelControl();
			this.picAnimator = new AnimatorNS.Animator(this.components);
			this.pnPic = new System.Windows.Forms.Panel();
			this.pnPicChude = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
			this.panelControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lbcMucLuc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnBaiHoc)).BeginInit();
			this.pnBaiHoc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picChuDe)).BeginInit();
			this.pnPic.SuspendLayout();
			this.pnPicChude.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.splitContainerControl1);
			this.picAnimator.SetDecoration(this.panelControl1, AnimatorNS.DecorationType.None);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1120, 526);
			this.panelControl1.TabIndex = 0;
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picAnimator.SetDecoration(this.splitContainerControl1, AnimatorNS.DecorationType.None);
			this.splitContainerControl1.Location = new System.Drawing.Point(5, 5);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.panelControl3);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.AutoScroll = true;
			this.splitContainerControl1.Panel2.Controls.Add(this.pnBaiHoc);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(1110, 516);
			this.splitContainerControl1.SplitterPosition = 214;
			this.splitContainerControl1.TabIndex = 0;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// panelControl3
			// 
			this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelControl3.Controls.Add(this.lbcMucLuc);
			this.panelControl3.Controls.Add(this.lbDanhMuc);
			this.panelControl3.Controls.Add(this.labelControl1);
			this.picAnimator.SetDecoration(this.panelControl3, AnimatorNS.DecorationType.None);
			this.panelControl3.Location = new System.Drawing.Point(3, 4);
			this.panelControl3.Name = "panelControl3";
			this.panelControl3.Size = new System.Drawing.Size(210, 509);
			this.panelControl3.TabIndex = 1;
			// 
			// lbcMucLuc
			// 
			this.lbcMucLuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbcMucLuc.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbcMucLuc.Appearance.Options.UseFont = true;
			this.lbcMucLuc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.picAnimator.SetDecoration(this.lbcMucLuc, AnimatorNS.DecorationType.None);
			this.lbcMucLuc.Location = new System.Drawing.Point(5, 56);
			this.lbcMucLuc.Name = "lbcMucLuc";
			this.lbcMucLuc.Size = new System.Drawing.Size(200, 448);
			this.lbcMucLuc.TabIndex = 2;
			this.lbcMucLuc.ToolTip = "Nhấp vào để xem";
			this.lbcMucLuc.Click += new System.EventHandler(this.lbcMucLuc_Click);
			// 
			// lbDanhMuc
			// 
			this.lbDanhMuc.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picAnimator.SetDecoration(this.lbDanhMuc, AnimatorNS.DecorationType.None);
			this.lbDanhMuc.Location = new System.Drawing.Point(5, 32);
			this.lbDanhMuc.Name = "lbDanhMuc";
			this.lbDanhMuc.Size = new System.Drawing.Size(0, 17);
			this.lbDanhMuc.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picAnimator.SetDecoration(this.labelControl1, AnimatorNS.DecorationType.None);
			this.labelControl1.Location = new System.Drawing.Point(5, 30);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(59, 17);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Mục lục";
			// 
			// pnBaiHoc
			// 
			this.pnBaiHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnBaiHoc.Appearance.BackColor = System.Drawing.Color.White;
			this.pnBaiHoc.Appearance.Options.UseBackColor = true;
			this.pnBaiHoc.Controls.Add(this.pnPicChude);
			this.pnBaiHoc.Controls.Add(this.pnPic);
			this.pnBaiHoc.Controls.Add(this.btnAudio);
			this.pnBaiHoc.Controls.Add(this.btnDictionary);
			this.pnBaiHoc.Controls.Add(this.btnRefresh);
			this.pnBaiHoc.Controls.Add(this.btnBack);
			this.pnBaiHoc.Controls.Add(this.btnClose);
			this.pnBaiHoc.Controls.Add(this.btnNext);
			this.pnBaiHoc.Controls.Add(this.lbLHViet);
			this.pnBaiHoc.Controls.Add(this.lbMucLuc);
			this.pnBaiHoc.Controls.Add(this.lbKhoHay);
			this.pnBaiHoc.Controls.Add(this.lbViet);
			this.pnBaiHoc.Controls.Add(this.lbTenBai);
			this.picAnimator.SetDecoration(this.pnBaiHoc, AnimatorNS.DecorationType.None);
			this.pnBaiHoc.Location = new System.Drawing.Point(0, 4);
			this.pnBaiHoc.Name = "pnBaiHoc";
			this.pnBaiHoc.Size = new System.Drawing.Size(884, 509);
			this.pnBaiHoc.TabIndex = 1;
			// 
			// picChuDe
			// 
			this.picAnimator.SetDecoration(this.picChuDe, AnimatorNS.DecorationType.None);
			this.picChuDe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picChuDe.Location = new System.Drawing.Point(0, 0);
			this.picChuDe.Name = "picChuDe";
			this.picChuDe.Size = new System.Drawing.Size(546, 374);
			this.picChuDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picChuDe.TabIndex = 7;
			this.picChuDe.TabStop = false;
			// 
			// btnAudio
			// 
			this.btnAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAudio.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAudio.Appearance.Options.UseFont = true;
			this.picAnimator.SetDecoration(this.btnAudio, AnimatorNS.DecorationType.None);
			this.btnAudio.Enabled = false;
			this.btnAudio.Image = ((System.Drawing.Image)(resources.GetObject("btnAudio.Image")));
			this.btnAudio.Location = new System.Drawing.Point(558, 138);
			this.btnAudio.Name = "btnAudio";
			this.btnAudio.Size = new System.Drawing.Size(103, 54);
			this.btnAudio.TabIndex = 6;
			this.btnAudio.Text = "Nghe";
			this.btnAudio.ToolTip = "Nhấn để nghe";
			this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
			// 
			// btnDictionary
			// 
			this.btnDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDictionary.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDictionary.Appearance.Options.UseFont = true;
			this.picAnimator.SetDecoration(this.btnDictionary, AnimatorNS.DecorationType.None);
			this.btnDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnDictionary.Image")));
			this.btnDictionary.Location = new System.Drawing.Point(667, 138);
			this.btnDictionary.Name = "btnDictionary";
			this.btnDictionary.Size = new System.Drawing.Size(103, 54);
			this.btnDictionary.TabIndex = 1;
			this.btnDictionary.Text = "Từ điển";
			this.btnDictionary.ToolTip = "Nhấn để tra từ điển";
			this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefresh.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Appearance.Options.UseFont = true;
			this.picAnimator.SetDecoration(this.btnRefresh, AnimatorNS.DecorationType.None);
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(558, 78);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(103, 54);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "Toàn bài";
			this.btnRefresh.ToolTip = "Nhấn để load lại bài học";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBack.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Appearance.Options.UseFont = true;
			this.picAnimator.SetDecoration(this.btnBack, AnimatorNS.DecorationType.None);
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(667, 78);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(103, 54);
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "Bài trước";
			this.btnBack.ToolTip = "Nhấn để quay về bài trước";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Appearance.Options.UseFont = true;
			this.picAnimator.SetDecoration(this.btnClose, AnimatorNS.DecorationType.None);
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(776, 138);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(103, 54);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Đóng";
			this.btnClose.ToolTip = "Nhấn để đóng bài học";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Appearance.Options.UseFont = true;
			this.picAnimator.SetDecoration(this.btnNext, AnimatorNS.DecorationType.None);
			this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
			this.btnNext.Location = new System.Drawing.Point(776, 78);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(103, 54);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Bài tiếp";
			this.btnNext.ToolTip = "Nhấn để sang bài tiếp theo";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// lbLHViet
			// 
			this.lbLHViet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbLHViet.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picAnimator.SetDecoration(this.lbLHViet, AnimatorNS.DecorationType.None);
			this.lbLHViet.Location = new System.Drawing.Point(6, 481);
			this.lbLHViet.Name = "lbLHViet";
			this.lbLHViet.Size = new System.Drawing.Size(30, 17);
			this.lbLHViet.TabIndex = 4;
			this.lbLHViet.Text = "Viet";
			// 
			// lbMucLuc
			// 
			this.lbMucLuc.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picAnimator.SetDecoration(this.lbMucLuc, AnimatorNS.DecorationType.None);
			this.lbMucLuc.Location = new System.Drawing.Point(6, 55);
			this.lbMucLuc.Name = "lbMucLuc";
			this.lbMucLuc.Size = new System.Drawing.Size(65, 17);
			this.lbMucLuc.TabIndex = 4;
			this.lbMucLuc.Text = "Muc Luc";
			// 
			// lbKhoHay
			// 
			this.lbKhoHay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbKhoHay.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picAnimator.SetDecoration(this.lbKhoHay, AnimatorNS.DecorationType.None);
			this.lbKhoHay.Location = new System.Drawing.Point(6, 458);
			this.lbKhoHay.Name = "lbKhoHay";
			this.lbKhoHay.Size = new System.Drawing.Size(34, 17);
			this.lbKhoHay.TabIndex = 4;
			this.lbKhoHay.Text = "KHo";
			// 
			// rkqBaiHoc
			// 
			this.rkqBaiHoc.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
			this.rkqBaiHoc.Appearance.Text.BackColor = System.Drawing.Color.Transparent;
			this.rkqBaiHoc.Appearance.Text.BackColor2 = System.Drawing.Color.Transparent;
			this.rkqBaiHoc.Appearance.Text.BorderColor = System.Drawing.Color.Transparent;
			this.rkqBaiHoc.Appearance.Text.Options.UseBackColor = true;
			this.rkqBaiHoc.Appearance.Text.Options.UseBorderColor = true;
			this.rkqBaiHoc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.picAnimator.SetDecoration(this.rkqBaiHoc, AnimatorNS.DecorationType.None);
			this.rkqBaiHoc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rkqBaiHoc.EnableToolTips = true;
			this.rkqBaiHoc.Location = new System.Drawing.Point(0, 0);
			this.rkqBaiHoc.Name = "rkqBaiHoc";
			this.rkqBaiHoc.Options.CopyPaste.MaintainDocumentSectionSettings = false;
			this.rkqBaiHoc.Options.Fields.UseCurrentCultureDateTimeFormat = false;
			this.rkqBaiHoc.Options.MailMerge.KeepLastParagraph = false;
			this.rkqBaiHoc.ReadOnly = true;
			this.rkqBaiHoc.Size = new System.Drawing.Size(546, 374);
			this.rkqBaiHoc.TabIndex = 0;
			// 
			// lbViet
			// 
			this.lbViet.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lbViet.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picAnimator.SetDecoration(this.lbViet, AnimatorNS.DecorationType.None);
			this.lbViet.Location = new System.Drawing.Point(399, 34);
			this.lbViet.Name = "lbViet";
			this.lbViet.Size = new System.Drawing.Size(7, 15);
			this.lbViet.TabIndex = 0;
			this.lbViet.Text = "0";
			// 
			// lbTenBai
			// 
			this.lbTenBai.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lbTenBai.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picAnimator.SetDecoration(this.lbTenBai, AnimatorNS.DecorationType.None);
			this.lbTenBai.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
			this.lbTenBai.Location = new System.Drawing.Point(300, 5);
			this.lbTenBai.Name = "lbTenBai";
			this.lbTenBai.Size = new System.Drawing.Size(25, 17);
			this.lbTenBai.TabIndex = 0;
			this.lbTenBai.Text = "Bài";
			// 
			// picAnimator
			// 
			this.picAnimator.AnimationType = AnimatorNS.AnimationType.HorizSlideAndRotate;
			this.picAnimator.Cursor = null;
			animation10.AnimateOnlyDifferences = true;
			animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
			animation10.LeafCoeff = 0F;
			animation10.MaxTime = 1F;
			animation10.MinTime = 0F;
			animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
			animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
			animation10.MosaicSize = 0;
			animation10.Padding = new System.Windows.Forms.Padding(50);
			animation10.RotateCoeff = 0.3F;
			animation10.RotateLimit = 0.2F;
			animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
			animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
			animation10.TimeCoeff = 0F;
			animation10.TransparencyCoeff = 0F;
			this.picAnimator.DefaultAnimation = animation10;
			// 
			// pnPic
			// 
			this.pnPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnPic.BackColor = System.Drawing.Color.Transparent;
			this.pnPic.Controls.Add(this.pictureBox1);
			this.picAnimator.SetDecoration(this.pnPic, AnimatorNS.DecorationType.None);
			this.pnPic.Location = new System.Drawing.Point(558, 199);
			this.pnPic.Name = "pnPic";
			this.pnPic.Size = new System.Drawing.Size(321, 253);
			this.pnPic.TabIndex = 8;
			// 
			// pnPicChude
			// 
			this.pnPicChude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnPicChude.Controls.Add(this.picChuDe);
			this.pnPicChude.Controls.Add(this.rkqBaiHoc);
			this.picAnimator.SetDecoration(this.pnPicChude, AnimatorNS.DecorationType.None);
			this.pnPicChude.Location = new System.Drawing.Point(6, 78);
			this.pnPicChude.Name = "pnPicChude";
			this.pnPicChude.Size = new System.Drawing.Size(546, 374);
			this.pnPicChude.TabIndex = 9;
			// 
			// pictureBox1
			// 
			this.picAnimator.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(321, 253);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// FrmBaiHocChiTiet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1120, 526);
			this.Controls.Add(this.panelControl1);
			this.picAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmBaiHocChiTiet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bài học";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBaiHocChiTiet_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
			this.panelControl3.ResumeLayout(false);
			this.panelControl3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lbcMucLuc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnBaiHoc)).EndInit();
			this.pnBaiHoc.ResumeLayout(false);
			this.pnBaiHoc.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picChuDe)).EndInit();
			this.pnPic.ResumeLayout(false);
			this.pnPicChude.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PanelControl panelControl1;
		private SplitContainerControl splitContainerControl1;
		private LabelControl labelControl1;
		private LabelControl lbTenBai;
		private LabelControl lbViet;
		private PanelControl panelControl3;
		private PanelControl pnBaiHoc;
		private SimpleButton btnClose;
		private SimpleButton btnBack;
		private SimpleButton btnNext;
		private LabelControl lbDanhMuc;
		private ListBoxControl lbcMucLuc;
		public RichEditControl rkqBaiHoc;
		private LabelControl lbLHViet;
		private LabelControl lbKhoHay;
		private SimpleButton btnRefresh;
		private SimpleButton btnAudio;
		private SimpleButton btnDictionary;
		private PictureBox picChuDe;
		private LabelControl lbMucLuc;
		private AnimatorNS.Animator picAnimator;
		private Panel pnPic;
		private Panel pnPicChude;
		private PictureBox pictureBox1;
    }
}