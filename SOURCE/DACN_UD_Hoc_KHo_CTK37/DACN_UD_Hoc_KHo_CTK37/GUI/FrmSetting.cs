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
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (txtServerName.Text != "")
			{
				try
				{
					string file = string.Concat(Application.StartupPath, "\\DACN_UD_Hoc_KHo_CTK37.exe.Config"); //the application configuration file name
					XmlTextReader reader = new XmlTextReader(file);
					XmlDocument doc = new XmlDocument();
					doc.Load(reader);
					reader.Close();
					string nodeRoute = string.Concat("connectionStrings/add");

					XmlNode cnnStr = null;
					XmlElement root = doc.DocumentElement;
					XmlNodeList Settings = root.SelectNodes(nodeRoute);
					for (int i = 0; i < Settings.Count; i++)
					{
						cnnStr = Settings[i];
						if (cnnStr.Attributes["name"].Value.Equals("HocKHoEntities"))
							break;
						cnnStr = null;
					}

					string cbb = "metadata=res://*/DTO.DATADBContext.csdl|res://*/DTO.DATADBContext.ssdl|res://*/DTO.DATADBContext.msl;provider=System.Data.SqlClient;provider connection string='data source=" + txtServerName.Text + ";initial catalog=HocKHo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;'";

					cnnStr.Attributes["connectionString"].Value = cbb;
					cnnStr.Attributes["providerName"].Value = "System.Data.EntityClient";
					doc.Save(file);

					SqlConnection conn = new SqlConnection("Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=master;integrated security=True;");
					conn.Open();

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
					addServer(this, new EventArgs());
				}
				catch (Exception)
				{
					if (MessageBox.Show("Lỗi! Server Name không đúng hoặc file sql không tồn tại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
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
