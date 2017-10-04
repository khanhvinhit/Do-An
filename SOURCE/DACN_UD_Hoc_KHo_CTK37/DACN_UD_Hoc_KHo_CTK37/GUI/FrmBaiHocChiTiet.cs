using System;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DevExpress.XtraEditors;
using System.IO;
using System.Linq;
using WMPLib;

namespace DACN_UD_Hoc_KHo_CTK37
{
	public partial class FrmBaiHocChiTiet : XtraForm
	{
		private int _iDBaiHoc;
		string _pictures = "";
		private int _next;
		private int _last;
		private WindowsMediaPlayer sound;
		private bool trangthaiam = false;
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
		void LoadDanhMucTheoTen(string name, int id)
		{
			picBox.Image = null;
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
						rkqBaiHoc.Text += j + ". " + item.TenKHo + " - " + item.TenViet + "\n";
						foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
						{
							rkqBaiHoc.Text += "\t* " + itemdmc.Ten + ".\n";
							if (itemdmc.IDAmThanh > 0)
							{
								btnAudio.Enabled = true;
								if (itemdmc.IDAmThanh > 0)
								{
									btnAudio.Enabled = true;
								}
							}
							if (itemdmc.BaiKhoas.Count >= 1)
							{
								foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
								{
									if (bk.NoiDung == null)
									{
										if (bk.HoiViet != null)
										{
											if (bk.TraLoiKHo != null)
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";

											}
											else
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\n";
											}
											if (bk.TraLoiViet != null)
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\t\t+ " + bk.TraLoiViet + "\n";
											}
											else
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\n";
											}

										}
										else
										{
											if (bk.TraLoiKHo != null)
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";

											}
											else
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\n";
											}
										}
									}
									else
									{
										rkqBaiHoc.Text += "\t" + bk.NoiDung + "\n";
									}
								}
							}
							if (itemdmc.TuVungs.Count >= 1)
							{
								foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
								{
									rkqBaiHoc.Text += "\t\t" + tv.KHo + ": " + tv.Viet + "\n";
								}

							}
							if (itemdmc.DamThoais.Count >= 1)
							{
								foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
								{
									if (dt.CauHoiViet != null)
									{
										rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
										rkqBaiHoc.Text += "\t- " + dt.CauHoiViet + "\t\t+ " + dt.TraLoiViet + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
									}
								}
							}
							if (itemdmc.DichKHoViets.Count >= 1)
							{
								foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
								{
									if (kh.Viet != null)
									{
										rkqBaiHoc.Text += "\t- " + kh.KHo + "\t\t+ " + kh.Viet + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + kh.KHo + "\n";
									}
								}
							}
							if (itemdmc.DichVietKHoes.Count >= 1)
							{
								foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
								{
									if (v.KHo != null)
									{
										rkqBaiHoc.Text += "\t- " + v.Viet + "\t\t+ " + v.KHo + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + v.Viet + "\n";
									}
								}
							}
							//if (itemdmc.LuyenTaps.Count >= 1)
							//{
							//	foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
							//	{
							//		if (lt.HoiKHo != null && lt.HoiViet != null)
							//		{
							//			if (lt.TraLoiKHo != null && lt.TraLoiViet != null)
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
							//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n";
							//			}
							//			else if (lt.TraLoiKHo != null && lt.TraLoiViet == null)
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
							//			}
							//			else if (lt.TraLoiKHo == null && lt.TraLoiViet != null)
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
							//			}
							//			else
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
							//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
							//			}
							//		}
							//		else if (lt.HoiKHo != null && lt.HoiViet == null)
							//		{
							//			if (lt.TraLoiKHo != null)
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
							//			}
							//			else
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
							//			}
							//		}
							//		else if (lt.HoiKHo == null && lt.HoiViet != null)
							//		{
							//			if (lt.TraLoiViet != null)
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n";
							//			}
							//			else
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
							//			}
							//		}
							//	}
							//}
							if (itemdmc.NguPhaps.Count >= 1)
							{
								foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
								{
									rkqBaiHoc.Text += "\t\t" + tv.NoiDung + "\n";
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
							rkqBaiHoc.Text += j + ". " + itemdmc.Ten + ".\n";
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
											if (bk.TraLoiKHo != null)
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";

											}
											else
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\n";
											}
											if (bk.TraLoiViet != null)
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\t\t+ " + bk.TraLoiViet + "\n";
											}
											else
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\n";
											}
										}
										else
										{
											if (bk.TraLoiKHo != null)
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";

											}
											else
											{
												rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\n";
											}
										}
										//
									}
									else
									{
										rkqBaiHoc.Text += "\t" + bk.NoiDung + "\n";
									}
								}
							}
							if (itemdmc.TuVungs.Count >= 1)
							{
								foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
								{
									rkqBaiHoc.Text += "\t" + tv.KHo + ": " + tv.Viet + "\n";
								}
							}
							if (itemdmc.DamThoais.Count >= 1)
							{
								foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
								{
									if (dt.CauHoiViet != null)
									{
										rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
										rkqBaiHoc.Text += "\t- " + dt.CauHoiViet + "\t\t+ " + dt.TraLoiViet + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
									}
								}
							}
							if (itemdmc.DichKHoViets.Count >= 1)
							{
								foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
								{
									if (kh.Viet != null)
									{
										rkqBaiHoc.Text += "\t- " + kh.KHo + "\t\t+ " + kh.Viet + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + kh.KHo + "\n";
									}
								}
							}
							if (itemdmc.DichVietKHoes.Count >= 1)
							{
								foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
								{
									if (v.KHo != null)
									{
										rkqBaiHoc.Text += "\t- " + v.Viet + "\t\t+ " + v.KHo + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + v.Viet + "\n";
									}
								}
							}
							//if (itemdmc.LuyenTaps.Count >= 1)
							//{
							//	foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
							//	{
							//		if (lt.HoiKHo != null && lt.HoiViet != null)
							//		{
							//			if (lt.TraLoiKHo != null && lt.TraLoiViet != null)
							//			{

							//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
							//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n";
							//			}
							//			else if (lt.TraLoiKHo != null && lt.TraLoiViet == null)
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
							//			}
							//			else if (lt.TraLoiKHo == null && lt.TraLoiViet != null)
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
							//			}
							//			else
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
							//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
							//			}
							//		}
							//		else if (lt.HoiKHo != null && lt.HoiViet == null)
							//		{
							//			if (lt.TraLoiKHo != null)
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
							//			}
							//			else
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
							//			}
							//		}
							//		else if (lt.HoiKHo == null && lt.HoiViet != null)
							//		{
							//			if (lt.TraLoiViet != null)
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n";
							//			}
							//			else
							//			{
							//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
							//			}
							//		}
							//	}
							//}
							if (itemdmc.NguPhaps.Count >= 1)
							{
								foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
								{
									rkqBaiHoc.Text += "\t\t" + tv.NoiDung + "\n";
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
					rkqBaiHoc.Text += j + ". " + itemdmc.Ten + ".\n";
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
									if (bk.TraLoiKHo != null)
									{
										rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";

									}
									else
									{
										rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\n";
									}
									if (bk.TraLoiViet != null)
									{
										rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\t\t+ " + bk.TraLoiViet + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\n";
									}
								}
								else
								{
									if (bk.TraLoiKHo != null)
									{
										rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";

									}
									else
									{
										rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\n";
									}
								}
							}
							else
							{
								rkqBaiHoc.Text += "\t" + bk.NoiDung + "\n";
							}
						}
					}
					if (itemdmc.TuVungs.Count >= 1)
					{
						foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
						{
							rkqBaiHoc.Text += "\t" + tv.KHo + ": " + tv.Viet + "\n";
						}
					}
					if (itemdmc.DamThoais.Count >= 1)
					{
						foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
						{
							if (dt.CauHoiViet != null)
							{
								rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
								rkqBaiHoc.Text += "\t- " + dt.CauHoiViet + "\t\t+ " + dt.TraLoiViet + "\n";
							}
							else
							{
								rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
							}
						}
					}
					if (itemdmc.DichKHoViets.Count >= 1)
					{
						foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
						{
							if (kh.Viet != null)
							{
								rkqBaiHoc.Text += "\t- " + kh.KHo + "\t\t+ " + kh.Viet + "\n";
							}
							else
							{
								rkqBaiHoc.Text += "\t- " + kh.KHo + "\n";
							}
						}
					}
					if (itemdmc.DichVietKHoes.Count >= 1)
					{
						foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
						{
							if (v.KHo != null)
							{
								rkqBaiHoc.Text += "\t- " + v.Viet + "\t\t+ " + v.KHo + "\n";
							}
							else
							{
								rkqBaiHoc.Text += "\t- " + v.Viet + "\n";
							}
						}
					}
					//if (itemdmc.LuyenTaps.Count >= 1)
					//{
					//	foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
					//	{
					//		if (lt.HoiKHo != null && lt.HoiViet != null)
					//		{
					//			if (lt.TraLoiKHo != null && lt.TraLoiViet != null)
					//			{

					//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
					//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n";
					//			}
					//			else if (lt.TraLoiKHo != null && lt.TraLoiViet == null)
					//			{
					//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
					//			}
					//			else if (lt.TraLoiKHo == null && lt.TraLoiViet != null)
					//			{
					//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
					//			}
					//			else
					//			{
					//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
					//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
					//			}
					//		}
					//		else if (lt.HoiKHo != null && lt.HoiViet == null)
					//		{
					//			if (lt.TraLoiKHo != null)
					//			{
					//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
					//			}
					//			else
					//			{
					//				rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
					//			}
					//		}
					//		else if (lt.HoiKHo == null && lt.HoiViet != null)
					//		{
					//			if (lt.TraLoiViet != null)
					//			{
					//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n";
					//			}
					//			else
					//			{
					//				rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
					//			}
					//		}
					//	}
					//}
					if (itemdmc.NguPhaps.Count >= 1)
					{
						foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
						{
							rkqBaiHoc.Text += "\t\t" + tv.NoiDung + "\n";
						}

					}
				}
			}
		}
		void LoadBaiHoc(int iDBaiHoc)
		{
			lbViet.Text = "";
			lbKhoHay.Text = "";
			lbLHViet.Text = "";
			picBox.Image = null;
			lbcMucLuc.Items.Clear();//moi
			rkqBaiHoc.ResetText();
			rkqBaiHoc.Font = new Font("TNKeyUni-Arial", 11F);
			int SoBai = BaiHocDao.Instance.BaiHocCounts();
			int j = 0;
			int i = 0;
			if (_iDBaiHoc <= 1)
			{
				btnBack.Enabled = false;
			}
			else
			{
				btnBack.Enabled = true;
			}
			if (_iDBaiHoc >= SoBai)
			{
				btnNext.Enabled = false;
			}
			else
			{
				btnNext.Enabled = true;
			}
			foreach (BaiHoc item in BaiHocDao.Instance.LoadTenBai(iDBaiHoc))
			{
				if (item.TenViet != null && item.TenKHo != null)
				{
					lbViet.Text = "(" + item.TenViet + ")";
					lbTenBai.Text = "Bài " + iDBaiHoc + ": " + item.TenKHo;
				}
				else if (item.TenViet == null && item.TenKHo != null)
				{
					lbTenBai.Text = "Bài " + iDBaiHoc + ": " + item.TenKHo;
				}
				else if (item.TenViet != null && item.TenKHo == null)
				{
					lbTenBai.Text = "Bài " + iDBaiHoc + ": " + item.TenViet;
				}
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
						string _filepath = Application.StartupPath;
						Image image = Image.FromFile(_filepath + _pictures);
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
						lbcMucLuc.Items.Add(i + ". " + itemdmc.Ten);

					}
				}
				else
				{
					i++;
					lbcMucLuc.Items.Add(i + ". " + item.TenKHo);
				}
			}
			foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoad(iDBaiHoc))
			{
				j++;
				if (item.TenKHo != null)
				{
					rkqBaiHoc.Text += j + ". " + item.TenKHo + " - " + item.TenViet + "\n";
					foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						rkqBaiHoc.Text += "\t* " + itemdmc.Ten + ".\n";
						if (itemdmc.BaiKhoas.Count >= 1)
						{
							foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
							{
								if (bk.NoiDung == null)
								{
									if (bk.HoiViet != null)
									{
										if (bk.TraLoiKHo != null)
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";

										}
										else
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\n";
										}
										if (bk.TraLoiViet != null)
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\t\t+ " + bk.TraLoiViet + "\n";
										}
										else
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\n";
										}
									}
									else
									{
										if (bk.TraLoiKHo != null)
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";

										}
										else
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\n";
										}
									}
								}
								else
								{
									rkqBaiHoc.Text += "\t" + bk.NoiDung + "\n";
								}
							}
						}
						if (itemdmc.TuVungs.Count >= 1)
						{
							foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t\t" + tv.KHo + ": " + tv.Viet + "\n";
							}
						}
						if (itemdmc.DamThoais.Count >= 1)
						{
							foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
							{
								if (dt.CauHoiViet != null)
								{
									rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
									rkqBaiHoc.Text += "\t- " + dt.CauHoiViet + "\t\t+ " + dt.TraLoiViet + "\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
								}
							}
						}
						//Tới đây
						if (itemdmc.DichKHoViets.Count >= 1)
						{
							foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
							{
								if (kh.Viet != null)
								{
									rkqBaiHoc.Text += "\t- " + kh.KHo + "\t\t+ " + kh.Viet + "\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t- " + kh.KHo + "\n";
								}
							}
						}
						if (itemdmc.DichVietKHoes.Count >= 1)
						{
							foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
							{
								if (v.KHo != null)
								{
									rkqBaiHoc.Text += "\t- " + v.Viet + "\t\t+ " + v.KHo + "\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t- " + v.Viet + "\n";
								}
							}
						}
						if (itemdmc.CauHois.Count >= 1)
						{
							foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
							{
								if (ch.TraLoi != null)
								{
									rkqBaiHoc.Text += "\t- " + ch.Hoi + "\t\t+ " + ch.TraLoi + "\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t- " + ch.Hoi + "\n";
								}
							}
						}
						if (itemdmc.LuyenTaps.Count >= 1)
						{
							foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
							{
								if (lt.HoiKHo != null && lt.HoiViet != null)
								{
									if (lt.TraLoiKHo != null && lt.TraLoiViet != null)
									{

										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n";
									}
									else if (lt.TraLoiKHo != null && lt.TraLoiViet == null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
									}
									else if (lt.TraLoiKHo == null && lt.TraLoiViet != null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
									}
								}
								else if (lt.HoiKHo != null && lt.HoiViet == null)
								{
									if (lt.TraLoiKHo != null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
									}
								}
								else if (lt.HoiKHo == null && lt.HoiViet != null)
								{
									if (lt.TraLoiViet != null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
									}
								}
							}
						}
						if (itemdmc.NguPhaps.Count >= 1)
						{
							foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t\t" + tv.NoiDung + "\n";
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
						rkqBaiHoc.Text += j + ". " + itemdmc.Ten + ".\n";
						if (itemdmc.BaiKhoas.Count >= 1)
						{
							foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
							{
								if (bk.NoiDung == null)
								{
									if (bk.HoiViet != null)
									{
										if (bk.TraLoiKHo != null)
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";

										}
										else
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\n";
										}
										if (bk.TraLoiViet != null)
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\t\t+ " + bk.TraLoiViet + "\n";
										}
										else
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\n";
										}
									}
									else
									{
										if (bk.TraLoiKHo != null)
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";

										}
										else
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\n";
										}
									}
								}
								else
								{
									rkqBaiHoc.Text += "\t" + bk.NoiDung + "\n";
								}
							}
						}
						if (itemdmc.TuVungs.Count >= 1)
						{
							foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t" + tv.KHo + ": " + tv.Viet + "\n";
							}
						}
						if (itemdmc.DamThoais.Count >= 1)
						{
							foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
							{
								if (dt.CauHoiViet != null)
								{
									rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
									rkqBaiHoc.Text += "\t- " + dt.CauHoiViet + "\t\t+ " + dt.TraLoiViet + "\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
								}
							}
						}
						if (itemdmc.DichKHoViets.Count >= 1)
						{
							foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
							{
								if (kh.Viet != null)
								{
									rkqBaiHoc.Text += "\t- " + kh.KHo + "\t\t+ " + kh.Viet + "\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t- " + kh.KHo + "\n";
								}
							}
						}
						if (itemdmc.DichVietKHoes.Count >= 1)
						{
							foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
							{
								if (v.KHo != null)
								{
									rkqBaiHoc.Text += "\t- " + v.Viet + "\t\t+ " + v.KHo + "\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t- " + v.Viet + "\n";
								}
							}
						}
						if (itemdmc.CauHois.Count >= 1)
						{
							foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
							{
								if (ch.TraLoi != null)
								{
									rkqBaiHoc.Text += "\t- " + ch.Hoi + "\t\t+ " + ch.TraLoi + "\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t- " + ch.Hoi + "\n";
								}
							}
						}
						if (itemdmc.LuyenTaps.Count >= 1)
						{
							foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
							{
								if (lt.HoiKHo != null && lt.HoiViet != null)
								{
									if (lt.TraLoiKHo != null && lt.TraLoiViet != null)
									{

										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n";
									}
									else if (lt.TraLoiKHo != null && lt.TraLoiViet == null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
									}
									else if (lt.TraLoiKHo == null && lt.TraLoiViet != null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
									}
								}
								else if (lt.HoiKHo != null && lt.HoiViet == null)
								{
									if (lt.TraLoiKHo != null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
									}
								}
								else if (lt.HoiKHo == null && lt.HoiViet != null)
								{
									if (lt.TraLoiViet != null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n";
									}
								}
							}
						}
						if (itemdmc.NguPhaps.Count >= 1)
						{
							foreach (NguPhap tv in NguPhapDAO.Instance.LoadNguPhaps(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t\t" + tv.NoiDung + "\n";
							}

						}
					}
				}

			}
		}
		void LoadAmThanh(string dgdan)
		{
			sound = new WindowsMediaPlayer();
			sound.URL = dgdan;
			if (trangthaiam)
			{
				trangthaiam = false;
				sound.controls.stop();
			}
			else
			{
				trangthaiam = true;
				sound.controls.play();
			}
		}
		#endregion
		#region event
		private void btnClose_Click(object sender, EventArgs e)
		{
			if (trangthaiam)
			{
				trangthaiam = false;
				sound.controls.stop();
				btnAudio.Text = "Nghe";
			}
			this.Close();
		}
		private void FrmBaiHocChiTiet_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (XtraMessageBox.Show("Bạn có muốn đóng bài học không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
			{
				e.Cancel = true;
			}
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			if (trangthaiam)
			{
				trangthaiam = false;
				sound.controls.stop();
				btnAudio.Text = "Nghe";
			}
			FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
			if (f != null)
			{
				f.Close();
			}
			_last = _iDBaiHoc - 1;
			if (_last <= 1)
			{
				_last = 1;
			}
			_iDBaiHoc = _last;
			this.Text = "Bài học số " + _last;
			LoadBaiHoc(_last);

		}
		private void btnNext_Click(object sender, EventArgs e)
		{
			if (trangthaiam)
			{
				trangthaiam = false;
				sound.controls.stop();
				btnAudio.Text = "Nghe";
			}
			FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
			if (f != null)
			{
				f.Close();
			}
			_next = _iDBaiHoc + 1;
			_iDBaiHoc = _next;
			this.Text = "Bài học số " + _next;
			LoadBaiHoc(_next);

		}
		private void lbcMucLuc_Click(object sender, EventArgs e)
		{
			if (trangthaiam)
			{
				trangthaiam = false;
				sound.controls.stop();
				btnAudio.Text = "Nghe";
			}
			string tukhoa = lbcMucLuc.SelectedItem.ToString();
			int id = 0;
			string str = tukhoa.Substring(0, tukhoa.LastIndexOf('.'));
			string subStringItem = tukhoa.Substring(str.Length + 2);
			foreach (var dm in DanhMucDao.Instance.DanhMucLoad(_iDBaiHoc))
			{
				if (dm.TenKHo != null && dm.TenKHo == subStringItem)
				{
					id = dm.ID;
				}
				else
				{
					foreach (var dmc in DanhMucConDao.Instance.DanhMucConLoad(dm.ID))
					{
						if (dmc.Ten == subStringItem)
						{
							id = dmc.ID;
						}
					}
				}

			}
			if (subStringItem == "Câu hỏi")
			{
				FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
				if (f != null)
				{
					XtraMessageBox.Show("Bạn đã mở bài tập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					f = new FrmExercise(_iDBaiHoc);
					f.Text = "Bài tập của bài học số " + _iDBaiHoc;
					f.Show();
				}
			}
			if (subStringItem == "Luyện tập")
			{
				FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
				if (f != null)
				{
					XtraMessageBox.Show("Bạn đã mở luyện tập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					f = new FrmExercise(_iDBaiHoc);
					f.Text = "Luyện tập của bài học số " + _iDBaiHoc;
					f.Show();
				}
			}
			else
			{
				LoadDanhMucTheoTen(subStringItem, id);
			}

		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			if (trangthaiam)
			{
				trangthaiam = false;
				sound.controls.stop();
				btnAudio.Text = "Nghe";
			}
			FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
			if (f != null)
			{
				f.Close();
			}
			LoadBaiHoc(_iDBaiHoc);
		}
		private void btnDictionary_Click(object sender, EventArgs e)
		{
			if (trangthaiam)
			{
				trangthaiam = false;
				sound.controls.stop();
				btnAudio.Text = "Nghe";
			}
			FrmDictionary f = Application.OpenForms.OfType<FrmDictionary>().FirstOrDefault();
			if (f != null)
			{
				XtraMessageBox.Show("Bạn đã mở tử điển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				f = new FrmDictionary();
				f.Show();
			}
		}
		private void btnAudio_Click(object sender, EventArgs e)
		{
			if (btnAudio.Text =="Nghe")
			{
				btnAudio.Text = "Dừng";
				SimpleButton simpleButton = sender as SimpleButton;
				if (simpleButton != null)
				{
					DanhMucCon dmc = (simpleButton.Tag as DanhMucCon);

					var am = AmThanhDAO.Instance.LoadAmThanhs(dmc.IDAmThanh);
					string _filepath = Application.StartupPath;
					LoadAmThanh(_filepath + am.DuongDan);
				}
			}
			else
			{
				btnAudio.Text = "Nghe";
				if (trangthaiam)
				{
					trangthaiam = false;
					sound.controls.stop();
				}
			}
			
			
		}
		#endregion

		






	}
}