using System;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DevExpress.XtraEditors;
using System.IO;
using System.Linq;

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
			lbName.Text = "";
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
							if (itemdmc.IDHinh > 0)
							{

								try
								{
									foreach (Hinh hi in HinhDao.Instance.LoadHinhs((int)itemdmc.IDHinh))
									{
										_pictures = hi.DuongDan;
										string _filepath = Application.StartupPath;
										Image image = Image.FromFile(_filepath + _pictures);
										picBox.Image = image;
										lbName.Text = hi.TenHinh;
									}
								}
								catch (Exception)
								{
									picBox.Image = null;
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
							if (itemdmc.IDHinh > 0)
							{
								try
								{
									foreach (Hinh hi in HinhDao.Instance.LoadHinhs((int)itemdmc.IDHinh))
									{
										_pictures = hi.DuongDan;
										string _filepath = Application.StartupPath;
										Image image = Image.FromFile(_filepath + _pictures);
										picBox.Image = image;
										lbName.Text = hi.TenHinh;
									}
								}
								catch (Exception)
								{
									picBox.Image = null;
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
					if (itemdmc.IDHinh > 0)
					{
						try
						{
							foreach (Hinh hi in HinhDao.Instance.LoadHinhs((int)itemdmc.IDHinh))
							{
								_pictures = hi.DuongDan;
								string _filepath = Application.StartupPath;
								Image image = Image.FromFile(_filepath + _pictures);
								picBox.Image = image;
								lbName.Text = hi.TenHinh;
							}
						}
						catch (Exception)
						{
							picBox.Image = null;
						}
					}
				}
			}
		}
		void LoadBaiHoc(int iDBaiHoc)
		{
			lbViet.Text = "";
			lbName.Text = "";
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
						if (itemdmc.IDHinh > 0)
						{
							try
							{
								foreach (Hinh hi in HinhDao.Instance.LoadHinhs((int)itemdmc.IDHinh))
								{
									_pictures = hi.DuongDan;
									string _filepath = Application.StartupPath;
									Image image = Image.FromFile(_filepath + _pictures);
									picBox.Image = image;
									lbName.Text = hi.TenHinh;
								}
							}
							catch (Exception)
							{
								picBox.Image = null;
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
						if (itemdmc.IDHinh > 0)
						{
							try
							{
								foreach (Hinh hi in HinhDao.Instance.LoadHinhs((int)itemdmc.IDHinh))
								{
									_pictures = hi.DuongDan;
									string _filepath = Application.StartupPath;
									Image image = Image.FromFile(_filepath + _pictures);
									picBox.Image = image;
									lbName.Text = hi.TenHinh;
								}
							}
							catch (Exception)
							{
								picBox.Image = null;
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
			if (XtraMessageBox.Show("Bạn có muốn đóng bài học không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
			{
				e.Cancel = true;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
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
			else
			{
				LoadDanhMucTheoTen(subStringItem, id);
			}

		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			FrmExercise f = Application.OpenForms.OfType<FrmExercise>().FirstOrDefault();
			if (f != null)
			{
				f.Close();
			}
			LoadBaiHoc(_iDBaiHoc);
		}
		private void btnDictionary_Click(object sender, EventArgs e)
		{
			frmDictionary f = Application.OpenForms.OfType<frmDictionary>().FirstOrDefault();
			if (f != null)
			{
				XtraMessageBox.Show("Bạn đã mở tử điển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				f = new frmDictionary();
				f.Show();
			}
		}
		#endregion






	}
}