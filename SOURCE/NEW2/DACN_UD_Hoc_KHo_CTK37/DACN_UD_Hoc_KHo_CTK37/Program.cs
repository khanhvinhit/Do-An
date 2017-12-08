using System;
using System.Windows.Forms;
using DACN_UD_Hoc_KHo_CTK37.DAO;
using DACN_UD_Hoc_KHo_CTK37.GUI;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors.Controls;

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

			BonusSkins.Register();
			SkinManager.EnableFormSkins();//
			Localizer.Active = new TuyChinhDevExpress("&Hủy bỏ", "&Hủy", "&Chấp nhận", "&Không", "&Đóng", "&Thử lại", "&Có");
			Application.Run(new FrmUdHoc());
		}
	}
}
