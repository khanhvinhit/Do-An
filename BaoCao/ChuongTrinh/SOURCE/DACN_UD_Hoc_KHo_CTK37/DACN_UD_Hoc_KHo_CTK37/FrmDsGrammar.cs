using System;
using System.Drawing;
using System.Linq;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DevExpress.XtraEditors;

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
			flpGrammar.Controls.Clear();
			foreach (BaiHoc item in BaiHocDao.Instance.LoadNguPhap())
			{
				SimpleButton btn = new SimpleButton() { Width = 200, Height = 60};
                btn.Text = "Bài " + item.ID.ToString() + ": " + item.TenViet;
				btn.Click += btn_Click;
				btn.Tag = item;
				btn.Font = new Font("TNKeyUni-Arial", 8F, FontStyle.Bold);
				//btn.Image = ((Image)(resources.GetObject("SimpleButton1.Image")));
				btn.ImageLocation = ImageLocation.MiddleLeft;
				btn.Location = new Point(81, 61);

				flpGrammar.Controls.Add(btn);
			}

		}


		void btn_Click(object sender, EventArgs e)
		{
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