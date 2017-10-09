using System;
using System.Drawing;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DACN_UD_Hoc_KHo_CTK37.Properties;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	public partial class FrmGrammar : XtraForm
	{
		private int _iDNguPhap;

		public int IdNguPhap
		{
			get { return _iDNguPhap; }
			set { _iDNguPhap = value; LoadNguPhap(_iDNguPhap); }
		}



		public FrmGrammar(int iDNguPhap)
		{
			InitializeComponent();
			IdNguPhap = iDNguPhap;
		}

		private void LoadNguPhap(int _iDNguPhap)
		{
			recNguPhap.ResetText();
			recNguPhap.Font = new Font("TNKeyUni-Arial", 12F);
			DanhMucCon dmcon = DanhMucConDao.Instance.DanhMucConByID(_iDNguPhap);
			lbName.Text = dmcon.Ten;
			foreach (var item in NguPhapDAO.Instance.LoadNguPhaps(_iDNguPhap))
				recNguPhap.Text += item.NoiDung + "\n";
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FrmGrammar_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (XtraMessageBox.Show("Bạn có muốn đóng ngữ pháp không?", Resources.thong_bao, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
				e.Cancel = true;
		}
	}
}