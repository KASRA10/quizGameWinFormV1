// Ignore Spelling: FRM

using System;
using System.Windows.Forms;

namespace TenQuizQuestions
{
	public partial class Start_FRM : Form
	{
		#region PublicItems
		string github = "https://github.com/KASRA10";
		string website = "https://kasra10design.com/";
		#endregion
		public Start_FRM()
		{
			InitializeComponent();
		}

		private void GitHub_LBLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				// Use Process.Start to open the URL in the default browser  
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = github,
					UseShellExecute = true // Ensures it uses the default browser  
				});
			}
			catch (Exception ex)
			{
				// Handle exceptions, such as when a browser is unavailable  
				DialogResult result = MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WebSite_LBLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				// Use Process.Start to open the URL in the default browser  
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = website,
					UseShellExecute = true // Ensures it uses the default browser  
				});
			}
			catch (Exception ex)
			{
				// Handle exceptions, such as when a browser is unavailable  
				DialogResult result = MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Start_BTN_Click(object sender, EventArgs e)
		{
			Game_FRM form = new Game_FRM();
			this.Hide();
			form.Show();
		}
	}
}
