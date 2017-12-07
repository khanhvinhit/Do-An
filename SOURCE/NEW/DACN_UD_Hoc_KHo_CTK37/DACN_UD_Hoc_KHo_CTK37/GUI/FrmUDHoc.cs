using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.Properties;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	public partial class FrmUdHoc : RibbonForm
	{
		public FrmUdHoc()
		{
			if (Settings.Default["CheckDB"].ToString() == "0")
			{
				FrmSetting frm = new FrmSetting();
				frm.AddServer += frm_OK;
				frm.FormClosed += new FormClosedEventHandler(frm_Close);
				frm.ShowDialog();
			}
			else
			{
				InitializeComponent();
				UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
				InitSkinGallery();
				WebCome();
			}


		}

		#region Method
		private void InitSkinGallery()
		{
			SkinHelper.InitSkinGallery(rbSkin, true);
		}
		void WebCome()
		{

			FrmWecome f = new FrmWecome();
			f.MdiParent = this;
			f.Show();
		}

		

		private bool CheckExistForm(string name)
		{
			bool check = false;
			foreach (Form frm in MdiChildren)
			{
				if (frm.Name == name)
				{
					check = true;
					break;
				}
			}
			return check;
		}

		private void ActiveChildForm(string name)
		{
			foreach (Form frm in MdiChildren)
			{
				if (frm.Name == name)
				{
					frm.Activate();
					break;
				}
			}
		}
		#endregion


		#region Event
		private void frm_OK(object sender, EventArgs e)
		{
			Settings.Default["CheckDB"] = "1";
			Settings.Default.Save();
			Application.Restart();
		}
		private void frm_Close(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void btnHelper_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CheckExistForm("FrmHelper"))
			{
				FrmHelper f = new FrmHelper();
				f.MdiParent = this;
				f.Show();
			}
			else
				ActiveChildForm("FrmHelper");
		}
		private void btnLesson_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CheckExistForm("FrmDsBaiHoc"))
			{
				FrmDsBaiHoc f = new FrmDsBaiHoc();
				f.MdiParent = this;
				f.Show();
			}
			else
				ActiveChildForm("FrmDsBaiHoc");
		}

		private void FrmUdHoc_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (XtraMessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", Resources.thong_bao, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
				e.Cancel = true;
			Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
			Settings.Default.Save();
		}

		private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}

		private void btnGammar_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CheckExistForm("FrmDsGrammar"))
			{
				FrmDsGrammar f = new FrmDsGrammar();
				f.MdiParent = this;
				f.Show();
			}
			else
				ActiveChildForm("FrmDsGrammar");

		}

		private void btnInfo_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CheckExistForm("FrmInfo"))
			{
				FrmInfo f = new FrmInfo();
				f.MdiParent = this;
				f.Show();
			}
			else
				ActiveChildForm("FrmInfo");
		}

		private void btnDictionary_ItemClick(object sender, ItemClickEventArgs e)
		{

			try
			{
				FrmDictionary f = Application.OpenForms.OfType<FrmDictionary>().FirstOrDefault();
				if (f != null)
					XtraMessageBox.Show("Bạn đã mở tử điển! Xin hãy kiểm tra cửa sổ chương trình!", Resources.thong_bao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					f = new FrmDictionary();
					f.Show();
				}
			}
			catch (Exception)
			{
				XtraMessageBox.Show(Resources.error_connectionstring, Resources.thong_bao, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
	}
}