using DACN_UD_Hoc_KHo_CTK37.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class DamThoaiDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static DamThoaiDao _instance;

		public static DamThoaiDao Instance
		{
			get { if(_instance == null) _instance = new DamThoaiDao();
				return _instance;
			}
			private set { DamThoaiDao._instance = value; }
		}

		private DamThoaiDao() { }

		public List<DamThoai> LoadDamThoais(int idDanhMucCon)
		{
			List<DamThoai> list = _db.DamThoais.Where(x => x.IDDanhMucCon == idDanhMucCon).ToList();
			return list;
		}

	}
}
