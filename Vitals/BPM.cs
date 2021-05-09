using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laps_Remote.Vitals
{
	class BPM
	{
		public static float randomBPM()
		{
			Random rnd = new Random();
			double value = (rnd.NextDouble() * (100 - 0) + 0);
			return (float)value;
		}
	}
}
