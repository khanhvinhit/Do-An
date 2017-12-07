using System;
using System.Collections.Generic;
using System.Linq;
using DACN_UD_Hoc_KHo_CTK37.DTO;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class BaiHocDao
	{
		private readonly DATAContext _db = new DATAContext();
		private static BaiHocDao _instance;

		public static BaiHocDao Instance
		{
			get
			{
				if (_instance == null) _instance = new BaiHocDao();
				return _instance;
			}
			private set { _instance = value; }
		}

		private BaiHocDao() { }

		public List<BaiHoc> LoadTenBai(int idBai)
		{
			List<BaiHoc> list = _db.BaiHocs.Where(x => x.ID == idBai).ToList();
			return list;
		}

		public List<BaiHoc> LoadBaiHoc()
		{
			List<BaiHoc> list = _db.BaiHocs.ToList();
			return list;
		}

		public bool Checkdb()
		{
			try
			{
				if (_db.BaiHocs.ToList().Count > 0)
				{
					return true;
				}
				return false;
			}
			catch (Exception)
			{
				return false;
			}

		}

		public int BaiHocCounts()
		{
			int i = _db.BaiHocs.Count();
			return i;
		}

		public List<BaiHoc> LoadNguPhap()
		{
			List<BaiHoc> list = _db.BaiHocs.Where(x => x.TenViet.Contains("NGỮ PHÁP") || x.TenViet.Contains("Ngữ Pháp")).ToList();
			return list;
		}

	}
}
