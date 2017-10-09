using DACN_UD_Hoc_KHo_CTK37.DTO;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class AmThanhDao
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static AmThanhDao _instance;

		public static AmThanhDao Instance
		{
			get
			{
				if (_instance == null) _instance = new AmThanhDao();
				return _instance;
			}
			private set { _instance = value; }
		}

		private AmThanhDao() { }

		public AmThanh LoadAmThanhs(int idAt)
		{
			return _db.AmThanhs.Find(idAt);
		}
	}
}
