using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	partial class FrmDictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDictionary));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lbcTuVung = new DevExpress.XtraEditors.ListBoxControl();
            this.recNghia = new DevExpress.XtraRichEdit.RichEditControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDic = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDic = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcTuVung)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDic.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(563, 222);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainerControl1);
            this.groupBox2.Location = new System.Drawing.Point(6, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Từ điển";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(7, 21);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lbcTuVung);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.recNghia);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(538, 132);
            this.splitContainerControl1.SplitterPosition = 188;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lbcTuVung
            // 
            this.lbcTuVung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcTuVung.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcTuVung.Appearance.Options.UseFont = true;
            this.lbcTuVung.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbcTuVung.Location = new System.Drawing.Point(4, 4);
            this.lbcTuVung.Name = "lbcTuVung";
            this.lbcTuVung.Size = new System.Drawing.Size(183, 125);
            this.lbcTuVung.TabIndex = 0;
            this.lbcTuVung.Click += new System.EventHandler(this.lbcTuVung_Click);
            // 
            // recNghia
            // 
            this.recNghia.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.recNghia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recNghia.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.recNghia.EnableToolTips = true;
            this.recNghia.Location = new System.Drawing.Point(0, 4);
            this.recNghia.Name = "recNghia";
            this.recNghia.Options.CopyPaste.MaintainDocumentSectionSettings = false;
            this.recNghia.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.recNghia.Options.MailMerge.KeepLastParagraph = false;
            this.recNghia.ReadOnly = true;
            this.recNghia.Size = new System.Drawing.Size(342, 121);
            this.recNghia.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDic);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtDic);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra từ";
            // 
            // btnDic
            // 
            this.btnDic.Location = new System.Drawing.Point(470, 16);
            this.btnDic.Name = "btnDic";
            this.btnDic.Size = new System.Drawing.Size(75, 23);
            this.btnDic.TabIndex = 2;
            this.btnDic.Text = "Tra từ";
            this.btnDic.ToolTip = "Nhấn để tra từ";
            this.btnDic.Click += new System.EventHandler(this.btnDic_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nhập từ:";
            // 
            // txtDic
            // 
            this.txtDic.Location = new System.Drawing.Point(56, 17);
            this.txtDic.Name = "txtDic";
            this.txtDic.Properties.Appearance.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDic.Properties.Appearance.Options.UseFont = true;
            this.txtDic.Size = new System.Drawing.Size(408, 22);
            this.txtDic.TabIndex = 0;
            this.txtDic.ToolTip = "Nhập từ cần tra";
            this.txtDic.Enter += new System.EventHandler(this.txtDic_Enter);
            this.txtDic.Leave += new System.EventHandler(this.txtDic_Leave);
            // 
            // FrmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 222);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Từ điển";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcTuVung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDic.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private PanelControl panelControl1;
		private GroupBox groupBox2;
		private GroupBox groupBox1;
		private SimpleButton btnDic;
		private LabelControl labelControl1;
		private TextEdit txtDic;
		private SplitContainerControl splitContainerControl1;
		private RichEditControl recNghia;
		private ListBoxControl lbcTuVung;
	}
}