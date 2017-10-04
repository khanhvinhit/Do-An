using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DACN_UD_Hoc_KHo_CTK37.DTO;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class AmThanhDAO
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static AmThanhDAO _instance;

		public static AmThanhDAO Instance
		{
			get
			{
				if (_instance == null) _instance = new AmThanhDAO();
				return _instance;
			}
			private set { AmThanhDAO._instance = value; }
		}

		private AmThanhDAO() { }

		public AmThanh LoadAmThanhs(int idAT)
		{
			return _db.AmThanhs.Find(idAT);
		}
	}
}
