using DACN_UD_Hoc_KHo_CTK37.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class LuyenTapDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static LuyenTapDao _instance;

		public static LuyenTapDao Instance
		{
			get { if(_instance == null) _instance = new LuyenTapDao();
				return _instance;
			}
			private set { LuyenTapDao._instance = value; }
		}

		private LuyenTapDao() { }

		public List<LuyenTap> LoadLuyenTaps(int idDanhMucCon)
		{
			List<LuyenTap> list = _db.LuyenTaps.Where(x => x.IDDanhMucCon == idDanhMucCon).ToList();
			return list;
		}

		public bool KiemTraLT(int idDanhMucCon)
		{
			var db = _db.LuyenTaps.Find(idDanhMucCon);
			if (db != null)
			{
				return true;
			}
			return false;
		}
	}
}
