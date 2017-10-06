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
		private string gopy = "";
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
					gopy = ch.GoiY;
					lbGoiy.Text = "";
					txtTraLoi.ForeColor = Color.Black;
				}
				else
				{
					txtCauHoi.Text = "Câu " + stt + ": " + ch.Hoi;
					gopy = ch.GoiY;
					lbGoiy.Text = "";
					txtTraLoi.Text = "Nhập câu trả lời!";
					txtTraLoi.ForeColor = Color.LightGray;
					this.txtTraLoi.Leave += new System.EventHandler(this.txtTraLoi_Leave);
					this.txtTraLoi.Enter += new System.EventHandler(this.txtTraLoi_Enter);
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
			txtCauHoi.Text = "";
			txtCount.Text = "";
			lbGoiy.Text = "";
			btnPr.Enabled = false;
			btnNext.Enabled = true;
			foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoad(iDBaiHoc))
			{
				if (item.TenKHo != null)
				{
					foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						if (itemdmc.CauHois.Count >= 1)
						{
							soBT = CauHoiDao.Instance.CauHoiCounts(itemdmc.ID);
							txtCount.Text = stt + " / " + soBT.ToString();
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
						if (itemdmc.CauHois.Count >= 1)
						{
							soBT = CauHoiDao.Instance.CauHoiCounts(itemdmc.ID);
							txtCount.Text = stt + " / " + soBT.ToString();
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
		private void txtTraLoi_Leave(object sender, EventArgs e)
		{
			if (txtTraLoi.Text == "")
			{
				txtTraLoi.Text = "Nhập câu trả lời!";
				txtTraLoi.ForeColor = Color.Gray;
			}
			else
			{
				txtTraLoi.ForeColor = Color.Black;
			}
		}

		private void txtTraLoi_Enter(object sender, EventArgs e)
		{
			if (txtTraLoi.Text == "Nhập câu trả lời!")
			{
				txtTraLoi.Text = "";
				txtTraLoi.ForeColor = Color.Black;
			}
		}
		private void btnNext_Click(object sender, EventArgs e)
		{
			string cauTL = txtTraLoi.Text;
			if (cauTL != "Nhập câu trả lời!")
			{
				CauHoiDao.Instance.UpdateCauHoi(idBT, cauTL);
			}
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
				if (cauTL != "Nhập câu trả lời!")
				{
					CauHoiDao.Instance.UpdateCauHoi(idBT, cauTL);
				}
				Close();
			}
			catch (Exception)
			{
				Close();
			}

		}

        private void btnGoiY_Click(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercise));
            if (btnGoiY.Text == "Gợi ý")
            {
                btnGoiY.Text = "Ẩn";
                btnGoiY.Image = DACN_UD_Hoc_KHo_CTK37.Properties.Resources.btnGoiY_ImageAn;
                lbGoiy.Text = gopy;
            }
            else
            {
                btnGoiY.Text = "Gợi ý";
                btnGoiY.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiY.Image")));
                lbGoiy.Text = "";

            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn làm mới tất cả câu trả lời không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoad(_iDBaiHoc))
                {
                    if (item.TenKHo != null)
                    {
                        foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
                        {
                            if (itemdmc.CauHois.Count >= 1)
                            {
                                foreach (CauHoi itemcauhoi in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
                                {
                                    CauHoiDao.Instance.Referst(itemcauhoi.ID);
                                }
                                XtraMessageBox.Show("Đã làm mới tất cả câu trả lời?", "Thông báo", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                                LoadBaiTap(_iDBaiHoc);
                            }
                        }
                    }
                    else
                    {
                        foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
                        {
                            if (itemdmc.CauHois.Count >= 1)
                            {
                                foreach (CauHoi itemcauhoi in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
                                {
                                    CauHoiDao.Instance.Referst(itemcauhoi.ID);
                                }
                                XtraMessageBox.Show("Đã làm mới tất cả câu trả lời?", "Thông báo", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                                LoadBaiTap(_iDBaiHoc);
                            }

                        }

                    }

                }
            }

        }
        #endregion
    }
}