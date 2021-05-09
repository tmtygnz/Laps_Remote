using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laps_Remote.Vitals
{
	class Resp
	{
		public static float getRandomResp()
		{
			Random rnd = new Random();
			double value = (rnd.NextDouble() * (40 - 10) + 10);
			return (float)value;
		}
	}
}
