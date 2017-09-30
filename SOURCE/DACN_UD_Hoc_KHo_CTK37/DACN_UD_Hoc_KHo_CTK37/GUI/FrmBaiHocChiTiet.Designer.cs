using System.ComponentModel;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37
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
			DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DACN_UD_Hoc_KHo_CTK37.WaitForm), true, true);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaiHocChiTiet));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
			this.lbcMucLuc = new DevExpress.XtraEditors.ListBoxControl();
			this.lbDanhMuc = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.pnBaiHoc = new DevExpress.XtraEditors.PanelControl();
			this.picBox = new System.Windows.Forms.PictureBox();
			this.btnExe = new DevExpress.XtraEditors.SimpleButton();
			this.btnDictionary = new DevExpress.XtraEditors.SimpleButton();
			this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
			this.btnBack = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnNext = new DevExpress.XtraEditors.SimpleButton();
			this.lbLHViet = new DevExpress.XtraEditors.LabelControl();
			this.lbName = new DevExpress.XtraEditors.LabelControl();
			this.lbKhoHay = new DevExpress.XtraEditors.LabelControl();
			this.rkqBaiHoc = new DevExpress.XtraRichEdit.RichEditControl();
			this.lbViet = new DevExpress.XtraEditors.LabelControl();
			this.lbTenBai = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
			this.panelControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lbcMucLuc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnBaiHoc)).BeginInit();
			this.pnBaiHoc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.splitContainerControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1120, 449);
			this.panelControl1.TabIndex = 0;
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainerControl1.Location = new System.Drawing.Point(5, 5);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.panelControl3);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.AutoScroll = true;
			this.splitContainerControl1.Panel2.Controls.Add(this.pnBaiHoc);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(1110, 439);
			this.splitContainerControl1.SplitterPosition = 227;
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
			this.panelControl3.Location = new System.Drawing.Point(3, 4);
			this.panelControl3.Name = "panelControl3";
			this.panelControl3.Size = new System.Drawing.Size(223, 432);
			this.panelControl3.TabIndex = 1;
			// 
			// lbcMucLuc
			// 
			this.lbcMucLuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbcMucLuc.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbcMucLuc.Appearance.Options.UseFont = true;
			this.lbcMucLuc.Location = new System.Drawing.Point(5, 56);
			this.lbcMucLuc.Name = "lbcMucLuc";
			this.lbcMucLuc.Size = new System.Drawing.Size(213, 371);
			this.lbcMucLuc.TabIndex = 2;
			this.lbcMucLuc.Click += new System.EventHandler(this.lbcMucLuc_Click);
			// 
			// lbDanhMuc
			// 
			this.lbDanhMuc.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDanhMuc.Location = new System.Drawing.Point(5, 32);
			this.lbDanhMuc.Name = "lbDanhMuc";
			this.lbDanhMuc.Size = new System.Drawing.Size(0, 17);
			this.lbDanhMuc.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.pnBaiHoc.Controls.Add(this.picBox);
			this.pnBaiHoc.Controls.Add(this.btnExe);
			this.pnBaiHoc.Controls.Add(this.btnDictionary);
			this.pnBaiHoc.Controls.Add(this.btnRefresh);
			this.pnBaiHoc.Controls.Add(this.btnBack);
			this.pnBaiHoc.Controls.Add(this.btnClose);
			this.pnBaiHoc.Controls.Add(this.btnNext);
			this.pnBaiHoc.Controls.Add(this.lbLHViet);
			this.pnBaiHoc.Controls.Add(this.lbName);
			this.pnBaiHoc.Controls.Add(this.lbKhoHay);
			this.pnBaiHoc.Controls.Add(this.rkqBaiHoc);
			this.pnBaiHoc.Controls.Add(this.lbViet);
			this.pnBaiHoc.Controls.Add(this.lbTenBai);
			this.pnBaiHoc.Location = new System.Drawing.Point(0, 4);
			this.pnBaiHoc.Name = "pnBaiHoc";
			this.pnBaiHoc.Size = new System.Drawing.Size(871, 432);
			this.pnBaiHoc.TabIndex = 1;
			// 
			// picBox
			// 
			this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picBox.BackColor = System.Drawing.Color.Transparent;
			this.picBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.picBox.Location = new System.Drawing.Point(532, 56);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(334, 296);
			this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBox.TabIndex = 5;
			this.picBox.TabStop = false;
			// 
			// btnExe
			// 
			this.btnExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExe.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExe.Appearance.Options.UseFont = true;
			this.btnExe.Image = ((System.Drawing.Image)(resources.GetObject("btnExe.Image")));
			this.btnExe.Location = new System.Drawing.Point(260, 5);
			this.btnExe.Name = "btnExe";
			this.btnExe.Size = new System.Drawing.Size(103, 31);
			this.btnExe.TabIndex = 1;
			this.btnExe.Text = "Bài tập";
			this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
			// 
			// btnDictionary
			// 
			this.btnDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDictionary.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDictionary.Appearance.Options.UseFont = true;
			this.btnDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnDictionary.Image")));
			this.btnDictionary.Location = new System.Drawing.Point(369, 5);
			this.btnDictionary.Name = "btnDictionary";
			this.btnDictionary.Size = new System.Drawing.Size(103, 31);
			this.btnDictionary.TabIndex = 1;
			this.btnDictionary.Text = "Từ điển";
			this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefresh.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Appearance.Options.UseFont = true;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(478, 5);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(103, 31);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBack.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Appearance.Options.UseFont = true;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(587, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(103, 31);
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "Bài trước";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Appearance.Options.UseFont = true;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(791, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 31);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Appearance.Options.UseFont = true;
			this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
			this.btnNext.Location = new System.Drawing.Point(696, 5);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(89, 31);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Bài tiếp";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// lbLHViet
			// 
			this.lbLHViet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbLHViet.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLHViet.Location = new System.Drawing.Point(6, 404);
			this.lbLHViet.Name = "lbLHViet";
			this.lbLHViet.Size = new System.Drawing.Size(30, 17);
			this.lbLHViet.TabIndex = 4;
			this.lbLHViet.Text = "Viet";
			// 
			// lbName
			// 
			this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbName.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName.Location = new System.Drawing.Point(532, 358);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(31, 17);
			this.lbName.TabIndex = 4;
			this.lbName.Text = "Anh";
			// 
			// lbKhoHay
			// 
			this.lbKhoHay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbKhoHay.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbKhoHay.Location = new System.Drawing.Point(6, 381);
			this.lbKhoHay.Name = "lbKhoHay";
			this.lbKhoHay.Size = new System.Drawing.Size(34, 17);
			this.lbKhoHay.TabIndex = 4;
			this.lbKhoHay.Text = "KHo";
			// 
			// rkqBaiHoc
			// 
			this.rkqBaiHoc.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
			this.rkqBaiHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rkqBaiHoc.EnableToolTips = true;
			this.rkqBaiHoc.Location = new System.Drawing.Point(6, 56);
			this.rkqBaiHoc.Name = "rkqBaiHoc";
			this.rkqBaiHoc.Options.CopyPaste.MaintainDocumentSectionSettings = false;
			this.rkqBaiHoc.Options.Fields.UseCurrentCultureDateTimeFormat = false;
			this.rkqBaiHoc.Options.MailMerge.KeepLastParagraph = false;
			this.rkqBaiHoc.ReadOnly = true;
			this.rkqBaiHoc.Size = new System.Drawing.Size(520, 319);
			this.rkqBaiHoc.TabIndex = 0;
			// 
			// lbViet
			// 
			this.lbViet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbViet.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbViet.Location = new System.Drawing.Point(312, 35);
			this.lbViet.Name = "lbViet";
			this.lbViet.Size = new System.Drawing.Size(0, 15);
			this.lbViet.TabIndex = 0;
			// 
			// lbTenBai
			// 
			this.lbTenBai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTenBai.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTenBai.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
			this.lbTenBai.Location = new System.Drawing.Point(5, 5);
			this.lbTenBai.Name = "lbTenBai";
			this.lbTenBai.Size = new System.Drawing.Size(25, 17);
			this.lbTenBai.TabIndex = 0;
			this.lbTenBai.Text = "Bài";
			// 
			// FrmBaiHocChiTiet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1120, 449);
			this.Controls.Add(this.panelControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmBaiHocChiTiet";
			this.ShowInTaskbar = false;
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
			((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
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
		public DevExpress.XtraRichEdit.RichEditControl rkqBaiHoc;
		private LabelControl lbLHViet;
		private LabelControl lbKhoHay;
		private SimpleButton btnRefresh;
		private System.Windows.Forms.PictureBox picBox;
		private LabelControl lbName;
		private SimpleButton btnDictionary;
		private SimpleButton btnExe;
	}
}