using DACN_UD_Hoc_KHo_CTK37.DTO;
using System;
using System.Collections.Generic;
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

	}
}
