using System;
using System.Drawing;
using System.Linq;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.GUI;

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
			try
			{
				flpGrammar.Enabled = false;
				flpGrammar.Controls.Clear();
				int i = 0;
				foreach (DanhMuc item in DanhMucDao.Instance.LoadNguPhap())
				{
					i++;
					foreach (var itemnp in DanhMucConDao.Instance.DanhMucConLoad(item.ID))
					{
						SimpleButton btn = new SimpleButton() { Width = 245, Height = 60 };
						btn.Text = "Bài: " + i + "\n" + itemnp.Ten;
						btn.Click += btn_Click;
						btn.Tag = itemnp;
						btn.Font = new Font("TNKeyUni-Arial", 8F, FontStyle.Bold);
						System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDsBaiHoc));
						btn.ImageLocation = ImageLocation.MiddleLeft;
						btn.Location = new Point(85, 61);

						flpGrammar.Controls.Add(btn);
					}


				}
				flpGrammar.Enabled = true;
				//animator.Show(flpGrammar);
			}
			catch (Exception)
			{
				MessageBox.Show("Không thể kết nối dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

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
				DanhMucCon nguphap = (simpleButton.Tag as DanhMucCon);
				FrmGrammar f = new FrmGrammar(nguphap.ID);
				f.Text = "Học ngữ pháp";
				f.ShowDialog();
			}
		}
	}
}