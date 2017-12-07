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
			this.txtDicti = new System.Windows.Forms.TextBox();
			this.btnDic = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lbcTuVung)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.groupBox2);
			this.panelControl1.Controls.Add(this.groupBox1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(657, 205);
			this.panelControl1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Controls.Add(this.splitContainerControl1);
			this.groupBox2.Location = new System.Drawing.Point(6, 57);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(646, 147);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Từ điển";
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Location = new System.Drawing.Point(7, 19);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.lbcTuVung);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.Controls.Add(this.recNghia);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(564, 122);
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
			this.lbcTuVung.Size = new System.Drawing.Size(183, 115);
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
			this.recNghia.Size = new System.Drawing.Size(368, 115);
			this.recNghia.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDicti);
			this.groupBox1.Controls.Add(this.btnDic);
			this.groupBox1.Controls.Add(this.labelControl1);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(646, 45);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tra từ";
			// 
			// txtDicti
			// 
			this.txtDicti.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDicti.Location = new System.Drawing.Point(56, 16);
			this.txtDicti.Name = "txtDicti";
			this.txtDicti.Size = new System.Drawing.Size(502, 22);
			this.txtDicti.TabIndex = 1;
			this.txtDicti.TextChanged += new System.EventHandler(this.txtDicti_TextChanged);
			this.txtDicti.Enter += new System.EventHandler(this.txtDicti_Enter);
			this.txtDicti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDicti_KeyDown);
			// 
			// btnDic
			// 
			this.btnDic.Location = new System.Drawing.Point(564, 15);
			this.btnDic.Name = "btnDic";
			this.btnDic.Size = new System.Drawing.Size(75, 21);
			this.btnDic.TabIndex = 2;
			this.btnDic.Text = "Tra từ";
			this.btnDic.ToolTip = "Nhấn để tra từ";
			this.btnDic.Click += new System.EventHandler(this.btnDic_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(7, 19);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(43, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Nhập từ:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(577, 23);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(69, 100);
			this.panel1.TabIndex = 10;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(27, 83);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(20, 16);
			this.label12.TabIndex = 0;
			this.label12.Text = ": `";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(5, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 15);
			this.label6.TabIndex = 0;
			this.label6.Text = "`";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(27, 67);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 16);
			this.label11.TabIndex = 0;
			this.label11.Text = ": ~";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(5, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "~";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(27, 51);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(27, 16);
			this.label10.TabIndex = 0;
			this.label10.Text = ": a\\";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "a\\";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(27, 35);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(27, 16);
			this.label9.TabIndex = 0;
			this.label9.Text = ": A|";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(5, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "A|";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(27, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(20, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = ": [";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "[";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(27, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(20, 16);
			this.label7.TabIndex = 0;
			this.label7.Text = ": {";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("TNKeyUni-Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "{";
			// 
			// FrmDictionary
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 205);
			this.Controls.Add(this.panelControl1);
			this.Font = new System.Drawing.Font("TNKeyUni-Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private PanelControl panelControl1;
		private GroupBox groupBox2;
		private GroupBox groupBox1;
		private SimpleButton btnDic;
		private LabelControl labelControl1;
		private SplitContainerControl splitContainerControl1;
		private RichEditControl recNghia;
		private ListBoxControl lbcTuVung;
		private TextBox txtDicti;
		private Panel panel1;
		private Label label12;
		private Label label6;
		private Label label11;
		private Label label5;
		private Label label10;
		private Label label4;
		private Label label9;
		private Label label3;
		private Label label8;
		private Label label2;
		private Label label7;
		private Label label1;
	}
}