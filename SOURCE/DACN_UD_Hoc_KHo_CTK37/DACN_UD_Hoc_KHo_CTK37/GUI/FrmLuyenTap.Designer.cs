using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	partial class FrmLuyenTap
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
			DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DACN_UD_Hoc_KHo_CTK37.GUI.WaitForm), true, true);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLuyenTap));
			this.lbCauHoi = new DevExpress.XtraEditors.LabelControl();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.lbSo = new DevExpress.XtraEditors.LabelControl();
			this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
			this.btnNext = new DevExpress.XtraEditors.SimpleButton();
			this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.recTraLoi = new DevExpress.XtraRichEdit.RichEditControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.lbCauh = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbCauHoi
			// 
			this.lbCauHoi.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCauHoi.Location = new System.Drawing.Point(5, 28);
			this.lbCauHoi.Name = "lbCauHoi";
			this.lbCauHoi.Size = new System.Drawing.Size(58, 17);
			this.lbCauHoi.TabIndex = 0;
			this.lbCauHoi.Text = "Câu hỏi:";
			// 
			// panelControl1
			// 
			this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.lbSo);
			this.panelControl1.Controls.Add(this.btnPrev);
			this.panelControl1.Controls.Add(this.btnNext);
			this.panelControl1.Controls.Add(this.btnRefresh);
			this.panelControl1.Controls.Add(this.btnThoat);
			this.panelControl1.Controls.Add(this.recTraLoi);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.lbCauh);
			this.panelControl1.Controls.Add(this.lbCauHoi);
			this.panelControl1.Location = new System.Drawing.Point(12, 12);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(739, 252);
			this.panelControl1.TabIndex = 1;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(665, 5);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(28, 13);
			this.labelControl2.TabIndex = 7;
			this.labelControl2.Text = "Tổng:";
			// 
			// lbSo
			// 
			this.lbSo.Location = new System.Drawing.Point(699, 5);
			this.lbSo.Name = "lbSo";
			this.lbSo.Size = new System.Drawing.Size(22, 13);
			this.lbSo.TabIndex = 6;
			this.lbSo.Text = "0 / 0";
			this.lbSo.ToolTip = "Số câu hỏi hiện tại / Tổng số câu hỏi";
			// 
			// btnPrev
			// 
			this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrev.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrev.Appearance.Options.UseFont = true;
			this.btnPrev.Enabled = false;
			this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
			this.btnPrev.Location = new System.Drawing.Point(425, 219);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(99, 28);
			this.btnPrev.TabIndex = 5;
			this.btnPrev.Text = "Câu trước";
			this.btnPrev.ToolTip = "Nhấn để quay lại câu trước";
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Appearance.Options.UseFont = true;
			this.btnNext.Enabled = false;
			this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
			this.btnNext.Location = new System.Drawing.Point(530, 219);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(99, 28);
			this.btnNext.TabIndex = 5;
			this.btnNext.Text = "Câu sau";
			this.btnNext.ToolTip = "Nhấn để sang câu tiếp theo";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefresh.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Appearance.Options.UseFont = true;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(320, 219);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(99, 28);
			this.btnRefresh.TabIndex = 5;
			this.btnRefresh.Text = "Làm lại";
			this.btnRefresh.ToolTip = "Nhấn để xóa tất cả câu trả lời có trong luyện tập";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Appearance.Options.UseFont = true;
			this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
			this.btnThoat.Location = new System.Drawing.Point(635, 219);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(99, 28);
			this.btnThoat.TabIndex = 5;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.ToolTip = "Thoát khỏi luyện tập";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// recTraLoi
			// 
			this.recTraLoi.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
			this.recTraLoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.recTraLoi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.recTraLoi.EnableToolTips = true;
			this.recTraLoi.Location = new System.Drawing.Point(5, 115);
			this.recTraLoi.Name = "recTraLoi";
			this.recTraLoi.Options.CopyPaste.MaintainDocumentSectionSettings = false;
			this.recTraLoi.Options.Fields.UseCurrentCultureDateTimeFormat = false;
			this.recTraLoi.Options.MailMerge.KeepLastParagraph = false;
			this.recTraLoi.Size = new System.Drawing.Size(729, 98);
			this.recTraLoi.TabIndex = 4;
			this.recTraLoi.Enter += new System.EventHandler(this.recTraLoi_Enter);
			this.recTraLoi.Leave += new System.EventHandler(this.recTraLoi_Leave);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Location = new System.Drawing.Point(5, 92);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(49, 17);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Trả lời:";
			// 
			// lbCauh
			// 
			this.lbCauh.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCauh.Location = new System.Drawing.Point(69, 28);
			this.lbCauh.Name = "lbCauh";
			this.lbCauh.Size = new System.Drawing.Size(9, 17);
			this.lbCauh.TabIndex = 0;
			this.lbCauh.Text = "0";
			// 
			// FrmLuyenTap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(763, 276);
			this.Controls.Add(this.panelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmLuyenTap";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Luyện tập";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private LabelControl lbCauHoi;
		private PanelControl panelControl1;
		private LabelControl labelControl1;
		private RichEditControl recTraLoi;
		private SimpleButton btnThoat;
		private SimpleButton btnRefresh;
        private LabelControl lbCauh;
        private SimpleButton btnPrev;
        private SimpleButton btnNext;
        private LabelControl lbSo;
        private LabelControl labelControl2;
    }
}