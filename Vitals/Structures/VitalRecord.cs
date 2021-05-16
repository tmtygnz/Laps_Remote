using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laps_Remote.Vitals.Structures
{
	struct VitalRecord
	{
		public List<Dictionary<string, string>> Time;
		public List<Dictionary<string, float>> Temp;
		public List<Dictionary<string, int>> RespRate;
		public List<Dictionary<string, int>> Hr;
		public List<Dictionary<string, int>> Spo;
	}
}