using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	public partial class FrmWecome : XtraForm
	{
		public FrmWecome()
		{
			InitializeComponent();
			picE.Image = null;LoadBt();
		}

		private void ShowImg()
		{
			
			string filepath = Application.StartupPath;
			Image image = Image.FromFile(filepath + "\\App_Data\\Images\\bg.jpg");
			picE.Image = image;
		}

		private void LoadBt()
		{
			ShowImg();
			picE.Enabled = true;
		}

	}
}