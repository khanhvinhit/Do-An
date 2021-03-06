﻿using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
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
		private string _pictures = "";
		private string xuong_dong = "\n";
		private int _next;
		private int _last;
		private WindowsMediaPlayer _sound;
		private bool _trangthaiam;

		public int IdBaiHoc
		{
			get { return _iDBaiHoc; }
			set
			{
				_iDBaiHoc = value;
				LoadBaiHoc(_iDBaiHoc);
			}
		}

		public FrmBaiHocChiTiet(int iDBaiHoc)
		{
			InitializeComponent();
			IdBaiHoc = iDBaiHoc;
		}

		#region method

		private void LoadDanhMucTheoTen(string name, int id)
		{
			recBaiHoc.Dock = DockStyle.None;
			recBaiHoc.Size = new Size(pnPicChude.Width, pnPicChude.Height - (lbTiengViet.Height + recTiengViet.Height + 10));
			recBaiHoc.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
			recBaiHoc.ResetText();
			recBaiHoc.Font = new Font("TNKeyUni-Arial", 11F);
			recTiengViet.ResetText();
			recTiengViet.Font = new Font("TNKeyUni-Arial", 11F);
			int j = 0;
			if (DanhMucDao.Instance.KTDanhMuc(name, id))
			{
				foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoadByName(name, id))
				{
					j++;
					if (item.TenKHo != null)
					{
						lbMucLuc.Text = Resources.dau_cach + item.TenKHo + " - " + item.TenViet;
						foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
						{
							recBaiHoc.Text += "\t* " + itemdmc.Ten + Resources.dau_cham + xuong_dong;
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
											recBaiHoc.Text += bk.TraLoiKHo != null
												? "- " + bk.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiKHo + xuong_dong
												: recBaiHoc.Text += "- " + bk.HoiKHo + xuong_dong;
											recTiengViet.Text += bk.TraLoiViet != null
												? "- " + bk.HoiViet + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiViet + xuong_dong
												: recBaiHoc.Text += "- " + bk.HoiViet + xuong_dong;
										}
										else
											recBaiHoc.Text += bk.TraLoiKHo != null
												? "- " + bk.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiKHo + xuong_dong
												: recBaiHoc.Text += "- " + bk.HoiKHo + xuong_dong;
									}
									else
									{
										recBaiHoc.Text += bk.NoiDung + xuong_dong;
										recTiengViet.Text += bk.TraLoiViet + xuong_dong;
									}

								}
							}
							if (itemdmc.TuVungs.Count >= 1)
								foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
									recBaiHoc.Text += Resources.tab + tv.KHo + Resources.dau2chamvacach + tv.Viet + xuong_dong;
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
												recBaiHoc.Text += "- " + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + " " + dt.TraLoiKHo +
																  xuong_dong;
												recTiengViet.Text += "- " + dt.CauHoiViet + Resources.tab + Resources.tab + Resources.dau_cong + " " + dt.TraLoiViet +
																  xuong_dong;
											}
											else
											{
												recBaiHoc.Text += "- " + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo +
																  xuong_dong;
												recTiengViet.Text += "- " + dt.CauHoiViet + xuong_dong;
											}
										}
										else
										{
											if (dt.TraLoiViet != null)
											{
												recBaiHoc.Text += "- " + dt.CauHoiKHo + xuong_dong;
												recTiengViet.Text += "- " + dt.CauHoiViet + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiViet +
																  xuong_dong;
											}
											else
											{
												recBaiHoc.Text += "- " + dt.CauHoiKHo + xuong_dong;
												recTiengViet.Text += "- " + dt.CauHoiViet + xuong_dong;
											}
										}
									}
									else
									{
										recBaiHoc.Text += dt.TraLoiKHo != null
											? "- " + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo + xuong_dong
											: "- " + dt.CauHoiKHo + xuong_dong;
									}
								}
							}
							if (itemdmc.DichKHoViets.Count >= 1)
							{
								foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
								{
									recBaiHoc.Text += Resources.tab + kh.KHo + xuong_dong + xuong_dong;
									if (kh.Viet != null)
									{
										recTiengViet.Text += Resources.tab + kh.Viet + xuong_dong + xuong_dong;
									}

								}
							}
							if (itemdmc.DichVietKHoes.Count >= 1)
								foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
								{
									recBaiHoc.Text += Resources.tab + v.Viet + xuong_dong;
									if (v.KHo != null)
									{
										recTiengViet.Text += Resources.tab + v.KHo + xuong_dong;
									}
								}


							if (itemdmc.NguPhaps.Count >= 1)
								foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
								{
									if (tv.NoiDung.Substring(0, 1) == "*")
									{
										recBaiHoc.Text += "\n";
										recBaiHoc.Text += tv.NoiDung + "\n";
									}
									else
									{
										recBaiHoc.Text += Resources.tab + tv.NoiDung + "\n";
									}
								}
						}
					}
					else
					{
						j = j - 1;
						foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
						{
							j++;
							//mục lục
							lbMucLuc.Text = Resources.dau_cach + itemdmc.Ten + Resources.dau_cham;
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
											recBaiHoc.Text += bk.TraLoiKHo != null
												? "- " + bk.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiKHo + xuong_dong
												: "- " + bk.HoiKHo + xuong_dong;
											recTiengViet.Text += bk.TraLoiViet != null
												? "- " + bk.HoiViet + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiViet + xuong_dong
												: "- " + bk.HoiViet + xuong_dong;
										}
										else
											recBaiHoc.Text += bk.TraLoiKHo != null
												? "- " + bk.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiKHo + xuong_dong
												: "- " + bk.HoiKHo + xuong_dong;
									}
									else
									{
										recBaiHoc.Text += bk.NoiDung + xuong_dong;
										recTiengViet.Text += bk.TraLoiViet + xuong_dong;
									}
								}
							}
							if (itemdmc.TuVungs.Count >= 1)
								foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
									recBaiHoc.Text += Resources.tab + tv.KHo + Resources.dau2chamvacach + tv.Viet + xuong_dong;
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
												recBaiHoc.Text += "- " + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + " " + dt.TraLoiKHo +
																  xuong_dong;
												recTiengViet.Text += "- " + dt.CauHoiViet + Resources.tab + Resources.tab + Resources.dau_cong + " " + dt.TraLoiViet +
																  xuong_dong;
											}
											else
											{
												recBaiHoc.Text += "- " + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo +
																  xuong_dong;
												recTiengViet.Text += "- " + dt.CauHoiViet + xuong_dong;
											}
										}
										else
										{
											if (dt.TraLoiViet != null)
											{
												recBaiHoc.Text += "- " + dt.CauHoiKHo + xuong_dong;
												recTiengViet.Text += "- " + dt.CauHoiViet + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiViet +
																  xuong_dong;
											}
											else
											{
												recBaiHoc.Text += "- " + dt.CauHoiKHo + xuong_dong;
												recTiengViet.Text += "- " + dt.CauHoiViet + xuong_dong;
											}
										}
									}
									else
									{
										recBaiHoc.Text += dt.TraLoiKHo != null
											? "- " + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo + xuong_dong
											: "- " + dt.CauHoiKHo + xuong_dong;
									}
								}
							}
							if (itemdmc.DichKHoViets.Count >= 1)
								foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
								{
									recBaiHoc.Text += Resources.tab + kh.KHo + xuong_dong + xuong_dong;
									if (kh.Viet != null)
									{
										recTiengViet.Text += Resources.tab + kh.Viet + xuong_dong + xuong_dong;
									}
								}
							if (itemdmc.DichVietKHoes.Count >= 1)
								foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
								{
									recBaiHoc.Text += Resources.tab + v.Viet + xuong_dong;
									if (v.KHo != null)
									{
										recTiengViet.Text += Resources.tab + v.KHo + xuong_dong;
									}
								}
							if (itemdmc.NguPhaps.Count >= 1)
								foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
								{
									if (tv.NoiDung.Substring(0, 1) == "*")
									{
										recBaiHoc.Text += "\n";
										recBaiHoc.Text += tv.NoiDung + "\n";
									}
									else
									{
										recBaiHoc.Text += Resources.tab + tv.NoiDung + "\n";
									}
								}
						}
					}
				}
			}
			else if (DanhMucConDao.Instance.KTDanhMucCon(name, id))
			{
				foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoadByName(name, id))
				{
					j++;
					lbMucLuc.Text = Resources.dau_cach + itemdmc.Ten + Resources.dau_cham;
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
									recBaiHoc.Text += bk.TraLoiKHo != null
										? "- " + bk.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiKHo + xuong_dong
										: "- " + bk.HoiKHo + xuong_dong;
									recTiengViet.Text += bk.TraLoiViet != null
										? "- " + bk.HoiViet + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiViet + xuong_dong
										: "- " + bk.HoiViet + xuong_dong;
								}
								else
									recBaiHoc.Text += bk.TraLoiKHo != null
										? "- " + bk.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiKHo + xuong_dong
										: "- " + bk.HoiKHo + xuong_dong;
							}
							else
							{
								recBaiHoc.Text += bk.NoiDung + xuong_dong;
								recTiengViet.Text += bk.TraLoiViet + xuong_dong;
							}
						}
					}
					if (itemdmc.TuVungs.Count >= 1)
						foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
							recBaiHoc.Text += Resources.tab + tv.KHo + Resources.dau2chamvacach + tv.Viet + xuong_dong;
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
										recBaiHoc.Text += "- " + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo +
														  xuong_dong;
										recTiengViet.Text += "- " + dt.CauHoiViet + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiViet +
														  xuong_dong;
									}
									else
									{
										recBaiHoc.Text += "- " + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo +
														  xuong_dong;
										recTiengViet.Text += "- " + dt.CauHoiViet + xuong_dong;
									}
								}
								else
								{
									if (dt.TraLoiViet != null)
									{
										recBaiHoc.Text += "- " + dt.CauHoiKHo + xuong_dong;
										recTiengViet.Text += "- " + dt.CauHoiViet + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiViet +
														  xuong_dong;
									}
									else
									{
										recBaiHoc.Text += "- " + dt.CauHoiKHo + xuong_dong;
										recTiengViet.Text += "- " + dt.CauHoiViet + xuong_dong;
									}
								}
							}
							else
								recBaiHoc.Text += dt.TraLoiKHo != null
									? "- " + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo + xuong_dong
									: "- " + dt.CauHoiKHo + xuong_dong;
						}
					}
					if (itemdmc.DichKHoViets.Count >= 1)
						foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
						{
							recBaiHoc.Text += Resources.tab + kh.KHo + xuong_dong + xuong_dong;
							if (kh.Viet != null)
							{
								recTiengViet.Text += Resources.tab + kh.Viet + xuong_dong + xuong_dong;
							}
						}
					if (itemdmc.DichVietKHoes.Count >= 1)
						foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
						{
							recBaiHoc.Text += Resources.tab + v.Viet + xuong_dong;
							if (v.KHo != null)
							{
								recTiengViet.Text += Resources.tab + v.KHo + xuong_dong;
							}
						}
					if (itemdmc.NguPhaps.Count >= 1)
						foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
						{
							if (tv.NoiDung.Substring(0, 1) == "*")
							{
								recBaiHoc.Text += "\n";
								recBaiHoc.Text += tv.NoiDung + "\n";
							}
							else
							{
								recBaiHoc.Text += Resources.tab + tv.NoiDung + "\n";
							}
						}
				}
			}
		}

		private void LoadBaiHoc(int iDBaiHoc)
		{
			picBai.Visible = false;
			picChuDe.Image = null;
			lbViet.Text = "";
			lbKhoHay.Text = "";
			lbLHViet.Text = "";
			lbMucLuc.Text = "";
			btnAudio.Enabled = false;
			if (_trangthaiam)
			{
				_trangthaiam = false;
				_sound.controls.stop();
				btnAudio.Text = Resources.nghe;
			}
			lbcMucLuc.Items.Clear(); //moi
			recBaiHoc.ResetText();
			recBaiHoc.Font = new Font("TNKeyUni-Arial", 11F);
			int soBai = BaiHocDao.Instance.BaiHocCounts();
			btnBack.Enabled = _iDBaiHoc > 1;
			btnNext.Enabled = _iDBaiHoc < soBai;
			int j = 0;
			int i = 0;
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
						picChuDe.Visible = true;
						var hinh = HinhDao.Instance.LoadHinhs((int)item.IDHinh);
						_pictures = hinh.DuongDan;
						string filepath = Application.StartupPath;
						Image image = Image.FromFile(filepath + _pictures);
						picChuDe.Image = image;
					}
					catch (Exception)
					{
						picChuDe.Image = null;
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
						lbcMucLuc.Items.Add(i + Resources.dau_cham + Resources.dau_cach + itemdmc.Ten);
					}
				}
				else
				{
					i++;
					lbcMucLuc.Items.Add(i + Resources.dau_cham + Resources.dau_cach + item.TenKHo);
				}
			}
		}
		private void LoadTatcaBaiHoc(int iDBaiHoc)
		{
			recBaiHoc.Dock = DockStyle.Fill;
			picAnimator.ShowSync(recBaiHoc);
			lbMucLuc.Text = "";
			btnAudio.Enabled = false;
			if (_trangthaiam)
			{
				_trangthaiam = false;
				_sound.controls.stop();
				btnAudio.Text = Resources.nghe;
			}
			recBaiHoc.ResetText();
			recBaiHoc.Font = new Font("TNKeyUni-Arial", 11F);
			int j = 0;
			int i = 0;
			foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoad(iDBaiHoc))
			{
				j++;
				if (item.TenKHo != null)
				{
					recBaiHoc.Text += j + Resources.dau_cham + Resources.dau_cach + item.TenKHo + " - " + item.TenViet + xuong_dong;
					foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						recBaiHoc.Text += "\t* " + itemdmc.Ten + Resources.dau_cham + xuong_dong;
						if (itemdmc.BaiKhoas.Count >= 1)
						{
							foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
							{
								if (bk.NoiDung == null)
								{
									if (bk.HoiViet != null)
									{
										recBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
										recBaiHoc.Text += bk.TraLoiViet != null ? Resources.tab_daungang + bk.HoiViet + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiViet + xuong_dong : Resources.tab_daungang + bk.HoiViet + xuong_dong;
									}
									else
										recBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
								}
								else
								{
									recBaiHoc.Text += bk.NoiDung + xuong_dong;
								}
							}
						}
						if (itemdmc.TuVungs.Count >= 1)
							foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
								recBaiHoc.Text += Resources.tab + Resources.tab + tv.KHo + Resources.dau2chamvacach + tv.Viet + xuong_dong;
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
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiViet + xuong_dong;
										}
										else
										{
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
										}
									}
									else
									{
										if (dt.TraLoiViet != null)
										{
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiViet + xuong_dong;
										}
										else
										{
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
										}
									}
								}
								else
									recBaiHoc.Text += dt.TraLoiKHo != null ? Resources.tab_daungang + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo + xuong_dong : Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
							}
						}
						//Tới đây
						if (itemdmc.DichKHoViets.Count >= 1)
							foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
								recBaiHoc.Text += kh.Viet != null
									? Resources.tab + kh.KHo + xuong_dong + xuong_dong + kh.Viet + xuong_dong
										: Resources.tab + kh.KHo + xuong_dong + xuong_dong;
						if (itemdmc.DichVietKHoes.Count >= 1)
							foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
								recBaiHoc.Text += v.KHo != null
									? Resources.tab + v.Viet + xuong_dong + xuong_dong + Resources.tab + v.KHo + xuong_dong
									: Resources.tab + v.Viet + xuong_dong;
						if (itemdmc.CauHois.Count >= 1)
							foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
								recBaiHoc.Text += ch.TraLoi != null ? Resources.tab_daungang + ch.Hoi + Resources.tab + Resources.tab + Resources.dau_cong + ch.TraLoi + xuong_dong : Resources.tab_daungang + ch.Hoi + xuong_dong;
						if (itemdmc.LuyenTaps.Count >= 1)
						{
							foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
							{
								if (lt.HoiKHo != null && lt.HoiViet != null)
								{
									if (lt.TraLoiKHo != null)
									{
										recBaiHoc.Text += Resources.tab + lt.HoiViet + xuong_dong;
										recBaiHoc.Text += Resources.tab_daungang + lt.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + lt.TraLoiKHo + xuong_dong;
									}
									else if (lt.TraLoiKHo == null)
									{
										recBaiHoc.Text += Resources.tab + lt.HoiViet + xuong_dong;
										recBaiHoc.Text += Resources.tab_daungang + lt.HoiKHo + xuong_dong;
									}
								}
								else if (lt.HoiKHo != null && lt.HoiViet == null)
									recBaiHoc.Text += lt.TraLoiKHo != null ? Resources.tab_daungang + lt.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + lt.TraLoiKHo + xuong_dong : Resources.tab_daungang + lt.HoiKHo + xuong_dong;
								else if (lt.HoiKHo == null && lt.HoiViet != null)
									recBaiHoc.Text += Resources.tab + lt.HoiViet + xuong_dong;
							}
						}
						if (itemdmc.NguPhaps.Count >= 1)
							foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
							{
								if (tv.NoiDung.Substring(0, 1) == "*")
								{
									recBaiHoc.Text += "\n";
									recBaiHoc.Text += Resources.tab + tv.NoiDung + "\n";
								}
								else
								{
									recBaiHoc.Text += Resources.tab + Resources.tab + tv.NoiDung + "\n";
								}
							}
					}
				}
				else
				{
					j = j - 1;
					foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						j++;
						recBaiHoc.Text += j + Resources.dau_cham + Resources.dau_cach + itemdmc.Ten + Resources.dau_cham + xuong_dong;
						if (itemdmc.BaiKhoas.Count >= 1)
						{
							foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
							{
								if (bk.NoiDung == null)
								{
									if (bk.HoiViet != null)
									{
										recBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
										recBaiHoc.Text += bk.TraLoiViet != null ? Resources.tab_daungang + bk.HoiViet + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiViet + xuong_dong : Resources.tab_daungang + bk.HoiViet + xuong_dong;
									}
									else
										recBaiHoc.Text += bk.TraLoiKHo != null ? Resources.tab_daungang + bk.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + bk.TraLoiKHo + xuong_dong : Resources.tab_daungang + bk.HoiKHo + xuong_dong;
								}
								else
								{
									recBaiHoc.Text += bk.NoiDung + xuong_dong;
								}
							}
						}
						if (itemdmc.TuVungs.Count >= 1)
							foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
								recBaiHoc.Text += Resources.tab + tv.KHo + Resources.dau2chamvacach + tv.Viet + xuong_dong;
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
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiViet + xuong_dong;
										}
										else
										{
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo + xuong_dong;
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
										}
									}
									else
									{
										if (dt.TraLoiViet != null)
										{
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiViet + xuong_dong;
										}
										else
										{
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
											recBaiHoc.Text += Resources.tab_daungang + dt.CauHoiViet + xuong_dong;
										}
									}
								}
								else
									recBaiHoc.Text += dt.TraLoiKHo != null ? Resources.tab_daungang + dt.CauHoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + dt.TraLoiKHo + xuong_dong : Resources.tab_daungang + dt.CauHoiKHo + xuong_dong;
							}
						}
						if (itemdmc.DichKHoViets.Count >= 1)
							foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
								recBaiHoc.Text += kh.Viet != null
									? Resources.tab + kh.KHo + xuong_dong + xuong_dong + kh.Viet + xuong_dong
										: Resources.tab + kh.KHo + xuong_dong + xuong_dong;
						if (itemdmc.DichVietKHoes.Count >= 1)
							foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
								recBaiHoc.Text += v.KHo != null
									? Resources.tab + v.Viet + xuong_dong + xuong_dong + Resources.tab + v.KHo + xuong_dong
									: Resources.tab + v.Viet + xuong_dong;
						if (itemdmc.CauHois.Count >= 1)
							foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
								recBaiHoc.Text += ch.TraLoi != null ? Resources.tab_daungang + ch.Hoi + Resources.tab + Resources.tab + Resources.dau_cong + ch.TraLoi + xuong_dong : Resources.tab_daungang + ch.Hoi + xuong_dong;
						if (itemdmc.LuyenTaps.Count >= 1)
						{
							if (itemdmc.LuyenTaps.Count >= 1)
							{
								foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
								{
									if (lt.HoiKHo != null && lt.HoiViet != null)
									{

										if (lt.TraLoiKHo != null)
										{
											recBaiHoc.Text += Resources.tab + lt.HoiViet + xuong_dong;
											recBaiHoc.Text += Resources.tab_daungang + lt.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + lt.TraLoiKHo + xuong_dong;
										}
										else if (lt.TraLoiKHo == null)
										{
											recBaiHoc.Text += Resources.tab + lt.HoiViet + xuong_dong;
											recBaiHoc.Text += Resources.tab_daungang + lt.HoiKHo + xuong_dong;
										}
									}
									else if (lt.HoiKHo != null && lt.HoiViet == null)
										recBaiHoc.Text += lt.TraLoiKHo != null ? Resources.tab_daungang + lt.HoiKHo + Resources.tab + Resources.tab + Resources.dau_cong + lt.TraLoiKHo + xuong_dong : Resources.tab_daungang + lt.HoiKHo + xuong_dong;
									else if (lt.HoiKHo == null && lt.HoiViet != null)
										recBaiHoc.Text += Resources.tab + lt.HoiViet + xuong_dong;
								}
							}
						}
						if (itemdmc.NguPhaps.Count >= 1)
							foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
							{
								if (tv.NoiDung.Substring(0, 1) == "*")
								{
									recBaiHoc.Text += "\n";
									recBaiHoc.Text += Resources.tab + tv.NoiDung + "\n";
								}
								else
								{
									recBaiHoc.Text += Resources.tab + Resources.tab + tv.NoiDung + "\n";
								}
							}
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
			else
			{
				FrmDictionary frmD = Application.OpenForms.OfType<FrmDictionary>().FirstOrDefault();
				if (frmD != null) frmD.Close();
				FrmLuyenTap frmL = Application.OpenForms.OfType<FrmLuyenTap>().FirstOrDefault();
				if (frmL != null) frmL.Close();
				FrmExercise frmC = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
				if (frmC != null) frmC.Close();
			}
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			pnPic.Controls.Remove(picChuDe);
			pnPicChude.Controls.Add(picChuDe);
			picChuDe.BringToFront();
			picChuDe.Dock = DockStyle.Fill;
			picAnimator.ShowSync(picChuDe);
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
			pnPic.Controls.Remove(picChuDe);
			pnPicChude.Controls.Add(picChuDe);
			picChuDe.BringToFront();
			picChuDe.Dock = DockStyle.Fill;
			picAnimator.ShowSync(picChuDe);
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
			picBai.Visible = false;
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
			if (subStringItem == "Câu hỏi")
			{
				FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
				if (f != null)
					XtraMessageBox.Show("Bạn đã mở câu hỏi! Xin hãy kiểm tra cửa sổ chương trình!", Resources.thong_bao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
					XtraMessageBox.Show("Bạn đã mở luyện tập! Xin hãy kiểm tra cửa sổ chương trình!", Resources.thong_bao,
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					f = new FrmLuyenTap(_iDBaiHoc);
					f.Text = "Luyện tập của bài học số " + _iDBaiHoc;
					f.Show();
				}
			}
			else
			{
				foreach (var dm in DanhMucDao.Instance.DanhMucLoad(_iDBaiHoc))
				{
					pnPic.Controls.Add(picChuDe);
					picChuDe.BringToFront();
					picChuDe.Dock = DockStyle.Fill;
					picAnimator.ShowSync(picChuDe);
					if (dm.TenKHo != null && dm.TenKHo == subStringItem)
					{
						id = dm.ID;
					}
					else if (subStringItem == "Bảng chữ cái")
					{
						try
						{
							picBai.Visible = true;
							string filepath = Application.StartupPath;
							Image image = Image.FromFile(filepath + "\\App_Data\\Images\\bangchucai.jpg");
							picBai.Image = image;
							pnPicChude.Controls.Add(picBai);
							picBai.BringToFront();
							picBai.Dock = DockStyle.Fill;
							picAnimator.ShowSync(picBai);
						}
						catch (Exception)
						{
							picChuDe.Image = null;
						}
					}
					else
					{
						foreach (var dmc in DanhMucConDao.Instance.DanhMucConLoad(dm.ID))
							if (dmc.Ten == subStringItem) id = dmc.ID;
					}

				}
				LoadDanhMucTheoTen(subStringItem, id);
			}

		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			pnPic.Controls.Add(picChuDe);
			picChuDe.BringToFront();
			picChuDe.Dock = DockStyle.Fill;
			picAnimator.ShowSync(picChuDe);
			FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
			if (f != null) f.Close();
			LoadTatcaBaiHoc(_iDBaiHoc);
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
				XtraMessageBox.Show("Bạn đã mở tử điển! Xin hãy kiểm tra cửa sổ chương trình!", Resources.thong_bao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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