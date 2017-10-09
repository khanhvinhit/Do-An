using System;
using DevExpress.XtraSplashScreen;

namespace DACN_UD_Hoc_KHo_CTK37.GUI
{
	public partial class WaitForm : SplashScreen
	{
		public WaitForm()
		{
			InitializeComponent();
		}

		#region Overrides

		public override void ProcessCommand(Enum cmd, object arg)
		{
			base.ProcessCommand(cmd, arg);
		}

		#endregion

		public enum SplashScreenCommand
		{
		}
	}
}