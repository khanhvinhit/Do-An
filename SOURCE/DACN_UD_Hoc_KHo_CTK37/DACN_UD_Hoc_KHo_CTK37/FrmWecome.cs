using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DACN_UD_Hoc_KHo_CTK37
{
	public partial class FrmWecome : XtraForm
	{
		public FrmWecome()
		{
			InitializeComponent();
			picE.Image = null;
			animator.Hide(picE);
			Load();
		}

		private void ShowImg()
		{
			//animator.WaitAllAnimations();
			string _filepath = Application.StartupPath;
			Image image = Image.FromFile(_filepath + "\\App_Data\\Images\\bg.jpg");
			picE.Image = image;
			//animator.Show(picE);
			//picE.Enabled = true;
		}

		private void Load()
		{
			ShowImg();
			picE.Enabled = true;
			animator.Show(picE);
		}

	}
}