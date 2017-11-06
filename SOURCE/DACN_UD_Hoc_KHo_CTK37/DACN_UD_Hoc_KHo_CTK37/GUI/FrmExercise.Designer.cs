﻿using System.ComponentModel;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	partial class FrmExercise
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercise));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.btnGoiY = new DevExpress.XtraEditors.SimpleButton();
			this.btnPr = new DevExpress.XtraEditors.SimpleButton();
			this.txtTraLoi = new DevExpress.XtraEditors.TextEdit();
			this.btnRef = new DevExpress.XtraEditors.SimpleButton();
			this.btnNext = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.txtCount = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.lbGoiYcb = new System.Windows.Forms.Label();
			this.txtCauHoi = new System.Windows.Forms.Label();
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
			this.panelControl1.Size = new System.Drawing.Size(640, 181);
			this.panelControl1.TabIndex = 0;
			// 
			// panelControl2
			// 
			this.panelControl2.Controls.Add(this.txtCauHoi);
			this.panelControl2.Controls.Add(this.lbGoiYcb);
			this.panelControl2.Controls.Add(this.labelControl2);
			this.panelControl2.Controls.Add(this.btnGoiY);
			this.panelControl2.Controls.Add(this.btnPr);
			this.panelControl2.Controls.Add(this.txtTraLoi);
			this.panelControl2.Controls.Add(this.btnRef);
			this.panelControl2.Controls.Add(this.btnNext);
			this.panelControl2.Controls.Add(this.btnSave);
			this.panelControl2.Controls.Add(this.txtCount);
			this.panelControl2.Controls.Add(this.labelControl1);
			this.panelControl2.Location = new System.Drawing.Point(12, 12);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(614, 157);
			this.panelControl2.TabIndex = 6;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Location = new System.Drawing.Point(6, 93);
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
			this.btnGoiY.Enabled = false;
			this.btnGoiY.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiY.Image")));
			this.btnGoiY.Location = new System.Drawing.Point(127, 120);
			this.btnGoiY.Name = "btnGoiY";
			this.btnGoiY.Size = new System.Drawing.Size(116, 32);
			this.btnGoiY.TabIndex = 4;
			this.btnGoiY.Text = "Gợi ý";
			this.btnGoiY.Click += new System.EventHandler(this.btnGoiY_Click);
			// 
			// btnPr
			// 
			this.btnPr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPr.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPr.Appearance.Options.UseFont = true;
			this.btnPr.Image = ((System.Drawing.Image)(resources.GetObject("btnPr.Image")));
			this.btnPr.Location = new System.Drawing.Point(249, 120);
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
			this.txtTraLoi.Location = new System.Drawing.Point(97, 90);
			this.txtTraLoi.Name = "txtTraLoi";
			this.txtTraLoi.Properties.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTraLoi.Properties.Appearance.Options.UseFont = true;
			this.txtTraLoi.Size = new System.Drawing.Size(512, 24);
			this.txtTraLoi.TabIndex = 3;
			// 
			// btnRef
			// 
			this.btnRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRef.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRef.Appearance.Options.UseFont = true;
			this.btnRef.Image = ((System.Drawing.Image)(resources.GetObject("btnRef.Image")));
			this.btnRef.Location = new System.Drawing.Point(5, 120);
			this.btnRef.Name = "btnRef";
			this.btnRef.Size = new System.Drawing.Size(116, 32);
			this.btnRef.TabIndex = 4;
			this.btnRef.Text = "Làm lại";
			this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Appearance.Options.UseFont = true;
			this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
			this.btnNext.Location = new System.Drawing.Point(371, 120);
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
			this.btnSave.Location = new System.Drawing.Point(493, 120);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(116, 32);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Thoát";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtCount
			// 
			this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCount.Location = new System.Drawing.Point(585, 5);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(6, 13);
			this.txtCount.TabIndex = 1;
			this.txtCount.Text = "0";
			this.txtCount.ToolTip = "Số câu hỏi hiện tại / Tổng số câu hỏi";
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Location = new System.Drawing.Point(551, 5);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(28, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Tổng:";
			// 
			// lbGoiYcb
			// 
			this.lbGoiYcb.Font = new System.Drawing.Font("TNKeyUni-Arial", 9F);
			this.lbGoiYcb.Location = new System.Drawing.Point(97, 45);
			this.lbGoiYcb.Name = "lbGoiYcb";
			this.lbGoiYcb.Size = new System.Drawing.Size(512, 42);
			this.lbGoiYcb.TabIndex = 6;
			this.lbGoiYcb.Text = "goi y";
			// 
			// txtCauHoi
			// 
			this.txtCauHoi.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold);
			this.txtCauHoi.Location = new System.Drawing.Point(5, 5);
			this.txtCauHoi.Name = "txtCauHoi";
			this.txtCauHoi.Size = new System.Drawing.Size(540, 40);
			this.txtCauHoi.TabIndex = 7;
			this.txtCauHoi.Text = "CauHoi";
			// 
			// FrmExercise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(640, 181);
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

		private PanelControl panelControl1;
        private SimpleButton btnGoiY;
        private SimpleButton btnPr;
        private SimpleButton btnRef;
        private LabelControl labelControl1;
        private LabelControl txtCount;
		private SimpleButton btnNext;
        private SimpleButton btnSave;
        private LabelControl labelControl2;
        private TextEdit txtTraLoi;
		private PanelControl panelControl2;
		private System.Windows.Forms.Label lbGoiYcb;
		private System.Windows.Forms.Label txtCauHoi;
    }
}