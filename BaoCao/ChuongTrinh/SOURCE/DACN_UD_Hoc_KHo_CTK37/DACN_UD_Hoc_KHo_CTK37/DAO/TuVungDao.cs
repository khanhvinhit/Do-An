using DACN_UD_Hoc_KHo_CTK37.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class	TuVungDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static TuVungDao _instance;

		public static TuVungDao Instance
		{
			get { if(_instance == null) _instance = new TuVungDao();
				return _instance;
			}
			private set { TuVungDao._instance = value; }
		}

		private TuVungDao() { }

		public List<TuVung> LoadTuVungs(int idDanhMucCon)
		{
			List<TuVung> list = _db.TuVungs.Where(x => x.IDDanhMucCon == idDanhMucCon).ToList();
			return list;
		}

	}
}
