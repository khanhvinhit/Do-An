using DACN_UD_Hoc_KHo_CTK37.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class HinhDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static HinhDao _instance;

		public static HinhDao Instance
		{
			get { if(_instance == null) _instance = new HinhDao();
				return _instance;
			}
			private set { HinhDao._instance = value; }
		}

		private HinhDao() { }

		public List<Hinh> LoadHinhs(int idHinh)
		{
			List<Hinh> list = _db.Hinhs.Where(x => x.ID == idHinh).ToList();
			return list;
		}
	}
}
