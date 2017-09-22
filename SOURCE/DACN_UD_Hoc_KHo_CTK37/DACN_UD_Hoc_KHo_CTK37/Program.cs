using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace DACN_UD_Hoc_KHo_CTK37
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");//
			Application.Run(new FrmUdHoc());
		}
	}
}
