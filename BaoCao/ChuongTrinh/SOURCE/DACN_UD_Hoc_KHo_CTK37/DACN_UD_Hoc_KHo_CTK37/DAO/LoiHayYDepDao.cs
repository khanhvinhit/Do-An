using DACN_UD_Hoc_KHo_CTK37.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class LoiHayYDepDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static LoiHayYDepDao _instance;

		public static LoiHayYDepDao Instance
		{
			get { if(_instance == null) _instance = new LoiHayYDepDao();
				return _instance;
			}
			private set { LoiHayYDepDao._instance = value; }
		}

		private LoiHayYDepDao() { }

		public List<LoiHayYDep> LoadHayYDeps(int idBaiHoc)
		{
			List<LoiHayYDep> list = _db.LoiHayYDeps.Where(x => x.IDBaiHoc == idBaiHoc).ToList();
			return list;
		}

		public bool KiemTraLH(int idBaiHoc)
		{
			var db = _db.LoiHayYDeps.Find(idBaiHoc);
			if (db != null)
			{
				return true;
			}
			return false;
		}
	}
}
