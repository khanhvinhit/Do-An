using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace DACN_UD_Hoc_KHo_CTK37
{
	public partial class FrmUdHoc : RibbonForm
	{
		public FrmUdHoc()
		{
			InitializeComponent();
			LoadBaiHoc();
		}

		#region Method

		void LoadBaiHoc()
		{

			FrmWecome f = new FrmWecome();
			f.MdiParent = this;
			f.Show();
		}

		private bool CheckExistForm(string name)
		{
			bool check = false;
			foreach (Form frm in this.MdiChildren)
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
			foreach (Form frm in this.MdiChildren)
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
		private void btnHelper_ItemClick(object sender, ItemClickEventArgs e)
		{
			foreach (Form frm in this.MdiChildren)
			{
				frm.Close();
			}
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
			foreach (Form frm in this.MdiChildren)
			{
				frm.Close();
			}
			if (!CheckExistForm("frmDSBaiHoc"))
			{
				FrmDsBaiHoc f = new FrmDsBaiHoc();
				f.MdiParent = this;
				f.Show();
			}
			else
			{
				ActiveChildForm("frmDSBaiHoc");
			}
		}
		
		private void FrmUdHoc_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
			{
				e.Cancel = true;
			}
		}

		private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnGammar_ItemClick(object sender, ItemClickEventArgs e)
		{
			foreach (Form frm in this.MdiChildren)
			{
				frm.Close();
			}
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
			foreach (Form frm in this.MdiChildren)
			{
				frm.Close();
			}
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
		#endregion

		

		

		

		
	}
}