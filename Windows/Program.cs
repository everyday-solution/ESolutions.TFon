using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ESolutions.TFon.Windows
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			try
			{
				Tapi.TapiController.Default.StartMonitoringPhones();
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
			finally
			{
				Tapi.TapiController.Default.StopMonitoringPhones();
			}
		}
	}
}
