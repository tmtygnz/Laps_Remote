using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laps_Remote.Vitals
{
	class Resp
	{
		/// <summary>
		/// Returns random RespRate for testing
		/// </summary>
		/// <returns>Returns RespRate</returns>
		public static int getRandomResp()
		{
			Random rnd = new Random();
			return rnd.Next(12, 16);
		}
	}
}
