using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37
{
	public partial class frmDictionary : DevExpress.XtraEditors.XtraForm
	{
		public frmDictionary()
		{
			InitializeComponent();
			DataForm();
		}

		#region MEnthod
		void DataForm()
		{
			this.txtDic.Leave += new System.EventHandler(this.txtDic_Leave);
			this.txtDic.Enter += new System.EventHandler(this.txtDic_Enter);
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
			{
				if (item.KHo != null)
				{
					if (item.Viet == null)
					{
						recNghia.Text += item.KHo + ": Đang cập nhật\n";
					}
					else
					{
						recNghia.Text += item.KHo + ": " + item.Viet + "\n";
					}

				}
			}
		}
		#endregion

		private void btnDic_Click(object sender, EventArgs e)
		{
			if (txtDic.Text == "Nhập từ cần tra!" || txtDic.Text=="")
			{
				XtraMessageBox.Show("Vui lòng nhập từ cần tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				recNghia.ResetText();
				recNghia.Font = new Font("TNKeyUni-Arial", 11F);
				recNghia.Text = "";
				string name = txtDic.Text;
				if (TuVungDao.Instance.LoadTuVungByKHo(name).Count <= 0)
				{
					recNghia.Text += "Không tin thấy từ này!";
				}
				else
				{
					foreach (var item in TuVungDao.Instance.LoadTuVungByKHo(name))
					{
						if (item.KHo != null)
						{
							if (item.Viet == null)
							{
								recNghia.Text += item.KHo + ": Đang cập nhật\n";
							}
							else
							{
								recNghia.Text += item.KHo + ": " + item.Viet + "\n";
							}

						}
					}
				}
			}
			

		}

		private void txtDic_Enter(object sender, EventArgs e)
		{
			if (txtDic.Text == "Nhập từ cần tra!")
			{
				txtDic.Text = "";
				txtDic.ForeColor = Color.Black;
			}
		}

		private void txtDic_Leave(object sender, EventArgs e)
		{
			if (txtDic.Text == "")
			{
				txtDic.Text = "Nhập từ cần tra!";
				txtDic.ForeColor = Color.Gray;
			}
		}

		
		
	}


}