using System.ComponentModel;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	partial class WaitForm
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
			this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// marqueeProgressBarControl1
			// 
			this.marqueeProgressBarControl1.EditValue = 0;
			this.marqueeProgressBarControl1.Location = new System.Drawing.Point(12, 231);
			this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
			this.marqueeProgressBarControl1.Size = new System.Drawing.Size(426, 12);
			this.marqueeProgressBarControl1.TabIndex = 5;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(12, 212);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(88, 13);
			this.labelControl2.TabIndex = 7;
			this.labelControl2.Text = "Đang tải dữ liệu...";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Location = new System.Drawing.Point(84, 59);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(287, 23);
			this.labelControl1.TabIndex = 8;
			this.labelControl1.Text = "ỨNG DỤNG HỌC TIẾNG K\'HO";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Location = new System.Drawing.Point(95, 134);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(242, 17);
			this.labelControl3.TabIndex = 8;
			this.labelControl3.Text = "KHOA CÔNG NGHỆ THÔNG TIN";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Location = new System.Drawing.Point(110, 111);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(207, 17);
			this.labelControl4.TabIndex = 8;
			this.labelControl4.Text = "TRƯỜNG ĐẠI HỌC ĐÀ LẠT";
			// 
			// WaitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 278);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.marqueeProgressBarControl1);
			this.Name = "WaitForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MarqueeProgressBarControl marqueeProgressBarControl1;
		private LabelControl labelControl2;
		private LabelControl labelControl1;
		private LabelControl labelControl3;
		private LabelControl labelControl4;
	}
}
