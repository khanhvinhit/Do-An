using System;
using System.Drawing;
using System.Linq;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace DACN_UD_Hoc_KHo_CTK37
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
			flpGrammar.Enabled = false;
			flpGrammar.Controls.Clear();
			int i = 0;
			foreach (BaiHoc item in BaiHocDao.Instance.LoadNguPhap())
			{
				i++;
				SimpleButton btn = new SimpleButton() { Width = 200, Height = 60};
                btn.Text = "Bài: " + i + "\n" + item.TenViet;
				btn.Click += btn_Click;
				btn.Tag = item;
				btn.Font = new Font("TNKeyUni-Arial", 8F, FontStyle.Bold);
				//btn.Image = ((Image)(resources.GetObject("SimpleButton1.Image")));
				btn.ImageLocation = ImageLocation.MiddleLeft;
				btn.Location = new Point(85, 61);

				flpGrammar.Controls.Add(btn);
			}
			flpGrammar.Enabled = true;
			animator.Show(flpGrammar);
		}


		void btn_Click(object sender, EventArgs e)
		{
			frmDictionary frm = Application.OpenForms.OfType<frmDictionary>().FirstOrDefault();
			if (frm != null)
			{
				frm.Close();
			}
			SimpleButton simpleButton = sender as SimpleButton;
			if (simpleButton != null)
			{
				BaiHoc baiHoc = (simpleButton.Tag as BaiHoc);
				FrmBaiHocChiTiet f = new FrmBaiHocChiTiet(baiHoc.ID);
				//f.MdiParent = this;
				f.Text = "Học ngữ pháp";
				f.ShowDialog();
			}
		}
	}
}