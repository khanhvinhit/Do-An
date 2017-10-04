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

		public Hinh LoadHinhs(int idHinh)
		{
			return _db.Hinhs.Find(idHinh);
		}
	}
}
