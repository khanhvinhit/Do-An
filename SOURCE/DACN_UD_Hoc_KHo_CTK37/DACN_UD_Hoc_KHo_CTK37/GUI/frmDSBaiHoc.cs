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
    public partial class FrmDsBaiHoc : XtraForm
    {

        public FrmDsBaiHoc()
        {
            InitializeComponent();
            LoadBaiHoc();
        }


        void LoadBaiHoc()
        {
            try
            {
                flpBaiHoc.Controls.Clear();
                int i = 0;
                foreach (BaiHoc item in BaiHocDao.Instance.LoadBaiHoc())
                {
                    i++;
                    SimpleButton btn = new SimpleButton() { Width = 244, Height = 60 };
                    btn.Text = "Bài " + i + ": \n" + item.TenKHo + "\n" + item.TenViet;
                    btn.Click += btn_Click;
                    btn.Tag = item;
                    btn.Font = new Font("TNKeyUni-Arial", 8F, FontStyle.Bold);
                    flpBaiHoc.Controls.Add(btn);
                    btn.ToolTip = Resources.nhan_de_xem_chi_tiet_bai_so + i;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.error_connectionstring, Resources.thong_bao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            FrmDictionary frm = Application.OpenForms.OfType<FrmDictionary>().FirstOrDefault();
            if (frm != null)frm.Close();
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