using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	public partial class FrmLuyenTap : DevExpress.XtraEditors.XtraForm
	{
		private int _iDBaiHoc;
		private int soLT = 0;
		private int idLT = 0;
		int stt = 1;
		public int IdBaiHoc
		{
			get { return _iDBaiHoc; }
			set { _iDBaiHoc = value; LoadLuyenTap(_iDBaiHoc); }
		}
		public FrmLuyenTap(int iDBaiHoc)
		{
			InitializeComponent();
			IdBaiHoc = iDBaiHoc;
		}

		#region method

		private void LoadLuyenTap(int idBaiHoc)
		{
			
		}
		#endregion
	}
}