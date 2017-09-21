using DACN_UD_Hoc_KHo_CTK37.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class DichVietKHoDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static DichVietKHoDao _instance;

		public static DichVietKHoDao Instance
		{
			get { if(_instance == null) _instance = new DichVietKHoDao();
				return _instance;
			}
			private set { DichVietKHoDao._instance = value; }
		}

		private DichVietKHoDao() { }
		public List<DichVietKHo> LoadDichVietKHos(int idDanhMucCon)
		{
			List<DichVietKHo> list = _db.DichVietKHoes.Where(x => x.IDDanhMucCon == idDanhMucCon).ToList();
			return list;
		}

	}
}
