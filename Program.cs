using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laps_Remote.Logging;

namespace Laps_Remote
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			logger.init();
			logger.log("Logger init", DateTime.UtcNow, Level.Trace);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Screens.Main());
		}
	}
}
