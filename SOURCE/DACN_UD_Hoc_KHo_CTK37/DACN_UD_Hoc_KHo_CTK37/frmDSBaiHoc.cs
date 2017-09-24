using System;
using System.Drawing;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DACN_UD_Hoc_KHo_CTK37
{
	public partial class FrmDsBaiHoc : XtraForm
	{

		public FrmDsBaiHoc()
		{
			InitializeComponent();
			LoadBaiHoc();
		}


		void LoadBaiHoc()
		{
			flpBaiHoc.Controls.Clear();
			int i=0;
			foreach (BaiHoc item in BaiHocDao.Instance.LoadBaiHoc())
			{
				i++;
				SimpleButton btn = new SimpleButton() { Width = 200, Height = 60 };
				btn.Text = "Bài " + i + ": \n" + item.TenKHo + "\n" + item.TenViet;
				btn.Click += btn_Click;
				btn.Tag = item;
				btn.Font = new Font("TNKeyUni-Arial", 8F, FontStyle.Bold);
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDsBaiHoc));
				btn.ImageLocation = ImageLocation.MiddleLeft;
				btn.Location = new Point(81, 61);
				flpBaiHoc.Controls.Add(btn);
			}
		}

		void btn_Click(object sender, EventArgs e)
		{
			SimpleButton simpleButton = sender as SimpleButton;
			if (simpleButton != null)
			{
				BaiHoc baiHoc = (simpleButton.Tag as BaiHoc);
				FrmBaiHocChiTiet f = new FrmBaiHocChiTiet(baiHoc.ID);

				f.Text = f.Text + " số " + baiHoc.ID;
				//f. = this;
				f.Text = "Bài học";
				f.ShowDialog();
			}
		}
	}
}