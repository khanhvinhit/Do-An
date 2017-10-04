using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DACN_UD_Hoc_KHo_CTK37.DTO;

namespace DACN_UD_Hoc_KHo_CTK37.DAO
{
	public class NguPhapDAO
	{
		private readonly HocKHoEntities _db = new HocKHoEntities();
		private static NguPhapDAO _instance;

		public static NguPhapDAO Instance
		{
			get
			{
				if (_instance == null) _instance = new NguPhapDAO();
				return _instance;
			}
			private set { NguPhapDAO._instance = value; }
		}

		private NguPhapDAO() { }
	}
}
