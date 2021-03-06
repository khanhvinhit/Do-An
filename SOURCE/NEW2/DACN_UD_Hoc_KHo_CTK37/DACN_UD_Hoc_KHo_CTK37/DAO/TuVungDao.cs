﻿using System.Collections.Generic;
using System.Linq;
using DACN_UD_Hoc_KHo_CTK37.DTO;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class TuVungDao
	{
		private readonly DATAContext _db = new DATAContext();
		private static TuVungDao _instance;

		public static TuVungDao Instance
		{
			get
			{
				if (_instance == null) _instance = new TuVungDao();
				return _instance;
			}
			private set { _instance = value; }
		}

		private TuVungDao() { }

		public List<TuVung> LoadTuVungs(int idDanhMucCon)
		{
			List<TuVung> list = _db.TuVungs.Where(x => x.IDDanhMucCon == idDanhMucCon).ToList();
			return list;
		}

		public List<TuVung> LoadTuVungDic()
		{
			List<TuVung> list = _db.TuVungs.OrderBy(x => x.KHo).ToList();
			return list;
		}

		public List<TuVung> LoadTuVungByKHo(string name)
		{
			List<TuVung> list = _db.TuVungs.Where(x => x.KHo == name).ToList();
			return list;
		}

	}
}
