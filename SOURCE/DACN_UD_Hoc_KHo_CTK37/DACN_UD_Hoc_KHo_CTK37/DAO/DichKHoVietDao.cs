using DACN_UD_Hoc_KHo_CTK37.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class DichKHoVietDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static DichKHoVietDao _instance;

		public static DichKHoVietDao Instance
		{
			get { if(_instance == null) _instance = new DichKHoVietDao();
				return _instance;
			}
			private set { DichKHoVietDao._instance = value; }
		}

		private DichKHoVietDao() { }

		public List<DichKHoViet> LoadDichKHoViets(int idDanhMucCon)
		{
			List<DichKHoViet> list = _db.DichKHoViets.Where(x => x.IDDanhMucCon == idDanhMucCon).ToList();
			return list;
		}

	}
}
