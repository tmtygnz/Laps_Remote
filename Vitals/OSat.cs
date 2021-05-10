using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laps_Remote.Vitals
{
	class OSat
	{
		/// <summary>
		/// Returns random OSat for testing
		/// </summary>
		/// <returns>Returns OSat</returns>
		public static int getRandomOsat()
		{
			Random rnd = new Random();
			return rnd.Next(10, 50);
		}
	}
}
