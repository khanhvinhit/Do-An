using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
    public partial class FrmLuyenTap : DevExpress.XtraEditors.XtraForm
    {
        private int _iDBaiHoc;
        private int soLT = 0;
        private int idLT = 0;
        int stt = 1;
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
                            soLT = LuyenTapDao.Instance.LTCounts(itemdmc.ID);
                            lbCauHoi.Text = "Câu " + stt + ":";
                            var lt = LuyenTapDao.Instance.LoadLTFirst(itemdmc.ID);
                            LoadCauHoiLT(lt.ID);
                            idLT = lt.ID;
                        }
                    }
                }
                else
                {
                    foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
                    {
                        if (itemdmc.LuyenTaps.Count >= 1)
                        {
                            soLT = LuyenTapDao.Instance.LTCounts(itemdmc.ID);
                            lbSo.Text = stt + "/" + soLT;
                            lbCauHoi.Text = "Câu " + stt + ":";
                            var lt = LuyenTapDao.Instance.LoadLTFirst(itemdmc.ID);
                            LoadCauHoiLT(lt.ID);
                            idLT = lt.ID;
                        }
                    }
                }
            }
        }

        private void LoadCauHoiLT(int idLT)
        {
            recTraLoi.ResetText();
            foreach (var lt in LuyenTapDao.Instance.LoadLTByID(idLT))
            {
                lbCauh.Text = lt.HoiKHo + "\n";
                if (lt.HoiViet != null)
                {
                    lbCauh.Text = lt.HoiKHo + "\n" + lt.HoiViet + "\n";
                }
                if (lt.TraLoiViet != null)
                {
                    lbCauh.Text = lt.HoiKHo + "\n" + lt.HoiViet + "\n + " + lt.TraLoiViet + "\n";
                }
                if (lt.TraLoiKHo!=null)
                {
                    recTraLoi.Text += lt.TraLoiKHo;
                }
                else
                {
					recTraLoi.ForeColor = Color.LightGray;
					recTraLoi.Text = "Nhập câu trả lời!";
					this.recTraLoi.Leave += new System.EventHandler(this.recTraLoi_Leave);
					this.recTraLoi.Enter += new System.EventHandler(this.recTraLoi_Enter);
                }
            }
            if (stt == 1)
            {
                btnPrev.Enabled = false;
            }
            else if (stt == soLT)
            {
                btnNext.Enabled = false;
            }
            else if (stt < soLT || stt > 1)
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
        }
        #endregion
		#region event
		private void recTraLoi_Leave(object sender, EventArgs e)
		{
			if (recTraLoi.Text == null)
			{
				recTraLoi.ForeColor = Color.Gray;
				recTraLoi.Text = "Nhập câu trả lời!";
			}
			else
			{
				recTraLoi.ForeColor = Color.Black;
			}
		}

		private void recTraLoi_Enter(object sender, EventArgs e)
		{
			if (recTraLoi.Text == "Nhập câu trả lời!")
			{
				recTraLoi.Text = null;
				recTraLoi.ForeColor = Color.Black;
			}
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			if (XtraMessageBox.Show("Bạn có muốn làm mới tất cả câu trả lời không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
								{
									LuyenTapDao.Instance.Referst(lt.ID);
								}
								XtraMessageBox.Show("Đã làm mới tất cả câu trả lời?", "Thông báo", MessageBoxButtons.OK,
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
								{
									LuyenTapDao.Instance.Referst(lt.ID);
								}
								XtraMessageBox.Show("Đã làm mới tất cả câu trả lời?", "Thông báo", MessageBoxButtons.OK,
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
				string cauTL = recTraLoi.Text;
				if (cauTL != "Nhập câu trả lời!")
				{
					LuyenTapDao.Instance.UpdateLT(idLT, cauTL);
				}
				Close();
			}
			catch (Exception)
			{
				Close();
			}
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (stt > 1)
			{
				stt--;
				idLT = idLT - 1;
				lbSo.Text = stt + " / " + soLT;
				lbCauHoi.Text = "Câu " + stt + ":";
				LoadCauHoiLT(idLT);
			}
			else if (stt == 1)
			{
				MessageBox.Show("Đã hết câu hỏi của bài: " + _iDBaiHoc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			string cauTL = recTraLoi.Text;
			if (cauTL != "")
			{
				LuyenTapDao.Instance.UpdateLT(idLT, cauTL);
			}
			if (stt < soLT)
			{
				stt++;
				idLT = idLT + 1;
				lbSo.Text = stt + " / " + soLT;
				lbCauHoi.Text = "Câu " + stt + ":";
				LoadCauHoiLT(idLT);
			}
			else
			{
				MessageBox.Show("Đã hết câu hỏi của bài: " + _iDBaiHoc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		#endregion
		
    }
}
