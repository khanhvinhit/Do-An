using DACN_UD_Hoc_KHo_CTK37.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class CauHoiDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static CauHoiDao _instance;

		public static CauHoiDao Instance
		{
			get { if(_instance == null) _instance = new CauHoiDao();
				return _instance;
			}
			private set { CauHoiDao._instance = value; }
		}

		private CauHoiDao() { }

		public List<CauHoi> LoadCauHois(int idDanhMucCon)
		{
			List<CauHoi> list = _db.CauHois.Where(x => x.IDDanhMucCon == idDanhMucCon).ToList();
			return list;
		}

		public CauHoi LoadCauHoiFirst(int idDanhMucCon)
		{
			CauHoi list = _db.CauHois.FirstOrDefault(x => x.IDDanhMucCon == idDanhMucCon);
			return list;
		}

		public int CauHoiCounts(int dmc)
		{
			int i = _db.CauHois.Where(x=>x.IDDanhMucCon == dmc).Count();
			return i;
		}

		public List<CauHoi> LoadCauHoiByID(int id)
		{
			List<CauHoi> list = _db.CauHois.Where(x => x.ID == id).ToList();
			return list;
		}

		public void UpdateCauHoi(int id, string cauTL)
		{
			var cauhoi = _db.CauHois.Find(id);
			cauhoi.TraLoi = cauTL;
			_db.SaveChanges();
		}

		public void Referst(int id)
		{
			var cauhoi = _db.CauHois.Find(id);
			cauhoi.TraLoi = null;
			_db.SaveChanges();
		}
	}
}
