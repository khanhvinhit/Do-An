using DACN_UD_Hoc_KHo_CTK37.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class DanhMucConDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static DanhMucConDao _instance;

		public static DanhMucConDao Instance
		{
			get
			{
				if (_instance == null) _instance = new DanhMucConDao();
				return _instance;
			}
			private set { DanhMucConDao._instance = value; }
		}

		private DanhMucConDao() { }

		public List<DanhMucCon> DanhMucConLoad(int iDDanhMuc)
		{
			List<DanhMucCon> list = _db.DanhMucCons.Where(x => x.IDDanhMuc == iDDanhMuc).ToList();
			return list;
		}

		public List<DanhMucCon> DanhMucConLoadByName(string name, int id)
		{
			List<DanhMucCon> list = _db.DanhMucCons.Where(x => x.Ten == name && x.ID == id).ToList();
			return list;
		}

		public bool KTDanhMucCon(string name, int id)
		{
			var db = _db.DanhMucCons.SingleOrDefault(x => x.Ten == name && x.ID == id);
			if (db != null)
			{
				return true;
			}
			return false;
		}}
}
