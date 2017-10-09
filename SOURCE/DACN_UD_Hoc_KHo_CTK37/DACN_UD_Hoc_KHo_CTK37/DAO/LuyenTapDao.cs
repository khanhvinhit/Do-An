using System.Collections.Generic;
using System.Linq;
using DACN_UD_Hoc_KHo_CTK37.DTO;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class LuyenTapDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static LuyenTapDao _instance;

		public static LuyenTapDao Instance
		{
			get { if(_instance == null) _instance = new LuyenTapDao();
				return _instance;
			}
			private set { _instance = value; }
		}

		private LuyenTapDao() { }

		public List<LuyenTap> LoadLuyenTaps(int idDanhMucCon)
		{
			List<LuyenTap> list = _db.LuyenTaps.Where(x => x.IDDanhMucCon == idDanhMucCon).ToList();
			return list;
		}

        public List<LuyenTap> LoadLTByID(int id)
        {
            List<LuyenTap> list = _db.LuyenTaps.Where(x => x.ID == id).ToList();
            return list;
        }
        public int LTCounts(int dmc)
        {
            int i = _db.LuyenTaps.Where(x => x.IDDanhMucCon == dmc).Count();
            return i;
        }
        public LuyenTap LoadLTFirst(int idDanhMucCon)
        {
            LuyenTap list = _db.LuyenTaps.FirstOrDefault(x => x.IDDanhMucCon == idDanhMucCon);
            return list;
        }

        public void Referst(int id)
        {
            var lt = _db.LuyenTaps.Find(id);
            lt.TraLoiKHo = null;
            _db.SaveChanges();
        }
        public void UpdateLT(int id, string cauTL)
        {
            var lt = _db.LuyenTaps.Find(id);
			cauTL = cauTL == "" ? null : cauTL;
            lt.TraLoiKHo = cauTL;
            _db.SaveChanges();
        }
    }
}
