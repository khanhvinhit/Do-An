using System;
using System.Drawing;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.Properties;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	public partial class FrmWecome : XtraForm
	{
		public FrmWecome()
		{
			InitializeComponent();
			picE.Image = null; LoadBt();
		}

		private void ShowImg()
		{
			try
			{
				string filepath = Application.StartupPath;
				Image image = Image.FromFile(filepath + "\\App_Data\\Images\\bg.jpg");
				picE.Image = image;
			}
			catch (Exception)
			{
				picE.Image = null;
				this.Controls.Remove(picE);
			}

		}

		private void LoadBt()
		{
			ShowImg();
			picE.Enabled = true;
		}

	}
}