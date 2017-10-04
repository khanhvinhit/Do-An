using System;
using System.Linq;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.Properties;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37
{
	public partial class FrmUdHoc : RibbonForm
	{
		public FrmUdHoc()
		{
			InitializeComponent();
			UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
			InitSkinGallery();
			LoadBaiHoc();
		}

		#region Method
		private void InitSkinGallery()
		{
			SkinHelper.InitSkinGallery(rbSkin, true);
		}
		void LoadBaiHoc()
		{

			FrmWecome f = new FrmWecome();
			f.MdiParent = this;
			f.Show();
		}

		private bool CheckExistForm(string name)
		{
			bool check = false;
			foreach (Form Frm in this.MdiChildren)
			{
				if (Frm.Name == name)
				{
					check = true;
					break;
				}
			}
			return check;
		}

		private void ActiveChildForm(string name)
		{
			foreach (Form Frm in this.MdiChildren)
			{
				if (Frm.Name == name)
				{
					Frm.Activate();
					break;
				}
			}
		}
		#endregion


		#region Event
		private void btnHelper_ItemClick(object sender, ItemClickEventArgs e)
		{
			//foreach (Form Frm in this.MdiChildren)
			//{
			//	Frm.Close();
			//}
			if (!CheckExistForm("FrmHelper"))
			{
				FrmHelper f = new FrmHelper();
				f.MdiParent = this;
				f.Show();
			}
			else
			{
				ActiveChildForm("FrmHelper");
			}
		}
		private void btnLesson_ItemClick(object sender, ItemClickEventArgs e)
		{
			//foreach (Form Frm in this.MdiChildren)
			//{
			//	Frm.Close();
			//}
			if (!CheckExistForm("FrmDsBaiHoc"))
			{
				FrmDsBaiHoc f = new FrmDsBaiHoc();
				f.MdiParent = this;
				f.Show();
			}
			else
			{
				ActiveChildForm("FrmDsBaiHoc");
			}
		}

		private void FrmUdHoc_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (XtraMessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
			{
				e.Cancel = true;

			}
			Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
			Settings.Default.Save();
		}

		private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnGammar_ItemClick(object sender, ItemClickEventArgs e)
		{
			//foreach (Form Frm in this.MdiChildren)
			//{
			//	Frm.Close();
			//}
			if (!CheckExistForm("FrmDsGrammar"))
			{
				FrmDsGrammar f = new FrmDsGrammar();
				f.MdiParent = this;
				f.Show();
			}
			else
			{
				ActiveChildForm("FrmDsGrammar");
			}

		}

		private void btnInfo_ItemClick(object sender, ItemClickEventArgs e)
		{
			//foreach (Form Frm in this.MdiChildren)
			//{
			//	Frm.Close();
			//}
			if (!CheckExistForm("FrmInfo"))
			{
				FrmInfo f = new FrmInfo();
				f.MdiParent = this;
				f.Show();
			}
			else
			{
				ActiveChildForm("FrmInfo");
			}
		}

		private void btnDictionary_ItemClick(object sender, ItemClickEventArgs e)
		{

			try
			{
				FrmDictionary f = Application.OpenForms.OfType<FrmDictionary>().FirstOrDefault();
				if (f != null)
				{
					XtraMessageBox.Show("Bạn đã mở tử điển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					f = new FrmDictionary();
					f.Show();
				}
			}
			catch (Exception)
			{
				XtraMessageBox.Show("Không thể kết nối dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion










	}
}