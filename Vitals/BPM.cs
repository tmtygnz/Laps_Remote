using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laps_Remote.Vitals
{
	class BPM
	{
		/// <summary>
		/// Returns a random BPM for testing
		/// </summary>
		/// <returns>Returns BPM</returns>
		public static int randomBPM()
		{
			Random rnd = new Random();
			return rnd.Next(90, 100);
		}
	}
}
