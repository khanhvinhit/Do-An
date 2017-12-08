using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using DACN_UD_Hoc_KHo_CTK37.DTO;
using DevExpress.XtraSplashScreen;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace DACN_UD_Hoc_KHo_CTK37
{
	public partial class FrmSetting : Form
	{
		private event EventHandler addServer;
		public event EventHandler AddServer
		{
			add { addServer += value; }
			remove { addServer -= value; }
		}
		public FrmSetting()
		{
			InitializeComponent();
			txtServerName.Focus();
		}

		void ChangeXml(string server, string user, string pass)
		{
			string con = user != ""
					? "data source=" + server + ";initial catalog=HocKHo;User ID=" + user + ";Password=" + pass + ";integrated security=True;"
					: "data source=" + server + ";initial catalog=HocKHo;integrated security=True;";
			try
			{
				XmlDocument XmlDoc = new XmlDocument();
				XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
				foreach (XmlElement xElement in XmlDoc.DocumentElement)
				{
					if (xElement.Name == "connectionStrings")
					{
						xElement.FirstChild.Attributes["connectionString"].Value = con + "MultipleActiveResultSets=True;App=EntityFramework;";
						xElement.FirstChild.Attributes["providerName"].Value = "System.Data.SqlClient";
					}
				}
				XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

			}
			catch (Exception)
			{
				if (MessageBox.Show("Lỗi! Không thể kết nối dữ liệu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
				{
					txtServerName.ResetText();
					txtServerName.Focus();
				}
				else
				{
					this.Close();
				}
			}
		}

		void CreateDatabase(string server, string user, string pass)
		{
			string conne = user != ""
					? "Data Source=" + server + ";Initial Catalog=master;User ID=" + user + ";Password=" + pass + ";integrated security=True;"
					: "Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=master;integrated security=True;";
			string con = user != ""
					? "data source=" + server + ";initial catalog=HocKHo;User ID=" + user + ";Password=" + pass + ";integrated security=True;"
					: "data source=" + server + ";initial catalog=HocKHo;integrated security=True;";

			try
			{
				SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(con);
				string database = builder.InitialCatalog;
				using (SqlConnection conn = new SqlConnection(con))
				{
					conn.Open();
					String sqlCommandText = "USE [master] GO ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE GO" +
						"DROP DATABASE [" + database + "] GO";
					SqlCommand sqlCommand = new SqlCommand(sqlCommandText, conn);
					sqlCommand.ExecuteNonQuery();
					conn.Close();
					conn.Dispose();
				}

				using (SqlConnection conn = new SqlConnection(conne))
				{
					string script = File.ReadAllText(Application.StartupPath + "/Data/data.sql");

					// split script on GO command
					IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
					foreach (string commandString in commandStrings)
					{
						if (commandString.Trim() != "")
						{
							new SqlCommand(commandString, conn).ExecuteNonQuery();
						}
					}
					conn.Close();
					conn.Dispose();
				}

			}
			catch (Exception)
			{
				if (MessageBox.Show("Lỗi! Không thể kết nối dữ liệu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
				{
					txtServerName.ResetText();
					txtServerName.Focus();
				}
				else
				{
					this.Close();
				}
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (txtServerName.Text != "")
			{
				ChangeXml(txtServerName.Text.Trim(), txtUser.Text.Trim(), txtPass.Text.Trim());
				CreateDatabase(txtServerName.Text.Trim(), txtUser.Text.Trim(), txtPass.Text.Trim());
				addServer(this, new EventArgs());
			}
			else
			{
				if (MessageBox.Show("Vui lòng nhập Server Name của Sql Server!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
				{
					txtServerName.Focus();
				}
				else
				{
					this.Close();
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
			{
				FileName = Application.StartupPath + "\\Data\\tnkey",
				UseShellExecute = true,
				Verb = "open"
			});
		}

		private void txtServerName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnOk.PerformClick();
			}
		}
	}
}
