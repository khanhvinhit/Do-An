using System.Collections.Generic;
using System.Linq;
using DACN_UD_Hoc_KHo_CTK37.DTO;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class DanhMucDao
	{
		private readonly DATAContext _db = new DATAContext();
		private static DanhMucDao _instance;

		public static DanhMucDao Instance
		{
			get
			{
				if (_instance == null) _instance = new DanhMucDao();
				return _instance;
			}
			private set { _instance = value; }
		}

		private DanhMucDao() { }

		public List<DanhMuc> DanhMucLoad(int iDBaihoc)
		{
			List<DanhMuc> list = _db.DanhMucs.Where(x => x.IDBaiHoc == iDBaihoc).ToList();
			return list;
		}

		public List<DanhMuc> DanhMucLoadByName(string name, int id)
		{
			List<DanhMuc> list = _db.DanhMucs.Where(x => x.TenKHo == name || x.TenViet == name && x.ID == id).ToList();
			return list;
		}

		public bool KTDanhMuc(string name, int id)
		{
			var db = _db.DanhMucs.FirstOrDefault(x => x.TenKHo == name && x.ID == id || x.TenViet == name && x.ID == id);
			if (db != null)
			{
				return true;
			}
			return false;
		}

		public List<DanhMuc> LoadNguPhap()
		{
			List<DanhMuc> list = _db.DanhMucs.Where(x => x.TenViet == "Ngữ pháp").ToList();
			return list;
		}
	}
}
