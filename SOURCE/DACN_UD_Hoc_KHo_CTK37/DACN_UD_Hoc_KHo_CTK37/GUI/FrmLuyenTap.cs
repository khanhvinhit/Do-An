using System;
using System.Drawing;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DACN_UD_Hoc_KHo_CTK37.Properties;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
    public partial class FrmLuyenTap : XtraForm
    {
        private int _iDBaiHoc;
        private int _soLt;
        private int _idLt;
        int _stt = 1;
        public int IdBaiHoc
        {
            get { return _iDBaiHoc; }
            set { _iDBaiHoc = value; LoadLuyenTap(_iDBaiHoc); }
        }
        public FrmLuyenTap(int iDBaiHoc)
        {
            InitializeComponent();
            IdBaiHoc = iDBaiHoc;
        }

        #region method

        private void LoadLuyenTap(int idBaiHoc)
        {
	        lbHay.Text = "";
            recTraLoi.ResetText();
            recTraLoi.Font = new Font("TNKeyUni-Arial", 11F);
            foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoad(idBaiHoc))
            {
                if (item.TenKHo != null)
                {
                    foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
                    {
                        if (itemdmc.LuyenTaps.Count >= 1)
                        {
                            _soLt = LuyenTapDao.Instance.LTCounts(itemdmc.ID);
                            lbCauHoi.Text = "Chủ đề " + _stt + Resources.dau_2_cham;
                            var lt = LuyenTapDao.Instance.LoadLTFirst(itemdmc.ID);
                            LoadCauHoiLt(lt.ID);
                            _idLt = lt.ID;
                        }
                    }
                }
                else
                {
                    foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
                    {
                        if (itemdmc.LuyenTaps.Count >= 1)
                        {
                            _soLt = LuyenTapDao.Instance.LTCounts(itemdmc.ID);
                            lbSo.Text = _stt + Resources.dau_cheo + _soLt;
							lbCauHoi.Text = "Chủ đề " + _stt + Resources.dau_2_cham;
                            var lt = LuyenTapDao.Instance.LoadLTFirst(itemdmc.ID);
                            LoadCauHoiLt(lt.ID);
                            _idLt = lt.ID;
                        }
                    }
                }
            }
		}

        private void LoadCauHoiLt(int idLt)
        {
            recTraLoi.ResetText();
            foreach (var lt in LuyenTapDao.Instance.LoadLTByID(idLt))
            {
                lbCauh.Text = lt.HoiKHo;
                if (lt.HoiViet != null)
					lbHay.Text = lt.HoiViet;
                //if (lt.TraLoiViet != null)
				//	lbCauh.Text = lt.HoiKHo + "\n" + lt.HoiViet + "\n + " + lt.TraLoiViet + "\n";
                if (lt.TraLoiKHo!=null)
					recTraLoi.Text += lt.TraLoiKHo;
				else
				{
					recTraLoi.ForeColor = Color.LightGray;
					recTraLoi.Text = Resources.nhap_cau_trl;
					recTraLoi.Leave += recTraLoi_Leave;
					recTraLoi.Enter += recTraLoi_Enter;
				}
				if (lt.HoiViet == "Tự đọc câu sau:")
				{
					lbTL.Visible = false;
					recTraLoi.Visible = false;
				}
				else
				{
					lbTL.Visible = true;
					recTraLoi.Visible = true;
				}
                
            }
			btnPrev.Enabled = _stt > 1 ? true : false;
			btnNext.Enabled = _stt < _soLt ? true : false;
        }
        #endregion
		#region event
		private void recTraLoi_Leave(object sender, EventArgs e)
		{
			if (recTraLoi.Text == null)
			{
				recTraLoi.ForeColor = Color.Gray;
				recTraLoi.Text = Resources.nhap_cau_trl;
			}
			else
				recTraLoi.ForeColor = Color.Black;
		}

		private void recTraLoi_Enter(object sender, EventArgs e)
		{
			if (recTraLoi.Text == Resources.nhap_cau_trl)
			{
				recTraLoi.Text = null;
				recTraLoi.ForeColor = Color.Black;
			}
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			if (XtraMessageBox.Show("Bạn có muốn làm mới tất cả câu trả lời không?", Resources.thong_bao, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoad(_iDBaiHoc))
				{
					if (item.TenKHo != null)
					{
						foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
						{
							if (itemdmc.LuyenTaps.Count >= 1)
							{
								foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
									LuyenTapDao.Instance.Referst(lt.ID);
								XtraMessageBox.Show("Đã làm mới tất cả câu trả lời?", Resources.thong_bao, MessageBoxButtons.OK,
											MessageBoxIcon.Information);
								recTraLoi.ResetText();
								LoadLuyenTap(IdBaiHoc);
							}
						}
					}
					else
					{
						foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
						{
							if (itemdmc.LuyenTaps.Count >= 1)
							{
								foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
									LuyenTapDao.Instance.Referst(lt.ID);
								XtraMessageBox.Show("Đã làm mới tất cả câu trả lời?", Resources.thong_bao, MessageBoxButtons.OK,
											MessageBoxIcon.Information);
								recTraLoi.ResetText();
								LoadLuyenTap(IdBaiHoc);
							}
						}
					}
				}
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			try
			{
				string cauTl = recTraLoi.Text;
				if (cauTl != Resources.nhap_cau_trl)
					LuyenTapDao.Instance.UpdateLT(_idLt, cauTl);
				Close();
			}
			catch (Exception)
			{
				Close();
			}
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (_stt > 1)
			{
				_stt--;
				_idLt = _idLt - 1;
				lbSo.Text = _stt + " / " + _soLt;
				lbCauHoi.Text = "Chủ đề " + _stt + Resources.dau_2_cham;
				LoadCauHoiLt(_idLt);
			}
			else if (_stt == 1)
				XtraMessageBox.Show(Resources.het_cau_hoi + _iDBaiHoc, Resources.thong_bao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			string cauTl = recTraLoi.Text;
			if (cauTl != "")
				LuyenTapDao.Instance.UpdateLT(_idLt, cauTl);
			if (_stt < _soLt)
			{
				_stt++;
				_idLt = _idLt + 1;
				lbSo.Text = _stt + " / " + _soLt;
				lbCauHoi.Text = "Chủ đề " + _stt + Resources.dau_2_cham;
				LoadCauHoiLt(_idLt);
			}
			else
				XtraMessageBox.Show(Resources.het_cau_hoi + _iDBaiHoc, Resources.thong_bao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		#endregion
		
    }
}
