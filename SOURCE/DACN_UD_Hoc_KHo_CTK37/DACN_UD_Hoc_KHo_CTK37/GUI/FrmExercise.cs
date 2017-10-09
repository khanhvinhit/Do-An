using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DACN_UD_Hoc_KHo_CTK37.Properties;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	public partial class FrmExercise : XtraForm
	{
		private int _iDBaiHoc;
		private int _soBt;
		private int _idBt;
		int _stt = 1;
		private string _gopy = "";
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
					txtCauHoi.Text = Resources.cau_so + _stt + ": " + ch.Hoi;
					txtTraLoi.Text = ch.TraLoi;
					_gopy = ch.GoiY;
					lbGoiy.Text = "";
					txtTraLoi.ForeColor = Color.Black;
				}
				else
				{
					txtCauHoi.Text = Resources.cau_so + _stt + ": " + ch.Hoi;
					_gopy = ch.GoiY;
					lbGoiy.Text = "";
					txtTraLoi.Text = Resources.nhap_cau_trl;
					txtTraLoi.ForeColor = Color.LightGray;
					txtTraLoi.Leave += txtTraLoi_Leave;
					txtTraLoi.Enter += txtTraLoi_Enter;
				}
			}
			if (_stt == 1)
				btnPr.Enabled = false;
			else if (_stt == _soBt)
				btnNext.Enabled = false;
			else if (_stt < _soBt || _stt > 1)
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
							_soBt = CauHoiDao.Instance.CauHoiCounts(itemdmc.ID);
							txtCount.Text = _stt + " / " + _soBt.ToString();
							var ch = CauHoiDao.Instance.LoadCauHoiFirst(itemdmc.ID);
							LoadCauHoi(ch.ID);
							_idBt = ch.ID;
						}
					}
				}
				else
				{
					foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						if (itemdmc.CauHois.Count >= 1)
						{
							_soBt = CauHoiDao.Instance.CauHoiCounts(itemdmc.ID);
							txtCount.Text = _stt + " / " + _soBt.ToString();
							var ch = CauHoiDao.Instance.LoadCauHoiFirst(itemdmc.ID);
							LoadCauHoi(ch.ID);
							_idBt = ch.ID;
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
				txtTraLoi.Text = Resources.nhap_cau_trl;
				txtTraLoi.ForeColor = Color.Gray;
			}
			else
				txtTraLoi.ForeColor = Color.Black;
		}

		private void txtTraLoi_Enter(object sender, EventArgs e)
		{
			if (txtTraLoi.Text == Resources.nhap_cau_trl)
			{
				txtTraLoi.Text = "";
				txtTraLoi.ForeColor = Color.Black;
			}
		}
		private void btnNext_Click(object sender, EventArgs e)
		{
			string cauTl = txtTraLoi.Text;
			if (cauTl != Resources.nhap_cau_trl)
				CauHoiDao.Instance.UpdateCauHoi(_idBt, cauTl);
			if (_stt < _soBt)
			{
				_stt++;
				_idBt = _idBt + 1;
				txtCount.Text = _stt + " / " + _soBt.ToString();
				LoadCauHoi(_idBt);
			}
			else
				XtraMessageBox.Show(Resources.het_cau_hoi + _iDBaiHoc, Resources.thong_bao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnPr_Click(object sender, EventArgs e)
		{
			if (_stt > 1)
			{
				_stt--;
				_idBt = _idBt - 1;
				txtCount.Text = _stt + " / " + _soBt.ToString();
				LoadCauHoi(_idBt);
			}
			else if (_stt == 1)
			{
				XtraMessageBox.Show(Resources.het_cau_hoi + _iDBaiHoc, Resources.thong_bao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				string cauTl = txtTraLoi.Text;
				if (cauTl != Resources.nhap_cau_trl)
				{
					CauHoiDao.Instance.UpdateCauHoi(_idBt, cauTl);
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmExercise));
            if (btnGoiY.Text == Resources.goi_y)
            {
                btnGoiY.Text = "Ẩn";
                btnGoiY.Image = Resources.btnGoiY_ImageAn;
                lbGoiy.Text = _gopy;
            }
            else
            {
                btnGoiY.Text = Resources.goi_y;
                btnGoiY.Image = ((Image)(resources.GetObject("btnGoiY.Image")));
                lbGoiy.Text = "";

            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn làm mới tất cả câu trả lời không?", Resources.thong_bao, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
								XtraMessageBox.Show("Đã làm mới tất cả câu trả lời?", Resources.thong_bao, MessageBoxButtons.OK,
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
								XtraMessageBox.Show("Đã làm mới tất cả câu trả lời?", Resources.thong_bao, MessageBoxButtons.OK,
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