using DACN_UD_Hoc_KHo_CTK37.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class BaiKhoaDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static BaiKhoaDao _instance;

		public static BaiKhoaDao Instance
		{
			get { if(_instance == null) _instance = new BaiKhoaDao();
				return _instance;
			}
			private set { BaiKhoaDao._instance = value; }
		}

		private BaiKhoaDao() { }

		public List<BaiKhoa> LoadBaiKhoas(int idDanhMucCon)
		{
			List<BaiKhoa> list = _db.BaiKhoas.Where(x => x.IDDanhMucCon == idDanhMucCon).ToList();
			return list;
		}

	}
}
