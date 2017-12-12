using System.Collections.Generic;
using System.Linq;
using DACN_UD_Hoc_KHo_CTK37.DTO;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class LoiHayYDepDao
	{
		private readonly DATAContext _db = new DATAContext();
		private static LoiHayYDepDao _instance;

		public static LoiHayYDepDao Instance
		{
			get { if(_instance == null) _instance = new LoiHayYDepDao();
				return _instance;
			}
			private set { _instance = value; }
		}

		private LoiHayYDepDao() { }

		public List<LoiHayYDep> LoadHayYDeps(int idBaiHoc)
		{
			List<LoiHayYDep> list = _db.LoiHayYDeps.Where(x => x.IDBaiHoc == idBaiHoc).ToList();
			return list;
		}

	}
}
