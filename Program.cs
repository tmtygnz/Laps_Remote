using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laps_Remote.Logging;
using Laps_Remote.Utils;

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
			Threads.init();
			Logger.init();
			Logger.log("Init", DateTime.UtcNow, Level.Trace);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Screens.Main());
		}
	}
}
