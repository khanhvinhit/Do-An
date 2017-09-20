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
			foreach (BaiHoc item in BaiHocDao.Instance.LoadBaiHoc())
			{
				if (item.TenViet != "Ngữ pháp"||item.TenViet != "NGỮ PHÁP")
				{
					SimpleButton btn = new SimpleButton() { Width = 200, Height = 60 };
					if (item.TenKHo != null)
					{
						btn.Text = "Bài " + item.ID.ToString() + ": " + item.TenKHo + "\n" + item.TenViet;
					}
					else
					{
						btn.Text = "Bài " + item.ID.ToString() + ": " + item.TenViet;
					}
					btn.Click += btn_Click;
					btn.Tag = item;
					btn.Font = new Font("TNKeyUni-Arial", 8F, FontStyle.Bold);
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDsBaiHoc));
					btn.Image = ((System.Drawing.Image)(resources.GetObject("btnDictionary.Glyph")));
					btn.ImageLocation = ImageLocation.MiddleLeft;
					btn.Location = new Point(81, 61);
					flpBaiHoc.Controls.Add(btn);
				}
				
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