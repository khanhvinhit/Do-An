using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace DACN_UD_Hoc_KHo_CTK37
{
	partial class FrmUdHoc
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
			
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUdHoc));
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnLesson = new DevExpress.XtraBars.BarButtonItem();
			this.btnGammar = new DevExpress.XtraBars.BarButtonItem();
			this.rbSkin = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
			this.btnExit = new DevExpress.XtraBars.BarButtonItem();
			this.btnInfo = new DevExpress.XtraBars.BarButtonItem();
			this.btnHelper = new DevExpress.XtraBars.BarButtonItem();
			this.btnDictionary = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLesson,
            this.btnGammar,
            this.rbSkin,
            this.btnExit,
            this.btnInfo,
            this.btnHelper,
            this.btnDictionary});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
			this.ribbonControl1.MaxItemId = 1;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.PageHeaderItemLinks.Add(this.rbSkin);
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOfficeEx;
			this.ribbonControl1.Size = new System.Drawing.Size(972, 82);
			// 
			// btnLesson
			// 
			this.btnLesson.Caption = "Bài học";
			this.btnLesson.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLesson.Glyph")));
			this.btnLesson.Id = 2;
			this.btnLesson.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLesson.LargeGlyph")));
			this.btnLesson.Name = "btnLesson";
			this.btnLesson.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLesson_ItemClick);
			// 
			// btnGammar
			// 
			this.btnGammar.Caption = "Ngữ pháp";
			this.btnGammar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGammar.Glyph")));
			this.btnGammar.Id = 3;
			this.btnGammar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGammar.LargeGlyph")));
			this.btnGammar.Name = "btnGammar";
			this.btnGammar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGammar_ItemClick);
			// 
			// rbSkin
			// 
			this.rbSkin.Caption = "Giao diện";
			this.rbSkin.Id = 5;
			this.rbSkin.Name = "rbSkin";
			// 
			// btnExit
			// 
			this.btnExit.Caption = "Thoát";
			this.btnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExit.Glyph")));
			this.btnExit.Id = 1;
			this.btnExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExit.LargeGlyph")));
			this.btnExit.Name = "btnExit";
			this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
			// 
			// btnInfo
			// 
			this.btnInfo.Caption = "Thông tin tác giả";
			this.btnInfo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnInfo.Glyph")));
			this.btnInfo.Id = 2;
			this.btnInfo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnInfo.LargeGlyph")));
			this.btnInfo.Name = "btnInfo";
			this.btnInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInfo_ItemClick);
			// 
			// btnHelper
			// 
			this.btnHelper.Caption = "Hướng dẫn chương trình";
			this.btnHelper.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHelper.Glyph")));
			this.btnHelper.Id = 3;
			this.btnHelper.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHelper.LargeGlyph")));
			this.btnHelper.Name = "btnHelper";
			this.btnHelper.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHelper_ItemClick);
			// 
			// btnDictionary
			// 
			this.btnDictionary.Caption = "Từ điển";
			this.btnDictionary.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDictionary.Glyph")));
			this.btnDictionary.Id = 4;
			this.btnDictionary.Name = "btnDictionary";
			this.btnDictionary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDictionary_ItemClick);
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Chức năng";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.btnLesson);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnGammar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnDictionary);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnExit);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Chức năng chương trình";
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
			this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "Thông tin";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.btnInfo);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Thông tin chương trình";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.btnHelper);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "Hướng dẫn";
			// 
			// FrmUdHoc
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(972, 465);
			this.Controls.Add(this.ribbonControl1);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmUdHoc";
			this.Ribbon = this.ribbonControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ứng dụng học tiếng K\' Ho";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUdHoc_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RibbonControl ribbonControl1;
		private RibbonPage ribbonPage1;
		private RibbonPageGroup ribbonPageGroup1;
		private BarButtonItem btnLesson;
		private BarButtonItem btnGammar;
		private SkinRibbonGalleryBarItem rbSkin;
		private BarButtonItem btnExit;
		private BarButtonItem btnInfo;
		private BarButtonItem btnHelper;
		private RibbonPage ribbonPage2;
		private RibbonPageGroup ribbonPageGroup2;
		private RibbonPageGroup ribbonPageGroup3;
		private BarButtonItem btnDictionary;}
}