using DACN_UD_Hoc_KHo_CTK37.DTO;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class HinhDao
	{
		private readonly DATAContext _db = new DATAContext();
		private static HinhDao _instance;

		public static HinhDao Instance
		{
			get { if(_instance == null) _instance = new HinhDao();
				return _instance;
			}
			private set { _instance = value; }
		}

		private HinhDao() { }

		public Hinh LoadHinhs(int idHinh)
		{
			return _db.Hinhs.Find(idHinh);
		}
	}
}
