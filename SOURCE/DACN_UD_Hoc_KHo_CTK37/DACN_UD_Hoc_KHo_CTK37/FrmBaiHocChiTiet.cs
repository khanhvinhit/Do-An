using System;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DevExpress.XtraEditors;
using System.IO;

namespace DACN_UD_Hoc_KHo_CTK37
{
	public partial class FrmBaiHocChiTiet : XtraForm
	{
		private int _iDBaiHoc;
		string _pictures = "";
		private int _next;
		private int _last;
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
							rkqBaiHoc.Text += "\t* " + itemdmc.Ten + "\n\n";
							if (itemdmc.BaiKhoas.Count >= 1)
							{
								foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
								{
									if (bk.NoiDung == null)
									{
										if (bk.HoiViet != null)
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";
											rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\t\t+ " + bk.TraLoiViet + "\n\n";
										}
										else
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";
										}
									}
									else
									{
										rkqBaiHoc.Text += "\t" + bk.NoiDung + "\n\n";
									}
								}
							}
							if (itemdmc.TuVungs.Count >= 1)
							{
								foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
								{
									rkqBaiHoc.Text += "\t\t" + tv.KHo + " : \t" + tv.Viet + "\n";
								}
							}
							if (itemdmc.DamThoais.Count >= 1)
							{
								foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
								{
									if (dt.CauHoiViet != null)
									{
										rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
										rkqBaiHoc.Text += "\t- " + dt.CauHoiViet + "\t\t+ " + dt.TraLoiViet + "\n\n";
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
										rkqBaiHoc.Text += "\t- " + kh.KHo + "\t\t+ " + kh.Viet + "\n\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + kh.KHo + "\n\n";
									}
								}
							}
							if (itemdmc.DichVietKHoes.Count >= 1)
							{
								foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
								{
									if (v.KHo != null)
									{
										rkqBaiHoc.Text += "\t- " + v.Viet + "\t\t+ " + v.KHo + "\n\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + v.Viet + "\n\n";
									}
								}
							}
							if (itemdmc.CauHois.Count >= 1)
							{
								foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
								{
									if (ch.TraLoi!=null)
									{
										rkqBaiHoc.Text += "\t- " + ch.Hoi + "\t\t+ " + ch.TraLoi + "\n\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + ch.Hoi  + "\n\n";
									}
								}
							}
							if (itemdmc.LuyenTaps.Count >= 1)
							{
								foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
								{
									if (lt.TraLoiKHo != null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
									}
									if (lt.TraLoiViet != null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n\n";
									}
								}
							}
							if (itemdmc.IDHinh > 0)
							{
								foreach (Hinh hi in HinhDao.Instance.LoadHinhs((int)itemdmc.IDHinh))
								{
									_pictures = hi.DuongDan;
									string _filepath = Application.StartupPath;
									Image image = Image.FromFile(_filepath + _pictures);
									picBox.Image = image;
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
							rkqBaiHoc.Text += j + ". " + itemdmc.Ten + "\n";
							if (itemdmc.BaiKhoas.Count >= 1)
							{
								foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
								{
									if (bk.NoiDung == null)
									{
										if (bk.HoiViet !=null)
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";
											rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\t\t+ " + bk.TraLoiViet + "\n\n";
										}
										else
										{
											rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";
										}
										//
									}
									else
									{
										rkqBaiHoc.Text += "\t" + bk.NoiDung + "\n\n";
									}
								}
							}
							if (itemdmc.TuVungs.Count >= 1)
							{
								foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
								{
									rkqBaiHoc.Text += "\t" + tv.KHo + " : \t" + tv.Viet + "\n";
								}
							}
							if (itemdmc.DamThoais.Count >= 1)
							{
								foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
								{
									if (dt.CauHoiViet!=null)
									{
										rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
										rkqBaiHoc.Text += "\t- " + dt.CauHoiViet + "\t\t+ " + dt.TraLoiViet + "\n\n";
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
									if (kh.Viet!=null)
									{
										rkqBaiHoc.Text += "\t- " + kh.KHo + "\t\t+ " + kh.Viet + "\n\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + kh.KHo  + "\n\n";
									}
								}
							}
							if (itemdmc.DichVietKHoes.Count >= 1)
							{
								foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
								{
									if (v.KHo!=null)
									{
										rkqBaiHoc.Text += "\t- " + v.Viet + "\t\t+ " + v.KHo + "\n\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + v.Viet +"\n\n";
									}
								}
							}
							if (itemdmc.CauHois.Count >= 1)
							{
								foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
								{
									if (ch.TraLoi!=null)
									{
										rkqBaiHoc.Text += "\t- " + ch.Hoi + "\t\t+ " + ch.TraLoi + "\n\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + ch.Hoi + "\n\n";
									}
								}
							}
							if (itemdmc.LuyenTaps.Count >= 1)
							{
								foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
								{
									if (lt.TraLoiKHo != null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
									}
									if (lt.TraLoiViet != null)
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n\n";
									}
								}
							}
							if (itemdmc.IDHinh > 0)
							{
								foreach (Hinh hi in HinhDao.Instance.LoadHinhs((int)itemdmc.IDHinh))
								{
									_pictures = hi.DuongDan;
									string _filepath = Application.StartupPath;
									Image image = Image.FromFile(_filepath + _pictures);
									picBox.Image = image;
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
					rkqBaiHoc.Text += j + ". " + itemdmc.Ten + "\n";
					if (itemdmc.BaiKhoas.Count >= 1)
					{
						foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
						{
							if (bk.NoiDung == null)
							{
								if (bk.HoiViet !=null)
								{
									rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";
									rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\t\t+ " + bk.TraLoiViet + "\n\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n\n";
								}
							}
							else
							{
								rkqBaiHoc.Text += "\t" + bk.NoiDung + "\n\n";
							}
						}
					}
					if (itemdmc.TuVungs.Count >= 1)
					{
						foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
						{
							rkqBaiHoc.Text += "\t" + tv.KHo + " : \t" + tv.Viet + "\n";
						}
					}
					if (itemdmc.DamThoais.Count >= 1)
					{
						foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
						{
							if (dt.CauHoiViet!=null)
							{
								rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
								rkqBaiHoc.Text += "\t- " + dt.CauHoiViet + "\t\t+ " + dt.TraLoiViet + "\n\n";
							}
							else
							{
								rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n\n";
							}
						}
					}
					if (itemdmc.DichKHoViets.Count >= 1)
					{
						foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
						{
							if (kh.Viet!=null)
							{
								rkqBaiHoc.Text += "\t- " + kh.KHo + "\t\t+ " + kh.Viet + "\n\n";
							}
							else
							{
								rkqBaiHoc.Text += "\t- " + kh.KHo + "\n\n";
							}
						}
					}
					if (itemdmc.DichVietKHoes.Count >= 1)
					{
						foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
						{
							if (v.KHo!=null)
							{
								rkqBaiHoc.Text += "\t- " + v.Viet + "\t\t+ " + v.KHo + "\n\n";
							}
							else
							{
								rkqBaiHoc.Text += "\t- " + v.Viet + "\n\n";
							}
						}
					}
					if (itemdmc.CauHois.Count >= 1)
					{
						foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
						{
							if (ch.TraLoi!=null)
							{
								rkqBaiHoc.Text += "\t\t- " + ch.Hoi + "\t\t+ " + ch.TraLoi + "\n\n";
							}
							else
							{
								rkqBaiHoc.Text += "\t\t- " + ch.Hoi  + "\n\n";
							}
						}
					}
					if (itemdmc.LuyenTaps.Count >= 1)
					{
						foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
						{
							if (lt.TraLoiKHo != null)
							{
								rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
							}
							else
							{
								rkqBaiHoc.Text += "\t- " + lt.HoiKHo + "\n";
							}
							if (lt.TraLoiViet != null)
							{
								rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n\n";
							}
							else
							{
								rkqBaiHoc.Text += "\t- " + lt.HoiViet + "\n\n";
							}
						}
					}
					if (itemdmc.IDHinh > 0)
					{
						foreach (Hinh hi in HinhDao.Instance.LoadHinhs((int)itemdmc.IDHinh))
						{
							_pictures = hi.DuongDan;
							string _filepath = Application.StartupPath;
							Image image = Image.FromFile(_filepath + _pictures);
							picBox.Image = image;
						}
					}}
			}
		}
		void LoadBaiHoc(int iDBaiHoc)
		{
			lbKhoHay.Text = "";
			lbLHViet.Text = "";
			picBox.Image = null;
			lbcMucLuc.Items.Clear();//moi
			rkqBaiHoc.ResetText();
			rkqBaiHoc.Font = new Font("TNKeyUni-Arial", 11F);
			//int i = 0;
			int j = 0;

			if (_iDBaiHoc < 1)
			{
				btnBack.Enabled = false;
			}
			else
			{
				btnBack.Enabled = true;
			}
			foreach (BaiHoc item in BaiHocDao.Instance.LoadTenBai(iDBaiHoc))
			{
				if (item.TenViet != null && item.TenKHo != null)
				{
					lbViet.Text = "(" + item.TenViet + ")";
					lbTenBai.Text = "Bài " + iDBaiHoc + ": " + item.TenKHo;
				}
				else
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
			}

			foreach (DanhMuc item in DanhMucDao.Instance.DanhMucLoad(iDBaiHoc))
			{
				if (item.TenKHo == null)
				{
					foreach (DanhMucCon itemdmc in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						lbcMucLuc.Items.Add(itemdmc.ID + ". " + itemdmc.Ten);
					}
				}
				else
				{
					lbcMucLuc.Items.Add(item.ID + ". " + item.TenKHo);
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
						rkqBaiHoc.Text += "\t* " + itemdmc.Ten + "\n";
						if (itemdmc.BaiKhoas.Count >= 1)
						{
							foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
							{
								if (bk.NoiDung == null)
								{
									if (bk.HoiViet!=null)
									{
										rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";
										rkqBaiHoc.Text += "\t- " + bk.HoiViet + "\t\t+ " + bk.TraLoiViet + "\n\n";
									}
									else
									{
										rkqBaiHoc.Text += "\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n\n";
									}
								}
								else
								{
									rkqBaiHoc.Text += "\t" + bk.NoiDung + "\n\n";
								}
							}
						}
						if (itemdmc.TuVungs.Count >= 1)
						{
							foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t" + tv.KHo + " : \t" + tv.Viet + "\n";
							}
						}
						if (itemdmc.DamThoais.Count >= 1)
						{
							foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
								rkqBaiHoc.Text += "\t- " + dt.CauHoiViet + "\t\t+ " + dt.TraLoiViet + "\n\n";
							}
						}
						//Tới đây
						if (itemdmc.DichKHoViets.Count >= 1)
						{
							foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t- " + kh.KHo + "\t\t+ " + kh.Viet + "\n\n";
							}
						}
						if (itemdmc.DichVietKHoes.Count >= 1)
						{
							foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t\t- " + v.Viet + "\t\t+ " + v.KHo + "\n\n";
							}
						}
						if (itemdmc.CauHois.Count >= 1)
						{
							foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t\t- " + ch.Hoi + "\t\t+ " + ch.TraLoi + "\n\n";
							}
						}
						if (itemdmc.LuyenTaps.Count >= 1)
						{
							foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
							{
								if (lt.TraLoiKHo != null)
								{
									rkqBaiHoc.Text += "\t\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t\t- " + lt.HoiKHo + "\n";
								}
								if (lt.TraLoiViet != null)
								{
									rkqBaiHoc.Text += "\t\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t\t- " + lt.HoiViet + "\n\n";
								}
							}
						}
						if (itemdmc.IDHinh > 0)
						{
							foreach (Hinh hi in HinhDao.Instance.LoadHinhs((int)itemdmc.IDHinh))
							{
								_pictures = hi.DuongDan;
								string _filepath = Application.StartupPath;
								Image image = Image.FromFile(_filepath + _pictures);
								picBox.Image = image;
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
						rkqBaiHoc.Text += j + ". " + itemdmc.Ten + "\n";
						if (itemdmc.BaiKhoas.Count >= 1)
						{
							foreach (BaiKhoa bk in BaiKhoaDao.Instance.LoadBaiKhoas(itemdmc.ID))
							{
								if (bk.NoiDung == null)
								{
									rkqBaiHoc.Text += "\t\t- " + bk.HoiKHo + "\t\t+ " + bk.TraLoiKHo + "\n";
									rkqBaiHoc.Text += "\t\t- " + bk.HoiViet + "\t\t+ " + bk.TraLoiViet + "\n\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t\t" + bk.NoiDung + "\n\n";
								}
							}
						}
						if (itemdmc.TuVungs.Count >= 1)
						{
							foreach (TuVung tv in TuVungDao.Instance.LoadTuVungs(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t\t" + tv.KHo + " : \t" + tv.Viet + "\n";
							}
						}
						if (itemdmc.DamThoais.Count >= 1)
						{
							foreach (DamThoai dt in DamThoaiDao.Instance.LoadDamThoais(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t\t- " + dt.CauHoiKHo + "\t\t+ " + dt.TraLoiKHo + "\n";
								rkqBaiHoc.Text += "\t\t- " + dt.CauHoiViet + "\t\t+ " + dt.TraLoiViet + "\n\n";
							}
						}
						if (itemdmc.DichKHoViets.Count >= 1)
						{
							foreach (DichKHoViet kh in DichKHoVietDao.Instance.LoadDichKHoViets(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t\t- " + kh.KHo + "\t\t+ " + kh.Viet + "\n\n";
							}
						}
						if (itemdmc.DichVietKHoes.Count >= 1)
						{
							foreach (DichVietKHo v in DichVietKHoDao.Instance.LoadDichVietKHos(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t\t- " + v.Viet + "\t\t+ " + v.KHo + "\n\n";
							}
						}
						if (itemdmc.CauHois.Count >= 1)
						{
							foreach (CauHoi ch in CauHoiDao.Instance.LoadCauHois(itemdmc.ID))
							{
								rkqBaiHoc.Text += "\t\t- " + ch.Hoi + "\t\t+ " + ch.TraLoi + "\n\n";
							}
						}
						if (itemdmc.LuyenTaps.Count >= 1)
						{
							foreach (LuyenTap lt in LuyenTapDao.Instance.LoadLuyenTaps(itemdmc.ID))
							{
								if (lt.TraLoiKHo != null)
								{
									rkqBaiHoc.Text += "\t\t- " + lt.HoiKHo + "\t\t+ " + lt.TraLoiKHo + "\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t\t- " + lt.HoiKHo + "\n";
								}
								if (lt.TraLoiViet != null)
								{
									rkqBaiHoc.Text += "\t\t- " + lt.HoiViet + "\t\t+ " + lt.TraLoiViet + "\n\n";
								}
								else
								{
									rkqBaiHoc.Text += "\t\t- " + lt.HoiViet + "\n\n";
								}
							}
						}
						if (itemdmc.IDHinh > 0)
						{
							foreach (Hinh hi in HinhDao.Instance.LoadHinhs((int)itemdmc.IDHinh))
							{
								_pictures = hi.DuongDan;
								string _filepath = Application.StartupPath;
								Image image = Image.FromFile(_filepath + _pictures);
								picBox.Image = image;
							}
						}
					}
				}

			}
		}
		#endregion
		#region event
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmBaiHocChiTiet_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn đóng bài học không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
			{
				e.Cancel = true;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			_last = _iDBaiHoc - 1;
			_iDBaiHoc = _last;
			this.Text = "Bài học số " + _last;
			LoadBaiHoc(_last);

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			_next = _iDBaiHoc + 1;
			_iDBaiHoc = _next;
			this.Text = "Bài học số " + _next;
			LoadBaiHoc(_next);

		}
		private void lbcMucLuc_Click(object sender, EventArgs e)
		{
			string tukhoa = lbcMucLuc.SelectedItem.ToString();
			int id = int.Parse(tukhoa.Substring(0, tukhoa.LastIndexOf('.')));
			string str = id.ToString();
			string subStringItem = tukhoa.Substring(str.Length + 2);
			LoadDanhMucTheoTen(subStringItem, id);
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadBaiHoc(_iDBaiHoc);
		}
		#endregion


	}
}