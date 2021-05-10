using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laps_Remote.Vitals
{
	class Temp
	{
		/// <summary>
		/// Returns random Temperature for testing
		/// </summary>
		/// <returns>Returns Temperature</returns>
		public static float getRandomTemperature()
		{
			Random rnd = new Random();
			double value = (rnd.NextDouble() * (30 - 19) + 19);
			return (float)value;
		}
	}
}
