namespace DACN_UD_Hoc_KHo_CTK37
{
	partial class FrmExercise
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
			DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DACN_UD_Hoc_KHo_CTK37.WaitForm), true, true);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercise));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.btnGoiY = new DevExpress.XtraEditors.SimpleButton();
			this.lbGoiy = new DevExpress.XtraEditors.LabelControl();
			this.btnPr = new DevExpress.XtraEditors.SimpleButton();
			this.txtTraLoi = new DevExpress.XtraEditors.TextEdit();
			this.btnRef = new DevExpress.XtraEditors.SimpleButton();
			this.txtCauHoi = new DevExpress.XtraEditors.LabelControl();
			this.btnNext = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.txtCount = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTraLoi.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.panelControl2);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(725, 145);
			this.panelControl1.TabIndex = 0;
			// 
			// panelControl2
			// 
			this.panelControl2.Controls.Add(this.labelControl2);
			this.panelControl2.Controls.Add(this.btnGoiY);
			this.panelControl2.Controls.Add(this.lbGoiy);
			this.panelControl2.Controls.Add(this.btnPr);
			this.panelControl2.Controls.Add(this.txtTraLoi);
			this.panelControl2.Controls.Add(this.btnRef);
			this.panelControl2.Controls.Add(this.txtCauHoi);
			this.panelControl2.Controls.Add(this.btnNext);
			this.panelControl2.Controls.Add(this.btnSave);
			this.panelControl2.Controls.Add(this.txtCount);
			this.panelControl2.Controls.Add(this.labelControl1);
			this.panelControl2.Location = new System.Drawing.Point(12, 12);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(703, 120);
			this.panelControl2.TabIndex = 6;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Location = new System.Drawing.Point(7, 53);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(84, 17);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Câu trả lời:";
			// 
			// btnGoiY
			// 
			this.btnGoiY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGoiY.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGoiY.Appearance.Options.UseFont = true;
			this.btnGoiY.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiY.Image")));
			this.btnGoiY.Location = new System.Drawing.Point(216, 83);
			this.btnGoiY.Name = "btnGoiY";
			this.btnGoiY.Size = new System.Drawing.Size(116, 32);
			this.btnGoiY.TabIndex = 4;
			this.btnGoiY.Text = "Gợi ý";
			this.btnGoiY.Click += new System.EventHandler(this.btnGoiY_Click);
			// 
			// lbGoiy
			// 
			this.lbGoiy.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGoiy.Location = new System.Drawing.Point(97, 29);
			this.lbGoiy.Name = "lbGoiy";
			this.lbGoiy.Size = new System.Drawing.Size(32, 17);
			this.lbGoiy.TabIndex = 5;
			this.lbGoiy.Text = "Goiy";
			// 
			// btnPr
			// 
			this.btnPr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPr.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPr.Appearance.Options.UseFont = true;
			this.btnPr.Image = ((System.Drawing.Image)(resources.GetObject("btnPr.Image")));
			this.btnPr.Location = new System.Drawing.Point(338, 83);
			this.btnPr.Name = "btnPr";
			this.btnPr.Size = new System.Drawing.Size(116, 32);
			this.btnPr.TabIndex = 4;
			this.btnPr.Text = "Câu trước";
			this.btnPr.Click += new System.EventHandler(this.btnPr_Click);
			// 
			// txtTraLoi
			// 
			this.txtTraLoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTraLoi.Location = new System.Drawing.Point(97, 50);
			this.txtTraLoi.Name = "txtTraLoi";
			this.txtTraLoi.Properties.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTraLoi.Properties.Appearance.Options.UseFont = true;
			this.txtTraLoi.Size = new System.Drawing.Size(601, 24);
			this.txtTraLoi.TabIndex = 3;
			// 
			// btnRef
			// 
			this.btnRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRef.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRef.Appearance.Options.UseFont = true;
			this.btnRef.Image = ((System.Drawing.Image)(resources.GetObject("btnRef.Image")));
			this.btnRef.Location = new System.Drawing.Point(94, 83);
			this.btnRef.Name = "btnRef";
			this.btnRef.Size = new System.Drawing.Size(116, 32);
			this.btnRef.TabIndex = 4;
			this.btnRef.Text = "Làm lại";
			this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
			// 
			// txtCauHoi
			// 
			this.txtCauHoi.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCauHoi.Location = new System.Drawing.Point(6, 5);
			this.txtCauHoi.Name = "txtCauHoi";
			this.txtCauHoi.Size = new System.Drawing.Size(59, 17);
			this.txtCauHoi.TabIndex = 2;
			this.txtCauHoi.Text = "Cau hoi";
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Appearance.Options.UseFont = true;
			this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
			this.btnNext.Location = new System.Drawing.Point(460, 83);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(116, 32);
			this.btnNext.TabIndex = 4;
			this.btnNext.Text = "Câu sau";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Appearance.Options.UseFont = true;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.Location = new System.Drawing.Point(582, 83);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(116, 32);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Thoát";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtCount
			// 
			this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCount.Location = new System.Drawing.Point(674, 5);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(6, 13);
			this.txtCount.TabIndex = 1;
			this.txtCount.Text = "0";
			this.txtCount.ToolTip = "Số câu hỏi hiện tại / Tổng số câu hỏi";
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Location = new System.Drawing.Point(640, 5);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(28, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Tổng:";
			// 
			// FrmExercise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(725, 145);
			this.Controls.Add(this.panelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmExercise";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bài Tập";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.panelControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTraLoi.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbGoiy;
        private DevExpress.XtraEditors.SimpleButton btnGoiY;
        private DevExpress.XtraEditors.SimpleButton btnPr;
        private DevExpress.XtraEditors.SimpleButton btnRef;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl txtCount;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.LabelControl txtCauHoi;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTraLoi;
		private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}