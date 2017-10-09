using System;
using System.Drawing;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.Properties;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	public partial class FrmDictionary : XtraForm
	{
		public FrmDictionary()
		{
			InitializeComponent();
			DataForm();
		}

		#region Method
		void DataForm()
		{
			txtDic.Leave += txtDic_Leave;
			txtDic.Enter += txtDic_Enter;
			lbcTuVung.Items.Clear();
			foreach (var item in TuVungDao.Instance.LoadTuVungDic())
			{
				lbcTuVung.Items.Add(item.KHo);
			}
		}
		#endregion
		#region action
		private void lbcTuVung_Click(object sender, EventArgs e)
		{
			recNghia.ResetText();
			recNghia.Font = new Font("TNKeyUni-Arial", 11F);
			recNghia.Text = "";
			string tukhoa = lbcTuVung.SelectedItem.ToString();
			string name = tukhoa;
			foreach (var item in TuVungDao.Instance.LoadTuVungByKHo(name))
				if (item.KHo != null)
					recNghia.Text += item.Viet == null ? item.KHo + ": Đang cập nhật\n" : item.KHo + ": " + item.Viet + "\n";
		}
		#endregion

		private void btnDic_Click(object sender, EventArgs e)
		{
			if (txtDic.Text == Resources.nhap_tu_can_tra || txtDic.Text== "")
				XtraMessageBox.Show("Vui lòng nhập từ cần tra!", Resources.thong_bao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				recNghia.ResetText();
				recNghia.Font = new Font("TNKeyUni-Arial", 11F);
				recNghia.Text = "";
				string name = txtDic.Text;
				if (TuVungDao.Instance.LoadTuVungByKHo(name).Count <= 0)
					recNghia.Text += Resources.khong_tim_thay;
				else
					foreach (var item in TuVungDao.Instance.LoadTuVungByKHo(name))
						if (item.KHo != null)
							recNghia.Text += item.Viet == null ? item.KHo + ": Đang cập nhật\n" : item.KHo + ": " + item.Viet + "\n";
			}
		}

		private void txtDic_Enter(object sender, EventArgs e)
		{
			if (txtDic.Text == Resources.nhap_tu_can_tra)
			{
				txtDic.Text = "";
				txtDic.ForeColor = Color.Black;
			}
		}

		private void txtDic_Leave(object sender, EventArgs e)
		{
			if (txtDic.Text == "")
			{
				txtDic.Text = Resources.nhap_tu_can_tra;
				txtDic.ForeColor = Color.Gray;
			}
		}
	}
}