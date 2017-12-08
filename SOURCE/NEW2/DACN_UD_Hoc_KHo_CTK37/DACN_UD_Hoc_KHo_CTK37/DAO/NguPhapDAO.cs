using System.Collections.Generic;
using System.Linq;
using DACN_UD_Hoc_KHo_CTK37.DTO;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class NguPhapDAO
	{
		private readonly DATAContext _db = new DATAContext();
		private static NguPhapDAO _instance;

		public static NguPhapDAO Instance
		{
			get
			{
				if (_instance == null) _instance = new NguPhapDAO();
				return _instance;
			}
			private set { _instance = value; }
		}

		private NguPhapDAO() { }

		public List<NguPhap> LoadNguPhaps(int idDanhMucCon)
		{
			List<NguPhap> list = _db.NguPhaps.Where(x => x.IDDanhMucCon == idDanhMucCon).ToList();
			return list;
		}
	}
}
