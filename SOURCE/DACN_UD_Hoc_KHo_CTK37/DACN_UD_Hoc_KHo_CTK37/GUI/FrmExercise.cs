using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37
{
	public partial class FrmExercise : DevExpress.XtraEditors.XtraForm
	{
		private int _iDBaiHoc;
		private int soBT = 0;
		private int idBT = 0;
		int stt = 1;
		public int IdBaiHoc
		{
			get { return _iDBaiHoc; }
			set { _iDBaiHoc = value; LoadBaiTap(_iDBaiHoc); }
		}
		public FrmExercise(int iDBaiHoc)
		{
			InitializeComponent();
			IdBaiHoc = iDBaiHoc;
		}

		#region Method

		private void LoadCauHoi(int idCauHoi)
		{
			foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHoiByID(idCauHoi))
			{
				if (ch.TraLoi != null)
				{
					txtCauHoi.Text = "Câu " + stt + ": " + ch.Hoi;
					txtTraLoi.Text = ch.TraLoi;
				}
				else
				{
					txtCauHoi.Text = "Câu " + stt + ": " + ch.Hoi;
					txtTraLoi.Text = "Cập nhập";
				}
			}
			if (stt == 1)
			{
				btnPr.Enabled = false;
			}
			else if (stt == soBT)
			{
				btnNext.Enabled = false;
			}
			else if (stt < soBT || stt > 1)
			{
				btnPr.Enabled = true;
				btnNext.Enabled = true;
			}
		}
		void LoadBaiTap(int iDBaiHoc)
		{
			btnPr.Enabled = false;
			btnNext.Enabled = true;
			txtCauHoi.Text = "";
			txtCount.Text = "";
			txtTraLoi.Text = "";
			foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoad(iDBaiHoc))
			{
				if (item.TenKHo != null)
				{
					foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						int i = 0;
						if (itemdmc.CauHois.Count >= 1)
						{
							i++;
							soBT = CauHoiDao.Instance.CauHoiCounts(itemdmc.ID);
							txtCount.Text = i + " / " + soBT.ToString();
							var ch = CauHoiDao.Instance.LoadCauHoiFirst(itemdmc.ID);
							LoadCauHoi(ch.ID);
							idBT = ch.ID;
						}
					}
				}
				else
				{
					foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						int i = 0;
						if (itemdmc.CauHois.Count >= 1)
						{
							i++;
							soBT = CauHoiDao.Instance.CauHoiCounts(itemdmc.ID);
							txtCount.Text = i + " / " + soBT.ToString();
							var ch = CauHoiDao.Instance.LoadCauHoiFirst(itemdmc.ID);
							LoadCauHoi(ch.ID);
							idBT = ch.ID;
						}

					}

				}

			}
		}
		#endregion
		#region event
		private void btnNext_Click(object sender, EventArgs e)
		{
			string cauTL = txtTraLoi.Text;
			CauHoiDao.Instance.UpdateCauHoi(idBT, cauTL);
			if (stt < soBT)
			{
				stt++;
				idBT = idBT + 1;
				txtCount.Text = stt + " / " + soBT.ToString();
				LoadCauHoi(idBT);
			}
			else
			{
				MessageBox.Show("Đã hết câu hỏi của bài: " + _iDBaiHoc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnPr_Click(object sender, EventArgs e)
		{
			if (stt > 1)
			{
				stt--;
				idBT = idBT - 1;
				txtCount.Text = stt + " / " + soBT.ToString();
				LoadCauHoi(idBT);
			}
			else if (stt == 1)
			{
				MessageBox.Show("Đã hết câu hỏi của bài: " + _iDBaiHoc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				string cauTL = txtTraLoi.Text;
				CauHoiDao.Instance.UpdateCauHoi(idBT, cauTL);
				Close();
			}
			catch (Exception)
			{
				Close();
			}

		}
		#endregion

	}
}