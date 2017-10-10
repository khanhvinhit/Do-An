using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DACN_UD_Hoc_KHo_CTK37.Properties;
using DevExpress.XtraEditors;
using WMPLib;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	public partial class FrmBaiHocChiTiet : XtraForm
	{
		private int _iDBaiHoc;
		string _pictures = "";
		private string xuong_dong = "\n";
		private int _next;
		private int _last;
		private WindowsMediaPlayer _sound;
		private bool _trangthaiam;
		public int IdBaiHoc
		{
			get { return _iDBaiHoc; }
			set { _iDBaiHoc = value; LoadBaiHoc(_iDBaiHoc); }
		}
		public FrmBaiHocChiTiet(int iDBaiHoc)
		{
			InitializeComponent();
			IdBaiHoc = iDBaiHoc;
		}
		#region method

		private void LoadDanhMucTheoTen(string name, int id)
		{
			btnAudio.Enabled = false;
			rkqBaiHoc.ResetText();
			rkqBaiHoc.Font = new Font("TNKeyUni-Arial", 11F);
			int j = 0;
			if (DanhMucDao.Instance.KTDanhMuc(name, id))
			{
				foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoadByName(name, id))
				{
					j++;
					if (item.TenKHo != null)
					{
						rkqBaiHoc.Text += j+Resources.dau_cham + Resources.dau_cach + item.TenKHo + " - " + item.TenViet + xuong_dong;
						foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
						{
							rkqBaiHoc.Text += "\t* " + itemdmc.Ten + Resources.dau_cham + xuong_dong;
							if (itemdmc.IDAmThanh > 0)
							{
								btnAudio.Enabled = true;
								if (itemdmc.IDAmThanh > 0)
									btnAudio.Enabled = true;
							}
							if (itemdmc.BaiKhoas.Count >= 1)
							{
								foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
								{
									if (bk.NoiDung == null)
									{
										if (bk.HoiViet != null)
										{
											rkqBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiKHo + xuong_dong : rkqBaiHoc.Text += Resources.tab_daungang + bk.HoiKHo + xuong_dong;
											rkqBaiHoc.Text += bk.TraLoiViet != null ? Resources.tab_daungang + bk.HoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiViet + xuong_dong : rkqBaiHoc.Text += Resources.tab_daungang + bk.HoiViet + xuong_dong;
										}
										else
											rkqBaiHoc.Text += bk.TraLoiKHo != null 
												? Resources.tab_daungang + bk.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiKHo + xuong_dong 
												: rkqBaiHoc.Text += Resources.tab_daungang + bk.HoiKHo + xuong_dong;
									}
									else
										rkqBaiHoc.Text += Resources.tab + bk.NoiDung + xuong_dong;
								}
							}
							if (itemdmc.TuVungs.Count >= 1)
								foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
									rkqBaiHoc.Text += Resources.tab + Resources.tab + tv.KHo + Resources.dau2chamvacach + tv.Viet + xuong_dong;
							if (itemdmc.DamThoais.Count >= 1)
							{
								foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
								{
									if (dt.CauHoiViet != null)
									{
										if (dt.TraLoiKHo != null)
										{
											if (dt.TraLoiViet != null)
											{
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiViet + xuong_dong;
											}
											else
											{
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
											}
										}
										else
										{
											if (dt.TraLoiViet != null)
											{
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiViet + xuong_dong;
											}
											else
											{
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
											}
										}
									}
									else
									{
										rkqBaiHoc.Text += dt.TraLoiKHo != null
											? Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong
											: Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
									}
								}
							}
							if (itemdmc.DichKHoViets.Count >= 1)
							{
								foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
								{
									rkqBaiHoc.Text += kh.Viet != null
										? Resources.tab_daungang + kh.KHo + Resources.tab+ Resources.tab+Resources.dau_cong + kh.Viet + xuong_dong
										: Resources.tab_daungang + kh.KHo + xuong_dong;
								}
							}
							if (itemdmc.DichVietKHoes.Count >= 1)
								foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
									rkqBaiHoc.Text += v.KHo != null ? Resources.tab_daungang + v.Viet + Resources.tab+ Resources.tab+Resources.dau_cong + v.KHo + xuong_dong : Resources.tab_daungang + v.Viet + xuong_dong;
							if (itemdmc.NguPhaps.Count >= 1)
								foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
									rkqBaiHoc.Text += Resources.tab + Resources.tab + tv.NoiDung + xuong_dong;
						}
					}
					else
					{
						j = j - 1;
						foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
						{
							j++;
							rkqBaiHoc.Text += j + Resources.dau_cham + Resources.dau_cach + itemdmc.Ten + Resources.dau_cham + xuong_dong;
							if (itemdmc.IDAmThanh > 0)
							{
								btnAudio.Enabled = true;
								btnAudio.Tag = itemdmc;
							}
							if (itemdmc.BaiKhoas.Count >= 1)
							{
								foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
								{
									if (bk.NoiDung == null)
									{
										if (bk.HoiViet != null)
										{
											rkqBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
											rkqBaiHoc.Text += bk.TraLoiViet != null ? Resources.tab_daungang + bk.HoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiViet + xuong_dong : Resources.tab_daungang + bk.HoiViet + xuong_dong;
										}
										else
											rkqBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
									}
									else
										rkqBaiHoc.Text += Resources.tab + bk.NoiDung + xuong_dong;
								}
							}
							if (itemdmc.TuVungs.Count >= 1)
								foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
									rkqBaiHoc.Text += Resources.tab + tv.KHo + Resources.dau2chamvacach + tv.Viet + xuong_dong;
							if (itemdmc.DamThoais.Count >= 1)
							{
								foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
								{
									if (dt.CauHoiViet != null)
									{
										if (dt.TraLoiKHo != null)
										{
											if (dt.TraLoiViet != null)
											{
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiViet + xuong_dong;
											}
											else
											{
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
											}
										}
										else
										{
											if (dt.TraLoiViet != null)
											{
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiViet + xuong_dong;
											}
											else
											{
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
												rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
											}
										}
									}
									else
										rkqBaiHoc.Text += dt.TraLoiKHo != null ? Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong : Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
								}
							}
							if (itemdmc.DichKHoViets.Count >= 1)
								foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
									rkqBaiHoc.Text += kh.Viet != null ? Resources.tab_daungang + kh.KHo + Resources.tab+ Resources.tab+Resources.dau_cong + kh.Viet + xuong_dong : Resources.tab_daungang + kh.KHo + xuong_dong;
							if (itemdmc.DichVietKHoes.Count >= 1)
								foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
									rkqBaiHoc.Text += v.KHo != null ? Resources.tab_daungang + v.Viet + Resources.tab+ Resources.tab+Resources.dau_cong + v.KHo + xuong_dong : Resources.tab_daungang + v.Viet + xuong_dong;
							if (itemdmc.NguPhaps.Count >= 1)
								foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
									rkqBaiHoc.Text += Resources.tab + Resources.tab + tv.NoiDung + xuong_dong;
						}
					}
				}
			}
			else if (DanhMucConDao.Instance.KTDanhMucCon(name, id))
			{
				foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoadByName(name, id))
				{
					j++;
					rkqBaiHoc.Text += j+Resources.dau_cham + Resources.dau_cach + itemdmc.Ten + Resources.dau_cham + xuong_dong;
					if (itemdmc.IDAmThanh > 0)
					{
						btnAudio.Enabled = true;
						btnAudio.Tag = itemdmc;
					}
					if (itemdmc.BaiKhoas.Count >= 1)
					{
						foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
						{
							if (bk.NoiDung == null)
							{
								if (bk.HoiViet != null)
								{
									rkqBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
									rkqBaiHoc.Text += bk.TraLoiViet != null ? Resources.tab_daungang + bk.HoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiViet + xuong_dong : Resources.tab_daungang + bk.HoiViet + xuong_dong;
								}
								else
									rkqBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
							}
							else
								rkqBaiHoc.Text += Resources.tab + bk.NoiDung + xuong_dong;
						}
					}
					if (itemdmc.TuVungs.Count >= 1)
						foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
							rkqBaiHoc.Text += Resources.tab + tv.KHo + Resources.dau2chamvacach + tv.Viet + xuong_dong;
					if (itemdmc.DamThoais.Count >= 1)
					{
						foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
						{
							if (dt.CauHoiViet != null)
							{
								if (dt.TraLoiKHo != null)
								{
									if (dt.TraLoiViet != null)
									{
										rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
										rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiViet + xuong_dong;
									}
									else
									{
										rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
										rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
									}
								}
								else
								{
									if (dt.TraLoiViet != null)
									{
										rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
										rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiViet + xuong_dong;
									}
									else
									{
										rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
										rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
									}
								}
							}
							else
								rkqBaiHoc.Text += dt.TraLoiKHo != null ? Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong : Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
						}
					}
					if (itemdmc.DichKHoViets.Count >= 1)
						foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
							rkqBaiHoc.Text += kh.Viet != null ? Resources.tab_daungang + kh.KHo + Resources.tab+ Resources.tab+Resources.dau_cong + kh.Viet + xuong_dong : Resources.tab_daungang + kh.KHo + xuong_dong;
					if (itemdmc.DichVietKHoes.Count >= 1)
						foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
							rkqBaiHoc.Text += v.KHo != null ? Resources.tab_daungang + v.Viet + Resources.tab+ Resources.tab+Resources.dau_cong + v.KHo + xuong_dong : Resources.tab_daungang + v.Viet + xuong_dong;
					if (itemdmc.NguPhaps.Count >= 1)
						foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
							rkqBaiHoc.Text += Resources.tab + Resources.tab + tv.NoiDung + xuong_dong;
				}
			}
		}
		private void LoadBaiHoc(int iDBaiHoc)
		{
			lbViet.Text = "";
			lbKhoHay.Text = "";
			lbLHViet.Text = "";
			picBox.Image = null;
			if (_trangthaiam)
			{
				_trangthaiam = false;
				_sound.controls.stop();
				btnAudio.Text = Resources.nghe;
				btnAudio.Enabled = false;
			}
			btnRefresh.Enabled = false;
			lbcMucLuc.Items.Clear();//moi
			rkqBaiHoc.ResetText();
			rkqBaiHoc.Font = new Font("TNKeyUni-Arial", 11F);
			int soBai = BaiHocDao.Instance.BaiHocCounts();
			int j = 0;
			int i = 0;
			btnBack.Enabled = _iDBaiHoc > 1;
			btnNext.Enabled = _iDBaiHoc < soBai;
			foreach (BaiHoc item in BaiHocDao.Instance.LoadTenBai(iDBaiHoc))
			{
				if (item.TenViet != null && item.TenKHo != null)
				{
					lbViet.Text = "(" + item.TenViet + ")";
					lbTenBai.Text = Resources.bai + iDBaiHoc + Resources.dau2chamvacach + item.TenKHo;
				}
				else if (item.TenViet == null && item.TenKHo != null)
				{
					lbTenBai.Text = Resources.bai + iDBaiHoc + Resources.dau2chamvacach + item.TenKHo;
				}
				else if (item.TenViet != null && item.TenKHo == null)
					lbTenBai.Text = Resources.bai + iDBaiHoc + Resources.dau2chamvacach + item.TenViet;
				if (item.LoiHayYDeps.Count >= 1)
				{
					foreach (LoiHayYDep lh in LoiHayYDepDao.Instance.LoadHayYDeps(item.ID))
					{
						lbKhoHay.Text = lh.CauKHo;
						lbLHViet.Text = lh.CauViet;
					}
				}
				if (item.IDHinh > 0)
				{
					try
					{
						var hinh = HinhDao.Instance.LoadHinhs((int)item.IDHinh);
						_pictures = hinh.DuongDan;
						string filepath = Application.StartupPath;
						Image image = Image.FromFile(filepath + _pictures);
						picBox.Image = image;
					}
					catch (Exception)
					{
						picBox.Image = null;
					}
				}
			}

			foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoad(iDBaiHoc))
			{
				if (item.TenKHo == null)
				{
					foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						i++;
						lbcMucLuc.Items.Add(i+Resources.dau_cham + Resources.dau_cach + itemdmc.Ten);
					}
				}
				else
				{
					i++;
					lbcMucLuc.Items.Add(i+Resources.dau_cham + Resources.dau_cach + item.TenKHo);
				}
			}
			foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoad(iDBaiHoc))
			{
				j++;
				if (item.TenKHo != null)
				{
					rkqBaiHoc.Text += j+Resources.dau_cham + Resources.dau_cach + item.TenKHo + " - " + item.TenViet + xuong_dong;
					foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						rkqBaiHoc.Text += "\t* " + itemdmc.Ten + Resources.dau_cham + xuong_dong;
						if (itemdmc.BaiKhoas.Count >= 1)
						{
							foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
							{
								if (bk.NoiDung == null)
								{
									if (bk.HoiViet != null)
									{
										rkqBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
										rkqBaiHoc.Text += bk.TraLoiViet != null ? Resources.tab_daungang + bk.HoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiViet + xuong_dong : Resources.tab_daungang + bk.HoiViet + xuong_dong;
									}
									else
										rkqBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
								}
								else
									rkqBaiHoc.Text += Resources.tab + bk.NoiDung + xuong_dong;
							}
						}
						if (itemdmc.TuVungs.Count >= 1)
							foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
								rkqBaiHoc.Text += Resources.tab + Resources.tab + tv.KHo + Resources.dau2chamvacach + tv.Viet + xuong_dong;
						if (itemdmc.DamThoais.Count >= 1)
						{
							foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
							{
								if (dt.CauHoiViet != null)
								{
									if (dt.TraLoiKHo != null)
									{
										if (dt.TraLoiViet != null)
										{
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiViet + xuong_dong;
										}
										else
										{
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
										}
									}
									else
									{
										if (dt.TraLoiViet != null)
										{
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiViet + xuong_dong;
										}
										else
										{
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
										}
									}
								}
								else
									rkqBaiHoc.Text += dt.TraLoiKHo != null ? Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong : Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
							}
						}
						//Tới đây
						if (itemdmc.DichKHoViets.Count >= 1)
							foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
								rkqBaiHoc.Text += kh.Viet != null ? Resources.tab_daungang + kh.KHo + Resources.tab+ Resources.tab+Resources.dau_cong + kh.Viet + xuong_dong : Resources.tab_daungang + kh.KHo + xuong_dong;
						if (itemdmc.DichVietKHoes.Count >= 1)
							foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
								rkqBaiHoc.Text += v.KHo != null ? Resources.tab_daungang + v.Viet + Resources.tab+ Resources.tab+Resources.dau_cong + v.KHo + xuong_dong : Resources.tab_daungang + v.Viet + xuong_dong;
						if (itemdmc.CauHois.Count >= 1)
							foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
								rkqBaiHoc.Text += ch.TraLoi != null ? Resources.tab_daungang + ch.Hoi + Resources.tab+ Resources.tab+Resources.dau_cong + ch.TraLoi + xuong_dong : Resources.tab_daungang + ch.Hoi + xuong_dong;
						if (itemdmc.LuyenTaps.Count >= 1)
						{
							foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
							{
								if (lt.HoiKHo != null && lt.HoiViet != null)
								{
									if (lt.TraLoiKHo != null && lt.TraLoiViet != null)
									{
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + lt.TraLoiKHo + xuong_dong;
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + lt.TraLoiViet + xuong_dong;
									}
									else if (lt.TraLoiKHo != null && lt.TraLoiViet == null)
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiKHo + xuong_dong;
									else if (lt.TraLoiKHo == null && lt.TraLoiViet != null)
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiViet + xuong_dong;
									else
									{
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiKHo + xuong_dong;
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiViet + xuong_dong;
									}
								}
								else if (lt.HoiKHo != null && lt.HoiViet == null)
									rkqBaiHoc.Text += lt.TraLoiKHo != null ? Resources.tab_daungang + lt.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + lt.TraLoiKHo + xuong_dong : Resources.tab_daungang + lt.HoiKHo + xuong_dong;
								else if (lt.HoiKHo == null && lt.HoiViet != null)
									rkqBaiHoc.Text += lt.TraLoiViet != null ? Resources.tab_daungang + lt.HoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + lt.TraLoiViet + xuong_dong : Resources.tab_daungang + lt.HoiViet + xuong_dong;
							}
						}
						if (itemdmc.NguPhaps.Count >= 1)
							foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
								rkqBaiHoc.Text += Resources.tab + Resources.tab + tv.NoiDung + xuong_dong;
					}
				}
				else
				{
					j = j - 1;
					foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						j++;
						rkqBaiHoc.Text += j+Resources.dau_cham + Resources.dau_cach + itemdmc.Ten + Resources.dau_cham + xuong_dong;
						if (itemdmc.BaiKhoas.Count >= 1)
						{
							foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
							{
								if (bk.NoiDung == null)
								{
									if (bk.HoiViet != null)
									{
										rkqBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
										rkqBaiHoc.Text += bk.TraLoiViet != null ? Resources.tab_daungang + bk.HoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiViet + xuong_dong : Resources.tab_daungang + bk.HoiViet + xuong_dong;
									}
									else
										rkqBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
								}
								else
									rkqBaiHoc.Text += Resources.tab + bk.NoiDung + xuong_dong;
							}
						}
						if (itemdmc.TuVungs.Count >= 1)
							foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
								rkqBaiHoc.Text += Resources.tab + tv.KHo + Resources.dau2chamvacach + tv.Viet + xuong_dong;
						if (itemdmc.DamThoais.Count >= 1)
						{
							foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
							{
								if (dt.CauHoiViet != null)
								{
									if (dt.TraLoiKHo != null)
									{
										if (dt.TraLoiViet != null)
										{
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiViet + xuong_dong;
										}
										else
										{
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
										}
									}
									else
									{
										if (dt.TraLoiViet != null)
										{
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiViet + xuong_dong;
										}
										else
										{
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
											rkqBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
										}
									}
								}
								else
									rkqBaiHoc.Text += dt.TraLoiKHo != null ? Resources.tab_daungang + dt.CauHoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + dt.TraLoiKHo + xuong_dong : Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
							}
						}
						if (itemdmc.DichKHoViets.Count >= 1)
							foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
								rkqBaiHoc.Text += kh.Viet != null ? Resources.tab_daungang + kh.KHo + Resources.tab+ Resources.tab+Resources.dau_cong + kh.Viet + xuong_dong : Resources.tab_daungang + kh.KHo + xuong_dong;
						if (itemdmc.DichVietKHoes.Count >= 1)
							foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
								rkqBaiHoc.Text += v.KHo != null ? Resources.tab_daungang + v.Viet + Resources.tab+ Resources.tab+Resources.dau_cong + v.KHo + xuong_dong : Resources.tab_daungang + v.Viet + xuong_dong;
						if (itemdmc.CauHois.Count >= 1)
							foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
								rkqBaiHoc.Text += ch.TraLoi != null ? Resources.tab_daungang + ch.Hoi + Resources.tab+ Resources.tab+Resources.dau_cong + ch.TraLoi + xuong_dong : Resources.tab_daungang + ch.Hoi + xuong_dong;
						if (itemdmc.LuyenTaps.Count >= 1)
						{
							foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
							{
								if (lt.HoiKHo != null && lt.HoiViet != null)
								{
									if (lt.TraLoiKHo != null && lt.TraLoiViet != null)
									{
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + lt.TraLoiKHo + xuong_dong;
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + lt.TraLoiViet + xuong_dong;
									}
									else if (lt.TraLoiKHo != null && lt.TraLoiViet == null)
									{
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiKHo + xuong_dong;
									}
									else if (lt.TraLoiKHo == null && lt.TraLoiViet != null)
									{
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiViet + xuong_dong;
									}
									else
									{
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiKHo + xuong_dong;
										rkqBaiHoc.Text += Resources.tab_daungang + lt.HoiViet + xuong_dong;
									}
								}
								else if (lt.HoiKHo != null && lt.HoiViet == null)
									rkqBaiHoc.Text += lt.TraLoiKHo != null ? Resources.tab_daungang + lt.HoiKHo + Resources.tab+ Resources.tab+Resources.dau_cong + lt.TraLoiKHo + xuong_dong : Resources.tab_daungang + lt.HoiKHo + xuong_dong;
								else if (lt.HoiKHo == null && lt.HoiViet != null)
									rkqBaiHoc.Text += lt.TraLoiViet != null ? Resources.tab_daungang + lt.HoiViet + Resources.tab+ Resources.tab+Resources.dau_cong + lt.TraLoiViet + xuong_dong : Resources.tab_daungang + lt.HoiViet + xuong_dong;
							}
						}
						if (itemdmc.NguPhaps.Count >= 1)
							foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID)) rkqBaiHoc.Text += Resources.tab + Resources.tab + tv.NoiDung + xuong_dong;
					}
				}

			}
		}
		void LoadAmThanh(string dgdan)
		{
			_sound = new WindowsMediaPlayer();
			_sound.URL = dgdan;
			if (_trangthaiam)
			{
				_trangthaiam = false;
				_sound.controls.stop();
			}
			else
			{
				_trangthaiam = true;
				_sound.controls.play();
			}
		}
		#endregion
		#region event
		private void btnClose_Click(object sender, EventArgs e)
		{
			if (_trangthaiam)
			{
				_trangthaiam = false;
				_sound.controls.stop();
				btnAudio.Text = Resources.nghe;
			}
			Close();
		}
		private void FrmBaiHocChiTiet_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (XtraMessageBox.Show("Bạn có muốn đóng bài học không?", Resources.thong_bao, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
				e.Cancel = true;
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
			if (f != null) f.Close();
			_last = _iDBaiHoc - 1;
			if (_last <= 1) _last = 1;
			_iDBaiHoc = _last;
			Text = Resources.bai_so + _last;
			LoadBaiHoc(_last);
		}
		private void btnNext_Click(object sender, EventArgs e)
		{
			FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
			if (f != null)
				f.Close();
			_next = _iDBaiHoc + 1;
			_iDBaiHoc = _next;
			Text = Resources.bai_so + _next;
			LoadBaiHoc(_next);

		}
		private void lbcMucLuc_Click(object sender, EventArgs e)
		{
			btnRefresh.Enabled = true;
			if (_trangthaiam)
			{
				_trangthaiam = false;
				_sound.controls.stop();
				btnAudio.Text = Resources.nghe;
			}
			string tukhoa = lbcMucLuc.SelectedItem.ToString();
			int id = 0;
			string str = tukhoa.Substring(0, tukhoa.LastIndexOf('.'));
			string subStringItem = tukhoa.Substring(str.Length + 2);
			foreach (var dm in DanhMucDao.Instance.DanhMucLoad(_iDBaiHoc))
			{
				if (dm.TenKHo != null && dm.TenKHo == subStringItem)
					id = dm.ID;
				else
					foreach (var dmc in DanhMucConDao.Instance.DanhMucConLoad(dm.ID)) if (dmc.Ten == subStringItem) id = dmc.ID;
			}
			if (subStringItem == "Câu hỏi")
			{
				FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
				if (f != null)
					XtraMessageBox.Show("Bạn đã mở câu hỏi!", Resources.dau2chamvacach, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					f = new FrmExercise(_iDBaiHoc);
					f.Text = "Câu hỏi của bài học số " + _iDBaiHoc;
					f.Show();
				}
			}
			else if (subStringItem == "Luyện tập")
			{
				FrmLuyenTap f = Application.OpenForms.OfType<FrmLuyenTap>().FirstOrDefault();
				if (f != null)
					XtraMessageBox.Show("Bạn đã mở luyện tập!", Resources.dau2chamvacach, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					f = new FrmLuyenTap(_iDBaiHoc);
					f.Text = "Luyện tập của bài học số " + _iDBaiHoc;
					f.Show();
				}
			}
			else
				LoadDanhMucTheoTen(subStringItem, id);
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
			if (f != null) f.Close();
			btnRefresh.Enabled = false;
			LoadBaiHoc(_iDBaiHoc);
		}
		private void btnDictionary_Click(object sender, EventArgs e)
		{
			if (_trangthaiam)
			{
				_trangthaiam = false;
				_sound.controls.stop();
				btnAudio.Text = Resources.nghe;
			}
			FrmDictionary f = Application.OpenForms.OfType<FrmDictionary>().FirstOrDefault();
			if (f != null)
				XtraMessageBox.Show("Bạn đã mở tử điển!", Resources.dau2chamvacach, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				f = new FrmDictionary();
				f.Show();
			}
		}
		private void btnAudio_Click(object sender, EventArgs e)
		{
			if (btnAudio.Text == Resources.nghe)
			{
				btnAudio.Text = Resources.stop;
				SimpleButton simpleButton = sender as SimpleButton;
				if (simpleButton != null)
				{
					DanhMucCon dmc = (simpleButton.Tag as DanhMucCon);
					var am = AmThanhDao.Instance.LoadAmThanhs(dmc.IDAmThanh);
					string filepath = Application.StartupPath;
					LoadAmThanh(filepath + am.DuongDan);
				}
			}
			else
			{
				btnAudio.Text = Resources.nghe;
				if (_trangthaiam)
				{
					_trangthaiam = false;
					_sound.controls.stop();
				}
			}
		}
		#endregion








	}
}