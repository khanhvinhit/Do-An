using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DACN_UD_Hoc_KHo_CTK37.Properties;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	public partial class FrmDsGrammar : XtraForm
	{
		readonly HocKHoEntities _db = new HocKHoEntities();
		public FrmDsGrammar()
		{
			InitializeComponent();
			LoadGrammar();
		}


		void LoadGrammar()
		{
			try
			{
				flpGrammar.Controls.Clear();
				int i = 0;
				foreach (DanhMuc item in DanhMucDao.Instance.LoadNguPhap())
				{
					i++;
					foreach (var itemnp in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						SimpleButton btn = new SimpleButton() { Width = 244, Height = 60 };
						btn.Text = "Bài: " + i + "\n" + itemnp.Ten;
						btn.Click += btn_Click;
						btn.Tag = itemnp;
						btn.Font = new Font("TNKeyUni-Arial", 8F, FontStyle.Bold);
						flpGrammar.Controls.Add(btn);
                        btn.ToolTip = Resources.nha_de_xem_ngu_phap + i;
                    }
				}
			}
			catch (Exception)
			{
				XtraMessageBox.Show(this, "Không thể kết nối dữ liệu.", "Thông báo", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
        }

        
        void btn_Click(object sender, EventArgs e)
		{
			FrmDictionary frm = Application.OpenForms.OfType<FrmDictionary>().FirstOrDefault();
			if (frm != null)frm.Close();
			SimpleButton simpleButton = sender as SimpleButton;
			if (simpleButton != null)
			{
				DanhMucCon nguphap = (simpleButton.Tag as DanhMucCon);
				FrmGrammar f = new FrmGrammar(nguphap.ID);
				f.Text = "Học ngữ pháp";
				f.ShowDialog();
			}
		}
	}
}